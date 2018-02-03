using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EV3MessengerLib;

namespace EV3_GUI
{
    public partial class Form : System.Windows.Forms.Form
    {
        private Timer timer;
        private bool run = false;
        private EV3Messenger messenger;
        private string preMessage = "";
        public Dictionary<string, char> hotKey = new Dictionary<string, char>{
            { "GoF_Left" ,'q' },
            { "GoF_Right" , 'e' },
            { "GoB_Left" , 'z' },
            { "GoB_Right" , 'c' },
            { "GoF" , 'w' },
            { "GoB" , 'x' },
            { "Spin_Left" , 'a' },
            { "Spin_Right" , 'd' },
            { "Grab" , 'g'},
            { "Drop" , 'b' },
            { "Control" , 'p' },
            { "Send_Message" , 'm'}
        };
        public Form()
        {
            InitializeComponent();

            messenger = new EV3Messenger();
            UpdateGUI();
            FillPort();

            timer = new Timer();
            timer.Interval = 50; //refresh every 0.05 sec
            timer.Start();
            timer.Tick += new EventHandler(timer_tick);

            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form_KeyPress);
            KeyPreview = true;
        }

        #region GUI
        private void UpdateGUI()
        {
            if (messenger.IsConnected)
            {
                this.gb_Controler.Enabled =
                    this.gb_Message.Enabled =
                    this.gb_Setup.Enabled =
                    this.gb_Status.Enabled = true;

                this.bt_Connect.Text = "Connected";

                this.bt_Connect.Enabled =
                    this.bt_Refresh.Enabled = false;
                this.bt_Disconnect.Enabled = true;
            }
            else
            {
                this.gb_Controler.Enabled =
                    this.gb_Message.Enabled =
                    this.gb_Setup.Enabled =
                    this.gb_Status.Enabled = false;

                this.bt_Connect.Text = "Connect";

                this.bt_Connect.Enabled =
                    this.bt_Refresh.Enabled = true;
                this.bt_Disconnect.Enabled = false;
            }
        }
        #endregion

        #region Connection
        private void FillPort()
        {
            String[] ports = SerialPort.GetPortNames();
            Array.Sort(ports);

            this.cb_Connect.Items.Clear();
            foreach (string port in ports)
                this.cb_Connect.Items.Add(port);
        }

        private void bt_Connect_Click(object sender, EventArgs e)
        {
            if (this.cb_Connect.SelectedIndex > -1)
            {
                string port = cb_Connect.SelectedItem.ToString().ToUpper();
                if (messenger.Connect(port))
                {
                    UpdateGUI();
                }
                else
                {
                    MessageBox.Show("Some thing wrong! Unable to connect to " + port, "Error!");
                }
            }
            else
            {
                MessageBox.Show("Please select your port!", "Error!");
            }
        }

        private void bt_Refresh_Click(object sender, EventArgs e)
        {
            FillPort();
        }

        private void bt_Disconnect_Click(object sender, EventArgs e)
        {
            messenger.Disconnect();

            UpdateGUI();
        }


        #endregion

        #region Send Message
        private void bt_Message_Click(object sender, EventArgs e)
        {
            string msg = tb_Message.Text;
            if (!String.IsNullOrWhiteSpace(msg))
            {
                if (!(messenger.SendMessage("Message", msg) && messenger.SendMessage("Control", "_Mess")))
                {
                    MessageBox.Show("Oops! Something wrong. Unable to send message to ev3 mindstorm");
                }
            }
            else
            {
                MessageBox.Show("You have to put something in the textbox");
            }
        }
        #endregion

        #region Vehicle Setup
        private void trb_LargeMotorSpeed_Scroll(object sender, EventArgs e)
        {
            this.lbl_LargeMotorSpeed.Text = this.trb_LargeMotorSpeed.Value.ToString();
        }
        private void trb_MediumMotorSpeed_Scroll(object sender, EventArgs e)
        {
            this.lbl_MediumMotorSpeed.Text = this.trb_MediumMotorSpeed.Value.ToString();
        }

        private int[] TurningSpeed()
        {
            //int[] arr = new int[] { this.trb_LargeMotorSpeed.Value, this.trb_LargeMotorSpeed.Value / 2 };
            return new int[] { this.trb_LargeMotorSpeed.Value, this.trb_LargeMotorSpeed.Value / 2 }; 
        }
        #endregion

