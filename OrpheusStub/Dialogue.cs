using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrpheusStub
{
    class Dialogue
    {
        ChoosePassage _currentChoosePassage;
        public ChoosePassage currentChoosePassage {
            get { return _currentChoosePassage; }
            set { _currentChoosePassage = value;  }
        }


        public Dialogue(ChoosePassage firstChoosePassage) {
            currentChoosePassage = firstChoosePassage;
        }

        private void answer(Line question) { }

        public void start() { 
            foreach (Line line in currentChoosePassage.passages[0].lines) {
                line.character.sayLine(line);
            }
            
        }

        public void end() { }
    }
}
