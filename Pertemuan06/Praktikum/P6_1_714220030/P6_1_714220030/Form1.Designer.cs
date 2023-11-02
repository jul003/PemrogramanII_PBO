namespace P6_1_714220030
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
            this.vbButton = new System.Windows.Forms.Button();
            this.cButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // vbButton
            // 
            this.vbButton.BackColor = System.Drawing.Color.White;
            this.vbButton.ForeColor = System.Drawing.Color.Green;
            this.vbButton.Location = new System.Drawing.Point(96, 89);
            this.vbButton.Name = "vbButton";
            this.vbButton.Size = new System.Drawing.Size(159, 38);
            this.vbButton.TabIndex = 0;
            this.vbButton.Text = "Visual Basic ";
            this.vbButton.UseVisualStyleBackColor = false;
            this.vbButton.Click += new System.EventHandler(this.button1_Click);
            this.vbButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this.vbButton_MouseMove);
            // 
            // cButton
            // 
            this.cButton.ForeColor = System.Drawing.Color.Red;
            this.cButton.Location = new System.Drawing.Point(434, 89);
            this.cButton.Name = "cButton";
            this.cButton.Size = new System.Drawing.Size(148, 38);
            this.cButton.TabIndex = 1;
            this.cButton.Text = "C#";
            this.cButton.UseVisualStyleBackColor = true;
            this.cButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(96, 367);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(109, 32);
            this.closeButton.TabIndex = 2;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(91, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(584, 26);
            this.label1.TabIndex = 3;
            this.label1.Text = "Which do you think is Better , Visual Basic or C# ? ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.cButton);
            this.Controls.Add(this.vbButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button vbButton;
        private System.Windows.Forms.Button cButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label label1;
    }
}