        #region Controler
        private void bt_GoF_Left_Click(object sender, EventArgs e)
        {
            if (!(messenger.SendMessage("MovingSpeedL", -TurningSpeed()[1]) && messenger.SendMessage("MovingSpeedR", -TurningSpeed()[0]) && messenger.SendMessage("Control", "_FLeft")))
                MessageBox.Show("Opps! Somethings wrong. Please check the connection again", "Error");
        }

        private void bt_GoF_Right_Click(object sender, EventArgs e)
        {
            if (!(messenger.SendMessage("MovingSpeedL", -TurningSpeed()[0]) && messenger.SendMessage("MovingSpeedR", -TurningSpeed()[1]) && messenger.SendMessage("Control", "_FRight")))
                MessageBox.Show("Opps! Somethings wrong. Please check the connection again", "Error");
        }

        private void bt_GoB_Left_Click(object sender, EventArgs e)
        {
            if (!(messenger.SendMessage("MovingSpeedL", TurningSpeed()[1]) && messenger.SendMessage("MovingSpeedR", TurningSpeed()[0]) && messenger.SendMessage("Control", "_BLeft")))
                MessageBox.Show("Opps! Somethings wrong. Please check the connection again", "Error");
        }

        private void bt_GoB_Right_Click(object sender, EventArgs e)
        {
            if (!(messenger.SendMessage("MovingSpeedL", TurningSpeed()[0]) && messenger.SendMessage("MovingSpeedR", TurningSpeed()[1]) && messenger.SendMessage("Control", "_BRight")))
                MessageBox.Show("Opps! Somethings wrong. Please check the connection again", "Error");
        }

        private void bt_GoF_Click(object sender, EventArgs e)
        {
            if (!(messenger.SendMessage("MovingSpeedL", -TurningSpeed()[0]) && messenger.SendMessage("MovingSpeedR", -TurningSpeed()[0]) && messenger.SendMessage("Control", "_GoF")))
                MessageBox.Show("Opps! Somethings wrong. Please check the connection again", "Error");
        }

        private void bt_GoB_Click(object sender, EventArgs e)
        {
            if (!(messenger.SendMessage("MovingSpeedL", TurningSpeed()[0]) && messenger.SendMessage("MovingSpeedR", TurningSpeed()[0]) && messenger.SendMessage("Control", "_GoB")))
                MessageBox.Show("Opps! Somethings wrong. Please check the connection again", "Error");
        }

        private void bt_SpinL_Click(object sender, EventArgs e)
        {
            if (!(messenger.SendMessage("MovingSpeedL", TurningSpeed()[0]) && messenger.SendMessage("MovingSpeedR", 0) && messenger.SendMessage("Control", "_SpinL")))
                MessageBox.Show("Opps! Somethings wrong. Please check the connection again", "Error");
        }

        private void bt_SpinR_Click(object sender, EventArgs e)
        {
            if (!(messenger.SendMessage("MovingSpeedL", 0) && messenger.SendMessage("MovingSpeedR", TurningSpeed()[0]) && messenger.SendMessage("Control", "_SpinR")))
                MessageBox.Show("Opps! Somethings wrong. Please check the connection again", "Error");
        }

        private void bt_Grap_Click(object sender, EventArgs e)
        {
            if(!(messenger.SendMessage("GrapingSpeed", -this.trb_MediumMotorSpeed.Value) && messenger.SendMessage("Control", "_Grab")))
                MessageBox.Show("Opps! Somethings wrong. Please check the connection again", "Error");
        }

        private void bt_Drop_Click(object sender, EventArgs e)
        {
            if (!(messenger.SendMessage("GrapingSpeed", this.trb_MediumMotorSpeed.Value) && messenger.SendMessage("Control", "_Grab")))
                MessageBox.Show("Opps! Somethings wrong. Please check the connection again", "Error");
        }

        private void bt_Control_Click(object sender, EventArgs e)
        {
            if (run == true)
                if (!messenger.SendMessage("Control", "_Pause"))
                    MessageBox.Show("Opp! Somethings wrong");
                else
                {
                    this.bt_Control.Image = global::EV3_GUI.Properties.Resources.Run;
                    this.bt_Control.BackgroundImageLayout = ImageLayout.Stretch;
                    run = false;
                }
            else
                if (!messenger.SendMessage("Control", "_Run"))
                    MessageBox.Show("Opp! Somethings wrong");
                else
                {
                    this.bt_Control.Image = global::EV3_GUI.Properties.Resources.Pause;
                    this.bt_Control.BackgroundImageLayout = ImageLayout.Stretch;
                    run = true;
            }
        }
        #endregion

        #region Status
        private void bt_Clear_Click(object sender, EventArgs e)
        {
            this.lb_Status.Items.Clear();
        }

