namespace Coursess
{
    partial class dobFak
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
            this.dobSpecialnosti = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.ButtDobFak = new Bunifu.Framework.UI.BunifuFlatButton();
            this.DataOtdelenie = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DataOtdelenie)).BeginInit();
            this.SuspendLayout();
            // 
            // dobSpecialnosti
            // 
            this.dobSpecialnosti.BorderColor = System.Drawing.Color.SeaGreen;
            this.dobSpecialnosti.Location = new System.Drawing.Point(3, 226);
            this.dobSpecialnosti.Name = "dobSpecialnosti";
            this.dobSpecialnosti.Size = new System.Drawing.Size(191, 20);
            this.dobSpecialnosti.TabIndex = 6;
            this.dobSpecialnosti.Text = "название факультета ...";
            this.dobSpecialnosti.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dobSpecialnosti.MouseClick += new System.Windows.Forms.MouseEventHandler(this.bunifuCustomTextbox1_MouseClick);
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
            this.ButtDobFak.Location = new System.Drawing.Point(355, 208);
            this.ButtDobFak.Name = "ButtDobFak";
            this.ButtDobFak.Normalcolor = System.Drawing.Color.Transparent;
            this.ButtDobFak.OnHovercolor = System.Drawing.Color.Transparent;
            this.ButtDobFak.OnHoverTextColor = System.Drawing.Color.Gray;
            this.ButtDobFak.selected = false;
            this.ButtDobFak.Size = new System.Drawing.Size(197, 48);
            this.ButtDobFak.TabIndex = 5;
            this.ButtDobFak.Text = "Добавить факультет";
            this.ButtDobFak.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ButtDobFak.Textcolor = System.Drawing.Color.DimGray;
            this.ButtDobFak.TextFont = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtDobFak.Click += new System.EventHandler(this.ButtDobFak_Click);
            // 
            // DataOtdelenie
            // 
            this.DataOtdelenie.AllowUserToAddRows = false;
            this.DataOtdelenie.AllowUserToDeleteRows = false;
            this.DataOtdelenie.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DataOtdelenie.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataOtdelenie.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.DataOtdelenie.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataOtdelenie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataOtdelenie.Location = new System.Drawing.Point(0, 0);
            this.DataOtdelenie.Name = "DataOtdelenie";
            this.DataOtdelenie.ReadOnly = true;
            this.DataOtdelenie.RowHeadersVisible = false;
            this.DataOtdelenie.Size = new System.Drawing.Size(565, 202);
            this.DataOtdelenie.TabIndex = 4;
            // 
            // dobFak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.dobSpecialnosti);
            this.Controls.Add(this.ButtDobFak);
            this.Controls.Add(this.DataOtdelenie);
            this.Name = "dobFak";
            this.Size = new System.Drawing.Size(565, 310);
            ((System.ComponentModel.ISupportInitialize)(this.DataOtdelenie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public WindowsFormsControlLibrary1.BunifuCustomTextbox dobSpecialnosti;
        public Bunifu.Framework.UI.BunifuFlatButton ButtDobFak;
        public System.Windows.Forms.DataGridView DataOtdelenie;
    }
}
