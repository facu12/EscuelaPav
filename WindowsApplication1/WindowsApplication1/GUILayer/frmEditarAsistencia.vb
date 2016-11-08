Public Class frmEditarAsistencia
    Private Sub frmEditarAsistencia_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lbl_alumno.Text = ""
        lbl_curso.Text = ""
        lbl_fecha.Text = ""
        lbl_trimestre.Text = ""
        llenarDatos()

    End Sub


    Public Sub llenarDatos()
        With frmPlanillaAsistencia
            lbl_fecha.Text = .dgv_asistencias.Columns(.dgv_asistencias.CurrentCell.ColumnIndex).Name
            lbl_alumno.Text = .dgv_asistencias.CurrentRow.Cells("Nombre").Value
            lbl_trimestre.Text = .cbo_trimestre.Text
            lbl_curso.Text = .lbl_cursoreal.Text
            txt_asistencia.Text = .dgv_asistencias.CurrentCell.Value

        End With

    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Dim oAsistenciaService As New AsistenciaService
        With frmPlanillaAsistencia
            If (txt_asistencia.Text <> "") Then
                If (oAsistenciaService.ActualizarAsistencia(.lbl_cursoreal.Text, .cbo_trimestre.SelectedValue, .dgv_asistencias.CurrentRow.Cells("Legajo").Value, txt_asistencia.Text, lbl_fecha.Text, Justificada(chk_justif.Checked))) Then
                    MsgBox("Actualizado con exito!", vbOKOnly, "Actualizacion")
                End If

            End If
            frmPlanillaAsistencia.cargarAsistencias()
            Me.Close()
        End With

    End Sub

    Public Function Justificada(estado As Boolean) As Integer
        Dim ban As Integer = 0
        If estado = True Then
            ban = 1
        Else
            ban = 0
        End If
        Return ban
    End Function




    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

End Class