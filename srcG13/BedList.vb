Public Class BedList

    ' รับค่า W_ID มาจาก WardList (ถ้ามี)
    Public Property SelectedWardID As String
    Public Property SelectedWardName As String

    ' --- Escape single quote ป้องกัน error เวลา filter ---
    Private Function EscapeLike(value As String) As String
        If String.IsNullOrEmpty(value) Then Return value
        Return value.Replace("'", "''")
    End Function

    ' โหลดข้อมูลตาราง Bed
    Private Sub BedList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.BedTableAdapter.Fill(Me.DataDictionaryDataSet.Bed)

            If BedDataGridView.DataSource Is Nothing Then
                BedDataGridView.DataSource = BedBindingSource
            End If

            ' กรองทันทีถ้ามี SelectedWardID มาจาก WardList
            ApplyFilter()
        Catch ex As Exception
            MessageBox.Show("ไม่สามารถโหลดข้อมูล Bed ได้: " & ex.Message)
        End Try
    End Sub

    ' ปุ่มค้นหา
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        ApplyFilter()
    End Sub

    ' ฟังก์ชัน ApplyFilter รวม WardID + Keyword
    Private Sub ApplyFilter()
        Dim filters As New List(Of String)

        ' ถ้ามี W_ID จาก WardList ให้บังคับกรองด้วย
        If Not String.IsNullOrEmpty(SelectedWardID) Then
            filters.Add(String.Format("CONVERT(W_ID, 'System.String') = '{0}'", EscapeLike(SelectedWardID)))
        End If

        ' เงื่อนไขค้นหาตาม keyword
        Dim k As String = txtSearch1.Text.Trim()
        If k <> "" Then
            Dim kk As String = EscapeLike(k)
            filters.Add(String.Format(
                "(" &
                "CONVERT(B_ID, 'System.String') LIKE '%{0}%' OR " &
                "CONVERT(Bed_Number, 'System.String') LIKE '%{0}%' OR " &
                "CONVERT(Room_Number, 'System.String') LIKE '%{0}%' OR " &
                "B_Status LIKE '%{0}%'" &
                ")", kk))
        End If

        ' นำ filter มารวมกัน
        If filters.Count = 0 Then
            BedBindingSource.RemoveFilter()
        Else
            BedBindingSource.Filter = String.Join(" AND ", filters)
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs)

    End Sub
End Class
