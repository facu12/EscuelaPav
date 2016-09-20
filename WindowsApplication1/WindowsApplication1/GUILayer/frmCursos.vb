Public Class frmCursos
    Private Sub frmCursos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        momentoInicial() ' habilita los campos
        cargarInformacion() 'cargo los combos y la grilla

    End Sub

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
        txtAño.Enabled = True
        txtNivel.Enabled = True
        txtSubnivel.Enabled = True
        cmbMateria.Enabled = False
        cmbProfesor.Enabled = False
        dgvCursos.Enabled = False
        dgvMaterias.Enabled = False
        btnAgregarMateria.Enabled = False
        btnEliminarMateria.Enabled = False
        btnEliminarCurso.Enabled = False
        btnEditarCurso.Enabled = True
        btnEliminarCurso.Enabled = True
        btnFinalizar.Enabled = False
        btnCancelar.Visible = False
    End Sub

    Private Sub cargarInformacion()
        llenarComboMateria("nombre", "codMateria")
        llenarComboProfesor("nombre", "legajo")
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
            If oCurso.registrarCurso(curso) = 1 Then
                MsgBox("Curso Agregado")
            Else
                MsgBox("El curso ya existe, vuelva a intentarlo", vbCritical)
            End If


            momentoInicial()
            cargarInformacion()
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
        MsgBox("Seleccione curso a modificar")
        btnEliminarCurso.Enabled = False
        btnEditarCurso.Enabled = False
        txtAño.Enabled = False
        txtNivel.Enabled = False
        txtSubnivel.Enabled = False
        'btnEliminarMateria.Enabled = True
        dgvCursos.Enabled = True
        btnCancelar.Visible = True
        btnAgregarCurso.Enabled = False


    End Sub

    Private Sub dgvCursos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCursos.CellContentClick
        Dim oMateriaService As New MateriaService
        ' llenar los campos de los cursos
        txtAño.Text = dgvCursos.CurrentRow.Cells.Item("año").Value
        txtNivel.Text = dgvCursos.CurrentRow.Cells.Item("nivel").Value
        txtSubnivel.Text = dgvCursos.CurrentRow.Cells.Item("subnivel").Value
        habilitarEdicion()

        Dim cod_curso As String
        cod_curso = txtAño.Text + txtNivel.Text + txtSubnivel.Text
        'llenar las materias para ese curso
        For Each row As DataRow In oMateriaService.listarMateriaxCurso(cod_curso).Rows
            dgvMaterias.Rows.Add(New String() {row.Item("materia").ToString, row.Item("profesor").ToString})
        Next


    End Sub

    Private Sub habilitarEdicion()
        dgvMaterias.Enabled = True
        cmbMateria.Enabled = True
        cmbProfesor.Enabled = True
        btnAgregarMateria.Enabled = True

    End Sub

    Private Sub btnAgregarMateria_Click(sender As Object, e As EventArgs) Handles btnAgregarMateria.Click

    End Sub
End Class