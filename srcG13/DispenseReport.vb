Public Class DispenseReport

    ' โหลดข้อมูลครั้งแรกเมื่อเปิดฟอร์ม
    Private Sub DispenseReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            LoadAllData()

            With Vw_Dispense_ReportDataGridView
                .AutoGenerateColumns = True
                .ReadOnly = True
                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            End With
        Catch ex As Exception
            MessageBox.Show("Error loading data: " & ex.Message)
        End Try
    End Sub

    ' ฟังก์ชันโหลดข้อมูลทั้งหมด
    Private Sub LoadAllData()
        Me.Vw_Dispense_ReportTableAdapter.Fill(Me.DataDictionaryDataSet.vw_Dispense_Report)
        Vw_Dispense_ReportDataGridView.DataSource = Me.DataDictionaryDataSet.vw_Dispense_Report
    End Sub

    ' ปุ่มค้นหา
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        PerformSearch()
    End Sub

    ' ปุ่ม Refresh (รีเซ็ตกลับมาแสดงทั้งหมด)
    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Try
            ' 1) ล้างข้อความในช่องค้นหา
            txtSearch.Text = ""

            ' 2) โหลดข้อมูลใหม่ทั้งหมด
            LoadAllData()
        Catch ex As Exception
            MessageBox.Show("Refresh error: " & ex.Message)
        End Try
    End Sub

    ' กด Enter ในช่องค้นหาให้ทำงานเหมือนปุ่ม Search
    Private Sub txtSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            PerformSearch()
            e.SuppressKeyPress = True ' กันเสียง beep
        End If
    End Sub

    ' ฟังก์ชันค้นหา
    Private Sub PerformSearch()
        Try
            Dim keyword As String = txtSearch.Text.Trim()

            If keyword = "" Then
                LoadAllData()
            Else
                Dim dt As DataTable = Me.DataDictionaryDataSet.vw_Dispense_Report
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
                Vw_Dispense_ReportDataGridView.DataSource = dv
            End If

        Catch ex As Exception
            MessageBox.Show("Search error: " & ex.Message)
        End Try
    End Sub

End Class
