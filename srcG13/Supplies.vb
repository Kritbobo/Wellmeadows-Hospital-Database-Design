Public Class Supplies

    Private Sub btnManageSupplies_Click(sender As Object, e As EventArgs) Handles btnManageSupplies.Click
        ' เปิดฟอร์ม ManageSupplies
        Dim frm As New ManageSupplies()
        frm.Show()
    End Sub

    Private Sub btnDispense_Click(sender As Object, e As EventArgs) Handles btnDispense.Click
        ' เปิดฟอร์ม Dispense
        Dim frm As New Dispense()
        frm.Show()
    End Sub

    Private Sub btnDispenseReport_Click(sender As Object, e As EventArgs) Handles btnDispenseReport.Click
        ' เปิดฟอร์ม DispenseReport
        Dim frm As New DispenseReport()
        frm.Show()
    End Sub

End Class
