namespace nituz_project_23
{
    partial class CreateInventoryItem
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CIIName = new System.Windows.Forms.TextBox();
            this.CIIQuantity = new System.Windows.Forms.TextBox();
            this.CIIMinimunQuantity = new System.Windows.Forms.TextBox();
            this.CIIMaximumQuantity = new System.Windows.Forms.TextBox();
            this.CIIDescription = new System.Windows.Forms.TextBox();
            this.CIICreateButton = new System.Windows.Forms.Button();
            this.CIICategoryItemList = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.go_back_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Category:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Quantity:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(32, 309);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 20);
            this.label9.TabIndex = 8;
            this.label9.Text = "Description:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Minimum Quantity:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 257);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Maximum Quantity:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // CIIName
            // 
            this.CIIName.Location = new System.Drawing.Point(111, 82);
            this.CIIName.Name = "CIIName";
            this.CIIName.Size = new System.Drawing.Size(337, 26);
            this.CIIName.TabIndex = 11;
            this.CIIName.TextChanged += new System.EventHandler(this.CIIName_TextChanged);
            // 
            // CIIQuantity
            // 
            this.CIIQuantity.Location = new System.Drawing.Point(111, 174);
            this.CIIQuantity.Name = "CIIQuantity";
            this.CIIQuantity.Size = new System.Drawing.Size(337, 26);
            this.CIIQuantity.TabIndex = 12;
            this.CIIQuantity.TextChanged += new System.EventHandler(this.CIIQuantity_TextChanged);
            // 
            // CIIMinimunQuantity
            // 
            this.CIIMinimunQuantity.Location = new System.Drawing.Point(192, 214);
            this.CIIMinimunQuantity.Name = "CIIMinimunQuantity";
            this.CIIMinimunQuantity.Size = new System.Drawing.Size(256, 26);
            this.CIIMinimunQuantity.TabIndex = 13;
            this.CIIMinimunQuantity.TextChanged += new System.EventHandler(this.CIIMinimunQuantity_TextChanged);
            // 
            // CIIMaximumQuantity
            // 
            this.CIIMaximumQuantity.Location = new System.Drawing.Point(192, 257);
            this.CIIMaximumQuantity.Name = "CIIMaximumQuantity";
            this.CIIMaximumQuantity.Size = new System.Drawing.Size(256, 26);
            this.CIIMaximumQuantity.TabIndex = 14;
            this.CIIMaximumQuantity.TextChanged += new System.EventHandler(this.CIIMaximumQuantity_TextChanged);
            // 
            // CIIDescription
            // 
            this.CIIDescription.Location = new System.Drawing.Point(141, 303);
            this.CIIDescription.Name = "CIIDescription";
            this.CIIDescription.Size = new System.Drawing.Size(308, 26);
            this.CIIDescription.TabIndex = 15;
            this.CIIDescription.TextChanged += new System.EventHandler(this.CIIDescription_TextChanged);
            // 
            // CIICreateButton
            // 
            this.CIICreateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CIICreateButton.Location = new System.Drawing.Point(356, 386);
            this.CIICreateButton.Name = "CIICreateButton";
            this.CIICreateButton.Size = new System.Drawing.Size(258, 85);
            this.CIICreateButton.TabIndex = 16;
            this.CIICreateButton.Text = "Create New Item";
            this.CIICreateButton.UseVisualStyleBackColor = true;
            this.CIICreateButton.Click += new System.EventHandler(this.CIICreateButton_Click);
            // 
            // CIICategoryItemList
            // 
            this.CIICategoryItemList.FormattingEnabled = true;
            this.CIICategoryItemList.Location = new System.Drawing.Point(114, 128);
            this.CIICategoryItemList.Name = "CIICategoryItemList";
            this.CIICategoryItemList.Size = new System.Drawing.Size(334, 28);
            this.CIICategoryItemList.TabIndex = 17;
            this.CIICategoryItemList.SelectedIndexChanged += new System.EventHandler(this.CIICategoryItemList_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Enabled = false;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(250, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(269, 46);
            this.label6.TabIndex = 18;
            this.label6.Text = "Item Creation ";
            this.label6.Click += new System.EventHandler(this.label6_Click_1);
            // 
            // go_back_button
            // 
            this.go_back_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.go_back_button.Location = new System.Drawing.Point(18, 409);
            this.go_back_button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.go_back_button.Name = "go_back_button";
            this.go_back_button.Size = new System.Drawing.Size(192, 62);
            this.go_back_button.TabIndex = 19;
            this.go_back_button.Text = "<- Go back";
            this.go_back_button.UseVisualStyleBackColor = true;
            this.go_back_button.Click += new System.EventHandler(this.go_back_button_Click_1);
            // 
            // CreateInventoryItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 526);
            this.Controls.Add(this.go_back_button);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CIICategoryItemList);
            this.Controls.Add(this.CIICreateButton);
            this.Controls.Add(this.CIIDescription);
            this.Controls.Add(this.CIIMaximumQuantity);
            this.Controls.Add(this.CIIMinimunQuantity);
            this.Controls.Add(this.CIIQuantity);
            this.Controls.Add(this.CIIName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CreateInventoryItem";
            this.Text = "Create Inventory Item";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CreateInventoryItem_FormClosed);
            this.Load += new System.EventHandler(this.CreateInventoryItem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox CIIName;
        private System.Windows.Forms.TextBox CIIQuantity;
        private System.Windows.Forms.TextBox CIIMinimunQuantity;
        private System.Windows.Forms.TextBox CIIMaximumQuantity;
        private System.Windows.Forms.TextBox CIIDescription;
        private System.Windows.Forms.Button CIICreateButton;
        private System.Windows.Forms.ComboBox CIICategoryItemList;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button go_back_button;
    }
}