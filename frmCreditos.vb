Imports System.Data
Imports System.Data.SqlClient

Public Class frmCreditos
    Dim connectionString As String = "Data Source=DESKTOP-EFBDO38\SQLEXPRESS;Initial Catalog=BDComandato;Integrated Security=True"

    Private Sub frmCreditos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarCreditos()
    End Sub

    Private Sub CargarCreditos()
        Try
            Using cn As New SqlConnection(connectionString)
                Dim query As String = "SELECT c.IdCredito, cl.Nombre AS Cliente, c.Monto, c.PlazoMeses, c.Estado, c.FechaSolicitud
                                       FROM Creditos c INNER JOIN Clientes cl ON c.IdCliente = cl.IdCliente"
                Dim da As New SqlDataAdapter(query, cn)
                Dim dt As New DataTable()
                da.Fill(dt)
                dgCreditos.DataSource = dt
            End Using
        Catch ex As Exception
            MessageBox.Show("Error al cargar créditos: " & ex.Message)
        End Try
    End Sub

    Private Sub btnGuardarCredito_Click(sender As Object, e As EventArgs) Handles btnGuardarCredito.Click
        If String.IsNullOrWhiteSpace(txtIdClienteCredito.Text) OrElse String.IsNullOrWhiteSpace(txtMonto.Text) OrElse String.IsNullOrWhiteSpace(txtPlazo.Text) Then
            MessageBox.Show("Complete todos los campos.", "Validación")
            Return
        End If

        Try
            Using cn As New SqlConnection(connectionString)
                Using cmd As New SqlCommand("sp_InsertarCredito", cn)
                    cmd.CommandType = CommandType.StoredProcedure
                    cmd.Parameters.AddWithValue("@IdCliente", Convert.ToInt32(txtIdClienteCredito.Text))
                    cmd.Parameters.AddWithValue("@Monto", Convert.ToDecimal(txtMonto.Text))
                    cmd.Parameters.AddWithValue("@PlazoMeses", Convert.ToInt32(txtPlazo.Text))

                    cn.Open()
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Crédito registrado correctamente.", "Éxito")
            txtIdClienteCredito.Clear()
            txtMonto.Clear()
            txtPlazo.Clear()
            CargarCreditos()

        Catch ex As SqlException
            MessageBox.Show("Error SQL: " & ex.Message)
        End Try
    End Sub
End Class
