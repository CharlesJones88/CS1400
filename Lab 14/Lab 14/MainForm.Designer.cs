// File Prolog
// Name: charles
// CS 1400 Section 601
// Project: Lab 14
// Date: 10/15/2013 7:06:11 AM
// 
// I declare that the following code was written by me or provided 
// by the instructor for this project. I understand that copying source
// code from any other source constitutes cheating, and that I will receive
// a zero on this project if I am found in violation of this policy.
// ---------------------------------------------------------------------------
namespace Lab_14
{
    partial class MainForm
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
            this.standardShippingButton = new System.Windows.Forms.RadioButton();
            this.expressShippingButton = new System.Windows.Forms.RadioButton();
            this.sameDayButton = new System.Windows.Forms.RadioButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shippingMethodLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // standardShippingButton
            // 
            this.standardShippingButton.AutoSize = true;
            this.standardShippingButton.Location = new System.Drawing.Point(194, 148);
            this.standardShippingButton.Name = "standardShippingButton";
            this.standardShippingButton.Size = new System.Drawing.Size(124, 29);
            this.standardShippingButton.TabIndex = 0;
            this.standardShippingButton.TabStop = true;
            this.standardShippingButton.Text = "Standard";
            this.standardShippingButton.UseVisualStyleBackColor = true;
            this.standardShippingButton.CheckedChanged += new System.EventHandler(this.standardShipping);
            // 
            // expressShippingButton
            // 
            this.expressShippingButton.AutoSize = true;
            this.expressShippingButton.Location = new System.Drawing.Point(194, 202);
            this.expressShippingButton.Name = "expressShippingButton";
            this.expressShippingButton.Size = new System.Drawing.Size(115, 29);
            this.expressShippingButton.TabIndex = 1;
            this.expressShippingButton.TabStop = true;
            this.expressShippingButton.Text = "Express";
            this.expressShippingButton.UseVisualStyleBackColor = true;
            this.expressShippingButton.CheckedChanged += new System.EventHandler(this.expressShipping);
            // 
            // sameDayButton
            // 
            this.sameDayButton.AutoSize = true;
            this.sameDayButton.Location = new System.Drawing.Point(194, 254);
            this.sameDayButton.Name = "sameDayButton";
            this.sameDayButton.Size = new System.Drawing.Size(137, 29);
            this.sameDayButton.TabIndex = 2;
            this.sameDayButton.TabStop = true;
            this.sameDayButton.Text = "Same-Day";
            this.sameDayButton.UseVisualStyleBackColor = true;
            this.sameDayButton.CheckedChanged += new System.EventHandler(this.sameDayShipping);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(568, 40);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenu,
            this.aboutToolStripMenuItem});
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(64, 36);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // exitToolStripMenu
            // 
            this.exitToolStripMenu.Name = "exitToolStripMenu";
            this.exitToolStripMenu.Size = new System.Drawing.Size(155, 36);
            this.exitToolStripMenu.Text = "Exit";
            this.exitToolStripMenu.Click += new System.EventHandler(this.exitToolStripMenu_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(155, 36);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // shippingMethodLabel
            // 
            this.shippingMethodLabel.AutoSize = true;
            this.shippingMethodLabel.Location = new System.Drawing.Point(42, 82);
            this.shippingMethodLabel.Name = "shippingMethodLabel";
            this.shippingMethodLabel.Size = new System.Drawing.Size(311, 25);
            this.shippingMethodLabel.TabIndex = 4;
            this.shippingMethodLabel.Text = "Please select shipping method.";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 504);
            this.Controls.Add(this.shippingMethodLabel);
            this.Controls.Add(this.sameDayButton);
            this.Controls.Add(this.expressShippingButton);
            this.Controls.Add(this.standardShippingButton);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "MainForm";
            this.Text = "Lab 14";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton standardShippingButton;
        private System.Windows.Forms.RadioButton expressShippingButton;
        private System.Windows.Forms.RadioButton sameDayButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenu;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label shippingMethodLabel;
    }
}

