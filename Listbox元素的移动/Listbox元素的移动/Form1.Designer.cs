namespace Listbox元素的移动
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
            this.toleftbutton = new System.Windows.Forms.Button();
            this.torightbutton = new System.Windows.Forms.Button();
            this.leftListbox = new System.Windows.Forms.ListBox();
            this.rightListbox = new System.Windows.Forms.ListBox();
            this.toleftallbutton = new System.Windows.Forms.Button();
            this.torightallbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.xueshilabel = new System.Windows.Forms.Label();
            this.xuefenglabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // toleftbutton
            // 
            this.toleftbutton.Location = new System.Drawing.Point(282, 35);
            this.toleftbutton.Name = "toleftbutton";
            this.toleftbutton.Size = new System.Drawing.Size(75, 23);
            this.toleftbutton.TabIndex = 0;
            this.toleftbutton.Text = "<";
            this.toleftbutton.UseVisualStyleBackColor = true;
            this.toleftbutton.Click += new System.EventHandler(this.toleftbutton_Click);
            // 
            // torightbutton
            // 
            this.torightbutton.Location = new System.Drawing.Point(282, 184);
            this.torightbutton.Name = "torightbutton";
            this.torightbutton.Size = new System.Drawing.Size(75, 23);
            this.torightbutton.TabIndex = 1;
            this.torightbutton.Text = ">";
            this.torightbutton.UseVisualStyleBackColor = true;
            this.torightbutton.Click += new System.EventHandler(this.torightbutton_Click);
            // 
            // leftListbox
            // 
            this.leftListbox.FormattingEnabled = true;
            this.leftListbox.ItemHeight = 12;
            this.leftListbox.Location = new System.Drawing.Point(13, 35);
            this.leftListbox.Name = "leftListbox";
            this.leftListbox.Size = new System.Drawing.Size(196, 172);
            this.leftListbox.TabIndex = 2;
            // 
            // rightListbox
            // 
            this.rightListbox.FormattingEnabled = true;
            this.rightListbox.ItemHeight = 12;
            this.rightListbox.Location = new System.Drawing.Point(444, 35);
            this.rightListbox.Name = "rightListbox";
            this.rightListbox.Size = new System.Drawing.Size(196, 172);
            this.rightListbox.TabIndex = 3;
            // 
            // toleftallbutton
            // 
            this.toleftallbutton.Location = new System.Drawing.Point(282, 77);
            this.toleftallbutton.Name = "toleftallbutton";
            this.toleftallbutton.Size = new System.Drawing.Size(75, 23);
            this.toleftallbutton.TabIndex = 4;
            this.toleftallbutton.Text = "<<";
            this.toleftallbutton.UseVisualStyleBackColor = true;
            this.toleftallbutton.Click += new System.EventHandler(this.toleftallbutton_Click);
            // 
            // torightallbutton
            // 
            this.torightallbutton.Location = new System.Drawing.Point(282, 146);
            this.torightallbutton.Name = "torightallbutton";
            this.torightallbutton.Size = new System.Drawing.Size(75, 23);
            this.torightallbutton.TabIndex = 5;
            this.torightallbutton.Text = ">>";
            this.torightallbutton.UseVisualStyleBackColor = true;
            this.torightallbutton.Click += new System.EventHandler(this.torightallbutton_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(12, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 6;
            this.label1.Text = "已选学时";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(441, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "已选学分";
            // 
            // xueshilabel
            // 
            this.xueshilabel.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.xueshilabel.Location = new System.Drawing.Point(107, 229);
            this.xueshilabel.Name = "xueshilabel";
            this.xueshilabel.Size = new System.Drawing.Size(100, 23);
            this.xueshilabel.TabIndex = 8;
            this.xueshilabel.Text = "label3";
            // 
            // xuefenglabel
            // 
            this.xuefenglabel.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.xuefenglabel.Location = new System.Drawing.Point(548, 228);
            this.xuefenglabel.Name = "xuefenglabel";
            this.xuefenglabel.Size = new System.Drawing.Size(100, 23);
            this.xuefenglabel.TabIndex = 9;
            this.xuefenglabel.Text = "label4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 261);
            this.Controls.Add(this.xuefenglabel);
            this.Controls.Add(this.xueshilabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.torightallbutton);
            this.Controls.Add(this.toleftallbutton);
            this.Controls.Add(this.rightListbox);
            this.Controls.Add(this.leftListbox);
            this.Controls.Add(this.torightbutton);
            this.Controls.Add(this.toleftbutton);
            this.Name = "Form1";
            this.Text = "C#作业";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button toleftbutton;
        private System.Windows.Forms.Button torightbutton;
        private System.Windows.Forms.ListBox leftListbox;
        private System.Windows.Forms.ListBox rightListbox;
        private System.Windows.Forms.Button toleftallbutton;
        private System.Windows.Forms.Button torightallbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label xueshilabel;
        private System.Windows.Forms.Label xuefenglabel;
    }
}

