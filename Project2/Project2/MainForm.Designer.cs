// File Prolog
// Name: charl_000
// CS 1400 Section 601
// Project: Project2
// Date: 9/17/2013 5:51:23 AM
// 
// I declare that the following code was written by me or provided 
// by the instructor for this project. I understand that copying source
// code from any other source constitutes cheating, and that I will receive
// a zero on this project if I am found in violation of this policy.
// ---------------------------------------------------------------------------
namespace Project2
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oldStartTimeLabel = new System.Windows.Forms.Label();
            this.oldEndTimeLabel = new System.Windows.Forms.Label();
            this.newArrivalTimeLabel = new System.Windows.Forms.Label();
            this.oldStartTimeTextBox = new System.Windows.Forms.TextBox();
            this.oldEndTimeTextBox = new System.Windows.Forms.TextBox();
            this.newArrivalTimeTextBox = new System.Windows.Forms.TextBox();
            this.calculateNewTimeButton = new System.Windows.Forms.Button();
            this.pressButtonLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(525, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitMenuItem,
            this.aboutMenuItem});
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitMenuItem.Text = "Exit";
            this.exitMenuItem.Click += new System.EventHandler(this.exitMenuItem_Click);
            // 
            // aboutMenuItem
            // 
            this.aboutMenuItem.Name = "aboutMenuItem";
            this.aboutMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutMenuItem.Text = "About";
            this.aboutMenuItem.Click += new System.EventHandler(this.aboutMenuItem_Click);
            // 
            // oldStartTimeLabel
            // 
            this.oldStartTimeLabel.AutoSize = true;
            this.oldStartTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oldStartTimeLabel.Location = new System.Drawing.Point(53, 65);
            this.oldStartTimeLabel.Name = "oldStartTimeLabel";
            this.oldStartTimeLabel.Size = new System.Drawing.Size(164, 20);
            this.oldStartTimeLabel.TabIndex = 1;
            this.oldStartTimeLabel.Text = "1. Enter old start time:";
            // 
            // oldEndTimeLabel
            // 
            this.oldEndTimeLabel.AutoSize = true;
            this.oldEndTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oldEndTimeLabel.Location = new System.Drawing.Point(59, 116);
            this.oldEndTimeLabel.Name = "oldEndTimeLabel";
            this.oldEndTimeLabel.Size = new System.Drawing.Size(159, 20);
            this.oldEndTimeLabel.TabIndex = 2;
            this.oldEndTimeLabel.Text = "2. Enter old end time:";
            // 
            // newArrivalTimeLabel
            // 
            this.newArrivalTimeLabel.AutoSize = true;
            this.newArrivalTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newArrivalTimeLabel.Location = new System.Drawing.Point(322, 206);
            this.newArrivalTimeLabel.Name = "newArrivalTimeLabel";
            this.newArrivalTimeLabel.Size = new System.Drawing.Size(142, 20);
            this.newArrivalTimeLabel.TabIndex = 3;
            this.newArrivalTimeLabel.Text = "4. New Arrival Time";
            // 
            // oldStartTimeTextBox
            // 
            this.oldStartTimeTextBox.Location = new System.Drawing.Point(314, 65);
            this.oldStartTimeTextBox.Name = "oldStartTimeTextBox";
            this.oldStartTimeTextBox.Size = new System.Drawing.Size(150, 20);
            this.oldStartTimeTextBox.TabIndex = 4;
            // 
            // oldEndTimeTextBox
            // 
            this.oldEndTimeTextBox.Location = new System.Drawing.Point(314, 116);
            this.oldEndTimeTextBox.Name = "oldEndTimeTextBox";
            this.oldEndTimeTextBox.Size = new System.Drawing.Size(150, 20);
            this.oldEndTimeTextBox.TabIndex = 5;
            // 
            // newArrivalTimeTextBox
            // 
            this.newArrivalTimeTextBox.Location = new System.Drawing.Point(314, 172);
            this.newArrivalTimeTextBox.Name = "newArrivalTimeTextBox";
            this.newArrivalTimeTextBox.Size = new System.Drawing.Size(150, 20);
            this.newArrivalTimeTextBox.TabIndex = 6;
            // 
            // calculateNewTimeButton
            // 
            this.calculateNewTimeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateNewTimeButton.Location = new System.Drawing.Point(114, 172);
            this.calculateNewTimeButton.Name = "calculateNewTimeButton";
            this.calculateNewTimeButton.Size = new System.Drawing.Size(104, 35);
            this.calculateNewTimeButton.TabIndex = 7;
            this.calculateNewTimeButton.Text = "Press me!";
            this.calculateNewTimeButton.UseVisualStyleBackColor = true;
            this.calculateNewTimeButton.Click += new System.EventHandler(this.calculateNewTimeButton_Click);
            // 
            // pressButtonLabel
            // 
            this.pressButtonLabel.AutoSize = true;
            this.pressButtonLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pressButtonLabel.Location = new System.Drawing.Point(110, 215);
            this.pressButtonLabel.Name = "pressButtonLabel";
            this.pressButtonLabel.Size = new System.Drawing.Size(122, 20);
            this.pressButtonLabel.TabIndex = 8;
            this.pressButtonLabel.Text = "3. Press Button.";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 274);
            this.Controls.Add(this.pressButtonLabel);
            this.Controls.Add(this.calculateNewTimeButton);
            this.Controls.Add(this.newArrivalTimeTextBox);
            this.Controls.Add(this.oldEndTimeTextBox);
            this.Controls.Add(this.oldStartTimeTextBox);
            this.Controls.Add(this.newArrivalTimeLabel);
            this.Controls.Add(this.oldEndTimeLabel);
            this.Controls.Add(this.oldStartTimeLabel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "CS 1400 Project 2";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutMenuItem;
        private System.Windows.Forms.Label oldStartTimeLabel;
        private System.Windows.Forms.Label oldEndTimeLabel;
        private System.Windows.Forms.Label newArrivalTimeLabel;
        private System.Windows.Forms.TextBox oldStartTimeTextBox;
        private System.Windows.Forms.TextBox oldEndTimeTextBox;
        private System.Windows.Forms.TextBox newArrivalTimeTextBox;
        private System.Windows.Forms.Button calculateNewTimeButton;
        private System.Windows.Forms.Label pressButtonLabel;
    }
}

