﻿using System;
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
        //н * sql-запрос в файле
        string pfile = "FullInfo.txt";
        string pfileall = "FullInfoAll.txt";
        // к*
        public string sqltxt;
        



        public void Schit (Cours cours) //загрузка таблицы с открытми курсами (ИНФА ПО КУРСАМ)
    {
            try
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

            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
    }

        public void SchitAll(Cours cours) //загрузка таблицы со всеми курсами (ИНФА ПО КУРСАМ)
        {
            try
            {
                using (StreamReader sr = new StreamReader(pfileall)) 
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

            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void Prepod (Prepodav prepodav) //загрузка табл преподавателей
        {
            try
            {
                  cnn.Open();
                    zapros = (" SELECT CONCAT(Family, ' ', Name,' ' , Surname) AS [ФИО], Phone AS [Телефон], Stazh AS [Стаж] FROM Courses.dbo.Prepodavateli");
                    SqlDataAdapter da = new SqlDataAdapter(zapros, cnn);
                    SqlCommandBuilder cb = new SqlCommandBuilder(da);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "Prepodavateli");
                    prepodav.DataPrepodavatel.DataSource = ds.Tables[0];
                    cnn.Close();
                
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public void Groups(Group group) //табл группы
        {
            try
            {
                cnn.Open();
                zapros = (" SELECT  [id_nom_group] AS ID,  Specialnosti.Name_spec AS [Специальность] ,Otdelenie.Name_Otdela AS [Отдел] ,Groups.[Kolischestvo_Stydent] AS [Количество студентов] ,Groups.Nomer_Group AS [Номер группы]  ,Groups.[Open1]  FROM dbo.Groups INNER JOIN dbo.Specialnosti   ON Groups.Specialnost = Specialnosti.id_Speci INNER JOIN dbo.Otdelenie   ON Groups.Otdelenie = Otdelenie.id_Otdelenia");
                SqlDataAdapter da = new SqlDataAdapter(zapros, cnn);
                SqlCommandBuilder cb = new SqlCommandBuilder(da);
                DataSet ds = new DataSet();
                da.Fill(ds, "Groups");
                group.DataGroup.DataSource = ds.Tables[0];
                cnn.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void Aut(Form1 form) // проверка коннекта
        {

            try
            {
                cnn.Open();
                str = "Удачно!"; //зачем стр тут? ХЗ. Пусть будет
                form.ident.BackColor = Color.Transparent; 
                cnn.Close();
            }
            catch (Exception ex)
            {
                str = "Не Удачно!";
                form.ident.BackColor = Color.Red;
            }
        }



        public void danniy(Courses courses) //вывод информации во вкладку главное о курсах которые открыты
        {
            
            cnn.Open();
            zapros = ("SELECT Specialnosti.Name_spec AS Специальность ,Groups.[Kolischestvo_Stydent] AS [Количество Студентов] ,Groups.Nomer_Group AS [Номер Группы] ,Otdelenie.Name_Otdela AS Факультет FROM dbo.Groups INNER JOIN dbo.Otdelenie  ON Groups.Otdelenie = Otdelenie.id_Otdelenia INNER JOIN dbo.Specialnosti ON Groups.Specialnost = Specialnosti.id_Speci WHERE Groups.[Open1] = 1");
            SqlDataAdapter da = new SqlDataAdapter(zapros, cnn);
            SqlCommandBuilder cb = new SqlCommandBuilder(da);

            DataSet ds = new DataSet();
            da.Fill(ds, "Groups");
            courses.DataCourses.DataSource = ds.Tables[0];
            cnn.Close();
        }

        public void rezerv0(dobFak dobFak) // загрузка факультетов
        {

            cnn.Open();
            zapros = (" SELECT Name_Otdela AS[Факультет] FROM Courses.dbo.Otdelenie");
            SqlDataAdapter da = new SqlDataAdapter(zapros, cnn);
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            DataSet ds = new DataSet();
            da.Fill(ds, "Otdelenie");
            dobFak.DataOtdelenie.DataSource = ds.Tables[0];
            cnn.Close();

        }

        public void rezerv1(dobPredm dobPredm) // выгрузка таблица Предмет 
        {
            cnn.Open();
            zapros = (" SELECT Name_Predmeta AS [Предмет], Price AS [Цена] FROM Courses.dbo.Predmet");
            SqlDataAdapter da = new SqlDataAdapter(zapros, cnn);
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            DataSet ds = new DataSet();
            da.Fill(ds, "Predmet");
            dobPredm.DataPredmet.DataSource = ds.Tables[0];
            cnn.Close();
        }

        public void dobFakyltet(dobFak dobFak) //добавление факультета
        {
            cnn.Open();
            comand = cnn.CreateCommand();
            comand.CommandText = "INSERT INTO Otdelenie (Name_Otdela) VALUES  (@Name_Otdela)";
            comand.Parameters.AddWithValue("@Name_Otdela", Convert.ToString(dobFak.dobSpecialnosti.Text));
            comand.ExecuteNonQuery();
            cnn.Close();
            
           
        }

        public void dobPred(dobPredm dobPredm) //добавление препода
        {
            cnn.Open();
            comand = cnn.CreateCommand();
            comand.CommandText = "INSERT INTO Predmet (Name_Predmeta, Price) VALUES  (@Name_Predmeta,@Price)";
            comand.Parameters.AddWithValue("@Name_Predmeta", Convert.ToString(dobPredm.dobNamePred.Text));
            comand.Parameters.AddWithValue("@Price", Convert.ToString(dobPredm.dobPricePred.Text));
            comand.ExecuteNonQuery();
            cnn.Close();


        }

        public void visSpec(dobSpec dobSpec) // загрузка специальности
        {

            cnn.Open();
            zapros = (" SELECT Name_spec AS [Наименование специальности] FROM Courses.dbo.Specialnosti");
            SqlDataAdapter da = new SqlDataAdapter(zapros, cnn);
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            DataSet ds = new DataSet();
            da.Fill(ds, "Specialnosti");
            dobSpec.DataSpec.DataSource = ds.Tables[0];
            cnn.Close();

        }

        public void dobSpecial(dobSpec dobSpec) //добавление специальности
        {
            cnn.Open();
            comand = cnn.CreateCommand();
            comand.CommandText = "INSERT INTO Specialnosti (Name_spec) VALUES  (@Name_spec)";
            comand.Parameters.AddWithValue("@Name_spec", Convert.ToString(dobSpec.dobSpecialnost.Text));
            comand.ExecuteNonQuery();
            cnn.Close();


        }
        public void TipZan(dobType dobType) //выгрузка типа занятий
        {

            cnn.Open();
            zapros = ("SELECT Name_Type AS [Тип занятия] FROM Courses.dbo.TypeZanaytia");
            SqlDataAdapter da = new SqlDataAdapter(zapros, cnn);
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            DataSet ds = new DataSet();
            da.Fill(ds, "TypeZanaytia");
            dobType.DataType.DataSource = ds.Tables[0];
            cnn.Close();

        }

        public void dobTipZan(dobType dobType) //добавление занятий
        {
            cnn.Open();
            comand = cnn.CreateCommand();
            comand.CommandText = "INSERT INTO TypeZanaytia (Name_Type) VALUES  (@Name_Type)";
            comand.Parameters.AddWithValue("@Name_Type", Convert.ToString(dobType.dobTypeTxt.Text));
            comand.ExecuteNonQuery();
            cnn.Close();
        }

        public void DobPrepod(Prepodav prepodav) //добавление преподавателей
        {
            cnn.Open();
            comand = cnn.CreateCommand();
            comand.CommandText = "INSERT INTO Prepodavateli (Family, Name, Surname, Phone, Stazh) VALUES  (@Family, @Name, @Surname, @Phone, @Stazh)";
            comand.Parameters.AddWithValue("@Family", Convert.ToString(prepodav.dobPredFam.Text));
            comand.Parameters.AddWithValue("@Name", Convert.ToString(prepodav.dobPredName.Text));
            comand.Parameters.AddWithValue("@Surname", Convert.ToString(prepodav.dobPredSurN.Text));
            comand.Parameters.AddWithValue("@Phone", Convert.ToString(prepodav.dobNomerPrep.Text));
            comand.Parameters.AddWithValue("@Stazh", Convert.ToString(prepodav.dobStazhPrep.Text));
            comand.ExecuteNonQuery();
            cnn.Close();
        }

        public void DobGroup(Group group) //добавление групп
        {
           try
            {
                cnn.Open();
                comand = cnn.CreateCommand();
                comand.CommandText = "INSERT INTO Groups (Specialnost, Otdelenie, Kolischestvo_Stydent, Nomer_Group, Open1) VALUES  (@Specialnost, @Otdelenie, @Kolischestvo_Stydent, @Nomer_Group, @Open1)";
                comand.Parameters.AddWithValue("@Specialnost", Convert.ToInt32(group.ComboSpec.SelectedValue));
                comand.Parameters.AddWithValue("@Otdelenie", Convert.ToInt32(group.ComboOtdel.SelectedValue));
                comand.Parameters.AddWithValue("@Kolischestvo_Stydent", Convert.ToInt32(group.dobKolVoStuden.Text));
                comand.Parameters.AddWithValue("@Nomer_Group", Convert.ToString(group.dobNomerGroup.Text));
                comand.Parameters.AddWithValue("@Open1", Convert.ToString(group.opn));
                comand.ExecuteNonQuery();
                cnn.Close();
             }
             catch (Exception exx)
             {
                 MessageBox.Show(exx.ToString());
             }

             finally
             {
                 if (cnn != null)
                     cnn.Close();
             }

            Groups(group);
        }

        public void DeleteGroups(Group group) //класс удаления группы. в базе выбран режим связи "КАСКАд" для удаления связанных записей
        {
            DialogResult result = MessageBox.Show("Для удаления записи следует выбрать поле из колонки <ID>", "Информирование", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (result == DialogResult.OK)
            {
                try
                {
                    cnn.Open();
                    zapros = ("DELETE FROM [Groups] WHERE  id_nom_group = '" + group.id + "'");
                    SqlDataAdapter da = new SqlDataAdapter(zapros, cnn);
                    SqlCommandBuilder cb = new SqlCommandBuilder(da);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "Groups");
                    cnn.Close();

                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
                finally
                {
                    if (cnn != null)
                        cnn.Close();
                }

                
            }
            if (result == DialogResult.Cancel)
            {
                group.id = null;
            }

            Groups(group);
            group.bunifuFlatButton1.Visible = false;
        }

        public void UpdateGroups(Group group) // класс изминения статуса групы ОТКРЫТА/ЗАКРЫТА
        {
            DialogResult result = MessageBox.Show("Для обновления статуса группы следует выбрать поле из колонки <ID> . Не забудьте отметить галочкой нужный вариант!", "Информирование", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            if (result == DialogResult.OK)
            {
                try
                {
                    cnn.Open();
                    zapros = ("UPDATE dbo.Groups SET Open1 = '" + group.opn + "' WHERE id_nom_group = '" + group.id + "'");
                    SqlDataAdapter da = new SqlDataAdapter(zapros, cnn);
                    SqlCommandBuilder cb = new SqlCommandBuilder(da);
                    DataSet ds = new DataSet();
                    da.Fill(ds, "Groups");
                    cnn.Close();

                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }
                finally
                {
                    if (cnn != null)
                        cnn.Close();
                }


            }
            if (result == DialogResult.Cancel)
            {
                group.id = null;
            }

            Groups(group);
            group.bunifuFlatButton1.Visible = false;
            group.bunifuFlatButton2.Visible = false;
        }
    }
}
