<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManageRequisition
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
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnOrder = New System.Windows.Forms.Button()
        Me.cboType = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtSupplyName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSupplyID = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtWardID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataDictionaryDataSet = New pj._73.DataDictionaryDataSet()
        Me.RequestionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RequestionTableAdapter = New pj._73.DataDictionaryDataSetTableAdapters.RequestionTableAdapter()
        Me.TableAdapterManager = New pj._73.DataDictionaryDataSetTableAdapters.TableAdapterManager()
        Me.RequestionDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.DataDictionaryDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RequestionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RequestionDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnDelete
        '
        Me.btnDelete.BackColor = System.Drawing.Color.Red
        Me.btnDelete.Location = New System.Drawing.Point(560, 272)
        Me.btnDelete.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(170, 49)
        Me.btnDelete.TabIndex = 56
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = False
        '
        'btnOrder
        '
        Me.btnOrder.BackColor = System.Drawing.Color.Green
        Me.btnOrder.Location = New System.Drawing.Point(327, 272)
        Me.btnOrder.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnOrder.Name = "btnOrder"
        Me.btnOrder.Size = New System.Drawing.Size(170, 49)
        Me.btnOrder.TabIndex = 55
        Me.btnOrder.Text = "Order"
        Me.btnOrder.UseVisualStyleBackColor = False
        '
        'cboType
        '
        Me.cboType.FormattingEnabled = True
        Me.cboType.Location = New System.Drawing.Point(705, 148)
        Me.cboType.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cboType.Name = "cboType"
        Me.cboType.Size = New System.Drawing.Size(217, 28)
        Me.cboType.TabIndex = 54
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(122, 201)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 20)
        Me.Label5.TabIndex = 53
        Me.Label5.Text = "Amount"
        '
        'txtAmount
        '
        Me.txtAmount.Location = New System.Drawing.Point(227, 198)
        Me.txtAmount.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(217, 26)
        Me.txtAmount.TabIndex = 52
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(627, 148)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 20)
        Me.Label4.TabIndex = 51
        Me.Label4.Text = "Type"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(112, 145)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 20)
        Me.Label3.TabIndex = 50
        Me.Label3.Text = "Supply Name"
        '
        'txtSupplyName
        '
        Me.txtSupplyName.Location = New System.Drawing.Point(227, 134)
        Me.txtSupplyName.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtSupplyName.Name = "txtSupplyName"
        Me.txtSupplyName.Size = New System.Drawing.Size(217, 26)
        Me.txtSupplyName.TabIndex = 49
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(615, 81)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 20)
        Me.Label2.TabIndex = 48
        Me.Label2.Text = "Supply ID"
        '
        'txtSupplyID
        '
        Me.txtSupplyID.Location = New System.Drawing.Point(705, 75)
        Me.txtSupplyID.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtSupplyID.Name = "txtSupplyID"
        Me.txtSupplyID.Size = New System.Drawing.Size(217, 26)
        Me.txtSupplyID.TabIndex = 47
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.LightGray
        Me.btnSearch.Location = New System.Drawing.Point(823, 14)
        Me.btnSearch.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(97, 37)
        Me.btnSearch.TabIndex = 46
        Me.btnSearch.Text = "SEARCH"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'txtWardID
        '
        Me.txtWardID.Location = New System.Drawing.Point(227, 78)
        Me.txtWardID.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtWardID.Name = "txtWardID"
        Me.txtWardID.Size = New System.Drawing.Size(217, 26)
        Me.txtWardID.TabIndex = 45
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(115, 81)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 20)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = " Ward ID"
        '
        'DataDictionaryDataSet
        '
        Me.DataDictionaryDataSet.DataSetName = "DataDictionaryDataSet"
        Me.DataDictionaryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RequestionBindingSource
        '
        Me.RequestionBindingSource.DataMember = "Requestion"
        Me.RequestionBindingSource.DataSource = Me.DataDictionaryDataSet
        '
        'RequestionTableAdapter
        '
        Me.RequestionTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.RequestionTableAdapter = Me.RequestionTableAdapter
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
        'RequestionDataGridView
        '
        Me.RequestionDataGridView.AutoGenerateColumns = False
        Me.RequestionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.RequestionDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.RequestionDataGridView.DataSource = Me.RequestionBindingSource
        Me.RequestionDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.RequestionDataGridView.Location = New System.Drawing.Point(0, 360)
        Me.RequestionDataGridView.Name = "RequestionDataGridView"
        Me.RequestionDataGridView.RowHeadersWidth = 62
        Me.RequestionDataGridView.RowTemplate.Height = 28
        Me.RequestionDataGridView.Size = New System.Drawing.Size(1067, 334)
        Me.RequestionDataGridView.TabIndex = 57
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "RQ_ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "RQ_ID"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 150
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "SU_ID"
        Me.DataGridViewTextBoxColumn2.HeaderText = "SU_ID"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 150
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "SU_name"
        Me.DataGridViewTextBoxColumn3.HeaderText = "SU_name"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 150
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "W_ID"
        Me.DataGridViewTextBoxColumn4.HeaderText = "W_ID"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 150
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "SU_Description"
        Me.DataGridViewTextBoxColumn5.HeaderText = "SU_Description"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 150
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "SU_Type"
        Me.DataGridViewTextBoxColumn6.HeaderText = "SU_Type"
        Me.DataGridViewTextBoxColumn6.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 150
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Amount"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Amount"
        Me.DataGridViewTextBoxColumn7.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 150
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.pj._73.My.Resources.Resources.โลโก้
        Me.PictureBox1.Location = New System.Drawing.Point(967, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 69)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 58
        Me.PictureBox1.TabStop = False
        '
        'ManageRequisition
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1067, 694)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.RequestionDataGridView)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnOrder)
        Me.Controls.Add(Me.cboType)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtAmount)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtSupplyName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtSupplyID)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtWardID)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "ManageRequisition"
        Me.Text = "ManageRequsition"
        CType(Me.DataDictionaryDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RequestionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RequestionDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnOrder As Button
    Friend WithEvents cboType As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtSupplyName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtSupplyID As TextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents txtWardID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DataDictionaryDataSet As DataDictionaryDataSet
    Friend WithEvents RequestionBindingSource As BindingSource
    Friend WithEvents RequestionTableAdapter As DataDictionaryDataSetTableAdapters.RequestionTableAdapter
    Friend WithEvents TableAdapterManager As DataDictionaryDataSetTableAdapters.TableAdapterManager
    Friend WithEvents RequestionDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents PictureBox1 As PictureBox
End Class
