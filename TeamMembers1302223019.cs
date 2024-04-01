using System;
using System.IO;
using System.Text.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using static TeamMembers1302223019;
internal class TeamMembers1302223019
{
    public class TeamMembers
    {
        [JsonPropertyName("courses")]
        public Course[] Courses { get; set; }
    }
    public class Course
    {
        [JsonPropertyName("code")]
        public String code { get; set; }
        [JsonPropertyName("name")]
        public String name { get; set; }
    }

    public void ReadJSON()
    {
        string filePath = "tp7_2_1302223019.json";

        string jsonText = File.ReadAllText(filePath);

        TeamMembers TeamMembers = JsonSerializer.Deserialize<TeamMembers>(jsonText);

        Console.WriteLine("Daftar mata kuliah yang diambil:");

        for (int i = 0; i < TeamMembers.Courses.Length; i++)
        {
            Console.WriteLine($"MK {i + 1} {TeamMembers.Courses[i].code} - {TeamMembers.Courses[i].name}");
        }
    }
}