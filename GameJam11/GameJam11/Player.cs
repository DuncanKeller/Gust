using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input.Touch;

namespace GameJam11
{
    class Player
    {
        Texture2D texture;
        Point pos;
        int width;
        int height;

        Area currentArea;

        public Area CurrentArea
        {
            get { return currentArea; }
        }

        public Player(Texture2D texture, Area area)
        {
            this.texture = texture;
            width = texture.Width;
            height = texture.Height;

            GotoNewArea(area);
        }

        public void GotoNewArea(Area area)
        {
            pos = area.AreaPath.Start;
            currentArea = area;
        }

        public void Update(TouchCollection tc)
        {
            
        }

        public void Move()
        {
            Path path = currentArea.AreaPath;
        }

        public void Draw(SpriteBatch sb)
        {
            Rectangle rect = new Rectangle(pos.X - (width / 2), pos.Y - height, width, height);

            sb.Draw(texture, rect, Color.White);
        }
    }
}
