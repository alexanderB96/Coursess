﻿using System;
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
        }

        void Poloz(object sender) //положение индикатора
        {
            indicator.Top = ((Control)sender).Top;

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Home_Click(object sender, EventArgs e)
        {
            Poloz(sender);
        }

        private void Courses_Click(object sender, EventArgs e)
        {
            Poloz(sender);
        }

        private void Prepod_Click(object sender, EventArgs e)
        {
            Poloz(sender);
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            Poloz(sender);
        }

        /* private void bunifuFlatButton1_Click(object sender, EventArgs e)
         {

         }*/
    }
}
