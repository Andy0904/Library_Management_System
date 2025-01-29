namespace LibraryManagementSystem
{
    partial class issue_books
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.bname = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.issuebook = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.date = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.isbn = new System.Windows.Forms.TextBox();
            this.phoneno = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.branch = new System.Windows.Forms.TextBox();
            this.sname = new System.Windows.Forms.TextBox();
            this.uid = new System.Windows.Forms.TextBox();
            this.htdj = new System.Windows.Forms.Label();
            this.hgfh = new System.Windows.Forms.Label();
            this.gvgjh = new System.Windows.Forms.Label();
            this.hfyf = new System.Windows.Forms.Label();
            this.gdjy = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bname);
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Controls.Add(this.issuebook);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.date);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.isbn);
            this.panel1.Controls.Add(this.phoneno);
            this.panel1.Controls.Add(this.email);
            this.panel1.Controls.Add(this.branch);
            this.panel1.Controls.Add(this.sname);
            this.panel1.Controls.Add(this.uid);
            this.panel1.Controls.Add(this.htdj);
            this.panel1.Controls.Add(this.hgfh);
            this.panel1.Controls.Add(this.gvgjh);
            this.panel1.Controls.Add(this.hfyf);
            this.panel1.Controls.Add(this.gdjy);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1285, 582);
            this.panel1.TabIndex = 0;
            // 
            // bname
            // 
            this.bname.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bname.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bname.Location = new System.Drawing.Point(195, 324);
            this.bname.Name = "bname";
            this.bname.Size = new System.Drawing.Size(212, 35);
            this.bname.TabIndex = 20;
            this.bname.KeyDown += new System.Windows.Forms.KeyEventHandler(this.bname_KeyDown);
            this.bname.KeyUp += new System.Windows.Forms.KeyEventHandler(this.bname_KeyUp);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.listBox1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 29;
            this.listBox1.Location = new System.Drawing.Point(195, 368);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(212, 178);
            this.listBox1.TabIndex = 19;
            this.listBox1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseClick);
            this.listBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listBox1_KeyDown);
            // 
            // issuebook
            // 
            this.issuebook.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.issuebook.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.issuebook.Location = new System.Drawing.Point(639, 492);
            this.issuebook.Name = "issuebook";
            this.issuebook.Size = new System.Drawing.Size(556, 55);
            this.issuebook.TabIndex = 17;
            this.issuebook.Text = "ISSUE BOOK";
            this.issuebook.UseVisualStyleBackColor = false;
            this.issuebook.Click += new System.EventHandler(this.issuebook_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(905, 355);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(337, 33);
            this.dateTimePicker1.TabIndex = 16;
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.Location = new System.Drawing.Point(1014, 299);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(119, 29);
            this.date.TabIndex = 15;
            this.date.Text = "Issue Date";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(29, 147);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(235, 55);
            this.button1.TabIndex = 14;
            this.button1.Text = "Search Student";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // isbn
            // 
            this.isbn.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.isbn.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.isbn.Location = new System.Drawing.Point(595, 327);
            this.isbn.Name = "isbn";
            this.isbn.Size = new System.Drawing.Size(212, 35);
            this.isbn.TabIndex = 13;
            // 
            // phoneno
            // 
            this.phoneno.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.phoneno.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneno.Location = new System.Drawing.Point(595, 157);
            this.phoneno.Name = "phoneno";
            this.phoneno.Size = new System.Drawing.Size(212, 35);
            this.phoneno.TabIndex = 11;
            // 
            // email
            // 
            this.email.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.email.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.Location = new System.Drawing.Point(1046, 157);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(212, 35);
            this.email.TabIndex = 10;
            // 
            // branch
            // 
            this.branch.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.branch.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.branch.Location = new System.Drawing.Point(1046, 55);
            this.branch.Name = "branch";
            this.branch.Size = new System.Drawing.Size(212, 35);
            this.branch.TabIndex = 9;
            // 
            // sname
            // 
            this.sname.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.sname.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sname.Location = new System.Drawing.Point(595, 52);
            this.sname.Name = "sname";
            this.sname.Size = new System.Drawing.Size(212, 35);
            this.sname.TabIndex = 8;
            // 
            // uid
            // 
            this.uid.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.uid.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uid.Location = new System.Drawing.Point(29, 101);
            this.uid.Name = "uid";
            this.uid.Size = new System.Drawing.Size(235, 40);
            this.uid.TabIndex = 7;
            this.uid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // htdj
            // 
            this.htdj.AutoSize = true;
            this.htdj.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.htdj.Location = new System.Drawing.Point(495, 330);
            this.htdj.Name = "htdj";
            this.htdj.Size = new System.Drawing.Size(67, 29);
            this.htdj.TabIndex = 6;
            this.htdj.Text = "ISBN";
            // 
            // hgfh
            // 
            this.hgfh.AutoSize = true;
            this.hgfh.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hgfh.Location = new System.Drawing.Point(32, 330);
            this.hgfh.Name = "hgfh";
            this.hgfh.Size = new System.Drawing.Size(122, 29);
            this.hgfh.TabIndex = 5;
            this.hgfh.Text = "Book Name";
            // 
            // gvgjh
            // 
            this.gvgjh.AutoSize = true;
            this.gvgjh.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvgjh.Location = new System.Drawing.Point(435, 163);
            this.gvgjh.Name = "gvgjh";
            this.gvgjh.Size = new System.Drawing.Size(113, 29);
            this.gvgjh.TabIndex = 4;
            this.gvgjh.Text = "Phone No.";
            // 
            // hfyf
            // 
            this.hfyf.AutoSize = true;
            this.hfyf.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hfyf.Location = new System.Drawing.Point(914, 163);
            this.hfyf.Name = "hfyf";
            this.hfyf.Size = new System.Drawing.Size(63, 29);
            this.hfyf.TabIndex = 3;
            this.hfyf.Text = "Email";
            // 
            // gdjy
            // 
            this.gdjy.AutoSize = true;
            this.gdjy.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gdjy.Location = new System.Drawing.Point(914, 52);
            this.gdjy.Name = "gdjy";
            this.gdjy.Size = new System.Drawing.Size(79, 29);
            this.gdjy.TabIndex = 2;
            this.gdjy.Text = "Branch";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(481, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Student UID";
            // 
            // issue_books
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1310, 689);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "issue_books";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "issue_books";
            this.Load += new System.EventHandler(this.issue_books_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox isbn;
        private System.Windows.Forms.TextBox phoneno;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox branch;
        private System.Windows.Forms.TextBox sname;
        private System.Windows.Forms.TextBox uid;
        private System.Windows.Forms.Label htdj;
        private System.Windows.Forms.Label hgfh;
        private System.Windows.Forms.Label gvgjh;
        private System.Windows.Forms.Label hfyf;
        private System.Windows.Forms.Label gdjy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button issuebook;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox bname;
    }
}