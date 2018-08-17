
<?php error_reporting(0);
?>
<!DOCTYPE html>
<html>
<head>
<meta charset="UTF-8">
 <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">
<title>Contact</title>
<link rel="shortcut icon" type="image/png" href="favi.png"/>
<link href="bootstrap/css/bootstrap.min.css" rel="stylesheet">
<link href='https://fonts.googleapis.com/css?family=Oswald' rel='stylesheet' type='text/css'>
<link href = "style.css" rel = "stylesheet">

<meta http-equiv="content-type" content="text/html; charset=iso-8859-1" />

</head>

<body>
<!-- jQuery (necessary for Bootstrap's JavaScript plugins) -->
<script src="https://ajax.googleapis.com/ajax/libs/jquery/1.11.3/jquery.min.js"></script>
<!-- Include all compiled plugins (below), or include individual files as needed -->
<script src="bootstrap/js/bootstrap.min.js"></script>

<nav>
<?php
include("nav.php");
?>
</nav>
<div id = "wrapper">

<?php
	function validateInput($data, $fieldname, $index)
	{
		global $errorCount, $errors;
		if(empty($data))
		{
			$errors[$index] = "<span class='text-danger'>This field is required</span>";
			++$errorCount;
			$retval = "";
		}
		else
		{
			$retval = trim($data);
			$retval = stripslashes($retval);			
		}
		return($retval);
	}
	function validateEmail($data, $fieldName, $index)
	{
		global $errorCount, $errors;
		if(empty($data))
		{
			
			$errors[$index] = "<span class='text-danger'>This field is required</span>";
			++$errorCount;
			$retval = "";
		}
		else
		{
			if(filter_var($data, FILTER_VALIDATE_EMAIL) === false)
			{
				$errors[$index] = "<span class='text-danger'>This field is required</span>";
				++$errorCount;				
			}
			else
				$retval = $data;
		}

		return($retval);
	}
	function displayForm($name, $email, $subject, $message, $errors)
	{
		//print_r($errors);
	?>
	<div style = "text-align:center; padding-left:0px;">
		<h1>Contact Me</h1>
		<a href = "https://www.linkedin.com/in/andrew-singley-328427148"><img src="in.png" class="img-fluid" alt="LinkedIn" width="25" height="25"></a>	
		<a href = "tel:1-229-921-3956"><img src="phone.png" class="img-fluid" alt="Phone" width="25" height="25"></a>
		<a href = "mailto:contact.andrewsingley12@gmail.com?"><img src="mail.png" class="img-fluid" alt="Email" width="25" height="20"></a>
	</div>	
	<div class = "centerForm">
		<form class = "form-horizontal" name = "contact" action= "contact.php" method= "post">
			<div class="form-group">
				<label for="inputName">Your Name: </label><br>
				<div class="col-sm-10">
					<input type="text" id="inputName" class="form-control" placeholder = "Name" name="name" value="<?php echo $name; ?>" />
					<span><?php if(isset($errors['name'])){ echo $errors['name']; } ?></span>
				</div>
			</div>
			<div class="form-group">
				<label for="inputemail">Your Email: </label><br>
				<div class="col-sm-10">
					<input type="text" id="inputName" class="form-control" placeholder = "Email" name="email" value="<?php echo $email; ?>" />
					<span><?php if(isset($errors['email'])){ echo $errors['email']; } ?></span>
				</div>
			</div>
			<div class="form-group">
				<label for="inputsubject">Subject: </label><br>
				<div class="col-sm-10">
					<input type="text" id = "inputsubject" class="form-control" placeholder = "Subject" name="subject" value="<?php echo $subject; ?>" />
					<span><?php if(isset($errors['subject'])){ echo $errors['subject']; } ?></span>
				</div>
			</div>
			<div class="form-group">
				<label for="inputMessage">Message: </label><br>
				<div class="col-sm-10">
					<textarea placeholder="Please Enter Your Message..." id="inputMessage" class="form-control" rows="3" name="message" value="<?php echo $message; ?>"/></textarea>
					<span><?php if(isset($errors['message'])){ echo $errors['message']; } ?></span>
				</div>
			</div>			
			<div class="form-group">
				<input class="btn btn-default btn-sm" type="reset" value ="Clear Form" />&nbsp;
				&nbsp;<input class="btn btn-primary btn-sm active" type = "submit" name="Submit" value="Submit" />
			</div>						
		</form>
	</div>
	<?php
	}
	$ShowForm = TRUE;
	$errorCount = 0;
	$errors = array();
	$name = "";
	$email = "";
	$subject = "";
	$message = "";
	
	if(isset($_POST['Submit']))
	{
		$name = validateInput($_POST['name'], "Your Name", "name");
		$email = validateEmail($_POST['email'], "Your email", "email");
		$subject = validateInput($_POST['subject'], "subject", "subject");
		$message = validateInput($_POST['message'], "message", "message");
		
		if($errorCount==0)
			$ShowForm = FALSE;
		else
			$ShowForm = TRUE;
	}
	if($ShowForm == TRUE)
	{
		if($errorCount > 0)
			echo "<h3 style = \"color:#cc0000; text-align: center;\">Please re-enter the form information below.</h3>";
		displayForm($name, $email, $subject, $message, $errors);
	}
	else
	{
		$from = 'Online Portfolio'; 
		$to = 'contact.andrewsingley12@gmail.com'; 		
		$body = "From: $name\n E-Mail: $email\n Message:\n $message";
		
		if (mail ($to, $subject, $body, $from)) {
			$result='<div class="alert alert-success">Thank You! Your form has been submitted!</div>';
			echo $result;
		} 
		else 
		{
			$result='<div class="alert alert-danger">An error has occured. Please try again later.</div>';
			echo $result;
		}
	}
?>

</body>
</html>