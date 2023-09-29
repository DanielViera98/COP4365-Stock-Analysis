using System.ComponentModel;
using System.Data;
using System.Diagnostics;

namespace COP4365
{
    public partial class Form_entry : Form
    {
        public Form_entry()
        {
            StockContext db = new StockContext();

            //When the form is closed, it will delete all entries in the database
            this.FormClosed += new FormClosedEventHandler(Form_entry_FormClosed);
            void Form_entry_FormClosed(object sender, FormClosedEventArgs e)
            {
                Debug.WriteLine("DELETE DB");

                foreach (var item in db.StockFiles)
                {
                    db.StockFiles.Remove(item);
                }
                db.SaveChanges();

            }

            InitializeComponent();

            //Get ticker and period info, set as datasource for comboboxs
            IList<string> tickers = db.StockFiles.Select(item => item.Ticker).Distinct().ToList();
            comboBox_ticker.DataSource = tickers;
            IList<string> periods = db.StockFiles.Select(item => item.Period).Distinct().ToList();
            comboBox_period.DataSource = periods;

        }

        //Class containing the distinct items for display via bindingLists.
        public class File_Dates                 //Doesn't work without this extra step of removal
        {
            public int item { get; set; }
            public File_Dates(int _item)
            {
                item = _item;
            }
        }

        private void button_UpdateDates_Click(object sender, EventArgs e)
        {
            StockContext db = new StockContext();
            Debug.WriteLine("INDEX CHANGE" + comboBox_ticker.Text + " " + comboBox_period.Text);
            //grab the selected file determined by the ticker and period box
            StockFile file = db.StockFiles
                .Where(f => (f.Ticker == comboBox_ticker.Text) && (f.Period == comboBox_period.Text))
                .FirstOrDefault();
            Debug.WriteLine("FILE INFO: " + comboBox_ticker.Text + " " + comboBox_period.Text);
            if (file != null)
            {
                //Grab the stocks which match the file id
                var stocks = db.Stocks
                    .Where(stock => stock.StockFileGuid == file.Guid)
                    .ToList();

                Debug.WriteLine(file.Filename);

                //Get the dates in the file, put them into classes, and bind to a bindinglist for display
                List<DateTime> times = stocks.Select(s => s.Date).Distinct().ToList();
                BindingList<File_Dates> Years = new BindingList<File_Dates>();
                List<int> y = new List<int>(times.Select(s => s.Date.Year).Distinct().ToList()); y.Sort();
                foreach (var item in y)
                {
                    File_Dates file_Dates = new File_Dates(item);
                    Years.Add(file_Dates);
                }
                BindingList<File_Dates> Months = new BindingList<File_Dates>();
                List<int> m = new List<int>(times.Select(s => s.Date.Month).Distinct().ToList()); m.Sort();
                foreach (var item in m)
                {
                    File_Dates file_Dates = new File_Dates(item);
                    Months.Add(file_Dates);
                }
                BindingList<File_Dates> Days = new BindingList<File_Dates>();
                List<int> d = new List<int>(times.Select(s => s.Date.Day).Distinct().ToList()); d.Sort();
                foreach (var item in d)
                {
                    File_Dates file_Dates = new File_Dates(item);
                    Days.Add(file_Dates);
                }

                //Add BindingLists as datasources for comboboxes.BindingContexts necessary, without it objects pointing to the
                //same bindingList change in sync
                #region Bind_Date_ComboBoxes
                comboBox_EndYear.DataSource = Years;
                comboBox_EndYear.DisplayMember = "item";
                comboBox_EndYear.ValueMember = "item";
                comboBox_EndMonth.BindingContext = new BindingContext();
                comboBox_EndMonth.DataSource = Months;
                comboBox_EndMonth.DisplayMember = "item";
                comboBox_EndMonth.ValueMember = "item";
                comboBox_EndDay.BindingContext = new BindingContext();
                comboBox_EndDay.DataSource = Days;
                comboBox_EndDay.DisplayMember = "item";
                comboBox_EndDay.ValueMember = "item";

                comboBox_StartYear.BindingContext = new BindingContext();
                comboBox_StartYear.DataSource = Years;
                comboBox_StartYear.DisplayMember = "item";
                comboBox_StartYear.ValueMember = "item";
                comboBox_StartMonth.BindingContext = new BindingContext();
                comboBox_StartMonth.DataSource = Months;
                comboBox_StartMonth.DisplayMember = "item";
                comboBox_StartMonth.ValueMember = "item";
                comboBox_StartDay.BindingContext = new BindingContext();
                comboBox_StartDay.DataSource = Days;
                comboBox_StartDay.DisplayMember = "item";
                comboBox_StartDay.ValueMember = "item";
                #endregion


            }
            else
                MessageBox.Show("ERROR RETRIEVING TIMES");
        }
    }
}