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

        private void SwitchAll_OnValueChange(object sender, EventArgs e)
        {
            if (SwitchAll.Value == false)
            {
                bunifuCustomLabel2.Text = "Информация по всем открытым курсам";
                aut.Schit(this);
            }
            else if (SwitchAll.Value == true)
            {
                aut.SchitAll(this);
                bunifuCustomLabel2.Text = "Информация по всем курсам";
            }
        }
    }
}
