Imports System.Data
Imports System.Data.SqlClient

Public Class Form1

    ' 🔹 Conexión a la base de datos
    Dim connectionString As String = "Data Source=DESKTOP-EFBDO38\SQLEXPRESS;Initial Catalog=BDComandato;Integrated Security=True"

    ' ======================================================
    ' CARGA INICIAL DEL FORMULARIO
    ' ======================================================
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarClientes()
    End Sub

    ' ======================================================
    ' FUNCIÓN PARA CARGAR LOS CLIENTES EN EL DATAGRIDVIEW
    ' ======================================================
    Private Sub CargarClientes()
        Try
            Using cn As New SqlConnection(connectionString)
                Dim da As New SqlDataAdapter("SELECT * FROM Clientes ORDER BY FechaRegistro ASC", cn)
                Dim dt As New DataTable()
                da.Fill(dt)
                dgClientes.DataSource = dt
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al cargar los clientes: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' ======================================================
    ' BOTÓN GUARDAR - INSERTA UN NUEVO CLIENTE
    ' ======================================================
    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If String.IsNullOrWhiteSpace(txtCedula.Text) OrElse
           String.IsNullOrWhiteSpace(txtNombre.Text) OrElse
           String.IsNullOrWhiteSpace(txtDireccion.Text) OrElse
           String.IsNullOrWhiteSpace(txtTelefono.Text) Then
            MessageBox.Show("Ingrese todos los campos obligatorios.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If


        'If String.IsNullOrWhiteSpace(txtCedula.Text) Then
        '    MessageBox.Show("Ingrese la cédula.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        '    txtCedula.Focus()
        '    Exit Sub
        'End If

        Try
            Using cn As New SqlConnection(connectionString)
                Using cmd As New SqlCommand("sp_InsertarCliente", cn)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.AddWithValue("@Cedula", txtCedula.Text)
                    cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text)
                    cmd.Parameters.AddWithValue("@Direccion", txtDireccion.Text)
                    cmd.Parameters.AddWithValue("@Telefono", txtTelefono.Text)

                    cn.Open()
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Cliente registrado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LimpiarCampos()
            CargarClientes()

        Catch ex As SqlException
            MessageBox.Show("Error al guardar el cliente: " & ex.Message, "Error SQL", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' ======================================================
    ' BOTÓN BUSCAR CLIENTE POR CÉDULA
    ' ======================================================
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim cedulaBuscada As String = txtBuscarCedula.Text.Trim()

        If cedulaBuscada = "" Then
            MessageBox.Show("Ingrese una cédula para buscar.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            Using cn As New SqlConnection(connectionString)
                Dim query As String = "SELECT * FROM Clientes WHERE Cedula = @Cedula"
                Dim cmd As New SqlCommand(query, cn)
                cmd.Parameters.AddWithValue("@Cedula", cedulaBuscada)

                Dim da As New SqlDataAdapter(cmd)
                Dim dt As New DataTable()
                da.Fill(dt)

                If dt.Rows.Count > 0 Then
                    dgClientes.DataSource = dt
                Else
                    MessageBox.Show("No se encontró ningún cliente con esa cédula.", "Sin resultados", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    dgClientes.DataSource = Nothing
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al buscar el cliente: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' ======================================================
    ' BOTÓN MOSTRAR TODOS LOS CLIENTES
    ' ======================================================
    Private Sub btnMostrarTodos_Click(sender As Object, e As EventArgs) Handles btnMostrarTodos.Click
        txtBuscarCedula.Clear()
        CargarClientes()
    End Sub

    ' ======================================================
    ' LIMPIAR CAMPOS DE ENTRADA
    ' ======================================================
    Private Sub LimpiarCampos()
        txtCedula.Clear()
        txtNombre.Clear()
        txtDireccion.Clear()
        txtTelefono.Clear()
    End Sub

End Class
