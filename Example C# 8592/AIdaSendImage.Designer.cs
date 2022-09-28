namespace LILIN_Aida_Test
{
    partial class AIdaSendImage
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
            this.Tb_Password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Tb_Account = new System.Windows.Forms.TextBox();
            this.Tb_IP = new System.Windows.Forms.TextBox();
            this.Tb_Port = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Btn_Send = new System.Windows.Forms.Button();
            this.Btn_Browse = new System.Windows.Forms.Button();
            this.pb_image = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_image)).BeginInit();
            this.SuspendLayout();
            // 
            // Tb_Password
            // 
            this.Tb_Password.Location = new System.Drawing.Point(771, 24);
            this.Tb_Password.Margin = new System.Windows.Forms.Padding(5);
            this.Tb_Password.Name = "Tb_Password";
            this.Tb_Password.Size = new System.Drawing.Size(125, 27);
            this.Tb_Password.TabIndex = 45;
            this.Tb_Password.Text = "pass1234";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 16);
            this.label1.TabIndex = 40;
            this.label1.Text = "IP:";
            // 
            // Tb_Account
            // 
            this.Tb_Account.Location = new System.Drawing.Point(510, 24);
            this.Tb_Account.Margin = new System.Windows.Forms.Padding(5);
            this.Tb_Account.Name = "Tb_Account";
            this.Tb_Account.Size = new System.Drawing.Size(125, 27);
            this.Tb_Account.TabIndex = 46;
            this.Tb_Account.Text = "admin";
            // 
            // Tb_IP
            // 
            this.Tb_IP.Location = new System.Drawing.Point(49, 24);
            this.Tb_IP.Margin = new System.Windows.Forms.Padding(5);
            this.Tb_IP.Name = "Tb_IP";
            this.Tb_IP.Size = new System.Drawing.Size(145, 27);
            this.Tb_IP.TabIndex = 47;
            this.Tb_IP.Text = "127.0.0.1";
            // 
            // Tb_Port
            // 
            this.Tb_Port.Location = new System.Drawing.Point(290, 24);
            this.Tb_Port.Margin = new System.Windows.Forms.Padding(5);
            this.Tb_Port.Name = "Tb_Port";
            this.Tb_Port.Size = new System.Drawing.Size(81, 27);
            this.Tb_Port.TabIndex = 48;
            this.Tb_Port.Text = "8592";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(435, 27);
            this.label4.Margin = new System.Windows.Forms.Padding(5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 16);
            this.label4.TabIndex = 41;
            this.label4.Text = "Account:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(243, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 16);
            this.label2.TabIndex = 42;
            this.label2.Text = "Port:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(690, 27);
            this.label5.Margin = new System.Windows.Forms.Padding(5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 16);
            this.label5.TabIndex = 44;
            this.label5.Text = "Password:";
            // 
            // Btn_Send
            // 
            this.Btn_Send.Location = new System.Drawing.Point(112, 87);
            this.Btn_Send.Margin = new System.Windows.Forms.Padding(15);
            this.Btn_Send.Name = "Btn_Send";
            this.Btn_Send.Size = new System.Drawing.Size(65, 29);
            this.Btn_Send.TabIndex = 50;
            this.Btn_Send.Text = "2.Send";
            this.Btn_Send.UseVisualStyleBackColor = true;
            this.Btn_Send.Click += new System.EventHandler(this.Btn_Send_Click);
            // 
            // Btn_Browse
            // 
            this.Btn_Browse.Location = new System.Drawing.Point(17, 87);
            this.Btn_Browse.Margin = new System.Windows.Forms.Padding(15);
            this.Btn_Browse.Name = "Btn_Browse";
            this.Btn_Browse.Size = new System.Drawing.Size(82, 29);
            this.Btn_Browse.TabIndex = 50;
            this.Btn_Browse.Text = "1.Browse";
            this.Btn_Browse.UseVisualStyleBackColor = true;
            this.Btn_Browse.Click += new System.EventHandler(this.Btn_Browse_Click);
            // 
            // pb_image
            // 
            this.pb_image.Location = new System.Drawing.Point(17, 134);
            this.pb_image.Name = "pb_image";
            this.pb_image.Size = new System.Drawing.Size(35, 36);
            this.pb_image.TabIndex = 51;
            this.pb_image.TabStop = false;
            // 
            // AIdaSendImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 701);
            this.Controls.Add(this.pb_image);
            this.Controls.Add(this.Btn_Browse);
            this.Controls.Add(this.Btn_Send);
            this.Controls.Add(this.Tb_Password);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Tb_Account);
            this.Controls.Add(this.Tb_IP);
            this.Controls.Add(this.Tb_Port);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Font = new System.Drawing.Font("新細明體", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AIdaSendImage";
            this.Text = "AIda Send Image";
            ((System.ComponentModel.ISupportInitialize)(this.pb_image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Tb_Password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Tb_Account;
        private System.Windows.Forms.TextBox Tb_IP;
        private System.Windows.Forms.TextBox Tb_Port;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Btn_Send;
        private System.Windows.Forms.Button Btn_Browse;
        private System.Windows.Forms.PictureBox pb_image;
    }
}

