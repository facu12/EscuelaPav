Public Class frmPlanillaAsistencia
    Private oAsistenciaService As AsistenciaService
    Private Sub frmPlanillaAsistencia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        aCero()
    End Sub



    Private Sub aCero()

    End Sub

    Private Sub llenarGridAsistencias(fecha As String)


        For Each row As DataRow In oAsistenciaService.getDatosFecha(fecha).Rows
            With row
                dgv_asistencias.Rows.Add(New String() { .Item("legajo").ToString, .Item("nombre").ToString, getCurso()})
            End With
        Next
    End Sub

    Private Sub dtp_dia_ValueChanged(sender As Object, e As EventArgs) Handles dtp_dia.ValueChanged
        llenarGridAsistencias(dtp_dia.Value.ToString)
    End Sub


End Class