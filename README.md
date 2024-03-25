<h1>Acceso a bases de datos Visual Basic</h1>
<p>ADO .NET es una biblioteca de clases que ofrece diversos componentes para trabajar con aplicaciones que realizan operaciones con bases de datos.</p>
<p>En ADO .NET la gestión del acceso a datos y las tareas de manipulación de estos se separan en distintos componentes. En el espacio de nombres System.Data se encuentran las clases más comunes para el acceso a datos. Además de estas clases genéricas también ofrece las clases propias para los diferentes proveedores de datos.</p>
<h3><strong>Clases de acceso a datos:</strong> </h3>
<ul>
  <li><strong><a href="https://github.com/Mablenn/database-Visual-Basic/blob/main/01_Clases_de_acceso_a_datos/ConnectionTest.vb">Connection:</a></strong> Este objeto representa una conexión con una base de datos.</li>
  <li><strong><a href="https://github.com/Mablenn/database-Visual-Basic/blob/main/01_Clases_de_acceso_a_datos/CommandTest.vb">Command:</a></strong> Un objeto Command representa una sentencia SQL o un procedimiento almacenado.</li>
  <li><strong><a href="https://github.com/Mablenn/database-Visual-Basic/blob/main/01_Clases_de_acceso_a_datos/DataReaderTest.vb">DataReader</a>:</strong> A través de este objeto se pueden realizar tareas de sólo lectura sobre los datos.</li>
  <li><strong><a href="https://github.com/Mablenn/database-Visual-Basic/blob/main/01_Clases_de_acceso_a_datos/DataAdapterTest.vb">DataAdapter</a>:</strong> Representa un conjunto de comandos SQL y una conexión a la base de datos que se utilizan para rellenar un objeto DataSet y actualizar el origen de los datos.</li>
</ul>
<h3><strong>Clases de manipulación de datos</strong></h3>
<ul>
<li><strong>DataSet:</strong> Un objeto DataSet representa un conjunto de datos en memoria obtenidos de un origen de datos.</li>
  <li><strong>DataTable</strong></li>
  <li><strong>DataRow</strong></li>
  <li><strong>DataColumn</strong></li>
  <li><strong>Constraint</strong></li>
  <li><strong>DataRelation</strong></li>
</ul>
