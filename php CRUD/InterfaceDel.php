<?php


error_reporting(0);

	if ($_SERVER["REQUEST_METHOD"] == "POST") {
			$Id = $_POST["Id"]; 
			$Id = filter_var ( $Id, FILTER_SANITIZE_NUMBER_INT); 
			if (!filter_var($Id, FILTER_SANITIZE_NUMBER_INT))	 {
	 		echo"Id Invalido";	
	 		exit;
			}


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


  $sql = "DELETE FROM Viatura where Id = :Id;";

  $stmt = $conn->prepare($sql);
  
  $stmt->execute([
	  ':Id' => $Id
  ]);

 

}


?>


<!DOCTYPE html>

<html>
   <body>

<form action = "<?php $_PHP_SELF ?>" method = "POST">
		Id:*<input type = "text" name = "Id" />
		<input type = "submit" />
 </form>

   </body>
</html>