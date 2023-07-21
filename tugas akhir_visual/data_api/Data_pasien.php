Script Generated Using PyAthlon
Created By: Freddy Wicaksono, M.Kom
===================================
<?php
//Simpanlah dengan nama file : Data_pasien.php
require_once 'database.php';
class Data_pasien 
{
    private $db;
    private $table = 'data_pasien';
    public $kode_pasien = "";
    public $nama_pasien = "";
    public $alamat = "";
    public $jenis_kelamin = "";
    public $ttl = "";
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
    public function get_by_kode_pasien(int $kode_pasien)
    {
        $query = "SELECT * FROM $this->table WHERE kode_pasien = $kode_pasien";
        $result_set = $this->db->query($query);   
        return $result_set;
    }
    public function insert(): int
    {
        $query = "INSERT INTO $this->table (`kode_pasien`,`nama_pasien`,`alamat`,`jenis_kelamin`,`ttl`) VALUES ('$this->kode_pasien','$this->nama_pasien','$this->alamat','$this->jenis_kelamin','$this->ttl')";
        $this->db->query($query);
        return $this->db->insert_id();
    }
    public function update(int $id): int
    {
        $query = "UPDATE $this->table SET kode_pasien = '$this->kode_pasien', nama_pasien = '$this->nama_pasien', alamat = '$this->alamat', jenis_kelamin = '$this->jenis_kelamin', ttl = '$this->ttl' 
        WHERE id = $id";
        $this->db->query($query);
        return $this->db->affected_rows();
    }
    public function update_by_kode_pasien($kode_pasien): int
    {
        $query = "UPDATE $this->table SET kode_pasien = '$this->kode_pasien', nama_pasien = '$this->nama_pasien', alamat = '$this->alamat', jenis_kelamin = '$this->jenis_kelamin', ttl = '$this->ttl' 
        WHERE kode_pasien = $kode_pasien";
        $this->db->query($query);
        return $this->db->affected_rows();
    }
    public function delete(int $id): int
    {
        $query = "DELETE FROM $this->table WHERE id = $id";
        $this->db->query($query);
        return $this->db->affected_rows();
    }
    public function delete_by_kode_pasien($kode_pasien): int
    {
        $query = "DELETE FROM $this->table WHERE kode_pasien = $kode_pasien";
        $this->db->query($query);
        return $this->db->affected_rows();
    }
}
?>