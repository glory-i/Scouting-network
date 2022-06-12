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
    public partial class Form4 : Form
    {
        //Form1 my_form_1 = new Form1();
        //Form2 my_form_2 = new Form2();
        //Form3 my_form_3 = new Form3();
        //Form4 my_form_4 = new Form4();

        public Form4()
        {
            InitializeComponent();
        }

        private void search_similar_players_button_Click(object sender, EventArgs e)
        {
            Form6 frm6 = new Form6();
            Control[] ctrls = frm6.Controls.Find("listBox1", false);
            Control[] ctrls2 = frm6.Controls.Find("listBox2", false);
            Control[] ctrls3 = frm6.Controls.Find("listBox3", false);
            Control[] ctrls4 = frm6.Controls.Find("listBox4", false);
            Control[] ctrls5 = frm6.Controls.Find("listBox5", false);
            Control[] ctrls6 = frm6.Controls.Find("listBox6", false);
            Control[] ctrls7 = frm6.Controls.Find("listBox7", false);
            Control[] ctrls8 = frm6.Controls.Find("listBox8", false);
            Control[] ctrls9 = frm6.Controls.Find("listBox9", false);
            Control[] ctrls10 = frm6.Controls.Find("listBox10", false);
            Control[] ctrls11 = frm6.Controls.Find("listBox11", false);


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





            string position = similar_position_comboBox.SelectedItem.ToString();
            
            string over = similar_overall_comboBox.SelectedItem.ToString();
            string overa = over[0].ToString() + over[1].ToString();
            int overall = Convert.ToInt32(overa);

            string estimated_value = similar_value_comboBox.SelectedItem.ToString();
            string esvalue ="";
            foreach(char c in estimated_value)
            {
                if (char.IsDigit(c))
                {
                    esvalue += c.ToString();
                }
                if(c == '-')
                {
                    break;
                }
            }

            int es_value = Convert.ToInt32(esvalue);
            string connection_string = "datasource=127.0.0.1;port=3306;username=root;password='';database=scouting;SSL Mode=None";

            string query = "SELECT * FROM players WHERE position='" + position + "'AND overall>= '"+ overall +"' AND value>='"+es_value+"' AND overall<='"+(overall+10)+ "'AND value<='" + (es_value + 30) + "'";

            MySqlConnection databaseconnection = new MySqlConnection(connection_string);
            MySqlCommand commanddatabase = new MySqlCommand(query, databaseconnection);
            commanddatabase.CommandTimeout = 60;
            MySqlDataReader reader;

            try
            {
                databaseconnection.Open();
                reader = commanddatabase.ExecuteReader();
                
                if(reader.HasRows)
                {
                    while(reader.Read())
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

                    }
                    frm6.Show();

                }

                else
                {
                    MessageBox.Show("No youngsters like that currently in the databse");
                }

                //frm6.Show();
                databaseconnection.Close();
            }

            catch (Exception myexception)
            {
                MessageBox.Show(myexception.ToString());
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            //
        }

        private void label6_Click(object sender, EventArgs e)
        {
            //
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            //
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            //
        }

        private void label9_Click(object sender, EventArgs e)
        {
            //
        }

        private void similar_exit_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void similar_exit_button_MouseHover(object sender, EventArgs e)
        {
            similar_exit_button.BackColor = Color.Red;  
        }

        private void back_similar_players_button_Click(object sender, EventArgs e)
        {
            Form1 my_form_1 = new Form1();
            this.Hide();
            my_form_1.Show();
        }

        private void similar_exit_button_MouseLeave(object sender, EventArgs e)
        {
            similar_exit_button.BackColor = Color.DodgerBlue;
        }

        private void similar_position_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //
        }
    }
}
