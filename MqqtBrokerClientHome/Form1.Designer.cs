
namespace MqqtBrokerClientHome
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnPublish = new System.Windows.Forms.Button();
            this.txtAlıcı = new System.Windows.Forms.ListBox();
            this.lblSay = new System.Windows.Forms.Label();
            this.lbldeneme = new System.Windows.Forms.Label();
            this.lblMN01 = new System.Windows.Forms.Label();
            this.timer_MN01 = new System.Windows.Forms.Timer(this.components);
            this.timer1_MN02 = new System.Windows.Forms.Timer(this.components);
            this.lblMN02 = new System.Windows.Forms.Label();
            this.timer_CMA03 = new System.Windows.Forms.Timer(this.components);
            this.lblCMA03 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(776, 20);
            this.textBox1.TabIndex = 0;
            // 
            // btnPublish
            // 
            this.btnPublish.Location = new System.Drawing.Point(678, 38);
            this.btnPublish.Name = "btnPublish";
            this.btnPublish.Size = new System.Drawing.Size(110, 38);
            this.btnPublish.TabIndex = 1;
            this.btnPublish.Text = "Publish";
            this.btnPublish.UseVisualStyleBackColor = true;
            this.btnPublish.Click += new System.EventHandler(this.btnPublish_Click);
            // 
            // txtAlıcı
            // 
            this.txtAlıcı.FormattingEnabled = true;
            this.txtAlıcı.Location = new System.Drawing.Point(5, 330);
            this.txtAlıcı.Name = "txtAlıcı";
            this.txtAlıcı.Size = new System.Drawing.Size(783, 108);
            this.txtAlıcı.TabIndex = 4;
            // 
            // lblSay
            // 
            this.lblSay.AutoSize = true;
            this.lblSay.Location = new System.Drawing.Point(12, 228);
            this.lblSay.Name = "lblSay";
            this.lblSay.Size = new System.Drawing.Size(35, 13);
            this.lblSay.TabIndex = 5;
            this.lblSay.Text = "label1";
            // 
            // lbldeneme
            // 
            this.lbldeneme.AutoSize = true;
            this.lbldeneme.Location = new System.Drawing.Point(12, 187);
            this.lbldeneme.Name = "lbldeneme";
            this.lbldeneme.Size = new System.Drawing.Size(35, 13);
            this.lbldeneme.TabIndex = 6;
            this.lbldeneme.Text = "label1";
            // 
            // lblMN01
            // 
            this.lblMN01.AutoSize = true;
            this.lblMN01.Location = new System.Drawing.Point(253, 289);
            this.lblMN01.Name = "lblMN01";
            this.lblMN01.Size = new System.Drawing.Size(35, 13);
            this.lblMN01.TabIndex = 7;
            this.lblMN01.Text = "label1";
            // 
            // timer_MN01
            // 
            this.timer_MN01.Tick += new System.EventHandler(this.timer_MN01_Tick);
            // 
            // timer1_MN02
            // 
            this.timer1_MN02.Tick += new System.EventHandler(this.timer1_MN02_Tick);
            // 
            // lblMN02
            // 
            this.lblMN02.AutoSize = true;
            this.lblMN02.Location = new System.Drawing.Point(304, 289);
            this.lblMN02.Name = "lblMN02";
            this.lblMN02.Size = new System.Drawing.Size(35, 13);
            this.lblMN02.TabIndex = 8;
            this.lblMN02.Text = "label1";
            // 
            // timer_CMA03
            // 
            this.timer_CMA03.Tick += new System.EventHandler(this.timer_CMA03_Tick);
            // 
            // lblCMA03
            // 
            this.lblCMA03.AutoSize = true;
            this.lblCMA03.Location = new System.Drawing.Point(345, 289);
            this.lblCMA03.Name = "lblCMA03";
            this.lblCMA03.Size = new System.Drawing.Size(35, 13);
            this.lblCMA03.TabIndex = 9;
            this.lblCMA03.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblCMA03);
            this.Controls.Add(this.lblMN02);
            this.Controls.Add(this.lblMN01);
            this.Controls.Add(this.lbldeneme);
            this.Controls.Add(this.lblSay);
            this.Controls.Add(this.txtAlıcı);
            this.Controls.Add(this.btnPublish);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnPublish;
        private System.Windows.Forms.ListBox txtAlıcı;
        private System.Windows.Forms.Label lblSay;
        private System.Windows.Forms.Label lbldeneme;
        private System.Windows.Forms.Label lblMN01;
        private System.Windows.Forms.Timer timer_MN01;
        private System.Windows.Forms.Timer timer1_MN02;
        private System.Windows.Forms.Label lblMN02;
        private System.Windows.Forms.Timer timer_CMA03;
        private System.Windows.Forms.Label lblCMA03;
    }
}

