namespace ChatTecLaguna
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.serverTextBOX = new System.Windows.Forms.TextBox();
            this.portTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupchatTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.userTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.messagesTextBox = new System.Windows.Forms.TextBox();
            this.dataToSentTextBox = new System.Windows.Forms.TextBox();
            this.connectButton = new System.Windows.Forms.Button();
            this.sendButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "SERVER";
            // 
            // serverTextBOX
            // 
            this.serverTextBOX.Location = new System.Drawing.Point(105, 35);
            this.serverTextBOX.Name = "serverTextBOX";
            this.serverTextBOX.Size = new System.Drawing.Size(100, 20);
            this.serverTextBOX.TabIndex = 1;
            this.serverTextBOX.Text = "10.13.3.70";
            // 
            // portTextBox
            // 
            this.portTextBox.Location = new System.Drawing.Point(105, 71);
            this.portTextBox.Name = "portTextBox";
            this.portTextBox.Size = new System.Drawing.Size(100, 20);
            this.portTextBox.TabIndex = 3;
            this.portTextBox.Text = "1883";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "PORT";
            // 
            // groupchatTextBox
            // 
            this.groupchatTextBox.Location = new System.Drawing.Point(105, 108);
            this.groupchatTextBox.Name = "groupchatTextBox";
            this.groupchatTextBox.Size = new System.Drawing.Size(100, 20);
            this.groupchatTextBox.TabIndex = 5;
            this.groupchatTextBox.Text = "Mesa1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "CHAT GROUP";
            // 
            // userTextBox
            // 
            this.userTextBox.Location = new System.Drawing.Point(315, 38);
            this.userTextBox.Name = "userTextBox";
            this.userTextBox.Size = new System.Drawing.Size(159, 20);
            this.userTextBox.TabIndex = 7;
            this.userTextBox.Text = "EMILIANO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(258, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "USER";
            // 
            // messagesTextBox
            // 
            this.messagesTextBox.Location = new System.Drawing.Point(105, 161);
            this.messagesTextBox.Multiline = true;
            this.messagesTextBox.Name = "messagesTextBox";
            this.messagesTextBox.ReadOnly = true;
            this.messagesTextBox.Size = new System.Drawing.Size(369, 165);
            this.messagesTextBox.TabIndex = 8;
            // 
            // dataToSentTextBox
            // 
            this.dataToSentTextBox.Location = new System.Drawing.Point(105, 350);
            this.dataToSentTextBox.Name = "dataToSentTextBox";
            this.dataToSentTextBox.Size = new System.Drawing.Size(261, 20);
            this.dataToSentTextBox.TabIndex = 9;
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(399, 111);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(75, 23);
            this.connectButton.TabIndex = 10;
            this.connectButton.Text = "CONNECT";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // sendButton
            // 
            this.sendButton.Location = new System.Drawing.Point(399, 347);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(75, 23);
            this.sendButton.TabIndex = 11;
            this.sendButton.Text = "SEND";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 497);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.dataToSentTextBox);
            this.Controls.Add(this.messagesTextBox);
            this.Controls.Add(this.userTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupchatTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.portTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.serverTextBOX);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox serverTextBOX;
        private System.Windows.Forms.TextBox portTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox groupchatTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox userTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox messagesTextBox;
        private System.Windows.Forms.TextBox dataToSentTextBox;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Button sendButton;
    }
}

