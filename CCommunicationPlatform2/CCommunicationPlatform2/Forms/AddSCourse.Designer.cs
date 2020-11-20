namespace CCommunicationPlatform2.Forms
{
    partial class AddSCourse
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
            this.AddSCourseButton = new Guna.UI2.WinForms.Guna2TileButton();
            this.label2 = new System.Windows.Forms.Label();
            this.CourseIDTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.SuspendLayout();
            // 
            // AddSCourseButton
            // 
            this.AddSCourseButton.BorderRadius = 10;
            this.AddSCourseButton.CheckedState.Parent = this.AddSCourseButton;
            this.AddSCourseButton.CustomImages.Parent = this.AddSCourseButton;
            this.AddSCourseButton.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.AddSCourseButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.AddSCourseButton.ForeColor = System.Drawing.Color.White;
            this.AddSCourseButton.HoverState.Parent = this.AddSCourseButton;
            this.AddSCourseButton.Location = new System.Drawing.Point(158, 240);
            this.AddSCourseButton.Name = "AddSCourseButton";
            this.AddSCourseButton.ShadowDecoration.Parent = this.AddSCourseButton;
            this.AddSCourseButton.Size = new System.Drawing.Size(484, 81);
            this.AddSCourseButton.TabIndex = 24;
            this.AddSCourseButton.Text = "Add";
            this.AddSCourseButton.Click += new System.EventHandler(this.AddSCourseButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("幼圆", 12F);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(152, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 33);
            this.label2.TabIndex = 23;
            this.label2.Text = "课头号";
            // 
            // CourseIDTxt
            // 
            this.CourseIDTxt.BorderRadius = 7;
            this.CourseIDTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CourseIDTxt.DefaultText = "";
            this.CourseIDTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.CourseIDTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.CourseIDTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CourseIDTxt.DisabledState.Parent = this.CourseIDTxt;
            this.CourseIDTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.CourseIDTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CourseIDTxt.FocusedState.Parent = this.CourseIDTxt;
            this.CourseIDTxt.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.CourseIDTxt.ForeColor = System.Drawing.Color.Black;
            this.CourseIDTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CourseIDTxt.HoverState.Parent = this.CourseIDTxt;
            this.CourseIDTxt.Location = new System.Drawing.Point(376, 124);
            this.CourseIDTxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CourseIDTxt.Name = "CourseIDTxt";
            this.CourseIDTxt.PasswordChar = '*';
            this.CourseIDTxt.PlaceholderText = "";
            this.CourseIDTxt.SelectedText = "";
            this.CourseIDTxt.ShadowDecoration.Parent = this.CourseIDTxt;
            this.CourseIDTxt.Size = new System.Drawing.Size(267, 42);
            this.CourseIDTxt.TabIndex = 22;
            // 
            // AddSCourse
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AddSCourseButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CourseIDTxt);
            this.Name = "AddSCourse";
            this.Text = "AddSCourse";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2TileButton AddSCourseButton;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox CourseIDTxt;
    }
}