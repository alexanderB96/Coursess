namespace Coursess
{
    partial class Rezerv
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
            this.DataPredmet = new System.Windows.Forms.DataGridView();
            this.DataOtdelenie = new System.Windows.Forms.DataGridView();
            this.ButtDobFak = new Bunifu.Framework.UI.BunifuFlatButton();
            this.dobFak = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.dobNamePred = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.buttDobPred = new Bunifu.Framework.UI.BunifuFlatButton();
            this.dobPricePred = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.DataPredmet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataOtdelenie)).BeginInit();
            this.SuspendLayout();
            // 
            // DataPredmet
            // 
            this.DataPredmet.AllowUserToAddRows = false;
            this.DataPredmet.AllowUserToDeleteRows = false;
            this.DataPredmet.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.DataPredmet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataPredmet.Location = new System.Drawing.Point(3, 3);
            this.DataPredmet.Name = "DataPredmet";
            this.DataPredmet.ReadOnly = true;
            this.DataPredmet.RowHeadersVisible = false;
            this.DataPredmet.Size = new System.Drawing.Size(230, 150);
            this.DataPredmet.TabIndex = 0;
            // 
            // DataOtdelenie
            // 
            this.DataOtdelenie.AllowUserToAddRows = false;
            this.DataOtdelenie.AllowUserToDeleteRows = false;
            this.DataOtdelenie.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DataOtdelenie.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.DataOtdelenie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataOtdelenie.Location = new System.Drawing.Point(371, 3);
            this.DataOtdelenie.Name = "DataOtdelenie";
            this.DataOtdelenie.ReadOnly = true;
            this.DataOtdelenie.RowHeadersVisible = false;
            this.DataOtdelenie.Size = new System.Drawing.Size(191, 150);
            this.DataOtdelenie.TabIndex = 1;
            // 
            // ButtDobFak
            // 
            this.ButtDobFak.Activecolor = System.Drawing.Color.Transparent;
            this.ButtDobFak.BackColor = System.Drawing.Color.Transparent;
            this.ButtDobFak.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtDobFak.BorderRadius = 0;
            this.ButtDobFak.ButtonText = "Добавить факультет";
            this.ButtDobFak.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtDobFak.DisabledColor = System.Drawing.Color.Gray;
            this.ButtDobFak.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.ButtDobFak.Iconcolor = System.Drawing.Color.Transparent;
            this.ButtDobFak.Iconimage = null;
            this.ButtDobFak.Iconimage_right = null;
            this.ButtDobFak.Iconimage_right_Selected = null;
            this.ButtDobFak.Iconimage_Selected = null;
            this.ButtDobFak.IconMarginLeft = 0;
            this.ButtDobFak.IconMarginRight = 0;
            this.ButtDobFak.IconRightVisible = true;
            this.ButtDobFak.IconRightZoom = 0D;
            this.ButtDobFak.IconVisible = true;
            this.ButtDobFak.IconZoom = 90D;
            this.ButtDobFak.IsTab = false;
            this.ButtDobFak.Location = new System.Drawing.Point(365, 211);
            this.ButtDobFak.Name = "ButtDobFak";
            this.ButtDobFak.Normalcolor = System.Drawing.Color.Transparent;
            this.ButtDobFak.OnHovercolor = System.Drawing.Color.Transparent;
            this.ButtDobFak.OnHoverTextColor = System.Drawing.Color.Gray;
            this.ButtDobFak.selected = false;
            this.ButtDobFak.Size = new System.Drawing.Size(197, 48);
            this.ButtDobFak.TabIndex = 2;
            this.ButtDobFak.Text = "Добавить факультет";
            this.ButtDobFak.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ButtDobFak.Textcolor = System.Drawing.Color.DimGray;
            this.ButtDobFak.TextFont = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtDobFak.Click += new System.EventHandler(this.ButtDobFak_Click);
            // 
            // dobFak
            // 
            this.dobFak.BorderColor = System.Drawing.Color.SeaGreen;
            this.dobFak.Location = new System.Drawing.Point(371, 171);
            this.dobFak.Name = "dobFak";
            this.dobFak.Size = new System.Drawing.Size(191, 20);
            this.dobFak.TabIndex = 3;
            this.dobFak.Text = "название факультета ...";
            this.dobFak.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dobFak.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dobFak_MouseClick);
            // 
            // dobNamePred
            // 
            this.dobNamePred.BorderColor = System.Drawing.Color.SeaGreen;
            this.dobNamePred.Location = new System.Drawing.Point(30, 159);
            this.dobNamePred.Name = "dobNamePred";
            this.dobNamePred.Size = new System.Drawing.Size(191, 20);
            this.dobNamePred.TabIndex = 5;
            this.dobNamePred.Text = "название предмета ...";
            this.dobNamePred.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dobNamePred.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dobNamePred_MouseClick);
            // 
            // buttDobPred
            // 
            this.buttDobPred.Activecolor = System.Drawing.Color.Transparent;
            this.buttDobPred.BackColor = System.Drawing.Color.Transparent;
            this.buttDobPred.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttDobPred.BorderRadius = 0;
            this.buttDobPred.ButtonText = "Добавить предмет";
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
            this.buttDobPred.Location = new System.Drawing.Point(24, 211);
            this.buttDobPred.Name = "buttDobPred";
            this.buttDobPred.Normalcolor = System.Drawing.Color.Transparent;
            this.buttDobPred.OnHovercolor = System.Drawing.Color.Transparent;
            this.buttDobPred.OnHoverTextColor = System.Drawing.Color.Gray;
            this.buttDobPred.selected = false;
            this.buttDobPred.Size = new System.Drawing.Size(197, 48);
            this.buttDobPred.TabIndex = 4;
            this.buttDobPred.Text = "Добавить предмет";
            this.buttDobPred.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttDobPred.Textcolor = System.Drawing.Color.DimGray;
            this.buttDobPred.TextFont = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttDobPred.Click += new System.EventHandler(this.buttDobPred_Click);
            // 
            // dobPricePred
            // 
            this.dobPricePred.BorderColor = System.Drawing.Color.SeaGreen;
            this.dobPricePred.Location = new System.Drawing.Point(30, 185);
            this.dobPricePred.Name = "dobPricePred";
            this.dobPricePred.Size = new System.Drawing.Size(191, 20);
            this.dobPricePred.TabIndex = 6;
            this.dobPricePred.Text = "стоимсть предмета ...";
            this.dobPricePred.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dobPricePred.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dobPricePred_MouseClick);
            // 
            // Rezerv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.dobPricePred);
            this.Controls.Add(this.dobNamePred);
            this.Controls.Add(this.buttDobPred);
            this.Controls.Add(this.dobFak);
            this.Controls.Add(this.ButtDobFak);
            this.Controls.Add(this.DataOtdelenie);
            this.Controls.Add(this.DataPredmet);
            this.Name = "Rezerv";
            this.Size = new System.Drawing.Size(565, 400);
            ((System.ComponentModel.ISupportInitialize)(this.DataPredmet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataOtdelenie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView DataPredmet;
        public System.Windows.Forms.DataGridView DataOtdelenie;
        public Bunifu.Framework.UI.BunifuFlatButton ButtDobFak;
        public WindowsFormsControlLibrary1.BunifuCustomTextbox dobFak;
        public WindowsFormsControlLibrary1.BunifuCustomTextbox dobNamePred;
        public Bunifu.Framework.UI.BunifuFlatButton buttDobPred;
        public WindowsFormsControlLibrary1.BunifuCustomTextbox dobPricePred;
    }
}
