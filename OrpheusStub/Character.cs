using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrpheusStub
{
    class Character: Entity
    {

        public override void talk() {
            entityState.currentState.dialogue.start();
        }

        public void sayLine(Line line) {
            Console.WriteLine(line.line);
        }

        public void notifyPickUp() {}
    }
}
