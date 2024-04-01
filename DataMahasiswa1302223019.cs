using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class DataMahasiswa1302223019
{
    public string firstName { get; set; }
    public string lastName { get; set; }
    public string gender { get; set; }
    public int age { get; set; }
    public Address address { get; set; }
    public List<Course> courses { get; set; }

    public class Address
    {
        public string streetAddress { get; set; }
        public string city { get; set; }
        public string state { get; set; }
    }

    public class Course
    {
        public string code { get; set; }
        public string name { get; set; }
    }

    public void ReadJSON()
    {
        string json = File.ReadAllText("jurnal7_1_1302223019.json");

        var dataMahasiswa = JsonSerializer.Deserialize<DataMahasiswa1302223019>(json);

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