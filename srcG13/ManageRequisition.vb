Public Class ManageRequisition

    Private Sub ManageRequisition_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ' โหลดข้อมูลตาราง Requisition
            Me.RequestionTableAdapter.Fill(Me.DataDictionaryDataSet.Requestion)

            With RequestionDataGridView
                .AutoGenerateColumns = True
                .ReadOnly = True
                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            End With

        Catch ex As Exception
            MessageBox.Show("Load error: " & ex.Message)
        End Try
    End Sub

    ' ปุ่ม Search ค้นหาด้วย SupplyID หรือ WardID
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Try
            Dim wardID As String = txtWardID.Text.Trim()
            Dim supplyID As String = txtSupplyID.Text.Trim()

            Dim dt As DataTable = Me.DataDictionaryDataSet.Requestion
            Dim dv As New DataView(dt)

            Dim filter As String = ""
            If wardID <> "" Then
                filter &= $"CONVERT(W_ID, System.String) LIKE '%{wardID.Replace("'", "''")}%'"
            End If
            If supplyID <> "" Then
                If filter <> "" Then filter &= " AND "
                filter &= $"CONVERT(SU_ID, System.String) LIKE '%{supplyID.Replace("'", "''")}%'"
            End If

            If filter <> "" Then
                dv.RowFilter = filter
            End If

            RequestionDataGridView.DataSource = dv

        Catch ex As Exception
            MessageBox.Show("Search error: " & ex.Message)
        End Try
    End Sub

    ' ปุ่ม Order → เพิ่มการเบิกใหม่
    Private Sub btnOrder_Click(sender As Object, e As EventArgs) Handles btnOrder.Click
        Try
            If txtWardID.Text = "" OrElse txtSupplyID.Text = "" OrElse txtAmount.Text = "" Then
                MessageBox.Show("กรุณากรอกข้อมูลให้ครบ (WardID, SupplyID, Amount)")
                Exit Sub
            End If

            ' เพิ่มแถวใหม่ใน DataSet
            Dim newRow As DataRow = Me.DataDictionaryDataSet.Requestion.NewRow()
            newRow("W_ID") = txtWardID.Text
            newRow("SU_ID") = txtSupplyID.Text
            newRow("SU_Name") = txtSupplyName.Text
            newRow("SU_Type") = cboType.Text
            newRow("Amount") = Convert.ToInt32(txtAmount.Text)

            Me.DataDictionaryDataSet.Requestion.Rows.Add(newRow)

            ' บันทึกลง Database
            Me.RequestionTableAdapter.Update(Me.DataDictionaryDataSet.Requestion)
            MessageBox.Show("บันทึกการเบิกสำเร็จ")

            ' โหลดข้อมูลใหม่
            LoadAllData()

        Catch ex As Exception
            MessageBox.Show("Order error: " & ex.Message)
        End Try
    End Sub

    ' ปุ่ม Delete → ลบการเบิกที่เลือก
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            If RequestionDataGridView.SelectedRows.Count = 0 Then
                MessageBox.Show("กรุณาเลือกแถวที่จะลบ")
                Exit Sub
            End If

            Dim rqID As Integer = Convert.ToInt32(RequestionDataGridView.SelectedRows(0).Cells("RQ_ID").Value)

            ' หาแถวใน DataSet เพื่อลบ
            Dim row = Me.DataDictionaryDataSet.Requestion.FindByRQ_ID(rqID)
            If row IsNot Nothing Then
                row.Delete()
                Me.RequestionTableAdapter.Update(Me.DataDictionaryDataSet.Requestion)
                MessageBox.Show("ลบข้อมูลสำเร็จ")
                LoadAllData()
            End If

        Catch ex As Exception
            MessageBox.Show("Delete error: " & ex.Message)
        End Try
    End Sub

    ' โหลดข้อมูลใหม่ทั้งหมด
    Private Sub LoadAllData()
        Me.RequestionTableAdapter.Fill(Me.DataDictionaryDataSet.Requestion)
        RequestionDataGridView.DataSource = Me.DataDictionaryDataSet.Requestion
    End Sub

End Class
