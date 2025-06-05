Public Class frmServicio
    Private Sub ServicioBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.ServicioBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ServiciosPrestadosDataSet)

    End Sub

    Private Sub frmServicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ServiciosPrestadosDataSet.Categoria' Puede moverla o quitarla según sea necesario.
        Me.CategoriaTableAdapter.Fill(Me.ServiciosPrestadosDataSet.Categoria)
        'TODO: esta línea de código carga datos en la tabla 'ServiciosPrestadosDataSet.empresa' Puede moverla o quitarla según sea necesario.
        Me.EmpresaTableAdapter.Fill(Me.ServiciosPrestadosDataSet.empresa)
        'TODO: esta línea de código carga datos en la tabla 'ServiciosPrestadosDataSet.servicio' Puede moverla o quitarla según sea necesario.
        Me.ServicioTableAdapter.Fill(Me.ServiciosPrestadosDataSet.servicio)



    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        frmReporteServicios.ShowDialog()
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        Me.ServicioTableAdapter.Fill(Me.ServiciosPrestadosDataSet.servicio)
    End Sub

    Private Sub cmbCategoria_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCategoria.SelectedIndexChanged
        Dim CategoriaId As Integer = Convert.ToInt32(cmbCategoria.SelectedValue)
        Me.ServicioTableAdapter.FillByCategoria(Me.ServiciosPrestadosDataSet.servicio, CategoriaId)
    End Sub
End Class