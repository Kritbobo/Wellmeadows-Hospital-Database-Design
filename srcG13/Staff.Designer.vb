<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Staff
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.PanelStaff = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnWorkshift = New System.Windows.Forms.Button()
        Me.btnManageStaff = New System.Windows.Forms.Button()
        Me.btnStaffList = New System.Windows.Forms.Button()
        Me.btnStaffReport = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PanelStaff.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelStaff
        '
        Me.PanelStaff.Controls.Add(Me.PictureBox2)
        Me.PanelStaff.Controls.Add(Me.TableLayoutPanel1)
        Me.PanelStaff.Controls.Add(Me.PictureBox1)
        Me.PanelStaff.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelStaff.Location = New System.Drawing.Point(0, 0)
        Me.PanelStaff.Name = "PanelStaff"
        Me.PanelStaff.Size = New System.Drawing.Size(1067, 694)
        Me.PanelStaff.TabIndex = 1
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.pj._73.My.Resources.Resources.โลโก้
        Me.PictureBox2.Location = New System.Drawing.Point(967, 0)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(100, 69)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 5
        Me.PictureBox2.TabStop = False
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.LightSkyBlue
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnWorkshift, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnManageStaff, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnStaffList, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.btnStaffReport, 1, 1)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(262, 157)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(557, 375)
        Me.TableLayoutPanel1.TabIndex = 2
        '
        'btnWorkshift
        '
        Me.btnWorkshift.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnWorkshift.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnWorkshift.Location = New System.Drawing.Point(3, 3)
        Me.btnWorkshift.Name = "btnWorkshift"
        Me.btnWorkshift.Size = New System.Drawing.Size(272, 181)
        Me.btnWorkshift.TabIndex = 0
        Me.btnWorkshift.Text = "Work shift"
        Me.btnWorkshift.UseVisualStyleBackColor = False
        '
        'btnManageStaff
        '
        Me.btnManageStaff.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnManageStaff.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnManageStaff.Location = New System.Drawing.Point(281, 3)
        Me.btnManageStaff.Name = "btnManageStaff"
        Me.btnManageStaff.Size = New System.Drawing.Size(273, 181)
        Me.btnManageStaff.TabIndex = 1
        Me.btnManageStaff.Text = "Manage Staff"
        Me.btnManageStaff.UseVisualStyleBackColor = False
        '
        'btnStaffList
        '
        Me.btnStaffList.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnStaffList.Location = New System.Drawing.Point(3, 190)
        Me.btnStaffList.Name = "btnStaffList"
        Me.btnStaffList.Size = New System.Drawing.Size(272, 182)
        Me.btnStaffList.TabIndex = 2
        Me.btnStaffList.Text = "Staff List"
        Me.btnStaffList.UseVisualStyleBackColor = True
        '
        'btnStaffReport
        '
        Me.btnStaffReport.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnStaffReport.Location = New System.Drawing.Point(281, 190)
        Me.btnStaffReport.Name = "btnStaffReport"
        Me.btnStaffReport.Size = New System.Drawing.Size(273, 182)
        Me.btnStaffReport.TabIndex = 3
        Me.btnStaffReport.Text = "Staff Report"
        Me.btnStaffReport.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = Global.pj._73.My.Resources.Resources.Screenshot_2025_08_08_161313
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1067, 694)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Staff
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1067, 694)
        Me.Controls.Add(Me.PanelStaff)
        Me.Name = "Staff"
        Me.Text = "Staff"
        Me.PanelStaff.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelStaff As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents btnWorkshift As Button
    Friend WithEvents btnManageStaff As Button
    Friend WithEvents btnStaffList As Button
    Friend WithEvents btnStaffReport As Button
    Friend WithEvents PictureBox2 As PictureBox
End Class
