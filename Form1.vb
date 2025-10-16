'Imports WinFormsApp1.ADODB
'Imports System.Data

'Public Class Form1

'    ' 🔹 Cadena de conexión con tu instancia SQL Server
'    Dim connectionString As String = "Provider=SQLOLEDB;Data Source=DESKTOP-EFBDO38\SQLEXPRESS;Initial Catalog=BDComandato;Integrated Security=SSPI;"

'    ' ======================================================
'    ' CARGA INICIAL DEL FORMULARIO
'    ' ======================================================
'    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
'        CargarClientes()
'    End Sub

'    ' ======================================================
'    ' FUNCIÓN PARA CARGAR LOS CLIENTES EN EL DATAGRIDVIEW
'    ' ======================================================
'    Private Sub CargarClientes()
'        Try
'            Dim cn As New ADODB.Connection
'            Dim rs As New ADODB.Recordset

'            cn.Open(connectionString)
'            rs.Open("SELECT * FROM Clientes", cn, CursorTypeEnum.adOpenStatic, LockTypeEnum.adLockReadOnly)

'            ' Crear DataTable para el DataGridView
'            Dim dt As New DataTable()
'            For i As Integer = 0 To rs.Fields.Count - 1
'                dt.Columns.Add(rs.Fields(i).Name)
'            Next

'            While Not rs.EOF
'                Dim row As DataRow = dt.NewRow()
'                For i As Integer = 0 To rs.Fields.Count - 1
'                    row(i) = rs.Fields(i).Value
'                Next
'                dt.Rows.Add(row)
'                rs.MoveNext()
'            End While

'            dgClientes.DataSource = dt

'            rs.Close()
'            cn.Close()

'        Catch ex As Exception
'            MessageBox.Show("Error al cargar los clientes: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
'        End Try
'    End Sub

'    ' ======================================================
'    ' BOTÓN GUARDAR - INSERTA UN NUEVO CLIENTE
'    ' ======================================================
'    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
'        On Error GoTo ErrHandler

'        ' Validación básica
'        If Trim(txtCedula.Text) = "" Or Trim(txtNombre.Text) = "" Then
'            MsgBox("Ingrese todos los campos obligatorios.", vbExclamation, "Validación")
'            Exit Sub
'        End If

'        Dim cn As ADODB.Connection
'        Dim cmd As ADODB.Command

'        ' Crear y abrir conexión
'        Set cn = New ADODB.Connection
'        cn.ConnectionString = connectionString
'        cn.Open()

'        ' Configurar comando ADO para ejecutar el SP
'        Set cmd = New ADODB.Command
'        With cmd
'            .ActiveConnection = cn
'            .CommandType = CommandTypeEnum.adCmdStoredProc
'            .CommandText = "sp_InsertarCliente"

'            ' Parámetros del procedimiento almacenado
'            .Parameters.Append(.CreateParameter("@Cedula", DataTypeEnum.adVarChar, ParameterDirectionEnum.adParamInput, 10, txtCedula.Text))
'            .Parameters.Append(.CreateParameter("@Nombre", DataTypeEnum.adVarWChar, ParameterDirectionEnum.adParamInput, 100, txtNombre.Text))
'            .Parameters.Append(.CreateParameter("@Direccion", DataTypeEnum.adVarWChar, ParameterDirectionEnum.adParamInput, 200, txtDireccion.Text))
'            .Parameters.Append(.CreateParameter("@Telefono", DataTypeEnum.adVarChar, ParameterDirectionEnum.adParamInput, 20, txtTelefono.Text))

'            ' Ejecutar procedimiento
'            .Execute()
'        End With

'        MsgBox("Cliente registrado correctamente.", vbInformation, "Éxito")

'        ' Limpiar campos
'        txtCedula.Clear()
'        txtNombre.Clear()
'        txtDireccion.Clear()
'        txtTelefono.Clear()

'        ' Recargar grilla
'        CargarClientes()

'Cleanup:
'        On Error Resume Next
'        cn.Close()
'        Set cmd = Nothing
'        Set cn = Nothing
'        Exit Sub

'ErrHandler:
'        MsgBox("Error al guardar el cliente: " & Err.Description, vbCritical, "Error")
'        Resume Cleanup
'    End Sub

'End Class









Imports System.Data
Imports System.Data.SqlClient

Public Class Form1

    ' 🔹 Cadena de conexión a tu servidor SQL
    Dim connectionString As String = "Data Source=DESKTOP-EFBDO38\SQLEXPRESS;Initial Catalog=BDComandato;Integrated Security=True"

    ' ======================================================
    ' CARGA INICIAL DEL FORMULARIO
    ' ======================================================
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarClientes()
    End Sub


    'Private Sub btnVentas_Click(sender As Object, e As EventArgs) Handles btnVentas.Click
    '    Dim frm As New frmVentas()
    '    frm.ShowDialog()
    'End Sub



    ' ======================================================
    ' FUNCIÓN PARA CARGAR LOS CLIENTES EN EL DATAGRIDVIEW
    ' ======================================================
    Private Sub CargarClientes()
        Try
            Using cn As New SqlConnection(connectionString)
                Dim da As New SqlDataAdapter("SELECT * FROM Clientes", cn)
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
        ' Validación de campos obligatorios
        If String.IsNullOrWhiteSpace(txtCedula.Text) OrElse String.IsNullOrWhiteSpace(txtNombre.Text) Then
            MessageBox.Show("Ingrese todos los campos obligatorios.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

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

            ' Limpiar campos y recargar la tabla
            txtCedula.Clear()
            txtNombre.Clear()
            txtDireccion.Clear()
            txtTelefono.Clear()
            CargarClientes()

        Catch ex As SqlException
            MessageBox.Show("Error al guardar el cliente: " & ex.Message, "Error SQL", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class




