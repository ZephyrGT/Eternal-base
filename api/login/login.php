<?php
  $servername = "localhost";
  $username   = "enter ur db user";
  $password   = "enter ur pass here";
  $dbname     = "enter ur db name here";

  $conn = mysqli_connect($servername, $username, $password, $dbname);
  if (!$conn) {
    die();
  }

  $user = $_POST["username"];
  $pass = $_POST["password"];
  $id = $_POST["hwid"];

  $loginquery = $conn->prepare("SELECT username, password, hwid, blacklist, pcoinaddr FROM users WHERE username = ? AND password = ?");
  echo $conn->error;
  $loginquery->bind_param("ss", $user, $pass);
  $loginquery->execute();
  $result = $loginquery->get_result();

  if ($result->num_rows == 0)
  {
	   die("noacc");
  }

while ($row = mysqli_fetch_assoc($result)) {
  if (mysqli_num_rows($result)> 0 && $row["hwid"] == $id && $row["blacklist"] != 1)
  {
    echo("success|".$row["pcoinaddr"]);
  }
  else if (mysqli_num_rows($result) > 0 && $row["blacklist"] == 1)
  {
    echo("ban");
  }
  else if(mysqli_num_rows($result) > 0 && $row["hwid"] == $identifier)
  {
    echo("stolen");
  }
  else
  {
    echo("fail");
  }
}
?>
