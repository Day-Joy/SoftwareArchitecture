namespace CCommunicationPlatform2
{
    partial class LogIn
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.SignInButton = new Guna.UI2.WinForms.Guna2TileButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PswdTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.NameTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.elementHost1 = new System.Windows.Forms.Integration.ElementHost();
            this.label3 = new System.Windows.Forms.Label();
            this.IDTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.SignUpButton = new Guna.UI2.WinForms.Guna2TileButton();
            this.SuspendLayout();
            // 
            // SignInButton
            // 
            this.SignInButton.BorderRadius = 10;
            this.SignInButton.CheckedState.Parent = this.SignInButton;
            this.SignInButton.CustomImages.Parent = this.SignInButton;
            this.SignInButton.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.SignInButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.SignInButton.ForeColor = System.Drawing.Color.White;
            this.SignInButton.HoverState.Parent = this.SignInButton;
            this.SignInButton.Location = new System.Drawing.Point(185, 388);
            this.SignInButton.Name = "SignInButton";
            this.SignInButton.ShadowDecoration.Parent = this.SignInButton;
            this.SignInButton.Size = new System.Drawing.Size(224, 81);
            this.SignInButton.TabIndex = 9;
            this.SignInButton.Text = "Sign In";
            this.SignInButton.Click += new System.EventHandler(this.SignInButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(178, 290);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 39);
            this.label2.TabIndex = 8;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(178, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 39);
            this.label1.TabIndex = 7;
            this.label1.Text = "User name";
            // 
            // PswdTxt
            // 
            this.PswdTxt.BorderRadius = 7;
            this.PswdTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PswdTxt.DefaultText = "";
            this.PswdTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PswdTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PswdTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PswdTxt.DisabledState.Parent = this.PswdTxt;
            this.PswdTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PswdTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PswdTxt.FocusedState.Parent = this.PswdTxt;
            this.PswdTxt.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.PswdTxt.ForeColor = System.Drawing.Color.Black;
            this.PswdTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PswdTxt.HoverState.Parent = this.PswdTxt;
            this.PswdTxt.Location = new System.Drawing.Point(402, 287);
            this.PswdTxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.PswdTxt.Name = "PswdTxt";
            this.PswdTxt.PasswordChar = '*';
            this.PswdTxt.PlaceholderText = "";
            this.PswdTxt.SelectedText = "";
            this.PswdTxt.ShadowDecoration.Parent = this.PswdTxt;
            this.PswdTxt.Size = new System.Drawing.Size(267, 42);
            this.PswdTxt.TabIndex = 6;
            // 
            // NameTxt
            // 
            this.NameTxt.BorderRadius = 7;
            this.NameTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NameTxt.DefaultText = "";
            this.NameTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.NameTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.NameTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NameTxt.DisabledState.Parent = this.NameTxt;
            this.NameTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.NameTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NameTxt.FocusedState.Parent = this.NameTxt;
            this.NameTxt.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.NameTxt.ForeColor = System.Drawing.Color.Black;
            this.NameTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.NameTxt.HoverState.Parent = this.NameTxt;
            this.NameTxt.Location = new System.Drawing.Point(402, 117);
            this.NameTxt.Margin = new System.Windows.Forms.Padding(4);
            this.NameTxt.Name = "NameTxt";
            this.NameTxt.PasswordChar = '\0';
            this.NameTxt.PlaceholderText = "";
            this.NameTxt.SelectedText = "";
            this.NameTxt.ShadowDecoration.Parent = this.NameTxt;
            this.NameTxt.Size = new System.Drawing.Size(267, 42);
            this.NameTxt.TabIndex = 5;
            // 
            // elementHost1
            // 
            this.elementHost1.Location = new System.Drawing.Point(853, 523);
            this.elementHost1.Name = "elementHost1";
            this.elementHost1.Size = new System.Drawing.Size(10, 18);
            this.elementHost1.TabIndex = 10;
            this.elementHost1.Text = "elementHost1";
            this.elementHost1.Child = null;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(178, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 39);
            this.label3.TabIndex = 12;
            this.label3.Text = "ID";
            // 
            // IDTxt
            // 
            this.IDTxt.BorderRadius = 7;
            this.IDTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.IDTxt.DefaultText = "";
            this.IDTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.IDTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.IDTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.IDTxt.DisabledState.Parent = this.IDTxt;
            this.IDTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.IDTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.IDTxt.FocusedState.Parent = this.IDTxt;
            this.IDTxt.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.IDTxt.ForeColor = System.Drawing.Color.Black;
            this.IDTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.IDTxt.HoverState.Parent = this.IDTxt;
            this.IDTxt.Location = new System.Drawing.Point(402, 203);
            this.IDTxt.Margin = new System.Windows.Forms.Padding(4);
            this.IDTxt.Name = "IDTxt";
            this.IDTxt.PasswordChar = '\0';
            this.IDTxt.PlaceholderText = "";
            this.IDTxt.SelectedText = "";
            this.IDTxt.ShadowDecoration.Parent = this.IDTxt;
            this.IDTxt.Size = new System.Drawing.Size(267, 42);
            this.IDTxt.TabIndex = 11;
            // 
            // SignUpButton
            // 
            this.SignUpButton.BorderRadius = 10;
            this.SignUpButton.CheckedState.Parent = this.SignUpButton;
            this.SignUpButton.CustomImages.Parent = this.SignUpButton;
            this.SignUpButton.FillColor = System.Drawing.SystemColors.ActiveCaption;
            this.SignUpButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.SignUpButton.ForeColor = System.Drawing.Color.White;
            this.SignUpButton.HoverState.Parent = this.SignUpButton;
            this.SignUpButton.Location = new System.Drawing.Point(445, 388);
            this.SignUpButton.Name = "SignUpButton";
            this.SignUpButton.ShadowDecoration.Parent = this.SignUpButton;
            this.SignUpButton.Size = new System.Drawing.Size(224, 81);
            this.SignUpButton.TabIndex = 13;
            this.SignUpButton.Text = "Sign Up";
            this.SignUpButton.Click += new System.EventHandler(this.SignUpButton_Click);
            // 
            // LogIn
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(881, 565);
            this.Controls.Add(this.SignUpButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.IDTxt);
            this.Controls.Add(this.elementHost1);
            this.Controls.Add(this.SignInButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PswdTxt);
            this.Controls.Add(this.NameTxt);
            this.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.Name = "LogIn";
            this.Text = "Log In";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2TileButton SignInButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox PswdTxt;
        private Guna.UI2.WinForms.Guna2TextBox NameTxt;
        private System.Windows.Forms.Integration.ElementHost elementHost1;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox IDTxt;
        private Guna.UI2.WinForms.Guna2TileButton SignUpButton;
    }
}

