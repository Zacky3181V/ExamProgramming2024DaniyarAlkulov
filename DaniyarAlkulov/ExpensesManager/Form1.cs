using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ExpensesManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pathBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void readButton_Click(object sender, EventArgs e)
        {
            resultBox.Text = "";
            try
            {
                var path = pathBox.Text;
                var content = File.ReadAllLines(path);
                for (var i = 1; i < content.Length; i++)
                {
                    var line = content[i];
                    var lineCont = line.Split('|');
                    resultBox.Text += string.Join("\t", lineCont);
                    resultBox.Text += $"{Environment.NewLine}";
                }
            }
            catch(Exception ex)
            {
                resultBox.Text=ex.Message;
            }
            
        }
        public class Category
        {
            public string name;
            public List<string>? date;
            public decimal total;
            public int count;

            public Category(string name)
            {
                this.name = name;
                this.date = new List<string>();
                this.total = 0;
            }
        }

        
        private void statsButton_Click(object sender, EventArgs e)
        {
            resultBox.Text = "";
            var culture = CultureInfo.InvariantCulture;

            var path = pathBox.Text;
            var content = File.ReadAllLines(path);
            decimal amount = 0;

            var dates = new Dictionary<DateTime, int>();
            var categories = new Dictionary<string, int>();
            var list = new List<Category>();
            for (int i = 1; i < content.Length; i++)
            {
                var line = content[i];
                var split = line.Split("|");
                var date = DateTime.Parse(split[0], culture);
                var dateForModel = DateTime.Parse(split[0], culture).ToString("MMMM");
                var price = decimal.Parse(split[1], culture);
                amount += price;
                var category = split[2];

                //list.Add(new Category(category));

                if (dates.ContainsKey(date))
                {
                    dates[date] += 1;
                }
                else
                {
                    dates[date] = 1;
                }

                if (categories.ContainsKey(category))
                {
                    categories[category] += 1;
                }
                else
                {
                    categories[category] = 1;
                    list.Add(new Category(category));
                }

                foreach (Category item in list)
                {
                    if (item.name == category)
                    {
                        item.total += price;
                        if (!item.date.Contains(dateForModel))
                        {
                            item.date.Add(dateForModel);
                        }
                        
                        item.count += 1;
                    }

                }

            }
            resultBox.Text += $"Total expences: {amount}{Environment.NewLine}" +
                $"Number of categories: {categories.Count}{Environment.NewLine}" +
                $"Total dates of payment: {dates.Count}{Environment.NewLine}";
            foreach (var item in list)
            {
                resultBox.Text += $"{item.name} - bought {item.count} {(item.count>1?"times":"time")} in total. Purchases in: {string.Join(", ", item.date)}. Total expense: {item.total}{Environment.NewLine} ";
            }
        }
        

        private void resultBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
