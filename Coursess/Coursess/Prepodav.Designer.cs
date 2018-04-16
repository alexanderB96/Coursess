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
            this.DataPrepodavatel.Size = new System.Drawing.Size(565, 175);
            this.DataPrepodavatel.TabIndex = 1;
            // 
            // Prepodav
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.DataPrepodavatel);
            this.Name = "Prepodav";
            this.Size = new System.Drawing.Size(565, 400);
            this.Load += new System.EventHandler(this.Prepodav_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataPrepodavatel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView DataPrepodavatel;
    }
}
