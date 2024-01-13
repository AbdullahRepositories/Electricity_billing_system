<?php
include 'Formater/Format.php';
$fm=new Format();
if(isset($_POST))
{ 
    
    $con=mysqli_connect('localhost','root','','electicity_bill_system');
  
    $uid=$_POST["id"];
    $ustatus =$_POST["status"];

    if(empty($uid)){
        echo "No data enterd :(";
    }
    else  
    {
        $uid=$fm->validation($uid);
        $ustatus=$fm->validation($ustatus);
        if(is_numeric($uid)){
    if($ustatus == "0"){
    $sql="SELECT bill_details.id, meters.user_id,bill_details.total_unit,bill_details.total_bill,transactions.billing_date,transactions.payment_time,transactions.payment_status FROM meters INNER JOIN bill_details on meters.id=bill_details.meter_id INNER JOIN transactions on bill_details.id=transactions.bill_id where meters.user_id = '$uid' and transactions.payment_status = '0' ";}
    else
    { $sql="SELECT bill_details.id,meters.user_id,bill_details.total_unit,bill_details.total_bill,transactions.billing_date,transactions.payment_status FROM meters INNER JOIN bill_details on meters.id=bill_details.meter_id INNER JOIN transactions on bill_details.id=transactions.bill_id where meters.user_id = '$uid' and transactions.payment_status = '1' ";}
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
        echo "Sorry, No bills in this for you";
    }
}
}
    
}


?>