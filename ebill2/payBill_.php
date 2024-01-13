<?php
include 'Formater/Format.php';
$fm=new Format();

if(isset($_POST))
{ 
    
    $con=mysqli_connect('localhost','root','','electicity_bill_system');
  
    $bid=$_POST["id"];
    //$ustatus = $_POST["status"];
    if(empty($bid)){
            echo "No data enterd :(";
        }
     else {
    $bid=$fm->validation($bid);
    if(is_numeric($bid) ){
    $sql="update transactions set payment_status=0 where bill_id='$bid' ";
    $query=mysqli_query($con,$sql);
   

    if ($query)
    {
		echo "thanks sir, payed successfully";
    }
    else
    {
        echo "Sorry, No  with this Id";
    }
    }else {
        echo "sorry, invalide id format";
    }
}

}
?>