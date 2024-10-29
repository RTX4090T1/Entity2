// See https://aka.ms/new-console-template for more information
using Entity2;
using Entity2.Migrations;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using static Entity2.EBJCONTEXT1;
List<Sport> sportres = new List<Sport>()
{
    new Sport{NameSurname = "S1",SportType = "Football",Result = 5,Medal = "Gold"},
    new Sport{NameSurname = "S2",SportType = "Football",Result = 5,Medal = "None"},
    new Sport{NameSurname = "S3",SportType = "Tenis",Result = 5,Medal = "Bronze"},
    new Sport{NameSurname = "S4",SportType = "Tenis",Result = 5,Medal = "None"},
    new Sport{NameSurname = "S5",SportType = "Tenis",Result = 5,Medal = "Gold"},
    new Sport{NameSurname = "S6",SportType = "Football",Result = 5,Medal = "Silver"},
    new Sport{NameSurname = "S7",SportType = "Biatlon",Result = 5,Medal = "Gold"},
};
    
void GetInfo()
{
    using (var context = new EbjContext())
    {
        context.SportResults.AddRange(sportres);
        context.SaveChanges();
        var stList = context.SportResults.ToList();
        ShowInfo(stList);
        string path = "C://Users//default.LAPTOP-3FE6LNKR//source//repos//Entity2//Entity2//SportData.xml";
        AddDataFRomDbToXmlFile(path, stList);
    }
}
void GetinfoByInput(string sportType)
{
    using(var spotrList = new EbjContext())
    {
        var filtererdByMedal = spotrList.SportResults.Where(s=>s.Medal != "None");
        var filteredbySport = filtererdByMedal.Where(s => s.SportType == sportType).ToList();
        ShowInfo(filteredbySport);
    }
}
void ShowInfo(List<Sport> sportman)
{
    foreach (var s in sportman)
    {
        Console.WriteLine(s.NameSurname);
        Console.WriteLine(s.SportType);
        Console.WriteLine(s.Medal);
        Console.WriteLine(s.Result);
    }
}
void AddDataFRomDbToXmlFile(string path,List<Sport> sportData)
{
    XmlSerializer serToXmFile = new XmlSerializer(typeof(List<Sport>));
    using (FileStream fs = new FileStream(path, FileMode.Append))
    {
        serToXmFile.Serialize(fs, sportData);
    }
}
Console.WriteLine("Enter 1 to get SportInfo from db, 2 to get sportmans who earned medal in some sport:  :");
int inp = Convert.ToInt32(Console.ReadLine());
switch (inp)
{
    case 1:
        {
            GetInfo(); break;
        }
        case 2:
        {
            Console.WriteLine("Enter sport Type:");
            string input = Console.ReadLine();
            GetinfoByInput(input);
            Console.WriteLine("Successfully saved tu xml File");
            break;
        }
    default:
        {
            Console.WriteLine("Incorrect operation!");
            break;
        }
}
