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
    public partial class Group : UserControl
    {
        Autorizacia aut = new Autorizacia();
        string opn = Convert.ToString(1);
        public Group()
        {
            InitializeComponent();
            aut.Groups(this);
            

        }

        private void Group_Load(object sender, EventArgs e)
        {

        }

         

        private void CheckOpen_OnChange(object sender, EventArgs e)
        {
            opn = "";
            if (CheckOpen.Checked == false)
            {
                opn = Convert.ToString(0);
             }
            else
                opn = Convert.ToString(1);

            labCheck.Text = opn;

        }
    }
}
