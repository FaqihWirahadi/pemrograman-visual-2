Script Generated Using PyAthlon
Created By: Freddy Wicaksono, M.Kom
===================================
<?php
//Simpanlah dengan nama file : Data_dokter.php
require_once 'database.php';
class Data_dokter 
{
    private $db;
    private $table = 'data_dokter';
    public $kode_dokter = "";
    public $nama_dokter = "";
    public $alamat = "";
    public function __construct(MySQLDatabase $db)
    {
        $this->db = $db;
    }
    public function get_all() 
    {
        $query = "SELECT * FROM $this->table";
        $result_set = $this->db->query($query);
        return $result_set;
    }
    public function get_by_id(int $id)
    {
        $query = "SELECT * FROM $this->table WHERE id = $id";
        $result_set = $this->db->query($query);   
        return $result_set;
    }
    public function get_by_kode_dokter(int $kode_dokter)
    {
        $query = "SELECT * FROM $this->table WHERE kode_dokter = $kode_dokter";
        $result_set = $this->db->query($query);   
        return $result_set;
    }
    public function insert(): int
    {
        $query = "INSERT INTO $this->table (`kode_dokter`,`nama_dokter`,`alamat`) VALUES ('$this->kode_dokter','$this->nama_dokter','$this->alamat')";
        $this->db->query($query);
        return $this->db->insert_id();
    }
    public function update(int $id): int
    {
        $query = "UPDATE $this->table SET kode_dokter = '$this->kode_dokter', nama_dokter = '$this->nama_dokter', alamat = '$this->alamat' 
        WHERE id = $id";
        $this->db->query($query);
        return $this->db->affected_rows();
    }
    public function update_by_kode_dokter($kode_dokter): int
    {
        $query = "UPDATE $this->table SET kode_dokter = '$this->kode_dokter', nama_dokter = '$this->nama_dokter', alamat = '$this->alamat' 
        WHERE kode_dokter = $kode_dokter";
        $this->db->query($query);
        return $this->db->affected_rows();
    }
    public function delete(int $id): int
    {
        $query = "DELETE FROM $this->table WHERE id = $id";
        $this->db->query($query);
        return $this->db->affected_rows();
    }
    public function delete_by_kode_dokter($kode_dokter): int
    {
        $query = "DELETE FROM $this->table WHERE kode_dokter = $kode_dokter";
        $this->db->query($query);
        return $this->db->affected_rows();
    }
}
?>