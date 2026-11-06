Public Class Requisition

    Private Sub btnRequisition_Click(sender As Object, e As EventArgs) Handles btnRequisition.Click
        ' เปิดฟอร์ม ManageRequisition
        Dim frm As New ManageRequisition()
        frm.Show()
    End Sub

    Private Sub btnRequisitionReport_Click(sender As Object, e As EventArgs) Handles btnRequisitionReport.Click
        ' เปิดฟอร์ม RequisitionReport
        Dim frm As New RequisitionReport()
        frm.Show()
    End Sub

End Class
