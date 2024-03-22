
Imports System.Data.SqlClient

' La clase Command() ejecuta sentencias SQL. El proveedor de bases de datos SQL
' tiene su propia clase Command() llamada SqlCommand()

Module CommandTest
  Sub Main()
    Try
      ' El objeto SqlConnection representa una conexión con un origen de datos 
      Dim connection As SqlConnection = New SqlConnection()
      ' Un modo más eficiente sería asignar la cadena de conexión en el momento de crear la instancia
      Dim connection As SqlConnection = New SqlConnection("Data Source=MAB-PORTATIL\SQLEXPRESS;Initial Catalog=TestDB;Integrated Security=True")
      
      ' Abre la conexión
      connection.Open()
      Console.WriteLine("Conexión establecida con la base de datos.")

      '  Una vez establecida la conexión con la base de datos
      ' ya podemos ejecutar sentencias con un objeto SqlCommand()
      ' A este objeto se le pasa como parámetros una cadena con la sentencia SQL y el objeto conexión
      Dim sqlcmd As new SqlCommand("SELECT * FROM PROVEEDORES", connection)

      ' Cierre de la conexión
      connection.Close()
    Catch ex As Exception
      Console.WriteLine("Error: " & ex.Message)
    End Try
  End Sub
End Module
