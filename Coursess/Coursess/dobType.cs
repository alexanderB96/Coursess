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
    public partial class dobType : UserControl
    {
        Autorizacia aut = new Autorizacia();
        public dobType()
        {
            InitializeComponent();
        }

        private void dobTypeTxt_MouseClick(object sender, MouseEventArgs e)
        {
            dobTypeTxt.Text = "";
        }

        private void buttDobType_Click(object sender, EventArgs e)
        {
            aut.dobTipZan(this);
            aut.TipZan(this);
            dobTypeTxt.Text = "тип занятия ...";

        }
    }
}
