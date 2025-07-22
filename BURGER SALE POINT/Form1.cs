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

    
    public partial class Form1 : Form
    {

      
        int currentPanelIndex = 0;
        Control[] panels;
        int current = 0;
        Control[] p;
       
        



        public Form1()
        {
            InitializeComponent();
            sidepanel.Height = button1.Height;
            sidepanel.Top = button1.Top;
            firstex1.BringToFront();
            button1_Click(this, EventArgs.Empty);
            panels = new Control[] { firstex1,firstex2,firstex3};
            panels[0].BringToFront();
            label2.Hide();
            button7.Hide();
            button8.Hide();
            DRINKS1.Hide();
            label4.Hide();
            label3.Hide();
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string filePath = Path.Combine(desktopPath, "OrderDetails.txt");

            File.WriteAllText(filePath, string.Empty); // Clears old data



        }
       


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            sidepanel.Height = button1.Height;
            sidepanel.Top = button1.Top;

            firstex1.BringToFront();
            label1.Visible = true;
            label1.BringToFront();

            button6.Visible = true;
            button6.BringToFront();
            firstex1.Visible = true;
            firstex2.Visible = true;
            firstex3.Visible = true;
            firstex1.BringToFront();
            firstex2.BringToFront();
            firstex3.BringToFront();
            button7.Hide ();
            label2.Hide();
            label3.Hide ();
            button8.Hide();
            button9.Hide();
           
            BURGER1.Hide();
            BURGER2.Hide();
            DEAL4.Hide();
            DRINKS1.Hide();
            label4.Hide();




        }

        private void button3_Click(object sender, EventArgs e)
        {
            sidepanel.Height = button3.Height;
            sidepanel.Top = button3.Top;
            button6.Hide();
            label1.Hide();
            label3.Hide();
            label2.Visible = true;
            label2.BringToFront ();
            button7.Visible = true;
            button7.BringToFront();
            BURGER1.Visible = true;
            BURGER1.BringToFront();
            button8.Hide();
            button6.Hide();
            button9.Hide();
            firstex1.Hide();
            firstex2.Hide();
            firstex3.Hide();
            DEAL4.Hide();
            DRINKS1.Hide();
            label4.Hide();





        }

        private void button2_Click(object sender, EventArgs e)
        {
            sidepanel.Height = button2.Height;
            sidepanel.Top = button2.Top;
            label3.Visible=true;
            label3.BringToFront();
            
            DRINKS1.Visible = true;
            DRINKS1.BringToFront();


            button7.Hide();
            button6.Hide();
            button9.Hide();
            button8.Hide();
            label4.Hide();





        }

        private void button4_Click(object sender, EventArgs e)
        {
            sidepanel.Height = button4.Height;
            sidepanel.Top = button4.Top;
            
            label2.Hide();
            label3.Hide();
             BURGER1.Hide();
            BURGER2.Hide();
            button6.Hide();
            button7.Hide();
            button8.Hide ();

            button9.Visible = true;
            firstex1.Visible = true;
            DEAL4.Visible = true;
            label1.Visible = true;
            label1.BringToFront ();
            firstex1.Visible = true;
            firstex2.Visible = true;
            firstex3.Visible = true;

            p = new Control[] { firstex1, firstex2, firstex3,DEAL4};
            panels[0].BringToFront();

            label4.Hide();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            sidepanel.Height = button5.Height;
            sidepanel.Top = button5.Top;
            button8.Hide();
            label3.Hide();
            cart1.BringToFront();
            cart1.LoadCartData(); 
            button6.Hide();
            button7.Hide();
            button8.Hide();
            button9.Hide();
            label1.Hide();
            label2.Hide();
            label3.Hide();
            label4.Visible = true;
            label4.BringToFront();



        }

        private void firstex11_Load(object sender, EventArgs e)
        {

        }

        private void firstex11_Load_1(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            currentPanelIndex++;


            if (currentPanelIndex >= panels.Length)
            {
                currentPanelIndex = 0;
            }

            panels[currentPanelIndex].BringToFront();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            button6.Hide();
            label1.Hide();
            button7.Hide();
            button8.Visible = true;
            button8.BringToFront();
            BURGER2.Visible = true;
            BURGER2.BringToFront();
            label4.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
           button3_Click(sender, e);
           
        }

        private void button9_Click(object sender, EventArgs e)
        {
            current++;


            if (current >= p.Length)
            {
                current = 0;
            }

            p[current].BringToFront();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

        
       

