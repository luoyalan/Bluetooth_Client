using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Threading;
using System.IO.Ports;
using System.IO;

namespace BluetoothClient
{
    public partial class Form1 : Form
    {
        
        private Thread thread;              
        private byte[] bytes = new byte[256];
        private string data = "";
        private byte[] msg = new byte[256];
        private readonly SerialPort _serialPort;
        private string completeData = "";        
        string path1 = @"C:\Users\Yalan\source\repos\Bluetooth Client\Bluetooth msg.txt";
        string path2 = @"C:\Users\Yalan\source\repos\Bluetooth Client\listBox.txt";
        bool ButtonccClicked = false;

        public Form1()
        {   
            InitializeComponent();
            send_message.Enabled = false;
            // Create a new SerialPort object with default settings.
            _serialPort = new SerialPort();
            string[] ports = SerialPort.GetPortNames();

            // Allow the user to set the appropriate properties.
            //COM3 incoming: PC als server COM4 outgoing PC als client
            DomainupdownAdd();

            // Set the read/write timeouts
            //_serialPort.ReadTimeout = 5000;
            _serialPort.WriteTimeout = 5000;
            this.FormClosing += Form1_FormClosing;

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            _serialPort.Close();
        }

        private void AsyncAccept()
        {

            try
            {
                ButtonStartServerEnabled(false);
                ButtonSendMessageEnabled(false);
                ButtonCloseConnectionEnabled(true);
                WriteToLabel("trying to connect");
                _serialPort.Open();

                while (true)
                {
                    
                    Console.WriteLine("Connected!");
                    WriteToLabel("Connected!");
                    ButtonSendMessageEnabled(true);
                    
                    data = null;  
                    int i;

                    // Loop to receive all the data sent by the client.
                    while ((i = _serialPort.Read(bytes, 0, bytes.Length)) != 0)
                    {
                       
                        // Translate data bytes to a ASCII string.
                        data = System.Text.Encoding.ASCII.GetString(bytes, 0, i);
                        completeData += data;
                        if (data[data.Length -1]=='\n')
                        {
                            ShowText(completeData);                            

                            completeData = "";
                        }
                        Console.WriteLine("Received: {0}", data);
                        WriteToLabel("Received: {0}");
                        // Process the data sent by the client.
                        data = data.ToUpper();
                        
                        byte[] msg = System.Text.Encoding.ASCII.GetBytes(data);

                    }
                   
                }
            }
            catch (Exception e)
            {                
             Console.WriteLine(e);
                WriteToLabel("connection failed. Please try again.");
                //if (ButtonccClicked)
                //{
                //    WriteToLabel("connection closed.");
                //}

                ButtonStartServerEnabled(true);
                ButtonSendMessageEnabled(false);
            }
            Console.WriteLine("bluetooth Client done");
           
        }



        private void connect_server_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show(domainUpDown1.SelectedItem.ToString());
            _serialPort.PortName = domainUpDown1.SelectedItem.ToString();           
            thread = new Thread(() => AsyncAccept());
            thread.Start();
        }

        private void send_message_Click_1(object sender, EventArgs e)
        {

            byte[] text_input = System.Text.Encoding.ASCII.GetBytes(textBox2.Text + "\n");
            // Send back a response.
            _serialPort.Write(text_input, 0, text_input.Length);
            listBox1.Items.Add(textBox2.Text);
            //File.AppendAllText(path1, textBox2.Text);
            Save_listBox1();
            Console.WriteLine("Sent: {0}");
            WriteToLabel("Sent: ");
        } 

        private void Save_listBox1()
        {
            using (System.IO.StreamWriter SaveFile = new System.IO.StreamWriter(path2))
            {
                foreach (var item in listBox1.Items)
                {
                    SaveFile.WriteLine(item);
                }
            }
        }

        private void close_connection_Click_1(object sender, EventArgs e)
        {
            
            _serialPort.Close();
            WriteToLabel("connection closed.");
            ButtonStartServerEnabled(true);
            ButtonccClicked = true;
            ButtonCloseConnectionEnabled(!ButtonccClicked);
        }

        private void ShowText(string text)
        {
             textBox1.Invoke(new Action(() => { textBox1.Text = text; }));



        }

        private void WriteToLabel(string msg)
        {
            label_connection_state.Invoke(new Action(() => { label_connection_state.Text = msg; }));
        }

        private void DomainupdownAdd()
        {
            string[] ports = SerialPort.GetPortNames();
            foreach (string port in ports)
            {
                domainUpDown1.Items.Add(port);
            }
            
        }
        private void ButtonStartServerEnabled(bool enabled)
        {
            connect_server.Invoke(new Action(() => { connect_server.Enabled = enabled; }));         
        }
        private void ButtonSendMessageEnabled(bool enabled)
        {           
            send_message.Invoke(new Action(() => { send_message.Enabled = enabled; }));
        }
        private void ButtonCloseConnectionEnabled(bool enabled)
        {
            close_connection.Invoke(new Action(() => { close_connection.Enabled = enabled; }));
        }
    }
}

