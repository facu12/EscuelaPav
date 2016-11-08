Public Class frmEstadisticasNotas
    Private Sub btnGenerar_Click(sender As Object, e As EventArgs) Handles btnGenerar.Click
        Dim reporte As New DocNotas
        Dim oCursoService As New CursoService
        If (txtAño.Text = "") Then
            MsgBox("Faltan Completar Datos", vbOK, "Datos Incompletos")
        Else
            If (oCursoService.listarCursosAño(txtAño.Text).Count > 0) Then
                reporte.SetParameterValue("@año", txtAño.Text)
                rptNotas.ReportSource = reporte
                rptNotas.Show()
                rptNotas.Refresh()
            Else
                MsgBox("No existe el curso buscado. Por favor, seleccione uno diferente", vbOK, "Curso Inexistente")
            End If
        End If
    End Sub
End Class