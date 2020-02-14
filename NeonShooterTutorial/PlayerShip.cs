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
    class PlayerShip : Entity
    {
        private static PlayerShip shipInstance;

        public static PlayerShip Instance
        {
            get
            {
                if (shipInstance == null)
                    shipInstance = new PlayerShip();

                return shipInstance;
            }
        }

        private PlayerShip()
        {
            image = Art.Player;
            Position = GameRoot.ScreenSize / 2;
            Radius = 10;
        }

        public override void Update()
        {
          
        }
    }
}
