﻿
namespace _0411
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
            this.lblTargetIP = new System.Windows.Forms.Label();
            this.lblTargetPort = new System.Windows.Forms.Label();
            this.lblListen = new System.Windows.Forms.Label();
            this.txtbTargetIP = new System.Windows.Forms.TextBox();
            this.txtbTargetport = new System.Windows.Forms.TextBox();
            this.txtbListenPort = new System.Windows.Forms.TextBox();
            this.btnConnent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTargetIP
            // 
            this.lblTargetIP.AutoSize = true;
            this.lblTargetIP.Location = new System.Drawing.Point(117, 84);
            this.lblTargetIP.Name = "lblTargetIP";
            this.lblTargetIP.Size = new System.Drawing.Size(39, 12);
            this.lblTargetIP.TabIndex = 0;
            this.lblTargetIP.Text = "目標IP";
            // 
            // lblTargetPort
            // 
            this.lblTargetPort.AutoSize = true;
            this.lblTargetPort.Location = new System.Drawing.Point(268, 84);
            this.lblTargetPort.Name = "lblTargetPort";
            this.lblTargetPort.Size = new System.Drawing.Size(48, 12);
            this.lblTargetPort.TabIndex = 1;
            this.lblTargetPort.Text = "目標port";
            // 
            // lblListen
            // 
            this.lblListen.AutoSize = true;
            this.lblListen.Location = new System.Drawing.Point(428, 84);
            this.lblListen.Name = "lblListen";
            this.lblListen.Size = new System.Drawing.Size(48, 12);
            this.lblListen.TabIndex = 2;
            this.lblListen.Text = "接聽port";
            // 
            // txtbTargetIP
            // 
            this.txtbTargetIP.Location = new System.Drawing.Point(162, 81);
            this.txtbTargetIP.Name = "txtbTargetIP";
            this.txtbTargetIP.Size = new System.Drawing.Size(100, 22);
            this.txtbTargetIP.TabIndex = 3;
            // 
            // txtbTargetport
            // 
            this.txtbTargetport.Location = new System.Drawing.Point(322, 81);
            this.txtbTargetport.Name = "txtbTargetport";
            this.txtbTargetport.Size = new System.Drawing.Size(100, 22);
            this.txtbTargetport.TabIndex = 4;
            // 
            // txtbListenPort
            // 
            this.txtbListenPort.Location = new System.Drawing.Point(482, 80);
            this.txtbListenPort.Name = "txtbListenPort";
            this.txtbListenPort.Size = new System.Drawing.Size(100, 22);
            this.txtbListenPort.TabIndex = 5;
            // 
            // btnConnent
            // 
            this.btnConnent.Location = new System.Drawing.Point(598, 80);
            this.btnConnent.Name = "btnConnent";
            this.btnConnent.Size = new System.Drawing.Size(75, 23);
            this.btnConnent.TabIndex = 6;
            this.btnConnent.Text = "連線";
            this.btnConnent.UseVisualStyleBackColor = true;
            this.btnConnent.Click += new System.EventHandler(this.btnConnent_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnConnent);
            this.Controls.Add(this.txtbListenPort);
            this.Controls.Add(this.txtbTargetport);
            this.Controls.Add(this.txtbTargetIP);
            this.Controls.Add(this.lblListen);
            this.Controls.Add(this.lblTargetPort);
            this.Controls.Add(this.lblTargetIP);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTargetIP;
        private System.Windows.Forms.Label lblTargetPort;
        private System.Windows.Forms.Label lblListen;
        private System.Windows.Forms.TextBox txtbTargetIP;
        private System.Windows.Forms.TextBox txtbTargetport;
        private System.Windows.Forms.TextBox txtbListenPort;
        private System.Windows.Forms.Button btnConnent;
    }
}

