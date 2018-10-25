namespace BluetoothClient
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
            this.close_connection = new System.Windows.Forms.Button();
            this.send_message = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.connect_server = new System.Windows.Forms.Button();
            this.domainUpDown1 = new System.Windows.Forms.DomainUpDown();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label_connection_state = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // close_connection
            // 
            this.close_connection.Location = new System.Drawing.Point(121, 372);
            this.close_connection.Name = "close_connection";
            this.close_connection.Size = new System.Drawing.Size(130, 32);
            this.close_connection.TabIndex = 16;
            this.close_connection.Text = "Close connection";
            this.close_connection.UseVisualStyleBackColor = true;
            this.close_connection.Click += new System.EventHandler(this.close_connection_Click_1);
            // 
            // send_message
            // 
            this.send_message.Location = new System.Drawing.Point(119, 320);
            this.send_message.Name = "send_message";
            this.send_message.Size = new System.Drawing.Size(133, 29);
            this.send_message.TabIndex = 15;
            this.send_message.Text = "Send message";
            this.send_message.UseVisualStyleBackColor = true;
            this.send_message.Click += new System.EventHandler(this.send_message_Click_1);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(119, 148);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(144, 20);
            this.textBox2.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Message to send to server";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(119, 246);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(144, 20);
            this.textBox1.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(116, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Message to receive from server";
            // 
            // connect_server
            // 
            this.connect_server.Location = new System.Drawing.Point(119, 52);
            this.connect_server.Name = "connect_server";
            this.connect_server.Size = new System.Drawing.Size(125, 21);
            this.connect_server.TabIndex = 10;
            this.connect_server.Text = "connect to Server";
            this.connect_server.UseVisualStyleBackColor = true;
            this.connect_server.Click += new System.EventHandler(this.connect_server_Click_1);
            // 
            // domainUpDown1
            // 
            this.domainUpDown1.Location = new System.Drawing.Point(431, 135);
            this.domainUpDown1.Name = "domainUpDown1";
            this.domainUpDown1.Size = new System.Drawing.Size(236, 20);
            this.domainUpDown1.TabIndex = 20;
            this.domainUpDown1.Text = "domainUpDown1";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(431, 174);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(248, 186);
            this.listBox1.TabIndex = 21;
            // 
            // label_connection_state
            // 
            this.label_connection_state.AutoSize = true;
            this.label_connection_state.Location = new System.Drawing.Point(275, 56);
            this.label_connection_state.Name = "label_connection_state";
            this.label_connection_state.Size = new System.Drawing.Size(76, 13);
            this.label_connection_state.TabIndex = 22;
            this.label_connection_state.Text = "not connected";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_connection_state);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.domainUpDown1);
            this.Controls.Add(this.close_connection);
            this.Controls.Add(this.send_message);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.connect_server);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button close_connection;
        private System.Windows.Forms.Button send_message;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button connect_server;
        private System.Windows.Forms.DomainUpDown domainUpDown1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label_connection_state;
    }
}

