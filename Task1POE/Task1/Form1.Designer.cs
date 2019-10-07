namespace Task1
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
            this.components = new System.ComponentModel.Container();
            this.strtBtn1 = new System.Windows.Forms.Button();
            this.PSBtn1 = new System.Windows.Forms.Button();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // strtBtn1
            // 
            this.strtBtn1.Location = new System.Drawing.Point(664, 330);
            this.strtBtn1.Name = "strtBtn1";
            this.strtBtn1.Size = new System.Drawing.Size(75, 23);
            this.strtBtn1.TabIndex = 0;
            this.strtBtn1.Text = "Strat";
            this.strtBtn1.UseVisualStyleBackColor = true;
            this.strtBtn1.Click += new System.EventHandler(this.StrtBtn1_Click);
            // 
            // PSBtn1
            // 
            this.PSBtn1.Location = new System.Drawing.Point(664, 359);
            this.PSBtn1.Name = "PSBtn1";
            this.PSBtn1.Size = new System.Drawing.Size(75, 23);
            this.PSBtn1.TabIndex = 1;
            this.PSBtn1.Text = "Pause";
            this.PSBtn1.UseVisualStyleBackColor = true;
            this.PSBtn1.Click += new System.EventHandler(this.PSBtn1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(606, 417);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.PSBtn1);
            this.Controls.Add(this.strtBtn1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button strtBtn1;
        private System.Windows.Forms.Button PSBtn1;
        private System.Windows.Forms.Timer Timer1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

