
namespace project006
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
            this.devicesTextBox = new System.Windows.Forms.TextBox();
            this.linesTextBox = new System.Windows.Forms.TextBox();
            this.packetsTextBox = new System.Windows.Forms.TextBox();
            this.addDeviceButton = new System.Windows.Forms.Button();
            this.addLineButton = new System.Windows.Forms.Button();
            this.removeDeviceButton = new System.Windows.Forms.Button();
            this.removeLineButton = new System.Windows.Forms.Button();
            this.generatePacketButton = new System.Windows.Forms.Button();
            this.calculateStatisticsButton = new System.Windows.Forms.Button();
            this.linesListBox = new System.Windows.Forms.ListBox();
            this.deviceTextBox = new System.Windows.Forms.TextBox();
            this.senderTextBox = new System.Windows.Forms.TextBox();
            this.receiverTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // devicesTextBox
            // 
            this.devicesTextBox.Location = new System.Drawing.Point(65, 47);
            this.devicesTextBox.Name = "devicesTextBox";
            this.devicesTextBox.Size = new System.Drawing.Size(114, 20);
            this.devicesTextBox.TabIndex = 0;
            // 
            // linesTextBox
            // 
            this.linesTextBox.Location = new System.Drawing.Point(65, 99);
            this.linesTextBox.Name = "linesTextBox";
            this.linesTextBox.Size = new System.Drawing.Size(114, 20);
            this.linesTextBox.TabIndex = 1;
            // 
            // packetsTextBox
            // 
            this.packetsTextBox.Location = new System.Drawing.Point(65, 152);
            this.packetsTextBox.Name = "packetsTextBox";
            this.packetsTextBox.Size = new System.Drawing.Size(114, 20);
            this.packetsTextBox.TabIndex = 2;
            // 
            // addDeviceButton
            // 
            this.addDeviceButton.Location = new System.Drawing.Point(473, 68);
            this.addDeviceButton.Name = "addDeviceButton";
            this.addDeviceButton.Size = new System.Drawing.Size(75, 30);
            this.addDeviceButton.TabIndex = 3;
            this.addDeviceButton.Text = "AddDevice";
            this.addDeviceButton.UseVisualStyleBackColor = true;
            // 
            // addLineButton
            // 
            this.addLineButton.Location = new System.Drawing.Point(563, 68);
            this.addLineButton.Name = "addLineButton";
            this.addLineButton.Size = new System.Drawing.Size(75, 30);
            this.addLineButton.TabIndex = 4;
            this.addLineButton.Text = "AddLine";
            this.addLineButton.UseVisualStyleBackColor = true;
            // 
            // removeDeviceButton
            // 
            this.removeDeviceButton.Location = new System.Drawing.Point(661, 68);
            this.removeDeviceButton.Name = "removeDeviceButton";
            this.removeDeviceButton.Size = new System.Drawing.Size(94, 30);
            this.removeDeviceButton.TabIndex = 5;
            this.removeDeviceButton.Text = "RemoveDevice";
            this.removeDeviceButton.UseVisualStyleBackColor = true;
            // 
            // removeLineButton
            // 
            this.removeLineButton.Location = new System.Drawing.Point(473, 127);
            this.removeLineButton.Name = "removeLineButton";
            this.removeLineButton.Size = new System.Drawing.Size(75, 33);
            this.removeLineButton.TabIndex = 6;
            this.removeLineButton.Text = "RemoveLine";
            this.removeLineButton.UseVisualStyleBackColor = true;
            // 
            // generatePacketButton
            // 
            this.generatePacketButton.Location = new System.Drawing.Point(563, 124);
            this.generatePacketButton.Name = "generatePacketButton";
            this.generatePacketButton.Size = new System.Drawing.Size(75, 38);
            this.generatePacketButton.TabIndex = 7;
            this.generatePacketButton.Text = "Generate Packet";
            this.generatePacketButton.UseVisualStyleBackColor = true;
            // 
            // calculateStatisticsButton
            // 
            this.calculateStatisticsButton.Location = new System.Drawing.Point(667, 125);
            this.calculateStatisticsButton.Name = "calculateStatisticsButton";
            this.calculateStatisticsButton.Size = new System.Drawing.Size(88, 37);
            this.calculateStatisticsButton.TabIndex = 8;
            this.calculateStatisticsButton.Text = "Calculate Statistics";
            this.calculateStatisticsButton.UseVisualStyleBackColor = true;
            // 
            // linesListBox
            // 
            this.linesListBox.FormattingEnabled = true;
            this.linesListBox.Location = new System.Drawing.Point(65, 207);
            this.linesListBox.Name = "linesListBox";
            this.linesListBox.Size = new System.Drawing.Size(120, 186);
            this.linesListBox.TabIndex = 9;
            // 
            // deviceTextBox
            // 
            this.deviceTextBox.Location = new System.Drawing.Point(270, 220);
            this.deviceTextBox.Name = "deviceTextBox";
            this.deviceTextBox.Size = new System.Drawing.Size(100, 20);
            this.deviceTextBox.TabIndex = 10;
            // 
            // senderTextBox
            // 
            this.senderTextBox.Location = new System.Drawing.Point(270, 273);
            this.senderTextBox.Name = "senderTextBox";
            this.senderTextBox.Size = new System.Drawing.Size(100, 20);
            this.senderTextBox.TabIndex = 11;
            // 
            // receiverTextBox
            // 
            this.receiverTextBox.Location = new System.Drawing.Point(270, 328);
            this.receiverTextBox.Name = "receiverTextBox";
            this.receiverTextBox.Size = new System.Drawing.Size(100, 20);
            this.receiverTextBox.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.receiverTextBox);
            this.Controls.Add(this.senderTextBox);
            this.Controls.Add(this.deviceTextBox);
            this.Controls.Add(this.linesListBox);
            this.Controls.Add(this.calculateStatisticsButton);
            this.Controls.Add(this.generatePacketButton);
            this.Controls.Add(this.removeLineButton);
            this.Controls.Add(this.removeDeviceButton);
            this.Controls.Add(this.addLineButton);
            this.Controls.Add(this.addDeviceButton);
            this.Controls.Add(this.packetsTextBox);
            this.Controls.Add(this.linesTextBox);
            this.Controls.Add(this.devicesTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox devicesTextBox;
        private System.Windows.Forms.TextBox linesTextBox;
        private System.Windows.Forms.TextBox packetsTextBox;
        private System.Windows.Forms.Button addDeviceButton;
        private System.Windows.Forms.Button addLineButton;
        private System.Windows.Forms.Button removeDeviceButton;
        private System.Windows.Forms.Button removeLineButton;
        private System.Windows.Forms.Button generatePacketButton;
        private System.Windows.Forms.Button calculateStatisticsButton;
        private System.Windows.Forms.ListBox linesListBox;
        private System.Windows.Forms.TextBox deviceTextBox;
        private System.Windows.Forms.TextBox senderTextBox;
        private System.Windows.Forms.TextBox receiverTextBox;
    }
}

