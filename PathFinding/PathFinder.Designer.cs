
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
            this.starPointButton = new System.Windows.Forms.Button();
            this.endPointButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // borderButton
            // 
            this.borderButton.Location = new System.Drawing.Point(148, 13);
            this.borderButton.Name = "borderButton";
            this.borderButton.Size = new System.Drawing.Size(23, 23);
            this.borderButton.TabIndex = 0;
            this.borderButton.Text = "button1";
            this.borderButton.UseVisualStyleBackColor = true;
            this.borderButton.Click += new System.EventHandler(this.BorderButton_Click);
            // 
            // starPointButton
            // 
            this.starPointButton.Location = new System.Drawing.Point(177, 13);
            this.starPointButton.Name = "starPointButton";
            this.starPointButton.Size = new System.Drawing.Size(23, 23);
            this.starPointButton.TabIndex = 1;
            this.starPointButton.Text = "button2";
            this.starPointButton.UseVisualStyleBackColor = true;
            this.starPointButton.Click += new System.EventHandler(this.StarPointButton_Click);
            // 
            // endPointButton
            // 
            this.endPointButton.Location = new System.Drawing.Point(206, 13);
            this.endPointButton.Name = "endPointButton";
            this.endPointButton.Size = new System.Drawing.Size(23, 23);
            this.endPointButton.TabIndex = 2;
            this.endPointButton.Text = "button3";
            this.endPointButton.UseVisualStyleBackColor = true;
            this.endPointButton.Click += new System.EventHandler(this.EndPointButton_Click);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(272, 13);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(40, 37);
            this.startButton.TabIndex = 3;
            this.startButton.Text = ">";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // PathFinder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.endPointButton);
            this.Controls.Add(this.starPointButton);
            this.Controls.Add(this.borderButton);
            this.Name = "PathFinder";
            this.Text = "PathFinder";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PathFinder_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button borderButton;
        private System.Windows.Forms.Button starPointButton;
        private System.Windows.Forms.Button endPointButton;
        private System.Windows.Forms.Button startButton;
    }
}