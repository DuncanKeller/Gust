using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace GameJam11
{
    class Path
    {
        List<Point> points = new List<Point>();
        Point start;
        List<Point> exits = new List<Point>();

        public Point Start
        {
            get { return start; }
        }

        public List<Point> Exits
        {
            get { return exits; }
        }

        /// <summary>
        /// The path along which the player can travel
        /// </summary>
        /// <param name="points">All points that make up the path</param>
        /// <param name="start">The point where the player begins</param>
        /// <param name="exits">All exits along the path</param>
        public Path(List<Point> points, Point start, List<Point> exits)
        {
            this.points = points;
            this.start = start;
            this.exits = exits;
        }
    }
}
