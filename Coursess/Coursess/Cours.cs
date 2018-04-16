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
    public partial class Cours : UserControl
    {
        Autorizacia aut = new Autorizacia();
        public Cours()
        {
            InitializeComponent();
            aut.Schit(this);
        }

        private void Cours_Load(object sender, EventArgs e)
        {

        }
    }
}
