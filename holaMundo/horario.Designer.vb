﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class horario
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.PanelBD = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Idhorario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdCargo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdEspecialista = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.especialidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cargoper = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.hora = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PanelDatos = New System.Windows.Forms.Panel()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.PanelBuscarDiag = New System.Windows.Forms.Panel()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.modificarBT = New System.Windows.Forms.Button()
        Me.nuevoBT = New System.Windows.Forms.Button()
        Me.eliminarBT = New System.Windows.Forms.Button()
        Me.PanelBD.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelDatos.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelBD
        '
        Me.PanelBD.Controls.Add(Me.DataGridView1)
        Me.PanelBD.Controls.Add(Me.TextBox3)
        Me.PanelBD.Controls.Add(Me.Label4)
        Me.PanelBD.Location = New System.Drawing.Point(610, 12)
        Me.PanelBD.Name = "PanelBD"
        Me.PanelBD.Size = New System.Drawing.Size(608, 366)
        Me.PanelBD.TabIndex = 52
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Idhorario, Me.IdCargo, Me.IdEspecialista, Me.especialidad, Me.cargoper, Me.hora})
        Me.DataGridView1.Location = New System.Drawing.Point(57, 112)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(529, 216)
        Me.DataGridView1.TabIndex = 45
        '
        'Idhorario
        '
        Me.Idhorario.DataPropertyName = "Idhorario"
        Me.Idhorario.HeaderText = "ID"
        Me.Idhorario.MinimumWidth = 8
        Me.Idhorario.Name = "Idhorario"
        Me.Idhorario.ReadOnly = True
        Me.Idhorario.Visible = False
        Me.Idhorario.Width = 150
        '
        'IdCargo
        '
        Me.IdCargo.DataPropertyName = "IdCargo"
        Me.IdCargo.HeaderText = "IDCARGO"
        Me.IdCargo.MinimumWidth = 8
        Me.IdCargo.Name = "IdCargo"
        Me.IdCargo.ReadOnly = True
        Me.IdCargo.Visible = False
        Me.IdCargo.Width = 150
        '
        'IdEspecialista
        '
        Me.IdEspecialista.DataPropertyName = "IdEspecialista"
        Me.IdEspecialista.HeaderText = "IDESPEC"
        Me.IdEspecialista.MinimumWidth = 8
        Me.IdEspecialista.Name = "IdEspecialista"
        Me.IdEspecialista.ReadOnly = True
        Me.IdEspecialista.Width = 150
        '
        'especialidad
        '
        Me.especialidad.DataPropertyName = "especialidad"
        Me.especialidad.HeaderText = "ESPECIALISTA "
        Me.especialidad.MinimumWidth = 8
        Me.especialidad.Name = "especialidad"
        Me.especialidad.ReadOnly = True
        Me.especialidad.Width = 150
        '
        'cargoper
        '
        Me.cargoper.DataPropertyName = "cargoper"
        Me.cargoper.HeaderText = "CARGO"
        Me.cargoper.MinimumWidth = 8
        Me.cargoper.Name = "cargoper"
        Me.cargoper.ReadOnly = True
        Me.cargoper.Width = 150
        '
        'hora
        '
        Me.hora.DataPropertyName = "horario"
        Me.hora.FillWeight = 200.0!
        Me.hora.HeaderText = "HORARIO"
        Me.hora.MinimumWidth = 8
        Me.hora.Name = "hora"
        Me.hora.ReadOnly = True
        Me.hora.Width = 150
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(140, 57)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(391, 26)
        Me.TextBox3.TabIndex = 44
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(53, 63)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 20)
        Me.Label4.TabIndex = 42
        Me.Label4.Text = "BUSCAR:"
        '
        'PanelDatos
        '
        Me.PanelDatos.Controls.Add(Me.ComboBox2)
        Me.PanelDatos.Controls.Add(Me.PanelBuscarDiag)
        Me.PanelDatos.Controls.Add(Me.TextBox2)
        Me.PanelDatos.Controls.Add(Me.ComboBox1)
        Me.PanelDatos.Controls.Add(Me.Label3)
        Me.PanelDatos.Controls.Add(Me.Label2)
        Me.PanelDatos.Controls.Add(Me.Label1)
        Me.PanelDatos.Location = New System.Drawing.Point(12, 12)
        Me.PanelDatos.Name = "PanelDatos"
        Me.PanelDatos.Size = New System.Drawing.Size(592, 316)
        Me.PanelDatos.TabIndex = 51
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(324, 87)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(187, 28)
        Me.ComboBox2.TabIndex = 20
        '
        'PanelBuscarDiag
        '
        Me.PanelBuscarDiag.Location = New System.Drawing.Point(595, -9)
        Me.PanelBuscarDiag.Name = "PanelBuscarDiag"
        Me.PanelBuscarDiag.Size = New System.Drawing.Size(581, 620)
        Me.PanelBuscarDiag.TabIndex = 19
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(324, 142)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(187, 26)
        Me.TextBox2.TabIndex = 17
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(324, 32)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(187, 28)
        Me.ComboBox1.TabIndex = 18
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(133, 148)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 20)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "HORARIO"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(133, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(150, 20)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "ESPECIALISTA EN"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(133, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 20)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "CARGO"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(465, 334)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(113, 44)
        Me.Button1.TabIndex = 50
        Me.Button1.Text = "Buscar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'modificarBT
        '
        Me.modificarBT.Location = New System.Drawing.Point(149, 334)
        Me.modificarBT.Name = "modificarBT"
        Me.modificarBT.Size = New System.Drawing.Size(113, 44)
        Me.modificarBT.TabIndex = 49
        Me.modificarBT.Text = "Modificar"
        Me.modificarBT.UseVisualStyleBackColor = True
        '
        'nuevoBT
        '
        Me.nuevoBT.Location = New System.Drawing.Point(12, 334)
        Me.nuevoBT.Name = "nuevoBT"
        Me.nuevoBT.Size = New System.Drawing.Size(113, 44)
        Me.nuevoBT.TabIndex = 48
        Me.nuevoBT.Text = "Nuevo"
        Me.nuevoBT.UseVisualStyleBackColor = True
        '
        'eliminarBT
        '
        Me.eliminarBT.Location = New System.Drawing.Point(303, 334)
        Me.eliminarBT.Name = "eliminarBT"
        Me.eliminarBT.Size = New System.Drawing.Size(113, 44)
        Me.eliminarBT.TabIndex = 47
        Me.eliminarBT.Text = "Eliminar"
        Me.eliminarBT.UseVisualStyleBackColor = True
        '
        'horario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1220, 456)
        Me.Controls.Add(Me.PanelBD)
        Me.Controls.Add(Me.PanelDatos)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.modificarBT)
        Me.Controls.Add(Me.nuevoBT)
        Me.Controls.Add(Me.eliminarBT)
        Me.Name = "horario"
        Me.Text = "horario"
        Me.PanelBD.ResumeLayout(False)
        Me.PanelBD.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelDatos.ResumeLayout(False)
        Me.PanelDatos.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelBD As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents PanelDatos As Panel
    Friend WithEvents PanelBuscarDiag As Panel
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents modificarBT As Button
    Friend WithEvents nuevoBT As Button
    Friend WithEvents eliminarBT As Button
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Idhorario As DataGridViewTextBoxColumn
    Friend WithEvents IdCargo As DataGridViewTextBoxColumn
    Friend WithEvents IdEspecialista As DataGridViewTextBoxColumn
    Friend WithEvents especialidad As DataGridViewTextBoxColumn
    Friend WithEvents cargoper As DataGridViewTextBoxColumn
    Friend WithEvents hora As DataGridViewTextBoxColumn
End Class
