using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace WindowsFormsApp5
{
    public partial class DEAL4 : UserControl
    {
        
        public DEAL4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)

        {

            string dish = "DEAL 4";
            int balance = 1000;

            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string filePath = System.IO.Path.Combine(desktopPath, "OrderDetails.txt");

            string data = $"Dish: {dish}, Balance: {balance}";
            System.IO.File.AppendAllText(filePath, data + Environment.NewLine);  // ✅ append, not overwrite

            MessageBox.Show("ITEM ADDED TO CART");

        }
    }
}
