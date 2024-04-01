using System;
using System.IO;
using System.Net;
using System.Text.Json;
using static DataMahasiswa1302223074;

public class DataMahasiswa1302223074
{
    public string firstName { get; set; }
    public string lastName { get; set; }
    public string gender { get; set; }
    public int age { get; set; }
    public Alamat address { get; set; }
    public List<Courses> courses { get; set; }

    public class Alamat
    {
        public string streetAddress;
        public string city;
        public string state;
    }
    public class Courses
    {
        public string code;
        public string name;
    }
    public void ReadJSON()
    {
        string json = File.ReadAllText("D:\\Alvan\\kliah\\sem4\\kpl\\praktikum\\modul_7kel7\\1302223074\\jurnal7_1_1302223074.json");

        var dataMahasiswa = JsonSerializer.Deserialize<DataMahasiswa1302223074>(json);

        Console.WriteLine("SOAL 1");

        if (dataMahasiswa != null)
        {
            Console.WriteLine($"Nama: {dataMahasiswa.firstName} {dataMahasiswa.lastName}");
            Console.WriteLine($"Gender: {dataMahasiswa.gender}");
            Console.WriteLine($"Age: {dataMahasiswa.age}");
            Console.WriteLine("Address:");
            Console.WriteLine($"  Street: {dataMahasiswa.address.streetAddress}");
            Console.WriteLine($"  City: {dataMahasiswa.address.city}");
            Console.WriteLine($"  State: {dataMahasiswa.address.state}");

            Console.WriteLine("Courses:");
            foreach (var course in dataMahasiswa.courses)
            {
                Console.WriteLine($"  Code: {course.code}, Name: {course.name}");
            }
        }
        else
        {
            Console.WriteLine("Data mahasiswa tidak tersedia.");
        }
    }
}