Imports MySql.Data.MySqlClient
Imports System.Configuration

Public Class Form1
    Dim connectionString As String = ConfigurationManager.ConnectionStrings("Taller").ConnectionString

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Using conexion As New MySqlConnection(connectionString)

        End Using
    End Sub

    Private Sub BTINGRESAR_Click(sender As Object, e As EventArgs) Handles BTINGRESAR.Click
        Using conexion As New MySqlConnection(connectionString)
            Dim command As New MySqlCommand("SELECT * FROM usuarios WHERE Correo = @correo AND Contraseña = @contraseña", conexion)
            command.Parameters.AddWithValue("@correo", TXUSUARIO.Text)
            command.Parameters.AddWithValue("@contraseña", TXCONTRASEÑA.Text)

            Try
                conexion.Open()
                Dim reader As MySqlDataReader = command.ExecuteReader()
                If reader.HasRows Then
                    MessageBox.Show("Ingresado correctamente!", "Sesión iniciada", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Credenciales incorrectas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
                reader.Close()
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub MenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MenuToolStripMenuItem.Click
        Dim form2 As New Form2()

        form2.Show()




    End Sub




End Class
