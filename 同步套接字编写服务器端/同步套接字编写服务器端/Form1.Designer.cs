namespace 同步套接字编写服务器端
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.porttextBox = new System.Windows.Forms.TextBox();
            this.servertextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.inputtextBox = new System.Windows.Forms.TextBox();
            this.outputtextBox = new System.Windows.Forms.TextBox();
            this.startlistenbutton = new System.Windows.Forms.Button();
            this.sandmessagebutton = new System.Windows.Forms.Button();
            this.stoplistenbutton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "服务器IP";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(14, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "监听端口";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(82, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(182, 21);
            this.textBox1.TabIndex = 2;
            // 
            // porttextBox
            // 
            this.porttextBox.Location = new System.Drawing.Point(84, 57);
            this.porttextBox.Name = "porttextBox";
            this.porttextBox.ReadOnly = true;
            this.porttextBox.Size = new System.Drawing.Size(181, 21);
            this.porttextBox.TabIndex = 3;
            // 
            // servertextBox
            // 
            this.servertextBox.Location = new System.Drawing.Point(83, 26);
            this.servertextBox.Name = "servertextBox";
            this.servertextBox.ReadOnly = true;
            this.servertextBox.Size = new System.Drawing.Size(182, 21);
            this.servertextBox.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Location = new System.Drawing.Point(304, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "服务器状态";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(6, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(188, 88);
            this.listBox1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(12, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 14);
            this.label3.TabIndex = 5;
            this.label3.Text = "接收信息";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(12, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 14);
            this.label4.TabIndex = 6;
            this.label4.Text = "发送信息";
            // 
            // inputtextBox
            // 
            this.inputtextBox.Location = new System.Drawing.Point(81, 119);
            this.inputtextBox.Multiline = true;
            this.inputtextBox.Name = "inputtextBox";
            this.inputtextBox.Size = new System.Drawing.Size(414, 62);
            this.inputtextBox.TabIndex = 7;
            this.inputtextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // outputtextBox
            // 
            this.outputtextBox.Location = new System.Drawing.Point(81, 187);
            this.outputtextBox.Multiline = true;
            this.outputtextBox.Name = "outputtextBox";
            this.outputtextBox.Size = new System.Drawing.Size(414, 62);
            this.outputtextBox.TabIndex = 8;
            // 
            // startlistenbutton
            // 
            this.startlistenbutton.Location = new System.Drawing.Point(69, 255);
            this.startlistenbutton.Name = "startlistenbutton";
            this.startlistenbutton.Size = new System.Drawing.Size(75, 23);
            this.startlistenbutton.TabIndex = 9;
            this.startlistenbutton.Text = "开始监听";
            this.startlistenbutton.UseVisualStyleBackColor = true;
            this.startlistenbutton.Click += new System.EventHandler(this.startlistenbutton_Click);
            // 
            // sandmessagebutton
            // 
            this.sandmessagebutton.Location = new System.Drawing.Point(215, 255);
            this.sandmessagebutton.Name = "sandmessagebutton";
            this.sandmessagebutton.Size = new System.Drawing.Size(75, 23);
            this.sandmessagebutton.TabIndex = 10;
            this.sandmessagebutton.Text = "发送信息";
            this.sandmessagebutton.UseVisualStyleBackColor = true;
            // 
            // stoplistenbutton
            // 
            this.stoplistenbutton.Location = new System.Drawing.Point(366, 255);
            this.stoplistenbutton.Name = "stoplistenbutton";
            this.stoplistenbutton.Size = new System.Drawing.Size(75, 23);
            this.stoplistenbutton.TabIndex = 11;
            this.stoplistenbutton.Text = "停止监听";
            this.stoplistenbutton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 285);
            this.Controls.Add(this.stoplistenbutton);
            this.Controls.Add(this.sandmessagebutton);
            this.Controls.Add(this.startlistenbutton);
            this.Controls.Add(this.outputtextBox);
            this.Controls.Add(this.inputtextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.porttextBox);
            this.Controls.Add(this.servertextBox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox porttextBox;
        private System.Windows.Forms.TextBox servertextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox inputtextBox;
        private System.Windows.Forms.TextBox outputtextBox;
        private System.Windows.Forms.Button startlistenbutton;
        private System.Windows.Forms.Button sandmessagebutton;
        private System.Windows.Forms.Button stoplistenbutton;
    }
}

