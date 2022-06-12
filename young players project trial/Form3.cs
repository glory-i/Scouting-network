using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace young_players_project_trial
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void defending_textbox_TextChanged(object sender, EventArgs e)
        {
            //
        }

        private void search_exit_button_MouseHover(object sender, EventArgs e)
        {
            
            add_exit_button.BackColor = Color.Red;
            
        }

        private void Form3_MouseLeave(object sender, EventArgs e)
        {
            //
        }

        private void search_exit_button_MouseLeave(object sender, EventArgs e)
        {
            add_exit_button.BackColor = Color.DodgerBlue;
        }

        private void back_search_button_Click(object sender, EventArgs e)
        {
            //
        }

        private void back_add_player_button_Click(object sender, EventArgs e)
        {
            Form1 my_form_1 = new Form1();
            this.Hide();
            my_form_1.Show();
        }

        private void search_exit_button_Click(object sender, EventArgs e)
        {
            //
        }

        private void add_exit_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tableLayoutPanel1_Click(object sender, EventArgs e)
        {
            //
        }

        private void add_player_to_database_button_Click(object sender, EventArgs e)
        {
            string fname = first_name_textbox.Text;
            string lname = last_name_textbox.Text;
            int age = Convert.ToInt32(age_textbox.Text);
            string position = position_comboBox.SelectedItem.ToString();
            int pace = Convert.ToInt32(pace_textbox.Text);
            int passing = Convert.ToInt32(passing_textbox.Text);
            int shooting = Convert.ToInt32(shooting_textbox.Text);
            int dribbling = Convert.ToInt32(dribbling_textbox.Text);
            int defending = Convert.ToInt32(defending_textbox.Text);
            int overall = Convert.ToInt32(overall_textbox.Text);
            double value = Convert.ToDouble(estimated_value_textBox.Text);




            string connection_string = "datasource=127.0.0.1;port=3306;username=root;password='';database=scouting;SSL MODE=None";
            string query = "INSERT INTO players VALUES('','" + fname + "','" + lname + "','" + position + "','" + age + "','" + value + "','" + pace + "','" + passing + "','" + shooting + "','" + dribbling + "','" + defending + "','" + overall + "')";

            MySqlConnection con = new MySqlConnection(connection_string);
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataReader reader;

            try
            {
                con.Open();
                reader = cmd.ExecuteReader();
                con.Close();
                MessageBox.Show("THANKS! YOUNGSTER SUCCESFULLY ADDED");

                first_name_textbox.Clear();
                last_name_textbox.Clear();
                age_textbox.Clear();
                position_comboBox.Text = "";
                defending_textbox.Clear();
                dribbling_textbox.Clear();
                overall_textbox.Clear();
                pace_textbox.Clear();
                passing_textbox.Clear();
                shooting_textbox.Clear();
                estimated_value_textBox.Clear();

            }

            catch (Exception my_exception)
            {
                MessageBox.Show(my_exception.ToString());
            }

        }
    }
}
