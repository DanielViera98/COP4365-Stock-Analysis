using System;
using System.IO;
using System.Collections;
using System.Reflection;
using System.Diagnostics;
using System.Net.NetworkInformation;
using CsvHelper;
using System.Globalization;
using CsvHelper.Configuration;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;

namespace COP4365
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Debug.WriteLine("TESTING");
            //Create Database
            InitDatabase();

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form_entry());

        }

        static void InitDatabase()
        {
            using var db = new StockContext();
            Debug.WriteLine($"Database path: {db.DbPath}.");

            // Create
            Debug.WriteLine("POPULATING STOCKFILES");
            //Use GetFiles("Directory") to get file names (returns string array)
            string mypath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);    //Get path to exe location
            if (mypath != null) {
                mypath += "\\Stock Data";
            }
            else
            {
                Debug.WriteLine("FAILED TO GET CURRENT DIRECTORY");
                return;
            }
            Debug.WriteLine($"PATH:  {mypath}");
            if (Directory.Exists(mypath))
            {
                //Get filenames, populated Stockcontext with stockfiles
                List<string> filenames = new List<string>(Directory.GetFiles(mypath));
                foreach (string path in filenames)
                {
                    Debug.WriteLine(path);
                    //Create a reader for the csv, read into records, place recores into file.
                    var reader = new StreamReader(path);
                    var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
                    var records = csv.GetRecords<Stock>();
                    foreach (var item in records)
                    {
                        item.StockFilePath = path;
                        db.Stocks.Add(item);
                    }
                }
                db.SaveChanges();                                       //Takes a lot of time, do once after finished rather than inside loop
                Debug.WriteLine("FINISHED POPULATING STOCKCONTEXT");
            }           
            else { Debug.WriteLine("DIRECTORY DOESN'T EXIST"); return; }
        }
    }
}