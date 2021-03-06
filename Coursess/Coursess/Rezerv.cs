﻿using System;
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
    public partial class Rezerv : UserControl
    {
        Autorizacia aut = new Autorizacia();
        public Rezerv() //вкладка Добавления
        {
            InitializeComponent();

            dobPredm1.Visible = false; //предметы
            dobFak1.Visible = false; //отделения
            dobSpec1.Visible = false; //специальности
            dobType1.Visible = false; //тип
            indicatorRez.Visible = false; //индикатор выбранной вкладки
            group1.Visible = false; // группы

        }

        void Polozrez(object sender) //положение индикатора
        {
            indicatorRez.Visible = true;
            indicatorRez.Left = ((Control)sender).Left;
            indicatorRez.Width = ((Control)sender).Width;
        }

        public void Ref (Rezerv rezerv)
        {
            Invalidate();
        }

       
        private void ButtPredmAct_Click(object sender, EventArgs e)
        {
           Polozrez(sender);
            aut.rezerv1(dobPredm1); //вывод в датагрид
            dobPredm1.Visible = true;
            dobFak1.Visible = false;
            dobSpec1.Visible = false;
            dobType1.Visible = false;
            group1.Visible = false;

        }

        private void ButtFakAct_Click(object sender, EventArgs e)
        {
            Polozrez(sender);
            aut.rezerv0(dobFak1); //вывод в датагрид
            dobFak1.Visible = true;
            dobPredm1.Visible = false;
            dobSpec1.Visible = false;
            dobType1.Visible = false;
            group1.Visible = false;
        }

        private void ButtSpecAct_Click(object sender, EventArgs e)
        {
        Polozrez(sender);
            aut.visSpec(dobSpec1); //вывод в датагрид
            dobSpec1.Visible = true;
            dobFak1.Visible = false;
            dobPredm1.Visible = false;
            dobType1.Visible = false;
            group1.Visible = false;
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            Polozrez(sender);
            aut.TipZan(dobType1); //вывод в датагрид
            dobType1.Visible = true;
            dobSpec1.Visible = false;
            dobFak1.Visible = false;
            dobPredm1.Visible = false;
            group1.Visible = false;
        }

        private void ButtGroupAct_Click(object sender, EventArgs e)
        {
            Polozrez(sender);
            group1.Visible = true;
            DannieCombo dc = new DannieCombo();
            dc.dannieComboBoxGroups(group1);
        }

        private void Rezerv_Load(object sender, EventArgs e)
        {

        }
    }
}
