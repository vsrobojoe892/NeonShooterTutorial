using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace NeonShooterTutorial
{
    static class Art
    {
        public static Texture2D Player { get; private set; }
        public static Texture2D Seeker { get; private set; }
        public static Texture2D Wanderer { get; private set; }
        public static Texture2D Bullet { get; private set; }
        public static Texture2D Pointer { get; private set; }

        public static void Load(GameRoot instance)
        {
            Player = instance.Content.Load<Texture2D>("Art\\Player");
            Seeker = instance.Content.Load<Texture2D>("Art\\Seeker");
            Wanderer = instance.Content.Load<Texture2D>("Art\\Wanderer");
            Bullet = instance.Content.Load<Texture2D>("Art\\Bullet");
            Pointer = instance.Content.Load<Texture2D>("Art\\Pointer");
        }
    }
}
