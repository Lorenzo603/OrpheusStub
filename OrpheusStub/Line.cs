using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrpheusStub
{
    class Line
    {
        private String _line;
        public String line 
        {
            get { return _line; }
            set { _line = value; }
        }

        private Character _character;
        public Character character {
            get { return _character; }
            set { _character = value; }
        }

        public Line(Character character, String line) {
            _character = character;
            _line = line;
        }


    }
}
