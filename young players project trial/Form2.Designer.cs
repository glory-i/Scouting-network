
namespace young_players_project_trial
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.search_first_name_textbox = new System.Windows.Forms.TextBox();
            this.search_last_name_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.back_search_button = new System.Windows.Forms.Button();
            this.specific_player_button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.real_search_exit_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(192, 256);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(348, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "ENTER PLAYER FIRST NAME: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // search_first_name_textbox
            // 
            this.search_first_name_textbox.Location = new System.Drawing.Point(575, 253);
            this.search_first_name_textbox.Name = "search_first_name_textbox";
            this.search_first_name_textbox.Size = new System.Drawing.Size(202, 31);
            this.search_first_name_textbox.TabIndex = 1;
            this.search_first_name_textbox.TextChanged += new System.EventHandler(this.search_first_name_textbox_TextChanged);
            // 
            // search_last_name_textBox
            // 
            this.search_last_name_textBox.Location = new System.Drawing.Point(575, 346);
            this.search_last_name_textBox.Name = "search_last_name_textBox";
            this.search_last_name_textBox.Size = new System.Drawing.Size(202, 31);
            this.search_last_name_textBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(192, 333);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(341, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "ENTER PLAYER LAST NAME: ";
            // 
            // back_search_button
            // 
            this.back_search_button.BackColor = System.Drawing.Color.MintCream;
            this.back_search_button.Image = ((System.Drawing.Image)(resources.GetObject("back_search_button.Image")));
            this.back_search_button.Location = new System.Drawing.Point(66, 523);
            this.back_search_button.Name = "back_search_button";
            this.back_search_button.Size = new System.Drawing.Size(203, 155);
            this.back_search_button.TabIndex = 5;
            this.back_search_button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.back_search_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.back_search_button.UseVisualStyleBackColor = false;
            this.back_search_button.Click += new System.EventHandler(this.back_search_button_Click);
            // 
            // specific_player_button
            // 
            this.specific_player_button.BackColor = System.Drawing.Color.MintCream;
            this.specific_player_button.Image = ((System.Drawing.Image)(resources.GetObject("specific_player_button.Image")));
            this.specific_player_button.Location = new System.Drawing.Point(422, 521);
            this.specific_player_button.Name = "specific_player_button";
            this.specific_player_button.Size = new System.Drawing.Size(247, 169);
            this.specific_player_button.TabIndex = 6;
            this.specific_player_button.Text = "SEARCH SPECIFIC PLAYER";
            this.specific_player_button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.specific_player_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.specific_player_button.UseVisualStyleBackColor = false;
            this.specific_player_button.Click += new System.EventHandler(this.specific_player_button_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Info;
            this.label3.Location = new System.Drawing.Point(35, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(598, 42);
            this.label3.TabIndex = 8;
            this.label3.Text = "LOOKING FOR A YOUNG BALLER?....";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.LavenderBlush;
            this.label4.Location = new System.Drawing.Point(813, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(250, 31);
            this.label4.TabIndex = 9;
            this.label4.Text = ".....Look no Further.";
            // 
            // real_search_exit_button
            // 
            this.real_search_exit_button.BackColor = System.Drawing.Color.MintCream;
            this.real_search_exit_button.Image = ((System.Drawing.Image)(resources.GetObject("real_search_exit_button.Image")));
            this.real_search_exit_button.Location = new System.Drawing.Point(848, 521);
            this.real_search_exit_button.Name = "real_search_exit_button";
            this.real_search_exit_button.Size = new System.Drawing.Size(199, 157);
            this.real_search_exit_button.TabIndex = 7;
            this.real_search_exit_button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.real_search_exit_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.real_search_exit_button.UseVisualStyleBackColor = false;
            this.real_search_exit_button.Click += new System.EventHandler(this.search_exit_button_Click);
            this.real_search_exit_button.MouseLeave += new System.EventHandler(this.real_search_exit_button_MouseLeave);
            this.real_search_exit_button.MouseHover += new System.EventHandler(this.real_search_exit_button_MouseHover);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(1104, 724);
            this.Controls.Add(this.real_search_exit_button);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.specific_player_button);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.back_search_button);
            this.Controls.Add(this.search_last_name_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.search_first_name_textbox);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox search_first_name_textbox;
        private System.Windows.Forms.TextBox search_last_name_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button back_search_button;
        private System.Windows.Forms.Button specific_player_button;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button real_search_exit_button;
    }
}