namespace 用户登陆窗口作业
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.groupbox = new System.Windows.Forms.GroupBox();
            this.labelUserName = new System.Windows.Forms.Label();
            this.labelPassowrd = new System.Windows.Forms.Label();
            this.lableCode = new System.Windows.Forms.Label();
            this.labelType = new System.Windows.Forms.Label();
            this.textboxUid = new System.Windows.Forms.TextBox();
            this.textboxPwd = new System.Windows.Forms.TextBox();
            this.textboxCode = new System.Windows.Forms.TextBox();
            this.textboxType = new System.Windows.Forms.TextBox();
            this.buttonSignIn = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.groupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.Font = new System.Drawing.Font("楷体", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelTitle.Location = new System.Drawing.Point(12, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(595, 43);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "用户登陆窗口";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupbox
            // 
            this.groupbox.Controls.Add(this.buttonClose);
            this.groupbox.Controls.Add(this.buttonSignIn);
            this.groupbox.Controls.Add(this.textboxType);
            this.groupbox.Controls.Add(this.textboxCode);
            this.groupbox.Controls.Add(this.textboxPwd);
            this.groupbox.Controls.Add(this.textboxUid);
            this.groupbox.Controls.Add(this.labelType);
            this.groupbox.Controls.Add(this.lableCode);
            this.groupbox.Controls.Add(this.labelPassowrd);
            this.groupbox.Controls.Add(this.labelUserName);
            this.groupbox.Location = new System.Drawing.Point(49, 55);
            this.groupbox.Name = "groupbox";
            this.groupbox.Size = new System.Drawing.Size(510, 194);
            this.groupbox.TabIndex = 1;
            this.groupbox.TabStop = false;
            this.groupbox.Text = "请输入";
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Location = new System.Drawing.Point(6, 36);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(53, 12);
            this.labelUserName.TabIndex = 0;
            this.labelUserName.Text = "用户名：";
            // 
            // labelPassowrd
            // 
            this.labelPassowrd.AutoSize = true;
            this.labelPassowrd.Location = new System.Drawing.Point(6, 64);
            this.labelPassowrd.Name = "labelPassowrd";
            this.labelPassowrd.Size = new System.Drawing.Size(47, 12);
            this.labelPassowrd.TabIndex = 1;
            this.labelPassowrd.Text = "密 码：";
            // 
            // lableCode
            // 
            this.lableCode.AutoSize = true;
            this.lableCode.Location = new System.Drawing.Point(6, 90);
            this.lableCode.Name = "lableCode";
            this.lableCode.Size = new System.Drawing.Size(53, 12);
            this.lableCode.TabIndex = 2;
            this.lableCode.Text = "验证码：";
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(6, 119);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(47, 12);
            this.labelType.TabIndex = 3;
            this.labelType.Text = "类 型：";
            // 
            // textboxUid
            // 
            this.textboxUid.Location = new System.Drawing.Point(91, 33);
            this.textboxUid.Name = "textboxUid";
            this.textboxUid.Size = new System.Drawing.Size(174, 21);
            this.textboxUid.TabIndex = 4;
            // 
            // textboxPwd
            // 
            this.textboxPwd.Location = new System.Drawing.Point(91, 61);
            this.textboxPwd.Name = "textboxPwd";
            this.textboxPwd.Size = new System.Drawing.Size(174, 21);
            this.textboxPwd.TabIndex = 5;
            // 
            // textboxCode
            // 
            this.textboxCode.Location = new System.Drawing.Point(91, 88);
            this.textboxCode.Name = "textboxCode";
            this.textboxCode.Size = new System.Drawing.Size(174, 21);
            this.textboxCode.TabIndex = 6;
            // 
            // textboxType
            // 
            this.textboxType.Location = new System.Drawing.Point(91, 116);
            this.textboxType.Name = "textboxType";
            this.textboxType.Size = new System.Drawing.Size(174, 21);
            this.textboxType.TabIndex = 7;
            // 
            // buttonSignIn
            // 
            this.buttonSignIn.Location = new System.Drawing.Point(106, 165);
            this.buttonSignIn.Name = "buttonSignIn";
            this.buttonSignIn.Size = new System.Drawing.Size(75, 23);
            this.buttonSignIn.TabIndex = 8;
            this.buttonSignIn.Text = "登陆";
            this.buttonSignIn.UseVisualStyleBackColor = true;
            this.buttonSignIn.Click += new System.EventHandler(this.buttonSignIn_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(277, 165);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(75, 23);
            this.buttonClose.TabIndex = 9;
            this.buttonClose.Text = "关闭";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 261);
            this.Controls.Add(this.groupbox);
            this.Controls.Add(this.labelTitle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupbox.ResumeLayout(false);
            this.groupbox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.GroupBox groupbox;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Label lableCode;
        private System.Windows.Forms.Label labelPassowrd;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.TextBox textboxType;
        private System.Windows.Forms.TextBox textboxCode;
        private System.Windows.Forms.TextBox textboxPwd;
        private System.Windows.Forms.TextBox textboxUid;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonSignIn;
    }
}

