namespace nituz_project_23
{
    partial class OwnerLandingPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OwnerLandingPage));
            this.welcome_label = new System.Windows.Forms.Label();
            this.sign_out_button = new System.Windows.Forms.Button();
            this.inventory_crud = new System.Windows.Forms.Button();
            this.selfEvaluation_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // welcome_label
            // 
            this.welcome_label.AutoSize = true;
            this.welcome_label.BackColor = System.Drawing.Color.Transparent;
            this.welcome_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.welcome_label.Location = new System.Drawing.Point(363, 28);
            this.welcome_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.welcome_label.Name = "welcome_label";
            this.welcome_label.Size = new System.Drawing.Size(224, 37);
            this.welcome_label.TabIndex = 0;
            this.welcome_label.Text = "Hello, Shahar";
            this.welcome_label.Click += new System.EventHandler(this.welcome_label_Click);
            // 
            // sign_out_button
            // 
            this.sign_out_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.sign_out_button.Location = new System.Drawing.Point(18, 763);
            this.sign_out_button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.sign_out_button.Name = "sign_out_button";
            this.sign_out_button.Size = new System.Drawing.Size(117, 55);
            this.sign_out_button.TabIndex = 1;
            this.sign_out_button.Text = "Sign Out";
            this.sign_out_button.UseVisualStyleBackColor = true;
            this.sign_out_button.Click += new System.EventHandler(this.sign_out_button_Click);
            // 
            // inventory_crud
            // 
            this.inventory_crud.BackColor = System.Drawing.Color.Transparent;
            this.inventory_crud.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("inventory_crud.BackgroundImage")));
            this.inventory_crud.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.inventory_crud.FlatAppearance.BorderSize = 0;
            this.inventory_crud.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inventory_crud.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inventory_crud.Location = new System.Drawing.Point(82, 362);
            this.inventory_crud.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.inventory_crud.Name = "inventory_crud";
            this.inventory_crud.Size = new System.Drawing.Size(368, 340);
            this.inventory_crud.TabIndex = 2;
            this.inventory_crud.UseVisualStyleBackColor = false;
            this.inventory_crud.Click += new System.EventHandler(this.inventory_crud_Click);
            // 
            // selfEvaluation_button
            // 
            this.selfEvaluation_button.BackColor = System.Drawing.Color.Transparent;
            this.selfEvaluation_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("selfEvaluation_button.BackgroundImage")));
            this.selfEvaluation_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.selfEvaluation_button.FlatAppearance.BorderSize = 0;
            this.selfEvaluation_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selfEvaluation_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selfEvaluation_button.Location = new System.Drawing.Point(498, 277);
            this.selfEvaluation_button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.selfEvaluation_button.Name = "selfEvaluation_button";
            this.selfEvaluation_button.Size = new System.Drawing.Size(441, 534);
            this.selfEvaluation_button.TabIndex = 3;
            this.selfEvaluation_button.UseVisualStyleBackColor = false;
            this.selfEvaluation_button.Click += new System.EventHandler(this.selfEvaluation_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(206, 122);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(945, 56);
            this.label1.TabIndex = 4;
            this.label1.Text = "Welcome to your personal business site ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(243, 209);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(779, 56);
            this.label2.TabIndex = 5;
            this.label2.Text = "What would you like to do today?";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // OwnerLandingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(986, 837);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.selfEvaluation_button);
            this.Controls.Add(this.inventory_crud);
            this.Controls.Add(this.sign_out_button);
            this.Controls.Add(this.welcome_label);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "OwnerLandingPage";
            this.Text = "Owner Landing Page";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OwnerLandingPage_FormClosed);
            this.Load += new System.EventHandler(this.OwnerLandingPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcome_label;
        private System.Windows.Forms.Button sign_out_button;
        private System.Windows.Forms.Button inventory_crud;
        private System.Windows.Forms.Button selfEvaluation_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}