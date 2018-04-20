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
        public string opn = Convert.ToString(1);  //изначально группа создаётся сразу открытой
        public string id = null;

        public Group()
        {
            InitializeComponent();
            aut.Groups(this);

            bunifuFlatButton1.Visible = false;
            bunifuFlatButton2.Visible = false;



        }

        private void Group_Load(object sender, EventArgs e)
        {

        }

         

        private void CheckOpen_OnChange(object sender, EventArgs e) //если выбран вариант открытия ручками
        {
            opn = "";
            if (CheckOpen.Checked == false)
            {
                opn = Convert.ToString(0);
                lbid.Text = opn;
            }
            else
            {
                opn = Convert.ToString(1);
                lbid.Text = opn;
            }

        }

        private void dobKolVoStuden_MouseClick(object sender, MouseEventArgs e)
        {
            dobKolVoStuden.Text = "";
        }

        private void dobNomerGroup_MouseClick(object sender, MouseEventArgs e)
        {
            dobNomerGroup.Text = "";
        }

        private void buttDobPred_Click(object sender, EventArgs e)
        {
            aut.DobGroup(this);
        }

        private void DataGroup_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToString(DataGroup.SelectedCells[0].Value);
            lbid.Visible = true;
            //lbid.Text = "yuyuyuyuyuyuyuyuyuyuyu";
            lbid.Text = id;
            bunifuFlatButton1.Visible = true;
            bunifuFlatButton2.Visible = true;
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            aut.DeleteGroups(this);
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            aut.UpdateGroups(this);
        }
    }
}
