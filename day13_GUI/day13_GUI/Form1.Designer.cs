namespace day13_GUI
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
            this.lblOutput = new System.Windows.Forms.Label();
            this.btnPushMe = new System.Windows.Forms.Button();
            this.fieldInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(28, 35);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(55, 13);
            this.lblOutput.TabIndex = 0;
            this.lblOutput.Text = "Demo text";
            this.lblOutput.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnPushMe
            // 
            this.btnPushMe.Location = new System.Drawing.Point(31, 72);
            this.btnPushMe.Name = "btnPushMe";
            this.btnPushMe.Size = new System.Drawing.Size(137, 74);
            this.btnPushMe.TabIndex = 1;
            this.btnPushMe.Text = "Spied šeit";
            this.btnPushMe.UseVisualStyleBackColor = true;
            this.btnPushMe.Click += new System.EventHandler(this.btnPushMe_Click);
            // 
            // fieldInput
            // 
            this.fieldInput.Location = new System.Drawing.Point(124, 35);
            this.fieldInput.Name = "fieldInput";
            this.fieldInput.Size = new System.Drawing.Size(100, 20);
            this.fieldInput.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.fieldInput);
            this.Controls.Add(this.btnPushMe);
            this.Controls.Add(this.lblOutput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Button btnPushMe;
        private System.Windows.Forms.TextBox fieldInput;
    }
}

