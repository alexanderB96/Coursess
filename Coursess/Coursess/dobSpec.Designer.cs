namespace Coursess
{
    partial class dobSpec
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
            this.DataSpec = new System.Windows.Forms.DataGridView();
            this.dobSpecialnost = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.buttDobPred = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.DataSpec)).BeginInit();
            this.SuspendLayout();
            // 
            // DataSpec
            // 
            this.DataSpec.AllowUserToAddRows = false;
            this.DataSpec.AllowUserToDeleteRows = false;
            this.DataSpec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DataSpec.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataSpec.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.DataSpec.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataSpec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataSpec.Location = new System.Drawing.Point(0, 0);
            this.DataSpec.Name = "DataSpec";
            this.DataSpec.ReadOnly = true;
            this.DataSpec.RowHeadersVisible = false;
            this.DataSpec.Size = new System.Drawing.Size(565, 255);
            this.DataSpec.TabIndex = 5;
            // 
            // dobSpecialnost
            // 
            this.dobSpecialnost.BorderColor = System.Drawing.Color.SeaGreen;
            this.dobSpecialnost.Location = new System.Drawing.Point(3, 277);
            this.dobSpecialnost.Name = "dobSpecialnost";
            this.dobSpecialnost.Size = new System.Drawing.Size(191, 20);
            this.dobSpecialnost.TabIndex = 10;
            this.dobSpecialnost.Text = "название специальности ...";
            this.dobSpecialnost.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dobSpecialnost.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dobSpecialnost_MouseClick);
            // 
            // buttDobPred
            // 
            this.buttDobPred.Activecolor = System.Drawing.Color.Transparent;
            this.buttDobPred.BackColor = System.Drawing.Color.Transparent;
            this.buttDobPred.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttDobPred.BorderRadius = 0;
            this.buttDobPred.ButtonText = "Добавить специальность";
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
            this.buttDobPred.Location = new System.Drawing.Point(297, 261);
            this.buttDobPred.Name = "buttDobPred";
            this.buttDobPred.Normalcolor = System.Drawing.Color.Transparent;
            this.buttDobPred.OnHovercolor = System.Drawing.Color.Transparent;
            this.buttDobPred.OnHoverTextColor = System.Drawing.Color.Gray;
            this.buttDobPred.selected = false;
            this.buttDobPred.Size = new System.Drawing.Size(244, 48);
            this.buttDobPred.TabIndex = 9;
            this.buttDobPred.Text = "Добавить специальность";
            this.buttDobPred.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttDobPred.Textcolor = System.Drawing.Color.DimGray;
            this.buttDobPred.TextFont = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttDobPred.Click += new System.EventHandler(this.buttDobPred_Click);
            // 
            // dobSpec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.dobSpecialnost);
            this.Controls.Add(this.buttDobPred);
            this.Controls.Add(this.DataSpec);
            this.Name = "dobSpec";
            this.Size = new System.Drawing.Size(565, 310);
            ((System.ComponentModel.ISupportInitialize)(this.DataSpec)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView DataSpec;
        public WindowsFormsControlLibrary1.BunifuCustomTextbox dobSpecialnost;
        public Bunifu.Framework.UI.BunifuFlatButton buttDobPred;
    }
}
