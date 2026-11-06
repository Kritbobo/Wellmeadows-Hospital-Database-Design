Imports System.Data.SqlClient

Public Class Emergency_Contact

    Private Sub Emergency_Contact_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' โหลดข้อมูล EmergencyContact ลง DataGridView
        Me.EmergencyContactTableAdapter.Fill(Me.DataDictionaryDataSet.EmergencyContact)
    End Sub

    ' ปุ่ม Search
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Try
            Dim pid As String = P_IDTextBox.Text.Trim()

            If pid <> "" Then
                ' กรองจาก BindingSource
                EmergencyContactBindingSource.Filter = $"P_ID LIKE '%{pid}%'"
            Else
                EmergencyContactBindingSource.RemoveFilter()
            End If

        Catch ex As Exception
            MessageBox.Show("Search error: " & ex.Message)
        End Try
    End Sub

    ' ปุ่ม Add (เพิ่มแถวใหม่)
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            EmergencyContactBindingSource.AddNew()
        Catch ex As Exception
            MessageBox.Show("Add error: " & ex.Message)
        End Try
    End Sub

    ' ปุ่ม Save (บันทึกลง DB)
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            Me.Validate()
            EmergencyContactBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.DataDictionaryDataSet)
            MessageBox.Show("Data saved successfully.")
        Catch ex As Exception
            MessageBox.Show("Save error: " & ex.Message)
        End Try
    End Sub

    ' ปุ่ม Delete
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            EmergencyContactBindingSource.RemoveCurrent()
            Me.Validate()
            EmergencyContactBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.DataDictionaryDataSet)
            MessageBox.Show("Data deleted successfully.")
        Catch ex As Exception
            MessageBox.Show("Delete error: " & ex.Message)
        End Try
    End Sub

End Class
