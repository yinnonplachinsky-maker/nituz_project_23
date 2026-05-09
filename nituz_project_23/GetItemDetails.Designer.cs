namespace nituz_project_23
{
    partial class GetItemDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GetItemDetails));
            this.GIDCategoryItemList = new System.Windows.Forms.ComboBox();
            this.GIDDescription = new System.Windows.Forms.TextBox();
            this.GIDMaximumQuantity = new System.Windows.Forms.TextBox();
            this.GIDMinimunQuantity = new System.Windows.Forms.TextBox();
            this.GIDQuantity = new System.Windows.Forms.TextBox();
            this.GIDName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.GIDUpdateItemDetails = new System.Windows.Forms.Button();
            this.GIDDeleteItemDetails = new System.Windows.Forms.Button();
            this.GIDLookForItems = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.go_back_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GIDCategoryItemList
            // 
            this.GIDCategoryItemList.FormattingEnabled = true;
            this.GIDCategoryItemList.Location = new System.Drawing.Point(235, 139);
            this.GIDCategoryItemList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GIDCategoryItemList.Name = "GIDCategoryItemList";
            this.GIDCategoryItemList.Size = new System.Drawing.Size(224, 21);
            this.GIDCategoryItemList.TabIndex = 29;
            this.GIDCategoryItemList.SelectedIndexChanged += new System.EventHandler(this.GIDCategoryItemList_SelectedIndexChanged);
            // 
            // GIDDescription
            // 
            this.GIDDescription.Location = new System.Drawing.Point(235, 383);
            this.GIDDescription.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GIDDescription.Name = "GIDDescription";
            this.GIDDescription.Size = new System.Drawing.Size(226, 20);
            this.GIDDescription.TabIndex = 28;
            this.GIDDescription.TextChanged += new System.EventHandler(this.GIDDescription_TextChanged);
            // 
            // GIDMaximumQuantity
            // 
            this.GIDMaximumQuantity.Location = new System.Drawing.Point(235, 321);
            this.GIDMaximumQuantity.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GIDMaximumQuantity.Name = "GIDMaximumQuantity";
            this.GIDMaximumQuantity.Size = new System.Drawing.Size(226, 20);
            this.GIDMaximumQuantity.TabIndex = 27;
            this.GIDMaximumQuantity.TextChanged += new System.EventHandler(this.GIDMaximumQuantity_TextChanged);
            // 
            // GIDMinimunQuantity
            // 
            this.GIDMinimunQuantity.Location = new System.Drawing.Point(235, 260);
            this.GIDMinimunQuantity.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GIDMinimunQuantity.Name = "GIDMinimunQuantity";
            this.GIDMinimunQuantity.Size = new System.Drawing.Size(226, 20);
            this.GIDMinimunQuantity.TabIndex = 26;
            this.GIDMinimunQuantity.TextChanged += new System.EventHandler(this.GIDMinimunQuantity_TextChanged);
            // 
            // GIDQuantity
            // 
            this.GIDQuantity.Location = new System.Drawing.Point(235, 200);
            this.GIDQuantity.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GIDQuantity.Name = "GIDQuantity";
            this.GIDQuantity.Size = new System.Drawing.Size(226, 20);
            this.GIDQuantity.TabIndex = 25;
            this.GIDQuantity.TextChanged += new System.EventHandler(this.GIDQuantity_TextChanged);
            // 
            // GIDName
            // 
            this.GIDName.Location = new System.Drawing.Point(235, 75);
            this.GIDName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GIDName.Name = "GIDName";
            this.GIDName.Size = new System.Drawing.Size(226, 20);
            this.GIDName.TabIndex = 24;
            this.GIDName.TextChanged += new System.EventHandler(this.GIDName_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Adobe Gothic Std B", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label5.Location = new System.Drawing.Point(20, 321);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 23);
            this.label5.TabIndex = 23;
            this.label5.Text = "Maximum Quantity:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Adobe Gothic Std B", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.Location = new System.Drawing.Point(20, 258);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 23);
            this.label4.TabIndex = 22;
            this.label4.Text = "Minimum Quantity:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Adobe Gothic Std B", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label9.Location = new System.Drawing.Point(20, 381);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 23);
            this.label9.TabIndex = 21;
            this.label9.Text = "Description:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Adobe Gothic Std B", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(20, 198);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 23);
            this.label3.TabIndex = 20;
            this.label3.Text = "Quantity:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Adobe Gothic Std B", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(20, 139);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 23);
            this.label2.TabIndex = 19;
            this.label2.Text = "Category:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Adobe Gothic Std B", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(20, 72);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 23);
            this.label1.TabIndex = 18;
            this.label1.Text = "Name:";
            // 
            // GIDUpdateItemDetails
            // 
            this.GIDUpdateItemDetails.BackColor = System.Drawing.Color.Transparent;
            this.GIDUpdateItemDetails.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("GIDUpdateItemDetails.BackgroundImage")));
            this.GIDUpdateItemDetails.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.GIDUpdateItemDetails.FlatAppearance.BorderSize = 0;
            this.GIDUpdateItemDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GIDUpdateItemDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GIDUpdateItemDetails.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.GIDUpdateItemDetails.Location = new System.Drawing.Point(545, 74);
            this.GIDUpdateItemDetails.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GIDUpdateItemDetails.Name = "GIDUpdateItemDetails";
            this.GIDUpdateItemDetails.Size = new System.Drawing.Size(214, 207);
            this.GIDUpdateItemDetails.TabIndex = 30;
            this.GIDUpdateItemDetails.UseVisualStyleBackColor = false;
            this.GIDUpdateItemDetails.Click += new System.EventHandler(this.GIDUpdateItemDetails_Click);
            // 
            // GIDDeleteItemDetails
            // 
            this.GIDDeleteItemDetails.BackColor = System.Drawing.Color.Transparent;
            this.GIDDeleteItemDetails.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("GIDDeleteItemDetails.BackgroundImage")));
            this.GIDDeleteItemDetails.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.GIDDeleteItemDetails.FlatAppearance.BorderSize = 0;
            this.GIDDeleteItemDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GIDDeleteItemDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GIDDeleteItemDetails.Location = new System.Drawing.Point(532, 276);
            this.GIDDeleteItemDetails.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GIDDeleteItemDetails.Name = "GIDDeleteItemDetails";
            this.GIDDeleteItemDetails.Size = new System.Drawing.Size(246, 203);
            this.GIDDeleteItemDetails.TabIndex = 31;
            this.GIDDeleteItemDetails.UseVisualStyleBackColor = false;
            this.GIDDeleteItemDetails.Click += new System.EventHandler(this.GIDDeleteItemDetails_Click);
            // 
            // GIDLookForItems
            // 
            this.GIDLookForItems.FormattingEnabled = true;
            this.GIDLookForItems.Location = new System.Drawing.Point(380, 23);
            this.GIDLookForItems.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GIDLookForItems.Name = "GIDLookForItems";
            this.GIDLookForItems.Size = new System.Drawing.Size(231, 21);
            this.GIDLookForItems.TabIndex = 32;
            this.GIDLookForItems.SelectedIndexChanged += new System.EventHandler(this.GIDLookForItems_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Adobe Gothic Std B", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label6.Location = new System.Drawing.Point(230, 16);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 28);
            this.label6.TabIndex = 33;
            this.label6.Text = "Item Name:";
            // 
            // go_back_button
            // 
            this.go_back_button.Font = new System.Drawing.Font("Adobe Gothic Std B", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.go_back_button.Location = new System.Drawing.Point(12, 498);
            this.go_back_button.Name = "go_back_button";
            this.go_back_button.Size = new System.Drawing.Size(106, 40);
            this.go_back_button.TabIndex = 34;
            this.go_back_button.Text = "← Go back";
            this.go_back_button.UseVisualStyleBackColor = true;
            this.go_back_button.Click += new System.EventHandler(this.go_back_button_Click);
            // 
            // GetItemDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(837, 552);
            this.Controls.Add(this.go_back_button);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.GIDLookForItems);
            this.Controls.Add(this.GIDDeleteItemDetails);
            this.Controls.Add(this.GIDUpdateItemDetails);
            this.Controls.Add(this.GIDCategoryItemList);
            this.Controls.Add(this.GIDDescription);
            this.Controls.Add(this.GIDMaximumQuantity);
            this.Controls.Add(this.GIDMinimunQuantity);
            this.Controls.Add(this.GIDQuantity);
            this.Controls.Add(this.GIDName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "GetItemDetails";
            this.Text = "Get Item Details";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GetItemDetails_FormClosed);
            this.Load += new System.EventHandler(this.GetItemDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox GIDCategoryItemList;
        private System.Windows.Forms.TextBox GIDDescription;
        private System.Windows.Forms.TextBox GIDMaximumQuantity;
        private System.Windows.Forms.TextBox GIDMinimunQuantity;
        private System.Windows.Forms.TextBox GIDQuantity;
        private System.Windows.Forms.TextBox GIDName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button GIDUpdateItemDetails;
        private System.Windows.Forms.Button GIDDeleteItemDetails;
        private System.Windows.Forms.ComboBox GIDLookForItems;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button go_back_button;
    }
}