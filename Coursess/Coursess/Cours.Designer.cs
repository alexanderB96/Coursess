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
            this.DataFull.Size = new System.Drawing.Size(565, 202);
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
            // Cours
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Controls.Add(this.DataFull);
            this.Name = "Cours";
            this.Size = new System.Drawing.Size(565, 400);
            this.Load += new System.EventHandler(this.Cours_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataFull)).EndInit();
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView DataFull;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuiOSSwitch SwitchAll;
    }
}
