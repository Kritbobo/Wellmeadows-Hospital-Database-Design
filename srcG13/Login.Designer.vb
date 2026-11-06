<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.PanelLogin = New System.Windows.Forms.Panel()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PanelLogin.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelLogin
        '
        Me.PanelLogin.BackgroundImage = Global.pj._73.My.Resources.Resources.พื้นหลัง
        Me.PanelLogin.Controls.Add(Me.btnLogin)
        Me.PanelLogin.Controls.Add(Me.Label2)
        Me.PanelLogin.Controls.Add(Me.Label1)
        Me.PanelLogin.Controls.Add(Me.txtPassword)
        Me.PanelLogin.Controls.Add(Me.txtUsername)
        Me.PanelLogin.Controls.Add(Me.PictureBox1)
        Me.PanelLogin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelLogin.Location = New System.Drawing.Point(0, 0)
        Me.PanelLogin.Name = "PanelLogin"
        Me.PanelLogin.Size = New System.Drawing.Size(1067, 694)
        Me.PanelLogin.TabIndex = 0
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnLogin.Location = New System.Drawing.Point(481, 505)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(155, 59)
        Me.btnLogin.TabIndex = 5
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.LightCyan
        Me.Label2.Location = New System.Drawing.Point(448, 403)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Password"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.LightCyan
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Location = New System.Drawing.Point(448, 328)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 22)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Username"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(448, 437)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(245, 26)
        Me.txtPassword.TabIndex = 2
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(448, 354)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(245, 26)
        Me.txtUsername.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.pj._73.My.Resources.Resources.พื้นหลัง
        Me.PictureBox1.Image = Global.pj._73.My.Resources.Resources.โลโก้
        Me.PictureBox1.Location = New System.Drawing.Point(433, 110)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(228, 153)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1067, 694)
        Me.Controls.Add(Me.PanelLogin)
        Me.Name = "Login"
        Me.Text = "Login"
        Me.PanelLogin.ResumeLayout(False)
        Me.PanelLogin.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelLogin As Panel
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
