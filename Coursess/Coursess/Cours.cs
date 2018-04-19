using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Coursess
{
    public partial class Cours : UserControl
    {
        Autorizacia aut = new Autorizacia();
        DannieCombo dc = new DannieCombo();
        string txtgrup;
        string txtpredm;
        string txtprep;
        string txttype;


        public Cours()
        {
            InitializeComponent();
            aut.Schit(this);
            dc.dannieComboBox(this);
           

        }

        private void Cours_Load(object sender, EventArgs e)
        {

        }

        public void SwitchAll_OnValueChange(object sender, EventArgs e)
        {
            dc.dannieComboBox(this);
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

        public void up (Form1 form)
            {
            dc.dannieComboBox(this);
            }


        private void ComboPredmet_MouseClick(object sender, MouseEventArgs e)
        {
           
        }

        private void ComboPredmet_TextChanged(object sender, EventArgs e)
        {
            //txtpredm = Convert.ToString(ComboPredmet.Text);
            //txtgrup = Convert.ToString(ComboNomerGroup.Text);
            txtprep = Convert.ToString(ComboPrepod.Text);
            txttype = Convert.ToString(ComboType.Text);
            aut.cnn.Open();
            aut.comand = aut.cnn.CreateCommand();
            aut.comand.CommandText = ("SELECT id_Predmeta FROM Courses.dbo.Predmet WHERE Name_Predmeta = '" + ComboPredmet.Text + "' ");
            using (SqlDataReader reader = aut.comand.ExecuteReader())
            {
                if (reader.Read())
                {
                    txtpredm = null;
                    txtpredm = reader["id_Predmeta"].ToString();
                }

            }
            aut.cnn.Close();
            
        }

        public void Poluschenie()
        {
            
        }

        private void GetToID_TextChanged(object sender, EventArgs e)
        {

            txtgrup = Convert.ToString(ComboNomerGroup.SelectedValue);
            txtpredm = Convert.ToString(ComboPredmet.SelectedValue);
            txtprep = Convert.ToString(ComboPrepod.SelectedValue);
            txttype = Convert.ToString(ComboType.SelectedValue);
               
            
        }

        

        private void buttDobCours_Click(object sender, EventArgs e)
        {
            try
            {
                aut.cnn.Open();
                aut.comand = aut.cnn.CreateCommand();
                aut.comand.CommandText = "INSERT INTO Nagruzka (Nomer_group, id_Predmet, id_Type_zan,kod_Prepodavatelya) VALUES  (@Nomer_group, @id_Predmet, @id_Type_zan, @kod_Prepodavatelya)";
                aut.comand.Parameters.AddWithValue("@Nomer_group", txtgrup);
                aut.comand.Parameters.AddWithValue("@id_Predmet", txtpredm);
                aut.comand.Parameters.AddWithValue("@id_Type_zan", txttype);
                aut.comand.Parameters.AddWithValue("@kod_Prepodavatelya", txtprep);
                aut.comand.ExecuteNonQuery();
                aut.cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


        }
    }
}
