<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCobranzas
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
        Me.lblIdCredito = New System.Windows.Forms.Label()
        Me.txtIdCredito = New System.Windows.Forms.TextBox()
        Me.lblMontoPago = New System.Windows.Forms.Label()
        Me.txtMontoPago = New System.Windows.Forms.TextBox()
        Me.btnRegistrarPago = New System.Windows.Forms.Button()
        Me.dgPagos = New System.Windows.Forms.DataGridView()
        CType(Me.dgPagos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        ' lblIdCredito
        '
        Me.lblIdCredito.AutoSize = True
        Me.lblIdCredito.Location = New System.Drawing.Point(80, 60)
        Me.lblIdCredito.Name = "lblIdCredito"
        Me.lblIdCredito.Size = New System.Drawing.Size(63, 15)
        Me.lblIdCredito.TabIndex = 0
        Me.lblIdCredito.Text = "Numero Crédito:"
        '
        ' txtIdCredito
        '
        Me.txtIdCredito.Location = New System.Drawing.Point(200, 57)
        Me.txtIdCredito.Name = "txtIdCredito"
        Me.txtIdCredito.Size = New System.Drawing.Size(120, 23)
        Me.txtIdCredito.TabIndex = 1
        '
        ' lblMontoPago
        '
        Me.lblMontoPago.AutoSize = True
        Me.lblMontoPago.Location = New System.Drawing.Point(80, 100)
        Me.lblMontoPago.Name = "lblMontoPago"
        Me.lblMontoPago.Size = New System.Drawing.Size(85, 15)
        Me.lblMontoPago.TabIndex = 2
        Me.lblMontoPago.Text = "Monto Pagado:"
        '
        ' txtMontoPago
        '
        Me.txtMontoPago.Location = New System.Drawing.Point(200, 97)
        Me.txtMontoPago.Name = "txtMontoPago"
        Me.txtMontoPago.Size = New System.Drawing.Size(120, 23)
        Me.txtMontoPago.TabIndex = 3
        '
        ' btnRegistrarPago
        '
        Me.btnRegistrarPago.Location = New System.Drawing.Point(200, 140)
        Me.btnRegistrarPago.Name = "btnRegistrarPago"
        Me.btnRegistrarPago.Size = New System.Drawing.Size(120, 30)
        Me.btnRegistrarPago.TabIndex = 4
        Me.btnRegistrarPago.Text = "Registrar Pago"
        Me.btnRegistrarPago.UseVisualStyleBackColor = True
        '
        ' dgPagos
        '
        Me.dgPagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgPagos.Location = New System.Drawing.Point(80, 200)
        Me.dgPagos.Name = "dgPagos"
        Me.dgPagos.RowTemplate.Height = 25
        Me.dgPagos.Size = New System.Drawing.Size(600, 180)
        Me.dgPagos.TabIndex = 5
        '
        ' frmCobranzas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.dgPagos)
        Me.Controls.Add(Me.btnRegistrarPago)
        Me.Controls.Add(Me.txtMontoPago)
        Me.Controls.Add(Me.lblMontoPago)
        Me.Controls.Add(Me.txtIdCredito)
        Me.Controls.Add(Me.lblIdCredito)
        Me.Name = "frmCobranzas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestión de Cobranzas"
        CType(Me.dgPagos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Friend WithEvents lblIdCredito As Label
    Friend WithEvents txtIdCredito As TextBox
    Friend WithEvents lblMontoPago As Label
    Friend WithEvents txtMontoPago As TextBox
    Friend WithEvents btnRegistrarPago As Button
    Friend WithEvents dgPagos As DataGridView
End Class
