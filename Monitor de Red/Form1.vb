Imports MySql.Data.MySqlClient
Imports System.Net
Imports System.Net.NetworkInformation
Imports System.Net.Sockets
Imports System.Drawing

Public Class Form1

    ' Objetos para BD y notificación
    Dim Conexion As New MySqlConnection
    Dim Registra As New MySqlCommand
    Dim Notify As New NotifyIcon()

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' 🔹 Ocultar ventana principal completamente
        Me.Visible = False
        Me.ShowInTaskbar = False
        Me.Opacity = 0
        Me.WindowState = FormWindowState.Minimized

        ' 🔹 Configurar NotifyIcon
        Notify.Visible = True
        Notify.Text = "Monitor de Red"
        Notify.Icon = SystemIcons.Information  ' ícono genérico de Windows

        ' 🔹 Asociar clic del ícono
        AddHandler Notify.Click, AddressOf RegistrarDatos
    End Sub

    Private Sub RegistrarDatos(sender As Object, e As EventArgs)
        Try
            ' Conectar a MySQL
            Conexion.ConnectionString = "server=148.227.3.236;user=reporte_red;password=reporte_red;database=reporte_red"
            Conexion.Open()

            ' Hostname
            Dim hostname As String = Dns.GetHostName()

            ' IP
            Dim ipAddress As String = GetLocalIPAddress()

            ' MAC
            Dim macAddress As String = NetworkInterface.GetAllNetworkInterfaces() _
                .Where(Function(nic) nic.OperationalStatus = OperationalStatus.Up AndAlso
                                      nic.NetworkInterfaceType <> NetworkInterfaceType.Loopback) _
                .Select(Function(nic) BitConverter.ToString(nic.GetPhysicalAddress().GetAddressBytes())) _
                .FirstOrDefault()

            ' Fecha actual
            Dim fechaRegistro As String = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")

            ' Preparar comando SQL
            Registra.Connection = Conexion
            Registra.CommandText = "INSERT INTO Michell_equipos (hostname, macaddres, ip, fecha_equipo) VALUES (@hostname, @mac, @ip, @fecha)"
            Registra.Parameters.Clear()
            Registra.Parameters.AddWithValue("@hostname", hostname)
            Registra.Parameters.AddWithValue("@mac", macAddress)
            Registra.Parameters.AddWithValue("@ip", ipAddress)
            Registra.Parameters.AddWithValue("@fecha", fechaRegistro)
            Registra.ExecuteNonQuery()
            Conexion.Close()

            ' Mostrar popup Mich
            Dim popup As New Mich()
            popup.ShowDialog()

        Catch ex As Exception
            MessageBox.Show("Error al registrar: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Función para obtener IP local
    Private Function GetLocalIPAddress() As String
        Try
            Using socket As New Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp)
                socket.Connect("8.8.8.8", 65530)
                Dim endPoint As IPEndPoint = CType(socket.LocalEndPoint, IPEndPoint)
                Return endPoint.Address.ToString()
            End Using
        Catch ex As Exception
            Return "IP no disponible"
        End Try
    End Function

End Class
