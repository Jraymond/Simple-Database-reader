using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database_reader
{
    class Datum
    {
        public string title
        {
            get
            {
                return this.title;
            }
            set
            {
                this.title = value;
            }
        }
        public string sub_group
        {
            get
            {
                return this.sub_group;
            }
            set
            {
                this.sub_group = value;
            }
        }
        public int season
        {
            get
            {
                return this.season;
            }
            set
            {
                this.season = value;
            }
        }
        public string notes
        {
            get
            {
                return this.notes;
            }
            set
            {
                this.notes = value;
            }
        }
        public int episode
        {
            get
            {
                return this.episode;
            }
            set
            {
                this.episode = value;
            }
        }
        public bool current
        {
            get
            {
                return this.current;
            }
            set
            {
                this.current = value;
            }
        }
        public bool stalled
        {
            get
            {
                return this.stalled;
            }
            set
            {
                this.stalled = value;
            }
        }
        public void eps_increase()
        {
            this.episode = this.episode + 1;
        }
    }
}
