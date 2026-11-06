Public Class In_Patient

    ' โหลดข้อมูลทั้งหมดเมื่อเปิดฟอร์ม
    Private Sub In_Patient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.In_PatientTableAdapter.Fill(Me.DataDictionaryDataSet.In_Patient)
        Catch ex As Exception
            MessageBox.Show("Load failed: " & ex.Message)
        End Try
    End Sub

    ' ====== ปุ่ม Search ======
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Try
            Dim pid = In_IDTextBox.Text.Trim()
            If pid = "" Then
                MessageBox.Show("กรุณากรอก Patient ID", "Search")
                Return
            End If

            ' filter ตาม P_ID (คุณต้องมี query FillByPatientID ใน TableAdapter)
            Me.In_PatientTableAdapter.FillByPatientID(Me.DataDictionaryDataSet.In_Patient, pid)

        Catch ex As Exception
            MessageBox.Show("Search failed: " & ex.Message)
        End Try
    End Sub

    ' ====== ปุ่ม Edit ======
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Try
            If In_PatientDataGridView.CurrentRow Is Nothing Then
                MessageBox.Show("กรุณาเลือกข้อมูลที่ต้องการแก้ไข")
                Return
            End If

            ' ดึงค่าใหม่จาก TextBox/DateTimePicker
            Dim row As DataRowView = CType(In_PatientDataGridView.CurrentRow.DataBoundItem, DataRowView)

            ' 3 ช่องที่คุณระบุ
            row("WardSelection") = txtWardSelection.Text
            row("P_Name") = txtName.Text
            row("P_Surname") = txtSurname.Text

            ' ส่วนที่เหลือ
            row("Expected_Stay") = Expected_StayTextBox.Text
            row("Exp_Discharge") = Exp_DischargeDateTimePicker.Value
            row("Room_Number") = Room_NumberTextBox.Text
            row("Bed_Number") = Bed_NumberTextBox.Text
            row("Admit_Date") = Admit_DateDateTimePicker.Value
            row("Discharge_Date") = Discharge_DateDateTimePicker.Value

            ' อัปเดต DB
            Me.Validate()
            Me.In_PatientBindingSource.EndEdit()
            Me.In_PatientTableAdapter.Update(Me.DataDictionaryDataSet.In_Patient)

            MessageBox.Show("แก้ไขข้อมูลเรียบร้อยแล้ว")

        Catch ex As Exception
            MessageBox.Show("Edit failed: " & ex.Message)
        End Try
    End Sub

    ' ====== ปุ่ม Delete ======
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            If In_PatientDataGridView.CurrentRow Is Nothing Then
                MessageBox.Show("กรุณาเลือกข้อมูลที่จะลบ")
                Return
            End If

            Dim confirm = MessageBox.Show("คุณต้องการลบข้อมูลนี้หรือไม่?", "Confirm", MessageBoxButtons.YesNo)
            If confirm = DialogResult.Yes Then
                In_PatientDataGridView.Rows.Remove(In_PatientDataGridView.CurrentRow)
                Me.Validate()
                Me.In_PatientBindingSource.EndEdit()
                Me.In_PatientTableAdapter.Update(Me.DataDictionaryDataSet.In_Patient)

                MessageBox.Show("ลบข้อมูลเรียบร้อยแล้ว")
            End If

        Catch ex As Exception
            MessageBox.Show("Delete failed: " & ex.Message)
        End Try
    End Sub

End Class
