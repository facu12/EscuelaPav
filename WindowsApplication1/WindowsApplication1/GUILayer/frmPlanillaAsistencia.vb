Public Class frmPlanillaAsistencia
    Dim oAsistenciaService As New AsistenciaService

    Private Sub frmPlanillaAsistencia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        aCero()
    End Sub



    Private Sub aCero()
        cargarComboTrimestre()
        lbl_cursoreal.Text = frmAsistencia.getCurso()
    End Sub

    Public Sub cargarComboTrimestre()
        cbo_trimestre.DataSource = oAsistenciaService.getTrimestres()
        cbo_trimestre.ValueMember = "trimestre"
        cbo_trimestre.DisplayMember = "descripcion"
        cbo_trimestre.SelectedIndex = -1
    End Sub

    Public Sub cargarAsistencias()

        dgv_asistencias.DataSource = oAsistenciaService.getAsistencias(frmAsistencia.getCurso(), cbo_trimestre.SelectedValue)
        dgv_asistencias.Columns.Item(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgv_asistencias.Columns.Item(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgv_asistencias.Columns.Item(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft

        dgv_totalizador.DataSource = oAsistenciaService.getAsistenciaTotal(frmAsistencia.getCurso(), cbo_trimestre.SelectedValue)

    End Sub



    Private Sub btn_consultar_Click(sender As Object, e As EventArgs) Handles btn_consultar.Click
        dgv_asistencias.DataSource = Nothing
        If cbo_trimestre.Text = "" Then
            MsgBox("Seleccione un Trimestre.")
        Else
            If oAsistenciaService.existeAsistencia(frmAsistencia.getCurso(), cbo_trimestre.SelectedValue) = "False" Then
                MsgBox("No Hay asistencias cargadas para ese trimestre!")
            Else
                cargarAsistencias()
            End If
        End If
    End Sub

    Private Sub btn_cerrar_Click(sender As Object, e As EventArgs) Handles btn_cerrar.Click
        Me.Close()
    End Sub

    Private Sub dgv_asistencias_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv_asistencias.CellContentClick
        If Not (dgv_asistencias.CurrentCell.ColumnIndex = "0" Or dgv_asistencias.CurrentCell.ColumnIndex = "1") Then
            frmEditarAsistencia.ShowDialog()
        End If
    End Sub

    Private Sub btn_borrar_dia_Click(sender As Object, e As EventArgs) Handles btn_borrar_dia.Click
        Dim fecha As String = InputBox("Seleccione la fecha a borrar: ", "Fecha a Borrar", Date.Today)
        If (MsgBox("Seguro que desea borrar la fecha " + fecha + " del " + cbo_trimestre.Text + " Trimestre?", vbYesNo, "Borrar Fecha") = vbYes) Then
            If (oAsistenciaService.borrarDia(lbl_cursoreal.Text, cbo_trimestre.SelectedValue, fecha) = "True") Then
                MsgBox("Eliminado con exito!")
                cargarAsistencias()
            Else
                MsgBox("No hay Asistencias para la fecha seleccionada, intente nuevamente")
            End If
        End If
    End Sub
End Class