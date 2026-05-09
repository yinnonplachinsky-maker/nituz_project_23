namespace nituz_project_23
{
    partial class CrudInventoryItemMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrudInventoryItemMenu));
            this.CreateNewInventoryItem = new System.Windows.Forms.Button();
            this.GetInventoryItemDetails = new System.Windows.Forms.Button();
            this.go_back_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CreateNewInventoryItem
            // 
            this.CreateNewInventoryItem.BackColor = System.Drawing.Color.Transparent;
            this.CreateNewInventoryItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CreateNewInventoryItem.BackgroundImage")));
            this.CreateNewInventoryItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CreateNewInventoryItem.FlatAppearance.BorderSize = 0;
            this.CreateNewInventoryItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateNewInventoryItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateNewInventoryItem.Location = new System.Drawing.Point(11, 40);
            this.CreateNewInventoryItem.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CreateNewInventoryItem.Name = "CreateNewInventoryItem";
            this.CreateNewInventoryItem.Size = new System.Drawing.Size(296, 301);
            this.CreateNewInventoryItem.TabIndex = 0;
            this.CreateNewInventoryItem.UseVisualStyleBackColor = false;
            this.CreateNewInventoryItem.Click += new System.EventHandler(this.CreateNewInventoryItem_Click);
            // 
            // GetInventoryItemDetails
            // 
            this.GetInventoryItemDetails.BackColor = System.Drawing.Color.Transparent;
            this.GetInventoryItemDetails.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("GetInventoryItemDetails.BackgroundImage")));
            this.GetInventoryItemDetails.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.GetInventoryItemDetails.FlatAppearance.BorderSize = 0;
            this.GetInventoryItemDetails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GetInventoryItemDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GetInventoryItemDetails.Location = new System.Drawing.Point(311, 11);
            this.GetInventoryItemDetails.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.GetInventoryItemDetails.Name = "GetInventoryItemDetails";
            this.GetInventoryItemDetails.Size = new System.Drawing.Size(285, 338);
            this.GetInventoryItemDetails.TabIndex = 1;
            this.GetInventoryItemDetails.UseVisualStyleBackColor = false;
            this.GetInventoryItemDetails.Click += new System.EventHandler(this.button2_Click);
            // 
            // go_back_button
            // 
            this.go_back_button.Font = new System.Drawing.Font("Adobe Gothic Std B", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.go_back_button.Location = new System.Drawing.Point(7, 378);
            this.go_back_button.Name = "go_back_button";
            this.go_back_button.Size = new System.Drawing.Size(127, 41);
            this.go_back_button.TabIndex = 2;
            this.go_back_button.Text = "← Go back";
            this.go_back_button.UseVisualStyleBackColor = true;
            this.go_back_button.Click += new System.EventHandler(this.go_back_button_Click);
            // 
            // CrudInventoryItemMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(626, 431);
            this.Controls.Add(this.go_back_button);
            this.Controls.Add(this.GetInventoryItemDetails);
            this.Controls.Add(this.CreateNewInventoryItem);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CrudInventoryItemMenu";
            this.Text = "Inventory Item Menu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CrudInventoryItemMenu_FormClosed);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CreateNewInventoryItem;
        private System.Windows.Forms.Button GetInventoryItemDetails;
        private System.Windows.Forms.Button go_back_button;
    }
}