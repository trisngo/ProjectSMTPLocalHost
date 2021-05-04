﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace ProjectSMTPLocalHost
{
    public partial class FrmSmtpLocal : Form
    {
        TcpClient tcpClient;
        IPAddress iPAddress;
        IPEndPoint iPEndPoint;

        StreamReader sr;
        StreamWriter sw;
        public FrmSmtpLocal()
        {
            InitializeComponent();
        }
        private string inforToBase64(string input)
        {
            byte[] inputToBytes = System.Text.ASCIIEncoding.ASCII.GetBytes(input);
            string encodedInput = System.Convert.ToBase64String(inputToBytes);
            return encodedInput;
        }

        private void addTextToBox2(string input)
        {
            string text = "C: " + input + "\n";
            txtBoxSendSer.Text += text;
        }
        private void addTextToBox1(string input)
        {
            string text = "S: " + input + "\n";
            txtBoxGetSer.Text += text;
        }
        //use to hide and show password. Password is auto hide by default using property UseSystemPasswordChar = true
        private void checkBoxShowPwd_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowPwd.Checked)
            {
                txtBoxPwd.UseSystemPasswordChar = false;
            }
            else
            {
                txtBoxPwd.UseSystemPasswordChar = true;
            }
        }
        private void btnSend_Click(object sender, EventArgs e)
        {
            //if txtBoxSendSer and txtBoxGetSer have already text on previous sending, clear it
            txtBoxGetSer.Clear();
            txtBoxSendSer.Clear();
            //setup connection
            tcpClient = new TcpClient();
            iPAddress = IPAddress.Parse("127.0.0.1");
            iPEndPoint = new IPEndPoint(iPAddress, 25);
            tcpClient.Connect(iPEndPoint);

            sr = new StreamReader(tcpClient.GetStream());
            sw = new StreamWriter(tcpClient.GetStream());

            //run thread to listen a reply from mailserver
            CheckForIllegalCrossThreadCalls = false;
            Thread listenThd = new Thread(new ThreadStart(getMess));
            listenThd.IsBackground = true;
            listenThd.Start();

            //get mail domain
            int index = txtBoxFrom.Text.Trim().IndexOf('@');
            string domain = txtBoxFrom.Text.Trim().Substring(index + 1);

            //step to send mail
            string data = "EHLO " + domain;
            
            addTextToBox2(data);
            sw.WriteLine(data);
            sw.Flush();

            data = "AUTH LOGIN";
            addTextToBox2(data);
            sw.WriteLine(data);
            sw.Flush();

            data = inforToBase64(txtBoxFrom.Text);
            addTextToBox2(data);
            sw.WriteLine(data);
            sw.Flush();

            data = inforToBase64(txtBoxPwd.Text);
            addTextToBox2(data);
            sw.WriteLine(data);
            sw.Flush();

            data = "MAIL FROM:<" + txtBoxFrom.Text + ">";
            addTextToBox2(data);
            sw.WriteLine(data);
            sw.Flush();

            data = "RCPT TO:<" + txtBoxTo.Text + ">";
            addTextToBox2(data);
            sw.WriteLine(data);
            sw.Flush();

            data = "DATA";
            addTextToBox2(data);
            sw.WriteLine(data);
            sw.Flush();

            data = "FROM:<" + txtBoxFrom.Text + ">";
            addTextToBox2(data);
            sw.WriteLine(data);
            sw.Flush();

            data = "TO:<" + txtBoxTo.Text + ">";
            addTextToBox2(data);
            sw.WriteLine(data);
            sw.Flush();
            
            data = "Content-Type: text/plain; charset=\"UTF-8\"";//this make Vietnamese mail can be sent
            addTextToBox2(data);
            sw.WriteLine(data);
            sw.Flush();

            data = "subject: " + txtBoxSubject.Text;
            addTextToBox2(data);
            sw.WriteLine(data);
            sw.Flush();

            addTextToBox2("");
            sw.WriteLine();
            sw.Flush();
            data = richTBBody.Text;

            if (data.Contains("\n"))
            {
                string[] newData = data.Split('\n');
                foreach (string stringLine in newData)
                {
                    addTextToBox2(stringLine);
                    sw.WriteLine(stringLine);
                    sw.Flush();
                }
            }
            else
            {
                addTextToBox2(data);
                sw.WriteLine(data);
                sw.Flush();
            }
            addTextToBox2("");
            sw.WriteLine();
            sw.Flush();

            addTextToBox2(".");
            sw.WriteLine(".");
            sw.Flush();

            data = "QUIT";
            addTextToBox2(data);
            sw.WriteLine(data);
            sw.Flush();

            MessageBox.Show("Gửi mail thành công", "Thông báo");
            sr.Close();
            sw.Close();
        }

        private void getMess()
        {
            //get reply message from mailserver
            while (true)
            {
                string mess = "";
                mess = sr.ReadLine();
                if (string.IsNullOrEmpty(mess))
                {
                    tcpClient.Close();
                    break;
                }
                addTextToBox1(mess);
            }
        }

    }
}
