namespace day14_
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
            this.lsttest = new System.Windows.Forms.ListView();
            this.buttest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lsttest
            // 
            this.lsttest.HideSelection = false;
            this.lsttest.Location = new System.Drawing.Point(50, 35);
            this.lsttest.Name = "lsttest";
            this.lsttest.Size = new System.Drawing.Size(183, 287);
            this.lsttest.TabIndex = 0;
            this.lsttest.UseCompatibleStateImageBehavior = false;
            // 
            // buttest
            // 
            this.buttest.Location = new System.Drawing.Point(256, 44);
            this.buttest.Name = "buttest";
            this.buttest.Size = new System.Drawing.Size(75, 23);
            this.buttest.TabIndex = 1;
            this.buttest.Text = "push me";
            this.buttest.UseVisualStyleBackColor = true;
            this.buttest.Click += new System.EventHandler(this.buttest_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttest);
            this.Controls.Add(this.lsttest);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lsttest;
        private System.Windows.Forms.Button buttest;
    }
}

