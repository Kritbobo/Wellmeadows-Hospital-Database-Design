Public Class Patient

    Private Sub btnManagePatient_Click(sender As Object, e As EventArgs) Handles btnManagePatient.Click
        Dim manageForm As New Manage_Patient()
        manageForm.Show()
    End Sub

    Private Sub btnWaitinglist_Click(sender As Object, e As EventArgs) Handles btnWaitinglist.Click
        Dim waitingForm As New Waiting_List()
        waitingForm.Show()
    End Sub

    Private Sub btnInPatientReport_Click(sender As Object, e As EventArgs) Handles btnInPatientReport.Click
        Dim inReportForm As New In_Patient_Report()
        inReportForm.Show()
    End Sub

    Private Sub btnOutPatientReport_Click(sender As Object, e As EventArgs) Handles btnOutPatientReport.Click
        Dim outReportForm As New Out_Patient_Report()
        outReportForm.Show()
    End Sub

    Private Sub Patient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' สามารถใส่คำสั่งเริ่มต้น เช่น ตั้งค่า UI หรือโหลดข้อมูลเบื้องต้นได้ที่นี่
    End Sub

End Class