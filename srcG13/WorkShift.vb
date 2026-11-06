Public Class WorkShift

    ' Dataset และ TableAdapter
    Private ds As New DataDictionaryDataSet()
    Private taShift As New DataDictionaryDataSetTableAdapters.ShiftTableAdapter()

    ' โหลดข้อมูลตอนเปิดฟอร์ม
    Private Sub WorkShift_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            taShift.Fill(ds.Shift)
            ShiftDataGridView.DataSource = ds.Shift

            ' ตั้งค่า DateTimePicker ให้เป็นเวลา
            dtStart.Format = DateTimePickerFormat.Custom
            dtStart.CustomFormat = "HH:mm"
            dtStart.ShowUpDown = True

            dtEnd.Format = DateTimePickerFormat.Custom
            dtEnd.CustomFormat = "HH:mm"
            dtEnd.ShowUpDown = True

            ' ค่าเริ่มต้น
            dtStart.Value = Date.Today.AddHours(8)
            dtEnd.Value = Date.Today.AddHours(16)

            ' โหลดค่า Shift
            cboShift.Items.Clear()
            cboShift.Items.AddRange(New Object() {"Day", "Evening", "Night", "Custom"})
            cboShift.SelectedIndex = 0

        Catch ex As Exception
            MessageBox.Show("Load failed: " & ex.Message, "Error")
        End Try
    End Sub

    ' เมื่อเลือก Shift ให้กำหนดเวลาอัตโนมัติ
    Private Sub cboShift_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboShift.SelectedIndexChanged
        Select Case cboShift.SelectedItem.ToString()
            Case "Day"
                dtStart.Value = Date.Today.AddHours(8)
                dtEnd.Value = Date.Today.AddHours(16)
            Case "Evening"
                dtStart.Value = Date.Today.AddHours(16)
                dtEnd.Value = Date.Today.AddDays(1).AddHours(0) ' เที่ยงคืน
            Case "Night"
                dtStart.Value = Date.Today.AddHours(0)
                dtEnd.Value = Date.Today.AddHours(8)
            Case "Custom"
                ' ผู้ใช้จะใส่เอง
        End Select
    End Sub

    ' ปุ่ม Save
    Private Sub btnSaveShift_Click(sender As Object, e As EventArgs) Handles btnSaveShift.Click
        Try
            Dim sid As Integer
            Dim wid As Integer

            If Not Integer.TryParse(txtSearchStaff.Text, sid) Then
                MessageBox.Show("กรุณากรอก Staff ID เป็นตัวเลข", "Invalid Input")
                Exit Sub
            End If

            If Not Integer.TryParse(txtSearchWard.Text, wid) Then
                MessageBox.Show("กรุณากรอก Ward ID เป็นตัวเลข", "Invalid Input")
                Exit Sub
            End If

            ' เพิ่มแถวใหม่
            Dim row As DataDictionaryDataSet.ShiftRow = ds.Shift.NewShiftRow()
            row.S_ID = sid
            row.W_ID = wid
            row.S_Position = cboShift.Text
            row.StartTime = dtStart.Value.TimeOfDay
            row.EndTime = dtEnd.Value.TimeOfDay

            ds.Shift.AddShiftRow(row)
            taShift.Update(ds.Shift)

            MessageBox.Show("Shift saved successfully!", "Info")

            ' refresh datagrid
            taShift.Fill(ds.Shift)

        Catch ex As Exception
            MessageBox.Show("Save failed: " & ex.Message, "Error")
        End Try
    End Sub

    ' ปุ่ม Clear
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtSearchStaff.Clear()
        txtSearchWard.Clear()
        cboShift.SelectedIndex = 0
        dtStart.Value = Date.Today.AddHours(8)
        dtEnd.Value = Date.Today.AddHours(16)

        taShift.Fill(ds.Shift)
        ShiftDataGridView.DataSource = ds.Shift
    End Sub

    ' ปุ่ม Search (ค้นหาเฉพาะ Staff ID)
    Private Sub btnSearchStaff_Click(sender As Object, e As EventArgs) Handles btnSearchStaff.Click
        Try
            Dim sid As Integer

            If Not Integer.TryParse(txtSearchStaff.Text, sid) Then
                MessageBox.Show("กรุณากรอก Staff ID เป็นตัวเลข", "Invalid Input")
                Exit Sub
            End If

            ' ใช้ Query: SELECT * FROM Shift WHERE S_ID = @sid
            Dim dt As DataTable = taShift.GetDataByStaff(sid)

            If dt.Rows.Count = 0 Then
                MessageBox.Show("ไม่พบข้อมูล Shift ของ Staff ID นี้", "Search Result")
            End If

            ShiftDataGridView.DataSource = dt

        Catch ex As Exception
            MessageBox.Show("Search failed: " & ex.Message, "Error")
        End Try
    End Sub

End Class
