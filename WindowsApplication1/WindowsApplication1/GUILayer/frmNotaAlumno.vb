Public Class frmNotaAlumno
    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub frmNotaAlumno_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If (frmConsultarNotas.tipo = "Fecha") Then
            Me.Location = New Point(MousePosition.X, MousePosition.Y)
        End If
        lblAlumno.Text = ""
        lblMateria.Text = ""
        lblTrimestre.Text = ""
        txtNota.Text = ""

        llenarDatos()
    End Sub

    Public Sub llenarDatos()
        With frmConsultarNotas
            If .tipo = "Fecha" Then
                lblFecha.Text = .dgvNotasTrim.Columns(.dgvNotasTrim.CurrentCell.ColumnIndex).Name
                lblAlumno.Text = .dgvNotasTrim.CurrentRow.Cells("Nombre").Value
                lblMateria.Text = .cmbMateria.Text
                lblTrimestre.Text = .cmbTrimestre.Text
                txtNota.Text = .dgvNotasTrim.CurrentCell.Value
            Else
                lblFecha.Text = "Final"
                lblAlumno.Text = .dgvFinal.CurrentRow.Cells("Nombre").Value
                lblMateria.Text = .cmbMateria.Text
                lblTrimestre.Text = .cmbTrimestre.Text
                txtNota.Text = .dgvFinal.CurrentCell.Value
            End If

        End With
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        Dim oNotaService As New NotaService
        With frmConsultarNotas
            If (frmConsultarNotas.tipo = "Fecha") Then
                If (oNotaService.actualizarNotaFecha(frmNotas.getCurso, .cmbMateria.SelectedValue, .cmbTrimestre.SelectedValue, .dgvNotasTrim.CurrentRow.Cells("Legajo").Value, txtNota.Text, lblFecha.Text)) Then
                    MsgBox("Actualizado con exito!")
                End If
            Else
                oNotaService.actualizarNotaFinal(frmNotas.getCurso, .cmbMateria.SelectedValue, .cmbTrimestre.SelectedValue, .dgvFinal.CurrentRow.Cells("Legajo").Value, txtNota.Text)
                MsgBox("Actualizado con exito!")
            End If
            frmConsultarNotas.cargarNotas()
            Me.Close()
        End With

    End Sub
End Class