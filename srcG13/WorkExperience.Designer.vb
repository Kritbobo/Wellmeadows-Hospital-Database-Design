<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WorkExperience
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
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.DataDictionaryDataSet = New pj._73.DataDictionaryDataSet()
        Me.Work_ExperienceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Work_ExperienceTableAdapter = New pj._73.DataDictionaryDataSetTableAdapters.Work_ExperienceTableAdapter()
        Me.TableAdapterManager = New pj._73.DataDictionaryDataSetTableAdapters.TableAdapterManager()
        Me.Work_ExperienceDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Finish_DateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Start_DateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.S_PositionTextBox = New System.Windows.Forms.TextBox()
        Me.OrganizationNameTextBox = New System.Windows.Forms.TextBox()
        Me.S_IDTextBox = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.DataDictionaryDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Work_ExperienceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Work_ExperienceDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(73, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Staff ID"
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.LightGray
        Me.btnSearch.Location = New System.Drawing.Point(447, 23)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(97, 37)
        Me.btnSearch.TabIndex = 3
        Me.btnSearch.Text = "SEARCH"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(136, 122)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(145, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Organization Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(211, 185)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 20)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Position"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(559, 121)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 20)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Start Date"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(559, 182)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 20)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "End Date"
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.SkyBlue
        Me.btnSave.Location = New System.Drawing.Point(215, 287)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(170, 49)
        Me.btnSave.TabIndex = 14
        Me.btnSave.Text = "SAVE"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.Green
        Me.btnAdd.Location = New System.Drawing.Point(425, 287)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(170, 49)
        Me.btnAdd.TabIndex = 15
        Me.btnAdd.Text = "ADD"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.Red
        Me.btnDelete.Location = New System.Drawing.Point(638, 287)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(170, 49)
        Me.btnDelete.TabIndex = 16
        Me.btnDelete.Text = "DELETE"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'DataDictionaryDataSet
        '
        Me.DataDictionaryDataSet.DataSetName = "DataDictionaryDataSet"
        Me.DataDictionaryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Work_ExperienceBindingSource
        '
        Me.Work_ExperienceBindingSource.DataMember = "Work_Experience"
        Me.Work_ExperienceBindingSource.DataSource = Me.DataDictionaryDataSet
        '
        'Work_ExperienceTableAdapter
        '
        Me.Work_ExperienceTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.ShiftTableAdapter = Nothing
        Me.TableAdapterManager.Staff_ContractTableAdapter = Nothing
        Me.TableAdapterManager.StaffTableAdapter = Nothing
        Me.TableAdapterManager.SupplierTableAdapter = Nothing
        Me.TableAdapterManager.SuppliesTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = pj._73.DataDictionaryDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.Waiting_ListTableAdapter = Nothing
        Me.TableAdapterManager.WardTableAdapter = Nothing
        Me.TableAdapterManager.Work_ExperienceTableAdapter = Me.Work_ExperienceTableAdapter
        '
        'Work_ExperienceDataGridView
        '
        Me.Work_ExperienceDataGridView.AutoGenerateColumns = False
        Me.Work_ExperienceDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Work_ExperienceDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.Work_ExperienceDataGridView.DataSource = Me.Work_ExperienceBindingSource
        Me.Work_ExperienceDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Work_ExperienceDataGridView.Location = New System.Drawing.Point(0, 371)
        Me.Work_ExperienceDataGridView.Name = "Work_ExperienceDataGridView"
        Me.Work_ExperienceDataGridView.RowHeadersWidth = 62
        Me.Work_ExperienceDataGridView.RowTemplate.Height = 28
        Me.Work_ExperienceDataGridView.Size = New System.Drawing.Size(1067, 323)
        Me.Work_ExperienceDataGridView.TabIndex = 17
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Finish_Date"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Finish_Date"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 150
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Start_Date"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Start_Date"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 150
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "S_Position"
        Me.DataGridViewTextBoxColumn3.HeaderText = "S_Position"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 150
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "OrganizationName"
        Me.DataGridViewTextBoxColumn4.HeaderText = "OrganizationName"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 150
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "S_ID"
        Me.DataGridViewTextBoxColumn5.HeaderText = "S_ID"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 150
        '
        'Finish_DateDateTimePicker
        '
        Me.Finish_DateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Work_ExperienceBindingSource, "Finish_Date", True))
        Me.Finish_DateDateTimePicker.Location = New System.Drawing.Point(661, 180)
        Me.Finish_DateDateTimePicker.Name = "Finish_DateDateTimePicker"
        Me.Finish_DateDateTimePicker.Size = New System.Drawing.Size(200, 26)
        Me.Finish_DateDateTimePicker.TabIndex = 18
        '
        'Start_DateDateTimePicker
        '
        Me.Start_DateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Work_ExperienceBindingSource, "Start_Date", True))
        Me.Start_DateDateTimePicker.Location = New System.Drawing.Point(661, 120)
        Me.Start_DateDateTimePicker.Name = "Start_DateDateTimePicker"
        Me.Start_DateDateTimePicker.Size = New System.Drawing.Size(200, 26)
        Me.Start_DateDateTimePicker.TabIndex = 20
        '
        'S_PositionTextBox
        '
        Me.S_PositionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Work_ExperienceBindingSource, "S_Position", True))
        Me.S_PositionTextBox.Location = New System.Drawing.Point(301, 176)
        Me.S_PositionTextBox.Name = "S_PositionTextBox"
        Me.S_PositionTextBox.Size = New System.Drawing.Size(200, 26)
        Me.S_PositionTextBox.TabIndex = 22
        '
        'OrganizationNameTextBox
        '
        Me.OrganizationNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Work_ExperienceBindingSource, "OrganizationName", True))
        Me.OrganizationNameTextBox.Location = New System.Drawing.Point(301, 119)
        Me.OrganizationNameTextBox.Name = "OrganizationNameTextBox"
        Me.OrganizationNameTextBox.Size = New System.Drawing.Size(200, 26)
        Me.OrganizationNameTextBox.TabIndex = 24
        '
        'S_IDTextBox
        '
        Me.S_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Work_ExperienceBindingSource, "S_ID", True))
        Me.S_IDTextBox.Location = New System.Drawing.Point(200, 27)
        Me.S_IDTextBox.Name = "S_IDTextBox"
        Me.S_IDTextBox.Size = New System.Drawing.Size(200, 26)
        Me.S_IDTextBox.TabIndex = 26
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.pj._73.My.Resources.Resources.โลโก้
        Me.PictureBox1.Location = New System.Drawing.Point(967, -3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 69)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 27
        Me.PictureBox1.TabStop = False
        '
        'WorkExperience
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1067, 694)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Finish_DateDateTimePicker)
        Me.Controls.Add(Me.Start_DateDateTimePicker)
        Me.Controls.Add(Me.S_PositionTextBox)
        Me.Controls.Add(Me.OrganizationNameTextBox)
        Me.Controls.Add(Me.S_IDTextBox)
        Me.Controls.Add(Me.Work_ExperienceDataGridView)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSearch)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "WorkExperience"
        Me.Text = "WorkExperience"
        CType(Me.DataDictionaryDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Work_ExperienceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Work_ExperienceDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSearch As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents DataDictionaryDataSet As DataDictionaryDataSet
    Friend WithEvents Work_ExperienceBindingSource As BindingSource
    Friend WithEvents Work_ExperienceTableAdapter As DataDictionaryDataSetTableAdapters.Work_ExperienceTableAdapter
    Friend WithEvents TableAdapterManager As DataDictionaryDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Work_ExperienceDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents Finish_DateDateTimePicker As DateTimePicker
    Friend WithEvents Start_DateDateTimePicker As DateTimePicker
    Friend WithEvents S_PositionTextBox As TextBox
    Friend WithEvents OrganizationNameTextBox As TextBox
    Friend WithEvents S_IDTextBox As TextBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
