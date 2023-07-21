Imports System
Imports System.Data
Imports System.Data.SqlClient

'
' Este ejemplo establece una conexi�n con un origen
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
            ' Objeto conexi�n
            Dim conn As SqlConnection = New SqlConnection()
            ' Objeto comando
            Dim cmd As SqlCommand
            ' Objeto lector de datos
            Dim reader As SqlDataReader
            ' Cadena de conexi�n para una base de datos SQL Server
            conn.ConnectionString = "Data Source =MAB-PORTATIL\SQLEXPRESS;Initial Catalog=ClientDB;Integrated Security=True"
            ' Abre la conexi�n
            conn.Open()

            ' Comando de lectura de una tabla SQL con la conexi�n abierta
            cmd = New SqlCommand("SELECT * FROM dbo.ClienteDatabase", conn)

            ' Obtiene un lector de datos con el m�todo ExecuteReader()
            reader = cmd.ExecuteReader()

            ' Recorre el objeto DataReader
            While reader.Read()
                Console.WriteLine(reader.GetValue(0).ToString + " " + reader.GetString(1) + " " + reader.GetValue(2).ToString)
            End While

            ' Cierre del objeto DataReader
            reader.Close()
            ' Cierre de la conexi�n
            conn.Close()


        Catch ex As SqlException
            Console.WriteLine(ex.Message)
        End Try
    End Sub
End Module
