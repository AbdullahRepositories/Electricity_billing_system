
           	<?php  
//include 'include/header.php';
include 'Config/Database.php';
include 'Formater/Format.php';
$fm=new Format();
$db=new Database();
$conn=$db->connect();
if(isset($_POST))
{ 
$type="consumer";//_POST["types"];
$sql="SELECT * FROM users WHERE types='$type' ";
$stmt=$conn->prepare($sql);
$stmt->execute();
$userArray=array();
//$xml=new SimpleXMLElement('<Users/>');
if($stmt->rowCount()>0) {
    while($result = $stmt->fetch(PDO::FETCH_ASSOC)){
        //echo $result;
         //var_dump($result);
        $userArray[]=$result;
 
            }
            echo json_encode($userArray);
}

else {
    echo "sorry, ";
}

}
?>
