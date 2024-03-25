' La clase DataReader permite la lectura de un conjunto de resultados de una consulta SQL.
' Hay que tener en cuenta que esta clase sólo permite lectura de datos y no modificación.
' La clase DataReader que ofrece SQL Server es SqlDataReader.
Imports System.Data.SqlClient

Module DataReaderTest
    Sub Main()
        Try
            ' 1 - Establece conexión con la base de datos.
            ' El objeto SqlConnection representa una conexión con un origen de datos 
            Dim connection As New SqlConnection("Data Source=MAB-PORTATIL\SQLEXPRESS;Initial Catalog=GastosDB;Integrated Security=True")
            ' Abre la conexión
            connection.Open()
            Console.WriteLine("Conexión establecida con la base de datos.")

            ' 2 - Ejecuta sentencias de lectura de datos
            ' ya podemos ejecutar sentencias SQL con un objeto SqlCommand()
            ' A este objeto se le pasa como parámetros una cadena con la sentencia SQL y el objeto conexión
            Dim sqlcmd As New SqlCommand("SELECT * FROM Proveedores", connection)
            Console.WriteLine("Se ha ejecutado la sentencia SELECT.")

            ' 3 - Lectura de datos
            ' La clase SqlDataReader permite la lectura de un conjunto de resultados
            ' de una consulta SQL. Este objeto se crea llamando al método ExecuteReader() de la clase SqlCommand()
            Dim reader As SqlDataReader = sqlcmd.ExecuteReader()
            ' Comprueba si obtiene datos y recorre el DataReader secuencialmente
            If reader.HasRows Then
                While reader.Read
                    Console.WriteLine(reader("proveedorId").ToString & " -- " & reader("descripcion"))
                End While
            Else
                Console.WriteLine("No se encontraron registros.")
            End If
            Console.ReadLine()
            ' Cierre de la conexión
            connection.Close()
        Catch ex As Exception
            Console.WriteLine("Error: " & ex.Message)
        End Try
    End Sub
End Module


