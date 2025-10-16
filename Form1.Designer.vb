<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    ' Limpieza de recursos
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

    ' Diseño de formulario
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblTitulo = New Label()
        Me.lblCedula = New Label()
        Me.txtCedula = New TextBox()
        Me.lblNombre = New Label()
        Me.txtNombre = New TextBox()
        Me.lblDireccion = New Label()
        Me.txtDireccion = New TextBox()
        Me.lblTelefono = New Label()
        Me.txtTelefono = New TextBox()
        Me.btnGuardar = New Button()
        Me.dgClientes = New DataGridView()
        Me.lblBuscar = New Label()
        Me.txtBuscarCedula = New TextBox()
        Me.btnBuscar = New Button()
        Me.btnMostrarTodos = New Button()
        CType(Me.dgClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        ' lblTitulo
        '
        Me.lblTitulo.AutoSize = True
        Me.lblTitulo.Font = New Font("Segoe UI", 14.25!, FontStyle.Bold, GraphicsUnit.Point)
        Me.lblTitulo.ForeColor = Color.FromArgb(0, 80, 152)
        Me.lblTitulo.Location = New Point(270, 10)
        Me.lblTitulo.Name = "lblTitulo"
        Me.lblTitulo.Size = New Size(210, 25)
        Me.lblTitulo.Text = "Registro de Clientes"
        '
        ' lblCedula
        '
        Me.lblCedula.AutoSize = True
        Me.lblCedula.Location = New Point(80, 60)
        Me.lblCedula.Text = "Cédula:"
        '
        ' txtCedula
        '
        Me.txtCedula.Location = New Point(160, 57)
        Me.txtCedula.Size = New Size(150, 23)
        '
        ' lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New Point(80, 95)
        Me.lblNombre.Text = "Nombre:"
        '
        ' txtNombre
        '
        Me.txtNombre.Location = New Point(160, 92)
        Me.txtNombre.Size = New Size(250, 23)
        '
        ' lblDireccion
        '
        Me.lblDireccion.AutoSize = True
        Me.lblDireccion.Location = New Point(80, 130)
        Me.lblDireccion.Text = "Dirección:"
        '
        ' txtDireccion
        '
        Me.txtDireccion.Location = New Point(160, 127)
        Me.txtDireccion.Size = New Size(300, 23)
        '
        ' lblTelefono
        '
        Me.lblTelefono.AutoSize = True
        Me.lblTelefono.Location = New Point(80, 165)
        Me.lblTelefono.Text = "Teléfono:"
        '
        ' txtTelefono
        '
        Me.txtTelefono.Location = New Point(160, 162)
        Me.txtTelefono.Size = New Size(150, 23)
        '
        ' btnGuardar
        '
        Me.btnGuardar.BackColor = Color.FromArgb(0, 80, 152)
        Me.btnGuardar.ForeColor = Color.White
        Me.btnGuardar.Font = New Font("Segoe UI", 9.75!, FontStyle.Bold, GraphicsUnit.Point)
        Me.btnGuardar.Location = New Point(160, 200)
        Me.btnGuardar.Size = New Size(150, 35)
        Me.btnGuardar.Text = "💾 Guardar Cliente"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        ' lblBuscar
        '
        Me.lblBuscar.AutoSize = True
        Me.lblBuscar.Location = New Point(80, 250)
        Me.lblBuscar.Text = "Buscar por Cédula:"
        '
        ' txtBuscarCedula
        '
        Me.txtBuscarCedula.Location = New Point(200, 247)
        Me.txtBuscarCedula.Size = New Size(150, 23)
        '
        ' btnBuscar
        '
        Me.btnBuscar.BackColor = Color.FromArgb(0, 80, 152)
        Me.btnBuscar.ForeColor = Color.White
        Me.btnBuscar.Font = New Font("Segoe UI", 9.0!, FontStyle.Bold, GraphicsUnit.Point)
        Me.btnBuscar.Location = New Point(360, 245)
        Me.btnBuscar.Size = New Size(80, 27)
        Me.btnBuscar.Text = "🔍 Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = False
        '
        ' btnMostrarTodos
        '
        Me.btnMostrarTodos.BackColor = Color.Gray
        Me.btnMostrarTodos.ForeColor = Color.White
        Me.btnMostrarTodos.Font = New Font("Segoe UI", 9.0!, FontStyle.Bold, GraphicsUnit.Point)
        Me.btnMostrarTodos.Location = New Point(450, 245)
        Me.btnMostrarTodos.Size = New Size(110, 27)
        Me.btnMostrarTodos.Text = "↺ Mostrar Todos"
        Me.btnMostrarTodos.UseVisualStyleBackColor = False
        '
        ' dgClientes
        '
        Me.dgClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgClientes.Location = New Point(80, 290)
        Me.dgClientes.Size = New Size(640, 130)
        Me.dgClientes.BackgroundColor = Color.White
        '
        ' Form1
        '
        Me.ClientSize = New Size(820, 460)
        Me.Controls.Add(Me.lblTitulo)
        Me.Controls.Add(Me.lblCedula)
        Me.Controls.Add(Me.txtCedula)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.lblDireccion)
        Me.Controls.Add(Me.txtDireccion)
        Me.Controls.Add(Me.lblTelefono)
        Me.Controls.Add(Me.txtTelefono)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.lblBuscar)
        Me.Controls.Add(Me.txtBuscarCedula)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.btnMostrarTodos)
        Me.Controls.Add(Me.dgClientes)
        Me.Name = "Form1"
        Me.StartPosition = FormStartPosition.CenterScreen
        Me.Text = "Gestión de Clientes"
        CType(Me.dgClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Friend WithEvents lblTitulo As Label
    Friend WithEvents lblCedula As Label
    Friend WithEvents txtCedula As TextBox
    Friend WithEvents lblNombre As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents lblDireccion As Label
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents lblTelefono As Label
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents btnGuardar As Button
    Friend WithEvents lblBuscar As Label
    Friend WithEvents txtBuscarCedula As TextBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents btnMostrarTodos As Button
    Friend WithEvents dgClientes As DataGridView
End Class
