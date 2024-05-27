using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Automation;

namespace BombParty2
{
    public partial class game : Form
    {
        char[] alphabet =  "abcdefghijklmnopqrstuvwxyz".ToCharArray();
        char prompt1;
        char prompt2;
        int bombCountdown = globals.bombDurationTimer;
        string userAnswer;

        public game()
        {
            
            InitializeComponent();
            promptGenerator();

        }

        private void promptGenerator()
        {
            livesLabel.Text = "Lives: " + globals.lives.ToString();

            Random random = new Random();

            prompt1 = alphabet[random.Next(alphabet.Length)];
            prompt2 = alphabet[random.Next(alphabet.Length)];

            bombCountdown = globals.bombDurationTimer;
            bombTimer.Enabled = true;
            promptLabel.Text = prompt1 + prompt2.ToString();
        }

        private void bombTimer_Tick(object sender, EventArgs e)
        {
            if (bombCountdown > -1)
            {
                bombTimerLabel.Text = bombCountdown.ToString();
                bombCountdown--;
            }

            else if (bombCountdown <= 0)
            {
                bombTimer.Enabled = false;
                globals.lives = globals.lives - 1;
                livesLabel.Text = "Lives: " + globals.lives.ToString();
               
                if (globals.lives == 0 && bombCountdown <= globals.bombDurationTimer)
                {
                    bombTimerLabel.Text = "";
                    promptLabel.Location = new Point(370, 112);
                    promptLabel.Text = "Game Over!";
                    promptInput.Enabled = false;
                    promptInput.Visible = false;
                    returnMenuButton.Enabled = true;
                    returnMenuButton.Visible = true;
                }
                else
                {
                    promptGenerator();
                }
                    
            }
            else
            {
                
            }
        }

        private void promptInput_KeyPress(object sender, KeyPressEventArgs e)
        {

            userAnswer = promptInput.Text.ToLower();
            if (e.KeyChar == 13 && bombCountdown > 0)
            {
                
                bool valid = promptValidation();

               if (valid)
                {
                    promptGenerator();
                }
              
            }

            
        }

        private bool promptValidation()
        {
            
            promptInput.Text = "";

            for (int  i = 0; i < userAnswer.Length;)
            {

                if (userAnswer[i] == prompt1)
                {

                    if (userAnswer[i + 1] == prompt2)
                    {

                        using (HttpClient client = new HttpClient())
                        {

                            string apiUrl = $"https://api.dictionaryapi.dev/api/v2/entries/en_US/{userAnswer}";
                            HttpResponseMessage response = client.GetAsync(apiUrl).Result;

                            if (response.IsSuccessStatusCode)
                            {
                                globals.lives++;
                                livesLabel.Text = "Lives: " + globals.lives.ToString();
                                return true;
                            }
                            else
                            {
                                return false;
                            }

                        }

                    }

                    else
                    {
                        return false;
                    }
                }
                else
                {
                    i++;
                }

            }  

            return false;

        }

        private void returnMenuButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
