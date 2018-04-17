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
    public partial class dobSpec : UserControl
    {
        Autorizacia aut = new Autorizacia();
        public dobSpec()
        {
            InitializeComponent();
        }

        private void buttDobPred_Click(object sender, EventArgs e)
        {
            aut.dobSpecial(this);
            aut.visSpec(this);
            dobSpecialnost.Text = "название специальности ...";
        }

        private void dobSpecialnost_MouseClick(object sender, MouseEventArgs e)
        {
            dobSpecialnost.Text = "";
        }
    }
}
