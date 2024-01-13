<?php
if(isset($_POST))
{ 
    
    $con=mysqli_connect('localhost','root','','electicity_bill_system');
  
    $uid=$_POST["id"];
    if(!empty($uid)){
		if($uid=="-1"){
			$sql="SELECT * FROM `complain`";
		}
		else {
		$sql="SELECT `user_id`,`complain`,`reaply_status` FROM `complain` WHERE user_id = '$uid'";}
    $query=mysqli_query($con,$sql);
    $xml = new SimpleXMLElement('<users/>');

    if (mysqli_num_rows($query)>0)
    {
            while($row = mysqli_fetch_assoc($query)){
            $Men = $xml->addChild('user');
        
            foreach ($row as $key => $value) {
            $Men->addChild($key, $value);
            }
        }
        echo $xml->asXML();
    }
    else
    {
        echo "Sorry, you have not add any complaints sir!";
    }
}
else {
    echo "Sorry, The Id could not be figured";

}}
else 
{
    echo "No data enterd :(";
}

?>