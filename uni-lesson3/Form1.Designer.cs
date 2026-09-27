namespace uni_lesson3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            listBox1 = new ListBox();
            groupBox1 = new GroupBox();
            textBox1 = new TextBox();
            maskedTextBox2 = new MaskedTextBox();
            maskedTextBox1 = new MaskedTextBox();
            button1 = new Button();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            pictureBox1 = new PictureBox();
            label10 = new Label();
            pictureBox2 = new PictureBox();
            groupBox2 = new GroupBox();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            label6 = new Label();
            textBox2 = new TextBox();
            maskedTextBox4 = new MaskedTextBox();
            button2 = new Button();
            label9 = new Label();
            label7 = new Label();
            label8 = new Label();
            button3 = new Button();
            button4 = new Button();
            groupBox1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(12, 374);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(742, 44);
            listBox1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.GradientInactiveCaption;
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(maskedTextBox2);
            groupBox1.Controls.Add(maskedTextBox1);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(comboBox2);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(0, 89);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(329, 279);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Travel infomration";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(114, 231);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 3;
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(114, 180);
            maskedTextBox2.Mask = "90:00";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(125, 27);
            maskedTextBox2.TabIndex = 12;
            maskedTextBox2.ValidatingType = typeof(DateTime);
            maskedTextBox2.MaskInputRejected += maskedTextBox2_MaskInputRejected;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(114, 138);
            maskedTextBox1.Mask = "00/00/0000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(125, 27);
            maskedTextBox1.TabIndex = 11;
            maskedTextBox1.ValidatingType = typeof(DateTime);
            maskedTextBox1.MaskInputRejected += maskedTextBox1_MaskInputRejected;
            // 
            // button1
            // 
            button1.Location = new Point(284, 50);
            button1.Name = "button1";
            button1.Size = new Size(34, 55);
            button1.TabIndex = 10;
            button1.Text = "<>";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "ISTANBUL", "BAKU", "MOSKOW", "BEIJIN" });
            comboBox2.Location = new Point(114, 91);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(151, 28);
            comboBox2.TabIndex = 9;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "ISTANBUL", "BAKU", "MOSKOW", "BEIJIN" });
            comboBox1.Location = new Point(114, 37);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 231);
            label5.Name = "label5";
            label5.Size = new Size(32, 20);
            label5.TabIndex = 7;
            label5.Text = "Yer:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 180);
            label4.Name = "label4";
            label4.Size = new Size(41, 20);
            label4.TabIndex = 6;
            label4.Text = "Saat:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 129);
            label3.Name = "label3";
            label3.Size = new Size(42, 20);
            label3.TabIndex = 5;
            label3.Text = "Tarix:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 78);
            label2.Name = "label2";
            label2.Size = new Size(59, 20);
            label2.TabIndex = 4;
            label2.Text = "Haraya:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 37);
            label1.Name = "label1";
            label1.Size = new Size(61, 20);
            label1.TabIndex = 3;
            label1.Text = "Hardan:";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AccessibleRole = AccessibleRole.Grip;
            flowLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.BackColor = SystemColors.ActiveCaption;
            flowLayoutPanel1.Controls.Add(pictureBox1);
            flowLayoutPanel1.Controls.Add(label10);
            flowLayoutPanel1.Controls.Add(pictureBox2);
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(788, 71);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            flowLayoutPanel1.SetFlowBreak(pictureBox1, true);
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 62);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.UseWaitCursor = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(134, 0);
            label10.Name = "label10";
            label10.Size = new Size(84, 20);
            label10.TabIndex = 3;
            label10.Text = "BMU Travel";
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            flowLayoutPanel1.SetFlowBreak(pictureBox2, true);
            pictureBox2.Location = new Point(224, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(125, 62);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.GradientInactiveCaption;
            groupBox2.Controls.Add(textBox4);
            groupBox2.Controls.Add(textBox3);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(textBox2);
            groupBox2.Controls.Add(maskedTextBox4);
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label8);
            groupBox2.Location = new Point(405, 89);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(306, 279);
            groupBox2.TabIndex = 13;
            groupBox2.TabStop = false;
            groupBox2.Text = "Personal Information";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(114, 180);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 13;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(114, 78);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 12;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Bottom;
            label6.AutoSize = true;
            label6.Location = new Point(0, 45);
            label6.Name = "label6";
            label6.Size = new Size(93, 20);
            label6.TabIndex = 2;
            label6.Text = "Ad ve soyad:";
            label6.TextAlign = ContentAlignment.BottomCenter;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(114, 38);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 3;
            // 
            // maskedTextBox4
            // 
            maskedTextBox4.Location = new Point(114, 138);
            maskedTextBox4.Mask = "(999) 00-000-00-00";
            maskedTextBox4.Name = "maskedTextBox4";
            maskedTextBox4.Size = new Size(125, 27);
            maskedTextBox4.TabIndex = 11;
            // 
            // button2
            // 
            button2.Location = new Point(145, 231);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 10;
            button2.Text = "Bilet al";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(6, 169);
            label9.Name = "label9";
            label9.Size = new Size(49, 20);
            label9.TabIndex = 4;
            label9.Text = "Email:";
            label9.Click += label9_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 81);
            label7.Name = "label7";
            label7.Size = new Size(34, 20);
            label7.TabIndex = 6;
            label7.Text = "FIN:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 129);
            label8.Name = "label8";
            label8.Size = new Size(61, 20);
            label8.TabIndex = 5;
            label8.Text = "Telefon:";
            // 
            // button3
            // 
            button3.Location = new Point(12, 424);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 13;
            button3.Text = "Delet ticket";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(617, 424);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 14;
            button4.Text = "Exit";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button4);
            Controls.Add(groupBox2);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(groupBox1);
            Controls.Add(listBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private GroupBox groupBox1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private FlowLayoutPanel flowLayoutPanel1;
        private MaskedTextBox maskedTextBox2;
        private MaskedTextBox maskedTextBox1;
        private Button button1;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private GroupBox groupBox2;
        private TextBox textBox2;
        private MaskedTextBox maskedTextBox4;
        private Button button2;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private TextBox textBox4;
        private TextBox textBox3;
        private Button button3;
        private Button button4;
        private Label label6;
    }
}
