namespace EV3_GUI
{
    partial class Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gb_Connect = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bt_Disconnect = new System.Windows.Forms.Button();
            this.bt_Refresh = new System.Windows.Forms.Button();
            this.bt_Connect = new System.Windows.Forms.Button();
            this.cb_Connect = new System.Windows.Forms.ComboBox();
            this.gb_Setup = new System.Windows.Forms.GroupBox();
            this.gb_MediumMotor = new System.Windows.Forms.GroupBox();
            this.lbl_MediumMotorSpeed = new System.Windows.Forms.Label();
            this.trb_MediumMotorSpeed = new System.Windows.Forms.TrackBar();
            this.gb_LargeMotor = new System.Windows.Forms.GroupBox();
            this.lbl_LargeMotorSpeed = new System.Windows.Forms.Label();
            this.trb_LargeMotorSpeed = new System.Windows.Forms.TrackBar();
            this.gb_Message = new System.Windows.Forms.GroupBox();
            this.bt_Message = new System.Windows.Forms.Button();
            this.tb_Message = new System.Windows.Forms.TextBox();
            this.gb_Controler = new System.Windows.Forms.GroupBox();
            this.bt_Drop = new System.Windows.Forms.Button();
            this.bt_Grap = new System.Windows.Forms.Button();
            this.bt_Control = new System.Windows.Forms.Button();
            this.bt_GoB_Right = new System.Windows.Forms.Button();
            this.bt_GoB = new System.Windows.Forms.Button();
            this.bt_GoB_Left = new System.Windows.Forms.Button();
            this.bt_SpinR = new System.Windows.Forms.Button();
            this.bt_SpinL = new System.Windows.Forms.Button();
            this.bt_GoF_Right = new System.Windows.Forms.Button();
            this.bt_GoF = new System.Windows.Forms.Button();
            this.bt_GoF_Left = new System.Windows.Forms.Button();
            this.gb_Status = new System.Windows.Forms.GroupBox();
            this.bt_Clear = new System.Windows.Forms.Button();
            this.lb_Status = new System.Windows.Forms.ListBox();
            this.bt_Help = new System.Windows.Forms.Button();
            this.bt_HotKey = new System.Windows.Forms.Button();
            this.lbl_Info = new System.Windows.Forms.Label();
            this.gb_Connect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.gb_Setup.SuspendLayout();
            this.gb_MediumMotor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trb_MediumMotorSpeed)).BeginInit();
            this.gb_LargeMotor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trb_LargeMotorSpeed)).BeginInit();
            this.gb_Message.SuspendLayout();
            this.gb_Controler.SuspendLayout();
            this.gb_Status.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_Connect
            // 
            this.gb_Connect.Controls.Add(this.pictureBox1);
            this.gb_Connect.Controls.Add(this.bt_Disconnect);
            this.gb_Connect.Controls.Add(this.bt_Refresh);
            this.gb_Connect.Controls.Add(this.bt_Connect);
            this.gb_Connect.Controls.Add(this.cb_Connect);
            this.gb_Connect.Location = new System.Drawing.Point(10, 11);
            this.gb_Connect.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gb_Connect.Name = "gb_Connect";
            this.gb_Connect.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gb_Connect.Size = new System.Drawing.Size(215, 71);
            this.gb_Connect.TabIndex = 0;
            this.gb_Connect.TabStop = false;
            this.gb_Connect.Text = "Bluetooth Connection";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EV3_GUI.Properties.Resources.Bluetooth;
            this.pictureBox1.Location = new System.Drawing.Point(156, 17);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // bt_Disconnect
            // 
            this.bt_Disconnect.Location = new System.Drawing.Point(80, 41);
            this.bt_Disconnect.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bt_Disconnect.Name = "bt_Disconnect";
            this.bt_Disconnect.Size = new System.Drawing.Size(71, 20);
            this.bt_Disconnect.TabIndex = 3;
            this.bt_Disconnect.Text = "Disconnect";
            this.bt_Disconnect.UseVisualStyleBackColor = true;
            this.bt_Disconnect.Click += new System.EventHandler(this.bt_Disconnect_Click);
            // 
            // bt_Refresh
            // 
            this.bt_Refresh.Location = new System.Drawing.Point(4, 41);
            this.bt_Refresh.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bt_Refresh.Name = "bt_Refresh";
            this.bt_Refresh.Size = new System.Drawing.Size(71, 20);
            this.bt_Refresh.TabIndex = 3;
            this.bt_Refresh.Text = "Refresh";
            this.bt_Refresh.UseVisualStyleBackColor = true;
            this.bt_Refresh.Click += new System.EventHandler(this.bt_Refresh_Click);
            // 
            // bt_Connect
            // 
            this.bt_Connect.Location = new System.Drawing.Point(80, 17);
            this.bt_Connect.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bt_Connect.Name = "bt_Connect";
            this.bt_Connect.Size = new System.Drawing.Size(71, 20);
            this.bt_Connect.TabIndex = 2;
            this.bt_Connect.Text = "Connect";
            this.bt_Connect.UseVisualStyleBackColor = true;
            this.bt_Connect.Click += new System.EventHandler(this.bt_Connect_Click);
            // 
            // cb_Connect
            // 
            this.cb_Connect.FormattingEnabled = true;
            this.cb_Connect.Location = new System.Drawing.Point(4, 17);
            this.cb_Connect.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cb_Connect.Name = "cb_Connect";
            this.cb_Connect.Size = new System.Drawing.Size(72, 21);
            this.cb_Connect.TabIndex = 1;
            // 
            // gb_Setup
            // 
            this.gb_Setup.Controls.Add(this.gb_MediumMotor);
            this.gb_Setup.Controls.Add(this.gb_LargeMotor);
            this.gb_Setup.Location = new System.Drawing.Point(10, 83);
            this.gb_Setup.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gb_Setup.Name = "gb_Setup";
            this.gb_Setup.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gb_Setup.Size = new System.Drawing.Size(215, 176);
            this.gb_Setup.TabIndex = 1;
            this.gb_Setup.TabStop = false;
            this.gb_Setup.Text = "Vehicle Setup";
            // 
            // gb_MediumMotor
            // 
            this.gb_MediumMotor.Controls.Add(this.lbl_MediumMotorSpeed);
            this.gb_MediumMotor.Controls.Add(this.trb_MediumMotorSpeed);
            this.gb_MediumMotor.Location = new System.Drawing.Point(5, 95);
            this.gb_MediumMotor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gb_MediumMotor.Name = "gb_MediumMotor";
            this.gb_MediumMotor.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gb_MediumMotor.Size = new System.Drawing.Size(201, 72);
            this.gb_MediumMotor.TabIndex = 1;
            this.gb_MediumMotor.TabStop = false;
            this.gb_MediumMotor.Text = "Medium Motor";
            // 
            // lbl_MediumMotorSpeed
            // 
            this.lbl_MediumMotorSpeed.AutoSize = true;
            this.lbl_MediumMotorSpeed.Location = new System.Drawing.Point(4, 48);
            this.lbl_MediumMotorSpeed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_MediumMotorSpeed.Name = "lbl_MediumMotorSpeed";
            this.lbl_MediumMotorSpeed.Size = new System.Drawing.Size(38, 13);
            this.lbl_MediumMotorSpeed.TabIndex = 3;
            this.lbl_MediumMotorSpeed.Text = "Speed";
            // 
            // trb_MediumMotorSpeed
            // 
            this.trb_MediumMotorSpeed.Location = new System.Drawing.Point(4, 17);
            this.trb_MediumMotorSpeed.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.trb_MediumMotorSpeed.Maximum = 30;
            this.trb_MediumMotorSpeed.Name = "trb_MediumMotorSpeed";
            this.trb_MediumMotorSpeed.Size = new System.Drawing.Size(181, 45);
            this.trb_MediumMotorSpeed.TabIndex = 2;
            this.trb_MediumMotorSpeed.TickFrequency = 3;
            this.trb_MediumMotorSpeed.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trb_MediumMotorSpeed.Value = 3;
            this.trb_MediumMotorSpeed.Scroll += new System.EventHandler(this.trb_MediumMotorSpeed_Scroll);
            // 
            // gb_LargeMotor
            // 
            this.gb_LargeMotor.Controls.Add(this.lbl_LargeMotorSpeed);
            this.gb_LargeMotor.Controls.Add(this.trb_LargeMotorSpeed);
            this.gb_LargeMotor.Location = new System.Drawing.Point(5, 18);
            this.gb_LargeMotor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gb_LargeMotor.Name = "gb_LargeMotor";
            this.gb_LargeMotor.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gb_LargeMotor.Size = new System.Drawing.Size(201, 72);
            this.gb_LargeMotor.TabIndex = 0;
            this.gb_LargeMotor.TabStop = false;
            this.gb_LargeMotor.Text = "Large Motor";
            // 
            // lbl_LargeMotorSpeed
            // 
            this.lbl_LargeMotorSpeed.AutoSize = true;
            this.lbl_LargeMotorSpeed.Location = new System.Drawing.Point(5, 49);
            this.lbl_LargeMotorSpeed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_LargeMotorSpeed.Name = "lbl_LargeMotorSpeed";
            this.lbl_LargeMotorSpeed.Size = new System.Drawing.Size(38, 13);
            this.lbl_LargeMotorSpeed.TabIndex = 1;
            this.lbl_LargeMotorSpeed.Text = "Speed";
            // 
            // trb_LargeMotorSpeed
            // 
            this.trb_LargeMotorSpeed.Location = new System.Drawing.Point(5, 18);
            this.trb_LargeMotorSpeed.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.trb_LargeMotorSpeed.Maximum = 100;
            this.trb_LargeMotorSpeed.Name = "trb_LargeMotorSpeed";
            this.trb_LargeMotorSpeed.Size = new System.Drawing.Size(191, 45);
            this.trb_LargeMotorSpeed.TabIndex = 0;
            this.trb_LargeMotorSpeed.TickFrequency = 5;
            this.trb_LargeMotorSpeed.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
            this.trb_LargeMotorSpeed.Value = 20;
            this.trb_LargeMotorSpeed.Scroll += new System.EventHandler(this.trb_LargeMotorSpeed_Scroll);
            // 
            // gb_Message
            // 
            this.gb_Message.Controls.Add(this.bt_Message);
            this.gb_Message.Controls.Add(this.tb_Message);
            this.gb_Message.Location = new System.Drawing.Point(230, 11);
            this.gb_Message.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gb_Message.Name = "gb_Message";
            this.gb_Message.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gb_Message.Size = new System.Drawing.Size(215, 71);
            this.gb_Message.TabIndex = 2;
            this.gb_Message.TabStop = false;
            this.gb_Message.Text = "Send Message";
            // 
            // bt_Message
            // 
            this.bt_Message.Location = new System.Drawing.Point(113, 41);
            this.bt_Message.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bt_Message.Name = "bt_Message";
            this.bt_Message.Size = new System.Drawing.Size(98, 20);
            this.bt_Message.TabIndex = 1;
            this.bt_Message.Text = "Send Message";
            this.bt_Message.UseVisualStyleBackColor = true;
            this.bt_Message.Click += new System.EventHandler(this.bt_Message_Click);
            // 
            // tb_Message
            // 
            this.tb_Message.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Message.Location = new System.Drawing.Point(4, 17);
            this.tb_Message.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_Message.Name = "tb_Message";
            this.tb_Message.Size = new System.Drawing.Size(207, 21);
            this.tb_Message.TabIndex = 0;
            // 
            // gb_Controler
            // 
            this.gb_Controler.Controls.Add(this.bt_Drop);
            this.gb_Controler.Controls.Add(this.bt_Grap);
            this.gb_Controler.Controls.Add(this.bt_Control);
            this.gb_Controler.Controls.Add(this.bt_GoB_Right);
            this.gb_Controler.Controls.Add(this.bt_GoB);
            this.gb_Controler.Controls.Add(this.bt_GoB_Left);
            this.gb_Controler.Controls.Add(this.bt_SpinR);
            this.gb_Controler.Controls.Add(this.bt_SpinL);
            this.gb_Controler.Controls.Add(this.bt_GoF_Right);
            this.gb_Controler.Controls.Add(this.bt_GoF);
            this.gb_Controler.Controls.Add(this.bt_GoF_Left);
            this.gb_Controler.Location = new System.Drawing.Point(230, 83);
            this.gb_Controler.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gb_Controler.Name = "gb_Controler";
            this.gb_Controler.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gb_Controler.Size = new System.Drawing.Size(215, 176);
            this.gb_Controler.TabIndex = 3;
            this.gb_Controler.TabStop = false;
            this.gb_Controler.Text = "Controler";
            // 
            // bt_Drop
            // 
            this.bt_Drop.BackgroundImage = global::EV3_GUI.Properties.Resources.Drop;
            this.bt_Drop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_Drop.Location = new System.Drawing.Point(153, 94);
            this.bt_Drop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bt_Drop.Name = "bt_Drop";
            this.bt_Drop.Size = new System.Drawing.Size(58, 63);
            this.bt_Drop.TabIndex = 10;
            this.bt_Drop.UseVisualStyleBackColor = true;
            this.bt_Drop.Click += new System.EventHandler(this.bt_Drop_Click);
            // 
            // bt_Grap
            // 
            this.bt_Grap.BackgroundImage = global::EV3_GUI.Properties.Resources.Pick;
            this.bt_Grap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_Grap.Location = new System.Drawing.Point(153, 27);
            this.bt_Grap.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bt_Grap.Name = "bt_Grap";
            this.bt_Grap.Size = new System.Drawing.Size(58, 63);
            this.bt_Grap.TabIndex = 9;
            this.bt_Grap.UseVisualStyleBackColor = true;
            this.bt_Grap.Click += new System.EventHandler(this.bt_Grap_Click);
            // 
            // bt_Control
            // 
            this.bt_Control.BackgroundImage = global::EV3_GUI.Properties.Resources.Stop;
            this.bt_Control.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_Control.Location = new System.Drawing.Point(54, 70);
            this.bt_Control.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bt_Control.Name = "bt_Control";
            this.bt_Control.Size = new System.Drawing.Size(45, 49);
            this.bt_Control.TabIndex = 8;
            this.bt_Control.UseVisualStyleBackColor = true;
            this.bt_Control.Click += new System.EventHandler(this.bt_Control_Click);
            // 
            // bt_GoB_Right
            // 
            this.bt_GoB_Right.BackgroundImage = global::EV3_GUI.Properties.Resources.BRight;
            this.bt_GoB_Right.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_GoB_Right.Location = new System.Drawing.Point(104, 122);
            this.bt_GoB_Right.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bt_GoB_Right.Name = "bt_GoB_Right";
            this.bt_GoB_Right.Size = new System.Drawing.Size(45, 49);
            this.bt_GoB_Right.TabIndex = 7;
            this.bt_GoB_Right.UseVisualStyleBackColor = true;
            this.bt_GoB_Right.Click += new System.EventHandler(this.bt_GoB_Right_Click);
            // 
            // bt_GoB
            // 
            this.bt_GoB.BackgroundImage = global::EV3_GUI.Properties.Resources.Down;
            this.bt_GoB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_GoB.Location = new System.Drawing.Point(54, 122);
            this.bt_GoB.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bt_GoB.Name = "bt_GoB";
            this.bt_GoB.Size = new System.Drawing.Size(45, 49);
            this.bt_GoB.TabIndex = 6;
            this.bt_GoB.UseVisualStyleBackColor = true;
            this.bt_GoB.Click += new System.EventHandler(this.bt_GoB_Click);
            // 
            // bt_GoB_Left
            // 
            this.bt_GoB_Left.BackgroundImage = global::EV3_GUI.Properties.Resources.BLeft;
            this.bt_GoB_Left.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_GoB_Left.Location = new System.Drawing.Point(4, 122);
            this.bt_GoB_Left.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bt_GoB_Left.Name = "bt_GoB_Left";
            this.bt_GoB_Left.Size = new System.Drawing.Size(45, 49);
            this.bt_GoB_Left.TabIndex = 5;
            this.bt_GoB_Left.UseVisualStyleBackColor = true;
            this.bt_GoB_Left.Click += new System.EventHandler(this.bt_GoB_Left_Click);
            // 
            // bt_SpinR
            // 
            this.bt_SpinR.BackgroundImage = global::EV3_GUI.Properties.Resources.SpRight;
            this.bt_SpinR.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_SpinR.Location = new System.Drawing.Point(104, 70);
            this.bt_SpinR.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bt_SpinR.Name = "bt_SpinR";
            this.bt_SpinR.Size = new System.Drawing.Size(45, 49);
            this.bt_SpinR.TabIndex = 4;
            this.bt_SpinR.UseVisualStyleBackColor = true;
            this.bt_SpinR.Click += new System.EventHandler(this.bt_SpinR_Click);
            // 
            // bt_SpinL
            // 
            this.bt_SpinL.BackgroundImage = global::EV3_GUI.Properties.Resources.SpLeft;
            this.bt_SpinL.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_SpinL.Location = new System.Drawing.Point(4, 70);
            this.bt_SpinL.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bt_SpinL.Name = "bt_SpinL";
            this.bt_SpinL.Size = new System.Drawing.Size(45, 49);
            this.bt_SpinL.TabIndex = 3;
            this.bt_SpinL.UseVisualStyleBackColor = true;
            this.bt_SpinL.Click += new System.EventHandler(this.bt_SpinL_Click);
            // 
            // bt_GoF_Right
            // 
            this.bt_GoF_Right.BackgroundImage = global::EV3_GUI.Properties.Resources.URight;
            this.bt_GoF_Right.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_GoF_Right.Location = new System.Drawing.Point(104, 18);
            this.bt_GoF_Right.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bt_GoF_Right.Name = "bt_GoF_Right";
            this.bt_GoF_Right.Size = new System.Drawing.Size(45, 49);
            this.bt_GoF_Right.TabIndex = 2;
            this.bt_GoF_Right.UseVisualStyleBackColor = true;
            this.bt_GoF_Right.Click += new System.EventHandler(this.bt_GoF_Right_Click);
            // 
            // bt_GoF
            // 
            this.bt_GoF.BackgroundImage = global::EV3_GUI.Properties.Resources.Up;
            this.bt_GoF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_GoF.Location = new System.Drawing.Point(54, 18);
            this.bt_GoF.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bt_GoF.Name = "bt_GoF";
            this.bt_GoF.Size = new System.Drawing.Size(45, 49);
            this.bt_GoF.TabIndex = 1;
            this.bt_GoF.UseVisualStyleBackColor = true;
            this.bt_GoF.Click += new System.EventHandler(this.bt_GoF_Click);
            // 
            // bt_GoF_Left
            // 
            this.bt_GoF_Left.BackgroundImage = global::EV3_GUI.Properties.Resources.ULeft;
            this.bt_GoF_Left.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bt_GoF_Left.Location = new System.Drawing.Point(4, 18);
            this.bt_GoF_Left.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bt_GoF_Left.Name = "bt_GoF_Left";
            this.bt_GoF_Left.Size = new System.Drawing.Size(45, 49);
            this.bt_GoF_Left.TabIndex = 0;
            this.bt_GoF_Left.UseVisualStyleBackColor = true;
            this.bt_GoF_Left.Click += new System.EventHandler(this.bt_GoF_Left_Click);
            // 
            // gb_Status
            // 
            this.gb_Status.Controls.Add(this.bt_Clear);
            this.gb_Status.Controls.Add(this.lb_Status);
            this.gb_Status.Location = new System.Drawing.Point(450, 11);
            this.gb_Status.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gb_Status.Name = "gb_Status";
            this.gb_Status.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gb_Status.Size = new System.Drawing.Size(164, 248);
            this.gb_Status.TabIndex = 4;
            this.gb_Status.TabStop = false;
            this.gb_Status.Text = "Status";
            // 
            // bt_Clear
            // 
            this.bt_Clear.Location = new System.Drawing.Point(94, 223);
            this.bt_Clear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bt_Clear.Name = "bt_Clear";
            this.bt_Clear.Size = new System.Drawing.Size(60, 20);
            this.bt_Clear.TabIndex = 2;
            this.bt_Clear.Text = "Clear";
            this.bt_Clear.UseVisualStyleBackColor = true;
            this.bt_Clear.Click += new System.EventHandler(this.bt_Clear_Click);
            // 
            // lb_Status
            // 
            this.lb_Status.FormattingEnabled = true;
            this.lb_Status.Location = new System.Drawing.Point(4, 17);
            this.lb_Status.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lb_Status.Name = "lb_Status";
            this.lb_Status.Size = new System.Drawing.Size(151, 199);
            this.lb_Status.TabIndex = 0;
            // 
            // bt_Help
            // 
            this.bt_Help.Location = new System.Drawing.Point(535, 263);
            this.bt_Help.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bt_Help.Name = "bt_Help";
            this.bt_Help.Size = new System.Drawing.Size(79, 28);
            this.bt_Help.TabIndex = 5;
            this.bt_Help.Text = "Help";
            this.bt_Help.UseVisualStyleBackColor = true;
            this.bt_Help.Click += new System.EventHandler(this.bt_Help_Click);
            // 
            // bt_HotKey
            // 
            this.bt_HotKey.Location = new System.Drawing.Point(450, 264);
            this.bt_HotKey.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bt_HotKey.Name = "bt_HotKey";
            this.bt_HotKey.Size = new System.Drawing.Size(79, 28);
            this.bt_HotKey.TabIndex = 6;
            this.bt_HotKey.Text = "Hot Key";
            this.bt_HotKey.UseVisualStyleBackColor = true;
            this.bt_HotKey.Click += new System.EventHandler(this.bt_HotKey_Click);
            // 
            // lbl_Info
            // 
            this.lbl_Info.AutoSize = true;
            this.lbl_Info.Location = new System.Drawing.Point(10, 264);
            this.lbl_Info.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Info.Name = "lbl_Info";
            this.lbl_Info.Size = new System.Drawing.Size(207, 26);
            this.lbl_Info.TabIndex = 7;
            this.lbl_Info.Text = "EV3 mindstorm application\r\nTeam member: David, Joram, Ghazi, Nhan";
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 297);
            this.Controls.Add(this.lbl_Info);
            this.Controls.Add(this.bt_HotKey);
            this.Controls.Add(this.bt_Help);
            this.Controls.Add(this.gb_Status);
            this.Controls.Add(this.gb_Controler);
            this.Controls.Add(this.gb_Message);
            this.Controls.Add(this.gb_Setup);
            this.Controls.Add(this.gb_Connect);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form";
            this.Text = "6 Shmekels to ride the snail";
            this.gb_Connect.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.gb_Setup.ResumeLayout(false);
            this.gb_MediumMotor.ResumeLayout(false);
            this.gb_MediumMotor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trb_MediumMotorSpeed)).EndInit();
            this.gb_LargeMotor.ResumeLayout(false);
            this.gb_LargeMotor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trb_LargeMotorSpeed)).EndInit();
            this.gb_Message.ResumeLayout(false);
            this.gb_Message.PerformLayout();
            this.gb_Controler.ResumeLayout(false);
            this.gb_Status.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_Connect;
        private System.Windows.Forms.Button bt_Connect;
        private System.Windows.Forms.ComboBox cb_Connect;
        private System.Windows.Forms.GroupBox gb_Setup;
        private System.Windows.Forms.GroupBox gb_MediumMotor;
        private System.Windows.Forms.Label lbl_MediumMotorSpeed;
        private System.Windows.Forms.TrackBar trb_MediumMotorSpeed;
        private System.Windows.Forms.GroupBox gb_LargeMotor;
        private System.Windows.Forms.Label lbl_LargeMotorSpeed;
        private System.Windows.Forms.TrackBar trb_LargeMotorSpeed;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bt_Disconnect;
        private System.Windows.Forms.Button bt_Refresh;
        private System.Windows.Forms.GroupBox gb_Message;
        private System.Windows.Forms.Button bt_Message;
        private System.Windows.Forms.TextBox tb_Message;
        private System.Windows.Forms.GroupBox gb_Controler;
        private System.Windows.Forms.Button bt_GoF_Left;
        private System.Windows.Forms.Button bt_Control;
        private System.Windows.Forms.Button bt_GoB_Right;
        private System.Windows.Forms.Button bt_GoB;
        private System.Windows.Forms.Button bt_GoB_Left;
        private System.Windows.Forms.Button bt_SpinR;
        private System.Windows.Forms.Button bt_SpinL;
        private System.Windows.Forms.Button bt_GoF_Right;
        private System.Windows.Forms.Button bt_GoF;
        private System.Windows.Forms.Button bt_Grap;
        private System.Windows.Forms.Button bt_Drop;
        private System.Windows.Forms.GroupBox gb_Status;
        private System.Windows.Forms.ListBox lb_Status;
        private System.Windows.Forms.Button bt_Clear;
        private System.Windows.Forms.Button bt_Help;
        private System.Windows.Forms.Button bt_HotKey;
        private System.Windows.Forms.Label lbl_Info;
    }
}

