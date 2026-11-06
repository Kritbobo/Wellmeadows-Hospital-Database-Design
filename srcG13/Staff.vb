Public Class Staff
    Private Sub btnWorkshift_Click(sender As Object, e As EventArgs) Handles btnWorkshift.Click
        ' เปิดฟอร์ม Workshift โดยไม่ซ่อนหน้าปัจจุบัน
        Dim frm As New WorkShift()
        frm.Show()
    End Sub

    Private Sub btnManageStaff_Click(sender As Object, e As EventArgs) Handles btnManageStaff.Click
        ' เปิดฟอร์ม ManageStaff โดยไม่ซ่อนหน้าปัจจุบัน
        Dim frm As New ManageStaff()
        frm.Show()
    End Sub

    Private Sub btnStaffList_Click(sender As Object, e As EventArgs) Handles btnStaffList.Click
        ' เปิดฟอร์ม StaffList โดยไม่ซ่อนหน้าปัจจุบัน
        Dim frm As New StaffList()
        frm.Show()
    End Sub

    Private Sub btnStaffReport_Click(sender As Object, e As EventArgs) Handles btnStaffReport.Click
        ' เปิดฟอร์ม StaffReport โดยไม่ซ่อนหน้าปัจจุบัน
        Dim frm As New StaffReport()
        frm.Show()
    End Sub
End Class
