Option Strict On
Option Explicit On

Imports System.Data.SqlClient  ' เพื่อจับ SqlException.Number ได้ชัดเจน

Public Class WardList_AddWard

    ' โหลดข้อมูลเบื้องต้น
    Private Sub WardList_AddWard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' โหลด Ward ไว้เช็ค PK ซ้ำ (ต้องมี WardTableAdapter และ DataDictionaryDataSet บนฟอร์ม)
        Me.WardTableAdapter.Fill(Me.DataDictionaryDataSet.Ward)

        ' ปุ่มลัด
        Me.AcceptButton = btnSave
        Me.CancelButton = btnCancel
    End Sub

    ' ให้พิมพ์ได้เฉพาะตัวเลขในช่องตัวเลข
    ' ผูกอีเวนต์ให้ TextBox ที่เป็นตัวเลขจริง ๆ (W_ID, Bed_Count, S_ID, B_ID)
    Private Sub txtWID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtWID.KeyPress
        NumericOnly_KeyPress(e)
    End Sub

    Private Sub txtBedCount_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBedCount.KeyPress
        NumericOnly_KeyPress(e)
    End Sub

    Private Sub txtSID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSID.KeyPress
        NumericOnly_KeyPress(e)
    End Sub

    Private Sub txtBID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBID.KeyPress
        NumericOnly_KeyPress(e)
    End Sub

    Private Sub NumericOnly_KeyPress(e As KeyPressEventArgs)
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    ' ตรวจความถูกต้องของฟอร์ม (ไม่บังคับ B_ID)
    Private Function ValidateForm() As Boolean
        Dim n As Integer

        If Not Integer.TryParse(txtWID.Text.Trim(), n) Then
            MessageBox.Show("กรุณากรอก Ward ID เป็นตัวเลข", "Validate", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtWID.Focus()
            Return False
        End If

        If String.IsNullOrWhiteSpace(txtWardName.Text) Then
            MessageBox.Show("กรุณากรอก Ward Name", "Validate", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtWardName.Focus()
            Return False
        End If

        If Not Integer.TryParse(txtBedCount.Text.Trim(), n) Then
            MessageBox.Show("กรุณากรอก Total Beds เป็นตัวเลข", "Validate", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtBedCount.Focus()
            Return False
        End If

        If Not Integer.TryParse(txtSID.Text.Trim(), n) Then
            MessageBox.Show("กรุณากรอก S_ID (Assigned Staff) เป็นตัวเลข", "Validate", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtSID.Focus()
            Return False
        End If

        ' B_ID: อนุญาตให้ว่าง → จะบันทึกเป็น NULL
        Dim tmp As Integer
        If txtBID.Text.Trim().Length > 0 AndAlso Not Integer.TryParse(txtBID.Text.Trim(), tmp) Then
            MessageBox.Show("B_ID (Bed ID) ต้องเป็นตัวเลข หรือเว้นว่าง", "Validate", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtBID.Focus()
            Return False
        End If

        Return True
    End Function

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If Not ValidateForm() Then Exit Sub

        Dim wid As Integer = CInt(txtWID.Text.Trim())
        Dim wname As String = txtWardName.Text.Trim()
        Dim tel As String = txtTel.Text.Trim()
        Dim bedCount As Integer = CInt(txtBedCount.Text.Trim())
        Dim sid As Integer = CInt(txtSID.Text.Trim())

        ' B_ID: ว่าง = NULL, มีค่า = จำนวนเต็ม
        Dim hasBid As Boolean = txtBID.Text.Trim().Length > 0
        Dim bidNullable As Integer? = If(hasBid, CInt(txtBID.Text.Trim()), CType(Nothing, Integer?))

        Try
            ' กัน PK ซ้ำด้วย PrimaryKey lookup (ต้องตั้ง PrimaryKey ของ DataTable ไว้แล้ว)
            ' ใน Typed DataSet ปกติจะมีเมธอด FindBy<PK>
            Dim existing = Me.DataDictionaryDataSet.Ward.FindByW_ID(wid)
            If existing IsNot Nothing Then
                MessageBox.Show("Ward ID นี้มีอยู่แล้ว", "Duplicate", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtWID.Focus()
                Exit Sub
            End If

            ' *** สำคัญ: แนะนำให้บันทึกโดยไม่บังคับ B_ID (NULL) ก่อน เพื่อเลี่ยงวงจร FK ***
            ' TableAdapter ที่ Visual Studio สร้างให้จะรองรับ Nullable(Of Integer) สำหรับคอลัมน์ที่รับ NULL
            Dim rows As Integer = Me.WardTableAdapter.Insert(
                wid,               ' @W_ID (int, PK)
                tel,               ' @W_Tel (nvarchar)
                bedCount,          ' @Bed_Count (int)
                wname,             ' @W_Name (nvarchar)
                sid,               ' @S_ID (int, FK -> Staff.S_ID)
                If(bidNullable.HasValue, CType(bidNullable.Value, Integer?), Nothing) ' @B_ID (int, NULL ok)
            )

            If rows > 0 Then
                MessageBox.Show("บันทึกสำเร็จ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.WardTableAdapter.Fill(Me.DataDictionaryDataSet.Ward)
                Me.DialogResult = DialogResult.OK
                Me.Close()
            Else
                MessageBox.Show("บันทึกไม่สำเร็จ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

        Catch ex As SqlException
            ' แยก message ให้ตรงกับสาเหตุจริง
            Select Case ex.Number
                Case 2627, 2601 ' PK/Unique ซ้ำ
                    MessageBox.Show("Ward ID ซ้ำในฐานข้อมูล", "Duplicate Key", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    txtWID.Focus()

                Case 547 ' FK ผิด (เช่น S_ID ไม่มีอยู่ หรือ B_ID ไม่มีอยู่ใน Bed)
                    ' ชี้แนะ: บันทึกโดยไม่กรอก B_ID ก่อน แล้วค่อยไปเพิ่มเตียงใน BedList ค่อยมา Update ทีหลัง
                    MessageBox.Show(
                        "ข้อมูลอ้างอิงไม่ถูกต้อง (Foreign Key). " & vbCrLf &
                        "- ตรวจว่า S_ID มีอยู่จริงในตาราง Staff หรือไม่" & vbCrLf &
                        "- ถ้า B_ID ทำให้ error ให้เว้นว่าง (NULL) ก่อน แล้วไปเพิ่มเตียงใน BedList ค่อยกลับมา Update",
                        "Foreign Key Error (547)", MessageBoxButtons.OK, MessageBoxIcon.Error)

                Case Else
                    MessageBox.Show("เกิดข้อผิดพลาด (SQL " & ex.Number.ToString() & "): " & ex.Message,
                                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Select

        Catch ex As Exception
            MessageBox.Show("เกิดข้อผิดพลาด: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

End Class
