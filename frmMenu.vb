Public Class frmMenu

    Private Sub btnClientes_Click(sender As Object, e As EventArgs) Handles btnClientes.Click
        Dim f As New Form1() ' Clientes
        f.ShowDialog()
    End Sub

    Private Sub btnVentas_Click(sender As Object, e As EventArgs) Handles btnVentas.Click
        Dim f As New frmVentas()
        f.ShowDialog()
    End Sub

    Private Sub btnCreditos_Click(sender As Object, e As EventArgs) Handles btnCreditos.Click
        Dim f As New frmCreditos()
        f.ShowDialog()
    End Sub

    Private Sub btnCobranzas_Click(sender As Object, e As EventArgs) Handles btnCobranzas.Click
        Dim f As New frmCobranzas()
        f.ShowDialog()
    End Sub

    Private Sub frmMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = Color.WhiteSmoke
    End Sub

End Class
