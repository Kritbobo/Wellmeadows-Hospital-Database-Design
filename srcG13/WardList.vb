Public Class WardList

    ' --- Escape single quote ป้องกัน error เวลา filter ---
    Private Function EscapeLike(value As String) As String
        If String.IsNullOrEmpty(value) Then Return value
        Return value.Replace("'", "''")
    End Function

    ' โหลดข้อมูลตาราง Ward
    Private Sub WardList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.WardTableAdapter.Fill(Me.DataDictionaryDataSet.Ward)

            ' ผูก DataGridView กับ BindingSource ถ้ายังไม่ได้ผูก
            If WardDataGridView.DataSource Is Nothing Then
                WardDataGridView.DataSource = WardBindingSource
            End If
        Catch ex As Exception
            MessageBox.Show("ไม่สามารถโหลดข้อมูล Ward ได้: " & ex.Message)
        End Try
    End Sub

    ' ปุ่มค้นหา
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim k As String = txtSearch1.Text.Trim()

        If k = "" Then
            WardBindingSource.RemoveFilter()
        Else
            Dim kk As String = EscapeLike(k)
            ' W_ID เป็นตัวเลข → ต้อง CONVERT เป็น String ก่อน LIKE
            WardBindingSource.Filter = String.Format(
                "(W_Name LIKE '%{0}%' OR CONVERT(W_ID, 'System.String') LIKE '%{0}%')",
                kk)
        End If
    End Sub

    ' ปุ่มเพิ่มวอร์ด (กรณีมีฟอร์ม Add)
    Private Sub btnAddWard_Click(sender As Object, e As EventArgs) Handles btnAddWard.Click
        Dim addWardForm As New WardList_AddWard()
        addWardForm.Show()
        Me.Hide()
    End Sub


End Class
