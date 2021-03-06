﻿Public Class frmAsignarAlumno
    Private Sub frmAsignarAlumno_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargarComboAño()
        momentoInicial()
    End Sub

    Private Sub cargarComboAño()
        Dim oCursoService As New CursoService
        cmbAño.DataSource = oCursoService.getAño
        cmbAño.ValueMember = "Año"
        cmbAño.DisplayMember = "Año"
        cmbAño.Text = "Año"
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        cargarGrillaCurso(cmbAño.SelectedValue)
        dgvCursos.Enabled = True
    End Sub

    Private Sub cargarGrillaCurso(año As Integer)
        Dim oCursoService As New CursoService

        dgvCursos.Rows.Clear()

        For Each row In oCursoService.listarCursosAño(año)
            With row
                dgvCursos.Rows.Add(New String() { .añolectivo.ToString, .nivel.ToString, .subnivel.ToString})
            End With
        Next
    End Sub

    Private Sub dgvCursos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCursos.CellContentClick
        Dim curso As String = ""
        dgvAlumnos.Enabled = True
        dgvCursoAlu.Enabled = True
        curso = getCurso()
        llenarGridAlumnos(curso)
        llenarGridAlumnosTotal(curso)
    End Sub

    Private Sub llenarGridAlumnos(curso As Integer)
        Dim oCursoService As New CursoService
        dgvCursoAlu.Rows.Clear()
        For Each row As DataRow In oCursoService.listarAlumnosCurso(curso).Rows
            With row
                dgvCursoAlu.Rows.Add(New String() { .Item("legajo").ToString, .Item("nombre").ToString, getCurso()})
            End With
        Next
    End Sub

    Private Sub llenarGridAlumnosTotal(curso As Integer)
        Dim oAlumnoService As New AlumnoService
        Dim nombre As String = ""
        dgvAlumnos.Rows.Clear()
        For Each row In oAlumnoService.listarAlumnosTotal(getCurso)
            With row
                nombre = .apellido + ", " + .nombre
                dgvAlumnos.Rows.Add(New String() { .legajo.ToString, nombre})
            End With
        Next
    End Sub

    Private Function getCurso()
        Return dgvCursos.CurrentRow.Cells.Item("col_año").Value + dgvCursos.CurrentRow.Cells.Item("col_nivel").Value + dgvCursos.CurrentRow.Cells.Item("col_subnivel").Value
    End Function

    Private Sub cmbAño_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbAño.SelectedIndexChanged

    End Sub

    Private Sub cmbAño_Click(sender As Object, e As EventArgs) Handles cmbAño.Click
        btnBuscar.Enabled = True
    End Sub

    Private Sub btnBuscarAlumno_Click(sender As Object, e As EventArgs) Handles btnBuscarAlumno.Click
        buscarAlumno(txtApellido.Text)
    End Sub

    Friend Sub buscarAlumno(ByVal apellido As String, Optional ByVal lst As List(Of Alumno) = Nothing)
        'busca un alumno por apellido 
        Dim oAlumnoService As New AlumnoService
        Dim nombre As String = ""
        dgvAlumnos.Rows.Clear()

        If IsNothing(lst) Then
            lst = oAlumnoService.listarAlumnosConFiltros(apellido)
        End If

        'Asignamos a la propiedad SelectionMode el valor FullRowSelect para que 
        'al hacer click sobre la grilla se resalte toda la fila completa. Esto puede tmb hacerse en modo diseño.
        dgvAlumnos.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvAlumnos.Rows.Clear()
        For Each oAlumno In lst
            With oAlumno
                'cargar filas del datagridview a partir de un array de strings
                nombre = .apellido + ", " + .nombre
                dgvAlumnos.Rows.Add(New String() { .legajo.ToString, nombre})
            End With
        Next
    End Sub

    Private Sub dgvAlumnos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAlumnos.CellContentClick
        btnAgregar.Enabled = True
        btnFinalizar.Enabled = True
    End Sub

    Private Sub dgvCursoAlu_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCursoAlu.CellContentClick
        btnEliminar.Enabled = True
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        dgvCursoAlu.Rows.Add(New String() {dgvAlumnos.CurrentRow.Cells.Item("col_legajo").Value.ToString, dgvAlumnos.CurrentRow.Cells.Item("col_nombre").Value.ToString, getCurso()})
        dgvAlumnos.Rows.Remove(dgvAlumnos.CurrentRow)
        btnFinalizar.Enabled = True
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        dgvAlumnos.Rows.Add(New String() {dgvCursoAlu.CurrentRow.Cells.Item("col1_legajo").Value.ToString, dgvCursoAlu.CurrentRow.Cells.Item("col1_nombre").Value.ToString})
        dgvCursoAlu.Rows.Remove(dgvCursoAlu.CurrentRow)
        btnFinalizar.Enabled = True
    End Sub

    Private Sub btnFinalizar_Click(sender As Object, e As EventArgs) Handles btnFinalizar.Click
        Dim oCursoService As New CursoService
        oCursoService.limpiarCurso(getCurso)

        Dim tabla As New DataTable

        If dgvCursoAlu.Rows.Count > 0 Then

            For Each col As DataGridViewColumn In dgvCursoAlu.Columns
                tabla.Columns.Add(col.Name)
            Next

            For Each row As DataGridViewRow In dgvCursoAlu.Rows
                Dim fila As DataRow = tabla.NewRow
                For Each cell As DataGridViewCell In row.Cells
                    fila(cell.ColumnIndex) = cell.Value
                Next
                tabla.Rows.Add(fila)
            Next

            If (oCursoService.asignarAlumnos(tabla)) Then
                MsgBox("Alumnos Agregados con exito", vbOK, "Agregado con exito")
            End If

        End If

    End Sub

    Private Sub momentoInicial()
        dgvCursoAlu.Enabled = False
        dgvAlumnos.Enabled = False
        dgvCursos.Enabled = False
        btnAgregar.Enabled = False
        btnEliminar.Enabled = False
        btnFinalizar.Enabled = False
    End Sub

    Private Sub btn_cerrar_Click(sender As Object, e As EventArgs) Handles btn_cerrar.Click
        Me.Close()
    End Sub
End Class