Script Generated Using PyAthlon
Created By: Freddy Wicaksono, M.Kom
===================================
File name: data_pasien_api.php
<?php
require_once 'database.php';
require_once 'Data_pasien.php';
$db = new MySQLDatabase();
$data_pasien = new Data_pasien($db);
$id=0;
$kode_pasien=0;
// Check the HTTP request method
$method = $_SERVER['REQUEST_METHOD'];
// Handle the different HTTP methods
switch ($method) {
    case 'GET':
        if(isset($_GET['id'])){
            $id = $_GET['id'];
        }
        if(isset($_GET['kode_pasien'])){
            $kode_pasien = $_GET['kode_pasien'];
        }
        if($id>0){    
            $result = $data_pasien->get_by_id($id);
        }elseif($kode_pasien>0){
            $result = $data_pasien->get_by_kode_pasien($kode_pasien);
        } else {
            $result = $data_pasien->get_all();
        }        
       
        $val = array();
        while ($row = $result->fetch_assoc()) {
            $val[] = $row;
        }
        
        header('Content-Type: application/json');
        echo json_encode($val);
        break;
    
    case 'POST':
        // Add a new data_pasien
        $data_pasien->kode_pasien = $_POST['kode_pasien'];
        $data_pasien->nama_pasien = $_POST['nama_pasien'];
        $data_pasien->alamat = $_POST['alamat'];
        $data_pasien->jenis_kelamin = $_POST['jenis_kelamin'];
        $data_pasien->ttl = $_POST['ttl'];
       
        $data_pasien->insert();
        $a = $db->affected_rows();
        if($a>0){
            $data['status']='success';
            $data['message']='Data Data_pasien created successfully.';
        } else {
            $data['status']='failed';
            $data['message']='Data Data_pasien not created.';
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
        if(isset($_GET['kode_pasien'])){
            $kode_pasien = $_GET['kode_pasien'];
        }
        parse_str(file_get_contents("php://input"), $_PUT);
        $data_pasien->kode_pasien = $_PUT['kode_pasien'];
        $data_pasien->nama_pasien = $_PUT['nama_pasien'];
        $data_pasien->alamat = $_PUT['alamat'];
        $data_pasien->jenis_kelamin = $_PUT['jenis_kelamin'];
        $data_pasien->ttl = $_PUT['ttl'];
        if($id>0){    
            $data_pasien->update($id);
        }elseif($kode_pasien<>""){
            $data_pasien->update_by_kode_pasien($kode_pasien);
        } else {
            
        } 
        
        $a = $db->affected_rows();
        if($a>0){
            $data['status']='success';
            $data['message']='Data Data_pasien updated successfully.';
        } else {
            $data['status']='failed';
            $data['message']='Data Data_pasien update failed.';
        }        
        header('Content-Type: application/json');
        echo json_encode($data);
        break;
    case 'DELETE':
        // Delete a user
        if(isset($_GET['id'])){
            $id = $_GET['id'];
        }
        if(isset($_GET['kode_pasien'])){
            $kode_pasien = $_GET['kode_pasien'];
        }
        if($id>0){    
            $data_pasien->delete($id);
        }elseif($kode_pasien>0){
            $data_pasien->delete_by_kode_pasien($kode_pasien);
        } else {
            
        } 
        
        $a = $db->affected_rows();
        if($a>0){
            $data['status']='success';
            $data['message']='Data Data_pasien deleted successfully.';
        } else {
            $data['status']='failed';
            $data['message']='Data Data_pasien delete failed.';
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