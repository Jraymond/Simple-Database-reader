namespace Database_reader
{
    partial class AddRow
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
            this.title = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.subgroup = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.episode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.season = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.notes = new System.Windows.Forms.RichTextBox();
            this.current = new System.Windows.Forms.CheckBox();
            this.stalled = new System.Windows.Forms.CheckBox();
            this.add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title";
            // 
            // title
            // 
            this.title.Location = new System.Drawing.Point(16, 30);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(157, 20);
            this.title.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sub Group";
            // 
            // subgroup
            // 
            this.subgroup.Location = new System.Drawing.Point(16, 74);
            this.subgroup.Name = "subgroup";
            this.subgroup.Size = new System.Drawing.Size(157, 20);
            this.subgroup.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Episode";
            // 
            // episode
            // 
            this.episode.Location = new System.Drawing.Point(16, 118);
            this.episode.Name = "episode";
            this.episode.Size = new System.Drawing.Size(45, 20);
            this.episode.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Season";
            // 
            // season
            // 
            this.season.Location = new System.Drawing.Point(16, 162);
            this.season.Name = "season";
            this.season.Size = new System.Drawing.Size(45, 20);
            this.season.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(184, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Notes";
            // 
            // notes
            // 
            this.notes.Location = new System.Drawing.Point(187, 30);
            this.notes.Name = "notes";
            this.notes.Size = new System.Drawing.Size(279, 207);
            this.notes.TabIndex = 9;
            this.notes.Text = "";
            // 
            // current
            // 
            this.current.AutoSize = true;
            this.current.Location = new System.Drawing.Point(100, 118);
            this.current.Name = "current";
            this.current.Size = new System.Drawing.Size(60, 17);
            this.current.TabIndex = 10;
            this.current.Text = "Current";
            this.current.UseVisualStyleBackColor = true;
            // 
            // stalled
            // 
            this.stalled.AutoSize = true;
            this.stalled.Location = new System.Drawing.Point(100, 141);
            this.stalled.Name = "stalled";
            this.stalled.Size = new System.Drawing.Size(58, 17);
            this.stalled.TabIndex = 11;
            this.stalled.Text = "Stalled";
            this.stalled.UseVisualStyleBackColor = true;
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(33, 214);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(100, 34);
            this.add.TabIndex = 12;
            this.add.Text = "Add Row";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // AddRow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 289);
            this.Controls.Add(this.add);
            this.Controls.Add(this.stalled);
            this.Controls.Add(this.current);
            this.Controls.Add(this.notes);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.season);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.episode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.subgroup);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.title);
            this.Controls.Add(this.label1);
            this.Name = "AddRow";
            this.Text = "AddRow";
            this.Load += new System.EventHandler(this.AddRow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox title;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox subgroup;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox episode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox season;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox notes;
        private System.Windows.Forms.CheckBox current;
        private System.Windows.Forms.CheckBox stalled;
        private System.Windows.Forms.Button add;
    }
}