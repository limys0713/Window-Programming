namespace WindowsFormsApp4
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.RiskyAccountButton = new System.Windows.Forms.Button();
            this.AddDelete = new System.Windows.Forms.Button();
            this.labelSearchResult = new System.Windows.Forms.Label();
            this.buttonReturnMenu = new System.Windows.Forms.Button();
            this.labelLink = new System.Windows.Forms.Label();
            this.labelUser = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.Statusbar = new System.Windows.Forms.Label();
            this.txtLink = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.labelResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Password administrator";
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Location = new System.Drawing.Point(40, 66);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(78, 17);
            this.labelSearch.TabIndex = 1;
            this.labelSearch.Text = "Search bar";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(125, 66);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(554, 22);
            this.txtSearch.TabIndex = 2;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(697, 66);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 23);
            this.SearchButton.TabIndex = 3;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // RiskyAccountButton
            // 
            this.RiskyAccountButton.Location = new System.Drawing.Point(43, 111);
            this.RiskyAccountButton.Name = "RiskyAccountButton";
            this.RiskyAccountButton.Size = new System.Drawing.Size(729, 26);
            this.RiskyAccountButton.TabIndex = 4;
            this.RiskyAccountButton.Text = "Risky account";
            this.RiskyAccountButton.UseVisualStyleBackColor = true;
            this.RiskyAccountButton.Click += new System.EventHandler(this.RiskyAccountButton_Click);
            // 
            // AddDelete
            // 
            this.AddDelete.Location = new System.Drawing.Point(582, 158);
            this.AddDelete.Name = "AddDelete";
            this.AddDelete.Size = new System.Drawing.Size(190, 23);
            this.AddDelete.TabIndex = 5;
            this.AddDelete.Text = "Add or delete";
            this.AddDelete.UseVisualStyleBackColor = true;
            this.AddDelete.Click += new System.EventHandler(this.AddDelete_Click);
            // 
            // labelSearchResult
            // 
            this.labelSearchResult.AutoSize = true;
            this.labelSearchResult.Location = new System.Drawing.Point(43, 189);
            this.labelSearchResult.Name = "labelSearchResult";
            this.labelSearchResult.Size = new System.Drawing.Size(99, 17);
            this.labelSearchResult.TabIndex = 6;
            this.labelSearchResult.Text = "Search results";
            // 
            // buttonReturnMenu
            // 
            this.buttonReturnMenu.Enabled = false;
            this.buttonReturnMenu.Location = new System.Drawing.Point(582, 187);
            this.buttonReturnMenu.Name = "buttonReturnMenu";
            this.buttonReturnMenu.Size = new System.Drawing.Size(190, 23);
            this.buttonReturnMenu.TabIndex = 8;
            this.buttonReturnMenu.Text = "Return to menu";
            this.buttonReturnMenu.UseVisualStyleBackColor = true;
            this.buttonReturnMenu.Visible = false;
            this.buttonReturnMenu.Click += new System.EventHandler(this.buttonReturnMenu_Click);
            // 
            // labelLink
            // 
            this.labelLink.AutoSize = true;
            this.labelLink.Enabled = false;
            this.labelLink.Location = new System.Drawing.Point(125, 312);
            this.labelLink.Name = "labelLink";
            this.labelLink.Size = new System.Drawing.Size(29, 17);
            this.labelLink.TabIndex = 9;
            this.labelLink.Text = "link";
            this.labelLink.Visible = false;
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Enabled = false;
            this.labelUser.Location = new System.Drawing.Point(125, 347);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(36, 17);
            this.labelUser.TabIndex = 10;
            this.labelUser.Text = "user";
            this.labelUser.Visible = false;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Enabled = false;
            this.labelPassword.Location = new System.Drawing.Point(125, 381);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(68, 17);
            this.labelPassword.TabIndex = 11;
            this.labelPassword.Text = "password";
            this.labelPassword.Visible = false;
            // 
            // Statusbar
            // 
            this.Statusbar.AutoSize = true;
            this.Statusbar.Enabled = false;
            this.Statusbar.Location = new System.Drawing.Point(166, 263);
            this.Statusbar.Name = "Statusbar";
            this.Statusbar.Size = new System.Drawing.Size(73, 17);
            this.Statusbar.TabIndex = 12;
            this.Statusbar.Text = "Status bar";
            this.Statusbar.Visible = false;
            // 
            // txtLink
            // 
            this.txtLink.Enabled = false;
            this.txtLink.Location = new System.Drawing.Point(169, 312);
            this.txtLink.Name = "txtLink";
            this.txtLink.Size = new System.Drawing.Size(368, 22);
            this.txtLink.TabIndex = 13;
            this.txtLink.Visible = false;
            // 
            // txtUser
            // 
            this.txtUser.Enabled = false;
            this.txtUser.Location = new System.Drawing.Point(178, 347);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(359, 22);
            this.txtUser.TabIndex = 14;
            this.txtUser.Visible = false;
            // 
            // txtPassword
            // 
            this.txtPassword.Enabled = false;
            this.txtPassword.Location = new System.Drawing.Point(199, 381);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(338, 22);
            this.txtPassword.TabIndex = 15;
            this.txtPassword.Visible = false;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Enabled = false;
            this.buttonAdd.Location = new System.Drawing.Point(345, 415);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(58, 23);
            this.buttonAdd.TabIndex = 16;
            this.buttonAdd.Text = "add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Visible = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Enabled = false;
            this.buttonDelete.Location = new System.Drawing.Point(420, 415);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(58, 23);
            this.buttonDelete.TabIndex = 17;
            this.buttonDelete.Text = "delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Visible = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // labelResult
            // 
            this.labelResult.BackColor = System.Drawing.SystemColors.HighlightText;
            this.labelResult.Location = new System.Drawing.Point(43, 216);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(729, 212);
            this.labelResult.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.txtLink);
            this.Controls.Add(this.Statusbar);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.labelLink);
            this.Controls.Add(this.buttonReturnMenu);
            this.Controls.Add(this.labelSearchResult);
            this.Controls.Add(this.AddDelete);
            this.Controls.Add(this.RiskyAccountButton);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.labelSearch);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Button RiskyAccountButton;
        private System.Windows.Forms.Button AddDelete;
        private System.Windows.Forms.Label labelSearchResult;
        private System.Windows.Forms.Button buttonReturnMenu;
        private System.Windows.Forms.Label labelLink;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label Statusbar;
        private System.Windows.Forms.TextBox txtLink;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Label labelResult;
    }
}

