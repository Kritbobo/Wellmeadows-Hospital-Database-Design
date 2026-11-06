Public Class Out_Patient

    ' โหลดข้อมูลทั้งหมดเมื่อเปิดฟอร์ม
    Private Sub Out_Patient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.Out_PatientTableAdapter.Fill(Me.DataDictionaryDataSet.Out_Patient)
        Catch ex As Exception
            MessageBox.Show("Load failed: " & ex.Message)
        End Try
    End Sub

    ' ====== ปุ่ม Search ======
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Try
            Dim pid = P_IDTextBox.Text.Trim()
            If pid = "" Then
                MessageBox.Show("กรุณากรอก Patient ID", "Search")
                Return
            End If

            ' ต้องสร้าง Query FillByPatientID ใน TableAdapter
            Me.Out_PatientTableAdapter.FillByPatientID(Me.DataDictionaryDataSet.Out_Patient, pid)

        Catch ex As Exception
            MessageBox.Show("Search failed: " & ex.Message)
        End Try
    End Sub

    ' ====== ปุ่ม Edit ======
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Try
            If Out_PatientDataGridView.CurrentRow Is Nothing Then
                MessageBox.Show("กรุณาเลือกข้อมูลที่ต้องการแก้ไข")
                Return
            End If

            ' ดึง row ที่เลือก
            Dim row As DataRowView = CType(Out_PatientDataGridView.CurrentRow.DataBoundItem, DataRowView)

            ' อัปเดตค่าจาก TextBox/DateTimePicker
            row("Appt_Time") = Appt_TimeTextBox.Text
            row("Diagnosis") = DiagnosisTextBox.Text
            row("Appt_Date") = Appt_DateDateTimePicker.Value
            row("P_Name") = txtName.Text
            row("P_Surname") = txtSurname.Text

            ' Commit กลับไป DB
            Me.Validate()
            Me.Out_PatientBindingSource.EndEdit()
            Me.Out_PatientTableAdapter.Update(Me.DataDictionaryDataSet.Out_Patient)

            MessageBox.Show("แก้ไขข้อมูลเรียบร้อยแล้ว")

        Catch ex As Exception
            MessageBox.Show("Edit failed: " & ex.Message)
        End Try
    End Sub

    ' ====== ปุ่ม Delete ======
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            If Out_PatientDataGridView.CurrentRow Is Nothing Then
                MessageBox.Show("กรุณาเลือกข้อมูลที่จะลบ")
                Return
            End If

            Dim confirm = MessageBox.Show("คุณต้องการลบข้อมูลนี้หรือไม่?", "Confirm", MessageBoxButtons.YesNo)
            If confirm = DialogResult.Yes Then
                Out_PatientDataGridView.Rows.Remove(Out_PatientDataGridView.CurrentRow)
                Me.Validate()
                Me.Out_PatientBindingSource.EndEdit()
                Me.Out_PatientTableAdapter.Update(Me.DataDictionaryDataSet.Out_Patient)

                MessageBox.Show("ลบข้อมูลเรียบร้อยแล้ว")
            End If

        Catch ex As Exception
            MessageBox.Show("Delete failed: " & ex.Message)
        End Try
    End Sub

End Class
