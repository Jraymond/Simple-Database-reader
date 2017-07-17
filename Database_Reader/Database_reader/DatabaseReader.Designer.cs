namespace Database_reader
{
    partial class DatabaseReader
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
            this.Add = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.cover_art = new System.Windows.Forms.PictureBox();
            this.title = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sub_group = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.episode = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.current = new System.Windows.Forms.CheckBox();
            this.stalled = new System.Windows.Forms.CheckBox();
            this.notes = new System.Windows.Forms.RichTextBox();
            this.Update = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.animeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.animeDatabaseDataSet = new Database_reader.AnimeDatabaseDataSet();
            this.increment = new System.Windows.Forms.Button();
            this.move_up = new System.Windows.Forms.Button();
            this.move_down = new System.Windows.Forms.Button();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.show_current = new System.Windows.Forms.Button();
            this.animeTableAdapter = new Database_reader.AnimeDatabaseDataSetTableAdapters.AnimeTableAdapter();
            this.searchCB = new System.Windows.Forms.CheckBox();
            this.gotoBox = new System.Windows.Forms.TextBox();
            this.totalIndex = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Season = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.endSeason = new System.Windows.Forms.Button();
            this.Column_Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_SubGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Eps = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Season = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Current = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column_Stalled = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column_Notes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.cover_art)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animeDatabaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(820, 258);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(85, 33);
            this.Add.TabIndex = 0;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(820, 297);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(85, 33);
            this.Delete.TabIndex = 1;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // cover_art
            // 
            this.cover_art.Location = new System.Drawing.Point(1060, 12);
            this.cover_art.Name = "cover_art";
            this.cover_art.Size = new System.Drawing.Size(159, 240);
            this.cover_art.TabIndex = 2;
            this.cover_art.TabStop = false;
            // 
            // title
            // 
            this.title.Location = new System.Drawing.Point(820, 28);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(211, 20);
            this.title.TabIndex = 3;
            this.title.TextChanged += new System.EventHandler(this.title_TextChanged);
            this.title.KeyUp += new System.Windows.Forms.KeyEventHandler(this.title_KeyUp);
            this.title.MouseLeave += new System.EventHandler(this.title_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(817, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Title";
            // 
            // sub_group
            // 
            this.sub_group.Location = new System.Drawing.Point(820, 67);
            this.sub_group.Name = "sub_group";
            this.sub_group.Size = new System.Drawing.Size(107, 20);
            this.sub_group.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(817, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Sub Group";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(817, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Notes";
            // 
            // episode
            // 
            this.episode.Location = new System.Drawing.Point(820, 106);
            this.episode.Name = "episode";
            this.episode.Size = new System.Drawing.Size(55, 20);
            this.episode.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(817, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Episode";
            // 
            // current
            // 
            this.current.AutoSize = true;
            this.current.Location = new System.Drawing.Point(996, 258);
            this.current.Name = "current";
            this.current.Size = new System.Drawing.Size(66, 17);
            this.current.TabIndex = 11;
            this.current.Text = "Current?";
            this.current.UseVisualStyleBackColor = true;
            this.current.CheckedChanged += new System.EventHandler(this.current_CheckedChanged);
            this.current.MouseUp += new System.Windows.Forms.MouseEventHandler(this.current_MouseUp);
            // 
            // stalled
            // 
            this.stalled.AutoSize = true;
            this.stalled.Location = new System.Drawing.Point(996, 275);
            this.stalled.Name = "stalled";
            this.stalled.Size = new System.Drawing.Size(58, 17);
            this.stalled.TabIndex = 12;
            this.stalled.Text = "Stalled";
            this.stalled.UseVisualStyleBackColor = true;
            this.stalled.CheckedChanged += new System.EventHandler(this.stalled_CheckedChanged);
            this.stalled.MouseUp += new System.Windows.Forms.MouseEventHandler(this.stalled_MouseUp);
            // 
            // notes
            // 
            this.notes.Location = new System.Drawing.Point(820, 146);
            this.notes.Name = "notes";
            this.notes.Size = new System.Drawing.Size(234, 106);
            this.notes.TabIndex = 13;
            this.notes.Text = "";
            this.notes.Leave += new System.EventHandler(this.notes_Leave);
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(912, 259);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(78, 71);
            this.Update.TabIndex = 14;
            this.Update.Text = "Update Database";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_Title,
            this.Column_SubGroup,
            this.Column_Eps,
            this.Column_Season,
            this.Column_Current,
            this.Column_Stalled,
            this.Column_Notes});
            this.dataGridView1.DataSource = this.animeBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(799, 640);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // animeBindingSource
            // 
            this.animeBindingSource.DataMember = "Anime";
            this.animeBindingSource.DataSource = this.animeDatabaseDataSet;
            // 
            // animeDatabaseDataSet
            // 
            this.animeDatabaseDataSet.DataSetName = "AnimeDatabaseDataSet";
            this.animeDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // increment
            // 
            this.increment.Location = new System.Drawing.Point(881, 425);
            this.increment.Name = "increment";
            this.increment.Size = new System.Drawing.Size(46, 37);
            this.increment.TabIndex = 16;
            this.increment.Text = " ^  Eps+1";
            this.increment.UseVisualStyleBackColor = true;
            this.increment.Click += new System.EventHandler(this.increment_Click);
            // 
            // move_up
            // 
            this.move_up.Location = new System.Drawing.Point(820, 384);
            this.move_up.Name = "move_up";
            this.move_up.Size = new System.Drawing.Size(55, 35);
            this.move_up.TabIndex = 17;
            this.move_up.Text = "^\r\n|";
            this.move_up.UseVisualStyleBackColor = true;
            this.move_up.Click += new System.EventHandler(this.move_up_Click);
            // 
            // move_down
            // 
            this.move_down.Location = new System.Drawing.Point(820, 425);
            this.move_down.Name = "move_down";
            this.move_down.Size = new System.Drawing.Size(55, 37);
            this.move_down.TabIndex = 18;
            this.move_down.Text = "|\r\nv";
            this.move_down.UseVisualStyleBackColor = true;
            this.move_down.Click += new System.EventHandler(this.move_down_Click);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Width = 27;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Title";
            this.dataGridViewTextBoxColumn1.HeaderText = "Title";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Title";
            this.dataGridViewTextBoxColumn2.HeaderText = "Title";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Title";
            this.dataGridViewTextBoxColumn3.HeaderText = "Title";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Notes";
            this.dataGridViewTextBoxColumn4.HeaderText = "Notes";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Visible = false;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Title";
            this.dataGridViewTextBoxColumn5.HeaderText = "Title";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Title";
            this.dataGridViewTextBoxColumn6.HeaderText = "Title";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Notes";
            this.dataGridViewTextBoxColumn7.HeaderText = "Notes";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Visible = false;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ID";
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Title";
            this.dataGridViewTextBoxColumn8.HeaderText = "Title";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Title";
            this.dataGridViewTextBoxColumn9.HeaderText = "Title";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Title";
            this.dataGridViewTextBoxColumn10.HeaderText = "Title";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // show_current
            // 
            this.show_current.Location = new System.Drawing.Point(944, 384);
            this.show_current.Name = "show_current";
            this.show_current.Size = new System.Drawing.Size(87, 35);
            this.show_current.TabIndex = 20;
            this.show_current.Text = "Toggle Show Current Anime";
            this.show_current.UseVisualStyleBackColor = true;
            this.show_current.Click += new System.EventHandler(this.show_current_Click);
            // 
            // animeTableAdapter
            // 
            this.animeTableAdapter.ClearBeforeFill = true;
            // 
            // searchCB
            // 
            this.searchCB.AutoSize = true;
            this.searchCB.Location = new System.Drawing.Point(912, 8);
            this.searchCB.Name = "searchCB";
            this.searchCB.Size = new System.Drawing.Size(66, 17);
            this.searchCB.TabIndex = 21;
            this.searchCB.Text = "Search?";
            this.searchCB.UseVisualStyleBackColor = true;
            this.searchCB.CheckedChanged += new System.EventHandler(this.searchCB_CheckedChanged);
            // 
            // gotoBox
            // 
            this.gotoBox.Location = new System.Drawing.Point(912, 106);
            this.gotoBox.Name = "gotoBox";
            this.gotoBox.Size = new System.Drawing.Size(40, 20);
            this.gotoBox.TabIndex = 22;
            this.gotoBox.TextChanged += new System.EventHandler(this.gotoBox_TextChanged);
            this.gotoBox.Enter += new System.EventHandler(this.gotoBox_Enter);
            this.gotoBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gotoBox_KeyUp);
            this.gotoBox.Leave += new System.EventHandler(this.gotoBox_Leave);
            // 
            // totalIndex
            // 
            this.totalIndex.AutoSize = true;
            this.totalIndex.Location = new System.Drawing.Point(958, 109);
            this.totalIndex.Name = "totalIndex";
            this.totalIndex.Size = new System.Drawing.Size(12, 13);
            this.totalIndex.TabIndex = 23;
            this.totalIndex.Text = "/";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(941, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Index";
            // 
            // Season
            // 
            this.Season.Location = new System.Drawing.Point(934, 67);
            this.Season.Name = "Season";
            this.Season.Size = new System.Drawing.Size(100, 20);
            this.Season.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(935, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Season";
            // 
            // endSeason
            // 
            this.endSeason.Location = new System.Drawing.Point(944, 425);
            this.endSeason.Name = "endSeason";
            this.endSeason.Size = new System.Drawing.Size(87, 23);
            this.endSeason.TabIndex = 27;
            this.endSeason.Text = "End of Season";
            this.endSeason.UseVisualStyleBackColor = true;
            this.endSeason.Click += new System.EventHandler(this.endSeason_Click);
            // 
            // Column_Title
            // 
            this.Column_Title.DataPropertyName = "Title";
            this.Column_Title.HeaderText = "Title";
            this.Column_Title.Name = "Column_Title";
            this.Column_Title.ReadOnly = true;
            this.Column_Title.Width = 500;
            // 
            // Column_SubGroup
            // 
            this.Column_SubGroup.DataPropertyName = "Sub group";
            this.Column_SubGroup.HeaderText = "Sub group";
            this.Column_SubGroup.Name = "Column_SubGroup";
            this.Column_SubGroup.ReadOnly = true;
            this.Column_SubGroup.Width = 95;
            // 
            // Column_Eps
            // 
            this.Column_Eps.DataPropertyName = "Eps";
            this.Column_Eps.HeaderText = "Eps";
            this.Column_Eps.Name = "Column_Eps";
            this.Column_Eps.ReadOnly = true;
            this.Column_Eps.Width = 50;
            // 
            // Column_Season
            // 
            this.Column_Season.DataPropertyName = "Season";
            this.Column_Season.HeaderText = "Season";
            this.Column_Season.Name = "Column_Season";
            this.Column_Season.ReadOnly = true;
            this.Column_Season.Width = 50;
            // 
            // Column_Current
            // 
            this.Column_Current.DataPropertyName = "Current";
            this.Column_Current.HeaderText = "Current";
            this.Column_Current.Name = "Column_Current";
            this.Column_Current.ReadOnly = true;
            this.Column_Current.Width = 50;
            // 
            // Column_Stalled
            // 
            this.Column_Stalled.DataPropertyName = "Come Back";
            this.Column_Stalled.HeaderText = "Come Back";
            this.Column_Stalled.Name = "Column_Stalled";
            this.Column_Stalled.ReadOnly = true;
            this.Column_Stalled.Width = 5;
            // 
            // Column_Notes
            // 
            this.Column_Notes.DataPropertyName = "Notes";
            this.Column_Notes.HeaderText = "Notes";
            this.Column_Notes.Name = "Column_Notes";
            this.Column_Notes.ReadOnly = true;
            this.Column_Notes.Width = 5;
            // 
            // DatabaseReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1231, 675);
            this.Controls.Add(this.endSeason);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Season);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.totalIndex);
            this.Controls.Add(this.gotoBox);
            this.Controls.Add(this.searchCB);
            this.Controls.Add(this.show_current);
            this.Controls.Add(this.move_down);
            this.Controls.Add(this.move_up);
            this.Controls.Add(this.increment);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.notes);
            this.Controls.Add(this.stalled);
            this.Controls.Add(this.current);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.episode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sub_group);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.title);
            this.Controls.Add(this.cover_art);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Add);
            this.Name = "DatabaseReader";
            this.Text = "Database Reader";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cover_art)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animeDatabaseDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.PictureBox cover_art;
        private System.Windows.Forms.TextBox title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox sub_group;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox episode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox current;
        private System.Windows.Forms.CheckBox stalled;
        private System.Windows.Forms.RichTextBox notes;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.DataGridView dataGridView1;
        private AnimeDatabaseDataSet animeDatabaseDataSet;
        private System.Windows.Forms.BindingSource animeBindingSource;
        private AnimeDatabaseDataSetTableAdapters.AnimeTableAdapter animeTableAdapter;
        private System.Windows.Forms.Button increment;
        private System.Windows.Forms.Button move_up;
        private System.Windows.Forms.Button move_down;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column_ComeBack;
        private System.Windows.Forms.Button show_current;
        private System.Windows.Forms.CheckBox searchCB;
        private System.Windows.Forms.TextBox gotoBox;
        private System.Windows.Forms.Label totalIndex;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Season;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button endSeason;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_SubGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Eps;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Season;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column_Current;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column_Stalled;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Notes;
    }
}

