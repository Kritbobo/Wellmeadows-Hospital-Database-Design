Public Class Out_Patient_Report

    Private Sub Out_Patient_Report_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            LoadAllData()

            With Vw_OutPatient_ReportDataGridView
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
        Me.Vw_OutPatient_ReportTableAdapter.Fill(Me.DataDictionaryDataSet.vw_OutPatient_Report)
        Vw_OutPatient_ReportDataGridView.DataSource = Me.DataDictionaryDataSet.vw_OutPatient_Report
    End Sub

    ' ปุ่ม Search (ค้นหาเฉพาะ Patient ID)
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        PerformSearchByID()
    End Sub

    ' ปุ่ม Filter (ค้นหาทุกคอลัมน์)
    Private Sub btnFilter_Click(sender As Object, e As EventArgs) Handles btnFilter.Click
        PerformFilter()
    End Sub

    ' Enter ที่ช่อง Patient ID
    Private Sub txtPatientID_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPatientID.KeyDown
        If e.KeyCode = Keys.Enter Then
            PerformSearchByID()
            e.SuppressKeyPress = True
        End If
    End Sub

    ' Enter ที่ช่อง Filter
    Private Sub txtFilter_KeyDown(sender As Object, e As KeyEventArgs) Handles txtFilter.KeyDown
        If e.KeyCode = Keys.Enter Then
            PerformFilter()
            e.SuppressKeyPress = True
        End If
    End Sub

    ' ฟังก์ชันค้นหาด้วย Patient ID
    Private Sub PerformSearchByID()
        Try
            Dim keyword As String = txtPatientID.Text.Trim()

            If keyword = "" Then
                LoadAllData()
            Else
                Dim dt As DataTable = Me.DataDictionaryDataSet.vw_OutPatient_Report
                Dim dv As New DataView(dt)
                dv.RowFilter = $"CONVERT(P_ID, System.String) LIKE '%{keyword.Replace("'", "''")}%'"
                Vw_OutPatient_ReportDataGridView.DataSource = dv
            End If

        Catch ex As Exception
            MessageBox.Show("Search by Patient ID error: " & ex.Message)
        End Try
    End Sub

    ' ฟังก์ชันค้นหาทุกคอลัมน์
    Private Sub PerformFilter()
        Try
            Dim keyword As String = txtFilter.Text.Trim()

            If keyword = "" Then
                LoadAllData()
            Else
                Dim dt As DataTable = Me.DataDictionaryDataSet.vw_OutPatient_Report
                Dim dv As New DataView(dt)

                Dim filters As New List(Of String)
                For Each col As DataColumn In dt.Columns
                    If col.DataType Is GetType(String) Then
                        filters.Add(String.Format("[{0}] LIKE '%{1}%'", col.ColumnName, keyword.Replace("'", "''")))
                    Else
                        filters.Add(String.Format("CONVERT([{0}], System.String) LIKE '%{1}%'", col.ColumnName, keyword.Replace("'", "''")))
                    End If
                Next

                dv.RowFilter = String.Join(" OR ", filters)
                Vw_OutPatient_ReportDataGridView.DataSource = dv
            End If

        Catch ex As Exception
            MessageBox.Show("Filter error: " & ex.Message)
        End Try
    End Sub

End Class
