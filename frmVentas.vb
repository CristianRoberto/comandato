Imports System.Data
Imports System.Data.SqlClient

Public Class frmVentas

    ' Cadena de conexión a tu BDComandato
    Dim connectionString As String = "Data Source=DESKTOP-EFBDO38\SQLEXPRESS;Initial Catalog=BDComandato;Integrated Security=True"

    Private Sub frmVentas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarVentas()
    End Sub

    Private Sub CargarVentas()
        Try
            Using cn As New SqlConnection(connectionString)
                Dim query As String = "SELECT v.IdVenta, c.Nombre AS Cliente, v.Fecha, v.Total 
                                       FROM Ventas v
                                       INNER JOIN Clientes c ON v.IdCliente = c.IdCliente
                                       ORDER BY v.Fecha DESC"

                Dim da As New SqlDataAdapter(query, cn)
                Dim dt As New DataTable()
                da.Fill(dt)
                dgVentas.DataSource = dt
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al cargar las ventas: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnGuardarVenta_Click(sender As Object, e As EventArgs) Handles btnGuardarVenta.Click
        ' Validar que los campos no estén vacíos
        If String.IsNullOrWhiteSpace(txtIdCliente.Text) OrElse String.IsNullOrWhiteSpace(txtTotal.Text) Then
            MessageBox.Show("Complete los campos obligatorios.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            Using cn As New SqlConnection(connectionString)
                Using cmd As New SqlCommand("sp_InsertarVenta", cn)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.AddWithValue("@IdCliente", Convert.ToInt32(txtIdCliente.Text))
                    cmd.Parameters.AddWithValue("@Total", Convert.ToDecimal(txtTotal.Text))

                    cn.Open()
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Venta registrada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Limpiar campos
            txtIdCliente.Clear()
            txtTotal.Clear()

            ' Recargar ventas
            CargarVentas()

        Catch ex As SqlException
            MessageBox.Show("Error al registrar la venta: " & ex.Message, "Error SQL", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
