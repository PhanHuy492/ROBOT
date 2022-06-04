using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;
using UsbLibrary;

namespace giaodien
{
    public partial class Form1 : Form
    {
        int i = 0, j, k;
        string s, m, n;
        bool canPaint;
        Graphics g;
        int x, y;
        


        private void btn_connect_Click(object sender, EventArgs e)
        //////khi nhấn nút Connect////////////////
        {
            if (cbcom.Text == "")
            {
                MessageBox.Show("Chọn cổng Com.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    if (serialPort1.IsOpen)
                    {
                        MessageBox.Show("COM Port is connected and ready for use", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        serialPort1.Open();
                        status.BackColor = Color.Lime;
                        status.Text = "Connecting...";
                        cbcom.Enabled = false;
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("COM is not found, please check your COM cable", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }
        
        private void btn_up_Click(object sender, EventArgs e)  
        {
            x = 200;
            y = 200;
            Pen pen = new Pen(Color.FromArgb(255, 0, 0, 0));
            g.DrawLine(Pens.Green, x, y, x, y -50);
        }

        private void btn_down_Click(object sender, EventArgs e)
        {
            x = 200;
            y = 200;
            Pen pen = new Pen(Color.FromArgb(255, 0, 0, 0));
            g.DrawLine(Pens.Red, x, y, x, y + 50);
        }

        private void btn_left_Click(object sender, EventArgs e)
        {
            x = 200;
            y = 200;
            Pen pen = new Pen(Color.FromArgb(255, 0, 0, 0));
            g.DrawLine(Pens.Pink, x+50, y-50, x+50, y-100);
        }

        private void btn_right_Click(object sender, EventArgs e)
        {
            x = 200;
            y = 200;
            Pen pen = new Pen(Color.FromArgb(255, 0, 0, 0));
            g.DrawLine(Pens.Blue, x, y-50, x + 50, y-50);
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {

        }

        

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
    
            
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            
        }

        private void btn_up_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                serialPort1.Write("1");
                canPaint = true;
                x = e.X;
                y = e.Y;
                g.DrawLine(Pens.Black, x, y, e.X, e.Y);



            }
            catch (Exception ex)
            {
                MessageBox.Show("can not control" + ex.Message);
            }
            

        }

        private void btn_up_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void btn_up_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                serialPort1.Write("0");
                canPaint = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("can not control" + ex.Message);
            }
        }

        private void btn_left_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                serialPort1.Write("3");
            }
            catch (Exception ex)
            {
                MessageBox.Show("can not control" + ex.Message);
            }
            
        }

        private void btn_left_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                serialPort1.Write("0");
            }
            catch (Exception ex)
            {
                MessageBox.Show("can not control" + ex.Message);
            }
        }

        private void btn_right_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                serialPort1.Write("4");
            }
            catch (Exception ex)
            {
                MessageBox.Show("can not control" + ex.Message);
            }
        }

        private void btn_right_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                serialPort1.Write("0");
            }
            catch (Exception ex)
            {
                MessageBox.Show("can not control" + ex.Message);
            }
        }

        private void btn_down_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                serialPort1.Write("2");
            }
            catch (Exception ex)
            {
                MessageBox.Show("can not control" + ex.Message);
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void cbcom_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void status_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_stop_Click_1(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Write("0");
            }
            catch (Exception ex)
            {
                MessageBox.Show("can not control" + ex.Message);
            }
        }

        private void btn_up_KeyUp(object sender, KeyEventArgs e)
        {
            
        }
           
        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                serialPort1.Write("1");
            }
            if (e.KeyCode == Keys.Down)
            {
                serialPort1.Write("2");
            }
            if (e.KeyCode == Keys.Left)
            {
                serialPort1.Write("3");
            }
            if (e.KeyCode == Keys.Right)
            {
                serialPort1.Write("4");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Write("6");
            }
            catch (Exception ex)
            {
                MessageBox.Show("can not control" + ex.Message);
            }
        }

        private void btn_led_on_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Write("5");
            }
            catch (Exception ex)
            {
                MessageBox.Show("can not control" + ex.Message);
            }
        }

        private void btn_passing_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                serialPort1.Write("5");
            }
            catch (Exception ex)
            {
                MessageBox.Show("can not control" + ex.Message);
            }
        }

        private void btn_passing_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                serialPort1.Write("6");
            }
            catch (Exception ex)
            {
                MessageBox.Show("can not control" + ex.Message);
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                serialPort1.Write("0");
            }
            if (e.KeyCode == Keys.Down)
            {
                serialPort1.Write("0");
            }
            if (e.KeyCode == Keys.Left)
            {
                serialPort1.Write("0");
            }
            if (e.KeyCode == Keys.Right)
            {
                serialPort1.Write("0");
            }
        }

        private void btn_down_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                serialPort1.Write("0");
            }
            catch (Exception ex)
            {
                MessageBox.Show("can not control" + ex.Message);
            }
        }

      

        private void btn_disconnect_Click(object sender, EventArgs e)
        //Sự kiện xảy ra khi nút Disconnect được nhấn
        {
            try
            {
                if (serialPort1.IsOpen)
                {
                    serialPort1.Close();
                    status.BackColor = Color.Red;
                    status.Text = "Disconnected!";
                    cbcom.Enabled = true;


                }
                else
                {
                    MessageBox.Show("COM Port is disconnected and NOT ready for use", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("COM is not found, please check your COM cable", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        public Form1()
        {
            InitializeComponent();
            g = pictureBox1.CreateGraphics();//KHAI BÁO BIẾN g
            canPaint = false;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            //Lấy tên cổng COM
            if (i != ports.Length)
            {
                i = ports.Length;
                cbcom.Items.Clear();
                for (int j = 0; j < i; j++)
                {
                    cbcom.Items.Add(ports[j]);
                }
            }
            

        }
        



    }
}
