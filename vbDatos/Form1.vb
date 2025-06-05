Public Class Form1
    Private Sub EmpresaBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.EmpresaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ServiciosPrestadosDataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ServiciosPrestadosDataSet.empresa' Puede moverla o quitarla según sea necesario.
        Me.EmpresaTableAdapter.Fill(Me.ServiciosPrestadosDataSet.empresa)

    End Sub

    Private Sub salir_Click(sender As Object, e As EventArgs) Handles salir.Click
        Close()
    End Sub

    Private Sub nuevo_Click(sender As Object, e As EventArgs) Handles nuevo.Click
        EmpresaBindingSource.AddNew()
        NombreTextBox.Focus()
    End Sub

    Private Sub cancelar_Click(sender As Object, e As EventArgs) Handles cancelar.Click
        EmpresaBindingSource.CancelEdit()
    End Sub

    Private Sub guardar_Click(sender As Object, e As EventArgs) Handles guardar.Click
        EmpresaBindingSource.EndEdit()
        EmpresaTableAdapter.Update(ServiciosPrestadosDataSet)
        ServiciosPrestadosDataSet.AcceptChanges()
        Me.EmpresaTableAdapter.Fill(Me.ServiciosPrestadosDataSet.empresa)
    End Sub

    Private Sub modificar_Click(sender As Object, e As EventArgs) Handles modificar.Click
        NombreTextBox.Focus()
    End Sub

    Private Sub eliminar_Click(sender As Object, e As EventArgs) Handles eliminar.Click
        If MessageBox.Show("¿Está seguro de eliminar el registro?", "Confirme", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Try
                EmpresaBindingSource.RemoveCurrent()
                EmpresaTableAdapter.Update(ServiciosPrestadosDataSet)
                ServiciosPrestadosDataSet.AcceptChanges()
                Me.EmpresaTableAdapter.Fill(Me.ServiciosPrestadosDataSet.empresa)
            Catch ex As Exception
                MessageBox.Show("Lo siento. No es posible eliminar el registro.", "Atención")
                Me.EmpresaTableAdapter.Fill(Me.ServiciosPrestadosDataSet.empresa)
            End Try
        End If
    End Sub

    Private Sub imprimir_Click(sender As Object, e As EventArgs) Handles imprimir.Click
        verEmpresas.ShowDialog()
    End Sub
End Class
