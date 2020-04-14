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
            this.OUTPUT = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.PrefixPostfix = new System.Windows.Forms.TextBox();
            this.GENERATE = new System.Windows.Forms.Button();
            this.INIT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ExpressionText
            // 
            this.ExpressionText.Location = new System.Drawing.Point(287, 85);
            this.ExpressionText.Margin = new System.Windows.Forms.Padding(5);
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
            this.Expression.Location = new System.Drawing.Point(46, 88);
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
            this.Title.Location = new System.Drawing.Point(175, 9);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(675, 43);
            this.Title.TabIndex = 2;
            this.Title.Text = "THREE ADRESS CODE GENERATOR";
            // 
            // OUTPUT
            // 
            this.OUTPUT.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.OUTPUT.BackgroundImage = global::Three_Address_Code_Generator.Properties.Resources.download;
            this.OUTPUT.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OUTPUT.Location = new System.Drawing.Point(559, 590);
            this.OUTPUT.Name = "OUTPUT";
            this.OUTPUT.Size = new System.Drawing.Size(159, 38);
            this.OUTPUT.TabIndex = 4;
            this.OUTPUT.Text = "OUTPUT";
            this.OUTPUT.UseVisualStyleBackColor = false;
            this.OUTPUT.Click += new System.EventHandler(this.Output_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.BackgroundImage = global::Three_Address_Code_Generator.Properties.Resources.download;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(809, 590);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 38);
            this.button1.TabIndex = 5;
            this.button1.Text = "CLEAR";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PrefixPostfix
            // 
            this.PrefixPostfix.Location = new System.Drawing.Point(51, 161);
            this.PrefixPostfix.Multiline = true;
            this.PrefixPostfix.Name = "PrefixPostfix";
            this.PrefixPostfix.Size = new System.Drawing.Size(917, 381);
            this.PrefixPostfix.TabIndex = 6;
            // 
            // GENERATE
            // 
            this.GENERATE.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.GENERATE.BackgroundImage = global::Three_Address_Code_Generator.Properties.Resources.download;
            this.GENERATE.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GENERATE.Location = new System.Drawing.Point(31, 590);
            this.GENERATE.Name = "GENERATE";
            this.GENERATE.Size = new System.Drawing.Size(159, 38);
            this.GENERATE.TabIndex = 10;
            this.GENERATE.Text = "GENERATE";
            this.GENERATE.UseVisualStyleBackColor = false;
            this.GENERATE.Click += new System.EventHandler(this.button2_Click);
            // 
            // INIT
            // 
            this.INIT.BackgroundImage = global::Three_Address_Code_Generator.Properties.Resources.download;
            this.INIT.Location = new System.Drawing.Point(287, 590);
            this.INIT.Name = "INIT";
            this.INIT.Size = new System.Drawing.Size(145, 38);
            this.INIT.TabIndex = 11;
            this.INIT.Text = "INIT";
            this.INIT.UseVisualStyleBackColor = true;
            this.INIT.Click += new System.EventHandler(this.INIT_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1026, 665);
            this.Controls.Add(this.INIT);
            this.Controls.Add(this.GENERATE);
            this.Controls.Add(this.PrefixPostfix);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.OUTPUT);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.Expression);
            this.Controls.Add(this.ExpressionText);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(5);
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
        private System.Windows.Forms.Button OUTPUT;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox PrefixPostfix;
        private System.Windows.Forms.Button GENERATE;
        private System.Windows.Forms.Button INIT;
    }
}

