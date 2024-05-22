namespace ConnectFour
{
    partial class background
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
            this.title = new System.Windows.Forms.Label();
            this.startBtn = new System.Windows.Forms.Button();
            this.startBg = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.startBg)).BeginInit();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Verdana", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(225, 181);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(319, 48);
            this.title.TabIndex = 0;
            this.title.Text = "Connect Four";
            this.title.Click += new System.EventHandler(this.title_Click);
            // 
            // startBtn
            // 
            this.startBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startBtn.Location = new System.Drawing.Point(343, 291);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(107, 40);
            this.startBtn.TabIndex = 1;
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.start_Click);
            // 
            // startBg
            // 
            this.startBg.Location = new System.Drawing.Point(0, 0);
            this.startBg.Name = "startBg";
            this.startBg.Size = new System.Drawing.Size(801, 457);
            this.startBg.TabIndex = 2;
            this.startBg.TabStop = false;
            this.startBg.Click += new System.EventHandler(this.startBg_Click);
            // 
            // background
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.title);
            this.Controls.Add(this.startBg);
            this.Name = "background";
            this.Text = "Connect Four";
            this.Load += new System.EventHandler(this.background_Load);
            ((System.ComponentModel.ISupportInitialize)(this.startBg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.PictureBox startBg;
    }
}

