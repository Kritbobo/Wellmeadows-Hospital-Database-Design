Imports System.Data.SqlClient

Public Class ManageStaff

    ' Connection String (แก้ไขตรงนี้ให้ตรงกับ instance จริง)
    Private connectionString As String = "Data Source=SOPITNAPA\DB_B6601218;Initial Catalog=DataDictionary;Integrated Security=True"

    ' ====== โหลดฟอร์ม ======
    Private Sub ManageStaff_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadStaffData()
    End Sub

    ' ====== ฟังก์ชันโหลด Staff ทั้งหมด ======
    Private Sub LoadStaffData()
        Try
            Using conn As New SqlConnection(connectionString)
                conn.Open()
                Dim sql As String = "SELECT * FROM Staff"
                Using da As New SqlDataAdapter(sql, conn)
                    Dim dt As New DataTable()
                    da.Fill(dt)
                    StaffDataGridView.DataSource = dt
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Load data failed: " & ex.Message)
        End Try
    End Sub

    ' ====== ปุ่ม Search ======
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim sid As String = S_IDTextBox.Text.Trim()

        If sid = "" Then
            LoadStaffData()
        Else
            Try
                Using conn As New SqlConnection(connectionString)
                    conn.Open()
                    Dim sql As String = "SELECT * FROM Staff WHERE S_ID=@sid"
                    Using da As New SqlDataAdapter(sql, conn)
                        da.SelectCommand.Parameters.AddWithValue("@sid", sid)
                        Dim dt As New DataTable()
                        da.Fill(dt)
                        StaffDataGridView.DataSource = dt
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show("Search failed: " & ex.Message)
            End Try
        End If
    End Sub

    ' ====== ปุ่ม New Staff ======
    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        MessageBox.Show("Add new staff here (ยังไม่ได้เชื่อม DB)", "New Staff")
        LoadStaffData()
    End Sub

    ' ====== ปุ่ม Edit ======
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        MessageBox.Show("Edit staff record here", "Edit")
        LoadStaffData()
    End Sub

    ' ====== ปุ่ม Delete ======
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        MessageBox.Show("Delete staff record here", "Delete")
        LoadStaffData()
    End Sub

    ' ====== ปุ่ม Add Qualification ======
    Private Sub btnAddQual_Click(sender As Object, e As EventArgs) Handles btnAddQual.Click
        Dim frm As New StaffQualification()
        frm.Show()
    End Sub

    ' ====== ปุ่ม Work Experience ======
    Private Sub btnWorkExp_Click(sender As Object, e As EventArgs) Handles btnWorkExp.Click
        Dim frm As New WorkExperience()
        frm.Show()
    End Sub

    ' ====== ปุ่ม Payroll ======
    Private Sub btnPayroll_Click(sender As Object, e As EventArgs) Handles btnPayroll.Click
        Dim frm As New Payroll()
        frm.Show()
    End Sub

End Class
