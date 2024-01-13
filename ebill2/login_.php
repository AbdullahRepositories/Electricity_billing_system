<?php
include 'Config/Database.php';
// include '../models/Users.php';

include 'Formater/Format.php';




$fm=new Format();

$db=new Database();
$conn=$db->connect();
 // $users = new Users($db);

if(isset($_POST)){
	$email=$_POST["email"];
	$pass=$_POST["pass"];
	$flag=true;
  if(empty($email)||empty($pass)){
echo "sorry, Fields must be full";
  }else{
    $email=$fm->validation($email);
    $pass=$fm->validation($pass);
if (!filter_var($email, FILTER_VALIDATE_EMAIL)) {
              $flag=false;
echo  "Invalid email format";}
if($flag){
    $query = "SELECT * FROM users WHERE email =:email AND password = :pass;";
          // Prepare statement
      $stmt = $conn->prepare($query);
      // Bind Param
      $stmt->bindParam(':email', $email);
      $stmt->bindParam(':pass', $pass);
 



      // Execute query
      $stmt->execute();

    // Valid Login
    //echo $stmt->rowCount();
    if($stmt->rowCount()>0){
      // Get Result
      $result = $stmt->fetch(PDO::FETCH_ASSOC);
	  
      
echo $result['id'].":".$result['name'].":".$result['password'].":".$result['email'].":".$result['address'].":".$result['phone'].":".$result['types'];    
    }
	else {
		echo "sorry, user not found";
	}

}}}else{

echo "sorry, no data entered sir";

}
 


 ?>