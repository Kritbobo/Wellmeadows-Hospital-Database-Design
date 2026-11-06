Public Class ManageSupplies

    ' โหลดข้อมูลทั้งหมดตอนเปิดฟอร์ม
    Private Sub ManageSupplies_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.SuppliesTableAdapter.Fill(Me.DataDictionaryDataSet.Supplies)
        Catch ex As Exception
            MessageBox.Show("Load error: " & ex.Message)
        End Try
    End Sub

    ' ปุ่ม Search (ค้นหาตาม SU_ID)
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Try
            Dim sid As String = SU_IDTextBox.Text.Trim()
            If sid = "" Then
                MessageBox.Show("กรุณากรอก Supplies ID", "Search")
                Return
            End If

            ' ต้องมี Query FillByID ใน SuppliesTableAdapter
            Me.SuppliesTableAdapter.FillByID(Me.DataDictionaryDataSet.Supplies, sid)

            If SuppliesDataGridView.Rows.Count = 0 Then
                MessageBox.Show("ไม่พบข้อมูล", "Search")
            End If
        Catch ex As Exception
            MessageBox.Show("Search error: " & ex.Message)
        End Try
    End Sub

    ' ปุ่ม Add (Insert)
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            Dim newRow As DataRow = Me.DataDictionaryDataSet.Supplies.NewRow()

            newRow("SU_ID") = SU_IDTextBox.Text.Trim()
            newRow("SU_Name") = SU_NameTextBox.Text.Trim()
            newRow("SU_Type") = SU_TypeTextBox.Text.Trim()
            newRow("SU_Description") = SU_DescriptionTextBox.Text.Trim()
            newRow("Amount") = AmountTextBox.Text.Trim()

            Me.DataDictionaryDataSet.Supplies.Rows.Add(newRow)
            Me.SuppliesTableAdapter.Update(Me.DataDictionaryDataSet.Supplies)

            MessageBox.Show("เพิ่ม Supplies สำเร็จ", "Add")
        Catch ex As Exception
            MessageBox.Show("Add error: " & ex.Message)
        End Try
    End Sub

    ' ปุ่ม Save (Update)
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            Me.Validate()
            Me.SuppliesBindingSource.EndEdit()
            Me.SuppliesTableAdapter.Update(Me.DataDictionaryDataSet.Supplies)

            MessageBox.Show("บันทึกข้อมูลเรียบร้อยแล้ว", "Save")
        Catch ex As Exception
            MessageBox.Show("Save error: " & ex.Message)
        End Try
    End Sub

    ' ปุ่ม Delete
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            If SuppliesBindingSource.Current IsNot Nothing Then
                Dim confirm = MessageBox.Show("คุณต้องการลบข้อมูลนี้หรือไม่?", "Confirm", MessageBoxButtons.YesNo)
                If confirm = DialogResult.Yes Then
                    SuppliesBindingSource.RemoveCurrent()
                    Me.Validate()
                    Me.SuppliesBindingSource.EndEdit()
                    Me.SuppliesTableAdapter.Update(Me.DataDictionaryDataSet.Supplies)

                    MessageBox.Show("ลบข้อมูลสำเร็จ", "Delete")
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Delete error: " & ex.Message)
        End Try
    End Sub

End Class
