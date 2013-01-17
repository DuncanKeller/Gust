using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input.Touch;

namespace GameJam11
{
    class World
    {
        List<Area> areas = new List<Area>();
        Player player;
        TouchCollection touch;
        

        public World()
        {

        }

        public void Update()
        {
            //update touch
            touch = TouchPanel.GetState();

            foreach (Area area in areas)
            {
                if (player.CurrentArea == area)
                {
                    area.Update(touch);
                }
            }
        }

        public void Draw(SpriteBatch sb)
        {
            foreach (Area area in areas)
            {
                if (player.CurrentArea == area)
                {
                    area.Draw(sb);
                }
            }
        }
    }
}
