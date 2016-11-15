Imports System.Text.RegularExpressions

Public Class frmReporteNota
    Private Sub btnGenerar_Click(sender As Object, e As EventArgs) Handles btnGenerar.Click
        Dim reporte As New ReporteNotas
        Dim oCursoService As New CursoService
        If (txtAño.Text = "" Or txtNivel.Text = "" Or txtSubnivel.Text = "") Then
            MsgBox("Faltan Completar Datos", vbOK, "Datos Incompletos")
        Else
            If (oCursoService.listarAlumnosCurso(getCurso()).Rows.Count > 0) Then
                reporte.SetParameterValue("pCurso", getCurso())
                reporte.SetParameterValue("pTipoNota", "F")
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

    Private Sub frmReporteNota_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter
        rptNotas.ReportSource = Nothing
        rptNotas.Refresh()
        txtAño.Text = ""
        txtNivel.Text = ""
        txtSubnivel.Text = ""
    End Sub

    Private Sub validarNumericos(sender As Object, e As EventArgs) Handles txtAño.Leave, txtNivel.Leave, txtSubnivel.Leave
        If Not Regex.Match(CType(sender, TextBox).Text, "^[0-9]\d*(\.\d+)?$").Success Then
            MessageBox.Show("Por favor ingrese solo caracteres Numéricos!")
            CType(sender, TextBox).Clear()
        End If
    End Sub
End Class