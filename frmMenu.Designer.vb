<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMenu
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnClientes = New System.Windows.Forms.Button()
        Me.btnVentas = New System.Windows.Forms.Button()
        Me.btnCreditos = New System.Windows.Forms.Button()
        Me.btnCobranzas = New System.Windows.Forms.Button()
        Me.lblTitulo = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        ' lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New Font("Segoe UI", 14.0!, FontStyle.Bold)
        Me.lblTitulo.Location = New Point(220, 40)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New Size(330, 25)
        Me.lblTitulo.TabIndex = 0
        Me.lblTitulo.Text = "Menú Principal - Sistema Comandato"
        '
        ' btnClientes
        '
        Me.btnClientes.Font = New Font("Segoe UI", 10.0!, FontStyle.Bold)
        Me.btnClientes.Location = New Point(150, 120)
        Me.btnClientes.Name = "btnClientes"
        Me.btnClientes.Size = New Size(150, 50)
        Me.btnClientes.TabIndex = 1
        Me.btnClientes.Text = "Clientes"
        Me.btnClientes.UseVisualStyleBackColor = True
        '
        ' btnVentas
        '
        Me.btnVentas.Font = New Font("Segoe UI", 10.0!, FontStyle.Bold)
        Me.btnVentas.Location = New Point(400, 120)
        Me.btnVentas.Name = "btnVentas"
        Me.btnVentas.Size = New Size(150, 50)
        Me.btnVentas.TabIndex = 2
        Me.btnVentas.Text = "Ventas"
        Me.btnVentas.UseVisualStyleBackColor = True
        '
        ' btnCreditos
        '
        Me.btnCreditos.Font = New Font("Segoe UI", 10.0!, FontStyle.Bold)
        Me.btnCreditos.Location = New Point(150, 200)
        Me.btnCreditos.Name = "btnCreditos"
        Me.btnCreditos.Size = New Size(150, 50)
        Me.btnCreditos.TabIndex = 3
        Me.btnCreditos.Text = "Créditos"
        Me.btnCreditos.UseVisualStyleBackColor = True
        '
        ' btnCobranzas
        '
        Me.btnCobranzas.Font = New Font("Segoe UI", 10.0!, FontStyle.Bold)
        Me.btnCobranzas.Location = New Point(400, 200)
        Me.btnCobranzas.Name = "btnCobranzas"
        Me.btnCobranzas.Size = New Size(150, 50)
        Me.btnCobranzas.TabIndex = 4
        Me.btnCobranzas.Text = "Cobranzas"
        Me.btnCobranzas.UseVisualStyleBackColor = True
        '
        ' frmMenu
        '
        Me.AutoScaleDimensions = New SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = AutoScaleMode.Font
        Me.ClientSize = New Size(700, 350)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.btnClientes)
        Me.Controls.Add(Me.btnVentas)
        Me.Controls.Add(Me.btnCreditos)
        Me.Controls.Add(Me.btnCobranzas)
        Me.Name = "frmMenu"
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Text = "Menú Principal"
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Friend WithEvents btnClientes As Button
    Friend WithEvents btnVentas As Button
    Friend WithEvents btnCreditos As Button
    Friend WithEvents btnCobranzas As Button
    Friend WithEvents lblTitulo As Label
End Class
