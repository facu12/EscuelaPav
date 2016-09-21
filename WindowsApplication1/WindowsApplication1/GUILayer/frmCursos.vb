Public Class frmCursos
    Public action As Action_type

    Private Sub frmCursos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        momentoInicial() ' habilita los campos
        cargarCombos() 'cargo combos
        cargarCursos() 'cargo cursos
    End Sub
    Enum Action_type
        editar
        borrar
        mostrar
    End Enum

    Private Sub llenarDgvCursos()
        Dim oCursoService As New CursoService

        For Each row In oCursoService.listarCursos
            With row
                dgvCursos.Rows.Add(New String() { .añolectivo.ToString, .nivel.ToString, .subnivel.ToString})
            End With

        Next

    End Sub

    Private Sub llenarComboMateria(ByVal display As String, ByVal value As String)
        Dim oMateriaService As New MateriaService

        cmbMateria.DataSource = oMateriaService.listarMateria()
        cmbMateria.DisplayMember = display
        cmbMateria.ValueMember = value

    End Sub

    Private Sub llenarComboProfesor(ByVal display As String, ByVal value As String)
        Dim oProfesorService As New ProfesorService
        cmbProfesor.DataSource = oProfesorService.listarProfesorCombo()
        cmbProfesor.DisplayMember = display
        cmbProfesor.ValueMember = value
    End Sub

    Private Sub momentoInicial()
        txtAño.Enabled = False
        txtNivel.Enabled = False
        txtSubnivel.Enabled = False
        cmbMateria.Enabled = False
        cmbProfesor.Enabled = False
        dgvCursos.Enabled = True
        dgvMaterias.Enabled = False
        btnAgregarMateria.Enabled = False
        btnEliminarMateria.Enabled = False
        btnEliminarCurso.Enabled = False
        btnEditarCurso.Enabled = False
        btnFinalizar.Visible = False
        txtAño.Text = Nothing
        txtNivel.Text = Nothing
        txtSubnivel.Text = Nothing
        action = Action_type.mostrar
        btnAgregarCurso.Enabled = False
        mostrarBotones()
    End Sub

    Private Sub cargarCombos()
        llenarComboMateria("nombre", "codMateria")
        llenarComboProfesor("nombre", "legajo")
    End Sub

    Private Sub cargarCursos()
        dgvCursos.Rows.Clear()
        llenarDgvCursos()
    End Sub

    Private Sub limpiarCampos()
        txtAño.Text = Nothing
        txtNivel.Text = Nothing
        txtSubnivel.Text = Nothing
    End Sub

    Private Sub btnAgregarCurso_Click(sender As Object, e As EventArgs) Handles btnAgregarCurso.Click
        Dim oCurso As New CursoService
        If validarCurso() Then
            Dim curso As New Curso
            With curso
                .añolectivo = txtAño.Text
                .nivel = txtNivel.Text
                .subnivel = txtSubnivel.Text
            End With
            If oCurso.registrarCurso(curso) Then
                MsgBox("Curso Agregado")
            Else
                MsgBox("El curso ya existe, vuelva a intentarlo", vbCritical)
            End If


            momentoInicial()
            cargarCursos()
            limpiarCampos()

        Else
            MsgBox("Campos Invalidos, vuelva a ingresar el curso")
        End If
    End Sub

    Private Function validarCurso() As Boolean
        If String.IsNullOrEmpty(txtAño.Text) Or Not IsNumeric(txtAño.Text) Then
            Return False
        End If
        If String.IsNullOrEmpty(txtNivel.Text) Or Not IsNumeric(txtAño.Text) Then
            Return False
        End If
        If String.IsNullOrEmpty(txtSubnivel.Text) Then
            Return False
        End If

        Return True
    End Function

    Private Sub btnEditarCurso_Click(sender As Object, e As EventArgs) Handles btnEditarCurso.Click

        esconderBotones()
        txtAño.Enabled = False
        txtNivel.Enabled = False
        txtSubnivel.Enabled = False
        'btnEliminarMateria.Enabled = True
        dgvCursos.Enabled = True
        btnFinalizar.Visible = True
        btnAgregarCurso.Enabled = False

        limpiarCampos()
        ' llenar los campos de los cursos
        txtAño.Text = dgvCursos.CurrentRow.Cells.Item("año").Value
        txtNivel.Text = dgvCursos.CurrentRow.Cells.Item("nivel").Value
        txtSubnivel.Text = dgvCursos.CurrentRow.Cells.Item("subnivel").Value
        habilitarEdicion()
        esconderBotones()

        Dim cod_curso As String
        cod_curso = txtAño.Text + txtNivel.Text + txtSubnivel.Text

        'llenar las materias para ese curso
        llenarMateriaxCurso()

    End Sub
    Public Sub esconderBotones()
        btnEditarCurso.Visible = False
        btnEliminarCurso.Visible = False
        btnCurso.Visible = False
    End Sub

    Public Sub mostrarBotones()
        btnEditarCurso.Visible = True
        btnEliminarCurso.Visible = True
        btnCurso.Visible = True
        btnEliminarMateria.Visible = True
    End Sub

    Private Sub dgvCursos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCursos.CellContentClick
        btnEditarCurso.Enabled = True
        btnEliminarCurso.Enabled = true

        txtAño.Text = dgvCursos.CurrentRow.Cells.Item("año").Value
                txtNivel.Text = dgvCursos.CurrentRow.Cells.Item("nivel").Value
                txtSubnivel.Text = dgvCursos.CurrentRow.Cells.Item("subnivel").Value
                llenarMateriaxCurso()



    End Sub

    Private Sub habilitarEdicion()
        dgvMaterias.Enabled = True
        cmbMateria.Enabled = True
        cmbProfesor.Enabled = True
        btnAgregarMateria.Enabled = True

    End Sub

    Private Sub btnAgregarMateria_Click(sender As Object, e As EventArgs) Handles btnAgregarMateria.Click
        Dim oMateriaService As New MateriaService

        If oMateriaService.registrarMateriaenCurso(getCodigoCurso, cmbMateria.SelectedValue, cmbProfesor.SelectedValue) Then
            MsgBox("Materia Agregada")
            llenarMateriaxCurso()
            btnFinalizar.Enabled = True

        Else
            MsgBox("La Materia ya existe, intente nuevamente", vbCritical)

        End If
    End Sub

    Private Sub llenarMateriaxCurso()
        Dim oMateriaService As New MateriaService
        dgvMaterias.Rows.Clear()
        For Each row As DataRow In oMateriaService.listarMateriaxCurso(getCodigoCurso).Rows
            dgvMaterias.Rows.Add(New String() {row.Item("materia").ToString, row.Item("profesor").ToString})
        Next
        dgvMaterias.Refresh()

    End Sub

    Private Function getCodigoCurso() As String
        Dim cod_curso As String
        cod_curso = txtAño.Text + txtNivel.Text + txtSubnivel.Text
        Return cod_curso
    End Function

    Private Sub btnEliminarCurso_Click(sender As Object, e As EventArgs) Handles btnEliminarCurso.Click
        Dim oCursoService As New CursoService
        btnFinalizar.Visible = True
        dgvCursos.Enabled = True
        esconderBotones()

        limpiarCampos()
        esconderBotones()
        If MsgBox("Esta seguro que desea borrar el curso seleccionado?", vbYesNo, "Borrar") = vbYes Then
            Dim cod_curso As String
            cod_curso = dgvCursos.CurrentRow.Cells.Item("Año").Value
            cod_curso += dgvCursos.CurrentRow.Cells.Item("Nivel").Value
            cod_curso += dgvCursos.CurrentRow.Cells.Item("Subnivel").Value
            oCursoService.eliminarCurso(cod_curso)
            momentoInicial()
            cargarCursos()
        End If


    End Sub

    Private Sub btnFinalizar_Click(sender As Object, e As EventArgs) Handles btnFinalizar.Click
        momentoInicial() ' habilita los campos

        dgvMaterias.Rows.Clear()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs)
        momentoInicial() ' habilita los campos
        dgvMaterias.Rows.Clear()
    End Sub

    Private Sub btnCurso_Click(sender As Object, e As EventArgs) Handles btnCurso.Click
        MsgBox("Complete los datos del curso")
        txtAño.Enabled = True
        txtNivel.Enabled = True
        txtSubnivel.Enabled = True
        btnAgregarCurso.Enabled = True
    End Sub

    Private Sub dgvMaterias_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvMaterias.CellContentClick
        btnEliminarMateria.Enabled = True
    End Sub

    Private Sub btnEliminarMateria_Click(sender As Object, e As EventArgs) Handles btnEliminarMateria.Click
        Dim oMateriaService As New MateriaService

        If MsgBox("Seguro que desea borrar la materia?", vbYesNo, "Eliminar Materia") = vbYes Then
            oMateriaService.eliminarMateriasCursos(getCodigoCurso, cmbProfesor.SelectedValue, cmbMateria.SelectedValue)
        End If

        llenarMateriaxCurso()

    End Sub
End Class