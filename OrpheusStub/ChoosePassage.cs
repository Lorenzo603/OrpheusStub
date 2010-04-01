using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrpheusStub
{
    class ChoosePassage
    {

        private int _numPassages = 4;
        public int numPassages
        {
            get { return _numPassages; }
            set { _numPassages = value; }
        }

        private Passage[] _passages;
        public Passage[] passages {
            get { return _passages; }
            set { _passages = value; }
        }

        private Line[] _lines;
        public Line[] lines
        {
            get { return _lines; }
            set { _lines = value; }
        }


        public ChoosePassage(int numPassages) {
            _numPassages = numPassages;
            _passages = new Passage[_numPassages];
            _lines = new Line[_numPassages];
        }

        public bool addPassage(Passage newPassage, int index) {
            if (index >= numPassages || index < 0)
            {
                return false;
            }
            else {
                passages[index] = newPassage;
                return true;
            }
        }

        public bool addLine(Line newLine, int index)
        {
            if (index >= numPassages || index < 0)
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
