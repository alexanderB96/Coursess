namespace Coursess
{
    partial class Group
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
            this.DataGroup = new System.Windows.Forms.DataGridView();
            this.ComboSpec = new System.Windows.Forms.ComboBox();
            this.ComboOtdel = new System.Windows.Forms.ComboBox();
            this.CheckOpen = new Bunifu.Framework.UI.BunifuCheckbox();
            this.labCheck = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.dobNomerGroup = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.dobKolVoStuden = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.buttDobPred = new Bunifu.Framework.UI.BunifuFlatButton();
            this.lbid = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.DataGroup)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGroup
            // 
            this.DataGroup.AllowUserToAddRows = false;
            this.DataGroup.AllowUserToDeleteRows = false;
            this.DataGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGroup.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGroup.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.DataGroup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGroup.Location = new System.Drawing.Point(0, 0);
            this.DataGroup.Name = "DataGroup";
            this.DataGroup.ReadOnly = true;
            this.DataGroup.RowHeadersVisible = false;
            this.DataGroup.Size = new System.Drawing.Size(565, 202);
            this.DataGroup.TabIndex = 3;
            this.DataGroup.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGroup_CellClick);
            // 
            // ComboSpec
            // 
            this.ComboSpec.FormattingEnabled = true;
            this.ComboSpec.Location = new System.Drawing.Point(3, 217);
            this.ComboSpec.Name = "ComboSpec";
            this.ComboSpec.Size = new System.Drawing.Size(137, 21);
            this.ComboSpec.TabIndex = 7;
            // 
            // ComboOtdel
            // 
            this.ComboOtdel.FormattingEnabled = true;
            this.ComboOtdel.Location = new System.Drawing.Point(146, 217);
            this.ComboOtdel.Name = "ComboOtdel";
            this.ComboOtdel.Size = new System.Drawing.Size(137, 21);
            this.ComboOtdel.TabIndex = 8;
            // 
            // CheckOpen
            // 
            this.CheckOpen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.CheckOpen.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.CheckOpen.Checked = true;
            this.CheckOpen.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(205)))), ((int)(((byte)(117)))));
            this.CheckOpen.ForeColor = System.Drawing.Color.White;
            this.CheckOpen.Location = new System.Drawing.Point(534, 218);
            this.CheckOpen.Name = "CheckOpen";
            this.CheckOpen.Size = new System.Drawing.Size(20, 20);
            this.CheckOpen.TabIndex = 9;
            this.CheckOpen.OnChange += new System.EventHandler(this.CheckOpen_OnChange);
            // 
            // labCheck
            // 
            this.labCheck.AutoSize = true;
            this.labCheck.Location = new System.Drawing.Point(519, 205);
            this.labCheck.Name = "labCheck";
            this.labCheck.Size = new System.Drawing.Size(51, 13);
            this.labCheck.TabIndex = 10;
            this.labCheck.Text = "Открыть";
            // 
            // dobNomerGroup
            // 
            this.dobNomerGroup.BorderColor = System.Drawing.Color.SeaGreen;
            this.dobNomerGroup.Location = new System.Drawing.Point(408, 218);
            this.dobNomerGroup.Name = "dobNomerGroup";
            this.dobNomerGroup.Size = new System.Drawing.Size(115, 20);
            this.dobNomerGroup.TabIndex = 17;
            this.dobNomerGroup.Text = "номер группы ...";
            this.dobNomerGroup.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dobNomerGroup.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dobNomerGroup_MouseClick);
            // 
            // dobKolVoStuden
            // 
            this.dobKolVoStuden.BorderColor = System.Drawing.Color.SeaGreen;
            this.dobKolVoStuden.Location = new System.Drawing.Point(289, 217);
            this.dobKolVoStuden.Name = "dobKolVoStuden";
            this.dobKolVoStuden.Size = new System.Drawing.Size(115, 20);
            this.dobKolVoStuden.TabIndex = 16;
            this.dobKolVoStuden.Text = "кол-во студентов ...";
            this.dobKolVoStuden.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dobKolVoStuden.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dobKolVoStuden_MouseClick);
            // 
            // buttDobPred
            // 
            this.buttDobPred.Activecolor = System.Drawing.Color.Transparent;
            this.buttDobPred.BackColor = System.Drawing.Color.Transparent;
            this.buttDobPred.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttDobPred.BorderRadius = 0;
            this.buttDobPred.ButtonText = "Добавить группу";
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
            this.buttDobPred.Location = new System.Drawing.Point(175, 259);
            this.buttDobPred.Name = "buttDobPred";
            this.buttDobPred.Normalcolor = System.Drawing.Color.Transparent;
            this.buttDobPred.OnHovercolor = System.Drawing.Color.Transparent;
            this.buttDobPred.OnHoverTextColor = System.Drawing.Color.Gray;
            this.buttDobPred.selected = false;
            this.buttDobPred.Size = new System.Drawing.Size(248, 48);
            this.buttDobPred.TabIndex = 15;
            this.buttDobPred.Text = "Добавить группу";
            this.buttDobPred.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttDobPred.Textcolor = System.Drawing.Color.DimGray;
            this.buttDobPred.TextFont = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttDobPred.Click += new System.EventHandler(this.buttDobPred_Click);
            // 
            // lbid
            // 
            this.lbid.AutoSize = true;
            this.lbid.Location = new System.Drawing.Point(3, 241);
            this.lbid.Name = "lbid";
            this.lbid.Size = new System.Drawing.Size(13, 13);
            this.lbid.TabIndex = 18;
            this.lbid.Text = "1";
            this.lbid.Visible = false;
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Удалить выбранную группу ";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = null;
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(477, 259);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(88, 48);
            this.bunifuFlatButton1.TabIndex = 19;
            this.bunifuFlatButton1.Text = "Удалить выбранную группу ";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.DimGray;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Segoe UI", 8.25F);
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.ButtonText = "Открыть/Закрыть";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = null;
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 0;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = true;
            this.bunifuFlatButton2.IconRightZoom = 0D;
            this.bunifuFlatButton2.IconVisible = true;
            this.bunifuFlatButton2.IconZoom = 90D;
            this.bunifuFlatButton2.IsTab = false;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(0, 262);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(116, 48);
            this.bunifuFlatButton2.TabIndex = 20;
            this.bunifuFlatButton2.Text = "Открыть/Закрыть";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.DimGray;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Segoe UI", 8.25F);
            this.bunifuFlatButton2.Click += new System.EventHandler(this.bunifuFlatButton2_Click);
            // 
            // Group
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.bunifuFlatButton2);
            this.Controls.Add(this.bunifuFlatButton1);
            this.Controls.Add(this.lbid);
            this.Controls.Add(this.dobNomerGroup);
            this.Controls.Add(this.dobKolVoStuden);
            this.Controls.Add(this.buttDobPred);
            this.Controls.Add(this.labCheck);
            this.Controls.Add(this.CheckOpen);
            this.Controls.Add(this.ComboOtdel);
            this.Controls.Add(this.ComboSpec);
            this.Controls.Add(this.DataGroup);
            this.Name = "Group";
            this.Size = new System.Drawing.Size(565, 310);
            this.Load += new System.EventHandler(this.Group_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGroup)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView DataGroup;
        public System.Windows.Forms.ComboBox ComboSpec;
        public System.Windows.Forms.ComboBox ComboOtdel;
        private Bunifu.Framework.UI.BunifuCustomLabel labCheck;
        public Bunifu.Framework.UI.BunifuCheckbox CheckOpen;
        public WindowsFormsControlLibrary1.BunifuCustomTextbox dobNomerGroup;
        public WindowsFormsControlLibrary1.BunifuCustomTextbox dobKolVoStuden;
        public Bunifu.Framework.UI.BunifuFlatButton buttDobPred;
        public Bunifu.Framework.UI.BunifuCustomLabel lbid;
        public Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        public Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
    }
}
