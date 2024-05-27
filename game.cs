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
        int bombCountdown = 7;
        string userAnswer;

        public game()
        {
            InitializeComponent();

            promptGenerator();

            

        }

        private void promptGenerator()
        {

            Random random = new Random();

            prompt1 = alphabet[random.Next(alphabet.Length)];
            prompt2 = alphabet[random.Next(alphabet.Length)];

            bombCountdown = 7;
            bombTimer.Enabled = true;
            promptLabel.Text = prompt1 + prompt2.ToString();




        }

        private void bombTimer_Tick(object sender, EventArgs e)
        {

            if (globals.lives == 0)
            {
                promptLabel.Text = "Game Over!";
                bombTimerLabel.Text = "";
                
            }

            else if (bombCountdown > -1)
            {
                bombTimerLabel.Text = bombCountdown.ToString();
                bombCountdown--;
            }

            else
            {
                bombTimer.Enabled = false;
                globals.lives = globals.lives - 1;
                livesLabel.Text = "Lives: "+globals.lives.ToString();
                promptGenerator();

            }
           
        }

        private void promptInput_KeyPress(object sender, KeyPressEventArgs e)
        {

            userAnswer = promptInput.Text.ToLower();
            if (e.KeyChar == 13)
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
        
    }

    public static class globals
    {
        public static int lives = 3;



    }
}
