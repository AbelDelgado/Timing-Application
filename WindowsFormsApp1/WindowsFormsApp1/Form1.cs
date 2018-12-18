using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class AthleteForm : Form
    {

        int radioButton = 0;
        public AthleteForm()
        {
            InitializeComponent();
            DisableControls();
            
           
        }
 
        private void DisableControls()
        {
         
            foreach (Control c in tabPage3.Controls)
            {                                      
                TextBox d = c as TextBox;
                if (d != null)
                {
                    d.Enabled = false;
                }                                           
            }
        

        lane1.Visible = false;
            country1.Visible = false;
            standing1.Visible = false;

            lane2.Visible = false;
            country2.Visible = false;
            standing2.Visible = false;


            lane3.Visible = false;
            country3.Visible = false;
            standing3.Visible = false;


            lane4.Visible = false;
            country4.Visible = false;
            standing4.Visible = false;

            lane5.Visible = false;
            country5.Visible = false;
            standing5.Visible = false;

            lane6.Visible = false;
            country6.Visible = false;
            standing6.Visible = false;

            lane7.Visible = false;
            country7.Visible = false;
            standing7.Visible = false;

            lane8.Visible = false;
            country8.Visible = false;
            standing8.Visible = false;

            lane9.Visible = false;
            country9.Visible = false;
            standing9.Visible = false;

            lane10.Visible = false;
            country10.Visible = false;
            standing10.Visible = false;
        }


        private void makeStandingAppear ()
        {
            if (racer == 1)
            {
                textBox1.Enabled = true;
            }

            if(racer == 2)
            {
                textBox1.Enabled = true;
                textBox2.Enabled = true;
            }
            if (racer == 3)
            {
                textBox1.Enabled = true;
                textBox2.Enabled = true;
                textBox3.Enabled = true;
            }


            if (racer == 4)
            {
                textBox1.Enabled = true;
                textBox2.Enabled = true;
                textBox3.Enabled = true;
                textBox4.Enabled = true;
            }

            if (racer == 5)
            {
                textBox1.Enabled = true;
                textBox2.Enabled = true;
                textBox3.Enabled = true;
                textBox4.Enabled = true;
                textBox5.Enabled = true;

            }

            if (racer == 6)
            {
                textBox1.Enabled = true;
                textBox2.Enabled = true;
                textBox3.Enabled = true;
                textBox4.Enabled = true;
                textBox5.Enabled = true;
                textBox6.Enabled = true;

            }

            if (racer == 7)
            {
                textBox1.Enabled = true;
                textBox2.Enabled = true;
                textBox3.Enabled = true;
                textBox4.Enabled = true;
                textBox5.Enabled = true;
                textBox6.Enabled = true;
                textBox7.Enabled = true;

            }

            if (racer == 8)
            {
                textBox1.Enabled = true;
                textBox2.Enabled = true;
                textBox3.Enabled = true;
                textBox4.Enabled = true;
                textBox5.Enabled = true;
                textBox6.Enabled = true;
                textBox7.Enabled = true;
                textBox8.Enabled = true;

            }


            if (racer ==9)
            {
                textBox1.Enabled = true;
                textBox2.Enabled = true;
                textBox3.Enabled = true;
                textBox4.Enabled = true;
                textBox5.Enabled = true;
                textBox6.Enabled = true;
                textBox7.Enabled = true;
                textBox8.Enabled = true;
                textBox9.Enabled = true;
            }

            if (racer == 10)
            {
                textBox1.Enabled = true;
                textBox2.Enabled = true;
                textBox3.Enabled = true;
                textBox4.Enabled = true;
                textBox5.Enabled = true;
                textBox6.Enabled = true;
                textBox7.Enabled = true;
                textBox8.Enabled = true;
                textBox9.Enabled = true;
                textBox10.Enabled = true;

            }
        }
        

        private void makeLaneAppear(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                DisableControls();
                radioButton = 1;

                lane1.Visible = true;
                country1.Visible = true;

                standing1.Visible = true;
                standing1.Text = "First Place";
                if (racer == radioButton && button2.Enabled == false)
                    textBox1.Enabled = true;
                
            }          
            if (radioButton2.Checked)
            {
                DisableControls();
                radioButton = 2;

                lane1.Visible = true;
                country1.Visible = true;

                lane2.Visible = true;
                country2.Visible = true;

                standing1.Visible = true;
                standing1.Text = "First Place";

                standing2.Visible = true;
                standing2.Text = "Second Place";

                
                    
            }

            if (radioButton3.Checked)
            {
                DisableControls();
                radioButton = 3;
                lane1.Visible = true;
                country1.Visible = true;

                lane2.Visible = true;
                country2.Visible = true;

                lane3.Visible = true;
                country3.Visible = true;

                standing1.Visible = true;
                standing1.Text = "First Place";

                standing2.Visible = true;
                standing2.Text = "Second Place";

                standing3.Visible = true;
                standing3.Text = "Third Place";

               
            }

            if (radioButton4.Checked)
            {
                DisableControls();
                radioButton = 4;
                lane1.Visible = true;
                country1.Visible = true;

                lane2.Visible = true;
                country2.Visible = true;

                lane3.Visible = true;
                country3.Visible = true;

                lane4.Visible = true;
                country4.Visible = true;

                standing1.Visible = true;
                standing1.Text = "First Place";

                standing2.Visible = true;
                standing2.Text = "Second Place";

                standing3.Visible = true;
                standing3.Text = "Third Place";

                standing4.Visible = true;
                standing4.Text = "4";


            }



            if (radioButton5.Checked)
            {
                DisableControls();
                radioButton = 5;
                lane1.Visible = true;
                country1.Visible = true;

                lane2.Visible = true;
                country2.Visible = true;

                lane3.Visible = true;
                country3.Visible = true;

                lane4.Visible = true;
                country4.Visible = true;

                lane5.Visible = true;
                country5.Visible = true;

                standing1.Visible = true;
                standing1.Text = "First Place";

                standing2.Visible = true;
                standing2.Text = "Second Place";

                standing3.Visible = true;
                standing3.Text = "Third Place";

                standing4.Visible = true;
                standing4.Text = "4";

                standing5.Visible = true;
                standing5.Text = "5";

              


            }


            if (radioButton6.Checked)
            {
                DisableControls();
                radioButton = 6;
                lane1.Visible = true;
                country1.Visible = true;

                lane2.Visible = true;
                country2.Visible = true;

                lane3.Visible = true;
                country3.Visible = true;

                lane4.Visible = true;
                country4.Visible = true;

                lane5.Visible = true;
                country5.Visible = true;

                lane6.Visible = true;
                country6.Visible = true;

                standing1.Visible = true;
                standing1.Text = "First Place";

                standing2.Visible = true;
                standing2.Text = "Second Place";

                standing3.Visible = true;
                standing3.Text = "Third Place";

                standing4.Visible = true;
                standing4.Text = "4";

                standing5.Visible = true;
                standing5.Text = "5";

                standing6.Visible = true;
                standing6.Text = "6";

                

            }


            if (radioButton7.Checked)
            {
                DisableControls();
                radioButton = 7;
                lane1.Visible = true;
                country1.Visible = true;

                lane2.Visible = true;
                country2.Visible = true;

                lane3.Visible = true;
                country3.Visible = true;

                lane4.Visible = true;
                country4.Visible = true;

                lane5.Visible = true;
                country5.Visible = true;

                lane6.Visible = true;
                country6.Visible = true;

                lane7.Visible = true;
                country7.Visible = true;

                standing1.Visible = true;
                standing1.Text = "First Place";

                standing2.Visible = true;
                standing2.Text = "Second Place";

                standing3.Visible = true;
                standing3.Text = "Third Place";

                standing4.Visible = true;
                standing4.Text = "4";

                standing5.Visible = true;
                standing5.Text = "5";

                standing6.Visible = true;
                standing6.Text = "6";

                standing7.Visible = true;
                standing7.Text = "7";

               

            }



            if (radioButton8.Checked)
            {
                DisableControls();
                radioButton = 8;
                lane1.Visible = true;
                country1.Visible = true;

                lane2.Visible = true;
                country2.Visible = true;

                lane3.Visible = true;
                country3.Visible = true;

                lane4.Visible = true;
                country4.Visible = true;

                lane5.Visible = true;
                country5.Visible = true;

                lane6.Visible = true;
                country6.Visible = true;

                lane7.Visible = true;
                country7.Visible = true;

                lane8.Visible = true;
                country8.Visible = true;

                standing1.Visible = true;
                standing1.Text = "First Place";

                standing2.Visible = true;
                standing2.Text = "Second Place";

                standing3.Visible = true;
                standing3.Text = "Third Place";

                standing4.Visible = true;
                standing4.Text = "4";

                standing5.Visible = true;
                standing5.Text = "5";

                standing6.Visible = true;
                standing6.Text = "6";

                standing7.Visible = true;
                standing7.Text = "7";

                standing8.Visible = true;
                standing8.Text = "8";

             


            }

            if (radioButton9.Checked)
            {
                DisableControls();
                radioButton = 9;
                lane1.Visible = true;
                country1.Visible = true;

                lane2.Visible = true;
                country2.Visible = true;

                lane3.Visible = true;
                country3.Visible = true;

                lane4.Visible = true;
                country4.Visible = true;

                lane5.Visible = true;
                country5.Visible = true;

                lane6.Visible = true;
                country6.Visible = true;

                lane7.Visible = true;
                country7.Visible = true;

                lane8.Visible = true;
                country8.Visible = true;

                lane9.Visible = true;
                country9.Visible = true;

                standing1.Visible = true;
                standing1.Text = "First Place";

                standing2.Visible = true;
                standing2.Text = "Second Place";

                standing3.Visible = true;
                standing3.Text = "Third Place";

                standing4.Visible = true;
                standing4.Text = "4";

                standing5.Visible = true;
                standing5.Text = "5";

                standing6.Visible = true;
                standing6.Text = "6";

                standing7.Visible = true;
                standing7.Text = "7";

                standing8.Visible = true;
                standing8.Text = "8";

                standing9.Visible = true;
                standing9.Text = "9";


            }


            if (radioButton10.Checked)
            {
                DisableControls();
                radioButton = 10;
                lane1.Visible = true;
                country1.Visible = true;

                lane2.Visible = true;
                country2.Visible = true;

                lane3.Visible = true;
                country3.Visible = true;

                lane4.Visible = true;
                country4.Visible = true;

                lane5.Visible = true;
                country5.Visible = true;

                lane6.Visible = true;
                country6.Visible = true;

                lane7.Visible = true;
                country7.Visible = true;

                lane8.Visible = true;
                country8.Visible = true;

                lane9.Visible = true;
                country9.Visible = true;

                lane10.Visible = true;
                country10.Visible = true;

                standing1.Visible = true;
                standing1.Text = "First Place";

                standing2.Visible = true;
                standing2.Text = "Second Place";

                standing3.Visible = true;
                standing3.Text = "Third Place";

                standing4.Visible = true;
                standing4.Text = "4";

                standing5.Visible = true;
                standing5.Text = "5";

                standing6.Visible = true;
                standing6.Text = "6";

                standing7.Visible = true;
                standing7.Text = "7";

                standing8.Visible = true;
                standing8.Text = "8";

                standing9.Visible = true;
                standing9.Text = "9";

                standing10.Visible = true;
                standing10.Text = "10";


                

            }

        }          
        
        

       

     
       

        int miliseconds = 0;
        int seconds = 0;
        int minutes = 0;
        int racer = 1;
        bool raceBegun = false;
       
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            miliseconds++;
            MilisecondsLabel.Text = miliseconds.ToString();
            if (miliseconds == 99)
            {
                miliseconds = 0;
                seconds++;
                SecondsLabel.Text = seconds.ToString();
            }

            if (seconds == 60)
            {
                seconds = 0;
                minutes++;
                MinutesLabel.Text = minutes.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (racer != radioButton)
            {
                timer1.Enabled = true;
                button2.Text = "Stop " + racer;
                if (raceBegun)
                {
                    startStopButton();
                }
                raceBegun = true;
            }
            else
            {
                listBox1.Items.Add("Racer" + racer + "    " + minutes + ":" + seconds + ":" + miliseconds);
                timer1.Enabled = false;
                button2.Enabled = false;
                button2.Text = "Start";
                button1.Enabled = true;
                raceBegun = false;

              
                makeStandingAppear();

            }
            
        }




        

        private void startStopButton()
        {                                           
            listBox1.Items.Add("Racer" + racer + "    " + minutes + ":" + seconds + ":" + miliseconds);                
            racer++;
            button2.Text = "Stop " + racer;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            miliseconds = 0;
            seconds = 0;
            minutes = 0;
            racer = 1;
            MilisecondsLabel.Text = miliseconds.ToString();
            SecondsLabel.Text = seconds.ToString();
            MinutesLabel.Text = minutes.ToString();


            listBox1.Items.Clear();
            button1.Enabled = false;
            button2.Enabled = true;
            

        }

        
    }
}
