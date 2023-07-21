Script Generated Using PyAthlon
Created By: Freddy Wicaksono, M.Kom
===================================
File name: data_dokter_api.php
<?php
require_once 'database.php';
require_once 'Data_dokter.php';
$db = new MySQLDatabase();
$data_dokter = new Data_dokter($db);
$id=0;
$kode_dokter=0;
// Check the HTTP request method
$method = $_SERVER['REQUEST_METHOD'];
// Handle the different HTTP methods
switch ($method) {
    case 'GET':
        if(isset($_GET['id'])){
            $id = $_GET['id'];
        }
        if(isset($_GET['kode_dokter'])){
            $kode_dokter = $_GET['kode_dokter'];
        }
        if($id>0){    
            $result = $data_dokter->get_by_id($id);
        }elseif($kode_dokter>0){
            $result = $data_dokter->get_by_kode_dokter($kode_dokter);
        } else {
            $result = $data_dokter->get_all();
        }        
       
        $val = array();
        while ($row = $result->fetch_assoc()) {
            $val[] = $row;
        }
        
        header('Content-Type: application/json');
        echo json_encode($val);
        break;
    
    case 'POST':
        // Add a new data_dokter
        $data_dokter->kode_dokter = $_POST['kode_dokter'];
        $data_dokter->nama_dokter = $_POST['nama_dokter'];
        $data_dokter->alamat = $_POST['alamat'];
       
        $data_dokter->insert();
        $a = $db->affected_rows();
        if($a>0){
            $data['status']='success';
            $data['message']='Data Data_dokter created successfully.';
        } else {
            $data['status']='failed';
            $data['message']='Data Data_dokter not created.';
        }
        header('Content-Type: application/json');
        echo json_encode($data);
        break;
    case 'PUT':
        // Update an existing data
        $_PUT = [];
        if(isset($_GET['id'])){
            $id = $_GET['id'];
        }
        if(isset($_GET['kode_dokter'])){
            $kode_dokter = $_GET['kode_dokter'];
        }
        parse_str(file_get_contents("php://input"), $_PUT);
        $data_dokter->kode_dokter = $_PUT['kode_dokter'];
        $data_dokter->nama_dokter = $_PUT['nama_dokter'];
        $data_dokter->alamat = $_PUT['alamat'];
        if($id>0){    
            $data_dokter->update($id);
        }elseif($kode_dokter<>""){
            $data_dokter->update_by_kode_dokter($kode_dokter);
        } else {
            
        } 
        
        $a = $db->affected_rows();
        if($a>0){
            $data['status']='success';
            $data['message']='Data Data_dokter updated successfully.';
        } else {
            $data['status']='failed';
            $data['message']='Data Data_dokter update failed.';
        }        
        header('Content-Type: application/json');
        echo json_encode($data);
        break;
    case 'DELETE':
        // Delete a user
        if(isset($_GET['id'])){
            $id = $_GET['id'];
        }
        if(isset($_GET['kode_dokter'])){
            $kode_dokter = $_GET['kode_dokter'];
        }
        if($id>0){    
            $data_dokter->delete($id);
        }elseif($kode_dokter>0){
            $data_dokter->delete_by_kode_dokter($kode_dokter);
        } else {
            
        } 
        
        $a = $db->affected_rows();
        if($a>0){
            $data['status']='success';
            $data['message']='Data Data_dokter deleted successfully.';
        } else {
            $data['status']='failed';
            $data['message']='Data Data_dokter delete failed.';
        }        
        header('Content-Type: application/json');
        echo json_encode($data);
        break;
    default:
        header("HTTP/1.0 405 Method Not Allowed");
        break;
    }
$db->close()
?>