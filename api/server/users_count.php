<?php
  $servername = "localhost";
  $username   = "enter ur db user";
  $password   = "enter ur pass here";
  $dbname     = "enter ur db name here";

  $conn = mysqli_connect($servername, $username, $password, $dbname);
  if (!$conn) {
    die();
  }

  $result = $conn->query("SELECT COUNT(*) FROM users");
  while ($row = $result->fetch_row()){
      echo $row[0];
  }
?>
