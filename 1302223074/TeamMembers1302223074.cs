using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class MembersData1302223074
{
    public List<Member> members { get; set; }

    public class Member
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string gender { get; set; }
        public int age { get; set; }
        public string nim { get; set; }
    }

    public void ReadJSON()
    {
        string json = File.ReadAllText("D:\\Alvan\\kliah\\sem4\\kpl\\praktikum\\modul_7kel7\\1302223074\\jurnal7_2_1302223074.json");

        var memberData = JsonSerializer.Deserialize<MembersData1302223074>(json);

        if (memberData != null && memberData.members != null)
        {
            foreach (var member in memberData.members)
            {
                Console.WriteLine($"Name: {member.firstName} {member.lastName}");
                Console.WriteLine($"Gender: {member.gender}");
                Console.WriteLine($"Age: {member.age}");
                Console.WriteLine($"NIM: {member.nim}");
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("Member data tidak tersedia.");
        }
    }
}