﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class menu
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.PACIENTESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MEDICAMENTOSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PROVEEDORToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PACIENTEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ENFERMEDADESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DIAGNOSTICOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RECETAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PEROSNALToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CARGOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.USUARIOSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HORARIOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TRASLADOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PACIENTESToolStripMenuItem, Me.PACIENTEToolStripMenuItem, Me.PEROSNALToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(5, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(1053, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'PACIENTESToolStripMenuItem
        '
        Me.PACIENTESToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MEDICAMENTOSToolStripMenuItem, Me.PROVEEDORToolStripMenuItem})
        Me.PACIENTESToolStripMenuItem.Name = "PACIENTESToolStripMenuItem"
        Me.PACIENTESToolStripMenuItem.Size = New System.Drawing.Size(93, 24)
        Me.PACIENTESToolStripMenuItem.Text = "MEDICINA"
        '
        'MEDICAMENTOSToolStripMenuItem
        '
        Me.MEDICAMENTOSToolStripMenuItem.Name = "MEDICAMENTOSToolStripMenuItem"
        Me.MEDICAMENTOSToolStripMenuItem.Size = New System.Drawing.Size(205, 26)
        Me.MEDICAMENTOSToolStripMenuItem.Text = "MEDICAMENTOS"
        '
        'PROVEEDORToolStripMenuItem
        '
        Me.PROVEEDORToolStripMenuItem.Name = "PROVEEDORToolStripMenuItem"
        Me.PROVEEDORToolStripMenuItem.Size = New System.Drawing.Size(205, 26)
        Me.PROVEEDORToolStripMenuItem.Text = "PROVEEDOR"
        '
        'PACIENTEToolStripMenuItem
        '
        Me.PACIENTEToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ENFERMEDADESToolStripMenuItem, Me.DIAGNOSTICOToolStripMenuItem, Me.RECETAToolStripMenuItem, Me.TRASLADOToolStripMenuItem})
        Me.PACIENTEToolStripMenuItem.Name = "PACIENTEToolStripMenuItem"
        Me.PACIENTEToolStripMenuItem.Size = New System.Drawing.Size(88, 24)
        Me.PACIENTEToolStripMenuItem.Text = "PACIENTE"
        '
        'ENFERMEDADESToolStripMenuItem
        '
        Me.ENFERMEDADESToolStripMenuItem.Name = "ENFERMEDADESToolStripMenuItem"
        Me.ENFERMEDADESToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.ENFERMEDADESToolStripMenuItem.Text = "ENFERMEDADES"
        '
        'DIAGNOSTICOToolStripMenuItem
        '
        Me.DIAGNOSTICOToolStripMenuItem.Name = "DIAGNOSTICOToolStripMenuItem"
        Me.DIAGNOSTICOToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.DIAGNOSTICOToolStripMenuItem.Text = "DIAGNOSTICO"
        '
        'RECETAToolStripMenuItem
        '
        Me.RECETAToolStripMenuItem.Name = "RECETAToolStripMenuItem"
        Me.RECETAToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.RECETAToolStripMenuItem.Text = "RECETA"
        '
        'PEROSNALToolStripMenuItem
        '
        Me.PEROSNALToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CARGOToolStripMenuItem, Me.USUARIOSToolStripMenuItem, Me.HORARIOToolStripMenuItem})
        Me.PEROSNALToolStripMenuItem.Name = "PEROSNALToolStripMenuItem"
        Me.PEROSNALToolStripMenuItem.Size = New System.Drawing.Size(95, 24)
        Me.PEROSNALToolStripMenuItem.Text = "PERSONAL"
        '
        'CARGOToolStripMenuItem
        '
        Me.CARGOToolStripMenuItem.Name = "CARGOToolStripMenuItem"
        Me.CARGOToolStripMenuItem.Size = New System.Drawing.Size(162, 26)
        Me.CARGOToolStripMenuItem.Text = "CARGO"
        '
        'USUARIOSToolStripMenuItem
        '
        Me.USUARIOSToolStripMenuItem.Name = "USUARIOSToolStripMenuItem"
        Me.USUARIOSToolStripMenuItem.Size = New System.Drawing.Size(162, 26)
        Me.USUARIOSToolStripMenuItem.Text = "USUARIOS"
        '
        'HORARIOToolStripMenuItem
        '
        Me.HORARIOToolStripMenuItem.Name = "HORARIOToolStripMenuItem"
        Me.HORARIOToolStripMenuItem.Size = New System.Drawing.Size(162, 26)
        Me.HORARIOToolStripMenuItem.Text = "HORARIO"
        '
        'TRASLADOToolStripMenuItem
        '
        Me.TRASLADOToolStripMenuItem.Name = "TRASLADOToolStripMenuItem"
        Me.TRASLADOToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.TRASLADOToolStripMenuItem.Text = "TRASLADO"
        '
        'menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1053, 565)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "menu"
        Me.Text = "menu"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents PACIENTESToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MEDICAMENTOSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PACIENTEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ENFERMEDADESToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PROVEEDORToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PEROSNALToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CARGOToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DIAGNOSTICOToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents USUARIOSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RECETAToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HORARIOToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TRASLADOToolStripMenuItem As ToolStripMenuItem
End Class
