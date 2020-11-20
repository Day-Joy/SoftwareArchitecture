namespace CCommunicationPlatform2
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.elementHost1 = new System.Windows.Forms.Integration.ElementHost();
            this.guna2DateTimePicker1 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.CoursePanel = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.AddCourseBtn = new Guna.UI2.WinForms.Guna2CircleButton();
            this.LogOutBtn = new Guna.UI2.WinForms.Guna2TileButton();
            this.SuspendLayout();
            // 
            // elementHost1
            // 
            this.elementHost1.Location = new System.Drawing.Point(1212, 734);
            this.elementHost1.Name = "elementHost1";
            this.elementHost1.Size = new System.Drawing.Size(10, 10);
            this.elementHost1.TabIndex = 0;
            this.elementHost1.Text = "elementHost1";
            this.elementHost1.Child = null;
            // 
            // guna2DateTimePicker1
            // 
            this.guna2DateTimePicker1.BorderRadius = 14;
            this.guna2DateTimePicker1.CheckedState.Parent = this.guna2DateTimePicker1;
            this.guna2DateTimePicker1.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.guna2DateTimePicker1.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.guna2DateTimePicker1.ForeColor = System.Drawing.Color.White;
            this.guna2DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.guna2DateTimePicker1.HoverState.Parent = this.guna2DateTimePicker1;
            this.guna2DateTimePicker1.Location = new System.Drawing.Point(43, 40);
            this.guna2DateTimePicker1.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.guna2DateTimePicker1.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.guna2DateTimePicker1.Name = "guna2DateTimePicker1";
            this.guna2DateTimePicker1.ShadowDecoration.Parent = this.guna2DateTimePicker1;
            this.guna2DateTimePicker1.Size = new System.Drawing.Size(428, 100);
            this.guna2DateTimePicker1.TabIndex = 1;
            this.guna2DateTimePicker1.Value = new System.DateTime(2020, 11, 17, 10, 2, 46, 334);
            // 
            // CoursePanel
            // 
            this.CoursePanel.AutoScroll = true;
            this.CoursePanel.BackColor = System.Drawing.Color.Transparent;
            this.CoursePanel.FillColor = System.Drawing.Color.WhiteSmoke;
            this.CoursePanel.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.CoursePanel.Location = new System.Drawing.Point(489, 40);
            this.CoursePanel.Name = "CoursePanel";
            this.CoursePanel.Radius = 14;
            this.CoursePanel.ShadowColor = System.Drawing.Color.Black;
            this.CoursePanel.ShadowStyle = Guna.UI2.WinForms.Guna2ShadowPanel.ShadowMode.ForwardDiagonal;
            this.CoursePanel.Size = new System.Drawing.Size(681, 656);
            this.CoursePanel.TabIndex = 2;
            // 
            // AddCourseBtn
            // 
            this.AddCourseBtn.CheckedState.Parent = this.AddCourseBtn;
            this.AddCourseBtn.CustomImages.Parent = this.AddCourseBtn;
            this.AddCourseBtn.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.AddCourseBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.AddCourseBtn.ForeColor = System.Drawing.Color.White;
            this.AddCourseBtn.HoverState.Parent = this.AddCourseBtn;
            this.AddCourseBtn.Location = new System.Drawing.Point(43, 292);
            this.AddCourseBtn.Name = "AddCourseBtn";
            this.AddCourseBtn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.AddCourseBtn.ShadowDecoration.Parent = this.AddCourseBtn;
            this.AddCourseBtn.Size = new System.Drawing.Size(148, 148);
            this.AddCourseBtn.TabIndex = 6;
            this.AddCourseBtn.Text = "Add Course";
            this.AddCourseBtn.Click += new System.EventHandler(this.AddCourseBtn_Click);
            // 
            // LogOutBtn
            // 
            this.LogOutBtn.BackColor = System.Drawing.Color.White;
            this.LogOutBtn.BorderRadius = 10;
            this.LogOutBtn.CheckedState.Parent = this.LogOutBtn;
            this.LogOutBtn.CustomImages.Parent = this.LogOutBtn;
            this.LogOutBtn.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.LogOutBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.LogOutBtn.ForeColor = System.Drawing.Color.White;
            this.LogOutBtn.HoverState.Parent = this.LogOutBtn;
            this.LogOutBtn.Location = new System.Drawing.Point(43, 615);
            this.LogOutBtn.Name = "LogOutBtn";
            this.LogOutBtn.ShadowDecoration.Parent = this.LogOutBtn;
            this.LogOutBtn.Size = new System.Drawing.Size(428, 81);
            this.LogOutBtn.TabIndex = 18;
            this.LogOutBtn.Text = "Log Out";
            this.LogOutBtn.Click += new System.EventHandler(this.LogOutBtn_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1223, 746);
            this.Controls.Add(this.LogOutBtn);
            this.Controls.Add(this.AddCourseBtn);
            this.Controls.Add(this.CoursePanel);
            this.Controls.Add(this.guna2DateTimePicker1);
            this.Controls.Add(this.elementHost1);
            this.Name = "MainWindow";
            this.Text = "MainWindow";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Integration.ElementHost elementHost1;
        private Guna.UI2.WinForms.Guna2ShadowPanel CoursePanel;
        private Guna.UI2.WinForms.Guna2DateTimePicker guna2DateTimePicker1;
        private Guna.UI2.WinForms.Guna2CircleButton AddCourseBtn;
        public Guna.UI2.WinForms.Guna2TileButton LogOutBtn;
    }
}