Imports System.Data.SqlClient

' Este ejemplo establece una conexión con una base de datos SQL Server
' a través de la clase SqlConnection()
Module Test01
    Sub Main()
        Try
            ' El objeto SqlConnection representa una conexión con 
            ' una base de datos.
            Dim connection As SqlConnection = New SqlConnection()
            connection.ConnectionString = "Data Source=NOMBRE_HOST\SQLEXPRESS;Initial Catalog=ClientDB;Integrated Security=True"
            ' Abre la conexión con la base de datos
            connection.Open()
            Console.WriteLine("Conexión establecida con la base de datos.")
        Catch ex As Exception
            Console.WriteLine("Error: " & ex.Message)
        End Try
    End Sub
End Module
