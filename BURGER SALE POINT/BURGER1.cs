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
    public partial class BURGER1 : UserControl
    {
        public BURGER1()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string dish = "GRILLER";
            int balance = 350;

            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string filePath = System.IO.Path.Combine(desktopPath, "OrderDetails.txt");

            string data = $"Dish: {dish}, Balance: {balance}";
            System.IO.File.AppendAllText(filePath, data + Environment.NewLine);  // ✅ append, not overwrite

            MessageBox.Show("ITEM ADDED TO CART");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string dish = "ZINGER";
            int balance = 400;

            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string filePath = System.IO.Path.Combine(desktopPath, "OrderDetails.txt");

            string data = $"Dish: {dish}, Balance: {balance}";
            System.IO.File.AppendAllText(filePath, data + Environment.NewLine);  // ✅ append, not overwrite

            MessageBox.Show("ITEM ADDED TO CART");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string dish = "SHRADER";
            int balance = 450;

            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string filePath = System.IO.Path.Combine(desktopPath, "OrderDetails.txt");

            string data = $"Dish: {dish}, Balance: {balance}";
            System.IO.File.AppendAllText(filePath, data + Environment.NewLine);  // ✅ append, not overwrite

            MessageBox.Show("ITEM ADDED TO CART");

        }
    }
}
