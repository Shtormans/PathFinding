
namespace PathFinding
{
    partial class PathFinder
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
            this.borderButton = new System.Windows.Forms.Button();
            this.startPointButton = new System.Windows.Forms.Button();
            this.endPointButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.rubberButton = new System.Windows.Forms.Button();
            this.changeConfigurationsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // borderButton
            // 
            this.borderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.borderButton.Location = new System.Drawing.Point(131, 13);
            this.borderButton.Name = "borderButton";
            this.borderButton.Size = new System.Drawing.Size(60, 23);
            this.borderButton.TabIndex = 0;
            this.borderButton.Text = "border";
            this.borderButton.UseVisualStyleBackColor = true;
            this.borderButton.Click += new System.EventHandler(this.BorderButton_Click);
            // 
            // startPointButton
            // 
            this.startPointButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startPointButton.Location = new System.Drawing.Point(224, 13);
            this.startPointButton.Name = "startPointButton";
            this.startPointButton.Size = new System.Drawing.Size(60, 23);
            this.startPointButton.TabIndex = 1;
            this.startPointButton.Text = "start";
            this.startPointButton.UseVisualStyleBackColor = true;
            this.startPointButton.Click += new System.EventHandler(this.StarPointButton_Click);
            // 
            // endPointButton
            // 
            this.endPointButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.endPointButton.Location = new System.Drawing.Point(316, 13);
            this.endPointButton.Name = "endPointButton";
            this.endPointButton.Size = new System.Drawing.Size(60, 23);
            this.endPointButton.TabIndex = 2;
            this.endPointButton.Text = "end";
            this.endPointButton.UseVisualStyleBackColor = true;
            this.endPointButton.Click += new System.EventHandler(this.EndPointButton_Click);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(407, 13);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(40, 37);
            this.startButton.TabIndex = 3;
            this.startButton.Text = ">";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearButton.Location = new System.Drawing.Point(48, 58);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(60, 23);
            this.clearButton.TabIndex = 4;
            this.clearButton.Text = "clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // rubberButton
            // 
            this.rubberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rubberButton.Location = new System.Drawing.Point(48, 12);
            this.rubberButton.Name = "rubberButton";
            this.rubberButton.Size = new System.Drawing.Size(60, 23);
            this.rubberButton.TabIndex = 5;
            this.rubberButton.Text = "rubber";
            this.rubberButton.UseVisualStyleBackColor = true;
            this.rubberButton.Click += new System.EventHandler(this.Button2_Click);
            // 
            // changeConfigurationsButton
            // 
            this.changeConfigurationsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeConfigurationsButton.Location = new System.Drawing.Point(131, 58);
            this.changeConfigurationsButton.Name = "changeConfigurationsButton";
            this.changeConfigurationsButton.Size = new System.Drawing.Size(124, 23);
            this.changeConfigurationsButton.TabIndex = 6;
            this.changeConfigurationsButton.Text = "change configurations";
            this.changeConfigurationsButton.UseVisualStyleBackColor = true;
            this.changeConfigurationsButton.Click += new System.EventHandler(this.ChangeConfigurationsButton_Click);
            // 
            // PathFinder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.changeConfigurationsButton);
            this.Controls.Add(this.rubberButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.endPointButton);
            this.Controls.Add(this.startPointButton);
            this.Controls.Add(this.borderButton);
            this.Name = "PathFinder";
            this.Text = "PathFinder";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PathFinder_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button borderButton;
        private System.Windows.Forms.Button startPointButton;
        private System.Windows.Forms.Button endPointButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button rubberButton;
        private System.Windows.Forms.Button changeConfigurationsButton;
    }
}