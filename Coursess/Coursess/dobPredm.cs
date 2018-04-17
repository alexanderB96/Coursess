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
    public partial class dobPredm : UserControl
    {
        Autorizacia aut = new Autorizacia();
        public dobPredm()
        {
            InitializeComponent();
        }

        private void dobNamePred_MouseClick(object sender, MouseEventArgs e)
        {
            dobNamePred.Text = "";
        }

        private void dobPricePred_MouseClick(object sender, MouseEventArgs e)
        {
            dobPricePred.Text = "";
        }

        private void buttDobPred_Click(object sender, EventArgs e)
        {
            aut.dobPred(this);
            aut.rezerv1(this);
            dobNamePred.Text = "название предмета ...";
            dobPricePred.Text = "стоимость предмета ...";
        }
    }
}
