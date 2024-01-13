<?php   

include 'Config/Database.php';
include 'Formater/Format.php';
$db=new Database();
$conn=$db->connect();
$fm=new Format();

$flag=0;
if(isset($_POST)){
   $id=$_POST['id'];
   $name=$_POST['name'];
   $email=$_POST['email'];
   $address=$_POST['address'];
   $phone=$_POST['phone'];
   $password=$_POST['password'];
   //$types=$_POST['types'];
   if(empty($id)||empty($name)||empty($email) || empty($address)||empty($phone)||empty($password)){
    echo "Sorry, you have to fill the feilds sir ";
    
   }else{
    $id=$fm->validation($id);
    $name=$fm->validation($name);
    $phone=$fm->validation($phone);
    $address=$fm->validation($address);
    $email=$fm->validation($email);
    $password=$fm->validation($password);
    if (!preg_match("/^[a-zA-Z ]*$/",$name)) {
$flag=1;
        echo "Only letters and white space allowed";
        echo '<br>';
      }
      if (!filter_var($email, FILTER_VALIDATE_EMAIL)) {
        $flag=1;
        echo  "Invalid email format";
       
      }
      if(!is_numeric($phone) || strlen($phone)!=9){
        $flag=1;
        echo "Invalid phone format";
        echo "<br>";
      }
if($flag !=1){
      $sql1="UPDATE users SET name=:name,address=:address,phone=:phone,email=:email,password=:password WHERE id=:id";
    $stmt=$conn->prepare($sql1);

      $stmt->bindParam(':name', $name);
      $stmt->bindParam(':address', $address);
      $stmt->bindParam(':phone', $phone);
      $stmt->bindParam(':email', $email);
      $stmt->bindParam(':password', $password);
    
      $stmt->bindParam(':id', $id);


     if($stmt->execute()) {

      echo("Updated Successfully");

     }else{
         echo "wrong";
     }
}
    //$type=$fm->validation($type);
   }
    // echo $name;
    // echo $email;
    // echo $password;
    // echo $types;
    




 }




    
       ?>
