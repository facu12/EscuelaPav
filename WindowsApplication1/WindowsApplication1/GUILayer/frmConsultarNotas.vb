Public Class frmConsultarNotas
    Public tipo As String

    Private Sub btnConsultar_Click(sender As Object, e As EventArgs) Handles btnConsultar.Click
        Dim oNotaService As New NotaService
        dgvNotasTrim.DataSource = Nothing
        If cmbMateria.Text = "" Or cmbTrimestre.Text = "" Then
            MsgBox("Faltan Completar Datos.")
        Else
            If oNotaService.existeNota(frmNotas.getCurso(), cmbMateria.SelectedValue, cmbTrimestre.SelectedValue) = "False" Then
                MsgBox("No Existen Notas Para Esa Materia!")
            Else
                cargarNotas()
            End If
        End If
    End Sub

    Public Sub cargarNotas()
        Dim oNotaService As New NotaService
        dgvNotasTrim.DataSource = oNotaService.getNotas(frmNotas.getCurso(), cmbMateria.SelectedValue, cmbTrimestre.SelectedValue)
        dgvNotasTrim.Columns.Item(1).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvNotasTrim.Columns.Item(0).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvFinal.DataSource = oNotaService.getNotaFinal(frmNotas.getCurso(), cmbMateria.SelectedValue, cmbTrimestre.SelectedValue)
        dgvFinal.Columns.Item(1).Visible = False
        dgvFinal.Columns.Item(2).Visible = False
    End Sub

    Private Sub frmConsultarNotas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim oNotaService As New NotaService
        cargarComboTrimestre()
        cargarComboMateria()


        'lblTitulo.Text = "Planilla de Notas del Curso: "
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
        cmbMateria.DataSource = oCursoService.listarMateriaCurso(frmNotas.getCurso)
        cmbMateria.DisplayMember = "nombre"
        cmbMateria.ValueMember = "cod_materia"
    End Sub

    Private Sub dgvNotasTrim_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvNotasTrim.CellContentClick
        If Not (dgvNotasTrim.CurrentCell.ColumnIndex = "0" Or dgvNotasTrim.CurrentCell.ColumnIndex = "1") Then
            tipo = "Fecha"
            frmNotaAlumno.ShowDialog()
        End If
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub btnBorrarDia_Click(sender As Object, e As EventArgs) Handles btnBorrarDia.Click
        Dim fecha As String = InputBox("Seleccione la fecha a borrar: ", "Fecha a Borrar", Date.Today)
        Dim oNotaService As New NotaService
        If (MsgBox("Seguro que desea borrar la fecha " + fecha + ", Para la materia " + cmbMateria.Text + " del " + cmbTrimestre.Text + "?", vbYesNo, "Borrar Fecha") = vbYes) Then
            If (oNotaService.borrarDia(frmNotas.getCurso(), cmbMateria.SelectedValue, cmbTrimestre.SelectedValue, fecha) = "True") Then
                MsgBox("Eliminado con exito!")
                cargarNotas()
            Else
                MsgBox("No hay notas para la fecha seleccionada, intente nuevamente")
            End If
        End If
    End Sub

    Private Sub btnBorrarFinal_Click(sender As Object, e As EventArgs) Handles btnBorrarFinal.Click
        Dim oNotaService As New NotaService
        If (MsgBox("Seguro que desea borrar el final?", vbYesNo, "Borrar Final") = vbYes) Then
            If (oNotaService.borrarFinal(frmNotas.getCurso(), cmbMateria.SelectedValue, cmbTrimestre.SelectedValue) = "True") Then
                MsgBox("Eliminado con exito!")
                cargarNotas()
            Else
                MsgBox("Error al borrar")
            End If
        End If
    End Sub

    Private Sub dgvFinal_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvFinal.CellContentClick
        If Not (dgvNotasTrim.CurrentCell.Value.ToString = "") Then
            tipo = "Final"
            frmNotaAlumno.ShowDialog()
        End If
    End Sub
End Class