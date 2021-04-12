<?php
  $servername = "localhost";
  $username   = "enter ur db user";
  $password   = "enter ur pass here";
  $dbname     = "enter ur db name here";

  $conn = mysqli_connect($servername, $username, $password, $dbname);
  if (!$conn) {
    die();
  }

  $ip = $_SERVER["HTTP_X_FORWARDED_FOR"];
  $user = $_POST["username"];
  $pass = $_POST["password"];
  $id = $_POST["hwid"];

  $json = file_get_contents("https://ip.teoh.io/api/vpn/$ip");
  $arr = json_decode($json);
  $vpn = $arr->vpn_or_proxy;
  if($vpn == "yes"){
	   die("vpn");
  }

  $dupcheck = $conn->prepare("SELECT * FROM users WHERE ip = ? OR hwid = ?");
  $dupcheck->bind_param("ss", $ip, $id);
  $dupcheck->execute();
  $res = $dupcheck->get_result();
  if(mysqli_num_rows($res) > 0){
      $stmtip->close();
      die("overuse");
  }
  $dupcheck->close();

  if(isset($user) && isset($pass) && isset($id)) {
    $usercheck = $conn->prepare("SELECT username FROM users WHERE username = ?");
    $usercheck->bind_param("s", $user);
    $usercheck->execute();
    $res = $usercheck->get_result();
    if (mysqli_num_rows($res) > 0)
    {
      die("overuse");
    }
    else {
      $pcoinaddr = md5($user);
      $reg = $conn->prepare("INSERT INTO users (username, password, hwid, ip, blacklist, pcoinaddr, pcoin) VALUES (?, ?, ?, ?, 0, ?, 0)");
      $reg->bind_param("sssss", $user, $pass, $id, $ip, $pcoinaddr);

      if ($reg->execute())
      {
        $table = "db$user";
        $regquery = "CREATE TABLE $table(ID int PRIMARY KEY AUTO_INCREMENT, packet text, ip text, date text, hacked bool)";
        $regresult = mysqli_query($conn, $regquery);
        if ($regresult)
        {
          die("success");
        }
        else {
          die("fail");
        }
      }
      else {
        die("fail");
      }
    }
  }

?>
