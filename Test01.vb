Imports System
Imports System.Data
Imports System.Data.SqlClient

'
' Este ejemplo establece una conexión con un origen
' de datos SQL Server
'
' Las clases que se van a utilizar son:
'
'   Connection()
'   Command()
'   DataReader()
'   DataAdapter()
'
Module Program
    Sub Main(args As String())

        Try
            ' Objeto conexión
            Dim conn As SqlConnection = New SqlConnection()
            ' Objeto comando
            Dim cmd As SqlCommand
            ' Objeto lector de datos
            Dim reader As SqlDataReader
            ' Cadena de conexión para una base de datos SQL Server
            ' Ojo. En este ejemplo la conexión se establece como equipo local y no como Server Authorization
            conn.ConnectionString = "Data Source =MAB-PORTATIL\SQLEXPRESS;Initial Catalog=ClientDB;Integrated Security=True"
            ' Abre la conexión
            conn.Open()

            ' Comando de lectura de una tabla SQL con la conexión abierta
            cmd = New SqlCommand("SELECT * FROM dbo.ClienteDatabase", conn)

            ' Obtiene un lector de datos con el método ExecuteReader()
            reader = cmd.ExecuteReader()

            ' Recorre el objeto DataReader
            While reader.Read()
                Console.WriteLine(reader.GetValue(0).ToString + " " + reader.GetString(1) + " " + reader.GetValue(2).ToString)
            End While

            ' Cierre del objeto DataReader
            reader.Close()
            ' Cierre de la conexión
            conn.Close()


        Catch ex As SqlException
            Console.WriteLine(ex.Message)
        End Try
    End Sub
End Module
