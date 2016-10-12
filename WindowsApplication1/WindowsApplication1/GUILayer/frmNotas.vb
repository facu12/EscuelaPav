Public Class frmNotas
    Private Sub frmNotas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarComboAño()
    End Sub

    Private Sub cargarComboAño()
        Dim oCursoService As New CursoService
        cmbAño.DataSource = oCursoService.getAño
        cmbAño.ValueMember = "Año"
        cmbAño.DisplayMember = "Año"
        cmbAño.Text = "Año"
    End Sub

    'Private Sub cmbAño_MouseClick(sender As Object, e As MouseEventArgs) Handles cmbAño.MouseClick
    '    cargarComboAño()

    'End Sub

    Private Sub cargarGrillaCurso(año As Integer)
        Dim oCursoService As New CursoService

        dgvCursos.Rows.Clear()

        For Each row In oCursoService.listarCursosAño(año)
            With row
                dgvCursos.Rows.Add(New String() { .añolectivo.ToString, .nivel.ToString, .subnivel.ToString})
            End With
        Next
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        cargarGrillaCurso(cmbAño.SelectedValue)
    End Sub

    Private Sub cmbAño_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbAño.SelectedIndexChanged

    End Sub

    Private Sub dgvCursos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCursos.CellContentClick
        Dim curso As String = ""
        cmbMateria.Enabled = True
        cmbTipoNota.Enabled = True
        cmbTrimestre.Enabled = True
        dgvNotas.Enabled = True
        curso = getCurso()
        llenarGridNotas(curso)
        cargarComboMateria()
        cargarComboTrimestre()
        cargarComboTipoNota()
    End Sub

    Private Sub cargarComboTipoNota()
        Dim oNotaservice As New NotaService
        cmbTipoNota.DataSource = oNotaservice.getTipoNota
        cmbTipoNota.ValueMember = "tipo_nota"
        cmbTipoNota.DisplayMember = "descripcion"
    End Sub

    Private Sub cargarComboTrimestre()
        Dim oNotaService As New NotaService
        cmbTrimestre.DataSource = oNotaService.getTrimestres
        cmbTrimestre.ValueMember = "trimestre"
        cmbTrimestre.DisplayMember = "descripcion"
    End Sub
    Private Sub cargarComboMateria()
        Dim oCursoService As New CursoService

        cmbMateria.DataSource = Nothing
        cmbMateria.DataSource = oCursoService.listarMateriaCurso(getCurso)
        cmbMateria.DisplayMember = "nombre"
        cmbMateria.ValueMember = "cod_materia"
    End Sub

    Private Sub llenarGridNotas(curso As Integer)
        Dim oCursoService As New CursoService
        dgvNotas.Rows.Clear()
        For Each row As DataRow In oCursoService.listarAlumnosCurso(curso).Rows
            With row
                dgvNotas.Rows.Add(New String() { .Item("legajo").ToString, .Item("nombre").ToString, getCurso()})
            End With
        Next
    End Sub

    Private Function getCurso()
        Return dgvCursos.CurrentRow.Cells.Item("col_año").Value + dgvCursos.CurrentRow.Cells.Item("col_nivel").Value + dgvCursos.CurrentRow.Cells.Item("col_subnivel").Value
    End Function

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        limpiar()
    End Sub
    Private Sub limpiar()
        dgvCursos.Rows.Clear()
        dgvNotas.Rows.Clear()
        cmbMateria.Enabled = False
        cmbTipoNota.Enabled = False
        cmbTrimestre.Enabled = False
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim oNotasService As New NotaService
        Dim tabla As New DataTable

        If dgvNotas.Rows.Count > 0 Then

            For Each col As DataGridViewColumn In dgvNotas.Columns
                tabla.Columns.Add(col.Name)
            Next


            For Each row As DataGridViewRow In dgvNotas.Rows
                Dim fila As DataRow = tabla.NewRow
                For Each cell As DataGridViewCell In row.Cells
                    fila(cell.ColumnIndex) = cell.Value
                Next
                tabla.Rows.Add(fila)
            Next



            If txtFecha.Text <> "  /  /" Then
                If (oNotasService.insertarNotas(tabla, cmbTipoNota.SelectedValue, cmbTrimestre.SelectedValue, txtFecha.Text, cmbMateria.SelectedValue)) Then
                    MsgBox("Agregado!", vbOK, "Nota")
                End If
            Else
                MsgBox("Complete el campo Fecha")
            End If
        Else
            MsgBox("Seleccione un curso con alumnos")

        End If




    End Sub
End Class