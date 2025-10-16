<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmVentas
    Inherits System.Windows.Forms.Form

    Private Sub InitializeComponent()
        lblCliente = New Label()
        txtIdCliente = New TextBox()
        lblTotal = New Label()
        txtTotal = New TextBox()
        btnGuardarVenta = New Button()
        dgVentas = New DataGridView()
        CType(dgVentas, System.ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        '
        ' lblCliente
        '
        lblCliente.AutoSize = True
        lblCliente.Location = New Point(60, 50)
        lblCliente.Text = "Cliente (ID):"
        '
        ' txtIdCliente
        '
        txtIdCliente.Location = New Point(160, 47)
        txtIdCliente.Size = New Size(150, 23)
        '
        ' lblTotal
        '
        lblTotal.AutoSize = True
        lblTotal.Location = New Point(60, 85)
        lblTotal.Text = "Total Venta:"
        '
        ' txtTotal
        '
        txtTotal.Location = New Point(160, 82)
        txtTotal.Size = New Size(150, 23)
        '
        ' btnGuardarVenta
        '
        btnGuardarVenta.Location = New Point(160, 120)
        btnGuardarVenta.Text = "Guardar Venta"
        btnGuardarVenta.Size = New Size(120, 30)
        '
        ' dgVentas
        '
        dgVentas.Location = New Point(60, 180)
        dgVentas.Size = New Size(600, 200)
        '
        ' frmVentas
        '
        ClientSize = New Size(750, 420)
        Controls.Add(lblCliente)
        Controls.Add(txtIdCliente)
        Controls.Add(lblTotal)
        Controls.Add(txtTotal)
        Controls.Add(btnGuardarVenta)
        Controls.Add(dgVentas)
        Text = "Registro de Ventas"
        StartPosition = FormStartPosition.CenterScreen
        CType(dgVentas, System.ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblCliente As Label
    Friend WithEvents txtIdCliente As TextBox
    Friend WithEvents lblTotal As Label
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents btnGuardarVenta As Button
    Friend WithEvents dgVentas As DataGridView
End Class
