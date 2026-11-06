<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Emergency_Contact
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
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.DataDictionaryDataSet = New pj._73.DataDictionaryDataSet()
        Me.EmergencyContactBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmergencyContactTableAdapter = New pj._73.DataDictionaryDataSetTableAdapters.EmergencyContactTableAdapter()
        Me.TableAdapterManager = New pj._73.DataDictionaryDataSetTableAdapters.TableAdapterManager()
        Me.EmergencyContactDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.E_NameTextBox = New System.Windows.Forms.TextBox()
        Me.E_RelationshipTextBox = New System.Windows.Forms.TextBox()
        Me.E_AddressTextBox = New System.Windows.Forms.TextBox()
        Me.E_TelTextBox = New System.Windows.Forms.TextBox()
        Me.E_ZipCodeTextBox = New System.Windows.Forms.TextBox()
        Me.P_IDTextBox = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.DataDictionaryDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmergencyContactBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmergencyContactDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.LightGray
        Me.btnSearch.Location = New System.Drawing.Point(396, 35)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(97, 37)
        Me.btnSearch.TabIndex = 5
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(44, 50)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Patient ID:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(103, 124)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 20)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Contact Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(119, 170)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 20)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Address"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(603, 159)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 20)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Tel"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(603, 199)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(97, 20)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Relationship"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(119, 214)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 20)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Zipcode"
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.SkyBlue
        Me.btnSave.Location = New System.Drawing.Point(247, 301)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(170, 49)
        Me.btnSave.TabIndex = 16
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.Green
        Me.btnAdd.Location = New System.Drawing.Point(454, 301)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(170, 49)
        Me.btnAdd.TabIndex = 17
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.Red
        Me.btnDelete.Location = New System.Drawing.Point(661, 301)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(170, 49)
        Me.btnDelete.TabIndex = 18
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'DataDictionaryDataSet
        '
        Me.DataDictionaryDataSet.DataSetName = "DataDictionaryDataSet"
        Me.DataDictionaryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EmergencyContactBindingSource
        '
        Me.EmergencyContactBindingSource.DataMember = "EmergencyContact"
        Me.EmergencyContactBindingSource.DataSource = Me.DataDictionaryDataSet
        '
        'EmergencyContactTableAdapter
        '
        Me.EmergencyContactTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BedTableAdapter = Nothing
        Me.TableAdapterManager.Edu_QualTableAdapter = Nothing
        Me.TableAdapterManager.EmergencyContactTableAdapter = Me.EmergencyContactTableAdapter
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
        Me.TableAdapterManager.Work_ExperienceTableAdapter = Nothing
        '
        'EmergencyContactDataGridView
        '
        Me.EmergencyContactDataGridView.AutoGenerateColumns = False
        Me.EmergencyContactDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.EmergencyContactDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8})
        Me.EmergencyContactDataGridView.DataSource = Me.EmergencyContactBindingSource
        Me.EmergencyContactDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.EmergencyContactDataGridView.Location = New System.Drawing.Point(0, 394)
        Me.EmergencyContactDataGridView.Name = "EmergencyContactDataGridView"
        Me.EmergencyContactDataGridView.RowHeadersWidth = 62
        Me.EmergencyContactDataGridView.RowTemplate.Height = 28
        Me.EmergencyContactDataGridView.Size = New System.Drawing.Size(1067, 300)
        Me.EmergencyContactDataGridView.TabIndex = 19
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "E_ContractID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "E_ContractID"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 150
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "E_Name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "E_Name"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 150
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "E_Surname"
        Me.DataGridViewTextBoxColumn3.HeaderText = "E_Surname"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 150
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "E_Relationship"
        Me.DataGridViewTextBoxColumn4.HeaderText = "E_Relationship"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 150
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "E_Address"
        Me.DataGridViewTextBoxColumn5.HeaderText = "E_Address"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 150
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "E_Tel"
        Me.DataGridViewTextBoxColumn6.HeaderText = "E_Tel"
        Me.DataGridViewTextBoxColumn6.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 150
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "E_ZipCode"
        Me.DataGridViewTextBoxColumn7.HeaderText = "E_ZipCode"
        Me.DataGridViewTextBoxColumn7.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 150
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "P_ID"
        Me.DataGridViewTextBoxColumn8.HeaderText = "P_ID"
        Me.DataGridViewTextBoxColumn8.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Width = 150
        '
        'E_NameTextBox
        '
        Me.E_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmergencyContactBindingSource, "E_Name", True))
        Me.E_NameTextBox.Location = New System.Drawing.Point(225, 118)
        Me.E_NameTextBox.Name = "E_NameTextBox"
        Me.E_NameTextBox.Size = New System.Drawing.Size(247, 26)
        Me.E_NameTextBox.TabIndex = 22
        '
        'E_RelationshipTextBox
        '
        Me.E_RelationshipTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmergencyContactBindingSource, "E_Relationship", True))
        Me.E_RelationshipTextBox.Location = New System.Drawing.Point(709, 196)
        Me.E_RelationshipTextBox.Name = "E_RelationshipTextBox"
        Me.E_RelationshipTextBox.Size = New System.Drawing.Size(247, 26)
        Me.E_RelationshipTextBox.TabIndex = 26
        '
        'E_AddressTextBox
        '
        Me.E_AddressTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmergencyContactBindingSource, "E_Address", True))
        Me.E_AddressTextBox.Location = New System.Drawing.Point(225, 170)
        Me.E_AddressTextBox.Name = "E_AddressTextBox"
        Me.E_AddressTextBox.Size = New System.Drawing.Size(247, 26)
        Me.E_AddressTextBox.TabIndex = 28
        '
        'E_TelTextBox
        '
        Me.E_TelTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmergencyContactBindingSource, "E_Tel", True))
        Me.E_TelTextBox.Location = New System.Drawing.Point(709, 153)
        Me.E_TelTextBox.Name = "E_TelTextBox"
        Me.E_TelTextBox.Size = New System.Drawing.Size(247, 26)
        Me.E_TelTextBox.TabIndex = 30
        '
        'E_ZipCodeTextBox
        '
        Me.E_ZipCodeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmergencyContactBindingSource, "E_ZipCode", True))
        Me.E_ZipCodeTextBox.Location = New System.Drawing.Point(225, 214)
        Me.E_ZipCodeTextBox.Name = "E_ZipCodeTextBox"
        Me.E_ZipCodeTextBox.Size = New System.Drawing.Size(247, 26)
        Me.E_ZipCodeTextBox.TabIndex = 32
        '
        'P_IDTextBox
        '
        Me.P_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmergencyContactBindingSource, "P_ID", True))
        Me.P_IDTextBox.Location = New System.Drawing.Point(138, 47)
        Me.P_IDTextBox.Name = "P_IDTextBox"
        Me.P_IDTextBox.Size = New System.Drawing.Size(247, 26)
        Me.P_IDTextBox.TabIndex = 34
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.pj._73.My.Resources.Resources.โลโก้
        Me.PictureBox1.Location = New System.Drawing.Point(967, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 69)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 35
        Me.PictureBox1.TabStop = False
        '
        'Emergency_Contact
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1067, 694)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.E_NameTextBox)
        Me.Controls.Add(Me.E_RelationshipTextBox)
        Me.Controls.Add(Me.E_AddressTextBox)
        Me.Controls.Add(Me.E_TelTextBox)
        Me.Controls.Add(Me.E_ZipCodeTextBox)
        Me.Controls.Add(Me.P_IDTextBox)
        Me.Controls.Add(Me.EmergencyContactDataGridView)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Emergency_Contact"
        Me.Text = "Emergency_Contact"
        CType(Me.DataDictionaryDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmergencyContactBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmergencyContactDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSearch As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents DataDictionaryDataSet As DataDictionaryDataSet
    Friend WithEvents EmergencyContactBindingSource As BindingSource
    Friend WithEvents EmergencyContactTableAdapter As DataDictionaryDataSetTableAdapters.EmergencyContactTableAdapter
    Friend WithEvents TableAdapterManager As DataDictionaryDataSetTableAdapters.TableAdapterManager
    Friend WithEvents EmergencyContactDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents E_NameTextBox As TextBox
    Friend WithEvents E_RelationshipTextBox As TextBox
    Friend WithEvents E_AddressTextBox As TextBox
    Friend WithEvents E_TelTextBox As TextBox
    Friend WithEvents E_ZipCodeTextBox As TextBox
    Friend WithEvents P_IDTextBox As TextBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
