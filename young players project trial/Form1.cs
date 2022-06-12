using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace young_players_project_trial
{
    public partial class Form1 : Form
    {
        Form2 my_form_2 = new Form2();
        Form3 my_form_3 = new Form3();
        Form4 my_form_4 = new Form4();
        public Form1()
        {
            InitializeComponent();
        }

        private void add_player_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            my_form_3.Show();
            

        }

        private void specific_player_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            my_form_2.Show();
        }

        private void similar_players_button_Click(object sender, EventArgs e)
        {
            this.Hide();
            my_form_4.Show();

        }

        private void home_exit_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void home_exit_button_MouseHover(object sender, EventArgs e)
        {
            home_exit_button.BackColor = Color.Red;
        }

        private void home_exit_button_MouseLeave(object sender, EventArgs e)
        {
            home_exit_button.BackColor = Color.LightGray;
        }
    }
}
