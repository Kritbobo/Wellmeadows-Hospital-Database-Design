Public Class RequisitionReport

    Private Sub RequisitionReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            LoadAllData()

            With Vw_Requisition_ReportDataGridView
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
        Me.Vw_Requisition_ReportTableAdapter.Fill(Me.DataDictionaryDataSet.vw_Requisition_Report)
        Vw_Requisition_ReportDataGridView.DataSource = Me.DataDictionaryDataSet.vw_Requisition_Report
    End Sub

    ' ปุ่ม Search (ค้นหาเฉพาะ RQ_ID)
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        PerformSearchByID()
    End Sub

    ' ปุ่ม Filter (ค้นหาทุกคอลัมน์)
    Private Sub btnFilter_Click(sender As Object, e As EventArgs) Handles btnFilter.Click
        PerformFilter()
    End Sub

    ' Enter ที่ช่อง Search
    Private Sub txtSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSearch.KeyDown
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

    ' ฟังก์ชันค้นหาด้วย RQ_ID
    Private Sub PerformSearchByID()
        Try
            Dim keyword As String = txtSearch.Text.Trim()

            If keyword = "" Then
                LoadAllData()
            Else
                Dim dt As DataTable = Me.DataDictionaryDataSet.vw_Requisition_Report
                Dim dv As New DataView(dt)
                dv.RowFilter = $"CONVERT(RQ_ID, System.String) LIKE '%{keyword.Replace("'", "''")}%'"
                Vw_Requisition_ReportDataGridView.DataSource = dv
            End If

        Catch ex As Exception
            MessageBox.Show("Search by ID error: " & ex.Message)
        End Try
    End Sub

    ' ฟังก์ชันค้นหาทุกคอลัมน์
    Private Sub PerformFilter()
        Try
            Dim keyword As String = txtFilter.Text.Trim()

            If keyword = "" Then
                LoadAllData()
            Else
                Dim dt As DataTable = Me.DataDictionaryDataSet.vw_Requisition_Report
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
                Vw_Requisition_ReportDataGridView.DataSource = dv
            End If

        Catch ex As Exception
            MessageBox.Show("Filter error: " & ex.Message)
        End Try
    End Sub

End Class
