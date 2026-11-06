Public Class MainMenu
    Private Sub btnStaff_Click(sender As Object, e As EventArgs) Handles btnStaff.Click
        Dim staffForm As New Staff()
        staffForm.Show()
    End Sub

    Private Sub btnPatient_Click(sender As Object, e As EventArgs) Handles btnPatient.Click
        Dim patientForm As New Patient()
        patientForm.Show()
    End Sub

    Private Sub btnWard_Click(sender As Object, e As EventArgs) Handles btnWard.Click
        Dim patientForm As New Ward()
        patientForm.Show()
    End Sub

    Private Sub btnSupplies_Click(sender As Object, e As EventArgs) Handles btnSupplies.Click
        Dim suppliesForm As New Supplies()
        suppliesForm.Show()
    End Sub

    Private Sub btnSuppliers_Click(sender As Object, e As EventArgs) Handles btnSuppliers.Click
        Dim suppliersForm As New Suppliers()
        suppliersForm.Show()
    End Sub

    Private Sub btnRequisition_Click(sender As Object, e As EventArgs) Handles btnRequisition.Click
        Dim requisitionForm As New Requisition()
        requisitionForm.Show()
    End Sub

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        Dim dashboardForm As New Dashboard()
        dashboardForm.Show()
    End Sub
End Class