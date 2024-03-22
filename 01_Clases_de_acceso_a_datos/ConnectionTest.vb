' Establece una conexión con una base de datos. Dependiendo del proveedor de la base de datos
' esta clase puede tener un nombre distinto. Para SQL Server la clase se denomina SqlConnection()

Imports System.Data.SqlClient

Module ConnectionTest
  Sub Main()
    Try
      ' El objeto SqlConnection representa una conexión con un origen de datos 
      Dim connection As SqlConnection = New SqlConnection()
      
      ' Al método ConnectionString() le asignamos la cadena de conexión a la base de datos         
      connection.ConnectionString = "Data Source=MAB-PORTATIL\SQLEXPRESS;Initial Catalog=TestDB;Integrated Security=True"
      
      ' Un modo más eficiente sería asignar la cadena de conexión en el momento de crear la instancia
      ' Dim connection As SqlConnection = New SqlConnection("Data Source=MAB-PORTATIL\SQLEXPRESS;Initial Catalog=TestDB;Integrated Security=True")
      
      ' Abre la conexión
      connection.Open()
      Console.WriteLine("Conexión establecida con la base de datos.")

      ' Cierre de la conexión
      connection.Close()
    Catch ex As Exception
      Console.WriteLine("Error: " & ex.Message)
    End Try
  End Sub
End Module
