<?php 

//include 'Config/Database.php';
include 'Formater/Format.php';
//$db=new Database();
//$conn=$db->connect();
 



 
    
if(isset($_POST)){
	    $con=mysqli_connect('localhost','root','','electicity_bill_system');

    $id=$_POST['id'];
    $complain=$_POST['complain'];
	if (empty($complain)||$id==""){
		echo "you must write you complain sir";
	}
	else {
    $sql2="SELECT name,address,phone,email FROM users WHERE id='$id'";
   $stmt2 = $con->query($sql2);
    $row2=$stmt2->fetch_assoc();
    $name=$row2['name'];
    $email=$row2['email'];
    $address=$row2['address'];
    $phone=$row2['phone'];
  
	
    $sql1="INSERT INTO complain( user_id, name, email,phone, address, complain) VALUES ('$id','$name','$email','$phone','$address','$complain')";
 
 
    if(mysqli_query($con,$sql1)){
        echo "Sent successfully";
        //header("Location:complainyour.php?success=complainedSendSuccessfully");
    }else{
        echo "Sorry, try again";
        //header("Location:index.php?error=occurssomeproblem");
    }
	}
}





   ?>
