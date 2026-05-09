namespace nituz_project_23
{
    partial class LoginScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginScreen));
            this.SignInWithGoogleButton = new System.Windows.Forms.Button();
            this.OrText = new System.Windows.Forms.TextBox();
            this.PhoneTextBox = new System.Windows.Forms.TextBox();
            this.NameLogin_textbox = new System.Windows.Forms.TextBox();
            this.login_button = new System.Windows.Forms.Button();
            this.username_label = new System.Windows.Forms.Label();
            this.phone_number_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SignInWithGoogleButton
            // 
            this.SignInWithGoogleButton.BackColor = System.Drawing.Color.Transparent;
            this.SignInWithGoogleButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SignInWithGoogleButton.BackgroundImage")));
            this.SignInWithGoogleButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SignInWithGoogleButton.FlatAppearance.BorderSize = 0;
            this.SignInWithGoogleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SignInWithGoogleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.SignInWithGoogleButton.Location = new System.Drawing.Point(213, -6);
            this.SignInWithGoogleButton.Name = "SignInWithGoogleButton";
            this.SignInWithGoogleButton.Size = new System.Drawing.Size(400, 378);
            this.SignInWithGoogleButton.TabIndex = 1;
            this.SignInWithGoogleButton.UseVisualStyleBackColor = false;
            this.SignInWithGoogleButton.Click += new System.EventHandler(this.SignInWithGoogleButton_Click);
            // 
            // OrText
            // 
            this.OrText.BackColor = System.Drawing.Color.Tan;
            this.OrText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OrText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.OrText.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.OrText.Location = new System.Drawing.Point(408, 392);
            this.OrText.Name = "OrText";
            this.OrText.Size = new System.Drawing.Size(34, 23);
            this.OrText.TabIndex = 2;
            this.OrText.Text = "Or:";
            this.OrText.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // PhoneTextBox
            // 
            this.PhoneTextBox.ForeColor = System.Drawing.Color.Silver;
            this.PhoneTextBox.Location = new System.Drawing.Point(408, 518);
            this.PhoneTextBox.Name = "PhoneTextBox";
            this.PhoneTextBox.Size = new System.Drawing.Size(226, 26);
            this.PhoneTextBox.TabIndex = 3;
            this.PhoneTextBox.TextChanged += new System.EventHandler(this.IDNumberOrPhoneTextBox_TextChanged);
            this.PhoneTextBox.Enter += new System.EventHandler(this.IDNumberOrPhoneTextBox_Enter);
            this.PhoneTextBox.Leave += new System.EventHandler(this.IDNumberOrPhoneTextBox_Leave);
            // 
            // NameLogin_textbox
            // 
            this.NameLogin_textbox.ForeColor = System.Drawing.Color.Silver;
            this.NameLogin_textbox.Location = new System.Drawing.Point(408, 454);
            this.NameLogin_textbox.Name = "NameLogin_textbox";
            this.NameLogin_textbox.Size = new System.Drawing.Size(226, 26);
            this.NameLogin_textbox.TabIndex = 4;
            this.NameLogin_textbox.TextChanged += new System.EventHandler(this.NameLogin_textbox_TextChanged_1);
            this.NameLogin_textbox.Enter += new System.EventHandler(this.NameLoginButton_Enter);
            this.NameLogin_textbox.Leave += new System.EventHandler(this.NameLoginButton_Leave);
            // 
            // login_button
            // 
            this.login_button.BackColor = System.Drawing.Color.Transparent;
            this.login_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("login_button.BackgroundImage")));
            this.login_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.login_button.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.login_button.FlatAppearance.BorderSize = 0;
            this.login_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_button.Location = new System.Drawing.Point(273, 595);
            this.login_button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(303, 277);
            this.login_button.TabIndex = 5;
            this.login_button.UseVisualStyleBackColor = false;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // username_label
            // 
            this.username_label.AutoSize = true;
            this.username_label.BackColor = System.Drawing.Color.Transparent;
            this.username_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.username_label.Location = new System.Drawing.Point(52, 451);
            this.username_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.username_label.Name = "username_label";
            this.username_label.Size = new System.Drawing.Size(222, 30);
            this.username_label.TabIndex = 6;
            this.username_label.Text = "Enter Username:";
            // 
            // phone_number_label
            // 
            this.phone_number_label.AutoSize = true;
            this.phone_number_label.BackColor = System.Drawing.Color.Transparent;
            this.phone_number_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.phone_number_label.Location = new System.Drawing.Point(52, 514);
            this.phone_number_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.phone_number_label.Name = "phone_number_label";
            this.phone_number_label.Size = new System.Drawing.Size(279, 30);
            this.phone_number_label.TabIndex = 7;
            this.phone_number_label.Text = "Enter Phone Number:";
            this.phone_number_label.Click += new System.EventHandler(this.enter_phoneNumber_Click);
            // 
            // LoginScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(882, 874);
            this.Controls.Add(this.phone_number_label);
            this.Controls.Add(this.username_label);
            this.Controls.Add(this.login_button);
            this.Controls.Add(this.NameLogin_textbox);
            this.Controls.Add(this.PhoneTextBox);
            this.Controls.Add(this.OrText);
            this.Controls.Add(this.SignInWithGoogleButton);
            this.Name = "LoginScreen";
            this.Text = "Login Screen";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LoginScreen_FormClosed);
            this.Load += new System.EventHandler(this.LoginScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button SignInWithGoogleButton;
        private System.Windows.Forms.TextBox OrText;
        private System.Windows.Forms.TextBox PhoneTextBox;
        private System.Windows.Forms.TextBox NameLogin_textbox;
        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.Label username_label;
        private System.Windows.Forms.Label phone_number_label;
    }
}