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
            this.DataFull = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DataFull)).BeginInit();
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
            this.DataFull.Location = new System.Drawing.Point(0, 0);
            this.DataFull.Name = "DataFull";
            this.DataFull.ReadOnly = true;
            this.DataFull.RowHeadersVisible = false;
            this.DataFull.Size = new System.Drawing.Size(565, 202);
            this.DataFull.TabIndex = 2;
            // 
            // Cours
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.DataFull);
            this.Name = "Cours";
            this.Size = new System.Drawing.Size(565, 400);
            this.Load += new System.EventHandler(this.Cours_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataFull)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView DataFull;
    }
}
