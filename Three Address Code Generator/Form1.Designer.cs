namespace Three_Address_Code_Generator
{
    partial class Form1
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
            this.ExpressionText = new System.Windows.Forms.TextBox();
            this.Expression = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.OutputText = new System.Windows.Forms.TextBox();
            this.Output = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ExpressionText
            // 
            this.ExpressionText.Location = new System.Drawing.Point(287, 147);
            this.ExpressionText.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.ExpressionText.Name = "ExpressionText";
            this.ExpressionText.Size = new System.Drawing.Size(681, 30);
            this.ExpressionText.TabIndex = 0;
            // 
            // Expression
            // 
            this.Expression.AutoSize = true;
            this.Expression.BackColor = System.Drawing.Color.White;
            this.Expression.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Expression.Image = global::Three_Address_Code_Generator.Properties.Resources.download;
            this.Expression.Location = new System.Drawing.Point(66, 150);
            this.Expression.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Expression.Name = "Expression";
            this.Expression.Size = new System.Drawing.Size(198, 26);
            this.Expression.TabIndex = 1;
            this.Expression.Text = "Enter Expression:";
            this.Expression.Click += new System.EventHandler(this.label1_Click);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Title.Location = new System.Drawing.Point(180, 49);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(675, 43);
            this.Title.TabIndex = 2;
            this.Title.Text = "THREE ADRESS CODE GENERATOR";
            // 
            // OutputText
            // 
            this.OutputText.Location = new System.Drawing.Point(287, 288);
            this.OutputText.Multiline = true;
            this.OutputText.Name = "OutputText";
            this.OutputText.Size = new System.Drawing.Size(681, 321);
            this.OutputText.TabIndex = 3;
            // 
            // Output
            // 
            this.Output.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Output.BackgroundImage = global::Three_Address_Code_Generator.Properties.Resources.download;
            this.Output.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Output.Location = new System.Drawing.Point(62, 230);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(159, 38);
            this.Output.TabIndex = 4;
            this.Output.Text = "Output";
            this.Output.UseVisualStyleBackColor = false;
            this.Output.Click += new System.EventHandler(this.Output_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1053, 665);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.OutputText);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.Expression);
            this.Controls.Add(this.ExpressionText);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "14-15-18";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ExpressionText;
        private System.Windows.Forms.Label Expression;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.TextBox OutputText;
        private System.Windows.Forms.Button Output;
    }
}

