<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WorkShift
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSearchStaff = New System.Windows.Forms.TextBox()
        Me.btnSearchStaff = New System.Windows.Forms.Button()
        Me.dtStart = New System.Windows.Forms.DateTimePicker()
        Me.dtEnd = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cboShift = New System.Windows.Forms.ComboBox()
        Me.ShiftDataGridView = New System.Windows.Forms.DataGridView()
        Me.SHIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SPositionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EndTimeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StartTimeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ShiftBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataDictionaryDataSet = New pj._73.DataDictionaryDataSet()
        Me.btnSaveShift = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.ShiftTableAdapter = New pj._73.DataDictionaryDataSetTableAdapters.ShiftTableAdapter()
        Me.TableAdapterManager = New pj._73.DataDictionaryDataSetTableAdapters.TableAdapterManager()
        Me.StaffBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StaffTableAdapter = New pj._73.DataDictionaryDataSetTableAdapters.StaffTableAdapter()
        Me.WardBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.WardTableAdapter = New pj._73.DataDictionaryDataSetTableAdapters.WardTableAdapter()
        Me.txtSearchWard = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.ShiftDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ShiftBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataDictionaryDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StaffBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WardBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(119, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Staff ID"
        '
        'txtSearchStaff
        '
        Me.txtSearchStaff.Location = New System.Drawing.Point(207, 55)
        Me.txtSearchStaff.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtSearchStaff.Name = "txtSearchStaff"
        Me.txtSearchStaff.Size = New System.Drawing.Size(273, 26)
        Me.txtSearchStaff.TabIndex = 1
        '
        'btnSearchStaff
        '
        Me.btnSearchStaff.BackColor = System.Drawing.Color.LightGray
        Me.btnSearchStaff.Location = New System.Drawing.Point(864, 13)
        Me.btnSearchStaff.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnSearchStaff.Name = "btnSearchStaff"
        Me.btnSearchStaff.Size = New System.Drawing.Size(97, 37)
        Me.btnSearchStaff.TabIndex = 5
        Me.btnSearchStaff.Text = "Search"
        Me.btnSearchStaff.UseVisualStyleBackColor = False
        '
        'dtStart
        '
        Me.dtStart.CustomFormat = """HH:mm"""
        Me.dtStart.Location = New System.Drawing.Point(208, 172)
        Me.dtStart.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dtStart.Name = "dtStart"
        Me.dtStart.ShowUpDown = True
        Me.dtStart.Size = New System.Drawing.Size(273, 26)
        Me.dtStart.TabIndex = 6
        '
        'dtEnd
        '
        Me.dtEnd.CustomFormat = """HH:mm"""
        Me.dtEnd.Location = New System.Drawing.Point(648, 166)
        Me.dtEnd.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dtEnd.Name = "dtEnd"
        Me.dtEnd.ShowUpDown = True
        Me.dtEnd.Size = New System.Drawing.Size(273, 26)
        Me.dtEnd.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(463, 115)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(131, 20)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "-----Shift Date-----"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(120, 172)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 20)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Start Date"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(560, 166)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 20)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "End Date"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(317, 238)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 20)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Shift"
        '
        'cboShift
        '
        Me.cboShift.FormattingEnabled = True
        Me.cboShift.Location = New System.Drawing.Point(386, 230)
        Me.cboShift.Name = "cboShift"
        Me.cboShift.Size = New System.Drawing.Size(306, 28)
        Me.cboShift.TabIndex = 19
        '
        'ShiftDataGridView
        '
        Me.ShiftDataGridView.AutoGenerateColumns = False
        Me.ShiftDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ShiftDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SHIDDataGridViewTextBoxColumn, Me.SPositionDataGridViewTextBoxColumn, Me.EndTimeDataGridViewTextBoxColumn, Me.StartTimeDataGridViewTextBoxColumn, Me.WIDDataGridViewTextBoxColumn, Me.SIDDataGridViewTextBoxColumn})
        Me.ShiftDataGridView.DataSource = Me.ShiftBindingSource
        Me.ShiftDataGridView.Location = New System.Drawing.Point(90, 298)
        Me.ShiftDataGridView.Name = "ShiftDataGridView"
        Me.ShiftDataGridView.RowHeadersWidth = 62
        Me.ShiftDataGridView.RowTemplate.Height = 28
        Me.ShiftDataGridView.Size = New System.Drawing.Size(925, 303)
        Me.ShiftDataGridView.TabIndex = 19
        '
        'SHIDDataGridViewTextBoxColumn
        '
        Me.SHIDDataGridViewTextBoxColumn.DataPropertyName = "SH_ID"
        Me.SHIDDataGridViewTextBoxColumn.HeaderText = "SH_ID"
        Me.SHIDDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.SHIDDataGridViewTextBoxColumn.Name = "SHIDDataGridViewTextBoxColumn"
        Me.SHIDDataGridViewTextBoxColumn.Width = 150
        '
        'SPositionDataGridViewTextBoxColumn
        '
        Me.SPositionDataGridViewTextBoxColumn.DataPropertyName = "S_Position"
        Me.SPositionDataGridViewTextBoxColumn.HeaderText = "S_Position"
        Me.SPositionDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.SPositionDataGridViewTextBoxColumn.Name = "SPositionDataGridViewTextBoxColumn"
        Me.SPositionDataGridViewTextBoxColumn.Width = 150
        '
        'EndTimeDataGridViewTextBoxColumn
        '
        Me.EndTimeDataGridViewTextBoxColumn.DataPropertyName = "EndTime"
        Me.EndTimeDataGridViewTextBoxColumn.HeaderText = "EndTime"
        Me.EndTimeDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.EndTimeDataGridViewTextBoxColumn.Name = "EndTimeDataGridViewTextBoxColumn"
        Me.EndTimeDataGridViewTextBoxColumn.Width = 150
        '
        'StartTimeDataGridViewTextBoxColumn
        '
        Me.StartTimeDataGridViewTextBoxColumn.DataPropertyName = "StartTime"
        Me.StartTimeDataGridViewTextBoxColumn.HeaderText = "StartTime"
        Me.StartTimeDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.StartTimeDataGridViewTextBoxColumn.Name = "StartTimeDataGridViewTextBoxColumn"
        Me.StartTimeDataGridViewTextBoxColumn.Width = 150
        '
        'WIDDataGridViewTextBoxColumn
        '
        Me.WIDDataGridViewTextBoxColumn.DataPropertyName = "W_ID"
        Me.WIDDataGridViewTextBoxColumn.HeaderText = "W_ID"
        Me.WIDDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.WIDDataGridViewTextBoxColumn.Name = "WIDDataGridViewTextBoxColumn"
        Me.WIDDataGridViewTextBoxColumn.Width = 150
        '
        'SIDDataGridViewTextBoxColumn
        '
        Me.SIDDataGridViewTextBoxColumn.DataPropertyName = "S_ID"
        Me.SIDDataGridViewTextBoxColumn.HeaderText = "S_ID"
        Me.SIDDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.SIDDataGridViewTextBoxColumn.Name = "SIDDataGridViewTextBoxColumn"
        Me.SIDDataGridViewTextBoxColumn.Width = 150
        '
        'ShiftBindingSource
        '
        Me.ShiftBindingSource.DataMember = "Shift"
        Me.ShiftBindingSource.DataSource = Me.DataDictionaryDataSet
        '
        'DataDictionaryDataSet
        '
        Me.DataDictionaryDataSet.DataSetName = "DataDictionaryDataSet"
        Me.DataDictionaryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnSaveShift
        '
        Me.btnSaveShift.BackColor = System.Drawing.Color.SkyBlue
        Me.btnSaveShift.Location = New System.Drawing.Point(385, 620)
        Me.btnSaveShift.Name = "btnSaveShift"
        Me.btnSaveShift.Size = New System.Drawing.Size(170, 49)
        Me.btnSaveShift.TabIndex = 20
        Me.btnSaveShift.Text = "Save"
        Me.btnSaveShift.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(613, 620)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(170, 49)
        Me.btnClear.TabIndex = 21
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'ShiftTableAdapter
        '
        Me.ShiftTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BedTableAdapter = Nothing
        Me.TableAdapterManager.Edu_QualTableAdapter = Nothing
        Me.TableAdapterManager.EmergencyContactTableAdapter = Nothing
        Me.TableAdapterManager.In_PatientTableAdapter = Nothing
        Me.TableAdapterManager.Out_PatientTableAdapter = Nothing
        Me.TableAdapterManager.Patient_MedicationTableAdapter = Nothing
        Me.TableAdapterManager.PatientTableAdapter = Nothing
        Me.TableAdapterManager.PayrollTableAdapter = Nothing
        Me.TableAdapterManager.Pharma_SuppliesTableAdapter = Nothing
        Me.TableAdapterManager.RequestionTableAdapter = Nothing
        Me.TableAdapterManager.ShiftTableAdapter = Me.ShiftTableAdapter
        Me.TableAdapterManager.Staff_ContractTableAdapter = Nothing
        Me.TableAdapterManager.StaffTableAdapter = Nothing
        Me.TableAdapterManager.SupplierTableAdapter = Nothing
        Me.TableAdapterManager.SuppliesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = pj._73.DataDictionaryDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.Waiting_ListTableAdapter = Nothing
        Me.TableAdapterManager.WardTableAdapter = Nothing
        Me.TableAdapterManager.Work_ExperienceTableAdapter = Nothing
        '
        'StaffBindingSource
        '
        Me.StaffBindingSource.DataMember = "Staff"
        Me.StaffBindingSource.DataSource = Me.DataDictionaryDataSet
        '
        'StaffTableAdapter
        '
        Me.StaffTableAdapter.ClearBeforeFill = True
        '
        'WardBindingSource
        '
        Me.WardBindingSource.DataMember = "Ward"
        Me.WardBindingSource.DataSource = Me.DataDictionaryDataSet
        '
        'WardTableAdapter
        '
        Me.WardTableAdapter.ClearBeforeFill = True
        '
        'txtSearchWard
        '
        Me.txtSearchWard.Location = New System.Drawing.Point(697, 58)
        Me.txtSearchWard.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtSearchWard.Name = "txtSearchWard"
        Me.txtSearchWard.Size = New System.Drawing.Size(223, 26)
        Me.txtSearchWard.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(623, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Ward ID"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.pj._73.My.Resources.Resources.โลโก้
        Me.PictureBox1.Location = New System.Drawing.Point(967, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 69)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 22
        Me.PictureBox1.TabStop = False
        '
        'WorkShift
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1067, 694)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnSaveShift)
        Me.Controls.Add(Me.ShiftDataGridView)
        Me.Controls.Add(Me.cboShift)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dtEnd)
        Me.Controls.Add(Me.dtStart)
        Me.Controls.Add(Me.btnSearchStaff)
        Me.Controls.Add(Me.txtSearchWard)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtSearchStaff)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "WorkShift"
        Me.Text = "WorkShift"
        CType(Me.ShiftDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ShiftBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataDictionaryDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StaffBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WardBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtSearchStaff As TextBox
    Friend WithEvents btnSearchStaff As Button
    Friend WithEvents dtStart As DateTimePicker
    Friend WithEvents dtEnd As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents DataDictionaryDataSet As DataDictionaryDataSet
    Friend WithEvents ShiftBindingSource As BindingSource
    Friend WithEvents ShiftTableAdapter As DataDictionaryDataSetTableAdapters.ShiftTableAdapter
    Friend WithEvents TableAdapterManager As DataDictionaryDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Label6 As Label
    Friend WithEvents cboShift As ComboBox
    Friend WithEvents ShiftDataGridView As DataGridView
    Friend WithEvents btnSaveShift As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents StaffBindingSource As BindingSource
    Friend WithEvents StaffTableAdapter As DataDictionaryDataSetTableAdapters.StaffTableAdapter
    Friend WithEvents WardBindingSource As BindingSource
    Friend WithEvents WardTableAdapter As DataDictionaryDataSetTableAdapters.WardTableAdapter
    Friend WithEvents SHIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SPositionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EndTimeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StartTimeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents WIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents txtSearchWard As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
