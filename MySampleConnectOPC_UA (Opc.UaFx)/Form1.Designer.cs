namespace ConnectKepwareOPC_UA
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnConnect = new Button();
            tbxValue = new TextBox();
            lblTag = new Label();
            tbxWriteValue = new TextBox();
            lblValueToWrite = new Label();
            btnDisonnect = new Button();
            btnWrite = new Button();
            btnRead = new Button();
            groupBox1 = new GroupBox();
            lblDataType = new Label();
            lblValue = new Label();
            btnUnsubscribe = new Button();
            btnSubscribe = new Button();
            tbxTag = new TextBox();
            tbxValueDataType = new TextBox();
            lblServerAddress = new Label();
            tbxServerAddress = new TextBox();
            groupBox2 = new GroupBox();
            btnUnsubscribeMulti = new Button();
            btnSubscribeMulti = new Button();
            btnWriteMulti = new Button();
            btnReadMulti = new Button();
            label5 = new Label();
            label2 = new Label();
            label3 = new Label();
            tbxTag4 = new TextBox();
            tbxTag2 = new TextBox();
            tbxDataType4 = new TextBox();
            tbxDataType2 = new TextBox();
            tbxTag3 = new TextBox();
            tbxValue4 = new TextBox();
            tbxTag1 = new TextBox();
            tbxDataType3 = new TextBox();
            tbxValue2 = new TextBox();
            tbxValue3 = new TextBox();
            tbxDataType1 = new TextBox();
            tbxValue1 = new TextBox();
            lblConnectStatus = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // btnConnect
            // 
            btnConnect.Location = new Point(347, 12);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(75, 23);
            btnConnect.TabIndex = 0;
            btnConnect.Text = "Connect";
            btnConnect.UseVisualStyleBackColor = true;
            btnConnect.Click += btnConnect_Click;
            // 
            // tbxValue
            // 
            tbxValue.Location = new Point(19, 89);
            tbxValue.Name = "tbxValue";
            tbxValue.Size = new Size(156, 23);
            tbxValue.TabIndex = 1;
            // 
            // lblTag
            // 
            lblTag.AutoSize = true;
            lblTag.Location = new Point(19, 24);
            lblTag.Name = "lblTag";
            lblTag.Size = new Size(25, 15);
            lblTag.TabIndex = 2;
            lblTag.Text = "Tag";
            // 
            // tbxWriteValue
            // 
            tbxWriteValue.Location = new Point(19, 198);
            tbxWriteValue.Name = "tbxWriteValue";
            tbxWriteValue.Size = new Size(156, 23);
            tbxWriteValue.TabIndex = 1;
            // 
            // lblValueToWrite
            // 
            lblValueToWrite.AutoSize = true;
            lblValueToWrite.Location = new Point(19, 180);
            lblValueToWrite.Name = "lblValueToWrite";
            lblValueToWrite.Size = new Size(81, 15);
            lblValueToWrite.TabIndex = 2;
            lblValueToWrite.Text = "Value To Write";
            // 
            // btnDisonnect
            // 
            btnDisonnect.Enabled = false;
            btnDisonnect.Location = new Point(347, 41);
            btnDisonnect.Name = "btnDisonnect";
            btnDisonnect.Size = new Size(75, 23);
            btnDisonnect.TabIndex = 0;
            btnDisonnect.Text = "Disconnect";
            btnDisonnect.UseVisualStyleBackColor = true;
            btnDisonnect.Click += btnDisonnect_Click;
            // 
            // btnWrite
            // 
            btnWrite.Location = new Point(181, 197);
            btnWrite.Name = "btnWrite";
            btnWrite.Size = new Size(75, 23);
            btnWrite.TabIndex = 0;
            btnWrite.Text = "Write";
            btnWrite.UseVisualStyleBackColor = true;
            btnWrite.Click += btnWrite_Click;
            // 
            // btnRead
            // 
            btnRead.Location = new Point(181, 89);
            btnRead.Name = "btnRead";
            btnRead.Size = new Size(75, 23);
            btnRead.TabIndex = 0;
            btnRead.Text = "Read";
            btnRead.UseVisualStyleBackColor = true;
            btnRead.Click += btnRead_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lblDataType);
            groupBox1.Controls.Add(lblValue);
            groupBox1.Controls.Add(lblTag);
            groupBox1.Controls.Add(btnWrite);
            groupBox1.Controls.Add(lblValueToWrite);
            groupBox1.Controls.Add(btnUnsubscribe);
            groupBox1.Controls.Add(btnSubscribe);
            groupBox1.Controls.Add(btnRead);
            groupBox1.Controls.Add(tbxTag);
            groupBox1.Controls.Add(tbxValueDataType);
            groupBox1.Controls.Add(tbxValue);
            groupBox1.Controls.Add(tbxWriteValue);
            groupBox1.Location = new Point(12, 89);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(410, 240);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Single Tag";
            // 
            // lblDataType
            // 
            lblDataType.AutoSize = true;
            lblDataType.Location = new Point(19, 114);
            lblDataType.Name = "lblDataType";
            lblDataType.Size = new Size(83, 15);
            lblDataType.TabIndex = 2;
            lblDataType.Text = "ValueDataType";
            // 
            // lblValue
            // 
            lblValue.AutoSize = true;
            lblValue.Location = new Point(19, 71);
            lblValue.Name = "lblValue";
            lblValue.Size = new Size(35, 15);
            lblValue.TabIndex = 2;
            lblValue.Text = "Value";
            // 
            // btnUnsubscribe
            // 
            btnUnsubscribe.Location = new Point(306, 118);
            btnUnsubscribe.Name = "btnUnsubscribe";
            btnUnsubscribe.Size = new Size(83, 23);
            btnUnsubscribe.TabIndex = 0;
            btnUnsubscribe.Text = "Unsubscribe";
            btnUnsubscribe.UseVisualStyleBackColor = true;
            btnUnsubscribe.Click += btnUnsubcribe_Click;
            // 
            // btnSubscribe
            // 
            btnSubscribe.Location = new Point(306, 89);
            btnSubscribe.Name = "btnSubscribe";
            btnSubscribe.Size = new Size(83, 23);
            btnSubscribe.TabIndex = 0;
            btnSubscribe.Text = "Subscribe";
            btnSubscribe.UseVisualStyleBackColor = true;
            btnSubscribe.Click += btnSubcribe_Click;
            // 
            // tbxTag
            // 
            tbxTag.Location = new Point(19, 42);
            tbxTag.Name = "tbxTag";
            tbxTag.Size = new Size(288, 23);
            tbxTag.TabIndex = 1;
            tbxTag.Text = "ns=2;s=Channel1.Device1.Tag1";
            // 
            // tbxValueDataType
            // 
            tbxValueDataType.Location = new Point(19, 132);
            tbxValueDataType.Name = "tbxValueDataType";
            tbxValueDataType.Size = new Size(156, 23);
            tbxValueDataType.TabIndex = 1;
            // 
            // lblServerAddress
            // 
            lblServerAddress.AutoSize = true;
            lblServerAddress.Location = new Point(8, 15);
            lblServerAddress.Name = "lblServerAddress";
            lblServerAddress.Size = new Size(39, 15);
            lblServerAddress.TabIndex = 2;
            lblServerAddress.Text = "Server";
            // 
            // tbxServerAddress
            // 
            tbxServerAddress.Location = new Point(53, 12);
            tbxServerAddress.Name = "tbxServerAddress";
            tbxServerAddress.Size = new Size(288, 23);
            tbxServerAddress.TabIndex = 1;
            tbxServerAddress.Text = "opc.tcp://10.84.1.68:49320";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnUnsubscribeMulti);
            groupBox2.Controls.Add(btnSubscribeMulti);
            groupBox2.Controls.Add(btnWriteMulti);
            groupBox2.Controls.Add(btnReadMulti);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(tbxTag4);
            groupBox2.Controls.Add(tbxTag2);
            groupBox2.Controls.Add(tbxDataType4);
            groupBox2.Controls.Add(tbxDataType2);
            groupBox2.Controls.Add(tbxTag3);
            groupBox2.Controls.Add(tbxValue4);
            groupBox2.Controls.Add(tbxTag1);
            groupBox2.Controls.Add(tbxDataType3);
            groupBox2.Controls.Add(tbxValue2);
            groupBox2.Controls.Add(tbxValue3);
            groupBox2.Controls.Add(tbxDataType1);
            groupBox2.Controls.Add(tbxValue1);
            groupBox2.Location = new Point(461, 89);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(450, 240);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Multiple Tag";
            // 
            // btnUnsubscribeMulti
            // 
            btnUnsubscribeMulti.Location = new Point(319, 197);
            btnUnsubscribeMulti.Name = "btnUnsubscribeMulti";
            btnUnsubscribeMulti.Size = new Size(110, 23);
            btnUnsubscribeMulti.TabIndex = 4;
            btnUnsubscribeMulti.Text = "UnsubscribeMulti";
            btnUnsubscribeMulti.UseVisualStyleBackColor = true;
            btnUnsubscribeMulti.Click += btnUnsubscribeMulti_Click;
            // 
            // btnSubscribeMulti
            // 
            btnSubscribeMulti.Location = new Point(319, 172);
            btnSubscribeMulti.Name = "btnSubscribeMulti";
            btnSubscribeMulti.Size = new Size(110, 23);
            btnSubscribeMulti.TabIndex = 4;
            btnSubscribeMulti.Text = "SubscribeMulti";
            btnSubscribeMulti.UseVisualStyleBackColor = true;
            btnSubscribeMulti.Click += btnSubscribeMulti_Click;
            // 
            // btnWriteMulti
            // 
            btnWriteMulti.Location = new Point(19, 198);
            btnWriteMulti.Name = "btnWriteMulti";
            btnWriteMulti.Size = new Size(75, 23);
            btnWriteMulti.TabIndex = 3;
            btnWriteMulti.Text = "WriteMulti";
            btnWriteMulti.UseVisualStyleBackColor = true;
            // 
            // btnReadMulti
            // 
            btnReadMulti.Location = new Point(19, 172);
            btnReadMulti.Name = "btnReadMulti";
            btnReadMulti.Size = new Size(75, 23);
            btnReadMulti.TabIndex = 3;
            btnReadMulti.Text = "RealMulti";
            btnReadMulti.UseVisualStyleBackColor = true;
            btnReadMulti.Click += btnReadMulti_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(328, 24);
            label5.Name = "label5";
            label5.Size = new Size(58, 15);
            label5.TabIndex = 2;
            label5.Text = "Data Type";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(221, 24);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 2;
            label2.Text = "Value";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 24);
            label3.Name = "label3";
            label3.Size = new Size(25, 15);
            label3.TabIndex = 2;
            label3.Text = "Tag";
            // 
            // tbxTag4
            // 
            tbxTag4.Location = new Point(19, 131);
            tbxTag4.Name = "tbxTag4";
            tbxTag4.Size = new Size(196, 23);
            tbxTag4.TabIndex = 1;
            tbxTag4.Text = "ns=2;s=Channel1.Device1.Tag4";
            // 
            // tbxTag2
            // 
            tbxTag2.Location = new Point(19, 72);
            tbxTag2.Name = "tbxTag2";
            tbxTag2.Size = new Size(196, 23);
            tbxTag2.TabIndex = 1;
            tbxTag2.Text = "ns=2;s=Channel1.Device1.Tag2";
            // 
            // tbxDataType4
            // 
            tbxDataType4.Location = new Point(328, 131);
            tbxDataType4.Name = "tbxDataType4";
            tbxDataType4.Size = new Size(101, 23);
            tbxDataType4.TabIndex = 1;
            // 
            // tbxDataType2
            // 
            tbxDataType2.Location = new Point(328, 72);
            tbxDataType2.Name = "tbxDataType2";
            tbxDataType2.Size = new Size(101, 23);
            tbxDataType2.TabIndex = 1;
            // 
            // tbxTag3
            // 
            tbxTag3.Location = new Point(19, 101);
            tbxTag3.Name = "tbxTag3";
            tbxTag3.Size = new Size(196, 23);
            tbxTag3.TabIndex = 1;
            tbxTag3.Text = "ns=2;s=Channel1.Device1.Tag3";
            // 
            // tbxValue4
            // 
            tbxValue4.Location = new Point(221, 131);
            tbxValue4.Name = "tbxValue4";
            tbxValue4.Size = new Size(101, 23);
            tbxValue4.TabIndex = 1;
            // 
            // tbxTag1
            // 
            tbxTag1.Location = new Point(19, 42);
            tbxTag1.Name = "tbxTag1";
            tbxTag1.Size = new Size(196, 23);
            tbxTag1.TabIndex = 1;
            tbxTag1.Text = "ns=2;s=Channel1.Device1.Tag1";
            // 
            // tbxDataType3
            // 
            tbxDataType3.Location = new Point(328, 101);
            tbxDataType3.Name = "tbxDataType3";
            tbxDataType3.Size = new Size(101, 23);
            tbxDataType3.TabIndex = 1;
            // 
            // tbxValue2
            // 
            tbxValue2.Location = new Point(221, 72);
            tbxValue2.Name = "tbxValue2";
            tbxValue2.Size = new Size(101, 23);
            tbxValue2.TabIndex = 1;
            // 
            // tbxValue3
            // 
            tbxValue3.Location = new Point(221, 101);
            tbxValue3.Name = "tbxValue3";
            tbxValue3.Size = new Size(101, 23);
            tbxValue3.TabIndex = 1;
            // 
            // tbxDataType1
            // 
            tbxDataType1.Location = new Point(328, 42);
            tbxDataType1.Name = "tbxDataType1";
            tbxDataType1.Size = new Size(101, 23);
            tbxDataType1.TabIndex = 1;
            // 
            // tbxValue1
            // 
            tbxValue1.Location = new Point(221, 42);
            tbxValue1.Name = "tbxValue1";
            tbxValue1.Size = new Size(101, 23);
            tbxValue1.TabIndex = 1;
            // 
            // lblConnectStatus
            // 
            lblConnectStatus.AutoSize = true;
            lblConnectStatus.Location = new Point(53, 41);
            lblConnectStatus.Name = "lblConnectStatus";
            lblConnectStatus.Size = new Size(66, 15);
            lblConnectStatus.TabIndex = 2;
            lblConnectStatus.Text = "Disconnect";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(948, 352);
            Controls.Add(lblConnectStatus);
            Controls.Add(lblServerAddress);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btnDisonnect);
            Controls.Add(btnConnect);
            Controls.Add(tbxServerAddress);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnConnect;
        private TextBox tbxValue;
        private Label lblTag;
        private TextBox tbxWriteValue;
        private Label lblValueToWrite;
        private Button btnDisonnect;
        private Button btnWrite;
        private Button btnRead;
        private GroupBox groupBox1;
        private Label lblServerAddress;
        private TextBox tbxServerAddress;
        private TextBox tbxTag;
        private Label lblValue;
        private Button btnSubscribe;
        private Label lblDataType;
        private TextBox tbxValueDataType;
        private Button btnUnsubscribe;
        private GroupBox groupBox2;
        private Label label2;
        private Label label3;
        private TextBox tbxTag1;
        private TextBox tbxValue1;
        private Label label5;
        private TextBox tbxDataType1;
        private TextBox tbxTag4;
        private TextBox tbxTag2;
        private TextBox tbxDataType4;
        private TextBox tbxDataType2;
        private TextBox tbxTag3;
        private TextBox tbxValue4;
        private TextBox tbxDataType3;
        private TextBox tbxValue2;
        private TextBox tbxValue3;
        private Button btnWriteMulti;
        private Button btnReadMulti;
        private Label lblConnectStatus;
        private Button btnUnsubscribeMulti;
        private Button btnSubscribeMulti;
    }
}
