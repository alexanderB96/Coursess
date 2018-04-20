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
        Autorizacia at = new Autorizacia();
        DannieCombo dc = new DannieCombo();
        Cours cs = new Cours();
        
        public Form1()
        {
            InitializeComponent();
            at.Aut(this);
            courses1.Visible = true;
            rezerv1.Visible = false;
            cours1.Visible = false;
            prepodav1.Visible = false;
            
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
            at.danniy(courses1);
            courses1.Visible = true;
            rezerv1.Visible = false;
            cours1.Visible = false;
            prepodav1.Visible = false;
        }

       
        private void Courses_Click(object sender, EventArgs e)
        {
            
            DannieCombo dn = new DannieCombo();
            Poloz(sender);
            dn.dannieComboBox(cours1);
            at.Schit(cours1);
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
             rezerv1.Visible = true;
            courses1.Visible = false;
            cours1.Visible = false;
            prepodav1.Visible = false;
        }

        
    }
}
