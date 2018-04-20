namespace Coursess
{
    partial class Prepodav
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.DataPrepodavatel = new System.Windows.Forms.DataGridView();
            this.dobPredSurN = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.dobPredFam = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.buttDobPred = new Bunifu.Framework.UI.BunifuFlatButton();
            this.dobPredName = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.dobNomerPrep = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.dobStazhPrep = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.DataPrepodavatel)).BeginInit();
            this.SuspendLayout();
            // 
            // DataPrepodavatel
            // 
            this.DataPrepodavatel.AllowUserToAddRows = false;
            this.DataPrepodavatel.AllowUserToDeleteRows = false;
            this.DataPrepodavatel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataPrepodavatel.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.DataPrepodavatel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataPrepodavatel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataPrepodavatel.Dock = System.Windows.Forms.DockStyle.Top;
            this.DataPrepodavatel.Location = new System.Drawing.Point(0, 0);
            this.DataPrepodavatel.Name = "DataPrepodavatel";
            this.DataPrepodavatel.ReadOnly = true;
            this.DataPrepodavatel.RowHeadersVisible = false;
            this.DataPrepodavatel.Size = new System.Drawing.Size(565, 317);
            this.DataPrepodavatel.TabIndex = 1;
            // 
            // dobPredSurN
            // 
            this.dobPredSurN.BorderColor = System.Drawing.Color.SeaGreen;
            this.dobPredSurN.Location = new System.Drawing.Point(263, 323);
            this.dobPredSurN.Name = "dobPredSurN";
            this.dobPredSurN.Size = new System.Drawing.Size(115, 20);
            this.dobPredSurN.TabIndex = 12;
            this.dobPredSurN.Text = "введите отчество ...";
            this.dobPredSurN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dobPredSurN.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dobPredSurN_MouseClick);
            // 
            // dobPredFam
            // 
            this.dobPredFam.BorderColor = System.Drawing.Color.SeaGreen;
            this.dobPredFam.Location = new System.Drawing.Point(4, 323);
            this.dobPredFam.Name = "dobPredFam";
            this.dobPredFam.Size = new System.Drawing.Size(122, 20);
            this.dobPredFam.TabIndex = 11;
            this.dobPredFam.Text = "введите фамилию  ...";
            this.dobPredFam.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dobPredFam.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dobPredFam_MouseClick);
            // 
            // buttDobPred
            // 
            this.buttDobPred.Activecolor = System.Drawing.Color.Transparent;
            this.buttDobPred.BackColor = System.Drawing.Color.Transparent;
            this.buttDobPred.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttDobPred.BorderRadius = 0;
            this.buttDobPred.ButtonText = "Добавить преподавателя";
            this.buttDobPred.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttDobPred.DisabledColor = System.Drawing.Color.Gray;
            this.buttDobPred.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.buttDobPred.Iconcolor = System.Drawing.Color.Transparent;
            this.buttDobPred.Iconimage = null;
            this.buttDobPred.Iconimage_right = null;
            this.buttDobPred.Iconimage_right_Selected = null;
            this.buttDobPred.Iconimage_Selected = null;
            this.buttDobPred.IconMarginLeft = 0;
            this.buttDobPred.IconMarginRight = 0;
            this.buttDobPred.IconRightVisible = true;
            this.buttDobPred.IconRightZoom = 0D;
            this.buttDobPred.IconVisible = true;
            this.buttDobPred.IconZoom = 90D;
            this.buttDobPred.IsTab = false;
            this.buttDobPred.Location = new System.Drawing.Point(153, 349);
            this.buttDobPred.Name = "buttDobPred";
            this.buttDobPred.Normalcolor = System.Drawing.Color.Transparent;
            this.buttDobPred.OnHovercolor = System.Drawing.Color.Transparent;
            this.buttDobPred.OnHoverTextColor = System.Drawing.Color.Gray;
            this.buttDobPred.selected = false;
            this.buttDobPred.Size = new System.Drawing.Size(248, 48);
            this.buttDobPred.TabIndex = 10;
            this.buttDobPred.Text = "Добавить преподавателя";
            this.buttDobPred.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttDobPred.Textcolor = System.Drawing.Color.DimGray;
            this.buttDobPred.TextFont = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttDobPred.Click += new System.EventHandler(this.buttDobPred_Click);
            // 
            // dobPredName
            // 
            this.dobPredName.BorderColor = System.Drawing.Color.SeaGreen;
            this.dobPredName.Location = new System.Drawing.Point(139, 323);
            this.dobPredName.Name = "dobPredName";
            this.dobPredName.Size = new System.Drawing.Size(113, 20);
            this.dobPredName.TabIndex = 13;
            this.dobPredName.Text = "введите имя ...";
            this.dobPredName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dobPredName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dobPredName_MouseClick);
            // 
            // dobNomerPrep
            // 
            this.dobNomerPrep.BorderColor = System.Drawing.Color.SeaGreen;
            this.dobNomerPrep.Location = new System.Drawing.Point(392, 323);
            this.dobNomerPrep.Name = "dobNomerPrep";
            this.dobNomerPrep.Size = new System.Drawing.Size(115, 20);
            this.dobNomerPrep.TabIndex = 14;
            this.dobNomerPrep.Text = "номер телефона ...";
            this.dobNomerPrep.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dobNomerPrep.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dobNomerPrep_MouseClick);
            // 
            // dobStazhPrep
            // 
            this.dobStazhPrep.BorderColor = System.Drawing.Color.SeaGreen;
            this.dobStazhPrep.Location = new System.Drawing.Point(517, 323);
            this.dobStazhPrep.Name = "dobStazhPrep";
            this.dobStazhPrep.Size = new System.Drawing.Size(46, 20);
            this.dobStazhPrep.TabIndex = 15;
            this.dobStazhPrep.Text = "стаж ...";
            this.dobStazhPrep.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dobStazhPrep.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dobStazhPrep_MouseClick);
            // 
            // Prepodav
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.dobStazhPrep);
            this.Controls.Add(this.dobNomerPrep);
            this.Controls.Add(this.dobPredName);
            this.Controls.Add(this.dobPredSurN);
            this.Controls.Add(this.dobPredFam);
            this.Controls.Add(this.buttDobPred);
            this.Controls.Add(this.DataPrepodavatel);
            this.Name = "Prepodav";
            this.Size = new System.Drawing.Size(565, 400);
            this.Load += new System.EventHandler(this.Prepodav_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataPrepodavatel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView DataPrepodavatel;
        public WindowsFormsControlLibrary1.BunifuCustomTextbox dobPredSurN;
        public WindowsFormsControlLibrary1.BunifuCustomTextbox dobPredFam;
        public Bunifu.Framework.UI.BunifuFlatButton buttDobPred;
        public WindowsFormsControlLibrary1.BunifuCustomTextbox dobPredName;
        public WindowsFormsControlLibrary1.BunifuCustomTextbox dobNomerPrep;
        public WindowsFormsControlLibrary1.BunifuCustomTextbox dobStazhPrep;
    }
}
