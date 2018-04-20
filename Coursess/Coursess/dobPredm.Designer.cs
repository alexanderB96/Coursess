namespace Coursess
{
    partial class dobPredm
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
            this.dobPricePred = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.dobNamePred = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.buttDobPred = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.DataPredmet)).BeginInit();
            this.SuspendLayout();
            // 
            // DataPredmet
            // 
            this.DataPredmet.AllowUserToAddRows = false;
            this.DataPredmet.AllowUserToDeleteRows = false;
            this.DataPredmet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataPredmet.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.DataPredmet.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataPredmet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataPredmet.Location = new System.Drawing.Point(3, 3);
            this.DataPredmet.Name = "DataPredmet";
            this.DataPredmet.ReadOnly = true;
            this.DataPredmet.RowHeadersVisible = false;
            this.DataPredmet.Size = new System.Drawing.Size(559, 235);
            this.DataPredmet.TabIndex = 1;
            // 
            // dobPricePred
            // 
            this.dobPricePred.BorderColor = System.Drawing.Color.SeaGreen;
            this.dobPricePred.Location = new System.Drawing.Point(300, 244);
            this.dobPricePred.Name = "dobPricePred";
            this.dobPricePred.Size = new System.Drawing.Size(191, 20);
            this.dobPricePred.TabIndex = 9;
            this.dobPricePred.Text = "стоимость предмета ...";
            this.dobPricePred.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dobPricePred.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dobPricePred_MouseClick);
            // 
            // dobNamePred
            // 
            this.dobNamePred.BorderColor = System.Drawing.Color.SeaGreen;
            this.dobNamePred.Location = new System.Drawing.Point(73, 244);
            this.dobNamePred.Name = "dobNamePred";
            this.dobNamePred.Size = new System.Drawing.Size(191, 20);
            this.dobNamePred.TabIndex = 8;
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
            this.buttDobPred.Location = new System.Drawing.Point(184, 259);
            this.buttDobPred.Name = "buttDobPred";
            this.buttDobPred.Normalcolor = System.Drawing.Color.Transparent;
            this.buttDobPred.OnHovercolor = System.Drawing.Color.Transparent;
            this.buttDobPred.OnHoverTextColor = System.Drawing.Color.Gray;
            this.buttDobPred.selected = false;
            this.buttDobPred.Size = new System.Drawing.Size(197, 48);
            this.buttDobPred.TabIndex = 7;
            this.buttDobPred.Text = "Добавить предмет";
            this.buttDobPred.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttDobPred.Textcolor = System.Drawing.Color.DimGray;
            this.buttDobPred.TextFont = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttDobPred.Click += new System.EventHandler(this.buttDobPred_Click);
            // 
            // dobPredm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.dobPricePred);
            this.Controls.Add(this.dobNamePred);
            this.Controls.Add(this.buttDobPred);
            this.Controls.Add(this.DataPredmet);
            this.Name = "dobPredm";
            this.Size = new System.Drawing.Size(565, 310);
            ((System.ComponentModel.ISupportInitialize)(this.DataPredmet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView DataPredmet;
        public WindowsFormsControlLibrary1.BunifuCustomTextbox dobPricePred;
        public WindowsFormsControlLibrary1.BunifuCustomTextbox dobNamePred;
        public Bunifu.Framework.UI.BunifuFlatButton buttDobPred;
    }
}
