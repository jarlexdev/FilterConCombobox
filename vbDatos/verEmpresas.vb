Imports Microsoft.Reporting.WinForms

Public Class verEmpresas
    Private Sub verEmpresas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ServiciosPrestadosDataSet.empresa' Puede moverla o quitarla según sea necesario.
        Me.EmpresaTableAdapter.Fill(Me.ServiciosPrestadosDataSet.empresa)

        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub cerrar_Click(sender As Object, e As EventArgs) Handles cerrar.Click
        Close()
    End Sub

    Private Sub ReportViewer1_Load(sender As Object, e As EventArgs) Handles ReportViewer1.Load
        Dim parameters As ReportParameter() = New ReportParameter(1) {}

        parameters(0) = New ReportParameter("fechainicial", "2024-01-01")
        parameters(1) = New ReportParameter("fechafinal", "2024-12-31")

        ReportViewer1.LocalReport.SetParameters(parameters)
        ReportViewer1.RefreshReport()
    End Sub

    Private Sub btnFiltrar_Click(sender As Object, e As EventArgs) Handles btnFiltrar.Click
        Dim saldoFiltro As Decimal

        If Decimal.TryParse(txtSaldo.Text, saldoFiltro) Then
            Me.EmpresaBindingSource.Filter = "saldo <= " & saldoFiltro.ToString()
            Me.ReportViewer1.RefreshReport()
        Else
            MessageBox.Show("Ingrese un valor numérico válido para el saldo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class