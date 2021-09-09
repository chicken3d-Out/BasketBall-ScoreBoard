using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace basketballscore
{
    public partial class Form1 : Form
    {
        int current_Score;
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            while (lbl_Team1.Text == "")
            {
                MessageBox.Show("Enter Team Name First", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                break;
            }

            if (txt_Score1.Text == "0")
            {
                txt_Score1.Text = "3";
            }
            else
            {

                if (txt_Score1.Text != "")
                {
                    current_Score = Convert.ToInt32(txt_Score1.Text);
                    current_Score = current_Score + 3;
                    txt_Score1.Text = Convert.ToString(current_Score);
                }
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            while (lbl_Team2.Text == "")
            {
                MessageBox.Show("Enter Team Name First", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                break;
            }

            if (txt_Score2.Text == "0")
            {
                txt_Score2.Text = "3";
            }
            else
            {

                if (txt_Score1.Text != "")
                {
                    current_Score = Convert.ToInt32(txt_Score2.Text);
                    current_Score = current_Score + 3;
                    txt_Score2.Text = Convert.ToString(current_Score);
                }
            }
        }

        private void lbl_Team1_Click(object sender, EventArgs e)
        {

        }

        private void txt_Score2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lbl_Team1.Text == "")
            {
                lbl_Team1.Text = "Team "+ txt_Score1.Text;
                txt_Score1.Text = "0";
            }
            else
            {
                if (lbl_Team1.Text != null)
                {
                    MessageBox.Show("Name already saved!","Cannot Changed",MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
           
        }

        private void btn_addname2_Click(object sender, EventArgs e)
        {
            if (lbl_Team2.Text == "")
            {
                lbl_Team2.Text = "Team " + txt_Score2.Text;
                txt_Score2.Text = "0";
            }
            else
            {
                if (lbl_Team2.Text != null)
                {
                    MessageBox.Show("Name already saved!", "Cannot Changed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btn_Reset1_Click(object sender, EventArgs e)
        {
            if ( MessageBox.Show("Are You Sure You Want To Reset?", "Verify", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                txt_Score1.Text = "";
                lbl_Team1.Text = "";
            }

        }

        private void btn_Reset2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure You Want To Reset?", "Verify", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                txt_Score2.Text = "";
                lbl_Team2.Text = "";
            }
        }

        private void btn_add1_Click(object sender, EventArgs e)
        {
           while (lbl_Team1.Text == "")
            {
                MessageBox.Show("Enter Team Name First", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                break;
            }

            if (txt_Score1.Text == "0")
            {
                txt_Score1.Text = "1";
            }
            else
            {
                
                if (txt_Score1.Text != "")
                {
                    current_Score = Convert.ToInt32(txt_Score1.Text);
                    current_Score = current_Score + 1;
                    txt_Score1.Text = Convert.ToString(current_Score);
                }
            }
            
        }

        private void btn_add2_Click(object sender, EventArgs e)
        {
            while (lbl_Team1.Text == "")
            {
                MessageBox.Show("Enter Team Name First", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                break;
            }

            if (txt_Score1.Text == "0")
            {
                txt_Score1.Text = "2";
            }
            else
            {

                if (txt_Score1.Text != "")
                {
                    current_Score = Convert.ToInt32(txt_Score1.Text);
                    current_Score = current_Score + 2;
                    txt_Score1.Text = Convert.ToString(current_Score);
                }
            }
        }

        private void btn_minus1_Click(object sender, EventArgs e)
        {
            while (lbl_Team1.Text == "")
            {
                MessageBox.Show("Enter Team Name First", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                break;
            }

            if (txt_Score1.Text == "0")
            {
                MessageBox.Show("Score Already Reached Zero", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {

                if (txt_Score1.Text != "")
                {
                    current_Score = Convert.ToInt32(txt_Score1.Text);
                    current_Score = current_Score - 1;
                    txt_Score1.Text = Convert.ToString(current_Score);
                }
            }
        }

        private void btn_minus2_Click(object sender, EventArgs e)
        {
            while (lbl_Team1.Text == "")
            {
                MessageBox.Show("Enter Team Name First", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                break;
            }

            if (txt_Score1.Text == "0")
            {
                MessageBox.Show("Score Already Reached Zero", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (txt_Score1.Text != "" && Convert.ToInt32(txt_Score1.Text) <= 2)
                {
                    txt_Score1.Text = "0";
                }
                else
                {
                    if (txt_Score1.Text != "" && Convert.ToInt32(txt_Score1.Text) > 2)
                    {
                        current_Score = Convert.ToInt32(txt_Score1.Text);
                        current_Score = current_Score - 2;
                        txt_Score1.Text = Convert.ToString(current_Score);
                    }
                }
            }
        }

        private void btn_minus3_Click(object sender, EventArgs e)
        {
            while (lbl_Team1.Text == "")
            {
                MessageBox.Show("Enter Team Name First", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                break;
            }

            if (txt_Score1.Text == "0")
            {
                MessageBox.Show("Score Already Reached Zero", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (txt_Score1.Text != "" && Convert.ToInt32(txt_Score1.Text) <= 3)
                {
                    txt_Score1.Text = "0";
                }
                else
                {
                    if (txt_Score1.Text != "" && Convert.ToInt32(txt_Score1.Text) > 3)
                    {
                        current_Score = Convert.ToInt32(txt_Score1.Text);
                        current_Score = current_Score - 3;
                        txt_Score1.Text = Convert.ToString(current_Score);
                    }
                }        
                
            }
        }

        private void btn_Plus1B_Click(object sender, EventArgs e)
        {
            while (lbl_Team2.Text == "")
            {
                MessageBox.Show("Enter Team Name First", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                break;
            }

            if (txt_Score2.Text == "0")
            {
                txt_Score2.Text = "1";
            }
            else
            {

                if (txt_Score2.Text != "")
                {
                    current_Score = Convert.ToInt32(txt_Score2.Text);
                    current_Score = current_Score + 1;
                    txt_Score2.Text = Convert.ToString(current_Score);
                }
            }
        }

        private void btn_Plus2B_Click(object sender, EventArgs e)
        {
            while (lbl_Team2.Text == "")
            {
                MessageBox.Show("Enter Team Name First", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                break;
            }

            if (txt_Score2.Text == "0")
            {
                txt_Score2.Text = "2";
            }
            else
            {

                if (txt_Score2.Text != "")
                {
                    current_Score = Convert.ToInt32(txt_Score2.Text);
                    current_Score = current_Score + 2;
                    txt_Score2.Text = Convert.ToString(current_Score);
                }
            }
        }

        private void btn_Minus2B_Click(object sender, EventArgs e)
        {
            while (lbl_Team2.Text == "")
            {
                MessageBox.Show("Enter Team Name First", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                break;
            }

            if (txt_Score2.Text == "0")
            {
                MessageBox.Show("Score Already Reached Zero", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (txt_Score2.Text != "" && Convert.ToInt32(txt_Score2.Text) <= 2)
                {
                    txt_Score2.Text = "0";
                }
                else
                {
                    if (txt_Score2.Text != "" && Convert.ToInt32(txt_Score2.Text) > 2)
                    {
                        current_Score = Convert.ToInt32(txt_Score2.Text);
                        current_Score = current_Score - 2;
                        txt_Score2.Text = Convert.ToString(current_Score);
                    }
                }
            }
        }

        private void btn_Minus1B_Click(object sender, EventArgs e)
        {
            while (lbl_Team2.Text == "")
            {
                MessageBox.Show("Enter Team Name First", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                break;
            }

            if (txt_Score2.Text == "0")
            {
                MessageBox.Show("Score Already Reached Zero", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {

                if (txt_Score2.Text != "")
                {
                    current_Score = Convert.ToInt32(txt_Score2.Text);
                    current_Score = current_Score - 1;
                    txt_Score2.Text = Convert.ToString(current_Score);
                }
            }
        }

        private void btn_Minus3B_Click(object sender, EventArgs e)
        {
            while (lbl_Team2.Text == "")
            {
                MessageBox.Show("Enter Team Name First", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                break;
            }

            if (txt_Score2.Text == "0")
            {
                MessageBox.Show("Score Already Reached Zero", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                if (txt_Score2.Text != "" && Convert.ToInt32(txt_Score2.Text) <= 3)
                {
                    txt_Score2.Text = "0";
                }
                else
                {
                    if (txt_Score2.Text != "" && Convert.ToInt32(txt_Score2.Text) > 3)
                    {
                        current_Score = Convert.ToInt32(txt_Score2.Text);
                        current_Score = current_Score - 3;
                        txt_Score2.Text = Convert.ToString(current_Score);
                    }
                }
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure You Want To Reset?", "Verify", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void AddNameMenuItem_Click(object sender, EventArgs e)
        {
            if (lbl_Team1.Text == "")
            {
                lbl_Team1.Text = "Team " + txt_Score1.Text;
                txt_Score1.Text = "0";
            }
            else
            {
                if (lbl_Team1.Text != null)
                {
                    MessageBox.Show("Name already saved!", "Cannot Changed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            if (lbl_Team2.Text == "")
            {
                lbl_Team2.Text = "Team " + txt_Score2.Text;
                txt_Score2.Text = "0";
            }
            else
            {
                if (lbl_Team2.Text != null)
                {
                    MessageBox.Show("Name already saved!", "Cannot Changed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }

        private void resetMenuItem_Click(object sender, EventArgs e)
        {
            
                txt_Score1.Text = "";
                lbl_Team1.Text = "";
            
            
                txt_Score2.Text = "";
                lbl_Team2.Text = "";
            

        }

        private void exitMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txt_Score1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                lbl_Team1.Text = "Team "+txt_Score1.Text;
                txt_Score1.Text = "0";
            }
        }

        private void txt_Score2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                lbl_Team2.Text = "Team " + txt_Score2.Text;
                txt_Score2.Text = "0";
            } 
        }
    }
 }


