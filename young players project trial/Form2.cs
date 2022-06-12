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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //
        }

        private void search_exit_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void back_search_button_Click(object sender, EventArgs e)
        {

            Form1 my_form_1 = new Form1();
            this.Hide();
            my_form_1.Show();
        }

        private void specific_player_button_Click(object sender, EventArgs e)
        {
            Form5 frm5 = new Form5();
            Control[] ctrls = frm5.Controls.Find("listBox1", false);
            Control[] ctrls2 = frm5.Controls.Find("listBox2", false);
            Control[] ctrls3 = frm5.Controls.Find("listBox3", false);
            Control[] ctrls4 = frm5.Controls.Find("listBox4", false);
            Control[] ctrls5 = frm5.Controls.Find("listBox5", false);
            Control[] ctrls6 = frm5.Controls.Find("listBox6", false);
            Control[] ctrls7 = frm5.Controls.Find("listBox7", false);
            Control[] ctrls8 = frm5.Controls.Find("listBox8", false);
            Control[] ctrls9 = frm5.Controls.Find("listBox9", false);
            Control[] ctrls10 = frm5.Controls.Find("listBox10", false);
            Control[] ctrls11 = frm5.Controls.Find("listBox11", false);
            Control[] ctrls12 = frm5.Controls.Find("textBox1", false);

            ListBox list_box1 = (ListBox)ctrls[0];
            ListBox list_box2 = (ListBox)ctrls2[0];
            ListBox list_box3 = (ListBox)ctrls3[0];
            ListBox list_box4 = (ListBox)ctrls4[0];
            ListBox list_box5 = (ListBox)ctrls5[0];
            ListBox list_box6 = (ListBox)ctrls6[0];
            ListBox list_box7 = (ListBox)ctrls7[0];
            ListBox list_box8 = (ListBox)ctrls8[0];
            ListBox list_box9 = (ListBox)ctrls9[0];
            ListBox list_box10 = (ListBox)ctrls10[0];
            ListBox list_box11 = (ListBox)ctrls11[0];
            TextBox text_box1 = (TextBox)ctrls12[0];




            string fname = search_first_name_textbox.Text;
            string lname = search_last_name_textBox.Text;

            string connection_string = "datasource=127.0.0.1;port=3306;username=root;password='';database=scouting;SSL Mode=None";

            string query = "SELECT * FROM players WHERE fname='" + fname + "' AND lname='" + lname + "'";

            MySqlConnection databaseconnection = new MySqlConnection(connection_string);
            MySqlCommand commanddatabase = new MySqlCommand(query, databaseconnection);
            commanddatabase.CommandTimeout = 60;
            MySqlDataReader reader;

            try
            {
                databaseconnection.Open();
                reader = commanddatabase.ExecuteReader();
                reader.Read();
                if (reader.HasRows)
                {
                    list_box1.Items.Add(reader.GetString(1));
                    list_box2.Items.Add(reader.GetString(2));
                    list_box3.Items.Add(reader.GetString(3));
                    list_box4.Items.Add(reader.GetInt32(4));
                    list_box5.Items.Add(reader.GetInt32(5) +"m");
                    list_box6.Items.Add(reader.GetInt32(6));
                    list_box7.Items.Add(reader.GetInt32(7));
                    list_box8.Items.Add(reader.GetInt32(8));
                    list_box9.Items.Add(reader.GetInt32(9));
                    list_box10.Items.Add(reader.GetInt32(10));
                    list_box11.Items.Add(reader.GetInt32(11));
                    text_box1.Text = "fghj";

                    frm5.Show();

                }

                else
                {
                    MessageBox.Show("young player not found");
                }

                //frm5.Show();
                databaseconnection.Close();
            }

            catch (Exception myexception)
            {
                MessageBox.Show(myexception.ToString());
            }
        }

        private void real_search_exit_button_MouseHover(object sender, EventArgs e)
        {
            real_search_exit_button.BackColor = Color.Red;
        }

        private void real_search_exit_button_MouseLeave(object sender, EventArgs e)
        {
            real_search_exit_button.BackColor = Color.MintCream;

        }

        private void search_first_name_textbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
