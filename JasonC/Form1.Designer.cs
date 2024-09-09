namespace JasonC
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
            label1 = new Label();
            label2 = new Label();
            txtPlayers1Name = new TextBox();
            label3 = new Label();
            txtPlayers1Health = new TextBox();
            lstOut = new ListBox();
            btnCalcName = new Button();
            btnClearAll = new Button();
            btnQuit = new Button();
            label4 = new Label();
            label5 = new Label();
            txtPlayers2Name = new TextBox();
            txtPlayers2Health = new TextBox();
            btnCalcName2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(449, 44);
            label1.MinimumSize = new Size(112, 20);
            label1.Name = "label1";
            label1.Size = new Size(112, 20);
            label1.TabIndex = 0;
            label1.Text = "Trading Card Game";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(91, 118);
            label2.Name = "label2";
            label2.Size = new Size(97, 15);
            label2.TabIndex = 1;
            label2.Text = "Player's 1 Name: ";
            label2.Click += label2_Click;
            // 
            // txtPlayers1Name
            // 
            txtPlayers1Name.Location = new Point(231, 115);
            txtPlayers1Name.Name = "txtPlayers1Name";
            txtPlayers1Name.Size = new Size(148, 23);
            txtPlayers1Name.TabIndex = 2;
            txtPlayers1Name.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(60, 154);
            label3.Name = "label3";
            label3.Size = new Size(165, 15);
            label3.TabIndex = 3;
            label3.Text = "Player's 1 Starting Health (%): ";
            // 
            // txtPlayers1Health
            // 
            txtPlayers1Health.Location = new Point(231, 148);
            txtPlayers1Health.Name = "txtPlayers1Health";
            txtPlayers1Health.Size = new Size(49, 23);
            txtPlayers1Health.TabIndex = 4;
            // 
            // lstOut
            // 
            lstOut.FormattingEnabled = true;
            lstOut.ItemHeight = 15;
            lstOut.Location = new Point(189, 232);
            lstOut.Name = "lstOut";
            lstOut.Size = new Size(665, 184);
            lstOut.TabIndex = 5;
            lstOut.SelectedIndexChanged += lstOut_SelectedIndexChanged;
            // 
            // btnCalcName
            // 
            btnCalcName.Location = new Point(132, 474);
            btnCalcName.Name = "btnCalcName";
            btnCalcName.Size = new Size(166, 23);
            btnCalcName.TabIndex = 6;
            btnCalcName.Text = "Calculate Player's &1 Health";
            btnCalcName.UseVisualStyleBackColor = true;
            // 
            // btnClearAll
            // 
            btnClearAll.Location = new Point(432, 499);
            btnClearAll.Name = "btnClearAll";
            btnClearAll.Size = new Size(171, 23);
            btnClearAll.TabIndex = 7;
            btnClearAll.Text = "&Clear All";
            btnClearAll.UseVisualStyleBackColor = true;
            // 
            // btnQuit
            // 
            btnQuit.Location = new Point(729, 499);
            btnQuit.Name = "btnQuit";
            btnQuit.Size = new Size(158, 23);
            btnQuit.TabIndex = 8;
            btnQuit.Text = "&Quit";
            btnQuit.UseVisualStyleBackColor = true;
            btnQuit.Click += button3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(586, 118);
            label4.Name = "label4";
            label4.Size = new Size(97, 15);
            label4.TabIndex = 9;
            label4.Text = "Player's 2 Name: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(561, 154);
            label5.Name = "label5";
            label5.Size = new Size(162, 15);
            label5.TabIndex = 10;
            label5.Text = "Player's 2 Starting Health (%):";
            // 
            // txtPlayers2Name
            // 
            txtPlayers2Name.Location = new Point(729, 115);
            txtPlayers2Name.Name = "txtPlayers2Name";
            txtPlayers2Name.Size = new Size(148, 23);
            txtPlayers2Name.TabIndex = 11;
            // 
            // txtPlayers2Health
            // 
            txtPlayers2Health.Location = new Point(729, 148);
            txtPlayers2Health.Name = "txtPlayers2Health";
            txtPlayers2Health.Size = new Size(49, 23);
            txtPlayers2Health.TabIndex = 12;
            // 
            // btnCalcName2
            // 
            btnCalcName2.Location = new Point(132, 520);
            btnCalcName2.Name = "btnCalcName2";
            btnCalcName2.Size = new Size(166, 23);
            btnCalcName2.TabIndex = 13;
            btnCalcName2.Text = "Calculate Player's &2 Health";
            btnCalcName2.UseVisualStyleBackColor = true;
            btnCalcName2.Click += btnCalcName2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1058, 583);
            Controls.Add(btnCalcName2);
            Controls.Add(txtPlayers2Health);
            Controls.Add(txtPlayers2Name);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(btnQuit);
            Controls.Add(btnClearAll);
            Controls.Add(btnCalcName);
            Controls.Add(lstOut);
            Controls.Add(txtPlayers1Health);
            Controls.Add(label3);
            Controls.Add(txtPlayers1Name);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = SystemColors.ControlText;
            Name = "Form1";
            Text = "JasonChen";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtPlayers1Name;
        private Label label3;
        private TextBox txtPlayers1Health;
        private ListBox lstOut;
        private Button btnCalcName;
        private Button btnClearAll;
        private Button btnQuit;
        private Label label4;
        private Label label5;
        private TextBox txtPlayers2Name;
        private TextBox txtPlayers2Health;
        private Button btnCalcName2;
    }
}
