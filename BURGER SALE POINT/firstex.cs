﻿using System;
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
    public partial class firstex1 : UserControl
    {
       
        public firstex1()
        {
            InitializeComponent();
   
        }
        

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void firstex1_Load(object sender, EventArgs e)
        {

        }

       public void button1_Click(object sender, EventArgs e)
        {
            string dish = "DEAL 5";
            int balance = 500;

            

            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string filePath = System.IO.Path.Combine(desktopPath, "OrderDetails.txt");

            string data = $"Dish: {dish}, Balance: {balance}";
            System.IO.File.AppendAllText(filePath, data + Environment.NewLine);  // ✅ append, not overwrite

            MessageBox.Show("ITEM ADDED TO CART");
        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}