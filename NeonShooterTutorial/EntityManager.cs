using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;
using System.Linq;

namespace NeonShooterTutorial
{
    class EntityManager
    {
        static List<Entity> entities = new List<Entity>();


        static bool isUpdating;
        static List<Entity> addEntities = new List<Entity>();

        public static int Count
        {
            get
            {
                return entities.Count;
            }
        }

        public static void Add(Entity entity)
        {
            if (!isUpdating)
                entities.Add(entity);
            else
                addEntities.Add(entity);
        }

        public static void Update()
        {
            isUpdating = true;

            foreach (var entity in entities)
                entity.Update();

            isUpdating = false;

            foreach (var entity in addEntities)
                entities.Add(entity);

            addEntities.Clear();

            entities = entities.Where(x => !x.IsExpired).ToList();
        }

        public static void Draw(SpriteBatch spriteBatch)
        {
            foreach (var entity in entities)
                entity.Draw(spriteBatch);
        }

    }
}
