namespace nituz_project_23
{
    partial class SubmitSelfEvaluation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
        /// Required method for Designer support.
        /// Do not modify the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SubmitSelfEvaluation));
            this.SSEEvaluationPros = new System.Windows.Forms.TextBox();
            this.SSEEvaluationCons = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SSESubmit = new System.Windows.Forms.Button();
            this.serviceCall_combo_box = new System.Windows.Forms.ComboBox();
            this.go_back_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SSEEvaluationPros
            // 
            this.SSEEvaluationPros.Location = new System.Drawing.Point(368, 152);
            this.SSEEvaluationPros.Multiline = true;
            this.SSEEvaluationPros.Name = "SSEEvaluationPros";
            this.SSEEvaluationPros.Size = new System.Drawing.Size(300, 126);
            this.SSEEvaluationPros.TabIndex = 1;
            this.SSEEvaluationPros.TextChanged += new System.EventHandler(this.SSEEvaluationPros_TextChanged);
            // 
            // SSEEvaluationCons
            // 
            this.SSEEvaluationCons.Location = new System.Drawing.Point(368, 337);
            this.SSEEvaluationCons.Multiline = true;
            this.SSEEvaluationCons.Name = "SSEEvaluationCons";
            this.SSEEvaluationCons.Size = new System.Drawing.Size(300, 109);
            this.SSEEvaluationCons.TabIndex = 2;
            this.SSEEvaluationCons.TextChanged += new System.EventHandler(this.SSEEvaluationCons_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(68, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "Insert Service Call ID:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(68, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 30);
            this.label2.TabIndex = 4;
            this.label2.Text = "Evaluation Pros:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(68, 337);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(222, 30);
            this.label3.TabIndex = 5;
            this.label3.Text = "Evaluation Cons:";
            // 
            // SSESubmit
            // 
            this.SSESubmit.BackColor = System.Drawing.Color.Transparent;
            this.SSESubmit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SSESubmit.BackgroundImage")));
            this.SSESubmit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SSESubmit.FlatAppearance.BorderSize = 0;
            this.SSESubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SSESubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SSESubmit.Location = new System.Drawing.Point(288, 452);
            this.SSESubmit.Name = "SSESubmit";
            this.SSESubmit.Size = new System.Drawing.Size(378, 406);
            this.SSESubmit.TabIndex = 6;
            this.SSESubmit.UseVisualStyleBackColor = false;
            this.SSESubmit.Click += new System.EventHandler(this.SSESubmit_Click);
            // 
            // serviceCall_combo_box
            // 
            this.serviceCall_combo_box.FormattingEnabled = true;
            this.serviceCall_combo_box.Location = new System.Drawing.Point(368, 74);
            this.serviceCall_combo_box.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.serviceCall_combo_box.Name = "serviceCall_combo_box";
            this.serviceCall_combo_box.Size = new System.Drawing.Size(298, 28);
            this.serviceCall_combo_box.TabIndex = 7;
            this.serviceCall_combo_box.SelectedIndexChanged += new System.EventHandler(this.serviceCall_combo_box_SelectedIndexChanged_1);
            // 
            // go_back_button
            // 
            this.go_back_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.go_back_button.Location = new System.Drawing.Point(21, 791);
            this.go_back_button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.go_back_button.Name = "go_back_button";
            this.go_back_button.Size = new System.Drawing.Size(138, 55);
            this.go_back_button.TabIndex = 8;
            this.go_back_button.Text = "← Go back";
            this.go_back_button.UseVisualStyleBackColor = true;
            this.go_back_button.Click += new System.EventHandler(this.go_back_button_Click);
            // 
            // SubmitSelfEvaluation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::nituz_project_23.Properties.Resources.רקע_עץ_עמוק;
            this.ClientSize = new System.Drawing.Size(772, 865);
            this.Controls.Add(this.go_back_button);
            this.Controls.Add(this.serviceCall_combo_box);
            this.Controls.Add(this.SSESubmit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SSEEvaluationCons);
            this.Controls.Add(this.SSEEvaluationPros);
            this.Name = "SubmitSelfEvaluation";
            this.Text = "Submit Self Evaluation";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SubmitSelfEvaluation_FormClosed);
            this.Load += new System.EventHandler(this.SubmitSelfEvaluation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox SSEEvaluationPros;
        private System.Windows.Forms.TextBox SSEEvaluationCons;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button SSESubmit;
        private System.Windows.Forms.ComboBox serviceCall_combo_box;
        private System.Windows.Forms.Button go_back_button;
    }
}

