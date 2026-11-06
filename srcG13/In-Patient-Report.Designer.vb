<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class In_Patient_Report
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
        Me.components = New System.ComponentModel.Container()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataDictionaryDataSet = New pj._73.DataDictionaryDataSet()
        Me.In_PatientBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.In_PatientTableAdapter = New pj._73.DataDictionaryDataSetTableAdapters.In_PatientTableAdapter()
        Me.TableAdapterManager = New pj._73.DataDictionaryDataSetTableAdapters.TableAdapterManager()
        Me.In_PatientBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.In_PatientBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.In_PatientBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Vw_InPatient_ReportBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Vw_InPatient_ReportTableAdapter = New pj._73.DataDictionaryDataSetTableAdapters.vw_InPatient_ReportTableAdapter()
        Me.InPatientReportDataGridView = New System.Windows.Forms.DataGridView()
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
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtPatientID = New System.Windows.Forms.TextBox()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.DataDictionaryDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.In_PatientBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.In_PatientBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.In_PatientBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.In_PatientBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Vw_InPatient_ReportBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InPatientReportDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.LightGray
        Me.btnSearch.Location = New System.Drawing.Point(384, 36)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(97, 37)
        Me.btnSearch.TabIndex = 17
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(38, 47)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 20)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Patient ID :"
        '
        'DataDictionaryDataSet
        '
        Me.DataDictionaryDataSet.DataSetName = "DataDictionaryDataSet"
        Me.DataDictionaryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'In_PatientBindingSource
        '
        Me.In_PatientBindingSource.DataMember = "In_Patient"
        Me.In_PatientBindingSource.DataSource = Me.DataDictionaryDataSet
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
        'In_PatientBindingSource1
        '
        Me.In_PatientBindingSource1.DataMember = "In_Patient"
        Me.In_PatientBindingSource1.DataSource = Me.DataDictionaryDataSet
        '
        'In_PatientBindingSource2
        '
        Me.In_PatientBindingSource2.DataMember = "In_Patient"
        Me.In_PatientBindingSource2.DataSource = Me.DataDictionaryDataSet
        '
        'In_PatientBindingSource3
        '
        Me.In_PatientBindingSource3.DataMember = "In_Patient"
        Me.In_PatientBindingSource3.DataSource = Me.DataDictionaryDataSet
        '
        'Vw_InPatient_ReportBindingSource
        '
        Me.Vw_InPatient_ReportBindingSource.DataMember = "vw_InPatient_Report"
        Me.Vw_InPatient_ReportBindingSource.DataSource = Me.DataDictionaryDataSet
        '
        'Vw_InPatient_ReportTableAdapter
        '
        Me.Vw_InPatient_ReportTableAdapter.ClearBeforeFill = True
        '
        'InPatientReportDataGridView
        '
        Me.InPatientReportDataGridView.AutoGenerateColumns = False
        Me.InPatientReportDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.InPatientReportDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12})
        Me.InPatientReportDataGridView.DataSource = Me.Vw_InPatient_ReportBindingSource
        Me.InPatientReportDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.InPatientReportDataGridView.Location = New System.Drawing.Point(0, 174)
        Me.InPatientReportDataGridView.Name = "InPatientReportDataGridView"
        Me.InPatientReportDataGridView.RowHeadersWidth = 62
        Me.InPatientReportDataGridView.RowTemplate.Height = 28
        Me.InPatientReportDataGridView.Size = New System.Drawing.Size(1067, 520)
        Me.InPatientReportDataGridView.TabIndex = 17
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "P_ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "P_ID"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 150
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "P_Name"
        Me.DataGridViewTextBoxColumn2.HeaderText = "P_Name"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 150
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "P_Surname"
        Me.DataGridViewTextBoxColumn3.HeaderText = "P_Surname"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 150
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "waitlist_date"
        Me.DataGridViewTextBoxColumn4.HeaderText = "waitlist_date"
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
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Admit_Date"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Admit_Date"
        Me.DataGridViewTextBoxColumn6.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 150
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Bed_Number"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Bed_Number"
        Me.DataGridViewTextBoxColumn7.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 150
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Room_Number"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Room_Number"
        Me.DataGridViewTextBoxColumn8.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Width = 150
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Exp_Discharge"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Exp_Discharge"
        Me.DataGridViewTextBoxColumn9.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.Width = 150
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Discharge_Date"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Discharge_Date"
        Me.DataGridViewTextBoxColumn10.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.Width = 150
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "W_ID"
        Me.DataGridViewTextBoxColumn11.HeaderText = "W_ID"
        Me.DataGridViewTextBoxColumn11.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.Width = 150
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "W_Name"
        Me.DataGridViewTextBoxColumn12.HeaderText = "W_Name"
        Me.DataGridViewTextBoxColumn12.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.Width = 150
        '
        'txtPatientID
        '
        Me.txtPatientID.Location = New System.Drawing.Point(133, 47)
        Me.txtPatientID.Name = "txtPatientID"
        Me.txtPatientID.Size = New System.Drawing.Size(229, 26)
        Me.txtPatientID.TabIndex = 18
        '
        'btnRefresh
        '
        Me.btnRefresh.BackColor = System.Drawing.Color.LightGray
        Me.btnRefresh.Location = New System.Drawing.Point(807, 34)
        Me.btnRefresh.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(97, 37)
        Me.btnRefresh.TabIndex = 19
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.pj._73.My.Resources.Resources.โลโก้
        Me.PictureBox1.Location = New System.Drawing.Point(967, -2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 69)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 20
        Me.PictureBox1.TabStop = False
        '
        'In_Patient_Report
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1067, 694)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.txtPatientID)
        Me.Controls.Add(Me.InPatientReportDataGridView)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "In_Patient_Report"
        Me.Text = "In_Patient_Report"
        CType(Me.DataDictionaryDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.In_PatientBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.In_PatientBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.In_PatientBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.In_PatientBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Vw_InPatient_ReportBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InPatientReportDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSearch As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents DataDictionaryDataSet As DataDictionaryDataSet
    Friend WithEvents In_PatientBindingSource As BindingSource
    Friend WithEvents In_PatientTableAdapter As DataDictionaryDataSetTableAdapters.In_PatientTableAdapter
    Friend WithEvents TableAdapterManager As DataDictionaryDataSetTableAdapters.TableAdapterManager
    Friend WithEvents In_PatientBindingSource1 As BindingSource
    Friend WithEvents In_PatientBindingSource2 As BindingSource
    Friend WithEvents In_PatientBindingSource3 As BindingSource
    Friend WithEvents Vw_InPatient_ReportBindingSource As BindingSource
    Friend WithEvents Vw_InPatient_ReportTableAdapter As DataDictionaryDataSetTableAdapters.vw_InPatient_ReportTableAdapter
    Friend WithEvents InPatientReportDataGridView As DataGridView
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
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents txtPatientID As TextBox
    Friend WithEvents btnRefresh As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
