namespace CCommunicationPlatform2.Forms
{
    partial class CourseCell
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CourseCell));
            this.elementHost1 = new System.Windows.Forms.Integration.ElementHost();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.DeleteButton = new Guna.UI2.WinForms.Guna2CircleButton();
            this.NameLbl = new System.Windows.Forms.Label();
            this.TeacherLbl = new System.Windows.Forms.Label();
            this.KindLbl = new System.Windows.Forms.Label();
            this.CidLbl = new System.Windows.Forms.Label();
            this.EditButton = new Guna.UI2.WinForms.Guna2CircleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ProgressLbl = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.RepreLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // elementHost1
            // 
            this.elementHost1.Location = new System.Drawing.Point(657, 197);
            this.elementHost1.Name = "elementHost1";
            this.elementHost1.Size = new System.Drawing.Size(10, 12);
            this.elementHost1.TabIndex = 0;
            this.elementHost1.Text = "elementHost1";
            this.elementHost1.Child = null;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 14;
            this.guna2Elipse1.TargetControl = this;
            // 
            // DeleteButton
            // 
            this.DeleteButton.BorderColor = System.Drawing.Color.MidnightBlue;
            this.DeleteButton.BorderThickness = 2;
            this.DeleteButton.CheckedState.Parent = this.DeleteButton;
            this.DeleteButton.CustomImages.Parent = this.DeleteButton;
            this.DeleteButton.FillColor = System.Drawing.Color.White;
            this.DeleteButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DeleteButton.ForeColor = System.Drawing.Color.White;
            this.DeleteButton.HoverState.Parent = this.DeleteButton;
            this.DeleteButton.Image = ((System.Drawing.Image)(resources.GetObject("DeleteButton.Image")));
            this.DeleteButton.ImageSize = new System.Drawing.Size(35, 35);
            this.DeleteButton.Location = new System.Drawing.Point(548, 197);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.DeleteButton.ShadowDecoration.Parent = this.DeleteButton;
            this.DeleteButton.Size = new System.Drawing.Size(70, 70);
            this.DeleteButton.TabIndex = 5;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // NameLbl
            // 
            this.NameLbl.AutoSize = true;
            this.NameLbl.Font = new System.Drawing.Font("幼圆", 10F);
            this.NameLbl.ForeColor = System.Drawing.Color.MidnightBlue;
            this.NameLbl.Location = new System.Drawing.Point(271, 86);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(0, 27);
            this.NameLbl.TabIndex = 12;
            // 
            // TeacherLbl
            // 
            this.TeacherLbl.AutoSize = true;
            this.TeacherLbl.Font = new System.Drawing.Font("幼圆", 10F);
            this.TeacherLbl.ForeColor = System.Drawing.Color.MidnightBlue;
            this.TeacherLbl.Location = new System.Drawing.Point(271, 166);
            this.TeacherLbl.Name = "TeacherLbl";
            this.TeacherLbl.Size = new System.Drawing.Size(0, 27);
            this.TeacherLbl.TabIndex = 13;
            // 
            // KindLbl
            // 
            this.KindLbl.AutoSize = true;
            this.KindLbl.Font = new System.Drawing.Font("幼圆", 10F);
            this.KindLbl.ForeColor = System.Drawing.Color.MidnightBlue;
            this.KindLbl.Location = new System.Drawing.Point(271, 126);
            this.KindLbl.Name = "KindLbl";
            this.KindLbl.Size = new System.Drawing.Size(0, 27);
            this.KindLbl.TabIndex = 14;
            // 
            // CidLbl
            // 
            this.CidLbl.AutoSize = true;
            this.CidLbl.Font = new System.Drawing.Font("幼圆", 10F);
            this.CidLbl.ForeColor = System.Drawing.Color.MidnightBlue;
            this.CidLbl.Location = new System.Drawing.Point(271, 16);
            this.CidLbl.Name = "CidLbl";
            this.CidLbl.Size = new System.Drawing.Size(0, 27);
            this.CidLbl.TabIndex = 15;
            // 
            // EditButton
            // 
            this.EditButton.BorderColor = System.Drawing.Color.MidnightBlue;
            this.EditButton.BorderThickness = 2;
            this.EditButton.CheckedState.Parent = this.EditButton;
            this.EditButton.CustomImages.Parent = this.EditButton;
            this.EditButton.FillColor = System.Drawing.Color.White;
            this.EditButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.EditButton.ForeColor = System.Drawing.Color.White;
            this.EditButton.HoverState.Parent = this.EditButton;
            this.EditButton.Image = ((System.Drawing.Image)(resources.GetObject("EditButton.Image")));
            this.EditButton.ImageSize = new System.Drawing.Size(35, 35);
            this.EditButton.Location = new System.Drawing.Point(548, 68);
            this.EditButton.Name = "EditButton";
            this.EditButton.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.EditButton.ShadowDecoration.Parent = this.EditButton;
            this.EditButton.Size = new System.Drawing.Size(70, 70);
            this.EditButton.TabIndex = 45;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("幼圆", 10F);
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(51, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 27);
            this.label1.TabIndex = 49;
            this.label1.Text = "课头号：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("幼圆", 10F);
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(51, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 27);
            this.label2.TabIndex = 48;
            this.label2.Text = "课程类型：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("幼圆", 10F);
            this.label3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label3.Location = new System.Drawing.Point(51, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 27);
            this.label3.TabIndex = 47;
            this.label3.Text = "授课教师：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("幼圆", 10F);
            this.label4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label4.Location = new System.Drawing.Point(51, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 27);
            this.label4.TabIndex = 46;
            this.label4.Text = "课程名：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("幼圆", 10F);
            this.label5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label5.Location = new System.Drawing.Point(51, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 27);
            this.label5.TabIndex = 51;
            this.label5.Text = "课程进度：";
            // 
            // ProgressLbl
            // 
            this.ProgressLbl.AutoSize = true;
            this.ProgressLbl.Font = new System.Drawing.Font("幼圆", 10F);
            this.ProgressLbl.ForeColor = System.Drawing.Color.MidnightBlue;
            this.ProgressLbl.Location = new System.Drawing.Point(271, 227);
            this.ProgressLbl.Name = "ProgressLbl";
            this.ProgressLbl.Size = new System.Drawing.Size(0, 27);
            this.ProgressLbl.TabIndex = 50;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("幼圆", 10F);
            this.label6.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label6.Location = new System.Drawing.Point(51, 272);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 27);
            this.label6.TabIndex = 53;
            this.label6.Text = "课代表：";
            // 
            // RepreLbl
            // 
            this.RepreLbl.AutoSize = true;
            this.RepreLbl.Font = new System.Drawing.Font("幼圆", 10F);
            this.RepreLbl.ForeColor = System.Drawing.Color.MidnightBlue;
            this.RepreLbl.Location = new System.Drawing.Point(271, 272);
            this.RepreLbl.Name = "RepreLbl";
            this.RepreLbl.Size = new System.Drawing.Size(0, 27);
            this.RepreLbl.TabIndex = 52;
            // 
            // CourseCell
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.RepreLbl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ProgressLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.CidLbl);
            this.Controls.Add(this.KindLbl);
            this.Controls.Add(this.TeacherLbl);
            this.Controls.Add(this.NameLbl);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.elementHost1);
            this.Name = "CourseCell";
            this.Size = new System.Drawing.Size(660, 337);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Integration.ElementHost elementHost1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        public System.Windows.Forms.Label TeacherLbl;
        public System.Windows.Forms.Label NameLbl;
        private Guna.UI2.WinForms.Guna2CircleButton DeleteButton;
        public System.Windows.Forms.Label CidLbl;
        public System.Windows.Forms.Label KindLbl;
        public Guna.UI2.WinForms.Guna2CircleButton EditButton;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label ProgressLbl;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label RepreLbl;
    }
}
