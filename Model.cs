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

public class Stock                             //Stock class containing all information for stock
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
    [Ignore] public string StockFilePath { get; set; }
}