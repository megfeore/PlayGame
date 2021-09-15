
namespace PlayGame
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
            this.startButton = new System.Windows.Forms.Button();
            this.backgroundLabel = new System.Windows.Forms.Label();
            this.countdownLabel1 = new System.Windows.Forms.Label();
            this.countdownLabel2 = new System.Windows.Forms.Label();
            this.countdownLabel3 = new System.Windows.Forms.Label();
            this.goLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("Bauhaus 93", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.ForeColor = System.Drawing.Color.Red;
            this.startButton.Location = new System.Drawing.Point(218, 106);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(183, 109);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Play Game";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // backgroundLabel
            // 
            this.backgroundLabel.ForeColor = System.Drawing.Color.Red;
            this.backgroundLabel.Location = new System.Drawing.Point(-28, -37);
            this.backgroundLabel.Name = "backgroundLabel";
            this.backgroundLabel.Size = new System.Drawing.Size(668, 409);
            this.backgroundLabel.TabIndex = 1;
            this.backgroundLabel.Text = "label1";
            // 
            // countdownLabel1
            // 
            this.countdownLabel1.AutoSize = true;
            this.countdownLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countdownLabel1.ForeColor = System.Drawing.Color.White;
            this.countdownLabel1.Location = new System.Drawing.Point(159, 262);
            this.countdownLabel1.Name = "countdownLabel1";
            this.countdownLabel1.Size = new System.Drawing.Size(303, 33);
            this.countdownLabel1.TabIndex = 2;
            this.countdownLabel1.Text = "Game will start in: 3!";
            this.countdownLabel1.Visible = false;
            // 
            // countdownLabel2
            // 
            this.countdownLabel2.AutoSize = true;
            this.countdownLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countdownLabel2.ForeColor = System.Drawing.Color.White;
            this.countdownLabel2.Location = new System.Drawing.Point(159, 262);
            this.countdownLabel2.Name = "countdownLabel2";
            this.countdownLabel2.Size = new System.Drawing.Size(303, 33);
            this.countdownLabel2.TabIndex = 3;
            this.countdownLabel2.Text = "Game will start in: 2!";
            this.countdownLabel2.Visible = false;
            this.countdownLabel2.Click += new System.EventHandler(this.label1_Click);
            // 
            // countdownLabel3
            // 
            this.countdownLabel3.AutoSize = true;
            this.countdownLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countdownLabel3.ForeColor = System.Drawing.Color.White;
            this.countdownLabel3.Location = new System.Drawing.Point(159, 262);
            this.countdownLabel3.Name = "countdownLabel3";
            this.countdownLabel3.Size = new System.Drawing.Size(303, 33);
            this.countdownLabel3.TabIndex = 4;
            this.countdownLabel3.Text = "Game will start in: 1!";
            this.countdownLabel3.Visible = false;
            // 
            // goLabel
            // 
            this.goLabel.AutoSize = true;
            this.goLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goLabel.ForeColor = System.Drawing.Color.White;
            this.goLabel.Location = new System.Drawing.Point(269, 254);
            this.goLabel.Name = "goLabel";
            this.goLabel.Size = new System.Drawing.Size(89, 42);
            this.goLabel.TabIndex = 5;
            this.goLabel.Text = "GO!";
            this.goLabel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(621, 346);
            this.Controls.Add(this.goLabel);
            this.Controls.Add(this.countdownLabel3);
            this.Controls.Add(this.countdownLabel2);
            this.Controls.Add(this.countdownLabel1);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.backgroundLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Label backgroundLabel;
        private System.Windows.Forms.Label countdownLabel1;
        private System.Windows.Forms.Label countdownLabel2;
        private System.Windows.Forms.Label countdownLabel3;
        private System.Windows.Forms.Label goLabel;
    }
}

