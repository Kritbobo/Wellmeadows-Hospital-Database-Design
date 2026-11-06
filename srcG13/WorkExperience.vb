Public Class WorkExperience

    Private Sub WorkExperience_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' โหลดข้อมูลทั้งหมดจากตาราง Work_Experience
        Me.Work_ExperienceTableAdapter.Fill(Me.DataDictionaryDataSet.Work_Experience)
    End Sub

    ' ค้นหาด้วย Staff ID
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Try
            Dim sid As String = S_IDTextBox.Text.Trim()

            If sid <> "" Then
                Work_ExperienceBindingSource.Filter = $"S_ID LIKE '%{sid}%'"
            Else
                Work_ExperienceBindingSource.RemoveFilter()
            End If

        Catch ex As Exception
            MessageBox.Show("Search error: " & ex.Message)
        End Try
    End Sub

    ' เพิ่มข้อมูลใหม่
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            Work_ExperienceBindingSource.AddNew()
        Catch ex As Exception
            MessageBox.Show("Add error: " & ex.Message)
        End Try
    End Sub

    ' บันทึกข้อมูล
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            Me.Validate()
            Work_ExperienceBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.DataDictionaryDataSet)
            MessageBox.Show("Data saved successfully.")
        Catch ex As Exception
            MessageBox.Show("Save error: " & ex.Message)
        End Try
    End Sub

    ' ลบข้อมูล
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            Work_ExperienceBindingSource.RemoveCurrent()
            Me.Validate()
            Work_ExperienceBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.DataDictionaryDataSet)
            MessageBox.Show("Data deleted successfully.")
        Catch ex As Exception
            MessageBox.Show("Delete error: " & ex.Message)
        End Try
    End Sub

End Class
