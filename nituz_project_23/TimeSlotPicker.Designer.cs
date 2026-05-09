namespace nituz_project_23
{
    partial class TimeSlotPicker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimeSlotPicker));
            this.label1 = new System.Windows.Forms.Label();
            this.TSP_TimeSlotCombo = new System.Windows.Forms.ComboBox();
            this.TSPScheduleButton = new System.Windows.Forms.Button();
            this.TSP_BackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(116, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(373, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose the desired time slot:";
            // 
            // TSP_TimeSlotCombo
            // 
            this.TSP_TimeSlotCombo.FormattingEnabled = true;
            this.TSP_TimeSlotCombo.Location = new System.Drawing.Point(497, 28);
            this.TSP_TimeSlotCombo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TSP_TimeSlotCombo.Name = "TSP_TimeSlotCombo";
            this.TSP_TimeSlotCombo.Size = new System.Drawing.Size(381, 28);
            this.TSP_TimeSlotCombo.TabIndex = 1;
            this.TSP_TimeSlotCombo.SelectedIndexChanged += new System.EventHandler(this.TSP_TimeSlotCombo_SelectedIndexChanged);
            // 
            // TSPScheduleButton
            // 
            this.TSPScheduleButton.BackColor = System.Drawing.Color.Transparent;
            this.TSPScheduleButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TSPScheduleButton.BackgroundImage")));
            this.TSPScheduleButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.TSPScheduleButton.FlatAppearance.BorderSize = 0;
            this.TSPScheduleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TSPScheduleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TSPScheduleButton.Location = new System.Drawing.Point(327, 103);
            this.TSPScheduleButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TSPScheduleButton.Name = "TSPScheduleButton";
            this.TSPScheduleButton.Size = new System.Drawing.Size(392, 351);
            this.TSPScheduleButton.TabIndex = 2;
            this.TSPScheduleButton.UseVisualStyleBackColor = false;
            this.TSPScheduleButton.Click += new System.EventHandler(this.TSPScheduleButton_Click);
            // 
            // TSP_BackButton
            // 
            this.TSP_BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TSP_BackButton.Location = new System.Drawing.Point(27, 378);
            this.TSP_BackButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TSP_BackButton.Name = "TSP_BackButton";
            this.TSP_BackButton.Size = new System.Drawing.Size(160, 62);
            this.TSP_BackButton.TabIndex = 3;
            this.TSP_BackButton.Text = "← Go back";
            this.TSP_BackButton.UseVisualStyleBackColor = true;
            this.TSP_BackButton.Click += new System.EventHandler(this.TSP_BackButton_Click);
            // 
            // TimeSlotPicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1004, 472);
            this.Controls.Add(this.TSP_BackButton);
            this.Controls.Add(this.TSPScheduleButton);
            this.Controls.Add(this.TSP_TimeSlotCombo);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "TimeSlotPicker";
            this.Tag = "Time Slot Picker";
            this.Text = "Time Slot Picker";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TimeSlotPicker_FormClosed);
            this.Load += new System.EventHandler(this.TimeSlotPicker_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox TSP_TimeSlotCombo;
        private System.Windows.Forms.Button TSPScheduleButton;
        private System.Windows.Forms.Button TSP_BackButton;
    }
}