﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class GlossaryData1302223083
{
    public Glossary glossary { get; set; }

    public class Glossary
    {
        public string title { get; set; }
        public GlossDiv GlossDiv { get; set; }
    }

    public class GlossDiv
    {
        public string title { get; set; }
        public GlossList GlossList { get; set; }
    }

    public class GlossList
    {
        public GlossEntry GlossEntry { get; set; }
    }

    public class GlossEntry
    {
        public string ID { get; set; }
        public string SortAs { get; set; }
        public string GlossTerm { get; set; }
        public string Acronym { get; set; }
        public string Abbrev { get; set; }
        public GlossDef GlossDef { get; set; }
        public string GlossSee { get; set; }
    }

    public class GlossDef
    {
        public string para { get; set; }
        public List<string> GlossSeeAlso { get; set; }
    }

    public void ReadJSON()
    {
        string json = File.ReadAllText("jurnal7_3_1302223083.json");

        var glossaryData = JsonSerializer.Deserialize<GlossaryData1302223083>(json);

        if (glossaryData != null && glossaryData.glossary != null && glossaryData.glossary.GlossDiv != null && glossaryData.glossary.GlossDiv.GlossList != null && glossaryData.glossary.GlossDiv.GlossList.GlossEntry != null)
        {
            var glossEntry = glossaryData.glossary.GlossDiv.GlossList.GlossEntry;
            Console.WriteLine($"Title: {glossaryData.glossary.title}");
            Console.WriteLine($"Glossary Title: {glossaryData.glossary.GlossDiv.title}");
            Console.WriteLine($"ID: {glossEntry.ID}");
            Console.WriteLine($"SortAs: {glossEntry.SortAs}");
            Console.WriteLine($"GlossTerm: {glossEntry.GlossTerm}");
            Console.WriteLine($"Acronym: {glossEntry.Acronym}");
            Console.WriteLine($"Abbrev: {glossEntry.Abbrev}");
            Console.WriteLine($"GlossDef: {glossEntry.GlossDef.para}");
            Console.WriteLine($"GlossSee: {glossEntry.GlossSee}");

            Console.WriteLine("GlossSeeAlso:");
            foreach (var item in glossEntry.GlossDef.GlossSeeAlso)
            {
                Console.WriteLine($"  - {item}");
            }
        }
        else
        {
            Console.WriteLine("Glossary data tidak tersedia.");
        }
    }
}