using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coursess
{
    public partial class Prepodav : UserControl
    {

        Autorizacia aut = new Autorizacia();
        public Prepodav()
        {
            InitializeComponent();
            aut.Prepod(this);
        }

        private void Prepodav_Load(object sender, EventArgs e)
        {

        }

        //начало

            // хрен знает как повесить один обработчик на очищение (возможно по тегу можно)
            // костыль
        private void dobPredFam_MouseClick(object sender, MouseEventArgs e)
        {
            dobPredFam.Text = "";
        }

        private void dobPredName_MouseClick(object sender, MouseEventArgs e)
        {
            dobPredName.Text = "";
        }

        private void dobPredSurN_MouseClick(object sender, MouseEventArgs e)
        {
            dobPredSurN.Text = "";
        }

        private void dobNomerPrep_MouseClick(object sender, MouseEventArgs e)
        {
            dobNomerPrep.Text = "";
        }

        private void dobStazhPrep_MouseClick(object sender, MouseEventArgs e)
        {
            dobStazhPrep.Text = "";
        }

        //конец

        private void buttDobPred_Click(object sender, EventArgs e)
        {
            aut.DobPrepod(this);
            aut.Prepod(this);
            dobPredFam.Text = "введите фамилию ...";
            dobStazhPrep.Text = "стаж ...";
            dobNomerPrep.Text = "номер телефона ...";
            dobPredSurN.Text = "введите отчество ...";
            dobPredName.Text = "введите имя ...";
            
        }
    }
}
