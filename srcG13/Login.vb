Public Class Login

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username As String = txtUsername.Text.Trim()
        Dim password As String = txtPassword.Text.Trim()

        ' ตรวจสอบ Username/Password แบบ Hardcode
        If username = "admin" AndAlso password = "1234" Then
            MessageBox.Show("Login Success! Welcome " & username, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' เปิดหน้า Main Menu
            Dim mainForm As New MainMenu()
            mainForm.Show()
            Me.Hide()

        Else
            MessageBox.Show("Invalid Username or Password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    ' ปิดโปรแกรมถ้ากดปิดหน้าต่าง Login
    Private Sub Login_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        Application.Exit()
    End Sub

End Class
