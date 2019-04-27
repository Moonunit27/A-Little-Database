namespace SmallDatabase
{
    partial class PeopleForm
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
            this.RefreshList = new System.Windows.Forms.Button();
            this.AddPerson = new System.Windows.Forms.Button();
            this.PeopleListBox = new System.Windows.Forms.ListBox();
            this.FName = new System.Windows.Forms.TextBox();
            this.LName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RefreshList
            // 
            this.RefreshList.Location = new System.Drawing.Point(12, 261);
            this.RefreshList.Name = "RefreshList";
            this.RefreshList.Size = new System.Drawing.Size(215, 42);
            this.RefreshList.TabIndex = 0;
            this.RefreshList.Text = "Refresh List";
            this.RefreshList.UseVisualStyleBackColor = true;
            this.RefreshList.Click += new System.EventHandler(this.RefreshList_Click);
            // 
            // AddPerson
            // 
            this.AddPerson.Location = new System.Drawing.Point(12, 214);
            this.AddPerson.Name = "AddPerson";
            this.AddPerson.Size = new System.Drawing.Size(215, 41);
            this.AddPerson.TabIndex = 1;
            this.AddPerson.Text = "Add Person";
            this.AddPerson.UseVisualStyleBackColor = true;
            this.AddPerson.Click += new System.EventHandler(this.AddPerson_Click);
            // 
            // PeopleListBox
            // 
            this.PeopleListBox.FormattingEnabled = true;
            this.PeopleListBox.ItemHeight = 20;
            this.PeopleListBox.Location = new System.Drawing.Point(371, 59);
            this.PeopleListBox.Name = "PeopleListBox";
            this.PeopleListBox.Size = new System.Drawing.Size(284, 244);
            this.PeopleListBox.TabIndex = 2;
            // 
            // FName
            // 
            this.FName.Location = new System.Drawing.Point(24, 72);
            this.FName.Name = "FName";
            this.FName.Size = new System.Drawing.Size(100, 26);
            this.FName.TabIndex = 3;
            // 
            // LName
            // 
            this.LName.Location = new System.Drawing.Point(24, 146);
            this.LName.Name = "LName";
            this.LName.Size = new System.Drawing.Size(100, 26);
            this.LName.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Add Person";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(367, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "List People";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "First Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Last Name";
            // 
            // PeopleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LName);
            this.Controls.Add(this.FName);
            this.Controls.Add(this.PeopleListBox);
            this.Controls.Add(this.AddPerson);
            this.Controls.Add(this.RefreshList);
            this.Name = "PeopleForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RefreshList;
        private System.Windows.Forms.Button AddPerson;
        private System.Windows.Forms.ListBox PeopleListBox;
        private System.Windows.Forms.TextBox FName;
        private System.Windows.Forms.TextBox LName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

