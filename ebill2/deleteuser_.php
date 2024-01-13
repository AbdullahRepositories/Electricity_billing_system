<?php
//include 'Config/Database.php';
	  $con=mysqli_connect('localhost','root','','electicity_bill_system');
    
// include '../Formater/Format.php'; 
if(isset($_POST))
{
$id=$_POST['id'];
if (!empty($id))
{
$sql="DELETE FROM users WHERE id='$id'";

      if(mysqli_query($con,$sql))
      {
            echo "Deleted Succefully";
      }

      else
      {
      	   	echo "Failed to Delete";
      }
}

      else 
      {
        echo "All feilds must be full !";
      }
}
?>