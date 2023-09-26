using CsvHelper.Configuration.Attributes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows.Forms.Design;

public class StockContext : DbContext
{
    public DbSet<StockFile> StockFiles { get; set; }    //Create database set for collection of stock files
    public DbSet<Stock> Stocks { get; set; }

    public string DbPath { get; }

    public StockContext()                               //Constructor for StockContext
    {
        var folder = Environment.SpecialFolder.LocalApplicationData;    //Get folder name for data
        var path = Environment.GetFolderPath(folder);                   //Get path to folder
        DbPath = System.IO.Path.Join(path, "Stocks.db");              //Update path variable to folder + name for database
    }

    // The following configures EF to create a Sqlite database file in the
    // special "local" folder for your platform.
    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite($"Data Source={DbPath}");
}

public class StockFile              //Information for each file
{
    public StockFile(string path, string filename, string ticker, string period) 
    {
        Path = path; Filename = filename; Ticker = ticker; Period = period;
        _id = Guid.NewGuid();
    }
    private Guid _id;    //Filename
    [Key]
    public Guid Guid { get; set; }
    //private string _filename;
    public string Path { get; set; }
    public string Filename { get ; set; }
    public string Ticker { get; set; }      //Name of stock
    public string Period { get; set; }      //Period of stock
    

    public List<Stock> Stocks { get; set; } = new();   //List of stocks

                                                                    //TODO: Implement construction of Stockfile to populate contents
}

public class Stock                                  //Stock class containing all information for stock
{
    //Ignore so that the csvReader does not try and use it as a column to read into
    [Ignore][Key] public Guid Id { get; set; }
    public DateTime Date { get; set; }                   //Date of stock (DateTime format)
    public string Ticker { get; set; }
    public string Period { get; set; }
    public double Open { get; set; }                     //Open value for stock (Dollars-Cents)
    public double High { get; set; }                     //High value for stock (Dollars-Cents)
    public double Low{ get; set; }                       //Low value for stock (Dollars-Cents)
    public double Close { get; set; }                    //Close value for stock (Dollars-Cents)
    //Needs to be 64-bit, numbers get too large for signed 32-bit
    public Int64 Volume { get; set; }                      //Volume value for stock (Int count)
    //public StockFile StockFile { get; set; }       //Parent class for stock collection
}