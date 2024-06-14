<?php 
include ('../conn/conn.php');

if (isset($_POST['user_id'])) {
    $user_id = $_POST['user_id'];

    try {
        $conn->beginTransaction();

        // Kullanıcıyı sil
        $deleteStmt = $conn->prepare("DELETE FROM `tbl_user` WHERE `tbl_user_id` = :user_id");
        $deleteStmt->bindParam(':user_id', $user_id, PDO::PARAM_INT);

        $deleteStmt->execute();

        $conn->commit(); 

        echo "User deleted successfully!";
    } catch (PDOException $e) {
        $conn->rollBack();
        echo "Error: " . $e->getMessage();
    }
} else {
    echo "Invalid request.";
}
?>
