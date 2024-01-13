<?php
include '../Config/Database.php';
// include '../models/Users.php';

include '../Formater/Format.php';

$fm=new Format();

$db=new Database();
$conn=$db->connect();
 // $users = new Users($db);
$flag=0;
if(isset($_POST)){
	$name=$_POST['name'];
  $phone=$_POST['phone'];
    $address=$_POST['address'];
    $email=$_POST['email'];
	$pass=$_POST['password'];
  $type=$_POST['types'];
  
  
  if(empty($email)||empty($pass)||empty($type) || empty($name)||empty($phone)||empty($address) ){
	  
    echo "All Feilds Must Be Full Sir!";
    //header("Location: loginform.php?error=emptyinputfield");
    

  }else{
	  if($type=="consumer"){
		  $meterType=$_POST['meterType'];
		  if($meterType==""){
		  echo "All Feilds Must Be Full Sir!";
		  }
	  }
    $name=$fm->validation($name);
    $phone=$fm->validation($phone);
    $address=$fm->validation($address);
    $email=$fm->validation($email);
    $pass=$fm->validation($pass);
    $type=$fm->validation($type);
	if($type=="consumer"){
    $meterType=$fm->validation($meterType);
	                     }
    if (!preg_match("/^[a-zA-Z ]*$/",$name)) {
      $flag=1;
              echo "Only letters and white space allowed";
              //echo '<br>';
            }
            if (!filter_var($email, FILTER_VALIDATE_EMAIL)) {
              $flag=1;
              echo  "Invalid email format";
             // echo "<br>";
            }
            if(!is_numeric($phone) || strlen($phone)!=9){
              $flag=1;
              echo "Invalid phone format";
             // echo "<br>";
            }
			
			$q="select email from users where email='$email'";
			$stmt = $conn->prepare($q);
      $stmt->execute();

    // Valid Login
    //echo $stmt->rowCount();
    if($stmt->rowCount()>0){
		echo "Email is already exits";
		$flag=1;
	}
            if($flag !=1){
    $query = "INSERT INTO users(name,address,phone,email, password, types) VALUES (:name,:address,:phone,:email,:pass,:types)";
          // Prepare statement
    $stmt = $conn->prepare($query);
      // Bind Param
    $stmt->bindParam(':name', $name);
    $stmt->bindParam(':address', $address);
    $stmt->bindParam(':phone', $phone);
    $stmt->bindParam(':email', $email);
    $stmt->bindParam(':pass', $pass);
    $stmt->bindParam(':types', $type);
   

    if($type=='consumer'){
      if($stmt->execute()){
        echo "inserted successfully";
	   $userid=$conn->lastInsertId();
        $metername="meter".$userid;
        $sql1="INSERT INTO meters( user_id, meter_name,meter_type) VALUES (:uid,:mname,:mmeter)";
        $stmt=$conn->prepare($sql1);
        $stmt->bindParam(':uid',$userid);
        $stmt->bindParam(':mname',$metername);
        $stmt->bindParam(':mmeter',$meterType);
        $stmt->execute();
		if($meterType == '0'){
			$unitPrice = 300;
		}else if($meterType == '1'){
			$unitPrice = 500;

		}
		$meter_id = $conn->lastInsertId();
		//echo $meter_id;
		$sql2="insert into `bill_details`(meter_id,total_unit,total_bill,unit_price,previous_reading) values ('$meter_id','0','0','$unitPrice','0')";
   
        $stmt1=$conn->prepare($sql2);
        $stmt1->execute();
		$bill_id = $conn->lastInsertId();
		
		$sql3="INSERT INTO transactions(bill_id,payment_status) VALUES ('$bill_id','0')";
		$stmt2=$conn->prepare($sql3);
		 $stmt2->execute();
        
        //header("Location: ../addusers.php?success=addUserSuccessfully");
        
      }
    }
    else{
     if($stmt->execute()){
      echo "addUserSuccessfully2";
      //header("Location: ../addusers.php?success=addUserSuccessfully");
      
    }

  }

   }   // Execute query
}
}else{
  echo "Something Wnet Wrong, please try agian!";
	//header("Location: login.php?error=plzlogin");


}



?>