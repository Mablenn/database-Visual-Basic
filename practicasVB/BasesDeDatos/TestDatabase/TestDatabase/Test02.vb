Imports System.Data.SqlClient
Module Test02
    Sub Main()
        ' El objeto Connection representa una sesión con la DB
        Dim connection As SqlConnection = New SqlConnection("Data Source=MAB-PORTATIL\SQLEXPRESS;Initial Catalog=ClientDB;Integrated Security=True")
        ' Objeto comando sql
        Dim cmd As SqlCommand
        ' Objeto para lectura de datos
        Dim reader As SqlDataReader



        ' Abre la conexión
        connection.Open()
        ' Comando sql para leer registros de una tabla + conexión
        cmd = New SqlCommand("SELECT * FROM prevision", connection)
        ' Obtiene un lector de datos
        reader = cmd.ExecuteReader()

        ' Recorre el objeto DataReader
        While reader.Read()
            Console.WriteLine("IdPrevision: " + reader.GetValue(0).ToString)
        End While

        ' Cierre del DataReader
        reader.Close()
        'Cierre de la conexión
        connection.Close()
    End Sub
End Module
