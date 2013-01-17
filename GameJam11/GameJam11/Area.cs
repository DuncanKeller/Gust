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
    class Area
    {
        Path path;
        Texture2D background;
        Module module;

        public Path AreaPath
        {
            get { return path; }
        }

        /// <summary>
        /// Create a new area
        /// </summary>
        /// <param name="path">The points that the player can traverse</param>
        /// <param name="background">The entire background image</param>
        public Area(Path path, Texture2D background, Module module)
        {
            this.path = path;
            this.background = background;
            this.module = module;
        }

        public void Update(TouchCollection tc)
        {
            module.Update(tc);
        }

        public Path GetPath()
        {
            return path;
        }

        public void Draw(SpriteBatch sb)
        {
            Rectangle rect = new Rectangle(0, 0, background.Width, background.Height);
            sb.Draw(background, rect, Color.White);
        }


    }
}
