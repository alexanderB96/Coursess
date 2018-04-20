namespace Coursess
{
    partial class Cours
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cours));
            this.DataFull = new System.Windows.Forms.DataGridView();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.SwitchAll = new Bunifu.Framework.UI.BunifuiOSSwitch();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.ComboNomerGroup = new System.Windows.Forms.ComboBox();
            this.ComboPredmet = new System.Windows.Forms.ComboBox();
            this.ComboPrepod = new System.Windows.Forms.ComboBox();
            this.ComboType = new System.Windows.Forms.ComboBox();
            this.buttDobCours = new Bunifu.Framework.UI.BunifuFlatButton();
            this.kolChasov = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.DataFull)).BeginInit();
            this.bunifuGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataFull
            // 
            this.DataFull.AllowUserToAddRows = false;
            this.DataFull.AllowUserToDeleteRows = false;
            this.DataFull.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DataFull.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataFull.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.DataFull.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataFull.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataFull.Location = new System.Drawing.Point(0, 28);
            this.DataFull.Name = "DataFull";
            this.DataFull.ReadOnly = true;
            this.DataFull.RowHeadersVisible = false;
            this.DataFull.Size = new System.Drawing.Size(565, 263);
            this.DataFull.TabIndex = 2;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.SwitchAll);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuCustomLabel2);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(565, 26);
            this.bunifuGradientPanel1.TabIndex = 3;
            // 
            // SwitchAll
            // 
            this.SwitchAll.BackColor = System.Drawing.Color.Transparent;
            this.SwitchAll.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SwitchAll.BackgroundImage")));
            this.SwitchAll.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SwitchAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SwitchAll.Location = new System.Drawing.Point(527, 2);
            this.SwitchAll.Name = "SwitchAll";
            this.SwitchAll.OffColor = System.Drawing.Color.Gray;
            this.SwitchAll.OnColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(202)))), ((int)(((byte)(94)))));
            this.SwitchAll.Size = new System.Drawing.Size(35, 20);
            this.SwitchAll.TabIndex = 4;
            this.SwitchAll.Value = false;
            this.SwitchAll.OnValueChange += new System.EventHandler(this.SwitchAll_OnValueChange);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(3, 0);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(358, 25);
            this.bunifuCustomLabel2.TabIndex = 3;
            this.bunifuCustomLabel2.Text = "Информация по всем открытым курсам";
            // 
            // ComboNomerGroup
            // 
            this.ComboNomerGroup.FormattingEnabled = true;
            this.ComboNomerGroup.Location = new System.Drawing.Point(69, 297);
            this.ComboNomerGroup.Name = "ComboNomerGroup";
            this.ComboNomerGroup.Size = new System.Drawing.Size(132, 21);
            this.ComboNomerGroup.TabIndex = 5;
            this.ComboNomerGroup.TextChanged += new System.EventHandler(this.GetToID_TextChanged);
            // 
            // ComboPredmet
            // 
            this.ComboPredmet.FormattingEnabled = true;
            this.ComboPredmet.Location = new System.Drawing.Point(217, 297);
            this.ComboPredmet.Name = "ComboPredmet";
            this.ComboPredmet.Size = new System.Drawing.Size(137, 21);
            this.ComboPredmet.TabIndex = 6;
            this.ComboPredmet.TextChanged += new System.EventHandler(this.GetToID_TextChanged);
            this.ComboPredmet.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ComboPredmet_MouseClick);
            // 
            // ComboPrepod
            // 
            this.ComboPrepod.FormattingEnabled = true;
            this.ComboPrepod.Location = new System.Drawing.Point(376, 297);
            this.ComboPrepod.Name = "ComboPrepod";
            this.ComboPrepod.Size = new System.Drawing.Size(150, 21);
            this.ComboPrepod.TabIndex = 7;
            this.ComboPrepod.TextChanged += new System.EventHandler(this.GetToID_TextChanged);
            // 
            // ComboType
            // 
            this.ComboType.FormattingEnabled = true;
            this.ComboType.Location = new System.Drawing.Point(147, 337);
            this.ComboType.Name = "ComboType";
            this.ComboType.Size = new System.Drawing.Size(112, 21);
            this.ComboType.TabIndex = 8;
            this.ComboType.TextChanged += new System.EventHandler(this.GetToID_TextChanged);
            // 
            // buttDobCours
            // 
            this.buttDobCours.Activecolor = System.Drawing.Color.Transparent;
            this.buttDobCours.BackColor = System.Drawing.Color.Transparent;
            this.buttDobCours.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttDobCours.BorderRadius = 0;
            this.buttDobCours.ButtonText = "Добавить ";
            this.buttDobCours.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttDobCours.DisabledColor = System.Drawing.Color.Gray;
            this.buttDobCours.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.buttDobCours.Iconcolor = System.Drawing.Color.Transparent;
            this.buttDobCours.Iconimage = null;
            this.buttDobCours.Iconimage_right = null;
            this.buttDobCours.Iconimage_right_Selected = null;
            this.buttDobCours.Iconimage_Selected = null;
            this.buttDobCours.IconMarginLeft = 0;
            this.buttDobCours.IconMarginRight = 0;
            this.buttDobCours.IconRightVisible = true;
            this.buttDobCours.IconRightZoom = 0D;
            this.buttDobCours.IconVisible = true;
            this.buttDobCours.IconZoom = 90D;
            this.buttDobCours.IsTab = false;
            this.buttDobCours.Location = new System.Drawing.Point(168, 352);
            this.buttDobCours.Name = "buttDobCours";
            this.buttDobCours.Normalcolor = System.Drawing.Color.Transparent;
            this.buttDobCours.OnHovercolor = System.Drawing.Color.Transparent;
            this.buttDobCours.OnHoverTextColor = System.Drawing.Color.Gray;
            this.buttDobCours.selected = false;
            this.buttDobCours.Size = new System.Drawing.Size(248, 48);
            this.buttDobCours.TabIndex = 11;
            this.buttDobCours.Text = "Добавить ";
            this.buttDobCours.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttDobCours.Textcolor = System.Drawing.Color.DimGray;
            this.buttDobCours.TextFont = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttDobCours.Click += new System.EventHandler(this.buttDobCours_Click);
            // 
            // kolChasov
            // 
            this.kolChasov.BorderColor = System.Drawing.Color.SeaGreen;
            this.kolChasov.Location = new System.Drawing.Point(310, 338);
            this.kolChasov.Name = "kolChasov";
            this.kolChasov.Size = new System.Drawing.Size(119, 20);
            this.kolChasov.TabIndex = 12;
            this.kolChasov.Text = "количество часов...";
            this.kolChasov.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.kolChasov.MouseClick += new System.Windows.Forms.MouseEventHandler(this.kolChasov_MouseClick);
            // 
            // Cours
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.kolChasov);
            this.Controls.Add(this.buttDobCours);
            this.Controls.Add(this.ComboType);
            this.Controls.Add(this.ComboPrepod);
            this.Controls.Add(this.ComboPredmet);
            this.Controls.Add(this.ComboNomerGroup);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Controls.Add(this.DataFull);
            this.Name = "Cours";
            this.Size = new System.Drawing.Size(565, 400);
            this.Load += new System.EventHandler(this.Cours_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataFull)).EndInit();
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView DataFull;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        public System.Windows.Forms.ComboBox ComboNomerGroup;
        public System.Windows.Forms.ComboBox ComboPredmet;
        public System.Windows.Forms.ComboBox ComboPrepod;
        public System.Windows.Forms.ComboBox ComboType;
        public Bunifu.Framework.UI.BunifuiOSSwitch SwitchAll;
        public Bunifu.Framework.UI.BunifuFlatButton buttDobCours;
        public WindowsFormsControlLibrary1.BunifuCustomTextbox kolChasov;
    }
}
