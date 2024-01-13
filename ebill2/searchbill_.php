<?php
if(isset($_POST))
{ 
    
    $con=mysqli_connect('localhost','root','','electicity_bill_system');
  
    $uid=$_POST["id"];
    $ustatus = $_POST["status"];
    
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
        echo "Sorry, No food in this menu";
    }
    
}
else 
{
    echo "No data enterd :(";
}

?>