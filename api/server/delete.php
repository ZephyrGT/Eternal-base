<?php
  $servername = "localhost";
  $username   = "enter ur db user";
  $password   = "enter ur pass here";
  $dbname     = "enter ur db name here";

  function filter($idz, $del) {
    if ($idz == "0")
    {
      return "DELETE FROM  team" . $_POST["username"] . " WHERE ID = $del";
    }
    else {
      return "DELETE FROM db" . $_POST["username"] . " WHERE ID = $del";
    }
  }

  $conn = mysqli_connect($servername, $username, $password, $dbname);
  if (!$conn) {
    die();
  }

  $user = $_POST["username"];
  $pass = $_POST["password"];
  $id = $_POST["hwid"];
  $deleteid = $_POST["deleteid"];

  if(isset($user) && isset($pass) && isset($id)) {
    $usercheck = $conn->prepare("SELECT * FROM users WHERE username = ? AND password = ? AND hwid = ?");
    $usercheck->bind_param("sss", $user, $pass, $id);
    $usercheck->execute();
    $res = $usercheck->get_result();
    if (mysqli_num_rows($res) > 0)
    {
      $delete = $conn->prepare(filter($id, $deleteid));
      $delete->execute();
    }
  }

?>
