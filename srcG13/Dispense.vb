Public Class Dispense

    Private Sub Dispense_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' โหลดข้อมูลทั้งหมดจาก View vw_Dispense_Report
        Me.Vw_Dispense_ReportTableAdapter.Fill(Me.DataDictionaryDataSet.vw_Dispense_Report)
        Vw_Dispense_ReportDataGridView.DataSource = Me.DataDictionaryDataSet.vw_Dispense_Report
    End Sub

    ' ปุ่ม Search (ค้นหาด้วย Patient ID)
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Try
            Dim searchText As String = txtPatientID.Text.Trim()

            If searchText = "" Then
                ' โหลดข้อมูลทั้งหมด
                Me.Vw_Dispense_ReportTableAdapter.Fill(Me.DataDictionaryDataSet.vw_Dispense_Report)
                Vw_Dispense_ReportDataGridView.DataSource = Me.DataDictionaryDataSet.vw_Dispense_Report
            Else
                ' กรองข้อมูลด้วย DataView
                Dim dv As New DataView(Me.DataDictionaryDataSet.vw_Dispense_Report)
                dv.RowFilter = $"Convert(P_ID, 'System.String') LIKE '%{searchText}%'"
                Vw_Dispense_ReportDataGridView.DataSource = dv
            End If

        Catch ex As Exception
            MessageBox.Show("Search error: " & ex.Message)
        End Try
    End Sub

    ' ปุ่ม Refresh (รีเซ็ตกล่องค้นหา + โหลดใหม่)
    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Try
            txtPatientID.Clear()
            Me.Vw_Dispense_ReportTableAdapter.Fill(Me.DataDictionaryDataSet.vw_Dispense_Report)
            Vw_Dispense_ReportDataGridView.DataSource = Me.DataDictionaryDataSet.vw_Dispense_Report
        Catch ex As Exception
            MessageBox.Show("Refresh error: " & ex.Message)
        End Try
    End Sub

End Class
