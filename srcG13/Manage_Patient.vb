Imports System.Data.SqlClient

Public Class Manage_Patient

    ' Connection string (แก้ไขแล้ว)
    Private connectionString As String = "Data Source=SOPITNAPA\DB_B6601218;Initial Catalog=DataDictionary;Integrated Security=True"

    ' โหลดข้อมูลผู้ป่วยทั้งหมดมาใส่ DataGridView
    Private Sub LoadAllPatients()
        Try
            Using conn As New SqlConnection(connectionString)
                conn.Open()
                Dim sql As String = "SELECT * FROM Patient"
                Using da As New SqlDataAdapter(sql, conn)
                    Dim dt As New DataTable()
                    da.Fill(dt)
                    PatientDataGridView.DataSource = dt
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Load failed: " & ex.Message)
        End Try
    End Sub

    ' ====== ปุ่ม New Patient (Insert) ======
    Private Sub btnNewPatient_Click(sender As Object, e As EventArgs) Handles btnNewPatient.Click
        Try
            Using conn As New SqlConnection(connectionString)
                conn.Open()

                Dim sql As String = "INSERT INTO Patient (P_Name, P_Surname, P_Birth, Sex, RegistrationDate, P_Address) 
                                     VALUES (@Name, @Surname, @Birth, @Sex, @RegDate, @Address)"

                Using cmd As New SqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@Name", txtName.Text.Trim())
                    cmd.Parameters.AddWithValue("@Surname", txtSurname.Text.Trim())
                    cmd.Parameters.AddWithValue("@Birth", DateTime.Parse(txtBirthday.Text))
                    cmd.Parameters.AddWithValue("@Sex", txtSex.Text.Trim())
                    cmd.Parameters.AddWithValue("@RegDate", DateTime.Now)
                    cmd.Parameters.AddWithValue("@Address", txtAddress.Text.Trim())

                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("เพิ่มผู้ป่วยใหม่เรียบร้อยแล้ว", "New Patient")
            LoadAllPatients()

        Catch ex As Exception
            MessageBox.Show("Insert failed: " & ex.Message)
        End Try
    End Sub

    ' ====== ปุ่ม Edit (Update) ======
    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Try
            Using conn As New SqlConnection(connectionString)
                conn.Open()

                Dim sql As String = "UPDATE Patient 
                                     SET P_Name=@Name, P_Surname=@Surname, P_Birth=@Birth, Sex=@Sex, P_Address=@Address 
                                     WHERE P_ID=@PID"

                Using cmd As New SqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@PID", Integer.Parse(txtPatientID.Text))
                    cmd.Parameters.AddWithValue("@Name", txtName.Text.Trim())
                    cmd.Parameters.AddWithValue("@Surname", txtSurname.Text.Trim())
                    cmd.Parameters.AddWithValue("@Birth", DateTime.Parse(txtBirthday.Text))
                    cmd.Parameters.AddWithValue("@Sex", txtSex.Text.Trim())
                    cmd.Parameters.AddWithValue("@Address", txtAddress.Text.Trim())

                    Dim rows = cmd.ExecuteNonQuery()
                    If rows > 0 Then
                        MessageBox.Show("แก้ไขข้อมูลเรียบร้อยแล้ว", "Edit")
                        LoadAllPatients()
                    Else
                        MessageBox.Show("ไม่พบข้อมูลที่จะแก้ไข", "Edit")
                    End If
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Update failed: " & ex.Message)
        End Try
    End Sub

    ' ====== ปุ่ม Delete ======
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            Using conn As New SqlConnection(connectionString)
                conn.Open()

                Dim sql As String = "DELETE FROM Patient WHERE P_ID=@PID"

                Using cmd As New SqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@PID", Integer.Parse(txtPatientID.Text))

                    Dim rows = cmd.ExecuteNonQuery()
                    If rows > 0 Then
                        MessageBox.Show("ลบข้อมูลเรียบร้อยแล้ว", "Delete")
                        LoadAllPatients()
                    Else
                        MessageBox.Show("ไม่พบข้อมูลที่จะลบ", "Delete")
                    End If
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Delete failed: " & ex.Message)
        End Try
    End Sub

    ' ====== ปุ่ม Search ======
    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Try
            Using conn As New SqlConnection(connectionString)
                conn.Open()

                Dim sql As String = "SELECT * FROM Patient WHERE P_ID=@PID"

                Using cmd As New SqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@PID", Integer.Parse(txtPatientID.Text))

                    Using reader As SqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            txtName.Text = reader("P_Name").ToString()
                            txtSurname.Text = reader("P_Surname").ToString()
                            txtBirthday.Text = reader("P_Birth").ToString()
                            txtSex.Text = reader("Sex").ToString()
                            txtAddress.Text = reader("P_Address").ToString()
                        Else
                            MessageBox.Show("ไม่พบข้อมูลผู้ป่วยนี้", "Search")
                        End If
                    End Using
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show("Search failed: " & ex.Message)
        End Try
    End Sub

    ' ====== ปุ่ม Emergency Contact ======
    Private Sub btnEmergencyContact_Click(sender As Object, e As EventArgs) Handles btnEmergencyContact.Click
        Dim frm As New Emergency_Contact()
        frm.Show()
    End Sub

    ' ====== ปุ่ม Out-Patient ======
    Private Sub btnOutPatient_Click(sender As Object, e As EventArgs) Handles btnOutPatient.Click
        Dim frm As New Out_Patient()
        frm.Show()
    End Sub

    ' ====== ปุ่ม In-Patient ======
    Private Sub btnInPatientbtninpatient_Click(sender As Object, e As EventArgs) Handles btnInPatientbtninpatient.Click
        Dim frm As New In_Patient()
        frm.Show()
    End Sub

    ' ====== โหลดฟอร์ม ======
    Private Sub Manage_Patient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadAllPatients()
    End Sub

End Class
