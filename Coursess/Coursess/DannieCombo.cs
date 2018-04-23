using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coursess
{
    //класс заполнения имеющихся комбобоксов в программе
    class DannieCombo
    {
         Autorizacia aut = new Autorizacia();

        public DataTable GetGrops() //загружает таблицу группы
        {
            DataTable table = new DataTable();
            string query = ("SELECT * FROM Courses.dbo.Groups");

            try
            {
                aut.cnn.Open();
                SqlTransaction transaction = aut.cnn.BeginTransaction();
                SqlCommand command = new SqlCommand(query, aut.cnn, transaction);
                DataSet dataSet = new DataSet();
                table = dataSet.Tables.Add("Groups");
                dataSet.Load(command.ExecuteReader(), LoadOption.OverwriteChanges, table);
                transaction.Commit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                if (aut.cnn != null)
                    aut.cnn.Close();
            }

            return table;
        }

        public DataTable GetPredmet() //загружает таблицу предметы
        {
            DataTable table = new DataTable();
            string query = ("SELECT * FROM Courses.dbo.Predmet");

            try
            {
                aut.cnn.Open();
                SqlTransaction transaction = aut.cnn.BeginTransaction();
                SqlCommand command = new SqlCommand(query, aut.cnn, transaction);
                DataSet dataSet = new DataSet();
                table = dataSet.Tables.Add("Predmet");
                dataSet.Load(command.ExecuteReader(), LoadOption.OverwriteChanges, table);
                transaction.Commit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                if (aut.cnn != null)
                    aut.cnn.Close();
            }
            return table;

        }

        public DataTable GetPrepod() // загружает таблицу преподавателей
        {
            DataTable table = new DataTable();
            string query = ("SELECT *, CONCAT(Family, ' ', Name, ' ', Surname) AS FIO FROM Courses.dbo.Prepodavateli ");

            try
            {
                aut.cnn.Open();
                SqlTransaction transaction = aut.cnn.BeginTransaction();
                SqlCommand command = new SqlCommand(query, aut.cnn, transaction);
                DataSet dataSet = new DataSet();
                table = dataSet.Tables.Add("Prepodavateli");
                dataSet.Load(command.ExecuteReader(), LoadOption.OverwriteChanges, table);
                transaction.Commit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                if (aut.cnn != null)
                    aut.cnn.Close();
            }

            return table;

        }

        public DataTable GetTypeZan() // загружает таблицу с типом занятий
        {
            DataTable table = new DataTable();
            string query = ("SELECT*  FROM Courses.dbo.TypeZanaytia");

            try
            {
                aut.cnn.Open();
                SqlTransaction transaction = aut.cnn.BeginTransaction();
                SqlCommand command = new SqlCommand(query, aut.cnn, transaction);
                DataSet dataSet = new DataSet();
                table = dataSet.Tables.Add("TypeZanaytia");
                dataSet.Load(command.ExecuteReader(), LoadOption.OverwriteChanges, table);
                transaction.Commit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                if (aut.cnn != null)
                    aut.cnn.Close();
            }

            return table;

        }

        public void dannieComboBox(Cours cours) //отвечает за заполнение комбобоксов
        {
            cours.ComboNomerGroup.DataSource = GetGrops();
            cours.ComboNomerGroup.DisplayMember = "Nomer_Group"; //отображаем столбец
            cours.ComboNomerGroup.ValueMember = "id_nom_group"; //тут обрабатываем ID выбранной строки. т.е. берем ид выбранной группы

            cours.ComboPredmet.DataSource = GetPredmet();
            cours.ComboPredmet.DisplayMember = "Name_Predmeta"; // всё что ниже аналогично
            cours.ComboPredmet.ValueMember = "id_Predmeta";

            cours.ComboPrepod.DataSource = GetPrepod();
            cours.ComboPrepod.DisplayMember = "FIO";
            cours.ComboPrepod.ValueMember = "id_prepod";

            cours.ComboType.DataSource = GetTypeZan();
            cours.ComboType.DisplayMember = "Name_Type";
            cours.ComboType.ValueMember = "id_type";
        
        }

        public DataTable GetSpecial() //хагружаем таблицу специальностей
        {
            DataTable table = new DataTable();
            string query = ("SELECT * FROM Courses.dbo.Specialnosti");

            try
            {
                aut.cnn.Open();
                SqlTransaction transaction = aut.cnn.BeginTransaction();
                SqlCommand command = new SqlCommand(query, aut.cnn, transaction);
                DataSet dataSet = new DataSet();
                table = dataSet.Tables.Add("Specialnosti");
                dataSet.Load(command.ExecuteReader(), LoadOption.OverwriteChanges, table);
                transaction.Commit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                if (aut.cnn != null)
                    aut.cnn.Close();
            }

            return table;

        }

        public DataTable GetOtdelenei() //загружаем факультеты
        {
            DataTable table = new DataTable();
            string query = ("SELECT * FROM Courses.dbo.Otdelenie");

            try
            {
                aut.cnn.Open();
                SqlTransaction transaction = aut.cnn.BeginTransaction();
                SqlCommand command = new SqlCommand(query, aut.cnn, transaction);
                DataSet dataSet = new DataSet();
                table = dataSet.Tables.Add("Otdelenie");
                dataSet.Load(command.ExecuteReader(), LoadOption.OverwriteChanges, table);
                transaction.Commit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                if (aut.cnn != null)
                    aut.cnn.Close();
            }

            return table;

        }

        public void dannieComboBoxGroups(Group group)
        {
            group.ComboOtdel.DataSource = GetOtdelenei();
            group.ComboOtdel.DisplayMember = "Name_Otdela"; //собственно тот же принцип что и выше
            group.ComboOtdel.ValueMember = "id_Otdelenia";

            group.ComboSpec.DataSource = GetSpecial();
            group.ComboSpec.DisplayMember = "Name_spec";
            group.ComboSpec.ValueMember = "id_Speci";


        }


    }
}
