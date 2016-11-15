Imports System.Text.RegularExpressions

Public Class frmEstadisticasNotas
    Private Sub btnGenerar_Click(sender As Object, e As EventArgs) Handles btnGenerar.Click
        Dim reporte As New DocNotas
        Dim oCursoService As New CursoService
        If (txtAño.Text = "" Or txtNivel.Text = "") Then
            MsgBox("Faltan Completar Datos", vbOK, "Datos Incompletos")
        Else
            If (oCursoService.getCursosAñoNivel(txtAño.Text, txtNivel.Text).Count > 0) Then
                reporte.SetParameterValue("@año", txtAño.Text)
                reporte.SetParameterValue("@curso", txtNivel.Text)
                reporte.SetParameterValue("pAño", txtAño.Text)
                reporte.SetParameterValue("pCurso", txtNivel.Text)
                rptNotas.ReportSource = reporte
                rptNotas.Show()
                rptNotas.Refresh()
            Else
                MsgBox("No existe el curso buscado. Por favor, seleccione uno diferente", vbOK, "Curso Inexistente")
            End If
        End If
    End Sub

    Private Sub frmEstadisticasNotas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rptNotas.ReportSource = Nothing
        rptNotas.Show()
        rptNotas.Refresh()
        txtNivel.Text = ""
        txtAño.Text = ""
    End Sub

    Private Sub validarNumericos(sender As Object, e As EventArgs) Handles txtAño.Leave, txtNivel.Leave
        If Not Regex.Match(CType(sender, TextBox).Text, "^[0-9]\d*(\.\d+)?$").Success Then
            MessageBox.Show("Por favor ingrese solo caracteres Numéricos!")
            CType(sender, TextBox).Clear()
        End If
    End Sub
End Class