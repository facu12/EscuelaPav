Public Class frmCursos
    Private Sub frmCursos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        momentoInicial()
        llenarComboMateria("nombre", "codMateria")
        llenarComboProfesor("nombre", "legajo")

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
        dgvCursos.Enabled = False
        dgvMaterias.Enabled = False
        btnAgregar.Enabled = False
        btnEliminar.Enabled = False
        btnEliminarCurso.Enabled = False
        btnEditarCurso.Enabled = False
        btnEliminarCurso.Enabled = False
        btnFinalizar.Enabled = False
    End Sub

End Class