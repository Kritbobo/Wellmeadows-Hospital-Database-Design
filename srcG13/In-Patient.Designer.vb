<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class In_Patient
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
        Dim Room_NumberLabel As System.Windows.Forms.Label
        Dim Bed_NumberLabel As System.Windows.Forms.Label
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.txtWardSelection = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtSurname = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.In_PatientDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.In_PatientBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataDictionaryDataSet = New pj._73.DataDictionaryDataSet()
        Me.In_IDTextBox = New System.Windows.Forms.TextBox()
        Me.Room_NumberTextBox = New System.Windows.Forms.TextBox()
        Me.Discharge_DateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Expected_StayTextBox = New System.Windows.Forms.TextBox()
        Me.Bed_NumberTextBox = New System.Windows.Forms.TextBox()
        Me.Exp_DischargeDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Admit_DateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.In_PatientTableAdapter = New pj._73.DataDictionaryDataSetTableAdapters.In_PatientTableAdapter()
        Me.TableAdapterManager = New pj._73.DataDictionaryDataSetTableAdapters.TableAdapterManager()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Room_NumberLabel = New System.Windows.Forms.Label()
        Bed_NumberLabel = New System.Windows.Forms.Label()
        CType(Me.In_PatientDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.In_PatientBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataDictionaryDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Room_NumberLabel
        '
        Room_NumberLabel.AutoSize = True
        Room_NumberLabel.Location = New System.Drawing.Point(569, 133)
        Room_NumberLabel.Name = "Room_NumberLabel"
        Room_NumberLabel.Size = New System.Drawing.Size(112, 20)
        Room_NumberLabel.TabIndex = 37
        Room_NumberLabel.Text = "Room Number"
        '
        'Bed_NumberLabel
        '
        Bed_NumberLabel.AutoSize = True
        Bed_NumberLabel.Location = New System.Drawing.Point(587, 175)
        Bed_NumberLabel.Name = "Bed_NumberLabel"
        Bed_NumberLabel.Size = New System.Drawing.Size(98, 20)
        Bed_NumberLabel.TabIndex = 43
        Bed_NumberLabel.Text = "Bed Number"
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.LightGray
        Me.btnSearch.Location = New System.Drawing.Point(411, 25)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(97, 37)
        Me.btnSearch.TabIndex = 11
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 30)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 20)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Patient ID:"
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.Red
        Me.btnDelete.Location = New System.Drawing.Point(591, 305)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(170, 49)
        Me.btnDelete.TabIndex = 13
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.SkyBlue
        Me.btnEdit.Location = New System.Drawing.Point(322, 305)
        Me.btnEdit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(170, 49)
        Me.btnEdit.TabIndex = 12
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'txtWardSelection
        '
        Me.txtWardSelection.Location = New System.Drawing.Point(217, 104)
        Me.txtWardSelection.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtWardSelection.Name = "txtWardSelection"
        Me.txtWardSelection.Size = New System.Drawing.Size(247, 26)
        Me.txtWardSelection.TabIndex = 14
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(89, 108)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 20)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Ward Selection"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(217, 150)
        Me.txtName.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(247, 26)
        Me.txtName.TabIndex = 16
        '
        'txtSurname
        '
        Me.txtSurname.Location = New System.Drawing.Point(217, 190)
        Me.txtSurname.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtSurname.Name = "txtSurname"
        Me.txtSurname.Size = New System.Drawing.Size(247, 26)
        Me.txtSurname.TabIndex = 17
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(135, 153)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 20)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(112, 190)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 20)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Surname"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(88, 233)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 20)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Expected Stay"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(555, 90)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(152, 20)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "Expected Discharge"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(587, 210)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(89, 20)
        Me.Label9.TabIndex = 30
        Me.Label9.Text = "Admit Date"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(587, 250)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(120, 20)
        Me.Label10.TabIndex = 31
        Me.Label10.Text = "Discharge Date"
        '
        'In_PatientDataGridView
        '
        Me.In_PatientDataGridView.AutoGenerateColumns = False
        Me.In_PatientDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.In_PatientDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10})
        Me.In_PatientDataGridView.DataSource = Me.In_PatientBindingSource
        Me.In_PatientDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.In_PatientDataGridView.Location = New System.Drawing.Point(0, 385)
        Me.In_PatientDataGridView.Name = "In_PatientDataGridView"
        Me.In_PatientDataGridView.RowHeadersWidth = 62
        Me.In_PatientDataGridView.RowTemplate.Height = 28
        Me.In_PatientDataGridView.Size = New System.Drawing.Size(1067, 309)
        Me.In_PatientDataGridView.TabIndex = 33
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "In_ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "In_ID"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 150
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "waitlist_date"
        Me.DataGridViewTextBoxColumn2.HeaderText = "waitlist_date"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 150
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Room_Number"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Room_Number"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 150
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Discharge_Date"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Discharge_Date"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 150
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Expected_Stay"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Expected_Stay"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 150
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Bed_Number"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Bed_Number"
        Me.DataGridViewTextBoxColumn6.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 150
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Exp_Discharge"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Exp_Discharge"
        Me.DataGridViewTextBoxColumn7.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 150
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Admit_Date"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Admit_Date"
        Me.DataGridViewTextBoxColumn8.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Width = 150
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "W_ID"
        Me.DataGridViewTextBoxColumn9.HeaderText = "W_ID"
        Me.DataGridViewTextBoxColumn9.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.Width = 150
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "P_ID"
        Me.DataGridViewTextBoxColumn10.HeaderText = "P_ID"
        Me.DataGridViewTextBoxColumn10.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.Width = 150
        '
        'In_PatientBindingSource
        '
        Me.In_PatientBindingSource.DataMember = "In_Patient"
        Me.In_PatientBindingSource.DataSource = Me.DataDictionaryDataSet
        '
        'DataDictionaryDataSet
        '
        Me.DataDictionaryDataSet.DataSetName = "DataDictionaryDataSet"
        Me.DataDictionaryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'In_IDTextBox
        '
        Me.In_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.In_PatientBindingSource, "In_ID", True))
        Me.In_IDTextBox.Location = New System.Drawing.Point(151, 30)
        Me.In_IDTextBox.Name = "In_IDTextBox"
        Me.In_IDTextBox.Size = New System.Drawing.Size(240, 26)
        Me.In_IDTextBox.TabIndex = 34
        '
        'Room_NumberTextBox
        '
        Me.Room_NumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.In_PatientBindingSource, "Room_Number", True))
        Me.Room_NumberTextBox.Location = New System.Drawing.Point(750, 127)
        Me.Room_NumberTextBox.Name = "Room_NumberTextBox"
        Me.Room_NumberTextBox.Size = New System.Drawing.Size(247, 26)
        Me.Room_NumberTextBox.TabIndex = 38
        '
        'Discharge_DateDateTimePicker
        '
        Me.Discharge_DateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.In_PatientBindingSource, "Discharge_Date", True))
        Me.Discharge_DateDateTimePicker.Location = New System.Drawing.Point(750, 250)
        Me.Discharge_DateDateTimePicker.Name = "Discharge_DateDateTimePicker"
        Me.Discharge_DateDateTimePicker.Size = New System.Drawing.Size(247, 26)
        Me.Discharge_DateDateTimePicker.TabIndex = 40
        '
        'Expected_StayTextBox
        '
        Me.Expected_StayTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.In_PatientBindingSource, "Expected_Stay", True))
        Me.Expected_StayTextBox.Location = New System.Drawing.Point(217, 230)
        Me.Expected_StayTextBox.Name = "Expected_StayTextBox"
        Me.Expected_StayTextBox.Size = New System.Drawing.Size(247, 26)
        Me.Expected_StayTextBox.TabIndex = 42
        '
        'Bed_NumberTextBox
        '
        Me.Bed_NumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.In_PatientBindingSource, "Bed_Number", True))
        Me.Bed_NumberTextBox.Location = New System.Drawing.Point(750, 171)
        Me.Bed_NumberTextBox.Name = "Bed_NumberTextBox"
        Me.Bed_NumberTextBox.Size = New System.Drawing.Size(247, 26)
        Me.Bed_NumberTextBox.TabIndex = 44
        '
        'Exp_DischargeDateTimePicker
        '
        Me.Exp_DischargeDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.In_PatientBindingSource, "Exp_Discharge", True))
        Me.Exp_DischargeDateTimePicker.Location = New System.Drawing.Point(750, 84)
        Me.Exp_DischargeDateTimePicker.Name = "Exp_DischargeDateTimePicker"
        Me.Exp_DischargeDateTimePicker.Size = New System.Drawing.Size(247, 26)
        Me.Exp_DischargeDateTimePicker.TabIndex = 46
        '
        'Admit_DateDateTimePicker
        '
        Me.Admit_DateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.In_PatientBindingSource, "Admit_Date", True))
        Me.Admit_DateDateTimePicker.Location = New System.Drawing.Point(750, 210)
        Me.Admit_DateDateTimePicker.Name = "Admit_DateDateTimePicker"
        Me.Admit_DateDateTimePicker.Size = New System.Drawing.Size(247, 26)
        Me.Admit_DateDateTimePicker.TabIndex = 48
        '
        'In_PatientTableAdapter
        '
        Me.In_PatientTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BedTableAdapter = Nothing
        Me.TableAdapterManager.Edu_QualTableAdapter = Nothing
        Me.TableAdapterManager.EmergencyContactTableAdapter = Nothing
        Me.TableAdapterManager.In_PatientTableAdapter = Me.In_PatientTableAdapter
        Me.TableAdapterManager.Out_PatientTableAdapter = Nothing
        Me.TableAdapterManager.Patient_MedicationTableAdapter = Nothing
        Me.TableAdapterManager.PatientTableAdapter = Nothing
        Me.TableAdapterManager.PayrollTableAdapter = Nothing
        Me.TableAdapterManager.Pharma_SuppliesTableAdapter = Nothing
        Me.TableAdapterManager.RequestionTableAdapter = Nothing
        Me.TableAdapterManager.ShiftTableAdapter = Nothing
        Me.TableAdapterManager.Staff_ContractTableAdapter = Nothing
        Me.TableAdapterManager.StaffTableAdapter = Nothing
        Me.TableAdapterManager.SupplierTableAdapter = Nothing
        Me.TableAdapterManager.SuppliesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = pj._73.DataDictionaryDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.Waiting_ListTableAdapter = Nothing
        Me.TableAdapterManager.WardTableAdapter = Nothing
        Me.TableAdapterManager.Work_ExperienceTableAdapter = Nothing
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.pj._73.My.Resources.Resources.โลโก้
        Me.PictureBox1.Location = New System.Drawing.Point(967, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 69)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 49
        Me.PictureBox1.TabStop = False
        '
        'In_Patient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1067, 694)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.In_IDTextBox)
        Me.Controls.Add(Room_NumberLabel)
        Me.Controls.Add(Me.Room_NumberTextBox)
        Me.Controls.Add(Me.Discharge_DateDateTimePicker)
        Me.Controls.Add(Me.Expected_StayTextBox)
        Me.Controls.Add(Bed_NumberLabel)
        Me.Controls.Add(Me.Bed_NumberTextBox)
        Me.Controls.Add(Me.Exp_DischargeDateTimePicker)
        Me.Controls.Add(Me.Admit_DateDateTimePicker)
        Me.Controls.Add(Me.In_PatientDataGridView)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtSurname)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtWardSelection)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "In_Patient"
        Me.Text = "In-Patient"
        CType(Me.In_PatientDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.In_PatientBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataDictionaryDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSearch As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents txtWardSelection As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtSurname As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents DataDictionaryDataSet As DataDictionaryDataSet
    Friend WithEvents In_PatientBindingSource As BindingSource
    Friend WithEvents In_PatientTableAdapter As DataDictionaryDataSetTableAdapters.In_PatientTableAdapter
    Friend WithEvents TableAdapterManager As DataDictionaryDataSetTableAdapters.TableAdapterManager
    Friend WithEvents In_PatientDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents In_IDTextBox As TextBox
    Friend WithEvents Room_NumberTextBox As TextBox
    Friend WithEvents Discharge_DateDateTimePicker As DateTimePicker
    Friend WithEvents Expected_StayTextBox As TextBox
    Friend WithEvents Bed_NumberTextBox As TextBox
    Friend WithEvents Exp_DischargeDateTimePicker As DateTimePicker
    Friend WithEvents Admit_DateDateTimePicker As DateTimePicker
    Friend WithEvents PictureBox1 As PictureBox
End Class
