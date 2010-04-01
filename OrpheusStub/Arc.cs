using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrpheusStub
{
    class Arc
    {
        private String _action;
        public String action {
            get { return _action; }
            set { _action = value;}
        }

        private Passage _passage;
        public Passage passage {
            get { return _passage; }
            set { _passage = value; }
        }

        private Item _item;
        public Item item {
            get { return _item; }
            set { _item = value; }
        }

        public Arc(String action, Passage passage, Item item) {
            this.action = action;
            this.passage = passage;
            this.item = item;
        }

    }
}
