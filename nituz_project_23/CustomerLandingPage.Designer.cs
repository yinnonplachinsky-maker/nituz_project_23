namespace nituz_project_23
{
    partial class CustomerLandingPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerLandingPage));
            this.welcome_label = new System.Windows.Forms.Label();
            this.make_a_review_button = new System.Windows.Forms.Button();
            this.sign_out_button = new System.Windows.Forms.Button();
            this.CLP_ChooseTimeSlot = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // welcome_label
            // 
            this.welcome_label.AutoSize = true;
            this.welcome_label.BackColor = System.Drawing.Color.Transparent;
            this.welcome_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.welcome_label.Location = new System.Drawing.Point(112, 28);
            this.welcome_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.welcome_label.Name = "welcome_label";
            this.welcome_label.Size = new System.Drawing.Size(878, 46);
            this.welcome_label.TabIndex = 0;
            this.welcome_label.Text = "Hello and Welcome to Shahar Hanagar\'s Site!";
            this.welcome_label.Click += new System.EventHandler(this.welcome_label_Click);
            // 
            // make_a_review_button
            // 
            this.make_a_review_button.BackColor = System.Drawing.Color.Transparent;
            this.make_a_review_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("make_a_review_button.BackgroundImage")));
            this.make_a_review_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.make_a_review_button.FlatAppearance.BorderSize = 0;
            this.make_a_review_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.make_a_review_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.make_a_review_button.Location = new System.Drawing.Point(54, 291);
            this.make_a_review_button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.make_a_review_button.Name = "make_a_review_button";
            this.make_a_review_button.Size = new System.Drawing.Size(440, 358);
            this.make_a_review_button.TabIndex = 1;
            this.make_a_review_button.UseVisualStyleBackColor = false;
            this.make_a_review_button.Click += new System.EventHandler(this.make_a_review_button_Click);
            // 
            // sign_out_button
            // 
            this.sign_out_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.sign_out_button.Location = new System.Drawing.Point(18, 672);
            this.sign_out_button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sign_out_button.Name = "sign_out_button";
            this.sign_out_button.Size = new System.Drawing.Size(154, 65);
            this.sign_out_button.TabIndex = 2;
            this.sign_out_button.Text = "Sign out";
            this.sign_out_button.UseVisualStyleBackColor = true;
            this.sign_out_button.Click += new System.EventHandler(this.sign_out_button_Click);
            // 
            // CLP_ChooseTimeSlot
            // 
            this.CLP_ChooseTimeSlot.BackColor = System.Drawing.Color.Transparent;
            this.CLP_ChooseTimeSlot.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CLP_ChooseTimeSlot.BackgroundImage")));
            this.CLP_ChooseTimeSlot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CLP_ChooseTimeSlot.FlatAppearance.BorderSize = 0;
            this.CLP_ChooseTimeSlot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CLP_ChooseTimeSlot.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CLP_ChooseTimeSlot.Location = new System.Drawing.Point(502, 228);
            this.CLP_ChooseTimeSlot.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CLP_ChooseTimeSlot.Name = "CLP_ChooseTimeSlot";
            this.CLP_ChooseTimeSlot.Size = new System.Drawing.Size(579, 474);
            this.CLP_ChooseTimeSlot.TabIndex = 3;
            this.CLP_ChooseTimeSlot.UseVisualStyleBackColor = false;
            this.CLP_ChooseTimeSlot.Click += new System.EventHandler(this.CLP_ChooseTimeSlot_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(12, 114);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1069, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "We specialize in providing professional and reliable handyman and carpentry servi" +
    "ces";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // CustomerLandingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1100, 756);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CLP_ChooseTimeSlot);
            this.Controls.Add(this.sign_out_button);
            this.Controls.Add(this.make_a_review_button);
            this.Controls.Add(this.welcome_label);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CustomerLandingPage";
            this.Text = "Customer Landing Page";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CustomerLandingPage_FormClosed);
            this.Load += new System.EventHandler(this.CustomerLandingPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcome_label;
        private System.Windows.Forms.Button make_a_review_button;
        private System.Windows.Forms.Button sign_out_button;
        private System.Windows.Forms.Button CLP_ChooseTimeSlot;
        private System.Windows.Forms.Label label1;
    }
}