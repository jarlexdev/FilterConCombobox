<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReporteServicios
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
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.VistaServicioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ServiciosPrestadosDataSet = New vbDatos.ServiciosPrestadosDataSet()
        Me.VistaServicioTableAdapter = New vbDatos.ServiciosPrestadosDataSetTableAdapters.vistaServicioTableAdapter()
        Me.cmbCategoria = New System.Windows.Forms.ComboBox()
        Me.VistaServicioBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.CategoriaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CategoriaTableAdapter = New vbDatos.ServiciosPrestadosDataSetTableAdapters.CategoriaTableAdapter()
        CType(Me.VistaServicioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ServiciosPrestadosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VistaServicioBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CategoriaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "vbDatos.rptServicios.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 65)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(800, 385)
        Me.ReportViewer1.TabIndex = 0
        '
        'VistaServicioBindingSource
        '
        Me.VistaServicioBindingSource.DataMember = "vistaServicio"
        Me.VistaServicioBindingSource.DataSource = Me.ServiciosPrestadosDataSet
        '
        'ServiciosPrestadosDataSet
        '
        Me.ServiciosPrestadosDataSet.DataSetName = "ServiciosPrestadosDataSet"
        Me.ServiciosPrestadosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VistaServicioTableAdapter
        '
        Me.VistaServicioTableAdapter.ClearBeforeFill = True
        '
        'cmbCategoria
        '
        Me.cmbCategoria.DataSource = Me.CategoriaBindingSource
        Me.cmbCategoria.DisplayMember = "Nombre"
        Me.cmbCategoria.FormattingEnabled = True
        Me.cmbCategoria.Location = New System.Drawing.Point(648, 38)
        Me.cmbCategoria.Name = "cmbCategoria"
        Me.cmbCategoria.Size = New System.Drawing.Size(121, 21)
        Me.cmbCategoria.TabIndex = 1
        Me.cmbCategoria.ValueMember = "Id"
        '
        'VistaServicioBindingSource1
        '
        Me.VistaServicioBindingSource1.DataMember = "vistaServicio"
        Me.VistaServicioBindingSource1.DataSource = Me.ServiciosPrestadosDataSet
        '
        'CategoriaBindingSource
        '
        Me.CategoriaBindingSource.DataMember = "Categoria"
        Me.CategoriaBindingSource.DataSource = Me.ServiciosPrestadosDataSet
        '
        'CategoriaTableAdapter
        '
        Me.CategoriaTableAdapter.ClearBeforeFill = True
        '
        'frmReporteServicios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.cmbCategoria)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "frmReporteServicios"
        Me.Text = "frmReporteServicios"
        CType(Me.VistaServicioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ServiciosPrestadosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VistaServicioBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CategoriaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ServiciosPrestadosDataSet As ServiciosPrestadosDataSet
    Friend WithEvents VistaServicioBindingSource As BindingSource
    Friend WithEvents VistaServicioTableAdapter As ServiciosPrestadosDataSetTableAdapters.vistaServicioTableAdapter
    Friend WithEvents cmbCategoria As ComboBox
    Friend WithEvents VistaServicioBindingSource1 As BindingSource
    Friend WithEvents CategoriaBindingSource As BindingSource
    Friend WithEvents CategoriaTableAdapter As ServiciosPrestadosDataSetTableAdapters.CategoriaTableAdapter
End Class
