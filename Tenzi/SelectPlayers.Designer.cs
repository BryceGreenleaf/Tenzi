namespace Tenzi
{
    partial class SelectPlayers
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_2players = new System.Windows.Forms.Button();
            this.btn_3players = new System.Windows.Forms.Button();
            this.btn_4players = new System.Windows.Forms.Button();
            this.btn_5players = new System.Windows.Forms.Button();
            this.btn_6players = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Helvetica", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(134, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(318, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select The Amount Of Players";
            // 
            // btn_2players
            // 
            this.btn_2players.Font = new System.Drawing.Font("Helvetica", 15.75F, System.Drawing.FontStyle.Bold);
            this.btn_2players.Location = new System.Drawing.Point(15, 106);
            this.btn_2players.Name = "btn_2players";
            this.btn_2players.Size = new System.Drawing.Size(113, 41);
            this.btn_2players.TabIndex = 1;
            this.btn_2players.Text = "2 Players";
            this.btn_2players.UseVisualStyleBackColor = true;
            this.btn_2players.Click += new System.EventHandler(this.btn_2players_Click);
            // 
            // btn_3players
            // 
            this.btn_3players.Font = new System.Drawing.Font("Helvetica", 15.75F, System.Drawing.FontStyle.Bold);
            this.btn_3players.Location = new System.Drawing.Point(138, 106);
            this.btn_3players.Name = "btn_3players";
            this.btn_3players.Size = new System.Drawing.Size(113, 41);
            this.btn_3players.TabIndex = 2;
            this.btn_3players.Text = "3 Players";
            this.btn_3players.UseVisualStyleBackColor = true;
            // 
            // btn_4players
            // 
            this.btn_4players.Font = new System.Drawing.Font("Helvetica", 15.75F, System.Drawing.FontStyle.Bold);
            this.btn_4players.Location = new System.Drawing.Point(261, 106);
            this.btn_4players.Name = "btn_4players";
            this.btn_4players.Size = new System.Drawing.Size(113, 41);
            this.btn_4players.TabIndex = 3;
            this.btn_4players.Text = "4 Players";
            this.btn_4players.UseVisualStyleBackColor = true;
            // 
            // btn_5players
            // 
            this.btn_5players.Font = new System.Drawing.Font("Helvetica", 15.75F, System.Drawing.FontStyle.Bold);
            this.btn_5players.Location = new System.Drawing.Point(384, 106);
            this.btn_5players.Name = "btn_5players";
            this.btn_5players.Size = new System.Drawing.Size(113, 41);
            this.btn_5players.TabIndex = 4;
            this.btn_5players.Text = "5 Players";
            this.btn_5players.UseVisualStyleBackColor = true;
            // 
            // btn_6players
            // 
            this.btn_6players.Font = new System.Drawing.Font("Helvetica", 15.75F, System.Drawing.FontStyle.Bold);
            this.btn_6players.Location = new System.Drawing.Point(503, 106);
            this.btn_6players.Name = "btn_6players";
            this.btn_6players.Size = new System.Drawing.Size(113, 41);
            this.btn_6players.TabIndex = 5;
            this.btn_6players.Text = "6 Players";
            this.btn_6players.UseVisualStyleBackColor = true;
            // 
            // btn_close
            // 
            this.btn_close.Font = new System.Drawing.Font("Helvetica", 15.75F, System.Drawing.FontStyle.Bold);
            this.btn_close.Location = new System.Drawing.Point(503, 349);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(113, 41);
            this.btn_close.TabIndex = 6;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_back
            // 
            this.btn_back.Font = new System.Drawing.Font("Helvetica", 15.75F, System.Drawing.FontStyle.Bold);
            this.btn_back.Location = new System.Drawing.Point(15, 349);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(113, 41);
            this.btn_back.TabIndex = 7;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // SelectPlayers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 402);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_6players);
            this.Controls.Add(this.btn_5players);
            this.Controls.Add(this.btn_4players);
            this.Controls.Add(this.btn_3players);
            this.Controls.Add(this.btn_2players);
            this.Controls.Add(this.label1);
            this.Name = "SelectPlayers";
            this.Text = "Select Players";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_2players;
        private System.Windows.Forms.Button btn_3players;
        private System.Windows.Forms.Button btn_4players;
        private System.Windows.Forms.Button btn_5players;
        private System.Windows.Forms.Button btn_6players;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_back;
    }
}