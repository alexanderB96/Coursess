namespace Coursess
{
    partial class dobType
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
            this.DataType = new System.Windows.Forms.DataGridView();
            this.dobTypeTxt = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.buttDobType = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.DataType)).BeginInit();
            this.SuspendLayout();
            // 
            // DataType
            // 
            this.DataType.AllowUserToAddRows = false;
            this.DataType.AllowUserToDeleteRows = false;
            this.DataType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DataType.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataType.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.DataType.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataType.Location = new System.Drawing.Point(0, 0);
            this.DataType.Name = "DataType";
            this.DataType.ReadOnly = true;
            this.DataType.RowHeadersVisible = false;
            this.DataType.Size = new System.Drawing.Size(565, 272);
            this.DataType.TabIndex = 6;
            // 
            // dobTypeTxt
            // 
            this.dobTypeTxt.BorderColor = System.Drawing.Color.SeaGreen;
            this.dobTypeTxt.Location = new System.Drawing.Point(12, 278);
            this.dobTypeTxt.Name = "dobTypeTxt";
            this.dobTypeTxt.Size = new System.Drawing.Size(191, 20);
            this.dobTypeTxt.TabIndex = 12;
            this.dobTypeTxt.Text = "тип занятия ...";
            this.dobTypeTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.dobTypeTxt.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dobTypeTxt_MouseClick);
            // 
            // buttDobType
            // 
            this.buttDobType.Activecolor = System.Drawing.Color.Transparent;
            this.buttDobType.BackColor = System.Drawing.Color.Transparent;
            this.buttDobType.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttDobType.BorderRadius = 0;
            this.buttDobType.ButtonText = "Добавить тип";
            this.buttDobType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttDobType.DisabledColor = System.Drawing.Color.Gray;
            this.buttDobType.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.buttDobType.Iconcolor = System.Drawing.Color.Transparent;
            this.buttDobType.Iconimage = null;
            this.buttDobType.Iconimage_right = null;
            this.buttDobType.Iconimage_right_Selected = null;
            this.buttDobType.Iconimage_Selected = null;
            this.buttDobType.IconMarginLeft = 0;
            this.buttDobType.IconMarginRight = 0;
            this.buttDobType.IconRightVisible = true;
            this.buttDobType.IconRightZoom = 0D;
            this.buttDobType.IconVisible = true;
            this.buttDobType.IconZoom = 90D;
            this.buttDobType.IsTab = false;
            this.buttDobType.Location = new System.Drawing.Point(306, 261);
            this.buttDobType.Name = "buttDobType";
            this.buttDobType.Normalcolor = System.Drawing.Color.Transparent;
            this.buttDobType.OnHovercolor = System.Drawing.Color.Transparent;
            this.buttDobType.OnHoverTextColor = System.Drawing.Color.Gray;
            this.buttDobType.selected = false;
            this.buttDobType.Size = new System.Drawing.Size(244, 48);
            this.buttDobType.TabIndex = 11;
            this.buttDobType.Text = "Добавить тип";
            this.buttDobType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttDobType.Textcolor = System.Drawing.Color.DimGray;
            this.buttDobType.TextFont = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttDobType.Click += new System.EventHandler(this.buttDobType_Click);
            // 
            // dobType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.dobTypeTxt);
            this.Controls.Add(this.buttDobType);
            this.Controls.Add(this.DataType);
            this.Name = "dobType";
            this.Size = new System.Drawing.Size(565, 310);
            ((System.ComponentModel.ISupportInitialize)(this.DataType)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView DataType;
        public WindowsFormsControlLibrary1.BunifuCustomTextbox dobTypeTxt;
        public Bunifu.Framework.UI.BunifuFlatButton buttDobType;
    }
}
