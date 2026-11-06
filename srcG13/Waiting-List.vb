Public Class Waiting_List

    Private Sub Waiting_List_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' โหลดข้อมูลทั้งหมดตอนเปิดฟอร์ม
        Me.Waiting_ListTableAdapter.Fill(Me.DataDictionaryDataSet.Waiting_List)
        Waiting_ListDataGridView.DataSource = Me.DataDictionaryDataSet.Waiting_List
    End Sub

    ' ค้นหาตาม Patient ID
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Try
            Dim searchText As String = txtPatientID.Text.Trim()

            If searchText = "" Then
                Me.Waiting_ListTableAdapter.Fill(Me.DataDictionaryDataSet.Waiting_List)
                Waiting_ListDataGridView.DataSource = Me.DataDictionaryDataSet.Waiting_List
            Else
                Dim dv As New DataView(Me.DataDictionaryDataSet.Waiting_List)
                dv.RowFilter = $"Convert(P_ID, 'System.String') LIKE '%{searchText}%'"
                Waiting_ListDataGridView.DataSource = dv
            End If
        Catch ex As Exception
            MessageBox.Show("Search error: " & ex.Message)
        End Try
    End Sub

    ' แก้ไขข้อมูล → ใช้แก้ตรง DataGridView แล้วกดปุ่ม Edit เพื่อ Save
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Try
            Me.Validate()
            Me.Waiting_ListBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.DataDictionaryDataSet)
            MessageBox.Show("บันทึกการแก้ไขเรียบร้อยแล้ว")
        Catch ex As Exception
            MessageBox.Show("Edit error: " & ex.Message)
        End Try
    End Sub

    ' ลบข้อมูล
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            If Waiting_ListDataGridView.CurrentRow IsNot Nothing Then
                Waiting_ListDataGridView.Rows.Remove(Waiting_ListDataGridView.CurrentRow)
                Me.Validate()
                Me.Waiting_ListBindingSource.EndEdit()
                Me.TableAdapterManager.UpdateAll(Me.DataDictionaryDataSet)
                MessageBox.Show("ลบข้อมูลเรียบร้อยแล้ว")
            End If
        Catch ex As Exception
            MessageBox.Show("Delete error: " & ex.Message)
        End Try
    End Sub

End Class
