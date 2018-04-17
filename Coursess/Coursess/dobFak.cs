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
    public partial class dobFak : UserControl
    {
        Autorizacia aut = new Autorizacia();
        public dobFak()
        {
            InitializeComponent();
        }

        private void bunifuCustomTextbox1_MouseClick(object sender, MouseEventArgs e)
        {
            dobSpecialnosti.Text = "";
        }

        private void ButtDobFak_Click(object sender, EventArgs e)
        {
            aut.dobFakyltet(this);
            aut.rezerv0(this);
            dobSpecialnosti.Text = "название факультета ...";
        }
    }
}
