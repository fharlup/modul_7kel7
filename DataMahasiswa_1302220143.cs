using System;
using System.IO;
using System.Text.Json;

public class DataMahasiswa1302220143
{
    public class NamaMahasiswa
    {
        public string first { get; set; }
        public string last { get; set; }
    }

    public NamaMahasiswa name { get; set; }
    public long nim { get; set; }
    public string fakultas { get; set; }

    public void ReadJSON()
    {
        string json = File.ReadAllText("jurnal7_1_1302220143.json");

        var dataMahasiswa = JsonSerializer.Deserialize<DataMahasiswa1302220143>(json);

        if (dataMahasiswa.name != null)
        {
            Console.WriteLine($"Nama {dataMahasiswa.name.first} {dataMahasiswa.name.last} dengan nim {dataMahasiswa.nim} dari fakultas {dataMahasiswa.fakultas}");
        }
        else
        {
            Console.WriteLine("Nama mahasiswa tidak tersedia.");
        }
    }

}