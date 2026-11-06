Public Class Ward
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnWardList.Click
        ' เปิดฟอร์ม WardList
        Dim wardListForm As New WardList()
        wardListForm.Show()
        Me.Hide() ' ซ่อนฟอร์มปัจจุบัน
    End Sub

    Private Sub btnBedList_Click(sender As Object, e As EventArgs) Handles btnBedList.Click
        ' เปิดฟอร์ม BedList
        Dim bedListForm As New BedList()
        bedListForm.Show()
        Me.Hide() ' ซ่อนฟอร์มปัจจุบัน
    End Sub

    Private Sub Ward_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class