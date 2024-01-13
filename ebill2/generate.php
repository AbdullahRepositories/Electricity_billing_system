<?php
include 'Config/Database.php';


$db=new Database();
$conn=$db->connect();
if(isset($_POST))
{ 
   //$con=mysqli_connect('localhost','root','','electicity_bill_system');
   //$pre="10";//$_POST["previousReading"];
   //$sql1="SELECT `id`, `user_id` FROM `meters`'";
   $meterId=$_POST["meter_id"];
   $totalUnit=$_POST["total_unit"];
   $totalBill=$_POST["total_bill"];
   $unitPrice=$_POST["unit_price"];
   $previousReading=$_POST["previous_reading"];
   $sql="insert into `bill_details`(meter_id,total_unit,total_bill,unit_price,previous_reading) values ('$meterId','$totalUnit',' $totalBill','$unitPrice',' $previousReading')";
  $stmt=$conn->prepare($sql);
  
  $bill_id = "";
   
   if($stmt->execute()){
	   
	   echo "entered successfully";
	   $bill_id = $conn->lastInsertId();
   }
   else{
	   echo "no data enterd";
   }
   $sql3="INSERT INTO transactions(bill_id) VALUES ('$bill_id')";
		$stmt2=$conn->prepare($sql3);
		 $stmt2->execute();
			 
} 
?>