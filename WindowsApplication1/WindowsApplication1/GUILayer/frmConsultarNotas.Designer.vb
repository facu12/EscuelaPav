﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConsultarNotas
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.cmbMateria = New System.Windows.Forms.ComboBox()
        Me.cmbTrimestre = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dgvNotasTrim = New System.Windows.Forms.DataGridView()
        Me.btnConsultar = New System.Windows.Forms.Button()
        Me.dgvFinal = New System.Windows.Forms.DataGridView()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.btnBorrarDia = New System.Windows.Forms.Button()
        Me.btnBorrarFinal = New System.Windows.Forms.Button()
        CType(Me.dgvNotasTrim, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvFinal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitulo.Location = New System.Drawing.Point(401, 7)
        Me.lblTitulo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New System.Drawing.Size(126, 20)
        Me.lblTitulo.TabIndex = 0
        Me.lblTitulo.Text = "Planilla de Notas"
        '
        'cmbMateria
        '
        Me.cmbMateria.FormattingEnabled = True
        Me.cmbMateria.Location = New System.Drawing.Point(120, 41)
        Me.cmbMateria.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmbMateria.Name = "cmbMateria"
        Me.cmbMateria.Size = New System.Drawing.Size(92, 21)
        Me.cmbMateria.TabIndex = 1
        '
        'cmbTrimestre
        '
        Me.cmbTrimestre.FormattingEnabled = True
        Me.cmbTrimestre.Location = New System.Drawing.Point(372, 41)
        Me.cmbTrimestre.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmbTrimestre.Name = "cmbTrimestre"
        Me.cmbTrimestre.Size = New System.Drawing.Size(92, 21)
        Me.cmbTrimestre.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 44)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Seleccionar Materia: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(255, 44)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Seleccionar Trimestre:"
        '
        'dgvNotasTrim
        '
        Me.dgvNotasTrim.AllowUserToAddRows = False
        Me.dgvNotasTrim.AllowUserToDeleteRows = False
        Me.dgvNotasTrim.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dgvNotasTrim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvNotasTrim.DefaultCellStyle = DataGridViewCellStyle1
        Me.dgvNotasTrim.Location = New System.Drawing.Point(12, 69)
        Me.dgvNotasTrim.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dgvNotasTrim.Name = "dgvNotasTrim"
        Me.dgvNotasTrim.ReadOnly = True
        Me.dgvNotasTrim.RowHeadersVisible = False
        Me.dgvNotasTrim.RowTemplate.Height = 24
        Me.dgvNotasTrim.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvNotasTrim.Size = New System.Drawing.Size(926, 453)
        Me.dgvNotasTrim.TabIndex = 5
        '
        'btnConsultar
        '
        Me.btnConsultar.Location = New System.Drawing.Point(505, 41)
        Me.btnConsultar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnConsultar.Name = "btnConsultar"
        Me.btnConsultar.Size = New System.Drawing.Size(56, 19)
        Me.btnConsultar.TabIndex = 6
        Me.btnConsultar.Text = "Consultar"
        Me.btnConsultar.UseVisualStyleBackColor = True
        '
        'dgvFinal
        '
        Me.dgvFinal.AllowUserToAddRows = False
        Me.dgvFinal.AllowUserToDeleteRows = False
        Me.dgvFinal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvFinal.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvFinal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFinal.Location = New System.Drawing.Point(943, 69)
        Me.dgvFinal.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dgvFinal.Name = "dgvFinal"
        Me.dgvFinal.ReadOnly = True
        Me.dgvFinal.RowHeadersVisible = False
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.dgvFinal.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvFinal.RowTemplate.Height = 24
        Me.dgvFinal.Size = New System.Drawing.Size(56, 453)
        Me.dgvFinal.TabIndex = 7
        '
        'btnCerrar
        '
        Me.btnCerrar.Location = New System.Drawing.Point(923, 527)
        Me.btnCerrar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(76, 19)
        Me.btnCerrar.TabIndex = 8
        Me.btnCerrar.Text = "Cerrar"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'btnBorrarDia
        '
        Me.btnBorrarDia.Location = New System.Drawing.Point(844, 527)
        Me.btnBorrarDia.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnBorrarDia.Name = "btnBorrarDia"
        Me.btnBorrarDia.Size = New System.Drawing.Size(74, 19)
        Me.btnBorrarDia.TabIndex = 9
        Me.btnBorrarDia.Text = "Borrar Dia"
        Me.btnBorrarDia.UseVisualStyleBackColor = True
        '
        'btnBorrarFinal
        '
        Me.btnBorrarFinal.Location = New System.Drawing.Point(766, 527)
        Me.btnBorrarFinal.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnBorrarFinal.Name = "btnBorrarFinal"
        Me.btnBorrarFinal.Size = New System.Drawing.Size(74, 19)
        Me.btnBorrarFinal.TabIndex = 10
        Me.btnBorrarFinal.Text = "Borrar Final"
        Me.btnBorrarFinal.UseVisualStyleBackColor = True
        '
        'frmConsultarNotas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 561)
        Me.Controls.Add(Me.btnBorrarFinal)
        Me.Controls.Add(Me.btnBorrarDia)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.dgvFinal)
        Me.Controls.Add(Me.btnConsultar)
        Me.Controls.Add(Me.dgvNotasTrim)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbTrimestre)
        Me.Controls.Add(Me.cmbMateria)
        Me.Controls.Add(Me.lblTitulo)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "frmConsultarNotas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Planilla de Notas"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgvNotasTrim, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvFinal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitulo As Label
    Friend WithEvents cmbMateria As ComboBox
    Friend WithEvents cmbTrimestre As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents dgvNotasTrim As DataGridView
    Friend WithEvents btnConsultar As Button
    Friend WithEvents dgvFinal As DataGridView
    Friend WithEvents btnCerrar As Button
    Friend WithEvents btnBorrarDia As Button
    Friend WithEvents btnBorrarFinal As Button
End Class
