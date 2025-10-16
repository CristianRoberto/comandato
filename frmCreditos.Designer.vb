<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCreditos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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
        Me.lblIdClienteCredito = New System.Windows.Forms.Label()
        Me.txtIdClienteCredito = New System.Windows.Forms.TextBox()
        Me.lblMonto = New System.Windows.Forms.Label()
        Me.txtMonto = New System.Windows.Forms.TextBox()
        Me.lblPlazo = New System.Windows.Forms.Label()
        Me.txtPlazo = New System.Windows.Forms.TextBox()
        Me.btnGuardarCredito = New System.Windows.Forms.Button()
        Me.dgCreditos = New System.Windows.Forms.DataGridView()
        CType(Me.dgCreditos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        ' lblIdClienteCredito
        '
        Me.lblIdClienteCredito.AutoSize = True
        Me.lblIdClienteCredito.Location = New System.Drawing.Point(80, 60)
        Me.lblIdClienteCredito.Name = "lblIdClienteCredito"
        Me.lblIdClienteCredito.Size = New System.Drawing.Size(60, 15)
        Me.lblIdClienteCredito.TabIndex = 0
        Me.lblIdClienteCredito.Text = "ID Cliente:"
        '
        ' txtIdClienteCredito
        '
        Me.txtIdClienteCredito.Location = New System.Drawing.Point(200, 57)
        Me.txtIdClienteCredito.Name = "txtIdClienteCredito"
        Me.txtIdClienteCredito.Size = New System.Drawing.Size(120, 23)
        Me.txtIdClienteCredito.TabIndex = 1
        '
        ' lblMonto
        '
        Me.lblMonto.AutoSize = True
        Me.lblMonto.Location = New System.Drawing.Point(80, 100)
        Me.lblMonto.Name = "lblMonto"
        Me.lblMonto.Size = New System.Drawing.Size(46, 15)
        Me.lblMonto.TabIndex = 2
        Me.lblMonto.Text = "Monto:"
        '
        ' txtMonto
        '
        Me.txtMonto.Location = New System.Drawing.Point(200, 97)
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.Size = New System.Drawing.Size(120, 23)
        Me.txtMonto.TabIndex = 3
        '
        ' lblPlazo
        '
        Me.lblPlazo.AutoSize = True
        Me.lblPlazo.Location = New System.Drawing.Point(80, 140)
        Me.lblPlazo.Name = "lblPlazo"
        Me.lblPlazo.Size = New System.Drawing.Size(82, 15)
        Me.lblPlazo.TabIndex = 4
        Me.lblPlazo.Text = "Plazo (meses):"
        '
        ' txtPlazo
        '
        Me.txtPlazo.Location = New System.Drawing.Point(200, 137)
        Me.txtPlazo.Name = "txtPlazo"
        Me.txtPlazo.Size = New System.Drawing.Size(120, 23)
        Me.txtPlazo.TabIndex = 5
        '
        ' btnGuardarCredito
        '
        Me.btnGuardarCredito.Location = New System.Drawing.Point(200, 180)
        Me.btnGuardarCredito.Name = "btnGuardarCredito"
        Me.btnGuardarCredito.Size = New System.Drawing.Size(120, 30)
        Me.btnGuardarCredito.TabIndex = 6
        Me.btnGuardarCredito.Text = "Guardar Crédito"
        Me.btnGuardarCredito.UseVisualStyleBackColor = True
        '
        ' dgCreditos
        '
        Me.dgCreditos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgCreditos.Location = New System.Drawing.Point(80, 240)
        Me.dgCreditos.Name = "dgCreditos"
        Me.dgCreditos.RowTemplate.Height = 25
        Me.dgCreditos.Size = New System.Drawing.Size(600, 160)
        Me.dgCreditos.TabIndex = 7
        '
        ' frmCreditos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.dgCreditos)
        Me.Controls.Add(Me.btnGuardarCredito)
        Me.Controls.Add(Me.txtPlazo)
        Me.Controls.Add(Me.lblPlazo)
        Me.Controls.Add(Me.txtMonto)
        Me.Controls.Add(Me.lblMonto)
        Me.Controls.Add(Me.txtIdClienteCredito)
        Me.Controls.Add(Me.lblIdClienteCredito)
        Me.Name = "frmCreditos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestión de Créditos"
        CType(Me.dgCreditos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Friend WithEvents lblIdClienteCredito As Label
    Friend WithEvents txtIdClienteCredito As TextBox
    Friend WithEvents lblMonto As Label
    Friend WithEvents txtMonto As TextBox
    Friend WithEvents lblPlazo As Label
    Friend WithEvents txtPlazo As TextBox
    Friend WithEvents btnGuardarCredito As Button
    Friend WithEvents dgCreditos As DataGridView
End Class
