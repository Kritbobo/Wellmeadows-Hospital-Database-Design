Public Class StaffList

    Private Sub StaffList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' โหลดข้อมูล Staff ทั้งหมดตอนเปิดฟอร์ม
        Me.StaffTableAdapter.Fill(Me.DataDictionaryDataSet.Staff)
        StaffDataGridView.DataSource = Me.DataDictionaryDataSet.Staff

        ' เติม column ลง ComboBox filter
        cboFilter.Items.Clear()
        cboFilter.Items.Add("S_ID")
        cboFilter.Items.Add("S_Name")
        cboFilter.Items.Add("S_Surname")
        cboFilter.Items.Add("S_Position")
        cboFilter.Items.Add("Sex")
        cboFilter.SelectedIndex = 0
    End Sub

    ' ปุ่ม Search (ค้นหาจาก Staff ID)
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Try
            Dim searchText As String = txtSearch.Text.Trim()

            If searchText = "" Then
                ' ถ้าไม่กรอกอะไร → แสดงทั้งหมด
                Me.StaffTableAdapter.Fill(Me.DataDictionaryDataSet.Staff)
                StaffDataGridView.DataSource = Me.DataDictionaryDataSet.Staff
            Else
                ' Filter ด้วย DataView
                Dim dv As New DataView(Me.DataDictionaryDataSet.Staff)
                dv.RowFilter = $"Convert(S_ID, 'System.String') LIKE '%{searchText}%'"
                StaffDataGridView.DataSource = dv
            End If

        Catch ex As Exception
            MessageBox.Show("Search error: " & ex.Message)
        End Try
    End Sub

    ' ปุ่ม Filter (กรองตาม column ที่เลือก)
    Private Sub btnFilter_Click(sender As Object, e As EventArgs) Handles btnFilter.Click
        Try
            Dim filterCol As String = cboFilter.SelectedItem.ToString()
            Dim filterText As String = txtFilter.Text.Trim()

            If filterText = "" Then
                ' ถ้าไม่กรอก filter → โหลดข้อมูลทั้งหมด
                Me.StaffTableAdapter.Fill(Me.DataDictionaryDataSet.Staff)
                StaffDataGridView.DataSource = Me.DataDictionaryDataSet.Staff
            Else
                ' กรองตาม column ที่เลือก
                Dim dv As New DataView(Me.DataDictionaryDataSet.Staff)
                dv.RowFilter = $"Convert({filterCol}, 'System.String') LIKE '%{filterText}%'"
                StaffDataGridView.DataSource = dv
            End If

        Catch ex As Exception
            MessageBox.Show("Filter error: " & ex.Message)
        End Try
    End Sub

End Class
