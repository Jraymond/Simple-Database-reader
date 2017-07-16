using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Database_reader
{
    public partial class AddRow : Form
    {
        public string returnTitle { get; set; }
        public string returnSub { get; set; }
        public int returnEps { get; set; }
        public int returnSeason { get; set; }
        public bool returnCurrent { get; set; }
        public bool returnStalled { get; set; }
        public string returnNotes { get; set; }

        public AddRow()
        {
            InitializeComponent();
        }

        private void AddRow_Load(object sender, EventArgs e)
        {
            
            this.title.Text = "default";
            this.subgroup.Text = "N/a";
            this.episode.Text = "1";
            this.season.Text = "1";
        }

        private void add_Click(object sender, EventArgs e)
        {
            int result = 1;
                       
            if (int.TryParse(this.episode.Text, out result))
            this.returnEps = result;

            if (int.TryParse(this.season.Text, out result))
            this.returnSeason = result;

            this.returnCurrent = this.current.Checked;
            this.returnNotes = this.notes.Text.ToString();
            this.returnStalled = this.stalled.Checked;
            this.returnSub = this.subgroup.Text.ToString();
            this.returnTitle = this.title.Text.ToString();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
