Public Class frmAsistencia
    Private Sub frmAsistencia_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub cargarComboAño()
        Dim oCursoService As New CursoService
        cmbAño.DataSource = oCursoService.getAño
        cmbAño.ValueMember = "Año"
        cmbAño.DisplayMember = "Año"
    End Sub

    'Private Sub cmbAño_MouseClick(sender As Object, e As MouseEventArgs) Handles cmbAño.MouseClick
    '    cargarComboAño()

    'End Sub

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

    Private Sub cmbAño_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbAño.SelectedIndexChanged

    End Sub

    Private Sub dgvCursos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCursos.CellContentClick

    End Sub

    Private Sub llenarGridNotas(curso As Integer)

    End Sub
End Class