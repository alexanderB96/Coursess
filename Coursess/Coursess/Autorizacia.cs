using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Drawing;

namespace Coursess
{
    class Autorizacia
    {
        Form1 form;
        public string str = null;
        public SqlConnection cnn = new SqlConnection(@"Data Source=АЛЕКСАНДР-ПК; Initial Catalog = Courses; Integrated Security=SSPI;");
        public SqlCommand comand;


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
    }
}
