
namespace B10956057_411
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.radioButton_black = new System.Windows.Forms.RadioButton();
            this.radioButton_blue = new System.Windows.Forms.RadioButton();
            this.radioButton_green = new System.Windows.Forms.RadioButton();
            this.radioButton_red = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox_listenPort = new System.Windows.Forms.TextBox();
            this.textBox_port = new System.Windows.Forms.TextBox();
            this.textBox_ip = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // radioButton_black
            // 
            this.radioButton_black.AutoSize = true;
            this.radioButton_black.Location = new System.Drawing.Point(701, 83);
            this.radioButton_black.Name = "radioButton_black";
            this.radioButton_black.Size = new System.Drawing.Size(48, 16);
            this.radioButton_black.TabIndex = 21;
            this.radioButton_black.TabStop = true;
            this.radioButton_black.Text = "black";
            this.radioButton_black.UseVisualStyleBackColor = true;
            // 
            // radioButton_blue
            // 
            this.radioButton_blue.AutoSize = true;
            this.radioButton_blue.Location = new System.Drawing.Point(477, 83);
            this.radioButton_blue.Name = "radioButton_blue";
            this.radioButton_blue.Size = new System.Drawing.Size(43, 16);
            this.radioButton_blue.TabIndex = 20;
            this.radioButton_blue.TabStop = true;
            this.radioButton_blue.Text = "blue";
            this.radioButton_blue.UseVisualStyleBackColor = true;
            // 
            // radioButton_green
            // 
            this.radioButton_green.AutoSize = true;
            this.radioButton_green.Location = new System.Drawing.Point(234, 83);
            this.radioButton_green.Name = "radioButton_green";
            this.radioButton_green.Size = new System.Drawing.Size(49, 16);
            this.radioButton_green.TabIndex = 19;
            this.radioButton_green.TabStop = true;
            this.radioButton_green.Text = "green";
            this.radioButton_green.UseVisualStyleBackColor = true;
            // 
            // radioButton_red
            // 
            this.radioButton_red.AutoSize = true;
            this.radioButton_red.Location = new System.Drawing.Point(35, 86);
            this.radioButton_red.Name = "radioButton_red";
            this.radioButton_red.Size = new System.Drawing.Size(38, 16);
            this.radioButton_red.TabIndex = 18;
            this.radioButton_red.TabStop = true;
            this.radioButton_red.Text = "red";
            this.radioButton_red.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(719, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 22);
            this.button1.TabIndex = 17;
            this.button1.Text = "連線";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox_listenPort
            // 
            this.textBox_listenPort.Location = new System.Drawing.Point(529, 25);
            this.textBox_listenPort.Name = "textBox_listenPort";
            this.textBox_listenPort.Size = new System.Drawing.Size(167, 22);
            this.textBox_listenPort.TabIndex = 16;
            // 
            // textBox_port
            // 
            this.textBox_port.Location = new System.Drawing.Point(289, 25);
            this.textBox_port.Name = "textBox_port";
            this.textBox_port.Size = new System.Drawing.Size(167, 22);
            this.textBox_port.TabIndex = 15;
            // 
            // textBox_ip
            // 
            this.textBox_ip.Location = new System.Drawing.Point(53, 25);
            this.textBox_ip.Name = "textBox_ip";
            this.textBox_ip.Size = new System.Drawing.Size(167, 22);
            this.textBox_ip.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(475, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 12);
            this.label3.TabIndex = 13;
            this.label3.Text = "接聽Port";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(235, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 12);
            this.label2.TabIndex = 12;
            this.label2.Text = "目標Port";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 12);
            this.label1.TabIndex = 11;
            this.label1.Text = "目標IP";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.radioButton_black);
            this.Controls.Add(this.radioButton_blue);
            this.Controls.Add(this.radioButton_green);
            this.Controls.Add(this.radioButton_red);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox_listenPort);
            this.Controls.Add(this.textBox_port);
            this.Controls.Add(this.textBox_ip);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButton_black;
        private System.Windows.Forms.RadioButton radioButton_blue;
        private System.Windows.Forms.RadioButton radioButton_green;
        private System.Windows.Forms.RadioButton radioButton_red;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox_listenPort;
        private System.Windows.Forms.TextBox textBox_port;
        private System.Windows.Forms.TextBox textBox_ip;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

