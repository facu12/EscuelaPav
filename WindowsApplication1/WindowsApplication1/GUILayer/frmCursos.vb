Public Class frmCursos
    Private Sub frmCursos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenarCombosMateria("nombre", "codMateria")
    End Sub

    Private Sub llenarCombosMateria(ByVal display As String, ByVal value As String)
        Dim oMateriaService As New MateriaService

        cmbMateria1.DataSource = oMateriaService.listarMateria()
        cmbMateria1.DisplayMember = display
        cmbMateria1.ValueMember = value

        cmbMateria2.DataSource = oMateriaService.listarMateria()
        cmbMateria2.DisplayMember = display
        cmbMateria2.ValueMember = value

        cmbMateria3.DataSource = oMateriaService.listarMateria()
        cmbMateria3.DisplayMember = display
        cmbMateria3.ValueMember = value

        cmbMateria4.DataSource = oMateriaService.listarMateria()
        cmbMateria4.DisplayMember = display
        cmbMateria4.ValueMember = value

        cmbMateria5.DataSource = oMateriaService.listarMateria()
        cmbMateria5.DisplayMember = display
        cmbMateria5.ValueMember = value

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox(cmbMateria1.SelectedValue)
    End Sub
End Class