using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Drawing;
using Bunifu.Framework.UI;
using System.IO;

namespace Coursess
{
    class Autorizacia
    {
        Form1 form;
        Cours cours;
        Rezerv rezerv;

        public string str = null;
        public SqlConnection cnn = new SqlConnection(@"Data Source=АЛЕКСАНДР-ПК; Initial Catalog = Courses; Integrated Security=SSPI;");
        public SqlCommand comand;
        public string zapros;
        string pfile = "FullInfo.txt";
        public string sqltxt;

        

        public void Schit (Cours cours)
    {
           
                using (StreamReader sr = new StreamReader(pfile))
                {
                    sqltxt = sr.ReadToEnd();
                    cnn.Open();
                     SqlDataAdapter da = new SqlDataAdapter(sqltxt, cnn);
                    SqlCommandBuilder cb = new SqlCommandBuilder(da);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "Nagruzka");
                    cours.DataFull.DataSource = ds.Tables[0];
                    cnn.Close();


                }
            
    }

        public void Aut(Form1 form) // проверка коннекта
        {

            try
            {
                cnn.Open();
                str = "Удачно!";
                form.ident.BackColor = Color.Transparent; 
                cnn.Close();
            }
            catch (Exception ex)
            {
                str = "Не Удачно!";
                form.ident.BackColor = Color.Red;
            }
        }



        public void danniy(Courses courses)
        {
            
            cnn.Open();
            zapros = ("SELECT Specialnosti.Name_spec AS Специальность ,Groups.[Kolischestvo Stydent] AS [Количество Студентов] ,Groups.Nomer_Group AS [Номер Группы] ,Otdelenie.Name_Otdela AS Факультет FROM dbo.Groups INNER JOIN dbo.Otdelenie  ON Groups.Otdelenie = Otdelenie.id_Otdelenia INNER JOIN dbo.Specialnosti ON Groups.Specialnost = Specialnosti.id_Speci WHERE Groups.[Open] = 0");
            SqlDataAdapter da = new SqlDataAdapter(zapros, cnn);
            SqlCommandBuilder cb = new SqlCommandBuilder(da);

            DataSet ds = new DataSet();
            da.Fill(ds, "Groups");
            courses.DataCourses.DataSource = ds.Tables[0];
            cnn.Close();
        }

        public void rezerv0(Rezerv rezerv)
        {

            cnn.Open();
            zapros = (" SELECT Name_Otdela AS[Факультет] FROM Courses.dbo.Otdelenie");
            SqlDataAdapter da = new SqlDataAdapter(zapros, cnn);
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            DataSet ds = new DataSet();
            da.Fill(ds, "Otdelenie");
            rezerv.DataOtdelenie.DataSource = ds.Tables[0];
            cnn.Close();

        }

        public void rezerv1(Rezerv rezerv)
        {
            cnn.Open();
            zapros = (" SELECT Name_Predmeta AS [Предмет], Price AS [Цена] FROM Courses.dbo.Predmet");
            SqlDataAdapter da = new SqlDataAdapter(zapros, cnn);
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            DataSet ds = new DataSet();
            da.Fill(ds, "Predmet");
            rezerv.DataPredmet.DataSource = ds.Tables[0];
            cnn.Close();
        }

        public void dobFak(Rezerv rezerv)
        {
            cnn.Open();
            comand = cnn.CreateCommand();
            comand.CommandText = "INSERT INTO Otdelenie (Name_Otdela) VALUES  (@Name_Otdela)";
            comand.Parameters.AddWithValue("@Name_Otdela", Convert.ToString(rezerv.dobFak.Text));
            comand.ExecuteNonQuery();
            cnn.Close();
            
           
        }

        public void dobPred(Rezerv rezerv)
        {
            cnn.Open();
            comand = cnn.CreateCommand();
            comand.CommandText = "INSERT INTO Predmet (Name_Predmeta, Price) VALUES  (@Name_Predmeta,@Price)";
            comand.Parameters.AddWithValue("@Name_Predmeta", Convert.ToString(rezerv.dobNamePred.Text));
            comand.Parameters.AddWithValue("@Price", Convert.ToString(rezerv.dobPricePred.Text));
            comand.ExecuteNonQuery();
            cnn.Close();


        }
    }
}
