using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using Microsoft.Xna.Framework.Net;
using Microsoft.Xna.Framework.Storage;

namespace OrpheusStub
{
    abstract class Entity
    {
        private Vector3 _position;
        public Vector3 position {
            get { return _position; }
            set { _position = value; }
        }

        private Model _model;
        public Vector3 model
        {
            get { return _model; }
            set { _model = value; }
        }

        private EntityState _entityState;
        public EntityState entityState {
            get { return _entityState; }
            set { _entityState = value; }
        }

    }
}
