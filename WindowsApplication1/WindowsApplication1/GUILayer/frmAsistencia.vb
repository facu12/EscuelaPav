Public Class frmAsistencia
    Private Sub frmAsistencia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        aCero()

    End Sub

    Private Sub aCero()
        mtb_fecha.Text = Nothing
        dgvAsistencia.Rows.Clear()
        dgvCursos.Rows.Clear()
        cargarComboAño()
        cargarComboTrimestre()
        mtb_fecha.Enabled = False
        cmbTrimestre.Enabled = False
    End Sub

    Private Sub cargarComboAño()
        Dim oAsistenciaService As New AsistenciaService
        cmbAño.DataSource = oAsistenciaService.getAño
        cmbAño.ValueMember = "Año"
        cmbAño.DisplayMember = "Año"
        cmbAño.Text = "Año"
    End Sub


    Private Sub cargarGrillaCurso(año As Integer)
        Dim oCursoService As New CursoService


        For Each row In oCursoService.listarCursosAño(año)
            With row
                dgvCursos.Rows.Add(New String() { .añolectivo.ToString, .nivel.ToString, .subnivel.ToString})
            End With
        Next



    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        cargarGrillaCurso(cmbAño.SelectedValue)
    End Sub



    Private Sub dgvCursos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCursos.CellContentClick
        dgvAsistencia.Rows.Clear()
        Dim curso As String = ""
        mtb_fecha.Enabled = True
        cmbTrimestre.Enabled = True
        curso = getCurso()
        llenarGridNotas(curso)
    End Sub

    Private Sub llenarGridNotas(curso As Integer)
        Dim oCursoService As New CursoService

        For Each row As DataRow In oCursoService.listarAlumnosCurso(curso).Rows
            With row
                dgvAsistencia.Rows.Add(New String() { .Item("legajo").ToString, .Item("nombre").ToString, getCurso()})
            End With
        Next
    End Sub

    Public Function getCurso()
        Return dgvCursos.CurrentRow.Cells.Item("col_año").Value + dgvCursos.CurrentRow.Cells.Item("col_nivel").Value + dgvCursos.CurrentRow.Cells.Item("col_subnivel").Value
    End Function

    Private Sub cargarComboTrimestre()
        Dim oAsistenciaService As New AsistenciaService
        cmbTrimestre.DataSource = oAsistenciaService.getTrimestres
        cmbTrimestre.ValueMember = "trimestre"
        cmbTrimestre.DisplayMember = "descripcion"
        cmbTrimestre.SelectedIndex = -1
    End Sub

    Private Sub btn_agregar_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click
        Dim oAsistenciaService As New AsistenciaService
        Dim tabla As New DataTable

        If dgvAsistencia.Rows.Count > 0 Then

            For Each col As DataGridViewColumn In dgvAsistencia.Columns
                tabla.Columns.Add(col.Name)
            Next


            For Each row As DataGridViewRow In dgvAsistencia.Rows
                Dim fila As DataRow = tabla.NewRow
                For Each cell As DataGridViewCell In row.Cells
                    fila(cell.ColumnIndex) = cell.Value
                Next
                tabla.Rows.Add(fila)
            Next



            If mtb_fecha.Text <> "  /  /    " And cmbTrimestre.SelectedIndex <> -1 Then
                If (oAsistenciaService.insertarAsistencias(tabla, cmbTrimestre.SelectedValue, mtb_fecha.Text)) Then
                    MsgBox("Asistencia del día Cargada!", vbOK, "Asistencia")
                    dgvAsistencia.Rows.Clear()
                    mtb_fecha.Text = Nothing
                End If
            Else
                MsgBox("Complete el campo Fecha")
            End If
        Else
            MsgBox("Seleccione un curso con alumnos")

        End If





    End Sub

    Private Sub btn_planilla_Click(sender As Object, e As EventArgs) Handles btn_planilla.Click
        frmPlanillaAsistencia.ShowDialog()

    End Sub


End Class