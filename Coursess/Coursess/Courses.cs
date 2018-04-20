using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bunifu.Framework.UI;

namespace Coursess
{
    public partial class Courses : UserControl
    {
        public Courses()
        {
            InitializeComponent();
            Autorizacia dn = new Autorizacia();
            dn.danniy(this);
        }

        private void bunifuGradientPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
