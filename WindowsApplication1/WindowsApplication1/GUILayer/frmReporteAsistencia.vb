Public Class frmReporteAsistencia
    Private Sub btnGenerar_Click(sender As Object, e As EventArgs) Handles btnGenerar.Click
        Dim reporte As New ReporteAsistencias
        Dim oCursoService As New CursoService
        If (txtAño.Text = "" Or txtNivel.Text = "" Or txtSubnivel.Text = "") Then
            MsgBox("Faltan Completar Datos", vbOK, "Datos Incompletos")
        Else
            If (oCursoService.listarAlumnosCurso(getCurso()).Rows.Count > 0) Then
                reporte.SetParameterValue("pCurso", getCurso())
                Me.rptNotas.ReportSource = reporte
                Me.rptNotas.Show()
                rptNotas.Refresh()
            Else
                MsgBox("No existe el curso buscado. Por favor, seleccione uno diferente", vbOK, "Curso Inexistente")
            End If
        End If

    End Sub

    Private Function getCurso() As String
        Return txtAño.Text + txtNivel.Text + txtSubnivel.Text
    End Function
End Class