using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class cart : UserControl
    {
        
        List<Order> orders = new List<Order>();

        public cart()
        {
            InitializeComponent();
          
        }

        

        private void burgeR11_Load(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0 && dataGridView1.SelectedRows[0].Index >= 0)
            {
                int index = dataGridView1.SelectedRows[0].Index;

                if (index >= 0 && index < orders.Count)
                {
                    orders.RemoveAt(index);

                    // Rewrite file
                    string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                    string filePath = Path.Combine(desktopPath, "OrderDetails.txt");

                    List<string> lines = new List<string>();
                    foreach (var order in orders)
                    {
                        lines.Add($"Dish: {order.Dish}, Balance: {order.Balance}");
                    }
                    File.WriteAllLines(filePath, lines);

                    LoadCartData(); // Refresh grid
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }




        private void cart_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void CalculateTotalBill()
        {
            int total = 0;

            foreach (Order order in orders)
            {
                total += order.Balance;
            }

            labelTotal.Text = "Total: " + total.ToString();
        }

        public void LoadCartData()
        {
            orders.Clear(); // clear old data

            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string filePath = Path.Combine(desktopPath, "OrderDetails.txt");

            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);

                foreach (string line in lines)
                {
                    string[] parts = line.Split(',');

                    if (parts.Length == 2)
                    {
                        string dish = parts[0].Replace("Dish:", "").Trim();
                        string balanceStr = parts[1].Replace("Balance:", "").Trim();

                        if (int.TryParse(balanceStr, out int balance))
                        {
                            orders.Add(new Order { Dish = dish, Balance = balance });
                        }
                    }
                }

                dataGridView1.DataSource = null; // refresh DataGridView
                dataGridView1.DataSource = orders;
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridView1.MultiSelect = false;
                CalculateTotalBill();
            }
            else
            {
                MessageBox.Show("No order file found.");
            }
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
