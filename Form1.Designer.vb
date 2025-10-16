<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer





    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        txtCedula = New TextBox()
        lblCedula = New Label()
        lblNombre = New Label()
        txtNombre = New TextBox()
        lblDireccion = New Label()
        txtDireccion = New TextBox()
        lblTelefono = New Label()
        txtTelefono = New TextBox()
        btnGuardar = New Button()
        dgClientes = New DataGridView()
        CType(dgClientes, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtCedula
        ' 
        txtCedula.Location = New Point(252, 52)
        txtCedula.Name = "txtCedula"
        txtCedula.Size = New Size(150, 23)
        txtCedula.TabIndex = 1
        ' 
        ' lblCedula
        ' 
        lblCedula.AutoSize = True
        lblCedula.Location = New Point(80, 55)
        lblCedula.Name = "lblCedula"
        lblCedula.Size = New Size(44, 15)
        lblCedula.TabIndex = 2
        lblCedula.Text = "Cédula"
        ' 
        ' lblNombre
        ' 
        lblNombre.AutoSize = True
        lblNombre.Location = New Point(80, 90)
        lblNombre.Name = "lblNombre"
        lblNombre.Size = New Size(51, 15)
        lblNombre.TabIndex = 3
        lblNombre.Text = "Nombre"
        ' 
        ' txtNombre
        ' 
        txtNombre.Location = New Point(252, 87)
        txtNombre.Name = "txtNombre"
        txtNombre.Size = New Size(250, 23)
        txtNombre.TabIndex = 4
        ' 
        ' lblDireccion
        ' 
        lblDireccion.AutoSize = True
        lblDireccion.Location = New Point(80, 125)
        lblDireccion.Name = "lblDireccion"
        lblDireccion.Size = New Size(58, 15)
        lblDireccion.TabIndex = 5
        lblDireccion.Text = "Dirección"
        ' 
        ' txtDireccion
        ' 
        txtDireccion.Location = New Point(252, 122)
        txtDireccion.Name = "txtDireccion"
        txtDireccion.Size = New Size(300, 23)
        txtDireccion.TabIndex = 6
        ' 
        ' lblTelefono
        ' 
        lblTelefono.AutoSize = True
        lblTelefono.Location = New Point(80, 160)
        lblTelefono.Name = "lblTelefono"
        lblTelefono.Size = New Size(52, 15)
        lblTelefono.TabIndex = 7
        lblTelefono.Text = "Teléfono"
        ' 
        ' txtTelefono
        ' 
        txtTelefono.Location = New Point(252, 157)
        txtTelefono.Name = "txtTelefono"
        txtTelefono.Size = New Size(150, 23)
        txtTelefono.TabIndex = 8
        ' 
        ' btnGuardar
        ' 
        btnGuardar.Location = New Point(252, 195)
        btnGuardar.Name = "btnGuardar"
        btnGuardar.Size = New Size(100, 30)
        btnGuardar.TabIndex = 9
        btnGuardar.Text = "Guardar"
        btnGuardar.UseVisualStyleBackColor = True
        ' 
        ' dgClientes
        ' 
        dgClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgClientes.Location = New Point(80, 250)
        dgClientes.Name = "dgClientes"
        dgClientes.RowTemplate.Height = 25
        dgClientes.Size = New Size(600, 150)
        dgClientes.TabIndex = 10
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(dgClientes)
        Controls.Add(btnGuardar)
        Controls.Add(txtTelefono)
        Controls.Add(lblTelefono)
        Controls.Add(txtDireccion)
        Controls.Add(lblDireccion)
        Controls.Add(txtNombre)
        Controls.Add(lblNombre)
        Controls.Add(lblCedula)
        Controls.Add(txtCedula)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Gestión de Clientes"
        CType(dgClientes, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtCedula As TextBox
    Friend WithEvents lblCedula As Label
    Friend WithEvents lblNombre As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents lblDireccion As Label
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents lblTelefono As Label
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents btnGuardar As Button
    Friend WithEvents dgClientes As DataGridView

End Class