        private void timer_tick(object sender, EventArgs e)
        {
            EV3Message message = messenger.ReadMessage();
            if (message != null)
            {
                if (checkMessage(messageTranslate(message.ValueAsText)) == true)
                {
                    lb_Status.Items.Add(messageTranslate(message.ValueAsText));
                    lb_Status.TopIndex = lb_Status.Items.Count - 1;
                }
            }
        }

        private string messageTranslate(string mess)
        {
            if (mess.Contains("_Mess"))
            {
                mess = mess.Substring(0, mess.IndexOf('_')) != "" ? "Message: " + mess.Substring(0, mess.IndexOf('_') ) : "No message recieved from the Brick";
                return mess;
            }
            for (int i = 2; i <= 15; i++)
            {
                if (mess.Contains("_Run") && mess.Contains("P_" + i.ToString()))
                {
                    switch (i)
                    {
                        case 2:
                        case 3:
                            return "Picking up box";
                        case 4:
                        case 5:
                        case 6:
                            return "Finding exit from pickup to drop off area";
                        case 7:
                            return "Following path until i see white (drop off)";
                        case 12:
                            return "Drop off";
                        case 8:
                        case 9:
                        case 10:
                        case 11:
                            return "adjusting for dropoff";
                        case 14:
                        case 15:
                        case 16:
                            return "Finding exit from dropoff to start";
                        case 13:
                            return "Droping off";
                        case 17:
                            return "Returning to start";
                    }
                }
            }
            mess = (mess.Contains("_Run") && mess.Contains("P_1")) ? "Following path to pick up area" : mess;
            mess = mess.Contains("_GoF") ? "Controler: Moving forward" : mess;
            mess = mess.Contains("_GoB") ? "Controler: Moving backward" : mess;
            mess = mess.Contains("_Grab") ? "Controler: Grabing" : mess;
            mess = mess.Contains("_Drop") ? "Controler: Droping" : mess;
            mess = mess.Contains("_SpinL") ? "Controler: Spinning left" : mess;
            mess = mess.Contains("_SpinR") ? "Controler: Spinning right" : mess;
            mess = mess.Contains("_FLeft") ? "Controler: Going foward to the left side" : mess;
            mess = mess.Contains("_FRight") ? "Controler: Going foward to the right side" : mess;
            mess = mess.Contains("_BLeft") ? "Controler: Going backward to the left side" : mess;
            mess = mess.Contains("_BRight") ? "Controler: Going backward to the left side" : mess;
            return mess;
        }

        private bool checkMessage(string mess)
        {
            if (mess != preMessage)
            {
                preMessage = mess;
                return true;
            }
            return false;
        }
        #endregion

        #region Key handle
        private void Form_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == hotKey["GoF_Left"])
            {
                this.bt_GoF_Click(this, null);
            }
            if(e.KeyChar == hotKey["GoF_Right"])
            {
                this.bt_GoF_Right_Click(this, null);
            }
            if(e.KeyChar == hotKey["GoB_Left"])
            {
                this.bt_GoB_Left_Click(this, null);
            }
            if(e.KeyChar == hotKey["GoB_Right"])
            {
                this.bt_GoB_Right_Click(this, null);
            }
            if(e.KeyChar == hotKey["GoB"])
            {
                this.bt_GoB_Click(this, null);
            }
            if(e.KeyChar == hotKey["GoF"])
            {
                this.bt_GoF_Click(this, null);
            }
            if(e.KeyChar == hotKey["Spin_Left"])
            {
                this.bt_SpinL_Click(this, null);
            }
            if(e.KeyChar == hotKey["Spin_Right"])
            {
                this.bt_SpinR_Click(this, null);
            }
            if(e.KeyChar == hotKey["Grab"])
            {
                this.bt_Grap_Click(this, null);
            }
            if(e.KeyChar == hotKey["Drop"])
            {
                this.bt_Drop_Click(this, null);
            }
            if(e.KeyChar == hotKey["Control"])
            {
                this.bt_Control_Click(this, null);
            }
            if(e.KeyChar == hotKey["Send_Message"])
            {
                this.bt_Message_Click(this, null);
            }
        }
        #endregion

        private void bt_HotKey_Click(object sender, EventArgs e)
        {
            MessageBox.Show("w and x to move forward/backward\na and d to turn left/right\n qezc for rotating while moving in their respective corners\ng and b to grab/drop\np for pause/resume/start\nm to send a message ");
        }

        private void bt_Help_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Center button starts/stops/resumes");
        }
    }
}