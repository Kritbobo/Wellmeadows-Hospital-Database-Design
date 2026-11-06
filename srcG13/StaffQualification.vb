Imports System.Data.SqlClient

Public Class StaffQualification

    ' 🔧 connection string (แก้ให้ตรงกับ SQL Server ของคุณ)
    Private connectionString As String = "Data Source=.;Initial Catalog=DataDictionary;Integrated Security=True"

    ' ====== ปุ่ม Search ======
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim staffID As String = txtStaffID.Text.Trim()

        If staffID = "" Then
            MessageBox.Show("กรุณากรอก Staff ID", "Search")
            Return
        End If

        Using conn As New SqlConnection(connectionString)
            Try
                conn.Open()
                Dim sql As String = "SELECT TOP 1 * FROM StaffQualification WHERE S_ID=@sid"
                Using cmd As New SqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@sid", staffID)

                    Using rdr As SqlDataReader = cmd.ExecuteReader()
                        If rdr.Read() Then
                            txtTypeQual.Text = rdr("Type_Qual").ToString()
                            dtpDateQual.Value = Convert.ToDateTime(rdr("Date_Qual"))
                            txtInstitution.Text = rdr("Institution").ToString()
                            MessageBox.Show("พบข้อมูลแล้ว", "Search")
                        Else
                            MessageBox.Show("ไม่พบข้อมูล", "Search")
                        End If
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Search error: " & ex.Message)
            End Try
        End Using
    End Sub

    ' ====== ปุ่ม Save (Update) ======
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim staffID As String = txtStaffID.Text.Trim()

        If staffID = "" Then
            MessageBox.Show("กรุณากรอก Staff ID", "Save")
            Return
        End If

        Using conn As New SqlConnection(connectionString)
            Try
                conn.Open()
                Dim sql As String = "UPDATE StaffQualification 
                                     SET Type_Qual=@type, Date_Qual=@date, Institution=@inst
                                     WHERE S_ID=@sid"

                Using cmd As New SqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@sid", staffID)
                    cmd.Parameters.AddWithValue("@type", txtTypeQual.Text.Trim())
                    cmd.Parameters.AddWithValue("@date", dtpDateQual.Value)
                    cmd.Parameters.AddWithValue("@inst", txtInstitution.Text.Trim())

                    Dim rows = cmd.ExecuteNonQuery()
                    If rows > 0 Then
                        MessageBox.Show("บันทึกข้อมูลสำเร็จ", "Save")
                    Else
                        MessageBox.Show("ไม่พบ Staff ID ที่ต้องการแก้ไข", "Save")
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show("Save error: " & ex.Message)
            End Try
        End Using
    End Sub

    ' ====== ปุ่ม Add (Insert) ======
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim staffID As String = txtStaffID.Text.Trim()

        If staffID = "" Then
            MessageBox.Show("กรุณากรอก Staff ID", "Add")
            Return
        End If

        Using conn As New SqlConnection(connectionString)
            Try
                conn.Open()
                Dim sql As String = "INSERT INTO StaffQualification (S_ID, Type_Qual, Date_Qual, Institution) 
                                     VALUES (@sid, @type, @date, @inst)"

                Using cmd As New SqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@sid", staffID)
                    cmd.Parameters.AddWithValue("@type", txtTypeQual.Text.Trim())
                    cmd.Parameters.AddWithValue("@date", dtpDateQual.Value)
                    cmd.Parameters.AddWithValue("@inst", txtInstitution.Text.Trim())

                    cmd.ExecuteNonQuery()
                    MessageBox.Show("เพิ่มข้อมูลใหม่สำเร็จ", "Add")
                End Using
            Catch ex As Exception
                MessageBox.Show("Add error: " & ex.Message)
            End Try
        End Using
    End Sub

    ' ====== ปุ่ม Delete ======
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim staffID As String = txtStaffID.Text.Trim()

        If staffID = "" Then
            MessageBox.Show("กรุณากรอก Staff ID", "Delete")
            Return
        End If

        Dim confirm = MessageBox.Show("คุณต้องการลบข้อมูลนี้หรือไม่?", "Confirm", MessageBoxButtons.YesNo)
        If confirm = DialogResult.No Then Return

        Using conn As New SqlConnection(connectionString)
            Try
                conn.Open()
                Dim sql As String = "DELETE FROM StaffQualification WHERE S_ID=@sid"

                Using cmd As New SqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@sid", staffID)

                    Dim rows = cmd.ExecuteNonQuery()
                    If rows > 0 Then
                        MessageBox.Show("ลบข้อมูลเรียบร้อยแล้ว", "Delete")
                        txtTypeQual.Clear()
                        txtInstitution.Clear()
                        txtStaffID.Clear()
                    Else
                        MessageBox.Show("ไม่พบข้อมูลที่ต้องการลบ", "Delete")
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show("Delete error: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub StaffBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.StaffBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataDictionaryDataSet)

    End Sub

    Private Sub StaffQualification_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataDictionaryDataSet.Staff' table. You can move, or remove it, as needed.
        Me.StaffTableAdapter.Fill(Me.DataDictionaryDataSet.Staff)

    End Sub
End Class
