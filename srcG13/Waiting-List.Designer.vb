<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Waiting_List
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
        Me.txtPatientID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.DataDictionaryDataSet = New pj._73.DataDictionaryDataSet()
        Me.Waiting_ListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Waiting_ListTableAdapter = New pj._73.DataDictionaryDataSetTableAdapters.Waiting_ListTableAdapter()
        Me.TableAdapterManager = New pj._73.DataDictionaryDataSetTableAdapters.TableAdapterManager()
        Me.Waiting_ListDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Waiting_ListBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Waiting_queTextBox = New System.Windows.Forms.TextBox()
        Me.Appt_TimeTextBox = New System.Windows.Forms.TextBox()
        Me.Exam_RmTextBox = New System.Windows.Forms.TextBox()
        Me.P_SurnameTextBox = New System.Windows.Forms.TextBox()
        Me.Appt_DateDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.StatusTextBox = New System.Windows.Forms.TextBox()
        Me.P_NameTextBox = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.DataDictionaryDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Waiting_ListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Waiting_ListDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Waiting_ListBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.LightGray
        Me.btnSearch.Location = New System.Drawing.Point(421, 22)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(97, 37)
        Me.btnSearch.TabIndex = 14
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'txtPatientID
        '
        Me.txtPatientID.Location = New System.Drawing.Point(166, 32)
        Me.txtPatientID.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtPatientID.Name = "txtPatientID"
        Me.txtPatientID.Size = New System.Drawing.Size(247, 26)
        Me.txtPatientID.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(53, 38)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 20)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Patient ID:"
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.Red
        Me.btnDelete.Location = New System.Drawing.Point(873, 228)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(170, 49)
        Me.btnDelete.TabIndex = 16
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.SkyBlue
        Me.btnEdit.Location = New System.Drawing.Point(655, 228)
        Me.btnEdit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(170, 49)
        Me.btnEdit.TabIndex = 15
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(86, 97)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 20)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(63, 137)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 20)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Surname"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 177)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(143, 20)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Examination Room"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(22, 217)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(139, 20)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Appointment Date"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(22, 257)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(138, 20)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "Appointment Time"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(651, 115)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(96, 20)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "Waiting Que"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(651, 155)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 20)
        Me.Label8.TabIndex = 30
        Me.Label8.Text = "Status"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(472, 312)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(92, 20)
        Me.Label9.TabIndex = 31
        Me.Label9.Text = "Waiting-List"
        '
        'DataDictionaryDataSet
        '
        Me.DataDictionaryDataSet.DataSetName = "DataDictionaryDataSet"
        Me.DataDictionaryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Waiting_ListBindingSource
        '
        Me.Waiting_ListBindingSource.DataMember = "Waiting_List"
        Me.Waiting_ListBindingSource.DataSource = Me.DataDictionaryDataSet
        '
        'Waiting_ListTableAdapter
        '
        Me.Waiting_ListTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.Waiting_ListTableAdapter = Me.Waiting_ListTableAdapter
        Me.TableAdapterManager.WardTableAdapter = Nothing
        Me.TableAdapterManager.Work_ExperienceTableAdapter = Nothing
        '
        'Waiting_ListDataGridView
        '
        Me.Waiting_ListDataGridView.AutoGenerateColumns = False
        Me.Waiting_ListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Waiting_ListDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9})
        Me.Waiting_ListDataGridView.DataSource = Me.Waiting_ListBindingSource
        Me.Waiting_ListDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Waiting_ListDataGridView.Location = New System.Drawing.Point(0, 392)
        Me.Waiting_ListDataGridView.Name = "Waiting_ListDataGridView"
        Me.Waiting_ListDataGridView.RowHeadersWidth = 62
        Me.Waiting_ListDataGridView.RowTemplate.Height = 28
        Me.Waiting_ListDataGridView.Size = New System.Drawing.Size(1067, 302)
        Me.Waiting_ListDataGridView.TabIndex = 32
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Waiting_que"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Waiting_que"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 150
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Appt_Time"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Appt_Time"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 150
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Exam_Rm"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Exam_Rm"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 150
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "P_Surname"
        Me.DataGridViewTextBoxColumn4.HeaderText = "P_Surname"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 150
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Appt_Date"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Appt_Date"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 150
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Status"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Status"
        Me.DataGridViewTextBoxColumn6.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 150
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "P_Name"
        Me.DataGridViewTextBoxColumn7.HeaderText = "P_Name"
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
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "W_ID"
        Me.DataGridViewTextBoxColumn9.HeaderText = "W_ID"
        Me.DataGridViewTextBoxColumn9.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.Width = 150
        '
        'Waiting_ListBindingSource1
        '
        Me.Waiting_ListBindingSource1.DataMember = "Waiting_List"
        Me.Waiting_ListBindingSource1.DataSource = Me.DataDictionaryDataSet
        '
        'Waiting_queTextBox
        '
        Me.Waiting_queTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Waiting_ListBindingSource, "Waiting_que", True))
        Me.Waiting_queTextBox.Location = New System.Drawing.Point(759, 109)
        Me.Waiting_queTextBox.Name = "Waiting_queTextBox"
        Me.Waiting_queTextBox.Size = New System.Drawing.Size(247, 26)
        Me.Waiting_queTextBox.TabIndex = 33
        '
        'Appt_TimeTextBox
        '
        Me.Appt_TimeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Waiting_ListBindingSource, "Appt_Time", True))
        Me.Appt_TimeTextBox.Location = New System.Drawing.Point(172, 257)
        Me.Appt_TimeTextBox.Name = "Appt_TimeTextBox"
        Me.Appt_TimeTextBox.Size = New System.Drawing.Size(247, 26)
        Me.Appt_TimeTextBox.TabIndex = 35
        '
        'Exam_RmTextBox
        '
        Me.Exam_RmTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Waiting_ListBindingSource, "Exam_Rm", True))
        Me.Exam_RmTextBox.Location = New System.Drawing.Point(172, 177)
        Me.Exam_RmTextBox.Name = "Exam_RmTextBox"
        Me.Exam_RmTextBox.Size = New System.Drawing.Size(247, 26)
        Me.Exam_RmTextBox.TabIndex = 37
        '
        'P_SurnameTextBox
        '
        Me.P_SurnameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Waiting_ListBindingSource, "P_Surname", True))
        Me.P_SurnameTextBox.Location = New System.Drawing.Point(172, 131)
        Me.P_SurnameTextBox.Name = "P_SurnameTextBox"
        Me.P_SurnameTextBox.Size = New System.Drawing.Size(247, 26)
        Me.P_SurnameTextBox.TabIndex = 39
        '
        'Appt_DateDateTimePicker
        '
        Me.Appt_DateDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Waiting_ListBindingSource, "Appt_Date", True))
        Me.Appt_DateDateTimePicker.Location = New System.Drawing.Point(172, 217)
        Me.Appt_DateDateTimePicker.Name = "Appt_DateDateTimePicker"
        Me.Appt_DateDateTimePicker.Size = New System.Drawing.Size(247, 26)
        Me.Appt_DateDateTimePicker.TabIndex = 41
        '
        'StatusTextBox
        '
        Me.StatusTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Waiting_ListBindingSource, "Status", True))
        Me.StatusTextBox.Location = New System.Drawing.Point(759, 155)
        Me.StatusTextBox.Name = "StatusTextBox"
        Me.StatusTextBox.Size = New System.Drawing.Size(247, 26)
        Me.StatusTextBox.TabIndex = 43
        '
        'P_NameTextBox
        '
        Me.P_NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Waiting_ListBindingSource, "P_Name", True))
        Me.P_NameTextBox.Location = New System.Drawing.Point(172, 94)
        Me.P_NameTextBox.Name = "P_NameTextBox"
        Me.P_NameTextBox.Size = New System.Drawing.Size(247, 26)
        Me.P_NameTextBox.TabIndex = 45
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.pj._73.My.Resources.Resources.โลโก้
        Me.PictureBox1.Location = New System.Drawing.Point(967, -1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 69)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 46
        Me.PictureBox1.TabStop = False
        '
        'Waiting_List
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1067, 694)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Waiting_queTextBox)
        Me.Controls.Add(Me.Appt_TimeTextBox)
        Me.Controls.Add(Me.Exam_RmTextBox)
        Me.Controls.Add(Me.P_SurnameTextBox)
        Me.Controls.Add(Me.Appt_DateDateTimePicker)
        Me.Controls.Add(Me.StatusTextBox)
        Me.Controls.Add(Me.P_NameTextBox)
        Me.Controls.Add(Me.Waiting_ListDataGridView)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtPatientID)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Waiting_List"
        Me.Text = "Waiting_List"
        CType(Me.DataDictionaryDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Waiting_ListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Waiting_ListDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Waiting_ListBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSearch As Button
    Friend WithEvents txtPatientID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents DataDictionaryDataSet As DataDictionaryDataSet
    Friend WithEvents Waiting_ListBindingSource As BindingSource
    Friend WithEvents Waiting_ListTableAdapter As DataDictionaryDataSetTableAdapters.Waiting_ListTableAdapter
    Friend WithEvents TableAdapterManager As DataDictionaryDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Waiting_ListDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents Waiting_ListBindingSource1 As BindingSource
    Friend WithEvents Waiting_queTextBox As TextBox
    Friend WithEvents Appt_TimeTextBox As TextBox
    Friend WithEvents Exam_RmTextBox As TextBox
    Friend WithEvents P_SurnameTextBox As TextBox
    Friend WithEvents Appt_DateDateTimePicker As DateTimePicker
    Friend WithEvents StatusTextBox As TextBox
    Friend WithEvents P_NameTextBox As TextBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
