namespace Inferno_A3_Logger
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.footerLabel = new System.Windows.Forms.Label();
            this.stopButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.bsport = new System.Windows.Forms.TextBox();
            this.zsport = new System.Windows.Forms.TextBox();
            this.bsLabel = new System.Windows.Forms.Label();
            this.zsLabel = new System.Windows.Forms.Label();
            this.msport = new System.Windows.Forms.TextBox();
            this.msLabel = new System.Windows.Forms.Label();
            this.headLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // footerLabel
            // 
            this.footerLabel.AutoSize = true;
            this.footerLabel.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.footerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.footerLabel.Location = new System.Drawing.Point(74, 233);
            this.footerLabel.Name = "footerLabel";
            this.footerLabel.Size = new System.Drawing.Size(162, 20);
            this.footerLabel.TabIndex = 14;
            this.footerLabel.Text = "~ Made by Karthik P ~";
            // 
            // stopButton
            // 
            this.stopButton.Enabled = false;
            this.stopButton.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stopButton.ForeColor = System.Drawing.Color.Red;
            this.stopButton.Location = new System.Drawing.Point(175, 182);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(143, 38);
            this.stopButton.TabIndex = 25;
            this.stopButton.Text = "Stop Logger";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("Segoe Script", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.ForeColor = System.Drawing.Color.Blue;
            this.startButton.Location = new System.Drawing.Point(12, 182);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(154, 37);
            this.startButton.TabIndex = 24;
            this.startButton.Text = "Start Logger";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // bsport
            // 
            this.bsport.Location = new System.Drawing.Point(146, 146);
            this.bsport.Name = "bsport";
            this.bsport.Size = new System.Drawing.Size(167, 20);
            this.bsport.TabIndex = 36;
            this.bsport.Text = "8002";
            this.bsport.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // zsport
            // 
            this.zsport.Location = new System.Drawing.Point(145, 103);
            this.zsport.Name = "zsport";
            this.zsport.Size = new System.Drawing.Size(167, 20);
            this.zsport.TabIndex = 35;
            this.zsport.Text = "8001";
            this.zsport.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bsLabel
            // 
            this.bsLabel.AutoSize = true;
            this.bsLabel.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bsLabel.ForeColor = System.Drawing.Color.Fuchsia;
            this.bsLabel.Location = new System.Drawing.Point(15, 137);
            this.bsLabel.Name = "bsLabel";
            this.bsLabel.Size = new System.Drawing.Size(113, 33);
            this.bsLabel.TabIndex = 34;
            this.bsLabel.Text = "BS Port :";
            // 
            // zsLabel
            // 
            this.zsLabel.AutoSize = true;
            this.zsLabel.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zsLabel.ForeColor = System.Drawing.Color.Fuchsia;
            this.zsLabel.Location = new System.Drawing.Point(16, 94);
            this.zsLabel.Name = "zsLabel";
            this.zsLabel.Size = new System.Drawing.Size(112, 33);
            this.zsLabel.TabIndex = 33;
            this.zsLabel.Text = "ZS Port :";
            // 
            // msport
            // 
            this.msport.Location = new System.Drawing.Point(145, 61);
            this.msport.Name = "msport";
            this.msport.Size = new System.Drawing.Size(167, 20);
            this.msport.TabIndex = 32;
            this.msport.Text = "8000";
            this.msport.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // msLabel
            // 
            this.msLabel.AutoSize = true;
            this.msLabel.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msLabel.ForeColor = System.Drawing.Color.Fuchsia;
            this.msLabel.Location = new System.Drawing.Point(12, 52);
            this.msLabel.Name = "msLabel";
            this.msLabel.Size = new System.Drawing.Size(116, 33);
            this.msLabel.TabIndex = 31;
            this.msLabel.Text = "MS Port :";
            // 
            // headLabel
            // 
            this.headLabel.AutoSize = true;
            this.headLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.headLabel.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headLabel.ForeColor = System.Drawing.Color.Olive;
            this.headLabel.Location = new System.Drawing.Point(51, 9);
            this.headLabel.Name = "headLabel";
            this.headLabel.Size = new System.Drawing.Size(213, 33);
            this.headLabel.TabIndex = 30;
            this.headLabel.Text = "Inferno A3 Logger";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 262);
            this.Controls.Add(this.bsport);
            this.Controls.Add(this.zsport);
            this.Controls.Add(this.bsLabel);
            this.Controls.Add(this.zsLabel);
            this.Controls.Add(this.msport);
            this.Controls.Add(this.msLabel);
            this.Controls.Add(this.headLabel);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.footerLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(347, 300);
            this.MinimumSize = new System.Drawing.Size(347, 300);
            this.Name = "Main";
            this.Text = "Inferno A3 Logger";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label footerLabel;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.TextBox bsport;
        private System.Windows.Forms.TextBox zsport;
        private System.Windows.Forms.Label bsLabel;
        private System.Windows.Forms.Label zsLabel;
        private System.Windows.Forms.TextBox msport;
        private System.Windows.Forms.Label msLabel;
        private System.Windows.Forms.Label headLabel;
    }
}

