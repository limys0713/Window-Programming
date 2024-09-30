namespace E24105038_Practice_4_1
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
            this.SuspendLayout();
            // 
            // labelMenu
            // 
            this.labelMenu.Location = new System.Drawing.Point(12, 9);
            this.labelMenu.Name = "labelMenu";
            this.labelMenu.Size = new System.Drawing.Size(150, 34);
            this.labelMenu.TabIndex = 0;
            this.labelMenu.Text = "Card flipping game";
            this.labelMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(591, 102);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(90, 39);
            this.buttonStart.TabIndex = 1;
            this.buttonStart.Text = "Start game";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonLeave
            // 
            this.buttonLeave.Location = new System.Drawing.Point(591, 237);
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
            this.buttonCont.Location = new System.Drawing.Point(591, 171);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCont);
            this.Controls.Add(this.buttonLeave);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.labelMenu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelMenu;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonLeave;
        private System.Windows.Forms.Button buttonCont;
        private System.Windows.Forms.ImageList imageList;
    }
}

