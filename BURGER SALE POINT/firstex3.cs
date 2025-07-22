using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class firstex3 : UserControl
    {
        public firstex3()
        {
            InitializeComponent();
        }

        private void firstex3_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string dish = "DEAL 8";
            int balance = 500;


            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string filePath = System.IO.Path.Combine(desktopPath, "OrderDetails.txt");

            string data = $"Dish: {dish}, Balance: {balance}";
            System.IO.File.AppendAllText(filePath, data + Environment.NewLine);  // ✅ append, not overwrite

            MessageBox.Show("ITEM ADDED TO CART");

        }
    }
}
