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
    }
}
