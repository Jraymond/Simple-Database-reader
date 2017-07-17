using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Database_reader
{
    public partial class DatabaseReader : Form
    {
        public static class Globals
        {
            public static bool showing_current = false;
            public static bool form_loaded = false;
            public static bool gotobox_foucsed = false;
        }

        public DatabaseReader()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'animeDatabaseDataSet.Anime' table. You can move, or remove it, as needed.
            this.animeTableAdapter.Fill(this.animeDatabaseDataSet.Anime);
            Globals.form_loaded = true;
            this.totalIndex.Text = "/ " + dataGridView1.RowCount.ToString();
            this.gotoBox.Text = (this.dataGridView1.CurrentCell.RowIndex + 1).ToString();
        }

        private void increment_Click(object sender, EventArgs e)
        {
            int val = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Column_Eps"].Value);

            dataGridView1.CurrentRow.Cells["Column_Eps"].Value = val + 1;
            episode.Text = dataGridView1.CurrentRow.Cells["Column_Eps"].Value.ToString();

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (!this.searchCB.Checked)
            {
                foreach (DataGridViewRow row in this.dataGridView1.SelectedRows)
                {
                    try
                    {
                        title.Text = row.Cells["Column_Title"].Value.ToString();
                        sub_group.Text = row.Cells["Column_SubGroup"].Value.ToString();
                        Season.Text = row.Cells["Column_Season"].Value.ToString();
                        episode.Text = row.Cells["Column_Eps"].Value.ToString();
                        current.Checked = Convert.ToBoolean(row.Cells["Column_Current"].Value);
                        stalled.Checked = Convert.ToBoolean(row.Cells["Column_Stalled"].Value);
                        notes.Text = row.Cells["Column_Notes"].Value.ToString();
                        gotoBox.Text = (this.dataGridView1.CurrentCell.RowIndex + 1).ToString();
                    }
                    catch (Exception debug)
                    {
                        Console.Write(debug);
                    }

                }
            }
            //this.searchCB.Checked = false;
        }

        private void notes_Leave(object sender, EventArgs e)
        {
            dataGridView1.CurrentRow.Cells["Column_Notes"].Value = notes.Text;
        }

        private void move_down_Click(object sender, EventArgs e)
        {
            select_next_row();

        }

        private void move_up_Click(object sender, EventArgs e)
        {
            select_previous_row();
        }

        private void current_CheckedChanged(object sender, EventArgs e)
        {
         //left empty
        }

        private void stalled_CheckedChanged(object sender, EventArgs e)
        {
         //left empty
        }

        private void current_MouseUp(object sender, MouseEventArgs e)
        {
            dataGridView1.CurrentRow.Cells["Column_Current"].Value = current.Checked;
        }

        private void stalled_MouseUp(object sender, MouseEventArgs e)
        {
            dataGridView1.CurrentRow.Cells["Column_ComeBack"].Value = stalled.Checked;
        }

        private void Add_Click(object sender, EventArgs e)
        {
            try
            {
                using (var addrow = new AddRow())
                {
                    var result = addrow.ShowDialog();

                    if (result == DialogResult.OK)
                    {
                        DataRow newDataRow = animeDatabaseDataSet.Tables["Anime"].NewRow();                        
                        newDataRow["Title"] = addrow.returnTitle;
                        newDataRow["Sub Group"] = addrow.returnSub;
                        newDataRow["Eps"] = addrow.returnEps;
                        newDataRow["Season"] = addrow.returnSeason;
                        newDataRow["Current"] = addrow.returnCurrent;
                        newDataRow["Come Back"] = addrow.returnStalled;
                        newDataRow["Notes"] = addrow.returnNotes;

                        animeDatabaseDataSet.Tables["Anime"].Rows.Add(newDataRow);
                    }
                }
                update_database();
            }
            catch
            {
                MessageBox.Show("Something went wrong");
            }
            
        }

        private void Update_Click(object sender, EventArgs e)
        {
            update_database();
            MessageBox.Show("Database Updated");
        }

        private void Delete_Click(object sender, EventArgs e)
        {

            int rowID = dataGridView1.CurrentCell.RowIndex;

            dataGridView1.Rows.RemoveAt(rowID);
        }

        private void show_current_Click(object sender, EventArgs e)
        {

            update_database();

            if (!Globals.showing_current)
            {
                this.animeTableAdapter.GetCurrent(this.animeDatabaseDataSet.Anime);
                Globals.showing_current = true;
            }
            else
            {
                int rowID = Convert.ToInt32(gotoBox.Text);
                
                this.animeTableAdapter.Fill(this.animeDatabaseDataSet.Anime);
                Globals.showing_current = false;

                dataGridView1.Rows[--rowID].Selected = true;
                dataGridView1.CurrentCell = dataGridView1.Rows[rowID].Cells[0];
            }
            this.totalIndex.Text = "/ " + dataGridView1.RowCount.ToString();
            this.gotoBox.Text = (this.dataGridView1.CurrentCell.RowIndex + 1).ToString();
        }

        private void title_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.searchCB.Checked)
                {
                    update_database();
                    this.animeTableAdapter.SearchFor(this.animeDatabaseDataSet.Anime, this.title.Text);
                    this.totalIndex.Text = "/ " + dataGridView1.RowCount.ToString();
                    this.gotoBox.Text = (this.dataGridView1.CurrentCell.RowIndex + 1).ToString();
                }

            }
            catch
            {
                MessageBox.Show("search exception");
            }
        }

        private void title_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if(e.KeyCode == Keys.Return && this.searchCB.Checked)
                {
                    update_database();
                    this.animeTableAdapter.SearchFor(this.animeDatabaseDataSet.Anime, this.title.Text);
                    this.totalIndex.Text = "/ " + dataGridView1.RowCount.ToString();
                    this.gotoBox.Text = (this.dataGridView1.CurrentCell.RowIndex + 1).ToString();
                }

            }
            catch
            {
                MessageBox.Show("search exception");
            }
        }

        private void searchCB_CheckedChanged(object sender, EventArgs e)
        {
            if(Globals.form_loaded && !this.searchCB.Checked)
            {
                int rowID = Convert.ToInt32(gotoBox.Text);

                update_database();

                this.animeTableAdapter.Fill(this.animeDatabaseDataSet.Anime);
                this.totalIndex.Text = "/ " + dataGridView1.RowCount.ToString();
                this.gotoBox.Text = (this.dataGridView1.CurrentCell.RowIndex + 1).ToString();

                dataGridView1.Rows[--rowID].Selected = true;
                dataGridView1.CurrentCell = dataGridView1.Rows[rowID].Cells[0];
            }
        }

        private void gotoBox_TextChanged(object sender, EventArgs e)
        {
            //left empty
        }

        private void gotoBox_Enter(object sender, EventArgs e)
        {
            Globals.gotobox_foucsed = true;
        }

        private void gotoBox_Leave(object sender, EventArgs e)
        {
            Globals.gotobox_foucsed = false;
        }

        private void gotoBox_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (Globals.form_loaded && Globals.gotobox_foucsed && e.KeyCode == Keys.Return)
                {
                    int rowcount = dataGridView1.RowCount;
                    int gotorow = Convert.ToInt32(this.gotoBox.Text) - 1;

                    this.totalIndex.Text = "/ " + rowcount.ToString();

                    if (gotorow < rowcount && gotorow > 0)
                    {
                        dataGridView1.Rows[gotorow].Selected = true;
                        dataGridView1.CurrentCell = dataGridView1.Rows[gotorow].Cells[0];
                        this.gotoBox.Text = (this.dataGridView1.CurrentCell.RowIndex + 1).ToString();
                    }

                }
            }
            catch
            {

            }
        }
        public void update_database()
        {
            try
            {
                this.Validate();
                this.animeBindingSource.EndEdit();
                this.animeTableAdapter.Update(this.animeDatabaseDataSet.Anime);
                this.totalIndex.Text = "/ " + dataGridView1.RowCount.ToString();
                this.gotoBox.Text = (this.dataGridView1.CurrentCell.RowIndex + 1).ToString();                
            }
            catch
            {
                if (animeDatabaseDataSet.HasErrors)
                {
                    foreach (DataTable table in animeDatabaseDataSet.Tables)
                    {
                        if (table.HasErrors)
                        {
                            foreach (DataRow row in table.Rows)
                            {
                                if (row.HasErrors)
                                {

                                    MessageBox.Show("Update Failed on row " + row.ToString() + ".");
                                }
                            }
                        }
                    }
                }
            }
        }

        private void endSeason_Click(object sender, EventArgs e)
        {
            int val = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Column_Season"].Value);

            dataGridView1.CurrentRow.Cells["Column_Season"].Value = val + 1;
            Season.Text = dataGridView1.CurrentRow.Cells["Column_Season"].Value.ToString();

            dataGridView1.CurrentRow.Cells["Column_Eps"].Value = 1;
            Season.Text = dataGridView1.CurrentRow.Cells["Column_Eps"].Value.ToString();

            dataGridView1.CurrentRow.Cells["Column_Current"].Value = false;
            current.Checked = false;
                        
            update_database();

            select_next_row();

        }

        public void select_next_row()
        {
            int Current_Row = dataGridView1.CurrentCell.RowIndex;

            if (Current_Row < dataGridView1.RowCount - 1)
            {
                dataGridView1.Rows[++Current_Row].Selected = true;
                dataGridView1.CurrentCell = dataGridView1.Rows[Current_Row].Cells[0];
            }
            else
            {
                dataGridView1.Rows[0].Selected = true;
                dataGridView1.CurrentCell = dataGridView1.Rows[0].Cells[0];
            }
            this.gotoBox.Text = (this.dataGridView1.CurrentCell.RowIndex + 1).ToString();
        }

        public void select_previous_row()
        {
            int Current_Row = dataGridView1.CurrentCell.RowIndex;

            if (Current_Row > 0)
            {
                dataGridView1.Rows[--Current_Row].Selected = true;
                dataGridView1.CurrentCell = dataGridView1.Rows[Current_Row].Cells[0];
            }
            else
            {
                dataGridView1.Rows[dataGridView1.RowCount - 1].Selected = true;
                dataGridView1.CurrentCell = dataGridView1.Rows[dataGridView1.RowCount - 1].Cells[0];
            }
            this.gotoBox.Text = (this.dataGridView1.CurrentCell.RowIndex + 1).ToString();
        }

        private void title_MouseLeave(object sender, EventArgs e)
        {
            //left empty
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            this.searchCB.Checked = false;
        }
    }
}
