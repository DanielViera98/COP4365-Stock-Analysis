using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COP4365
{
    public partial class Form_entry : Form
    {
        public Form_entry()
        {
            InitializeComponent();
            //Get ticker and period info, set as datasource for comboboxs
            StockContext db = new StockContext();
            IList<string> tickers = db.StockFiles.Select(item => item.Ticker).Distinct().ToList();
            comboBox_ticker.DataSource = tickers;
            IList<string> periods = db.StockFiles.Select(item => item.Period).Distinct().ToList();
            comboBox_period.DataSource = periods;

        }

    }
}