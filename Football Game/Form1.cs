using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace Football_Game
{
    public partial class Form1 : Form
    {
        int page = 1;
        Random randGen = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void option1Button_Click(object sender, EventArgs e)
        {
            if (page == 1)
            {
                page = 2;
            }
            else if (page == 2)
            {
                page = 4;
            }
            else if (page == 3)
            {
                page = 6;
            }
            else if (page == 4)
            {
                page = 8;
            }
            else if (page == 5)
            {
                page = 1;
            }
            else if (page == 6)
            {
                page = 1;
            }
            else if (page == 7)
            {
                page = 11;
            }
            else if (page == 8)
            {
                page = 13;
            }
            else if (page == 9)
            {
                page = 1;
            }
            else if (page == 10)
            {
                page = 1;
            }
            else if (page == 11)
            {
                page = 1;
            }
            else if (page == 12)
            {
                page = 16;
            }
            else if (page == 13)
            {
                page = 1;
            }
            else if (page == 14)
            {
                page = 18;
            }
            else if (page == 15)
            {
                page = 1;
            }
            else if (page == 16)
            {
                page = 20;
            }
            else if (page == 17)
            {
                page = 1;
            }
            else if (page == 18)
            {
                page = 1;
            }
            else if (page == 19)
            {
                page = 1;
            }
            else if (page == 20)
            {
                page = 1;
            }
            else if (page == 21)
            {
                page = 1;
            }

            switch (page)
            {
                case 1:
                    outputLabel.Text = "You are getting drafted to the NFL and have offers from 2 teams. Which one do you chose?";
                    option1Button.Text = "Buffalo Bills.";
                    option2Button.Text = "Kansas City Chiefs.";
                    option3Button.Text = "";
                    pictureBox.Image = Properties.Resources.draftPicture;
                    break;
                case 2:
                    outputLabel.Text = "You go to buffalo and hop in a taxi. The driver asks you where your going. Where do you wanna go?";
                    option1Button.Text = "Training Facilities.";
                    option2Button.Text = "Stadium.";
                    option3Button.Text = "";

                    break;
                case 3:
                    outputLabel.Text = "You go to Kansas City and walk around for a bit. You see a designer store and a dons. Which one do you wanna go to?";
                    option1Button.Text = "Designer Store.";
                    option2Button.Text = "Dons.";
                    option3Button.Text = "";
                    break;
                case 4:
                    outputLabel.Text = "You arrive at the training facility and see the coaches in one corner talking and your new teamates in another. Who do introduce yourself to first?";
                    option1Button.Text = "Coaches.";
                    option2Button.Text = "New Teamates.";
                    option3Button.Text = "";
                    pictureBox.Image = Properties.Resources.trainingCamp;
                    break;
                case 5:
                    outputLabel.Text = "You forgot you were supposed to go to the training facility and your coaches get angry and send you to the B team. Play again?";
                    option1Button.Text = "Yes.";
                    option2Button.Text = "No.";
                    option3Button.Text = "";
                    pictureBox.Image = Properties.Resources.stadium1;
                    break;
                case 6:
                    int chance = randGen.Next(1, 11);
                    pictureBox.Image = Properties.Resources.designerStore;
                    if (chance <= 4)
                    {
                        outputLabel.Text = "When you entered the designer store you notice 5 guys in all black walk in after you. They pull out loads of guns and knives. They kill you and everyone else in the store and take everything. Play Again?";
                        option1Button.Text = "Yes.";
                        option2Button.Text = "No.";
                        option3Button.Text = "";
                    }
                    else
                    {
                        outputLabel.Text = "When you entered the designer store you notice 5 guys in all black walk in after you. But luckely some police officers walk in after them. The five guys turn around and walk out. THe store didn't have the bag one of the officers wanted. THey got angry and shot everybody. Play Again?";
                        option1Button.Text = "Yes.";
                        option2Button.Text = "No.";
                        option3Button.Text = "";
                    }

                    break;
                case 7:
                    outputLabel.Text = "You go to Dons and can't decide what to order, a bigmac or a 10 piece nug. Which one do you want?";
                    option1Button.Text = "BigMac.";
                    option2Button.Text = "10 Piece Nug.";
                    option3Button.Text = "";
                    pictureBox.Image = Properties.Resources.mcdonalds;
                    break;
                case 8:
                    option3Button.Enabled = true;
                    outputLabel.Text = "You decide to go over to the coaches to seem more professional and have a better first impression. Which Coach do you talk to?";
                    option1Button.Text = "General Manager.";
                    option2Button.Text = "Head Coach.";
                    option3Button.Text = "Offensive Cordinator";

                    break;
                case 13:
                    outputLabel.Text = "You go up and introduce yourself to the General Manager. You get nervous and trip over your own foot. He gets angry and benchs you for the season. Play again?";
                    option1Button.Text = "Yes.";
                    option2Button.Text = "No.";
                    option3Button.Text = "";

                    break;
                case 10:
                    outputLabel.Text = "You go outside and spill a coffee on the cops. They get agry and shot you 62 times. Play Agai?";
                    option1Button.Text = "Yes.";
                    option2Button.Text = "No.";
                    option3Button.Text = "";
                    break;
                case 11:
                    outputLabel.Text = "You ordered a BigMac and downed it in 1 bite. You got diabetes and died. Play Again?";
                    option1Button.Text = "Yes.";
                    option2Button.Text = "No.";
                    option3Button.Text = "";
                    break;
                case 12:
                    outputLabel.Text = "You ordered a 6 piece nug and enjoyed it a lot. You finally decide to head over to the facility. How do you wanna get there?";
                    option1Button.Text = "Cab.";
                    option2Button.Text = "Bus";
                    option3Button.Text = "";
                    break;
                case 9:
                    outputLabel.Text = "You go up to your new teamates and your new coaches thought that was disrespectful. Play Again?";
                    option1Button.Text = "Yes.";
                    option2Button.Text = "No.";
                    option3Button.Text = "";
                    break;
                case 14:
                    outputLabel.Text = "You approach the head coach with confidence and introduce yourself. He says its tough for rookies like you to get a starting position on the team. You will need to undergo some training to prove yourself to him. What do you want to start with?";
                    option1Button.Text = "Throwing.";
                    option2Button.Text = "Scrambles.";
                    option3Button.Text = "";
                    break;
                case 15:
                    outputLabel.Text = "You approach the offisive cordinator and talk about all of the plays in the play book. He likes you so much that he talks to the head coach and gets you a starting spot on the team. You win!! Play Again?";
                    option1Button.Text = "Yes.";
                    option2Button.Text = "No.";
                    option3Button.Text = "";

                    break;
                case 16:
                    outputLabel.Text = "You hop into the cab and head over to the facility. On the way there you hit massive traffic that makes you late to your first training session. The coach is not very impressed but still tells you to join in with the rest. You see some of your teamates doing strength training and some runing some routes. Who do you wanna join.?";
                    option1Button.Text = "Strength.";
                    option2Button.Text = "Routes.";
                    option3Button.Text = "";
                    pictureBox.Image = Properties.Resources.taxi;
                    break;
                case 17:
                    outputLabel.Text = "You get onto the bus and go all the way to the back of the bus. The bus is almost full so you have to sit beside this shady guy. You don't get a good feeing from this guy so you decide to stand. On the way there the bus has to slam on the brakes and you go flying foward through the windshield. You died. Play Again?";
                    option1Button.Text = "Yes.";
                    option2Button.Text = "No.";
                    option3Button.Text = "";
                    pictureBox.Image = Properties.Resources.buss;
                    break;
                case 20:
                    outputLabel.Text = "You go and train strength with some of your teamates and completely fail. Your coach sees how weak you are and sits you. You lose. Play again?";
                    option1Button.Text = "Yes.";
                    option2Button.Text = "No.";
                    option3Button.Text = "";
                    break;
                case 21:
                    outputLabel.Text = "You go and run some routes with your teamates. You absolutely cook your defensive teamates. You coach sees your potential and still sits you because Kansas City sucks. You lose!! Play again?";
                    option1Button.Text = "Yes.";
                    option2Button.Text = "No.";
                    option3Button.Text = "";
                    break;
                case 18:
                    outputLabel.Text = "You go and show off your throwing skills even though you are a wide reciever. You're coach loves how vercitile you are. He gives you a starting position. You win!! Play Again?";
                    option1Button.Text = "Yes.";
                    option2Button.Text = "No.";
                    option3Button.Text = "";
                    break;
                case 19:
                    outputLabel.Text = "You go show off your running/ scambling skills and fly past all of the defense. You coach sees that and gives you the staring position you have been working for. You win!! Play again?";
                    option1Button.Text = "Yes.";
                    option2Button.Text = "No.";
                    option3Button.Text = "";
                    break;
                case 99:
                    outputLabel.Text = "Thank you for playing.";
                    option1Button.Text = "";
                    option2Button.Text = "";
                    option3Button.Text = "";

                    Refresh();
                    Thread.Sleep(2000);
                    Application.Exit();
                    break;
                default:
                    break;
            }
        }
        private void option2Button_Click(object sender, EventArgs e)
        {
            if (page == 1)
            {
                page = 3;
            }
            else if (page == 2)
            {
                page = 5;
            }
            else if (page == 3)
            {
                page = 7;
            }
            else if (page == 4)
            {
                page = 9;
            }
            else if (page == 5)
            {
                page = 99;
            }
            else if (page == 6)
            {
                page = 99;
            }
            else if (page == 7)
            {
                page = 12;
            }
            else if (page == 8)
            {
                page = 14;
            }
            else if (page == 9)
            {
                page = 99;
            }
            else if (page == 10)
            {
                page = 99;
            }
            else if (page == 11)
            {
                page = 99;
            }
            else if (page == 12)
            {
                page = 17;
            }
            else if (page == 13)
            {
                page = 99;
            }
            else if (page == 14)
            {
                page = 19;
            }
            else if (page == 15)
            {
                page = 99;
            }
            else if (page == 16)
            {
                page = 21;
            }
            else if (page == 17)
            {
                page = 99;
            }
            else if (page == 18)
            {
                page = 99;
            }
            else if (page == 19)
            {
                page = 99;
            }
            else if (page == 20)
            {
                page = 99;
            }
            else if (page == 21)
            {
                page = 99;
            }

            switch (page)
            {
                case 1:
                    outputLabel.Text = "You are getting drafted to the NFL and have offers from 2 teams. Which one do you chose?";
                    option1Button.Text = "Buffalo Bills.";
                    option2Button.Text = "Kansas City Chiefs.";
                    option3Button.Text = "";
                    pictureBox.Image = Properties.Resources.draftPicture;
                    break;
                case 2:
                    outputLabel.Text = "You go to buffalo and hop in a taxi. The driver asks you where your going. Where do you wanna go?";
                    option1Button.Text = "Training Facilities.";
                    option2Button.Text = "Stadium.";
                    option3Button.Text = "";

                    break;
                case 3:
                    outputLabel.Text = "You go to Kansas City and walk around for a bit. You see a designer store and a dons. Which one do you wanna go to?";
                    option1Button.Text = "Designer Store.";
                    option2Button.Text = "Dons.";
                    option3Button.Text = "";
                    break;
                case 4:
                    outputLabel.Text = "You arrive at the training facility and see the coaches in one corner talking and your new teamates in another. Who do introduce yourself to first?";
                    option1Button.Text = "Coaches.";
                    option2Button.Text = "New Teamates.";
                    option3Button.Text = "";
                    break;
                case 5:
                    outputLabel.Text = "You forgot you were supposed to go to the training facility and your coaches get angry and send you to the B team. Play again?";
                    option1Button.Text = "Yes.";
                    option2Button.Text = "No.";
                    option3Button.Text = "";
                    pictureBox.Image = Properties.Resources.stadium1;

                    break;
                case 6:
                    int chance = randGen.Next(1, 11);
                    if (chance <= 4)
                    {
                        outputLabel.Text = "When you entered the designer store you notice 5 guys in all black walk in after you. They pull out loads of guns and knives. They kill you and everyone else in the store and take everything. Play Again?";
                        option1Button.Text = "Yes.";
                        option2Button.Text = "No.";
                        option3Button.Text = "";
                    }
                    else
                    {
                        outputLabel.Text = "When you entered the designer store you notice 5 guys in all black walk in after you. But luckely some police officers walk in after them. The five guys turn around and walk out. THe store didn't have the bag one of the officers wanted. THey got angry and shot everybody. Play Again?";
                        option1Button.Text = "Yes.";
                        option2Button.Text = "No.";
                        option3Button.Text = "";
                    }

                    break;
                case 7:
                    outputLabel.Text = "You go to Dons and can't decide what to order, a bigmac or a 10 piece nug. Which one do you want?";
                    option1Button.Text = "BigMac.";
                    option2Button.Text = "10 Piece Nug.";
                    option3Button.Text = "";
                    pictureBox.Image = Properties.Resources.mcdonalds;

                    break;
                case 8:
                    option3Button.Enabled = true;
                    outputLabel.Text = "You decide to go over to the coaches to seem more professional and have a better first impression. Which Coach do you talk to?";
                    option1Button.Text = "General Manager.";
                    option2Button.Text = "Head Coach.";
                    option3Button.Text = "Offensive Cordinator";

                    break;
                case 13:
                    outputLabel.Text = "You go up and introduce yourself to the General Manager. You get nervous and trip over your own foot. He gets angry and benchs you for the season. Play again?";
                    option1Button.Text = "Yes.";
                    option2Button.Text = "No.";
                    option3Button.Text = "";

                    break;
                case 10:
                    outputLabel.Text = "You go outside and spill a coffee on the cops. They get agry and shot you 62 times. Play Agai?";
                    option1Button.Text = "Yes.";
                    option2Button.Text = "No.";
                    option3Button.Text = "";
                    break;
                case 11:
                    outputLabel.Text = "You ordered a BigMac and downed it in 1 bite. You got diabetes and died. Play Again?";
                    option1Button.Text = "Yes.";
                    option2Button.Text = "No.";
                    option3Button.Text = "";
                    break;
                case 12:
                    outputLabel.Text = "You ordered a 6 piece nug and enjoyed it a lot. You finally decide to head over to the facility. How do you wanna get there?";
                    option1Button.Text = "Cab.";
                    option2Button.Text = "Bus";
                    option3Button.Text = "";
                    break;
                case 9:
                    outputLabel.Text = "You go up to your new teamates and your new coaches thought that was disrespectful. Play Again?";
                    option1Button.Text = "Yes.";
                    option2Button.Text = "No.";
                    option3Button.Text = "";
                    break;
                case 14:
                    outputLabel.Text = "You approach the head coach with confidence and introduce yourself. He says its tough for rookies like you to get a starting position on the team. You will need to undergo some training to prove yourself to him. What do you want to start with?";
                    option1Button.Text = "Throwing.";
                    option2Button.Text = "Scrambles.";
                    option3Button.Text = "";
                    break;
                case 15:
                    outputLabel.Text = "You approach the offisive cordinator and talk about all of the plays in the play book. He likes you so much that he talks to the head coach and gets you a starting spot on the team. You win!! Play Again?";
                    option1Button.Text = "Yes.";
                    option2Button.Text = "No.";
                    option3Button.Text = "";

                    break;
                case 16:
                    outputLabel.Text = "You hop into the cab and head over to the facility. On the way there you hit massive traffic that makes you late to your first training session. The coach is not very impressed but still tells you to join in with the rest. You see some of your teamates doing strength training and some runing some routes. Who do you wanna join.?";
                    option1Button.Text = "Strength.";
                    option2Button.Text = "Routes.";
                    option3Button.Text = "";
                    pictureBox.Image = Properties.Resources.taxi;

                    break;
                case 17:
                    outputLabel.Text = "You get onto the bus and go all the way to the back of the bus. The bus is almost full so you have to sit beside this shady guy. You don't get a good feeing from this guy so you decide to stand. On the way there the bus has to slam on the brakes and you go flying foward through the windshield. You died. Play Again?";
                    option1Button.Text = "Yes.";
                    option2Button.Text = "No.";
                    option3Button.Text = "";
                    pictureBox.Image = Properties.Resources.buss;

                    break;
                case 20:
                    outputLabel.Text = "You go and train strenght with some of your teamates and completely fail. Your coach sees how weak you are and sits you. You lose. Play again?";
                    option1Button.Text = "Yes.";
                    option2Button.Text = "No.";
                    option3Button.Text = "";
                    break;
                case 21:
                    outputLabel.Text = "You go and run some routes with your teamates. You absolutely cook your defensive teamates. You coach sees your potential and still sits you because Kansas City sucks. You lose!! Play again?";
                    option1Button.Text = "Yes.";
                    option2Button.Text = "No.";
                    option3Button.Text = "";
                    break;
                case 18:
                    outputLabel.Text = "You go and show off your throwing skills even though you are a wide reciever. You're coach loves how vercitile you are. He gives you a starting position. You win!! Play Again?";
                    option1Button.Text = "Yes.";
                    option2Button.Text = "No.";
                    option3Button.Text = "";
                    break;
                case 19:
                    outputLabel.Text = "You go show off your running/ scambling skills and fly past all of the defense. You coach sees that and gives you the staring position you have been working for. You win!! Play again?";
                    option1Button.Text = "Yes.";
                    option2Button.Text = "No.";
                    option3Button.Text = "";
                    break;
                case 99:
                    outputLabel.Text = "Thank you for playing.";
                    option1Button.Text = "";
                    option2Button.Text = "";
                    option3Button.Text = "";

                    Refresh();
                    Thread.Sleep(2000);
                    Application.Exit();
                    break;
                default:
                    break;
            }
        }
        private void option3Button_Click(object sender, EventArgs e)
        {
            if (page == 8)
            {
                page = 15;
            }
            switch (page)
            {
                case 1:
                    outputLabel.Text = "You are getting drafted to the NFL and have offers from 2 teams. Which one do you chose?";
                    option1Button.Text = "Buffalo Bills.";
                    option2Button.Text = "Kansas City Chiefs.";
                    option3Button.Text = "";

                    break;
                case 2:
                    outputLabel.Text = "You go to buffalo and hop in a taxi. The driver asks you where your going. Where do you wanna go?";
                    option1Button.Text = "Training Facilities.";
                    option2Button.Text = "Stadium.";
                    option3Button.Text = "";

                    break;
                case 3:
                    outputLabel.Text = "You go to Kansas City and walk around for a bit. You see a designer store and a dons. Which one do you wanna go to?";
                    option1Button.Text = "Designer Store.";
                    option2Button.Text = "Dons.";
                    option3Button.Text = "";
                    break;
                case 4:
                    outputLabel.Text = "You arrive at the training facility and see the coaches in one corner talking and your new teamates in another. Who do introduce yourself to first?";
                    option1Button.Text = "Coaches.";
                    option2Button.Text = "New Teamates.";
                    option3Button.Text = "";
                    pictureBox.Image = Properties.Resources.trainingCamp;
                    break;
                case 5:
                    outputLabel.Text = "You forgot you were supposed to go to the training facility and your coaches get angry and send you to the B team. Play again?";
                    option1Button.Text = "Yes.";
                    option2Button.Text = "No.";
                    option3Button.Text = "";
                    pictureBox.Image = Properties.Resources.stadium1;
                    break;
                case 6:
                    int chance = randGen.Next(1, 11);
                    pictureBox.Image = Properties.Resources.designerStore;
                    if (chance <= 4)
                    {
                        outputLabel.Text = "When you entered the designer store you notice 5 guys in all black walk in after you. They pull out loads of guns and knives. They kill you and everyone else in the store and take everything. Play Again?";
                        option1Button.Text = "Yes.";
                        option2Button.Text = "No.";
                        option3Button.Text = "";
                    }
                    else
                    {
                        outputLabel.Text = "When you entered the designer store you notice 5 guys in all black walk in after you. But luckely some police officers walk in after them. The five guys turn around and walk out. THe store didn't have the bag one of the officers wanted. THey got angry and shot everybody. Play Again?";
                        option1Button.Text = "Yes.";
                        option2Button.Text = "No.";
                        option3Button.Text = "";
                    }

                    break;
                case 7:
                    outputLabel.Text = "You go to Dons and can't decide what to order, a bigmac or a 10 piece nug. Which one do you want?";
                    option1Button.Text = "BigMac.";
                    option2Button.Text = "10 Piece Nug.";
                    option3Button.Text = "";
                    pictureBox.Image = Properties.Resources.mcdonalds;
                    break;
                case 8:
                    option3Button.Enabled = true;
                    outputLabel.Text = "You decide to go over to the coaches to seem more professional and have a better first impression. Which Coach do you talk to?";
                    option1Button.Text = "General Manager.";
                    option2Button.Text = "Head Coach.";
                    option3Button.Text = "Offensive Cordinator";

                    break;
                case 13:
                    outputLabel.Text = "You go up and introduce yourself to the General Manager. You get nervous and trip over your own foot. He gets angry and benchs you for the season. Play again?";
                    option1Button.Text = "Yes.";
                    option2Button.Text = "No.";
                    option3Button.Text = "";

                    break;
                case 10:
                    outputLabel.Text = "You go outside and spill a coffee on the cops. They get agry and shot you 62 times. Play Agai?";
                    option1Button.Text = "Yes.";
                    option2Button.Text = "No.";
                    option3Button.Text = "";
                    break;
                case 11:
                    outputLabel.Text = "You ordered a BigMac and downed it in 1 bite. You got diabetes and died. Play Again?";
                    option1Button.Text = "Yes.";
                    option2Button.Text = "No.";
                    option3Button.Text = "";
                    break;
                case 12:
                    outputLabel.Text = "You ordered a 6 piece nug and enjoyed it a lot. You finally decide to head over to the facility. How do you wanna get there?";
                    option1Button.Text = "Cab.";
                    option2Button.Text = "Bus";
                    option3Button.Text = "";
                    break;
                case 9:
                    outputLabel.Text = "You go up to your new teamates and your new coaches thought that was disrespectful. Play Again?";
                    option1Button.Text = "Yes.";
                    option2Button.Text = "No.";
                    option3Button.Text = "";
                    break;
                case 14:
                    outputLabel.Text = "You approach the head coach with confidence and introduce yourself. He says its tough for rookies like you to get a starting position on the team. You will need to undergo some training to prove yourself to him. What do you want to start with?";
                    option1Button.Text = "Throwing.";
                    option2Button.Text = "Scrambles.";
                    option3Button.Text = "";
                    break;
                case 15:
                    outputLabel.Text = "You approach the offensive cordinator and talk about all of the plays in the play book. He likes you so much that he talks to the head coach and gets you a starting spot on the team. You win!! Play Again?";
                    option1Button.Text = "Yes.";
                    option2Button.Text = "No.";
                    option3Button.Text = "";

                    break;
                case 16:
                    outputLabel.Text = "You hop into the cab and head over to the facility. On the way there you hit massive traffic that makes you late to your first training session. The coach is not very impressed but still tells you to join in with the rest. You see some of your teamates doing strength training and some runing some routes. Who do you wanna join.?";
                    option1Button.Text = "Strength.";
                    option2Button.Text = "Routes.";
                    option3Button.Text = "";
                    pictureBox.Image = Properties.Resources.taxi;
                    break;
                case 17:
                    outputLabel.Text = "You get onto the bus and go all the way to the back of the bus. The bus is almost full so you have to sit beside this shady guy. You don't get a good feeing from this guy so you decide to stand. On the way there the bus has to slam on the brakes and you go flying foward through the windshield. You died. Play Again?";
                    option1Button.Text = "Yes.";
                    option2Button.Text = "No.";
                    option3Button.Text = "";
                    pictureBox.Image = Properties.Resources.buss;
                    break;
                case 20:
                    outputLabel.Text = "You go and train strenght with some of your teamates and completely fail. Your coach sees how weak you are and sits you. You lose. Play again?";
                    option1Button.Text = "Yes.";
                    option2Button.Text = "No.";
                    option3Button.Text = "";
                    break;
                case 21:
                    outputLabel.Text = "You go and run some routes with your teamates. You absolutely cook your defensive teamates. You coach sees your potential and still sits you because Kansas City sucks. You lose!! Play again?";
                    option1Button.Text = "Yes.";
                    option2Button.Text = "No.";
                    option3Button.Text = "";
                    break;
                case 18:
                    outputLabel.Text = "You go and show off your throwing skills even though you are a wide reciever. You're coach loves how vercitile you are. He gives you a starting position. You win!! Play Again?";
                    option1Button.Text = "Yes.";
                    option2Button.Text = "No.";
                    option3Button.Text = "";
                    break;
                case 19:
                    outputLabel.Text = "You go show off your running/ scambling skills and fly past all of the defense. You coach sees that and gives you the staring position you have been working for. You win!! Play again?";
                    option1Button.Text = "Yes.";
                    option2Button.Text = "No.";
                    option3Button.Text = "";
                    break;
                case 99:
                    outputLabel.Text = "Thank you for playing.";
                    option1Button.Text = "";
                    option2Button.Text = "";
                    option3Button.Text = "";

                    Refresh();
                    Thread.Sleep(2000);
                    Application.Exit();
                    break;
                default:
                    break;
            }
        }
    }
}
