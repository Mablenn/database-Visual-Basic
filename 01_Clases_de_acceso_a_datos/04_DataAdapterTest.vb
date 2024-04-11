' Un objeto DataAdapter actúa como puente entre un conjunto de datos, por ejemplo, un objeto DataSet,
' y un origen de datos, por ejemplo, una base de datos.
' Proporciona métodos para recuperar y modificar datos en el objeto DatSet mientras mantiene la
' sincronización entre los datos y el origen de estos.

Imports System.Data.SqlClient

Module DataAdapterTest
    Sub Main()
        Dim cadenaConn As String = "Data Source=MAB-PORTATIL\SQLEXPRESS;Initial Catalog=TestDB;Integrated Security=True"
        Dim command As String = "SELECT * FROM Proveedores"
        
        ' El objeto SqlConnection representa una conexión con un origen de datos 
        Using connection As New SqlConnection(cadenaConn)

            ' Objeto SqlDataAdapter. Actua de puente entre el origen de datos y un objeto DataSet
            ' Se le pasa como parámetros el comando SQL y la cadena de conexión
            Dim adapter As New SqlDataAdapter(command, connection)

            ' El objeto DataSet representa un conjunto de datos en memoria obtenidos desde un origen de datos.
            ' Este objeto contiene los datos obtenidos en la consulta para mostralos o modificarlos.
            Dim dataSet As New DataSet()

            Try
                connection.Open()
                ' Rellena el objeto DataSet con los registros de la consulta
                ' El objeto DataSet puede estar compuesto por una o más tablas.
                adapter.Fill(dataSet, "TablaDeDataSet")

                Console.WriteLine()
                For Each table As DataTable In dataSet.Tables
                    For Each row As DataRow In table.Rows
                        Console.WriteLine($"ID: {row("proveedorId")}, Descripción: {row("descripcion")}")
                    Next
                Next
            Catch ex As Exception
                Console.WriteLine("Error al recuperar datos: " & ex.Message)
            End Try
            ' Cierre de la conexión
            connection.Close()
        End Using
        Console.ReadLine()

    End Sub
End Module
