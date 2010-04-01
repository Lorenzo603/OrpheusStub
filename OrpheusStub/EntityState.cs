using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrpheusStub
{
    class EntityState
    {
        private int _numStates;
        public int numStates
        {
            get { return _numStates; }
            set { _numStates = value; }
        }

        private State[] _states;
        public State[] states {
            get { return _states; }
            set { _states = value;}
        }


        private State _currentState;
        public State currentState
        {
            get { return _currentState; }
            set { _currentState = value; }
        }


        public EntityState(int numStates) {
            this.numStates = numStates;
            states = new State[numStates];
            currentState = states[0];
        }

        public void nextState() { }
        public void nextState(Passage passage) { }
        public void nextState(Item item) { }

    }
}
