
namespace giaodien
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbcom = new System.Windows.Forms.ComboBox();
            this.status = new System.Windows.Forms.TextBox();
            this.btn_disconnect = new System.Windows.Forms.Button();
            this.btn_connect = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_left = new System.Windows.Forms.Button();
            this.btn_down = new System.Windows.Forms.Button();
            this.btn_right = new System.Windows.Forms.Button();
            this.btn_up = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_led_on = new System.Windows.Forms.Button();
            this.btn_led_off = new System.Windows.Forms.Button();
            this.btn_passing = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.cbcom);
            this.groupBox1.Controls.Add(this.status);
            this.groupBox1.Controls.Add(this.btn_disconnect);
            this.groupBox1.Controls.Add(this.btn_connect);
            this.groupBox1.Location = new System.Drawing.Point(982, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(291, 183);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "COM Port";
            // 
            // cbcom
            // 
            this.cbcom.FormattingEnabled = true;
            this.cbcom.Location = new System.Drawing.Point(68, 39);
            this.cbcom.Name = "cbcom";
            this.cbcom.Size = new System.Drawing.Size(148, 28);
            this.cbcom.TabIndex = 3;
            this.cbcom.SelectedIndexChanged += new System.EventHandler(this.cbcom_SelectedIndexChanged);
            // 
            // status
            // 
            this.status.BackColor = System.Drawing.Color.Gold;
            this.status.Location = new System.Drawing.Point(44, 87);
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(211, 26);
            this.status.TabIndex = 2;
            this.status.Text = "Disconnected !";
            this.status.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.status.TextChanged += new System.EventHandler(this.status_TextChanged);
            // 
            // btn_disconnect
            // 
            this.btn_disconnect.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_disconnect.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_disconnect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btn_disconnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_disconnect.Location = new System.Drawing.Point(156, 134);
            this.btn_disconnect.Name = "btn_disconnect";
            this.btn_disconnect.Size = new System.Drawing.Size(129, 41);
            this.btn_disconnect.TabIndex = 1;
            this.btn_disconnect.Text = "Disconnect";
            this.btn_disconnect.UseVisualStyleBackColor = false;
            this.btn_disconnect.Click += new System.EventHandler(this.btn_disconnect_Click);
            // 
            // btn_connect
            // 
            this.btn_connect.BackColor = System.Drawing.Color.SpringGreen;
            this.btn_connect.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_connect.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Lime;
            this.btn_connect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_connect.Location = new System.Drawing.Point(6, 134);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(134, 41);
            this.btn_connect.TabIndex = 0;
            this.btn_connect.Text = "Connect";
            this.btn_connect.UseVisualStyleBackColor = false;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.btn_left);
            this.groupBox2.Controls.Add(this.btn_down);
            this.groupBox2.Controls.Add(this.btn_right);
            this.groupBox2.Controls.Add(this.btn_up);
            this.groupBox2.Location = new System.Drawing.Point(982, 210);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(297, 259);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "CONTROL";
            // 
            // btn_left
            // 
            this.btn_left.BackColor = System.Drawing.Color.Aqua;
            this.btn_left.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_left.FlatAppearance.BorderSize = 2;
            this.btn_left.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btn_left.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_left.Location = new System.Drawing.Point(6, 113);
            this.btn_left.Name = "btn_left";
            this.btn_left.Size = new System.Drawing.Size(88, 66);
            this.btn_left.TabIndex = 2;
            this.btn_left.Text = "LEFT";
            this.btn_left.UseVisualStyleBackColor = false;
            this.btn_left.Click += new System.EventHandler(this.btn_left_Click);
            this.btn_left.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_left_MouseDown);
            this.btn_left.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_left_MouseUp);
            // 
            // btn_down
            // 
            this.btn_down.BackColor = System.Drawing.Color.Aqua;
            this.btn_down.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_down.FlatAppearance.BorderSize = 2;
            this.btn_down.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btn_down.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_down.Location = new System.Drawing.Point(101, 185);
            this.btn_down.Name = "btn_down";
            this.btn_down.Size = new System.Drawing.Size(89, 68);
            this.btn_down.TabIndex = 3;
            this.btn_down.Text = "DOWN";
            this.btn_down.UseVisualStyleBackColor = false;
            this.btn_down.Click += new System.EventHandler(this.btn_down_Click);
            this.btn_down.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_down_MouseDown);
            this.btn_down.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_down_MouseUp);
            // 
            // btn_right
            // 
            this.btn_right.BackColor = System.Drawing.Color.Aqua;
            this.btn_right.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_right.FlatAppearance.BorderSize = 2;
            this.btn_right.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btn_right.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_right.Location = new System.Drawing.Point(196, 113);
            this.btn_right.Name = "btn_right";
            this.btn_right.Size = new System.Drawing.Size(89, 66);
            this.btn_right.TabIndex = 1;
            this.btn_right.Text = "RIGHT";
            this.btn_right.UseVisualStyleBackColor = false;
            this.btn_right.Click += new System.EventHandler(this.btn_right_Click);
            this.btn_right.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_right_MouseDown);
            this.btn_right.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_right_MouseUp);
            // 
            // btn_up
            // 
            this.btn_up.BackColor = System.Drawing.Color.Aqua;
            this.btn_up.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_up.FlatAppearance.BorderSize = 2;
            this.btn_up.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btn_up.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_up.Location = new System.Drawing.Point(101, 39);
            this.btn_up.Name = "btn_up";
            this.btn_up.Size = new System.Drawing.Size(89, 67);
            this.btn_up.TabIndex = 0;
            this.btn_up.Text = "UP";
            this.btn_up.UseVisualStyleBackColor = false;
            this.btn_up.Click += new System.EventHandler(this.btn_up_Click);
            this.btn_up.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.btn_up.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btn_up_KeyDown);
            this.btn_up.KeyUp += new System.Windows.Forms.KeyEventHandler(this.btn_up_KeyUp);
            this.btn_up.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_up_MouseDown);
            this.btn_up.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_up_MouseUp);
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM7";
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.Location = new System.Drawing.Point(16, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(933, 657);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_passing);
            this.groupBox3.Controls.Add(this.btn_led_off);
            this.groupBox3.Controls.Add(this.btn_led_on);
            this.groupBox3.Location = new System.Drawing.Point(986, 481);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(292, 196);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "LIGHTS";
            // 
            // btn_led_on
            // 
            this.btn_led_on.BackColor = System.Drawing.Color.Yellow;
            this.btn_led_on.Location = new System.Drawing.Point(40, 25);
            this.btn_led_on.Name = "btn_led_on";
            this.btn_led_on.Size = new System.Drawing.Size(96, 84);
            this.btn_led_on.TabIndex = 0;
            this.btn_led_on.Text = "ON";
            this.btn_led_on.UseVisualStyleBackColor = false;
            this.btn_led_on.Click += new System.EventHandler(this.btn_led_on_Click);
            // 
            // btn_led_off
            // 
            this.btn_led_off.BackColor = System.Drawing.Color.LightGray;
            this.btn_led_off.Location = new System.Drawing.Point(170, 25);
            this.btn_led_off.Name = "btn_led_off";
            this.btn_led_off.Size = new System.Drawing.Size(89, 84);
            this.btn_led_off.TabIndex = 1;
            this.btn_led_off.Text = "OFF";
            this.btn_led_off.UseVisualStyleBackColor = false;
            this.btn_led_off.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_passing
            // 
            this.btn_passing.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btn_passing.Location = new System.Drawing.Point(40, 125);
            this.btn_passing.Name = "btn_passing";
            this.btn_passing.Size = new System.Drawing.Size(219, 45);
            this.btn_passing.TabIndex = 2;
            this.btn_passing.UseVisualStyleBackColor = false;
            this.btn_passing.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_passing_MouseDown);
            this.btn_passing.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_passing_MouseUp);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1285, 717);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "Form1";
            this.Text = " Interface User";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbcom;
        private System.Windows.Forms.TextBox status;
        private System.Windows.Forms.Button btn_disconnect;
        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_left;
        private System.Windows.Forms.Button btn_down;
        private System.Windows.Forms.Button btn_right;
        private System.Windows.Forms.Button btn_up;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_led_off;
        private System.Windows.Forms.Button btn_led_on;
        private System.Windows.Forms.Button btn_passing;
    }
}

