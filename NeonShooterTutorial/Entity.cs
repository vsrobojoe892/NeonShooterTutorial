using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;


namespace NeonShooterTutorial
{
    abstract class Entity
    {
        protected Texture2D image;
        protected Color color = Color.White;        //The tint of the Image.  This will also allow us to change the transparency later.

        public Vector2 Position, Velocity;
        public float Orientation;
        public float Radius = 20;                   //This is used for circular collision detection
        public bool IsExpired;                      //This will be true if the entity was destroyed and should be deleted

        public Vector2 Size
        {
            get
            {
                return image == null ? Vector2.Zero : new Vector2(image.Width, image.Height);
            }
        }

        public abstract void Update();

        public virtual void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(image, Position, null, color, Orientation, Size / 2f, 1f, 0, 0);
        }
    }
}
