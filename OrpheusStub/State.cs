using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrpheusStub
{
    class State
    {
        private int _numArcs;
        public int numArcs {
            get { return _numArcs; }
            set { _numArcs = value; }
        }
        private Arc[] _arcs;
        public Arc[] arcs
        {
            get { return _arcs; }
            set { _arcs = value; }
        }

        private Line _lineLookAt;
        public Line lineLookAt
        {
            get { return _lineLookAt; }
            set { _lineLookAt = value; }
        }
        private Line _linePickUp;
        public Line linePickUp
        {
            get { return _linePickUp; }
            set { _linePickUp = value; }
        }
        private Line _lineTalk;
        public Line lineTalk
        {
            get { return _lineTalk; }
            set { _lineTalk = value; }
        }

        private Line _lineWrongUse;
        public Line lineWrongUse
        {
            get { return _lineWrongUse; }
            set { _lineWrongUse = value; }
        }
        private Line _lineCorrectUse;
        public Line lineCorrectUse
        {
            get { return _lineCorrectUse; }
            set { _lineCorrectUse = value; }
        }

        private Dialogue _dialogue;
        public Dialogue dialogue
        {
            get { return _dialogue; }
            set { _dialogue = value; }
        }

        private Availability _availability;
        public Availability availability
        {
            get { return _availability; }
            set { _availability = value; }
        }




        public Line getLine(String action) {
            if (action.Equals("lookAt"))
            {
                return lineLookAt;
            }
            else
                if (action.Equals("pickUp"))
                {
                    return linePickUp;
                }
                else
                    if (action.Equals("talk"))
                    {
                        return lineTalk;
                    }
                    else
                        if (action.Equals("wrongUse"))
                        {
                            return lineWrongUse;
                        }
                        else
                            if (action.Equals("correctUse"))
                            {
                                return lineCorrectUse;
                            }
                            else
                                return null;
        }

    }
}
