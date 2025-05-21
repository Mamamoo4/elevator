namespace elevator
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
            this.lblTime = new System.Windows.Forms.Label();
            this.lblElevatorDirection = new System.Windows.Forms.Label();
            this.lblElevatorFloor = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblElevatorPassengers = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.numTargetFloor4 = new System.Windows.Forms.NumericUpDown();
            this.numCurrentFloor4 = new System.Windows.Forms.NumericUpDown();
            this.panelLight4 = new System.Windows.Forms.Panel();
            this.txtName4 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.numTargetFloor3 = new System.Windows.Forms.NumericUpDown();
            this.numCurrentFloor3 = new System.Windows.Forms.NumericUpDown();
            this.panelLight3 = new System.Windows.Forms.Panel();
            this.txtName3 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.numTargetFloor2 = new System.Windows.Forms.NumericUpDown();
            this.numCurrentFloor2 = new System.Windows.Forms.NumericUpDown();
            this.panelLight2 = new System.Windows.Forms.Panel();
            this.txtName2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numTargetFloor1 = new System.Windows.Forms.NumericUpDown();
            this.numCurrentFloor1 = new System.Windows.Forms.NumericUpDown();
            this.panelLight1 = new System.Windows.Forms.Panel();
            this.txtName1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTargetFloor4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCurrentFloor4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTargetFloor3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCurrentFloor3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTargetFloor2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCurrentFloor2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTargetFloor1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCurrentFloor1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblTime.Location = new System.Drawing.Point(107, 83);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(71, 36);
            this.lblTime.TabIndex = 0;
            this.lblTime.Text = "時間";
            this.lblTime.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblElevatorDirection
            // 
            this.lblElevatorDirection.AutoSize = true;
            this.lblElevatorDirection.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblElevatorDirection.Location = new System.Drawing.Point(83, 51);
            this.lblElevatorDirection.Name = "lblElevatorDirection";
            this.lblElevatorDirection.Size = new System.Drawing.Size(71, 36);
            this.lblElevatorDirection.TabIndex = 1;
            this.lblElevatorDirection.Text = "方向";
            // 
            // lblElevatorFloor
            // 
            this.lblElevatorFloor.AutoSize = true;
            this.lblElevatorFloor.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblElevatorFloor.Location = new System.Drawing.Point(306, 51);
            this.lblElevatorFloor.Name = "lblElevatorFloor";
            this.lblElevatorFloor.Size = new System.Drawing.Size(71, 36);
            this.lblElevatorFloor.TabIndex = 2;
            this.lblElevatorFloor.Text = "樓層";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblElevatorPassengers);
            this.groupBox1.Controls.Add(this.lblElevatorDirection);
            this.groupBox1.Controls.Add(this.lblElevatorFloor);
            this.groupBox1.Location = new System.Drawing.Point(291, 159);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(603, 265);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // lblElevatorPassengers
            // 
            this.lblElevatorPassengers.Font = new System.Drawing.Font("微軟正黑體", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblElevatorPassengers.Location = new System.Drawing.Point(83, 154);
            this.lblElevatorPassengers.Name = "lblElevatorPassengers";
            this.lblElevatorPassengers.Size = new System.Drawing.Size(436, 111);
            this.lblElevatorPassengers.TabIndex = 3;
            this.lblElevatorPassengers.Text = "人員";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.numTargetFloor4);
            this.groupBox2.Controls.Add(this.numCurrentFloor4);
            this.groupBox2.Controls.Add(this.panelLight4);
            this.groupBox2.Controls.Add(this.txtName4);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.numTargetFloor3);
            this.groupBox2.Controls.Add(this.numCurrentFloor3);
            this.groupBox2.Controls.Add(this.panelLight3);
            this.groupBox2.Controls.Add(this.txtName3);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.numTargetFloor2);
            this.groupBox2.Controls.Add(this.numCurrentFloor2);
            this.groupBox2.Controls.Add(this.panelLight2);
            this.groupBox2.Controls.Add(this.txtName2);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.numTargetFloor1);
            this.groupBox2.Controls.Add(this.numCurrentFloor1);
            this.groupBox2.Controls.Add(this.panelLight1);
            this.groupBox2.Controls.Add(this.txtName1);
            this.groupBox2.Location = new System.Drawing.Point(291, 489);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1347, 282);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label11.Location = new System.Drawing.Point(1026, 225);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(146, 31);
            this.label11.TabIndex = 23;
            this.label11.Text = "欲前往樓層 :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label12.Location = new System.Drawing.Point(1030, 140);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(122, 31);
            this.label12.TabIndex = 22;
            this.label12.Text = "目前樓層 :";
            // 
            // numTargetFloor4
            // 
            this.numTargetFloor4.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.numTargetFloor4.Location = new System.Drawing.Point(1218, 225);
            this.numTargetFloor4.Name = "numTargetFloor4";
            this.numTargetFloor4.Size = new System.Drawing.Size(68, 39);
            this.numTargetFloor4.TabIndex = 21;
            this.numTargetFloor4.ValueChanged += new System.EventHandler(this.numericUpDown7_ValueChanged);
            // 
            // numCurrentFloor4
            // 
            this.numCurrentFloor4.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.numCurrentFloor4.Location = new System.Drawing.Point(1218, 132);
            this.numCurrentFloor4.Name = "numCurrentFloor4";
            this.numCurrentFloor4.Size = new System.Drawing.Size(68, 39);
            this.numCurrentFloor4.TabIndex = 20;
            this.numCurrentFloor4.ValueChanged += new System.EventHandler(this.numericUpDown8_ValueChanged);
            // 
            // panelLight4
            // 
            this.panelLight4.Location = new System.Drawing.Point(1080, 55);
            this.panelLight4.Name = "panelLight4";
            this.panelLight4.Size = new System.Drawing.Size(72, 39);
            this.panelLight4.TabIndex = 19;
            // 
            // txtName4
            // 
            this.txtName4.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtName4.Location = new System.Drawing.Point(1178, 55);
            this.txtName4.Name = "txtName4";
            this.txtName4.Size = new System.Drawing.Size(108, 39);
            this.txtName4.TabIndex = 18;
            this.txtName4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.Location = new System.Drawing.Point(686, 225);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(146, 31);
            this.label9.TabIndex = 17;
            this.label9.Text = "欲前往樓層 :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label10.Location = new System.Drawing.Point(690, 140);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(122, 31);
            this.label10.TabIndex = 16;
            this.label10.Text = "目前樓層 :";
            // 
            // numTargetFloor3
            // 
            this.numTargetFloor3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.numTargetFloor3.Location = new System.Drawing.Point(878, 225);
            this.numTargetFloor3.Name = "numTargetFloor3";
            this.numTargetFloor3.Size = new System.Drawing.Size(68, 39);
            this.numTargetFloor3.TabIndex = 15;
            this.numTargetFloor3.ValueChanged += new System.EventHandler(this.numericUpDown5_ValueChanged);
            // 
            // numCurrentFloor3
            // 
            this.numCurrentFloor3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.numCurrentFloor3.Location = new System.Drawing.Point(878, 132);
            this.numCurrentFloor3.Name = "numCurrentFloor3";
            this.numCurrentFloor3.Size = new System.Drawing.Size(68, 39);
            this.numCurrentFloor3.TabIndex = 14;
            this.numCurrentFloor3.ValueChanged += new System.EventHandler(this.numericUpDown6_ValueChanged);
            // 
            // panelLight3
            // 
            this.panelLight3.Location = new System.Drawing.Point(740, 55);
            this.panelLight3.Name = "panelLight3";
            this.panelLight3.Size = new System.Drawing.Size(72, 39);
            this.panelLight3.TabIndex = 13;
            // 
            // txtName3
            // 
            this.txtName3.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtName3.Location = new System.Drawing.Point(838, 55);
            this.txtName3.Name = "txtName3";
            this.txtName3.Size = new System.Drawing.Size(108, 39);
            this.txtName3.TabIndex = 12;
            this.txtName3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(346, 225);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 31);
            this.label7.TabIndex = 11;
            this.label7.Text = "欲前往樓層 :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(350, 140);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 31);
            this.label8.TabIndex = 10;
            this.label8.Text = "目前樓層 :";
            // 
            // numTargetFloor2
            // 
            this.numTargetFloor2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.numTargetFloor2.Location = new System.Drawing.Point(538, 225);
            this.numTargetFloor2.Name = "numTargetFloor2";
            this.numTargetFloor2.Size = new System.Drawing.Size(68, 39);
            this.numTargetFloor2.TabIndex = 9;
            this.numTargetFloor2.ValueChanged += new System.EventHandler(this.numericUpDown3_ValueChanged);
            // 
            // numCurrentFloor2
            // 
            this.numCurrentFloor2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.numCurrentFloor2.Location = new System.Drawing.Point(538, 132);
            this.numCurrentFloor2.Name = "numCurrentFloor2";
            this.numCurrentFloor2.Size = new System.Drawing.Size(68, 39);
            this.numCurrentFloor2.TabIndex = 8;
            this.numCurrentFloor2.ValueChanged += new System.EventHandler(this.numericUpDown4_ValueChanged);
            // 
            // panelLight2
            // 
            this.panelLight2.Location = new System.Drawing.Point(400, 55);
            this.panelLight2.Name = "panelLight2";
            this.panelLight2.Size = new System.Drawing.Size(72, 39);
            this.panelLight2.TabIndex = 7;
            // 
            // txtName2
            // 
            this.txtName2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtName2.Location = new System.Drawing.Point(498, 55);
            this.txtName2.Name = "txtName2";
            this.txtName2.Size = new System.Drawing.Size(108, 39);
            this.txtName2.TabIndex = 6;
            this.txtName2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(6, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(146, 31);
            this.label6.TabIndex = 5;
            this.label6.Text = "欲前往樓層 :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(10, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 31);
            this.label5.TabIndex = 4;
            this.label5.Text = "目前樓層 :";
            // 
            // numTargetFloor1
            // 
            this.numTargetFloor1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.numTargetFloor1.Location = new System.Drawing.Point(198, 225);
            this.numTargetFloor1.Name = "numTargetFloor1";
            this.numTargetFloor1.Size = new System.Drawing.Size(68, 39);
            this.numTargetFloor1.TabIndex = 3;
            this.numTargetFloor1.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // numCurrentFloor1
            // 
            this.numCurrentFloor1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.numCurrentFloor1.Location = new System.Drawing.Point(198, 132);
            this.numCurrentFloor1.Name = "numCurrentFloor1";
            this.numCurrentFloor1.Size = new System.Drawing.Size(68, 39);
            this.numCurrentFloor1.TabIndex = 2;
            this.numCurrentFloor1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // panelLight1
            // 
            this.panelLight1.Location = new System.Drawing.Point(60, 55);
            this.panelLight1.Name = "panelLight1";
            this.panelLight1.Size = new System.Drawing.Size(72, 39);
            this.panelLight1.TabIndex = 1;
            this.panelLight1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txtName1
            // 
            this.txtName1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtName1.Location = new System.Drawing.Point(158, 55);
            this.txtName1.Name = "txtName1";
            this.txtName1.Size = new System.Drawing.Size(108, 39);
            this.txtName1.TabIndex = 0;
            this.txtName1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("微軟正黑體", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(1327, 159);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(197, 65);
            this.button1.TabIndex = 5;
            this.button1.Text = "開  始";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("微軟正黑體", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button2.Location = new System.Drawing.Point(1327, 259);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(197, 65);
            this.button2.TabIndex = 6;
            this.button2.Text = "暫  停";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("微軟正黑體", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button3.Location = new System.Drawing.Point(1327, 359);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(197, 65);
            this.button3.TabIndex = 7;
            this.button3.Text = "初 始 化";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1789, 886);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblTime);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTargetFloor4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCurrentFloor4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTargetFloor3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCurrentFloor3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTargetFloor2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCurrentFloor2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTargetFloor1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCurrentFloor1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblElevatorDirection;
        private System.Windows.Forms.Label lblElevatorFloor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblElevatorPassengers;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown numTargetFloor1;
        private System.Windows.Forms.NumericUpDown numCurrentFloor1;
        private System.Windows.Forms.Panel panelLight1;
        private System.Windows.Forms.TextBox txtName1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown numTargetFloor4;
        private System.Windows.Forms.NumericUpDown numCurrentFloor4;
        private System.Windows.Forms.Panel panelLight4;
        private System.Windows.Forms.TextBox txtName4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown numTargetFloor3;
        private System.Windows.Forms.NumericUpDown numCurrentFloor3;
        private System.Windows.Forms.Panel panelLight3;
        private System.Windows.Forms.TextBox txtName3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numTargetFloor2;
        private System.Windows.Forms.NumericUpDown numCurrentFloor2;
        private System.Windows.Forms.Panel panelLight2;
        private System.Windows.Forms.TextBox txtName2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

