using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrpheusStub
{
    class Item: Object
    {
        private Entity _correctUseEntity;
        public Entity correctUseEntity {
            get { return _correctUseEntity; }
            set { _correctUseEntity = value; }
        }

        private bool _consumable;
        public bool consumable
        {
            get { return _consumable; }
            set { _consumable = value; }
        }


    }
}
