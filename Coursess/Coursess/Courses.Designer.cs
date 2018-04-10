namespace Coursess
{
    partial class Courses
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Courses));
            this.bunifuGradientPanel2 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.DataCourses = new System.Windows.Forms.DataGridView();
            this.bunifuGradientPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataCourses)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuGradientPanel2
            // 
            this.bunifuGradientPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel2.BackgroundImage")));
            this.bunifuGradientPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel2.Controls.Add(this.DataCourses);
            this.bunifuGradientPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGradientPanel2.GradientBottomLeft = System.Drawing.SystemColors.ControlLightLight;
            this.bunifuGradientPanel2.GradientBottomRight = System.Drawing.SystemColors.ControlLightLight;
            this.bunifuGradientPanel2.GradientTopLeft = System.Drawing.SystemColors.ControlLightLight;
            this.bunifuGradientPanel2.GradientTopRight = System.Drawing.SystemColors.ControlLightLight;
            this.bunifuGradientPanel2.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel2.Name = "bunifuGradientPanel2";
            this.bunifuGradientPanel2.Quality = 10;
            this.bunifuGradientPanel2.Size = new System.Drawing.Size(565, 400);
            this.bunifuGradientPanel2.TabIndex = 2;
            // 
            // DataCourses
            // 
            this.DataCourses.AllowUserToAddRows = false;
            this.DataCourses.AllowUserToDeleteRows = false;
            this.DataCourses.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.DataCourses.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataCourses.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            this.DataCourses.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.DataCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataCourses.Dock = System.Windows.Forms.DockStyle.Top;
            this.DataCourses.Location = new System.Drawing.Point(0, 0);
            this.DataCourses.Name = "DataCourses";
            this.DataCourses.ReadOnly = true;
            this.DataCourses.RowHeadersVisible = false;
            this.DataCourses.Size = new System.Drawing.Size(565, 150);
            this.DataCourses.TabIndex = 0;
            // 
            // Courses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.Controls.Add(this.bunifuGradientPanel2);
            this.Name = "Courses";
            this.Size = new System.Drawing.Size(565, 400);
            this.bunifuGradientPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataCourses)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel2;
        public System.Windows.Forms.DataGridView DataCourses;
    }
}
