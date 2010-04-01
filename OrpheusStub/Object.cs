using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrpheusStub
{
    class Object: Entity
    {
        private Character _owner;
        public Character owner {
            get { return _owner; }
            set { _owner = value; }
        }


        public override void talk()
        {
            
        }
    }
}
