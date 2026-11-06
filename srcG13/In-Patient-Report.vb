Public Class In_Patient_Report

    Private Sub In_Patient_Report_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            LoadAllData()

            With InPatientReportDataGridView
                .AutoGenerateColumns = True
                .ReadOnly = True
                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            End With

        Catch ex As Exception
            MessageBox.Show("Load error: " & ex.Message)
        End Try
    End Sub

    ' โหลดข้อมูลทั้งหมด
    Private Sub LoadAllData()
        Me.Vw_InPatient_ReportTableAdapter.Fill(Me.DataDictionaryDataSet.vw_InPatient_Report)
        InPatientReportDataGridView.DataSource = Me.DataDictionaryDataSet.vw_InPatient_Report
    End Sub

    ' ปุ่ม Search
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        PerformSearch()
    End Sub

    ' ปุ่ม Refresh
    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Try
            txtPatientID.Text = ""   ' เคลียร์ช่องค้นหา
            LoadAllData()            ' โหลดข้อมูลใหม่ทั้งหมด
        Catch ex As Exception
            MessageBox.Show("Refresh error: " & ex.Message)
        End Try
    End Sub

    ' กด Enter ในช่อง Patient ID
    Private Sub txtPatientID_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPatientID.KeyDown
        If e.KeyCode = Keys.Enter Then
            PerformSearch()
            e.SuppressKeyPress = True ' กันเสียง beep
        End If
    End Sub

    ' ฟังก์ชันค้นหา
    Private Sub PerformSearch()
        Try
            Dim keyword As String = txtPatientID.Text.Trim()

            If keyword = "" Then
                LoadAllData()
            Else
                Dim dt As DataTable = Me.DataDictionaryDataSet.vw_InPatient_Report
                Dim dv As New DataView(dt)
                dv.RowFilter = $"CONVERT(P_ID, System.String) LIKE '%{keyword.Replace("'", "''")}%'"
                InPatientReportDataGridView.DataSource = dv
            End If

        Catch ex As Exception
            MessageBox.Show("Search error: " & ex.Message)
        End Try
    End Sub

End Class
