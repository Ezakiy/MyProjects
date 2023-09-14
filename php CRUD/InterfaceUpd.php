<?php


error_reporting(0);

	if ($_SERVER["REQUEST_METHOD"] == "POST") {
		

			$Id = $_POST["Id"]; 
			$Id = filter_var ( $Id, FILTER_SANITIZE_NUMBER_INT); 
			if (!filter_var($Id, FILTER_SANITIZE_NUMBER_INT))	 {
	 		echo"Id Invalido";	
	 		exit;
			}


		$Modelo = $_POST["Modelo"]; 
		$Modelo = strip_tags($Modelo); 
		$Modelo = filter_var ( $Modelo, FILTER_SANITIZE_STRING); 
		if (empty($Modelo)) {
		 echo"Modelo Invalido";	
		 exit;
		}
	 
	  
		$Marca = $_POST["Marca"]; 
		$Marca = strip_tags($Marca); 
		$Marca = filter_var ( $Marca, FILTER_SANITIZE_STRING); 
		if (empty($Marca)) {
		 echo"Marca Invalida";	
		 exit;
		}
	 
		$AnoFabrico = $_POST["AnoFabrico"]; 
		$AnoFabrico = filter_var ( $AnoFabrico, FILTER_SANITIZE_NUMBER_INT); 
		 if (!filter_var($AnoFabrico, FILTER_SANITIZE_NUMBER_INT))	 {
		 echo"AnoFabrico Invalido";	
		 exit;
		}
	
		$Cor = $_POST["Cor"]; 
		$Cor = strip_tags($Cor); 
		$Cor = filter_var ( $Cor, FILTER_SANITIZE_STRING); 
		if (empty($Cor)) {
		 echo"Cor Invalida";	
		 exit;
		}
	
		$PaisOrigem = $_POST["PaisOrigem"]; 
		$PaisOrigem = strip_tags($PaisOrigem); 
		$PaisOrigem = filter_var ( $PaisOrigem, FILTER_SANITIZE_STRING); 
		if (empty($PaisOrigem)) {
		 echo"Pais Invalido";	
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


  $sql = "UPDATE Viatura set Modelo = :Modelo, Marca = :Marca, AnoFabrico = :AnoFabrico, Cor = :Cor, PaisOrigem = :PaisOrigem where Id = :Id;";

$stmt = $conn->prepare($sql);

$stmt->execute([
	':Modelo' => $Modelo,
	':Marca' => $Marca,
	':AnoFabrico' => $AnoFabrico,
	':Cor' =>  $Cor,
	':PaisOrigem' =>  $PaisOrigem,
	':Id' => $Id

]);

}
?>

<!DOCTYPE html>

<html>
   <body>

<form action = "<?php $_PHP_SELF ?>" method = "POST">
		Id:*<input type = "text" name = "Id" />
		Modelo:*<input type = "text" name = "Modelo" />
		Marca:*<input type = "text" name = "Marca" />
		AnoFabrico:*<input type = "text" name = "AnoFabrico" />
		Cor:*<input type = "text" name = "Cor" />
		PaisOrigem:*<input type = "text" name = "PaisOrigem" />
		<input type = "submit" />
 </form>

   </body>
</html>