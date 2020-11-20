namespace CCommunicationPlatform2.Forms
{
    partial class AddCourse
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
            this.label3 = new System.Windows.Forms.Label();
            this.ProgressTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.AddCourseButton = new Guna.UI2.WinForms.Guna2TileButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.KindTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.CourseNameTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ReTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("幼圆", 12F);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(155, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 33);
            this.label3.TabIndex = 19;
            this.label3.Text = "进度";
            // 
            // ProgressTxt
            // 
            this.ProgressTxt.BorderRadius = 7;
            this.ProgressTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ProgressTxt.DefaultText = "";
            this.ProgressTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ProgressTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ProgressTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ProgressTxt.DisabledState.Parent = this.ProgressTxt;
            this.ProgressTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ProgressTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ProgressTxt.FocusedState.Parent = this.ProgressTxt;
            this.ProgressTxt.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ProgressTxt.ForeColor = System.Drawing.Color.Black;
            this.ProgressTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ProgressTxt.HoverState.Parent = this.ProgressTxt;
            this.ProgressTxt.Location = new System.Drawing.Point(379, 135);
            this.ProgressTxt.Margin = new System.Windows.Forms.Padding(4);
            this.ProgressTxt.Name = "ProgressTxt";
            this.ProgressTxt.PasswordChar = '\0';
            this.ProgressTxt.PlaceholderText = "";
            this.ProgressTxt.SelectedText = "";
            this.ProgressTxt.ShadowDecoration.Parent = this.ProgressTxt;
            this.ProgressTxt.Size = new System.Drawing.Size(267, 42);
            this.ProgressTxt.TabIndex = 18;
            this.ProgressTxt.TextChanged += new System.EventHandler(this.ProgressTxt_TextChanged);
            // 
            // AddCourseButton
            // 
            this.AddCourseButton.BorderRadius = 10;
            this.AddCourseButton.CheckedState.Parent = this.AddCourseButton;
            this.AddCourseButton.CustomImages.Parent = this.AddCourseButton;
            this.AddCourseButton.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.AddCourseButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.AddCourseButton.ForeColor = System.Drawing.Color.White;
            this.AddCourseButton.HoverState.Parent = this.AddCourseButton;
            this.AddCourseButton.Location = new System.Drawing.Point(162, 432);
            this.AddCourseButton.Name = "AddCourseButton";
            this.AddCourseButton.ShadowDecoration.Parent = this.AddCourseButton;
            this.AddCourseButton.Size = new System.Drawing.Size(484, 81);
            this.AddCourseButton.TabIndex = 17;
            this.AddCourseButton.Text = "Add";
            this.AddCourseButton.Click += new System.EventHandler(this.AddCourseButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("幼圆", 12F);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(155, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 33);
            this.label2.TabIndex = 16;
            this.label2.Text = "课程类型";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("幼圆", 12F);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(155, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 33);
            this.label1.TabIndex = 15;
            this.label1.Text = "课程名";
            // 
            // KindTxt
            // 
            this.KindTxt.BorderRadius = 7;
            this.KindTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.KindTxt.DefaultText = "";
            this.KindTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.KindTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.KindTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.KindTxt.DisabledState.Parent = this.KindTxt;
            this.KindTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.KindTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.KindTxt.FocusedState.Parent = this.KindTxt;
            this.KindTxt.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.KindTxt.ForeColor = System.Drawing.Color.Black;
            this.KindTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.KindTxt.HoverState.Parent = this.KindTxt;
            this.KindTxt.Location = new System.Drawing.Point(379, 219);
            this.KindTxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.KindTxt.Name = "KindTxt";
            this.KindTxt.PasswordChar = '\0';
            this.KindTxt.PlaceholderText = "";
            this.KindTxt.SelectedText = "";
            this.KindTxt.ShadowDecoration.Parent = this.KindTxt;
            this.KindTxt.Size = new System.Drawing.Size(267, 42);
            this.KindTxt.TabIndex = 14;
            this.KindTxt.TextChanged += new System.EventHandler(this.KindTxt_TextChanged);
            // 
            // CourseNameTxt
            // 
            this.CourseNameTxt.BorderRadius = 7;
            this.CourseNameTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CourseNameTxt.DefaultText = "";
            this.CourseNameTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.CourseNameTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.CourseNameTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CourseNameTxt.DisabledState.Parent = this.CourseNameTxt;
            this.CourseNameTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CourseNameTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CourseNameTxt.FocusedState.Parent = this.CourseNameTxt;
            this.CourseNameTxt.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.CourseNameTxt.ForeColor = System.Drawing.Color.Black;
            this.CourseNameTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CourseNameTxt.HoverState.Parent = this.CourseNameTxt;
            this.CourseNameTxt.Location = new System.Drawing.Point(379, 49);
            this.CourseNameTxt.Margin = new System.Windows.Forms.Padding(4);
            this.CourseNameTxt.Name = "CourseNameTxt";
            this.CourseNameTxt.PasswordChar = '\0';
            this.CourseNameTxt.PlaceholderText = "";
            this.CourseNameTxt.SelectedText = "";
            this.CourseNameTxt.ShadowDecoration.Parent = this.CourseNameTxt;
            this.CourseNameTxt.Size = new System.Drawing.Size(267, 42);
            this.CourseNameTxt.TabIndex = 13;
            this.CourseNameTxt.TextChanged += new System.EventHandler(this.CourseNameTxt_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("幼圆", 12F);
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Location = new System.Drawing.Point(155, 312);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 33);
            this.label4.TabIndex = 21;
            this.label4.Text = "课代表";
            // 
            // ReTxt
            // 
            this.ReTxt.BorderRadius = 7;
            this.ReTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ReTxt.DefaultText = "";
            this.ReTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ReTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ReTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ReTxt.DisabledState.Parent = this.ReTxt;
            this.ReTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ReTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ReTxt.FocusedState.Parent = this.ReTxt;
            this.ReTxt.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.ReTxt.ForeColor = System.Drawing.Color.Black;
            this.ReTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ReTxt.HoverState.Parent = this.ReTxt;
            this.ReTxt.Location = new System.Drawing.Point(379, 309);
            this.ReTxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ReTxt.Name = "ReTxt";
            this.ReTxt.PasswordChar = '\0';
            this.ReTxt.PlaceholderText = "";
            this.ReTxt.SelectedText = "";
            this.ReTxt.ShadowDecoration.Parent = this.ReTxt;
            this.ReTxt.Size = new System.Drawing.Size(267, 42);
            this.ReTxt.TabIndex = 20;
            this.ReTxt.TextChanged += new System.EventHandler(this.ReTxt_TextChanged);
            // 
            // AddCourse
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 575);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ReTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ProgressTxt);
            this.Controls.Add(this.AddCourseButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.KindTxt);
            this.Controls.Add(this.CourseNameTxt);
            this.Name = "AddCourse";
            this.Text = "AddCourse";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        public Guna.UI2.WinForms.Guna2TileButton AddCourseButton;
        public Guna.UI2.WinForms.Guna2TextBox ProgressTxt;
        public Guna.UI2.WinForms.Guna2TextBox KindTxt;
        public Guna.UI2.WinForms.Guna2TextBox CourseNameTxt;
        public Guna.UI2.WinForms.Guna2TextBox ReTxt;
    }
}