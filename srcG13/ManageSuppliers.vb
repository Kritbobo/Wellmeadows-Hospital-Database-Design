Public Class ManageSuppliers

    ' ====== โหลดข้อมูลทั้งหมด ======
    Private Sub ManageSuppliers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.SupplierTableAdapter.Fill(Me.DataDictionaryDataSet.Supplier)
        Catch ex As Exception
            MessageBox.Show("Load error: " & ex.Message)
        End Try
    End Sub

    ' ====== ปุ่ม Search (ค้นหา Supplier ID) ======
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Try
            Dim sid As String = SU_IDTextBox.Text.Trim()
            If sid = "" Then
                MessageBox.Show("กรุณากรอก Supplier ID", "Search")
                Return
            End If

            ' เพิ่ม Query FillByID ใน SupplierTableAdapter
            Me.SupplierTableAdapter.FillByID(Me.DataDictionaryDataSet.Supplier, sid)

            If SupplierDataGridView.Rows.Count = 0 Then
                MessageBox.Show("ไม่พบข้อมูล", "Search")
            End If
        Catch ex As Exception
            MessageBox.Show("Search error: " & ex.Message)
        End Try
    End Sub

    ' ====== ปุ่ม Add (Insert) ======
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Try
            Dim newRow As DataRow = Me.DataDictionaryDataSet.Supplier.NewRow()

            newRow("SU_ID") = SU_IDTextBox.Text.Trim()
            newRow("SU_Name") = SU_NameTextBox.Text.Trim()
            newRow("SP_Name") = SP_NameTextBox.Text.Trim()
            newRow("SP_Address") = SP_AddressTextBox.Text.Trim()
            newRow("SU_Tel") = SU_TelTextBox.Text.Trim()
            newRow("Type") = TextType.Text.Trim()

            Me.DataDictionaryDataSet.Supplier.Rows.Add(newRow)
            Me.SupplierTableAdapter.Update(Me.DataDictionaryDataSet.Supplier)

            MessageBox.Show("เพิ่ม Supplier สำเร็จ", "Add")
        Catch ex As Exception
            MessageBox.Show("Add error: " & ex.Message)
        End Try
    End Sub

    ' ====== ปุ่ม Save (Update) ======
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Try
            Me.Validate()
            Me.SupplierBindingSource.EndEdit()
            Me.SupplierTableAdapter.Update(Me.DataDictionaryDataSet.Supplier)

            MessageBox.Show("บันทึกการแก้ไขสำเร็จ", "Save")
        Catch ex As Exception
            MessageBox.Show("Save error: " & ex.Message)
        End Try
    End Sub

    ' ====== ปุ่ม Delete ======
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            If SupplierBindingSource.Current IsNot Nothing Then
                Dim confirm = MessageBox.Show("คุณต้องการลบข้อมูลนี้หรือไม่?", "Confirm", MessageBoxButtons.YesNo)
                If confirm = DialogResult.Yes Then
                    SupplierBindingSource.RemoveCurrent()
                    Me.Validate()
                    Me.SupplierBindingSource.EndEdit()
                    Me.SupplierTableAdapter.Update(Me.DataDictionaryDataSet.Supplier)

                    MessageBox.Show("ลบข้อมูลสำเร็จ", "Delete")
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Delete error: " & ex.Message)
        End Try
    End Sub

End Class
