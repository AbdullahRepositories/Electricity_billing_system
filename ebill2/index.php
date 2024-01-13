<?php  include 'include/header.php' ?>

<?php 
// include 'Formater/Format.php';
// $imgformat=new  Format();

// if(isset($_POST['submit'])){
// 	$image=$_FILES['image'];
// 	// var_dump($image);
// 	$img=$imgformat->imgformat($image);
// 	var_dump($img[0]);
// 	echo $img[1];
// }
// session_start();
?>
<div class="container">


			<?php
			if(!$_SESSION){
				?>
		<nav class="navbar navbar-inverse">
		<div class="container-fluid">
			<div class="navbar-header">
				<a class="navbar-brand" href="#">Apply For new connection</a>
			</div>

				<ul class="nav navbar-nav navbar-right">
					<!-- <li><a href="#"><span class="glyphicon glyphicon-user"></span> Sign Up</a></li> -->
					<li><a href="Applicationform.php" class="bg-primary"><span class="glyphicon glyphicon-log-in"></span> Apply</a></li>
				</ul>

						</div>
	               </nav>
	               <h1>Wellcome  home page  </h1>
	               <?php 
	               include 'include/userlist.inc.php';

	               ?>

				<?php
			}else if($_SESSION['users']['types']=='admin'){
             echo "<h1>Well come to  Admin page</h1>";
           }
           else if($_SESSION['users']['types']=='biller'){
           	?>
           	<!-- // START MITTER LISTS -->


               <?php  include 'include/meterlist.inc.php'; ?>;


           	<!-- // END MITTER LIST  -->


	<?php
            

                   
           }
           else if($_SESSION['users']['types']=='consumer'){
              echo "<h1> Well come to  Consumer pages</h1>";


   
              
               ?>


                <!-- Consumer page start  -->
                 <?php           include 'include/consumer.inc.php'; ?>



             



	<?php




                 // Consumer page end 
           }
           else if($_SESSION['users']['types']=='manager'){

              echo "<h1> Well come to  Manager pages</h1>";
           };



			?>
        


</div>
<?php 
 // include 'include/footer.php' 
?>


