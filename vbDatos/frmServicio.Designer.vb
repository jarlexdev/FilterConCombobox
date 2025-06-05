<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmServicio
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim IdLabel As System.Windows.Forms.Label
        Dim FechaLabel As System.Windows.Forms.Label
        Dim IdEmpresaLabel As System.Windows.Forms.Label
        Dim IdCategoriaLabel As System.Windows.Forms.Label
        Dim DescripcionLabel As System.Windows.Forms.Label
        Dim PrecioLabel As System.Windows.Forms.Label
        Dim TipoServicioLabel As System.Windows.Forms.Label
        Dim FinalizadoLabel As System.Windows.Forms.Label
        Me.ServiciosPrestadosDataSet = New vbDatos.ServiciosPrestadosDataSet()
        Me.EmpresaTableAdapter = New vbDatos.ServiciosPrestadosDataSetTableAdapters.empresaTableAdapter()
        Me.ServicioDataGridView = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.IdTextBox = New System.Windows.Forms.TextBox()
        Me.FechaDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.IdEmpresaComboBox = New System.Windows.Forms.ComboBox()
        Me.IdCategoriaComboBox = New System.Windows.Forms.ComboBox()
        Me.DescripcionTextBox = New System.Windows.Forms.TextBox()
        Me.PrecioTextBox = New System.Windows.Forms.TextBox()
        Me.TipoServicioComboBox = New System.Windows.Forms.ComboBox()
        Me.FinalizadoCheckBox = New System.Windows.Forms.CheckBox()
        Me.cmbCategoria = New System.Windows.Forms.ComboBox()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.CategoriaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ServicioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmpresaBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.EmpresaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ServicioTableAdapter = New vbDatos.ServiciosPrestadosDataSetTableAdapters.servicioTableAdapter()
        Me.TableAdapterManager = New vbDatos.ServiciosPrestadosDataSetTableAdapters.TableAdapterManager()
        Me.CategoriaTableAdapter = New vbDatos.ServiciosPrestadosDataSetTableAdapters.CategoriaTableAdapter()
        IdLabel = New System.Windows.Forms.Label()
        FechaLabel = New System.Windows.Forms.Label()
        IdEmpresaLabel = New System.Windows.Forms.Label()
        IdCategoriaLabel = New System.Windows.Forms.Label()
        DescripcionLabel = New System.Windows.Forms.Label()
        PrecioLabel = New System.Windows.Forms.Label()
        TipoServicioLabel = New System.Windows.Forms.Label()
        FinalizadoLabel = New System.Windows.Forms.Label()
        CType(Me.ServiciosPrestadosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ServicioDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.CategoriaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ServicioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpresaBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpresaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.Location = New System.Drawing.Point(12, 27)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(19, 13)
        IdLabel.TabIndex = 0
        IdLabel.Text = "Id:"
        '
        'FechaLabel
        '
        FechaLabel.AutoSize = True
        FechaLabel.Location = New System.Drawing.Point(12, 54)
        FechaLabel.Name = "FechaLabel"
        FechaLabel.Size = New System.Drawing.Size(40, 13)
        FechaLabel.TabIndex = 2
        FechaLabel.Text = "Fecha:"
        '
        'IdEmpresaLabel
        '
        IdEmpresaLabel.AutoSize = True
        IdEmpresaLabel.Location = New System.Drawing.Point(12, 79)
        IdEmpresaLabel.Name = "IdEmpresaLabel"
        IdEmpresaLabel.Size = New System.Drawing.Size(63, 13)
        IdEmpresaLabel.TabIndex = 4
        IdEmpresaLabel.Text = "Id Empresa:"
        '
        'IdCategoriaLabel
        '
        IdCategoriaLabel.AutoSize = True
        IdCategoriaLabel.Location = New System.Drawing.Point(12, 106)
        IdCategoriaLabel.Name = "IdCategoriaLabel"
        IdCategoriaLabel.Size = New System.Drawing.Size(67, 13)
        IdCategoriaLabel.TabIndex = 6
        IdCategoriaLabel.Text = "Id Categoria:"
        '
        'DescripcionLabel
        '
        DescripcionLabel.AutoSize = True
        DescripcionLabel.Location = New System.Drawing.Point(12, 133)
        DescripcionLabel.Name = "DescripcionLabel"
        DescripcionLabel.Size = New System.Drawing.Size(66, 13)
        DescripcionLabel.TabIndex = 8
        DescripcionLabel.Text = "Descripcion:"
        '
        'PrecioLabel
        '
        PrecioLabel.AutoSize = True
        PrecioLabel.Location = New System.Drawing.Point(12, 159)
        PrecioLabel.Name = "PrecioLabel"
        PrecioLabel.Size = New System.Drawing.Size(40, 13)
        PrecioLabel.TabIndex = 10
        PrecioLabel.Text = "Precio:"
        '
        'TipoServicioLabel
        '
        TipoServicioLabel.AutoSize = True
        TipoServicioLabel.Location = New System.Drawing.Point(12, 185)
        TipoServicioLabel.Name = "TipoServicioLabel"
        TipoServicioLabel.Size = New System.Drawing.Size(72, 13)
        TipoServicioLabel.TabIndex = 12
        TipoServicioLabel.Text = "Tipo Servicio:"
        '
        'FinalizadoLabel
        '
        FinalizadoLabel.AutoSize = True
        FinalizadoLabel.Location = New System.Drawing.Point(12, 214)
        FinalizadoLabel.Name = "FinalizadoLabel"
        FinalizadoLabel.Size = New System.Drawing.Size(57, 13)
        FinalizadoLabel.TabIndex = 14
        FinalizadoLabel.Text = "Finalizado:"
        '
        'ServiciosPrestadosDataSet
        '
        Me.ServiciosPrestadosDataSet.DataSetName = "ServiciosPrestadosDataSet"
        Me.ServiciosPrestadosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EmpresaTableAdapter
        '
        Me.EmpresaTableAdapter.ClearBeforeFill = True
        '
        'ServicioDataGridView
        '
        Me.ServicioDataGridView.AllowUserToAddRows = False
        Me.ServicioDataGridView.AllowUserToDeleteRows = False
        Me.ServicioDataGridView.AutoGenerateColumns = False
        Me.ServicioDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ServicioDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn6})
        Me.ServicioDataGridView.DataSource = Me.ServicioBindingSource
        Me.ServicioDataGridView.Location = New System.Drawing.Point(7, 41)
        Me.ServicioDataGridView.Name = "ServicioDataGridView"
        Me.ServicioDataGridView.ReadOnly = True
        Me.ServicioDataGridView.Size = New System.Drawing.Size(633, 148)
        Me.ServicioDataGridView.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnLimpiar)
        Me.GroupBox1.Controls.Add(Me.cmbCategoria)
        Me.GroupBox1.Controls.Add(Me.btnImprimir)
        Me.GroupBox1.Controls.Add(IdLabel)
        Me.GroupBox1.Controls.Add(Me.IdTextBox)
        Me.GroupBox1.Controls.Add(FechaLabel)
        Me.GroupBox1.Controls.Add(Me.FechaDateTimePicker)
        Me.GroupBox1.Controls.Add(IdEmpresaLabel)
        Me.GroupBox1.Controls.Add(Me.IdEmpresaComboBox)
        Me.GroupBox1.Controls.Add(IdCategoriaLabel)
        Me.GroupBox1.Controls.Add(Me.IdCategoriaComboBox)
        Me.GroupBox1.Controls.Add(DescripcionLabel)
        Me.GroupBox1.Controls.Add(Me.DescripcionTextBox)
        Me.GroupBox1.Controls.Add(PrecioLabel)
        Me.GroupBox1.Controls.Add(Me.PrecioTextBox)
        Me.GroupBox1.Controls.Add(TipoServicioLabel)
        Me.GroupBox1.Controls.Add(Me.TipoServicioComboBox)
        Me.GroupBox1.Controls.Add(FinalizadoLabel)
        Me.GroupBox1.Controls.Add(Me.FinalizadoCheckBox)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 196)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(633, 253)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'btnImprimir
        '
        Me.btnImprimir.Location = New System.Drawing.Point(325, 27)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(75, 23)
        Me.btnImprimir.TabIndex = 16
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'IdTextBox
        '
        Me.IdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ServicioBindingSource, "Id", True))
        Me.IdTextBox.Location = New System.Drawing.Point(90, 24)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.Size = New System.Drawing.Size(200, 20)
        Me.IdTextBox.TabIndex = 1
        '
        'FechaDateTimePicker
        '
        Me.FechaDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.ServicioBindingSource, "Fecha", True))
        Me.FechaDateTimePicker.Location = New System.Drawing.Point(90, 50)
        Me.FechaDateTimePicker.Name = "FechaDateTimePicker"
        Me.FechaDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.FechaDateTimePicker.TabIndex = 3
        '
        'IdEmpresaComboBox
        '
        Me.IdEmpresaComboBox.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ServicioBindingSource, "IdEmpresa", True))
        Me.IdEmpresaComboBox.DataSource = Me.EmpresaBindingSource1
        Me.IdEmpresaComboBox.DisplayMember = "Nombre"
        Me.IdEmpresaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.IdEmpresaComboBox.FormattingEnabled = True
        Me.IdEmpresaComboBox.Location = New System.Drawing.Point(90, 76)
        Me.IdEmpresaComboBox.Name = "IdEmpresaComboBox"
        Me.IdEmpresaComboBox.Size = New System.Drawing.Size(200, 21)
        Me.IdEmpresaComboBox.TabIndex = 5
        Me.IdEmpresaComboBox.ValueMember = "Id"
        '
        'IdCategoriaComboBox
        '
        Me.IdCategoriaComboBox.FormattingEnabled = True
        Me.IdCategoriaComboBox.Location = New System.Drawing.Point(90, 103)
        Me.IdCategoriaComboBox.Name = "IdCategoriaComboBox"
        Me.IdCategoriaComboBox.Size = New System.Drawing.Size(200, 21)
        Me.IdCategoriaComboBox.TabIndex = 7
        '
        'DescripcionTextBox
        '
        Me.DescripcionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ServicioBindingSource, "Descripcion", True))
        Me.DescripcionTextBox.Location = New System.Drawing.Point(90, 130)
        Me.DescripcionTextBox.Name = "DescripcionTextBox"
        Me.DescripcionTextBox.Size = New System.Drawing.Size(200, 20)
        Me.DescripcionTextBox.TabIndex = 9
        '
        'PrecioTextBox
        '
        Me.PrecioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ServicioBindingSource, "Precio", True))
        Me.PrecioTextBox.Location = New System.Drawing.Point(90, 156)
        Me.PrecioTextBox.Name = "PrecioTextBox"
        Me.PrecioTextBox.Size = New System.Drawing.Size(200, 20)
        Me.PrecioTextBox.TabIndex = 11
        '
        'TipoServicioComboBox
        '
        Me.TipoServicioComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ServicioBindingSource, "TipoServicio", True))
        Me.TipoServicioComboBox.FormattingEnabled = True
        Me.TipoServicioComboBox.Location = New System.Drawing.Point(90, 182)
        Me.TipoServicioComboBox.Name = "TipoServicioComboBox"
        Me.TipoServicioComboBox.Size = New System.Drawing.Size(200, 21)
        Me.TipoServicioComboBox.TabIndex = 13
        '
        'FinalizadoCheckBox
        '
        Me.FinalizadoCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.ServicioBindingSource, "Finalizado", True))
        Me.FinalizadoCheckBox.Location = New System.Drawing.Point(90, 209)
        Me.FinalizadoCheckBox.Name = "FinalizadoCheckBox"
        Me.FinalizadoCheckBox.Size = New System.Drawing.Size(200, 24)
        Me.FinalizadoCheckBox.TabIndex = 15
        Me.FinalizadoCheckBox.UseVisualStyleBackColor = True
        '
        'cmbCategoria
        '
        Me.cmbCategoria.DataSource = Me.CategoriaBindingSource
        Me.cmbCategoria.DisplayMember = "Nombre"
        Me.cmbCategoria.FormattingEnabled = True
        Me.cmbCategoria.Location = New System.Drawing.Point(450, 29)
        Me.cmbCategoria.Name = "cmbCategoria"
        Me.cmbCategoria.Size = New System.Drawing.Size(121, 21)
        Me.cmbCategoria.TabIndex = 17
        Me.cmbCategoria.ValueMember = "Id"
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(482, 69)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(75, 23)
        Me.btnLimpiar.TabIndex = 18
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'CategoriaBindingSource
        '
        Me.CategoriaBindingSource.DataMember = "Categoria"
        Me.CategoriaBindingSource.DataSource = Me.ServiciosPrestadosDataSet
        '
        'ServicioBindingSource
        '
        Me.ServicioBindingSource.DataMember = "servicio"
        Me.ServicioBindingSource.DataSource = Me.ServiciosPrestadosDataSet
        '
        'EmpresaBindingSource1
        '
        Me.EmpresaBindingSource1.DataMember = "empresa"
        Me.EmpresaBindingSource1.DataSource = Me.ServiciosPrestadosDataSet
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 25
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Fecha"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Fecha"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 75
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "IdEmpresa"
        Me.DataGridViewTextBoxColumn3.DataSource = Me.EmpresaBindingSource
        Me.DataGridViewTextBoxColumn3.DisplayMember = "Nombre"
        Me.DataGridViewTextBoxColumn3.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.DataGridViewTextBoxColumn3.HeaderText = "Nombre de la Empresa"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn3.ValueMember = "Id"
        Me.DataGridViewTextBoxColumn3.Width = 200
        '
        'EmpresaBindingSource
        '
        Me.EmpresaBindingSource.DataMember = "empresa"
        Me.EmpresaBindingSource.DataSource = Me.ServiciosPrestadosDataSet
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "IdCategoria"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Categoría"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Precio"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Precio"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 50
        '
        'ServicioTableAdapter
        '
        Me.ServicioTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CategoriaTableAdapter = Nothing
        Me.TableAdapterManager.empresaTableAdapter = Nothing
        Me.TableAdapterManager.servicioTableAdapter = Me.ServicioTableAdapter
        Me.TableAdapterManager.UpdateOrder = vbDatos.ServiciosPrestadosDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CategoriaTableAdapter
        '
        Me.CategoriaTableAdapter.ClearBeforeFill = True
        '
        'frmServicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(650, 450)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ServicioDataGridView)
        Me.Name = "frmServicio"
        Me.Text = "frmServicio"
        CType(Me.ServiciosPrestadosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ServicioDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.CategoriaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ServicioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpresaBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpresaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ServiciosPrestadosDataSet As ServiciosPrestadosDataSet
    Friend WithEvents ServicioBindingSource As BindingSource
    Friend WithEvents ServicioTableAdapter As ServiciosPrestadosDataSetTableAdapters.servicioTableAdapter
    Friend WithEvents TableAdapterManager As ServiciosPrestadosDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ServicioDataGridView As DataGridView
    Friend WithEvents EmpresaTableAdapter As ServiciosPrestadosDataSetTableAdapters.empresaTableAdapter
    Friend WithEvents EmpresaBindingSource As BindingSource
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents IdTextBox As TextBox
    Friend WithEvents FechaDateTimePicker As DateTimePicker
    Friend WithEvents IdEmpresaComboBox As ComboBox
    Friend WithEvents EmpresaBindingSource1 As BindingSource
    Friend WithEvents IdCategoriaComboBox As ComboBox
    Friend WithEvents DescripcionTextBox As TextBox
    Friend WithEvents PrecioTextBox As TextBox
    Friend WithEvents TipoServicioComboBox As ComboBox
    Friend WithEvents FinalizadoCheckBox As CheckBox
    Friend WithEvents btnImprimir As Button
    Friend WithEvents cmbCategoria As ComboBox
    Friend WithEvents CategoriaBindingSource As BindingSource
    Friend WithEvents CategoriaTableAdapter As ServiciosPrestadosDataSetTableAdapters.CategoriaTableAdapter
    Friend WithEvents btnLimpiar As Button
End Class
