Public Class Suppliers
    Private Sub btnManage_Click(sender As Object, e As EventArgs) Handles btnManage.Click
        ' เปิดฟอร์ม ManageSuppliers
        Dim frm As New ManageSuppliers()
        frm.Show()
    End Sub
End Class
