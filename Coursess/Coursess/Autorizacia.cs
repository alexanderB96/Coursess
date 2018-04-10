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

namespace Coursess
{
    class Autorizacia
    {
        Form1 form;
        public string str = null;
        public SqlConnection cnn = new SqlConnection(@"Data Source=АЛЕКСАНДР-ПК; Initial Catalog = Courses; Integrated Security=SSPI;");
        public SqlCommand comand;
        public string zapros;


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
    }
}
