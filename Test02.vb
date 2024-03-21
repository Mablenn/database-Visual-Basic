Imports System.Data.SqlClient

' Ejemplo para establecer una sencilla conexión con una base de datos SQL Server
' a través de la clase SqlConnection()
Module Test02
    Sub Main()
        Dim cadenaConexion As String = "Data Source=MAB-PORTATIL\SQLEXPRESS;Initial Catalog=TestDB;Integrated Security=True"
        Using myConnection As New SqlConnection(cadenaConexion)
            ' Abre la conexión
            myConnection.Open()
            Console.WriteLine("Conexión establecida con la base de datos.")
        End Using
    End Sub
End Module
