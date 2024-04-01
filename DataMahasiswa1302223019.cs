using System;
using System.IO;
using System.Text.Json;

public class DataMahasiswa1302223019
{
    public class NamaMahasiswa
    {
        public string depan { get; set; }
        public string belakang { get; set; }
    }

    public NamaMahasiswa nama { get; set; }
    public long nim { get; set; }
    public string fakultas { get; set; }

    public void ReadJSON()
    {
        string json = File.ReadAllText("tp7_1_1302223019.json");

        var dataMahasiswa = JsonSerializer.Deserialize<DataMahasiswa1302223019>(json);

        if (dataMahasiswa.nama != null)
        {
            Console.WriteLine($"Nama {dataMahasiswa.nama.depan} {dataMahasiswa.nama.belakang} dengan nim {dataMahasiswa.nim} dari fakultas " +
                $"{dataMahasiswa.fakultas}");
        }
        else
        {
            Console.WriteLine("Nama mahasiswa tidak tersedia.");
        }
    }
    static void Main(string[] args)
    {
        DataMahasiswa1302223019 dataMahasiswa = new DataMahasiswa1302223019();

        // Read and display the JSON data
        dataMahasiswa.ReadJSON();

        Console.WriteLine();
    }

}


