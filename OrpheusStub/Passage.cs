using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrpheusStub
{
    class Passage
    {
        private ChoosePassage _choosePassage;
        public ChoosePassage choosePassage {
            get { return _choosePassage;  }
            set { _choosePassage = value; }
        }

        private EntityState _entityState;
        public EntityState entityState {
            get { return _entityState; }
            set { _entityState = value; }
        }

        private int _numLines;
        public int numLines
        {
            get { return _numLines; }
            set { _numLines = value; }
        }

        private Line[] _lines;
        public Line[] lines
        {
            get { return _lines; }
            set { _lines = value; }
        }




        public Passage(ChoosePassage choosePassage, EntityState entityState, int numLines) {
            this.choosePassage = choosePassage;
            this.entityState = entityState;
            this.numLines = numLines;
            lines = new Line[numLines];
        }

        public bool addLine(Line newLine, int index)
        {
            if (index >= numLines || index < 0)
            {
                return false;
            }
            else
            {
                lines[index] = newLine;
                return true;
            }
        }

    }
}
