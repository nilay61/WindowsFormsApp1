<?php
// Veritabanı bağlantısı
$servername = "localhost";
$username = "root";
$password = ""; 
$dbname = "gyazproje"; 

// Bağlantı oluşturma
$conn = new mysqli($servername, $username, $password, $dbname);

// Bağlantı kontrol 
if ($conn->connect_error) {
    die("Bağlantı hatası: " . $conn->connect_error);
}

if(isset($_POST['update'])){
    $name = $_POST['name'];
    $username = $_POST['username'];

    $sql = "UPDATE tbl_user SET name='$name', username='$username' WHERE id='$id'";

    if ($conn->query($sql) === TRUE) {
        echo "Kayıt başarıyla güncellendi.";
    } else {
        echo "Hata: " . $sql . "<br>" . $conn->error;
    }
}

if(isset($_GET['id'])){
    $id = $_GET['id'];

    $sql = "SELECT * FROM tbl_user WHERE id='$id'";
    $result = $conn->query($sql);

    if ($result->num_rows > 0) {
        $row = $result->fetch_assoc();
        $name = $row['name'];
        $username = $row['username'];
    } else {
        echo "Kayıt bulunamadı.";
    }
}


$conn->close();
?>

<!DOCTYPE html>
<html>
<head>
    <title>Kayıt Güncelleme</title>
</head>
<body>
    <h2>Kayıt Güncelleme Formu</h2>
    <form method="post" action="">
        <input type="hidden" name="id" value="<?php echo $id; ?>">
        Name: <input type="text" name="name" value="<?php echo $name; ?>"><br>
        Username: <input type="email" name="username" value="<?php echo $username; ?>"><br>
        <input type="submit" name="update" value="Güncelle">
    </form>
</body>
</html>
