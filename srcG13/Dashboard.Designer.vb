<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Dashboard
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Me.PanelDashboard = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.chartBedsPerWard = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.chartBedStatus = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanelDashboard.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chartBedsPerWard, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chartBedStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelDashboard
        '
        Me.PanelDashboard.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.PanelDashboard.Controls.Add(Me.PictureBox1)
        Me.PanelDashboard.Controls.Add(Me.chartBedsPerWard)
        Me.PanelDashboard.Controls.Add(Me.chartBedStatus)
        Me.PanelDashboard.Controls.Add(Me.Label1)
        Me.PanelDashboard.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelDashboard.Location = New System.Drawing.Point(0, 0)
        Me.PanelDashboard.Name = "PanelDashboard"
        Me.PanelDashboard.Size = New System.Drawing.Size(1067, 941)
        Me.PanelDashboard.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.pj._73.My.Resources.Resources.โลโก้
        Me.PictureBox1.Location = New System.Drawing.Point(967, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 69)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'chartBedsPerWard
        '
        ChartArea1.Name = "ChartArea1"
        Me.chartBedsPerWard.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.chartBedsPerWard.Legends.Add(Legend1)
        Me.chartBedsPerWard.Location = New System.Drawing.Point(511, 164)
        Me.chartBedsPerWard.Name = "chartBedsPerWard"
        Me.chartBedsPerWard.Size = New System.Drawing.Size(457, 254)
        Me.chartBedsPerWard.TabIndex = 3
        Me.chartBedsPerWard.Text = "Chart3"
        '
        'chartBedStatus
        '
        ChartArea2.Name = "ChartArea1"
        Me.chartBedStatus.ChartAreas.Add(ChartArea2)
        Legend2.Name = "Legend1"
        Me.chartBedStatus.Legends.Add(Legend2)
        Me.chartBedStatus.Location = New System.Drawing.Point(28, 141)
        Me.chartBedStatus.Name = "chartBedStatus"
        Me.chartBedStatus.Size = New System.Drawing.Size(446, 338)
        Me.chartBedStatus.TabIndex = 1
        Me.chartBedStatus.Text = "Chart1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(330, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(276, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "🏥 Wellmeadows Hospital Dashboard "
        '
        'Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1067, 941)
        Me.Controls.Add(Me.PanelDashboard)
        Me.Name = "Dashboard"
        Me.Text = "Dashboard"
        Me.PanelDashboard.ResumeLayout(False)
        Me.PanelDashboard.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chartBedsPerWard, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chartBedStatus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelDashboard As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents chartBedStatus As DataVisualization.Charting.Chart
    Friend WithEvents chartBedsPerWard As DataVisualization.Charting.Chart
    Friend WithEvents PictureBox1 As PictureBox
End Class
