Imports System.Data
Imports System.Data.SqlClient

Public Class frmCobranzas
    Dim connectionString As String = "Data Source=DESKTOP-EFBDO38\SQLEXPRESS;Initial Catalog=BDComandato;Integrated Security=True"

    Private Sub frmCobranzas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarPagos()
    End Sub

    Private Sub CargarPagos()
        Try
            Using cn As New SqlConnection(connectionString)
                Dim query As String = "SELECT p.IdPago, c.IdCredito, cl.Nombre AS Cliente, p.MontoPagado, p.FechaPago
                                       FROM Pagos p
                                       INNER JOIN Creditos c ON p.IdCredito = c.IdCredito
                                       INNER JOIN Clientes cl ON c.IdCliente = cl.IdCliente
                                       ORDER BY p.FechaPago DESC"
                Dim da As New SqlDataAdapter(query, cn)
                Dim dt As New DataTable()
                da.Fill(dt)
                dgPagos.DataSource = dt
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al cargar pagos: " & ex.Message)
        End Try
    End Sub

    Private Sub btnRegistrarPago_Click(sender As Object, e As EventArgs) Handles btnRegistrarPago.Click
        If String.IsNullOrWhiteSpace(txtIdCredito.Text) OrElse String.IsNullOrWhiteSpace(txtMontoPago.Text) Then
            MessageBox.Show("Complete todos los campos.", "Validación")
            Return
        End If

        Try
            Using cn As New SqlConnection(connectionString)
                Using cmd As New SqlCommand("sp_RegistrarPago", cn)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.AddWithValue("@IdCredito", Convert.ToInt32(txtIdCredito.Text))
                    cmd.Parameters.AddWithValue("@MontoPagado", Convert.ToDecimal(txtMontoPago.Text))

                    cn.Open()
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Pago registrado correctamente.", "Éxito")
            txtIdCredito.Clear()
            txtMontoPago.Clear()
            CargarPagos()

        Catch ex As SqlException
            MessageBox.Show("Error SQL: " & ex.Message)
        End Try
    End Sub
End Class
