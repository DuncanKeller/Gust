using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input.Touch;

namespace GameJam11
{
    abstract class Module
    {
        protected bool activated = false;

        public bool IsActivated
        {
            get { return activated; }
        }

        public abstract void Initialize();

        public abstract void Update(TouchCollection tc);

        public abstract void Draw(SpriteBatch sb);
    }
}
