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
            //Testing DB
            using var db = new StockContext();
            #region ADDED_CODE
            // Note: This sample requires the database to be created before running.

            Debug.WriteLine($"Database path: {db.DbPath}.");

            // Create
            Debug.WriteLine("POPULATING STOCKFILES");
            //Use GetFiles("Directory") to get file names (returns string array)                //TODO//
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
                string[] filenames = Directory.GetFiles(mypath);
                foreach (string path in filenames)
                {
                    //Get name of file from path, then cut off the file extension
                    string name = path.Split("\\Stock Data\\").Last();
                    name = name.Substring(0,name.IndexOf("."));

                    //Create new stockFile and fill out attributes
                    string[] items = name.Split('-');
                    StockFile file = new(path, name, items[0], items[1]) {};

                    //Create a reader for the csv, read into records, place recodes into file.
                    var reader = new StreamReader(file.Path);
                    var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
                    var records = csv.GetRecords<Stock>();
                    foreach (var item in records)
                    {
                        file.Stocks.Add(item);
                    }

                    //Add file to database
                    db.Add(file);
                    db.SaveChanges();
                    
                    //Debug info
                    //Debug.WriteLine($"File: {file.Filename}");
                }
                Debug.WriteLine("FINISHED POPULATING STOCKCONTEXT");
                
                
            }
            
            else { Debug.WriteLine("DIRECTORY DOESN'T EXIST"); return; }

            #endregion
            
        }
    }
}