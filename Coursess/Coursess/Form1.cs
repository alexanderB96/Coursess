using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coursess
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Autorizacia at = new Autorizacia();
                at.Aut(this);
           courses1.Visible = true;
            rezerv1.Visible = false;
            cours1.Visible = false;
            prepodav1.Visible = false;
            
            // Home_Click(null, null);
        }

        void Poloz(object sender) //положение индикатора
        {
            indicator.Top = ((Control)sender).Top;
            indicator.Height = ((Control)sender).Height;

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Home_Click(object sender, EventArgs e)
        {
            Poloz(sender);
            courses1.Visible = true;
            rezerv1.Visible = false;
            cours1.Visible = false;
            prepodav1.Visible = false;
        }

        private void Courses_Click(object sender, EventArgs e)
        {
            Poloz(sender);
            courses1.Visible = false;
            rezerv1.Visible = false;
            cours1.Visible = true;
            prepodav1.Visible = false;

        }

        private void Prepod_Click(object sender, EventArgs e)
        {
            Poloz(sender);
           
            courses1.Visible = false;
            rezerv1.Visible = false;
            cours1.Visible = false;
            prepodav1.Visible = true;


        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            Poloz(sender);
            // rezerv1.Refresh(); // не работает
          //  UserControl rezerv1 = new UserControl();
            rezerv1.Visible = true;
            courses1.Visible = false;
            cours1.Visible = false;
            prepodav1.Visible = false;



        }

        /* private void bunifuFlatButton1_Click(object sender, EventArgs e)
         {

         }*/
    }
}
