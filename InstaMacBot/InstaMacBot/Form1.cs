using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InstagramApiSharp;
using InstagramApiSharp.Classes;
using InstagramApiSharp.Classes.Models;
using InstaMacBot.classi_MacBotClient;
using InstaMacBot.MacBotClient_classes;

namespace InstaMacBot
{
    public partial class Form1 : Form
    {

        BotClient client = new BotClient();
        UserApi utente;
        BotConsole follow_like_console;
        BotConsole unfollow_console;
        BotConsole extract_console;
        BotConsole console_hastag;
        BotConsole console_location;
        BotConsole console_send_dm;


        public Form1()
        {
            InitializeComponent();
        }

        bool is_loggin=false;
        private async void bt_login_Click(object sender, EventArgs e)
        {
            if (tx_username.Text == "" || tx_password.Text=="")
            {
                MessageBox.Show("fill username and password", "invalid credentials");
                return;
            }

            if (is_loggin)
            {
                MessageBox.Show("you are already logging in");
                return;
            }

            is_loggin = true;

            utente = new UserApi(tx_username.Text, tx_password.Text);

            


            string esito = await utente.loginAsync();



            if (utente.is_logged)
            {
                tx_username.Enabled = false;
                tx_password.Enabled = false;
                
                //MessageBox.Show("loggato");
                bt_login.Enabled = false;
                bt_logout.Enabled = true;

                tab_comandi.Enabled = true;
                
                follow_like_console = new DesktopTextBoxConsole(tx_console);
                unfollow_console = new DesktopTextBoxConsole(tx_console_unfollow);
                extract_console = new DesktopTextBoxConsole(console_extract);
                console_hastag = new DesktopTextBoxConsole(tx_console_hastag);
                console_location = new DesktopTextBoxConsole(tx_console_location);
                console_send_dm = new DesktopTextBoxConsole(tx_console_send_dm);


                SSSBot follow_like = new FollowLikeLastsPicBot(utente, tx_console: follow_like_console, like_lasts_pic: 1, delay:60);
                SSSBot unfollow = new UnfollowBot(utente, tx_console: unfollow_console);
                SSSBot extract_from_user = new ExtractFollowersBot(utente, tx_console: extract_console);
                SSSBot extract_from_hastag = new ExtractAccountsFromHastagBot(utente, tx_console: console_hastag);
                SSSBot extract_from_location = new ExtractAccountsFromLocationBot(utente, tx_console: console_location);
                SSSBot send_dm = new SendDmBot(utente, tx_console: console_send_dm);

               
                client.bots.Add("follow_like", follow_like);
                client.bots.Add("unfollow", unfollow);
                client.bots.Add("extract_from_user", extract_from_user);
                client.bots.Add("extract_from_hastag", extract_from_hastag);
                client.bots.Add("extract_from_location", extract_from_location);
                client.bots.Add("send_dm", send_dm);
                    
               
            }
            else
            {
                MessageBox.Show("login error: " + esito);
            }
            is_loggin = false;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            

            ExtractFollowersBot x = (ExtractFollowersBot)client.bots["extract_from_user"];
            if (!x.is_running)
            {
                x.set_username(tx_username_estrai_followers.Text);
                x.start();
                console_location.write_on_console("extract process can take some times (more followers more time)");

                do
                {
                    extract_console.write_on_console("wait extracting...");
                    await wait(10);


                } while (x.is_running);


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ExtractFollowersBot x = (ExtractFollowersBot)client.bots["extract_from_user"];
            x.save_on_file_extracted_list();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            FollowLikeLastsPicBot x = (FollowLikeLastsPicBot)client.bots["follow_like"];
            if (x.is_running)
            {
                MessageBox.Show("stop bot before");
            }
            else
            {
                x.load_list_from_file();
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            FollowLikeLastsPicBot x = (FollowLikeLastsPicBot)client.bots["follow_like"];
            x.clear_processing_accounts_list();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            bool spento = false;

            foreach (KeyValuePair<string, SSSBot> entry in client.bots)
            {
                if (entry.Value.is_running)
                {
                    entry.Value.stop(true);
                    spento = true;
                }
            }

            if (spento)
            {
                MessageBox.Show("Stopped all running bots and saved infos in bots files");
            }

        }


      
        private async void button5_Click(object sender, EventArgs e)
        {
            

            if (!client.bots["follow_like"].is_running)
                client.bots["follow_like"].start();     
            
        }

        private async Task<bool> wait(int seconds)
        {
            int i = 0;
            while (i < seconds)
            {
                await Task.Delay(1000);
                i++;
            }
            return true;
        }

        private async void button4_Click(object sender, EventArgs e)
        {
            if (client.bots["follow_like"].is_running)
            {
                client.bots["follow_like"].stop(true);

                int i = 0;
                do
                {
                    await wait(1);
                    i++;

                } while (client.bots["follow_like"].is_running && i < 5);

                if (client.bots["follow_like"].is_running)
                {
                    MessageBox.Show("couldn't stop bot: time out excedeed");
                }
            }
            
           
        }

        



        private async void bt_logout_Click(object sender, EventArgs e)
        {
            string s = await utente.logoutAsync();
            MessageBox.Show(s);
            if (s == "logged out")
            {
                Application.Exit();
            }

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            UnfollowBot x = (UnfollowBot) client.bots["unfollow"];
            

            if (x.is_running)
            {
                MessageBox.Show("stop bot before");
            }
            else
            {
                x.load_followed_accounts();
            }

        }



 
 
        private async void button6_Click(object sender, EventArgs e)
        {
            

            if (!client.bots["unfollow"].is_running)
                client.bots["unfollow"].start();
        }

       

        private async void button5_Click_1(object sender, EventArgs e)
        {
            if (client.bots["unfollow"].is_running)
            {
                client.bots["unfollow"].stop(true);

                int i = 0;
                do
                {
                    await wait(1);
                    i++;

                } while (client.bots["unfollow"].is_running && i < 5);

                if (client.bots["unfollow"].is_running)
                {
                    MessageBox.Show("couldn't stop bot: time out excedeed");
                }
            }
        }

      

        private void button5_Click_3(object sender, EventArgs e)
        {
            if (client.bots["follow_like"].is_running)
                MessageBox.Show("ON");
            else
                MessageBox.Show("OFF");
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            if (client.bots["unfollow"].is_running)
                MessageBox.Show("ON");
            else
                MessageBox.Show("OFF");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            FollowLikeLastsPicBot x = (FollowLikeLastsPicBot)client.bots["follow_like"];
            x.set_likes_last_pic(int.Parse(comboBox1.SelectedItem.ToString()));
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            FollowLikeLastsPicBot x = (FollowLikeLastsPicBot)client.bots["follow_like"];
            x.set_delay(int.Parse(comboBox2.SelectedItem.ToString()));
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            UnfollowBot x = (UnfollowBot)client.bots["unfollow"];
            x.set_delay(int.Parse(comboBox3.SelectedItem.ToString()));
        }

        private async void button7_Click(object sender, EventArgs e)
        {

           

            ExtractAccountsFromHastagBot x = (ExtractAccountsFromHastagBot)client.bots["extract_from_hastag"];
            if (!x.is_running)
            {
                x.set_hastag(tx_hastag.Text);
                x.start();
            }

            console_hastag.write_on_console("extract process can take some times (more recent posts on this hastag more time)");
            do
            {
                console_hastag.write_on_console("wait extracting...");
                await wait(10);


            } while (x.is_running);
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            ExtractAccountsFromHastagBot x = (ExtractAccountsFromHastagBot)client.bots["extract_from_hastag"];
            x.save_on_file_extracted_list();
        }

        private async void button8_Click(object sender, EventArgs e)
        {
           

            ExtractAccountsFromLocationBot x = (ExtractAccountsFromLocationBot)client.bots["extract_from_location"];
            if (!x.is_running)
            {
                x.set_location(tx_location.Text);
                x.start();
            }

            console_location.write_on_console("extract process can take some times (more recent location posts more time)");
            do
            {
                console_location.write_on_console("wait extracting...");
                await wait(10);


            } while (x.is_running);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ExtractAccountsFromLocationBot x = (ExtractAccountsFromLocationBot)client.bots["extract_from_location"];
            x.save_on_file_extracted_list();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
           

           
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            FollowLikeLastsPicBot x = (FollowLikeLastsPicBot)client.bots["follow_like"];
            if (comboBox2.SelectedItem.ToString() == "yes")
            {
                x.set_follow_accounts(true);
            }
            else
            {
                x.set_follow_accounts(false);
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            SendDmBot x = (SendDmBot)client.bots["send_dm"];
            if (x.is_running)
            {
                MessageBox.Show("stop bot before");
            }
            else
            {
                x.load_list_from_file();
            }

        }

        private async void button13_Click(object sender, EventArgs e)
        {
            
            if (!client.bots["send_dm"].is_running)
            client.bots["send_dm"].start();
        }

        private async void button12_Click(object sender, EventArgs e)
        {
            if (client.bots["send_dm"].is_running)
            {
                client.bots["send_dm"].stop(false);

                int i = 0;
                do
                {
                    await wait(1);
                    i++;

                } while (client.bots["send_dm"].is_running && i < 5);

                if (client.bots["send_dm"].is_running)
                {
                    MessageBox.Show("couldn't stop bot: time out excedeed");
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (client.bots["send_dm"].is_running)
                MessageBox.Show("ON");
            else
                MessageBox.Show("OFF");
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            SendDmBot x = (SendDmBot)client.bots["send_dm"];
            string mess = x.get_message();
            string link = x.get_link();
            using (message_form form2 = new message_form())
            {
                if(mess != "")
                {
                    form2.set_message(mess);
                }

                if (link != "")
                {
                    form2.set_check_link(true);
                    form2.set_link(link);
                }

                if (form2.ShowDialog() == DialogResult.OK)
                {
                    x.set_message(form2.get_message());
                    x.set_link(form2.get_link());
                    console_send_dm.write_on_console("message added");
                    button13.Enabled = true;
                }
            }
        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {
            SendDmBot x = (SendDmBot)client.bots["send_dm"];
            x.set_delay(int.Parse(comboBox6.SelectedItem.ToString()));
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
