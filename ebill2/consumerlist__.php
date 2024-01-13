<?php

if(isset($_POST))
{ 
    $con=mysqli_connect('localhost','root','','electicity_bill_system');
	
   $id=$_POST["id"];
   //if($id!=""){
   $sql="SELECT * FROM users WHERE id='$id' ";
    //$query=mysqli_query($con,$sql);
    //$xml = new SimpleXMLElement('<users/>');


//$sql = "SELECT id, firstname, lastname FROM MyGuests";
$result = $con->query($sql);
$flag=0;
if ($result->num_rows > 0) {
  // output data of each row
  while($row = $result->fetch_assoc()) {
    //echo "name:" . $row["name"]. " address:" . $row["address"]. " phone:" . $row["phone"]. "<br>";
	if ($row["types"]=="consumer"){
		$flag=1;
	    echo  $row["name"].":".$row["address"].":".$row["phone"].":";
	}
	else {
		echo "this id dose not belong to a consumer";
	}
  }
  
   /* if (mysqli_num_rows($query)>0)
    {
		
            /*while($row = mysqli_fetch_assoc($query)){
            $Men = $xml->addChild('user');
        
            foreach ($row as $key => $value) {
            $Men->addChild($key, $value);
            }
        }
	echo $xml->asXML();}*/
}
if ($flag==1){
$sql2="SELECT bill_details.previous_reading, meters.meter_type,meters.id FROM meters inner join bill_details on meters.id=bill_details.meter_id WHERE meters.user_id='$id'ORDER by Date desc LIMIT 1";
$result2 = $con->query($sql2);
if($result2->num_rows > 0 ) {
	
	while($row2 = $result2->fetch_assoc()) {
		echo $row2["previous_reading"].":".$row2["meter_type"].":".$row2["id"];
	}
}else {
	echo "none";
}
}
	
	


   //}
    else
    {
        echo "Sorry, you did not enter id ";
    }
    
}
else 
{
    echo "No data enterd :(";
}

?>

			

