
namespace young_players_project_trial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.similar_players_button = new System.Windows.Forms.Button();
            this.specific_player_button = new System.Windows.Forms.Button();
            this.add_player_button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.home_exit_button = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.MidnightBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(776, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to Felixified Scouting Network";
            // 
            // similar_players_button
            // 
            this.similar_players_button.Image = ((System.Drawing.Image)(resources.GetObject("similar_players_button.Image")));
            this.similar_players_button.Location = new System.Drawing.Point(-9, 7);
            this.similar_players_button.Name = "similar_players_button";
            this.similar_players_button.Size = new System.Drawing.Size(243, 193);
            this.similar_players_button.TabIndex = 2;
            this.similar_players_button.Text = "SEARCH SIMILAR PLAYERS";
            this.similar_players_button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.similar_players_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.similar_players_button.UseVisualStyleBackColor = true;
            this.similar_players_button.Click += new System.EventHandler(this.similar_players_button_Click);
            // 
            // specific_player_button
            // 
            this.specific_player_button.Image = ((System.Drawing.Image)(resources.GetObject("specific_player_button.Image")));
            this.specific_player_button.Location = new System.Drawing.Point(474, 7);
            this.specific_player_button.Name = "specific_player_button";
            this.specific_player_button.Size = new System.Drawing.Size(247, 193);
            this.specific_player_button.TabIndex = 3;
            this.specific_player_button.Text = "SEARCH SPECIFIC PLAYER";
            this.specific_player_button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.specific_player_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.specific_player_button.UseVisualStyleBackColor = true;
            this.specific_player_button.Click += new System.EventHandler(this.specific_player_button_Click);
            // 
            // add_player_button
            // 
            this.add_player_button.Image = ((System.Drawing.Image)(resources.GetObject("add_player_button.Image")));
            this.add_player_button.Location = new System.Drawing.Point(228, 7);
            this.add_player_button.Name = "add_player_button";
            this.add_player_button.Size = new System.Drawing.Size(249, 190);
            this.add_player_button.TabIndex = 4;
            this.add_player_button.Text = "ADD NEW PLAYER";
            this.add_player_button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.add_player_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.add_player_button.UseVisualStyleBackColor = true;
            this.add_player_button.Click += new System.EventHandler(this.add_player_button_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.similar_players_button);
            this.panel1.Controls.Add(this.add_player_button);
            this.panel1.Controls.Add(this.specific_player_button);
            this.panel1.Location = new System.Drawing.Point(21, 590);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(724, 200);
            this.panel1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(21, 108);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(554, 476);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // home_exit_button
            // 
            this.home_exit_button.Image = ((System.Drawing.Image)(resources.GetObject("home_exit_button.Image")));
            this.home_exit_button.Location = new System.Drawing.Point(739, 602);
            this.home_exit_button.Name = "home_exit_button";
            this.home_exit_button.Size = new System.Drawing.Size(204, 185);
            this.home_exit_button.TabIndex = 8;
            this.home_exit_button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.home_exit_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.home_exit_button.UseVisualStyleBackColor = true;
            this.home_exit_button.Click += new System.EventHandler(this.home_exit_button_Click);
            this.home_exit_button.MouseLeave += new System.EventHandler(this.home_exit_button_MouseLeave);
            this.home_exit_button.MouseHover += new System.EventHandler(this.home_exit_button_MouseHover);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(948, 802);
            this.Controls.Add(this.home_exit_button);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button similar_players_button;
        private System.Windows.Forms.Button specific_player_button;
        private System.Windows.Forms.Button add_player_button;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button home_exit_button;
    }
}

