 
 
 <?php
 
 error_reporting(0);

	


$servername = "localhost";
$username = "root";
$password = "";

try {
	$conn = new PDO("mysql:host=$servername;dbname=CRUD", $username, $password);
	// set the PDO error mode to exception
	$conn->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);
	echo "Connected successfully";
  } catch(PDOException $e) {
	echo "Connection failed: " . $e->getMessage();
  }

 $sql = "SELECT * FROM viatura";

  $stmt = $conn->prepare($sql);
  
  $stmt = $conn->query($sql);
  
  $result = $stmt->fetchAll(); //fetch()
  
  
  if (count($result) > 0) {
    echo "<table><tr><th>Id</th><th>Modelo</th><th>Marca</th><th>AnoFabrico</th><th>Cor</th><th>PaisOrigem</th></tr>";
    // output data of each row
    foreach ($result as $row) {
      echo "<tr><td>".$row["Id"]."</td><tr><td>".$row["Modelo"]."</td><tr><td>".$row["Marca"]."</td><tr><td>".$row["AnoFabrico"]."</td><tr><td>".$row["Cor"]."</td><tr><td>".$row["PaisOrigem"]."</td></tr>";
    }
    echo "</table>";
  } else {
    echo "0 results";
  }
  
  $conn = null;
    



  ?>