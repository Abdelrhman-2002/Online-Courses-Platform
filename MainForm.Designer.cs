namespace Project
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            WelcomePanel = new Panel();
            label1 = new Label();
            programmingpictureBox = new PictureBox();
            label2 = new Label();
            CoursesListBox = new ListBox();
            BusinesspictureBox = new PictureBox();
            MarektingpictureBox = new PictureBox();
            LanguagepictureBox = new PictureBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            viewbutton = new Button();
            Exitbutton = new Button();
            button1 = new Button();
            BackToLogin = new Button();
            Add = new Button();
            WelcomePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)programmingpictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BusinesspictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MarektingpictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)LanguagepictureBox).BeginInit();
            SuspendLayout();
            // 
            // WelcomePanel
            // 
            WelcomePanel.BackColor = Color.FromArgb(165, 64, 213);
            WelcomePanel.Controls.Add(label1);
            WelcomePanel.Dock = DockStyle.Top;
            WelcomePanel.Location = new Point(0, 0);
            WelcomePanel.Margin = new Padding(1);
            WelcomePanel.Name = "WelcomePanel";
            WelcomePanel.Size = new Size(872, 71);
            WelcomePanel.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(363, 24);
            label1.Margin = new Padding(1, 0, 1, 0);
            label1.Name = "label1";
            label1.Size = new Size(117, 23);
            label1.TabIndex = 0;
            label1.Text = "Our Courses";
            label1.Click += label1_Click;
            // 
            // programmingpictureBox
            // 
            programmingpictureBox.Image = (Image)resources.GetObject("programmingpictureBox.Image");
            programmingpictureBox.Location = new Point(80, 90);
            programmingpictureBox.Name = "programmingpictureBox";
            programmingpictureBox.Size = new Size(105, 90);
            programmingpictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            programmingpictureBox.TabIndex = 8;
            programmingpictureBox.TabStop = false;
            programmingpictureBox.Click += programmingPictureButton;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Bahnschrift", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(165, 64, 213);
            label2.Location = new Point(69, 199);
            label2.Name = "label2";
            label2.Size = new Size(126, 23);
            label2.TabIndex = 9;
            label2.Text = "Programming";
            // 
            // CoursesListBox
            // 
            CoursesListBox.Font = new Font("Bahnschrift", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            CoursesListBox.ForeColor = Color.FromArgb(165, 64, 213);
            CoursesListBox.FormattingEnabled = true;
            CoursesListBox.ItemHeight = 23;
            CoursesListBox.Location = new Point(300, 259);
            CoursesListBox.Name = "CoursesListBox";
            CoursesListBox.Size = new Size(250, 119);
            CoursesListBox.TabIndex = 10;
            CoursesListBox.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // BusinesspictureBox
            // 
            BusinesspictureBox.Image = (Image)resources.GetObject("BusinesspictureBox.Image");
            BusinesspictureBox.Location = new Point(270, 90);
            BusinesspictureBox.Name = "BusinesspictureBox";
            BusinesspictureBox.Size = new Size(115, 90);
            BusinesspictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            BusinesspictureBox.TabIndex = 12;
            BusinesspictureBox.TabStop = false;
            BusinesspictureBox.Click += businessPictureButton;
            // 
            // MarektingpictureBox
            // 
            MarektingpictureBox.Image = (Image)resources.GetObject("MarektingpictureBox.Image");
            MarektingpictureBox.Location = new Point(470, 90);
            MarektingpictureBox.Name = "MarektingpictureBox";
            MarektingpictureBox.Size = new Size(95, 90);
            MarektingpictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            MarektingpictureBox.TabIndex = 13;
            MarektingpictureBox.TabStop = false;
            MarektingpictureBox.Click += marektingPictureButton;
            // 
            // LanguagepictureBox
            // 
            LanguagepictureBox.Image = (Image)resources.GetObject("LanguagepictureBox.Image");
            LanguagepictureBox.Location = new Point(650, 90);
            LanguagepictureBox.Name = "LanguagepictureBox";
            LanguagepictureBox.Size = new Size(92, 90);
            LanguagepictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            LanguagepictureBox.TabIndex = 14;
            LanguagepictureBox.TabStop = false;
            LanguagepictureBox.Click += languagePictureButton;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Bahnschrift", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(165, 64, 213);
            label3.Location = new Point(283, 199);
            label3.Name = "label3";
            label3.Size = new Size(89, 23);
            label3.TabIndex = 15;
            label3.Text = "Business";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Bahnschrift", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(165, 64, 213);
            label4.Location = new Point(470, 199);
            label4.Name = "label4";
            label4.Size = new Size(95, 23);
            label4.TabIndex = 16;
            label4.Text = "Marketing";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Bahnschrift", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(165, 64, 213);
            label5.Location = new Point(650, 199);
            label5.Name = "label5";
            label5.Size = new Size(103, 23);
            label5.TabIndex = 17;
            label5.Text = "Languages";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Bahnschrift", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.FromArgb(165, 64, 213);
            label6.Location = new Point(69, 259);
            label6.Name = "label6";
            label6.Size = new Size(150, 23);
            label6.TabIndex = 18;
            label6.Text = "Choose courses:";
            // 
            // viewbutton
            // 
            viewbutton.BackColor = Color.FromArgb(165, 64, 213);
            viewbutton.FlatStyle = FlatStyle.Flat;
            viewbutton.Font = new Font("Bahnschrift", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            viewbutton.ForeColor = Color.White;
            viewbutton.Location = new Point(594, 276);
            viewbutton.Name = "viewbutton";
            viewbutton.Size = new Size(113, 39);
            viewbutton.TabIndex = 19;
            viewbutton.Text = "View";
            viewbutton.UseVisualStyleBackColor = false;
            viewbutton.Click += viewButton_Click;
            // 
            // Exitbutton
            // 
            Exitbutton.BackColor = Color.FromArgb(165, 64, 213);
            Exitbutton.FlatStyle = FlatStyle.Flat;
            Exitbutton.Font = new Font("Bahnschrift", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Exitbutton.ForeColor = Color.White;
            Exitbutton.Location = new Point(594, 334);
            Exitbutton.Name = "Exitbutton";
            Exitbutton.Size = new Size(113, 39);
            Exitbutton.TabIndex = 20;
            Exitbutton.Text = "Exit";
            Exitbutton.UseVisualStyleBackColor = false;
            Exitbutton.Click += exitButton_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(165, 64, 213);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Bahnschrift", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(650, 421);
            button1.Name = "button1";
            button1.Size = new Size(193, 39);
            button1.TabIndex = 21;
            button1.Text = "My Courses";
            button1.UseVisualStyleBackColor = false;
            button1.Click += myCoursesButton;
            // 
            // BackToLogin
            // 
            BackToLogin.BackColor = Color.FromArgb(165, 64, 213);
            BackToLogin.FlatStyle = FlatStyle.Flat;
            BackToLogin.Font = new Font("Bahnschrift", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            BackToLogin.ForeColor = Color.White;
            BackToLogin.Location = new Point(38, 427);
            BackToLogin.Name = "BackToLogin";
            BackToLogin.Size = new Size(193, 39);
            BackToLogin.TabIndex = 22;
            BackToLogin.Text = "Back To Login";
            BackToLogin.UseVisualStyleBackColor = false;
            BackToLogin.Click += backButtonInMainForm;
            // 
            // Add
            // 
            Add.BackColor = Color.FromArgb(165, 64, 213);
            Add.FlatStyle = FlatStyle.Flat;
            Add.Font = new Font("Bahnschrift", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            Add.ForeColor = Color.White;
            Add.Location = new Point(381, 421);
            Add.Name = "Add";
            Add.Size = new Size(113, 39);
            Add.TabIndex = 23;
            Add.Text = "Add";
            Add.UseVisualStyleBackColor = false;
            Add.Click += add_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(872, 495);
            Controls.Add(Add);
            Controls.Add(BackToLogin);
            Controls.Add(button1);
            Controls.Add(Exitbutton);
            Controls.Add(viewbutton);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(LanguagepictureBox);
            Controls.Add(MarektingpictureBox);
            Controls.Add(BusinesspictureBox);
            Controls.Add(CoursesListBox);
            Controls.Add(label2);
            Controls.Add(programmingpictureBox);
            Controls.Add(WelcomePanel);
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load_1;
            WelcomePanel.ResumeLayout(false);
            WelcomePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)programmingpictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)BusinesspictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)MarektingpictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)LanguagepictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel WelcomePanel;
        private Label label1;
        private PictureBox programmingpictureBox;
        private Label label2;
        private ListBox CoursesListBox;
        private PictureBox BusinesspictureBox;
        private PictureBox MarektingpictureBox;
        private PictureBox LanguagepictureBox;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button viewbutton;
        private Button Exitbutton;
        private Button button1;
        private Button BackToLogin;
        private LinkLabel linkLabel1;
        private Button Add;
    }
}