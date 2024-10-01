namespace E24105038_Practice4_2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.labelMenu = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonLeave = new System.Windows.Forms.Button();
            this.buttonCont = new System.Windows.Forms.Button();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.labelScore = new System.Windows.Forms.Label();
            this.labelUser = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.buttonRes = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.labelHistory = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelMenu
            // 
            this.labelMenu.Location = new System.Drawing.Point(1, -2);
            this.labelMenu.Name = "labelMenu";
            this.labelMenu.Size = new System.Drawing.Size(150, 34);
            this.labelMenu.TabIndex = 0;
            this.labelMenu.Text = "Card flipping game";
            this.labelMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(634, 41);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(90, 39);
            this.buttonStart.TabIndex = 1;
            this.buttonStart.Text = "Start game";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonLeave
            // 
            this.buttonLeave.Location = new System.Drawing.Point(634, 314);
            this.buttonLeave.Name = "buttonLeave";
            this.buttonLeave.Size = new System.Drawing.Size(90, 39);
            this.buttonLeave.TabIndex = 3;
            this.buttonLeave.Text = "Leave game";
            this.buttonLeave.UseVisualStyleBackColor = true;
            this.buttonLeave.Click += new System.EventHandler(this.buttonLeave_Click);
            // 
            // buttonCont
            // 
            this.buttonCont.Enabled = false;
            this.buttonCont.Location = new System.Drawing.Point(634, 101);
            this.buttonCont.Name = "buttonCont";
            this.buttonCont.Size = new System.Drawing.Size(90, 39);
            this.buttonCont.TabIndex = 4;
            this.buttonCont.Text = "Continue";
            this.buttonCont.UseVisualStyleBackColor = true;
            this.buttonCont.Click += new System.EventHandler(this.buttonCont_Click);
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "01.jpg");
            this.imageList.Images.SetKeyName(1, "02.jpg");
            this.imageList.Images.SetKeyName(2, "03.jpg");
            this.imageList.Images.SetKeyName(3, "04.jpg");
            this.imageList.Images.SetKeyName(4, "05.jpg");
            this.imageList.Images.SetKeyName(5, "06.jpg");
            this.imageList.Images.SetKeyName(6, "07.jpg");
            this.imageList.Images.SetKeyName(7, "08.jpg");
            this.imageList.Images.SetKeyName(8, "card.jpg");
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Location = new System.Drawing.Point(6, 9);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(77, 17);
            this.labelScore.TabIndex = 8;
            this.labelScore.Text = "Score: 100";
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Location = new System.Drawing.Point(105, 9);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(77, 17);
            this.labelUser.TabIndex = 9;
            this.labelUser.Text = "Username:";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(188, 6);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(100, 22);
            this.txtUser.TabIndex = 10;
            // 
            // buttonRes
            // 
            this.buttonRes.Location = new System.Drawing.Point(634, 163);
            this.buttonRes.Name = "buttonRes";
            this.buttonRes.Size = new System.Drawing.Size(90, 39);
            this.buttonRes.TabIndex = 11;
            this.buttonRes.Text = "Restart";
            this.buttonRes.UseVisualStyleBackColor = true;
            this.buttonRes.Click += new System.EventHandler(this.buttonRes_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(4, 29);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(819, 516);
            this.tabControl1.TabIndex = 12;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.labelScore);
            this.tabPage1.Controls.Add(this.buttonLeave);
            this.tabPage1.Controls.Add(this.buttonRes);
            this.tabPage1.Controls.Add(this.labelUser);
            this.tabPage1.Controls.Add(this.buttonCont);
            this.tabPage1.Controls.Add(this.txtUser);
            this.tabPage1.Controls.Add(this.buttonStart);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(811, 487);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Game area";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Transparent;
            this.tabPage2.Controls.Add(this.labelHistory);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(811, 487);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "History";
            // 
            // labelHistory
            // 
            this.labelHistory.BackColor = System.Drawing.Color.Transparent;
            this.labelHistory.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelHistory.Location = new System.Drawing.Point(26, 26);
            this.labelHistory.Name = "labelHistory";
            this.labelHistory.Size = new System.Drawing.Size(738, 408);
            this.labelHistory.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 557);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.labelMenu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelMenu;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonLeave;
        private System.Windows.Forms.Button buttonCont;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Button buttonRes;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label labelHistory;
    }
}

