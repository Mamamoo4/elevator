namespace elevatorSystem
{
    partial class MainForm
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
            this.btnStart = new System.Windows.Forms.Button();
            this.btnRandom = new System.Windows.Forms.Button();
            this.lblDirection = new System.Windows.Forms.Label();
            this.lblCurrentFloor = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnA = new System.Windows.Forms.Button();
            this.lblTargetA = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCurrentA = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblStatusA = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblStatusB = new System.Windows.Forms.Label();
            this.btnB = new System.Windows.Forms.Button();
            this.txtCurrentB = new System.Windows.Forms.TextBox();
            this.lblTargetB = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblStatusC = new System.Windows.Forms.Label();
            this.btnC = new System.Windows.Forms.Button();
            this.txtCurrentC = new System.Windows.Forms.TextBox();
            this.lblTargetC = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lblStatusD = new System.Windows.Forms.Label();
            this.btnD = new System.Windows.Forms.Button();
            this.txtCurrentD = new System.Windows.Forms.TextBox();
            this.lblTargetD = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnFloor1 = new System.Windows.Forms.Button();
            this.btnFloor2 = new System.Windows.Forms.Button();
            this.btnFloor3 = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnFloor13 = new System.Windows.Forms.Button();
            this.btnFloor15 = new System.Windows.Forms.Button();
            this.btnFloor14 = new System.Windows.Forms.Button();
            this.btnFloor10 = new System.Windows.Forms.Button();
            this.btnFloor12 = new System.Windows.Forms.Button();
            this.btnFloor11 = new System.Windows.Forms.Button();
            this.btnFloor7 = new System.Windows.Forms.Button();
            this.btnFloor9 = new System.Windows.Forms.Button();
            this.btnFloor8 = new System.Windows.Forms.Button();
            this.btnFloor4 = new System.Windows.Forms.Button();
            this.btnFloor6 = new System.Windows.Forms.Button();
            this.btnFloor5 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("微軟正黑體", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnStart.Location = new System.Drawing.Point(181, 163);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(137, 86);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "開 始";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnRandom
            // 
            this.btnRandom.Font = new System.Drawing.Font("微軟正黑體", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnRandom.Location = new System.Drawing.Point(443, 163);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(137, 86);
            this.btnRandom.TabIndex = 1;
            this.btnRandom.Text = "亂 數";
            this.btnRandom.UseVisualStyleBackColor = true;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // lblDirection
            // 
            this.lblDirection.AutoSize = true;
            this.lblDirection.Font = new System.Drawing.Font("微軟正黑體", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblDirection.Location = new System.Drawing.Point(33, 90);
            this.lblDirection.Name = "lblDirection";
            this.lblDirection.Size = new System.Drawing.Size(156, 71);
            this.lblDirection.TabIndex = 0;
            this.lblDirection.Text = "方 向";
            // 
            // lblCurrentFloor
            // 
            this.lblCurrentFloor.AutoSize = true;
            this.lblCurrentFloor.Font = new System.Drawing.Font("微軟正黑體", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblCurrentFloor.Location = new System.Drawing.Point(219, 90);
            this.lblCurrentFloor.Name = "lblCurrentFloor";
            this.lblCurrentFloor.Size = new System.Drawing.Size(156, 71);
            this.lblCurrentFloor.TabIndex = 1;
            this.lblCurrentFloor.Text = "樓 層";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblDirection);
            this.groupBox1.Controls.Add(this.lblCurrentFloor);
            this.groupBox1.Location = new System.Drawing.Point(688, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(408, 235);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // btnA
            // 
            this.btnA.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnA.Location = new System.Drawing.Point(37, 21);
            this.btnA.Name = "btnA";
            this.btnA.Size = new System.Drawing.Size(78, 48);
            this.btnA.TabIndex = 3;
            this.btnA.Text = "A";
            this.btnA.UseVisualStyleBackColor = true;
            this.btnA.Click += new System.EventHandler(this.btnA_Click);
            // 
            // lblTargetA
            // 
            this.lblTargetA.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblTargetA.Location = new System.Drawing.Point(469, 30);
            this.lblTargetA.Name = "lblTargetA";
            this.lblTargetA.Size = new System.Drawing.Size(70, 31);
            this.lblTargetA.TabIndex = 4;
            this.lblTargetA.Text = "目標";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(375, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 31);
            this.label4.TabIndex = 5;
            this.label4.Text = "- >";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtCurrentA
            // 
            this.txtCurrentA.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtCurrentA.Location = new System.Drawing.Point(222, 27);
            this.txtCurrentA.Name = "txtCurrentA";
            this.txtCurrentA.Size = new System.Drawing.Size(100, 39);
            this.txtCurrentA.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblStatusA);
            this.groupBox2.Controls.Add(this.btnA);
            this.groupBox2.Controls.Add(this.txtCurrentA);
            this.groupBox2.Controls.Add(this.lblTargetA);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(82, 390);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(594, 86);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            // 
            // lblStatusA
            // 
            this.lblStatusA.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblStatusA.Location = new System.Drawing.Point(133, 28);
            this.lblStatusA.Name = "lblStatusA";
            this.lblStatusA.Size = new System.Drawing.Size(68, 38);
            this.lblStatusA.TabIndex = 16;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblStatusB);
            this.groupBox3.Controls.Add(this.btnB);
            this.groupBox3.Controls.Add(this.txtCurrentB);
            this.groupBox3.Controls.Add(this.lblTargetB);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(82, 515);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(594, 86);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            // 
            // lblStatusB
            // 
            this.lblStatusB.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblStatusB.Location = new System.Drawing.Point(133, 31);
            this.lblStatusB.Name = "lblStatusB";
            this.lblStatusB.Size = new System.Drawing.Size(68, 38);
            this.lblStatusB.TabIndex = 17;
            // 
            // btnB
            // 
            this.btnB.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnB.Location = new System.Drawing.Point(37, 21);
            this.btnB.Name = "btnB";
            this.btnB.Size = new System.Drawing.Size(78, 48);
            this.btnB.TabIndex = 3;
            this.btnB.Text = "B";
            this.btnB.UseVisualStyleBackColor = true;
            this.btnB.Click += new System.EventHandler(this.btnB_Click);
            // 
            // txtCurrentB
            // 
            this.txtCurrentB.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtCurrentB.Location = new System.Drawing.Point(222, 27);
            this.txtCurrentB.Name = "txtCurrentB";
            this.txtCurrentB.Size = new System.Drawing.Size(100, 39);
            this.txtCurrentB.TabIndex = 6;
            // 
            // lblTargetB
            // 
            this.lblTargetB.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblTargetB.Location = new System.Drawing.Point(469, 30);
            this.lblTargetB.Name = "lblTargetB";
            this.lblTargetB.Size = new System.Drawing.Size(70, 31);
            this.lblTargetB.TabIndex = 4;
            this.lblTargetB.Text = "目標";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(384, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 31);
            this.label6.TabIndex = 5;
            this.label6.Text = "- >";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblStatusC);
            this.groupBox4.Controls.Add(this.btnC);
            this.groupBox4.Controls.Add(this.txtCurrentC);
            this.groupBox4.Controls.Add(this.lblTargetC);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Location = new System.Drawing.Point(82, 646);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(594, 90);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            // 
            // lblStatusC
            // 
            this.lblStatusC.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblStatusC.Location = new System.Drawing.Point(133, 28);
            this.lblStatusC.Name = "lblStatusC";
            this.lblStatusC.Size = new System.Drawing.Size(68, 38);
            this.lblStatusC.TabIndex = 17;
            // 
            // btnC
            // 
            this.btnC.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnC.Location = new System.Drawing.Point(37, 21);
            this.btnC.Name = "btnC";
            this.btnC.Size = new System.Drawing.Size(78, 48);
            this.btnC.TabIndex = 3;
            this.btnC.Text = "C";
            this.btnC.UseVisualStyleBackColor = true;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // txtCurrentC
            // 
            this.txtCurrentC.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtCurrentC.Location = new System.Drawing.Point(222, 27);
            this.txtCurrentC.Name = "txtCurrentC";
            this.txtCurrentC.Size = new System.Drawing.Size(100, 39);
            this.txtCurrentC.TabIndex = 6;
            // 
            // lblTargetC
            // 
            this.lblTargetC.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblTargetC.Location = new System.Drawing.Point(469, 30);
            this.lblTargetC.Name = "lblTargetC";
            this.lblTargetC.Size = new System.Drawing.Size(70, 31);
            this.lblTargetC.TabIndex = 4;
            this.lblTargetC.Text = "目標";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(384, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 31);
            this.label8.TabIndex = 5;
            this.label8.Text = "- >";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lblStatusD);
            this.groupBox5.Controls.Add(this.btnD);
            this.groupBox5.Controls.Add(this.txtCurrentD);
            this.groupBox5.Controls.Add(this.lblTargetD);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Location = new System.Drawing.Point(82, 782);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(594, 93);
            this.groupBox5.TabIndex = 10;
            this.groupBox5.TabStop = false;
            // 
            // lblStatusD
            // 
            this.lblStatusD.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblStatusD.Location = new System.Drawing.Point(133, 25);
            this.lblStatusD.Name = "lblStatusD";
            this.lblStatusD.Size = new System.Drawing.Size(68, 38);
            this.lblStatusD.TabIndex = 17;
            // 
            // btnD
            // 
            this.btnD.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnD.Location = new System.Drawing.Point(37, 21);
            this.btnD.Name = "btnD";
            this.btnD.Size = new System.Drawing.Size(78, 48);
            this.btnD.TabIndex = 3;
            this.btnD.Text = "D";
            this.btnD.UseVisualStyleBackColor = true;
            this.btnD.Click += new System.EventHandler(this.btnD_Click);
            // 
            // txtCurrentD
            // 
            this.txtCurrentD.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtCurrentD.Location = new System.Drawing.Point(222, 27);
            this.txtCurrentD.Name = "txtCurrentD";
            this.txtCurrentD.Size = new System.Drawing.Size(100, 39);
            this.txtCurrentD.TabIndex = 6;
            // 
            // lblTargetD
            // 
            this.lblTargetD.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblTargetD.Location = new System.Drawing.Point(469, 30);
            this.lblTargetD.Name = "lblTargetD";
            this.lblTargetD.Size = new System.Drawing.Size(70, 31);
            this.lblTargetD.TabIndex = 4;
            this.lblTargetD.Text = "目標";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label10.Location = new System.Drawing.Point(384, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 31);
            this.label10.TabIndex = 5;
            this.label10.Text = "- >";
            // 
            // btnFloor1
            // 
            this.btnFloor1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnFloor1.Location = new System.Drawing.Point(50, 60);
            this.btnFloor1.Name = "btnFloor1";
            this.btnFloor1.Size = new System.Drawing.Size(76, 66);
            this.btnFloor1.TabIndex = 12;
            this.btnFloor1.Text = "1 ";
            this.btnFloor1.UseVisualStyleBackColor = true;
            this.btnFloor1.Click += new System.EventHandler(this.btnFloor1_Click);
            // 
            // btnFloor2
            // 
            this.btnFloor2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnFloor2.Location = new System.Drawing.Point(180, 60);
            this.btnFloor2.Name = "btnFloor2";
            this.btnFloor2.Size = new System.Drawing.Size(76, 66);
            this.btnFloor2.TabIndex = 13;
            this.btnFloor2.Text = "2 ";
            this.btnFloor2.UseVisualStyleBackColor = true;
            this.btnFloor2.Click += new System.EventHandler(this.btnFloor2_Click);
            // 
            // btnFloor3
            // 
            this.btnFloor3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnFloor3.Location = new System.Drawing.Point(310, 60);
            this.btnFloor3.Name = "btnFloor3";
            this.btnFloor3.Size = new System.Drawing.Size(76, 66);
            this.btnFloor3.TabIndex = 14;
            this.btnFloor3.Text = "3 ";
            this.btnFloor3.UseVisualStyleBackColor = true;
            this.btnFloor3.Click += new System.EventHandler(this.btnFloor3_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnFloor13);
            this.groupBox6.Controls.Add(this.btnFloor15);
            this.groupBox6.Controls.Add(this.btnFloor14);
            this.groupBox6.Controls.Add(this.btnFloor10);
            this.groupBox6.Controls.Add(this.btnFloor12);
            this.groupBox6.Controls.Add(this.btnFloor11);
            this.groupBox6.Controls.Add(this.btnFloor7);
            this.groupBox6.Controls.Add(this.btnFloor9);
            this.groupBox6.Controls.Add(this.btnFloor8);
            this.groupBox6.Controls.Add(this.btnFloor4);
            this.groupBox6.Controls.Add(this.btnFloor6);
            this.groupBox6.Controls.Add(this.btnFloor5);
            this.groupBox6.Controls.Add(this.btnFloor1);
            this.groupBox6.Controls.Add(this.btnFloor3);
            this.groupBox6.Controls.Add(this.btnFloor2);
            this.groupBox6.Location = new System.Drawing.Point(682, 358);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(432, 554);
            this.groupBox6.TabIndex = 15;
            this.groupBox6.TabStop = false;
            // 
            // btnFloor13
            // 
            this.btnFloor13.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnFloor13.Location = new System.Drawing.Point(50, 460);
            this.btnFloor13.Name = "btnFloor13";
            this.btnFloor13.Size = new System.Drawing.Size(76, 66);
            this.btnFloor13.TabIndex = 24;
            this.btnFloor13.Text = "13 ";
            this.btnFloor13.UseVisualStyleBackColor = true;
            this.btnFloor13.Click += new System.EventHandler(this.btnFloor13_Click);
            // 
            // btnFloor15
            // 
            this.btnFloor15.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnFloor15.Location = new System.Drawing.Point(310, 460);
            this.btnFloor15.Name = "btnFloor15";
            this.btnFloor15.Size = new System.Drawing.Size(76, 66);
            this.btnFloor15.TabIndex = 26;
            this.btnFloor15.Text = "15 ";
            this.btnFloor15.UseVisualStyleBackColor = true;
            this.btnFloor15.Click += new System.EventHandler(this.btnFloor15_Click);
            // 
            // btnFloor14
            // 
            this.btnFloor14.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnFloor14.Location = new System.Drawing.Point(180, 460);
            this.btnFloor14.Name = "btnFloor14";
            this.btnFloor14.Size = new System.Drawing.Size(76, 66);
            this.btnFloor14.TabIndex = 25;
            this.btnFloor14.Text = "14 ";
            this.btnFloor14.UseVisualStyleBackColor = true;
            this.btnFloor14.Click += new System.EventHandler(this.btnFloor14_Click);
            // 
            // btnFloor10
            // 
            this.btnFloor10.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnFloor10.Location = new System.Drawing.Point(50, 360);
            this.btnFloor10.Name = "btnFloor10";
            this.btnFloor10.Size = new System.Drawing.Size(76, 66);
            this.btnFloor10.TabIndex = 21;
            this.btnFloor10.Text = "10 ";
            this.btnFloor10.UseVisualStyleBackColor = true;
            this.btnFloor10.Click += new System.EventHandler(this.btnFloor10_Click);
            // 
            // btnFloor12
            // 
            this.btnFloor12.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnFloor12.Location = new System.Drawing.Point(310, 360);
            this.btnFloor12.Name = "btnFloor12";
            this.btnFloor12.Size = new System.Drawing.Size(76, 66);
            this.btnFloor12.TabIndex = 23;
            this.btnFloor12.Text = "12 ";
            this.btnFloor12.UseVisualStyleBackColor = true;
            this.btnFloor12.Click += new System.EventHandler(this.btnFloor12_Click);
            // 
            // btnFloor11
            // 
            this.btnFloor11.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnFloor11.Location = new System.Drawing.Point(180, 360);
            this.btnFloor11.Name = "btnFloor11";
            this.btnFloor11.Size = new System.Drawing.Size(76, 66);
            this.btnFloor11.TabIndex = 22;
            this.btnFloor11.Text = "11 ";
            this.btnFloor11.UseVisualStyleBackColor = true;
            this.btnFloor11.Click += new System.EventHandler(this.btnFloor11_Click);
            // 
            // btnFloor7
            // 
            this.btnFloor7.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnFloor7.Location = new System.Drawing.Point(50, 260);
            this.btnFloor7.Name = "btnFloor7";
            this.btnFloor7.Size = new System.Drawing.Size(76, 66);
            this.btnFloor7.TabIndex = 18;
            this.btnFloor7.Text = "7 ";
            this.btnFloor7.UseVisualStyleBackColor = true;
            this.btnFloor7.Click += new System.EventHandler(this.btnFloor7_Click);
            // 
            // btnFloor9
            // 
            this.btnFloor9.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnFloor9.Location = new System.Drawing.Point(310, 260);
            this.btnFloor9.Name = "btnFloor9";
            this.btnFloor9.Size = new System.Drawing.Size(76, 66);
            this.btnFloor9.TabIndex = 20;
            this.btnFloor9.Text = "9 ";
            this.btnFloor9.UseVisualStyleBackColor = true;
            this.btnFloor9.Click += new System.EventHandler(this.btnFloor9_Click);
            // 
            // btnFloor8
            // 
            this.btnFloor8.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnFloor8.Location = new System.Drawing.Point(180, 260);
            this.btnFloor8.Name = "btnFloor8";
            this.btnFloor8.Size = new System.Drawing.Size(76, 66);
            this.btnFloor8.TabIndex = 19;
            this.btnFloor8.Text = "8 ";
            this.btnFloor8.UseVisualStyleBackColor = true;
            this.btnFloor8.Click += new System.EventHandler(this.btnFloor8_Click);
            // 
            // btnFloor4
            // 
            this.btnFloor4.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnFloor4.Location = new System.Drawing.Point(50, 160);
            this.btnFloor4.Name = "btnFloor4";
            this.btnFloor4.Size = new System.Drawing.Size(76, 66);
            this.btnFloor4.TabIndex = 15;
            this.btnFloor4.Text = "4 ";
            this.btnFloor4.UseVisualStyleBackColor = true;
            this.btnFloor4.Click += new System.EventHandler(this.btnFloor4_Click);
            // 
            // btnFloor6
            // 
            this.btnFloor6.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnFloor6.Location = new System.Drawing.Point(310, 160);
            this.btnFloor6.Name = "btnFloor6";
            this.btnFloor6.Size = new System.Drawing.Size(76, 66);
            this.btnFloor6.TabIndex = 17;
            this.btnFloor6.Text = "6 ";
            this.btnFloor6.UseVisualStyleBackColor = true;
            this.btnFloor6.Click += new System.EventHandler(this.btnFloor6_Click);
            // 
            // btnFloor5
            // 
            this.btnFloor5.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnFloor5.Location = new System.Drawing.Point(180, 160);
            this.btnFloor5.Name = "btnFloor5";
            this.btnFloor5.Size = new System.Drawing.Size(76, 66);
            this.btnFloor5.TabIndex = 16;
            this.btnFloor5.Text = "5 ";
            this.btnFloor5.UseVisualStyleBackColor = true;
            this.btnFloor5.Click += new System.EventHandler(this.btnFloor5_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1261, 949);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnRandom);
            this.Controls.Add(this.btnStart);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.Label lblDirection;
        private System.Windows.Forms.Label lblCurrentFloor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnA;
        private System.Windows.Forms.Label lblTargetA;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCurrentA;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnB;
        private System.Windows.Forms.TextBox txtCurrentB;
        private System.Windows.Forms.Label lblTargetB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnC;
        private System.Windows.Forms.TextBox txtCurrentC;
        private System.Windows.Forms.Label lblTargetC;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnD;
        private System.Windows.Forms.TextBox txtCurrentD;
        private System.Windows.Forms.Label lblTargetD;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnFloor1;
        private System.Windows.Forms.Button btnFloor2;
        private System.Windows.Forms.Button btnFloor3;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnFloor13;
        private System.Windows.Forms.Button btnFloor15;
        private System.Windows.Forms.Button btnFloor14;
        private System.Windows.Forms.Button btnFloor10;
        private System.Windows.Forms.Button btnFloor12;
        private System.Windows.Forms.Button btnFloor11;
        private System.Windows.Forms.Button btnFloor7;
        private System.Windows.Forms.Button btnFloor9;
        private System.Windows.Forms.Button btnFloor8;
        private System.Windows.Forms.Button btnFloor4;
        private System.Windows.Forms.Button btnFloor6;
        private System.Windows.Forms.Button btnFloor5;
        private System.Windows.Forms.Label lblStatusA;
        private System.Windows.Forms.Label lblStatusB;
        private System.Windows.Forms.Label lblStatusC;
        private System.Windows.Forms.Label lblStatusD;
    }
}

