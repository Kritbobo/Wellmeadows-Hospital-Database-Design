Public Class Payroll

    Private Sub Payroll_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' โหลดข้อมูล Payroll ทั้งหมดมาแสดง
        Me.PayrollTableAdapter.Fill(Me.DataDictionaryDataSet.Payroll)
        PayrollDataGridView.DataSource = Me.DataDictionaryDataSet.Payroll
    End Sub

    ' ปุ่ม Search ตาม StaffID
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Try
            Dim staffId As String = txtStaffID.Text.Trim()

            If staffId = "" Then
                ' ถ้าไม่ได้กรอกอะไร → แสดงข้อมูลทั้งหมด
                Me.PayrollTableAdapter.Fill(Me.DataDictionaryDataSet.Payroll)
            Else
                ' ใช้ DataView filter
                Dim dv As New DataView(Me.DataDictionaryDataSet.Payroll)
                dv.RowFilter = $"S_ID LIKE '%{staffId}%'"
                PayrollDataGridView.DataSource = dv
            End If

        Catch ex As Exception
            MessageBox.Show("Search error: " & ex.Message)
        End Try
    End Sub

    ' ปุ่ม Add (เพิ่มแถวใหม่)
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            Dim newRow As DataRow = Me.DataDictionaryDataSet.Payroll.NewRow()
            newRow("S_ID") = txtStaffID.Text
            newRow("Base_Salary") = txtBaseSalary.Text
            newRow("Pay_Method") = cmbPayMethod.Text
            newRow("Bank_Name") = cmbBankName.Text
            newRow("Bank_Number") = txtBankNumber.Text

            Me.DataDictionaryDataSet.Payroll.Rows.Add(newRow)
            MessageBox.Show("เพิ่มข้อมูลเรียบร้อยแล้ว (ยังไม่ Save)")
        Catch ex As Exception
            MessageBox.Show("Add error: " & ex.Message)
        End Try
    End Sub

    ' ปุ่ม Save (บันทึกข้อมูลกลับ Database)
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            Me.Validate()
            Me.PayrollBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.DataDictionaryDataSet)
            MessageBox.Show("บันทึกข้อมูลเรียบร้อยแล้ว")
        Catch ex As Exception
            MessageBox.Show("Save error: " & ex.Message)
        End Try
    End Sub

    ' ปุ่ม Delete (ลบแถวที่เลือก)
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            If PayrollDataGridView.CurrentRow IsNot Nothing Then
                PayrollDataGridView.Rows.Remove(PayrollDataGridView.CurrentRow)
                Me.Validate()
                Me.PayrollBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.DataDictionaryDataSet)
                MessageBox.Show("ลบข้อมูลเรียบร้อยแล้ว")
            End If
        Catch ex As Exception
            MessageBox.Show("Delete error: " & ex.Message)
        End Try
    End Sub

End Class
