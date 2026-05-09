namespace nituz_project_23
{
    partial class WriteAReview
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WriteAReview));
            this.write_a_review = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.description = new System.Windows.Forms.Label();
            this.rate = new System.Windows.Forms.Label();
            this.title_text_box = new System.Windows.Forms.TextBox();
            this.description_text_box = new System.Windows.Forms.TextBox();
            this.ratingComboBox = new System.Windows.Forms.ComboBox();
            this.Submit_button = new System.Windows.Forms.Button();
            this.serviceCallID = new System.Windows.Forms.Label();
            this.serviceCall_combo_box = new System.Windows.Forms.ComboBox();
            this.go_back_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // write_a_review
            // 
            this.write_a_review.AutoSize = true;
            this.write_a_review.BackColor = System.Drawing.Color.Transparent;
            this.write_a_review.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.write_a_review.Location = new System.Drawing.Point(483, 31);
            this.write_a_review.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.write_a_review.Name = "write_a_review";
            this.write_a_review.Size = new System.Drawing.Size(485, 37);
            this.write_a_review.TabIndex = 0;
            this.write_a_review.Text = "Write a review to our business:";
            this.write_a_review.Click += new System.EventHandler(this.label1_Click);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.Color.Transparent;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.title.Location = new System.Drawing.Point(46, 217);
            this.title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(75, 30);
            this.title.TabIndex = 1;
            this.title.Text = "Title:";
            // 
            // description
            // 
            this.description.AutoSize = true;
            this.description.BackColor = System.Drawing.Color.Transparent;
            this.description.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.description.Location = new System.Drawing.Point(46, 308);
            this.description.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(161, 30);
            this.description.TabIndex = 2;
            this.description.Text = "Description:";
            this.description.Click += new System.EventHandler(this.description_Click);
            // 
            // rate
            // 
            this.rate.AutoSize = true;
            this.rate.BackColor = System.Drawing.Color.Transparent;
            this.rate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.rate.Location = new System.Drawing.Point(46, 586);
            this.rate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.rate.Name = "rate";
            this.rate.Size = new System.Drawing.Size(101, 30);
            this.rate.TabIndex = 3;
            this.rate.Text = "Rating:";
            // 
            // title_text_box
            // 
            this.title_text_box.Location = new System.Drawing.Point(243, 222);
            this.title_text_box.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.title_text_box.Name = "title_text_box";
            this.title_text_box.Size = new System.Drawing.Size(718, 26);
            this.title_text_box.TabIndex = 4;
            this.title_text_box.TextChanged += new System.EventHandler(this.title_text_box_TextChanged);
            // 
            // description_text_box
            // 
            this.description_text_box.Location = new System.Drawing.Point(243, 308);
            this.description_text_box.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.description_text_box.Multiline = true;
            this.description_text_box.Name = "description_text_box";
            this.description_text_box.Size = new System.Drawing.Size(718, 195);
            this.description_text_box.TabIndex = 5;
            this.description_text_box.TextChanged += new System.EventHandler(this.description_text_box_TextChanged);
            // 
            // ratingComboBox
            // 
            this.ratingComboBox.FormattingEnabled = true;
            this.ratingComboBox.Location = new System.Drawing.Point(243, 586);
            this.ratingComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ratingComboBox.Name = "ratingComboBox";
            this.ratingComboBox.Size = new System.Drawing.Size(158, 28);
            this.ratingComboBox.TabIndex = 6;
            this.ratingComboBox.SelectedIndexChanged += new System.EventHandler(this.ratingComboBox_SelectedIndexChanged_1);
            // 
            // Submit_button
            // 
            this.Submit_button.BackColor = System.Drawing.Color.Transparent;
            this.Submit_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Submit_button.BackgroundImage")));
            this.Submit_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Submit_button.FlatAppearance.BorderSize = 0;
            this.Submit_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Submit_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Submit_button.Location = new System.Drawing.Point(817, 513);
            this.Submit_button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Submit_button.Name = "Submit_button";
            this.Submit_button.Size = new System.Drawing.Size(537, 452);
            this.Submit_button.TabIndex = 7;
            this.Submit_button.UseVisualStyleBackColor = false;
            this.Submit_button.Click += new System.EventHandler(this.Submit_button_Click);
            // 
            // serviceCallID
            // 
            this.serviceCallID.AutoSize = true;
            this.serviceCallID.BackColor = System.Drawing.Color.Transparent;
            this.serviceCallID.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.serviceCallID.Location = new System.Drawing.Point(42, 126);
            this.serviceCallID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.serviceCallID.Name = "serviceCallID";
            this.serviceCallID.Size = new System.Drawing.Size(1013, 30);
            this.serviceCallID.TabIndex = 8;
            this.serviceCallID.Text = "If you want to write your review on a specific service call, choose the service c" +
    "all:";
            // 
            // serviceCall_combo_box
            // 
            this.serviceCall_combo_box.FormattingEnabled = true;
            this.serviceCall_combo_box.Location = new System.Drawing.Point(1093, 127);
            this.serviceCall_combo_box.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.serviceCall_combo_box.Name = "serviceCall_combo_box";
            this.serviceCall_combo_box.Size = new System.Drawing.Size(276, 28);
            this.serviceCall_combo_box.TabIndex = 9;
            this.serviceCall_combo_box.SelectedIndexChanged += new System.EventHandler(this.serviceCall_combo_box_SelectedIndexChanged);
            // 
            // go_back_button
            // 
            this.go_back_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.go_back_button.Location = new System.Drawing.Point(15, 831);
            this.go_back_button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.go_back_button.Name = "go_back_button";
            this.go_back_button.Size = new System.Drawing.Size(192, 60);
            this.go_back_button.TabIndex = 10;
            this.go_back_button.Text = "← Go back";
            this.go_back_button.UseVisualStyleBackColor = true;
            this.go_back_button.Click += new System.EventHandler(this.go_back_button_Click);
            // 
            // WriteAReview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1401, 922);
            this.Controls.Add(this.go_back_button);
            this.Controls.Add(this.serviceCall_combo_box);
            this.Controls.Add(this.serviceCallID);
            this.Controls.Add(this.Submit_button);
            this.Controls.Add(this.ratingComboBox);
            this.Controls.Add(this.description_text_box);
            this.Controls.Add(this.title_text_box);
            this.Controls.Add(this.rate);
            this.Controls.Add(this.description);
            this.Controls.Add(this.title);
            this.Controls.Add(this.write_a_review);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "WriteAReview";
            this.Text = "Write A Review";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.WriteAReview_FormClosed);
            this.Load += new System.EventHandler(this.WriteAReview_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label write_a_review;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label description;
        private System.Windows.Forms.Label rate;
        private System.Windows.Forms.TextBox title_text_box;
        private System.Windows.Forms.TextBox description_text_box;
        private System.Windows.Forms.ComboBox ratingComboBox;
        private System.Windows.Forms.Button Submit_button;
        private System.Windows.Forms.Label serviceCallID;
        private System.Windows.Forms.ComboBox serviceCall_combo_box;
        private System.Windows.Forms.Button go_back_button;
    }
}