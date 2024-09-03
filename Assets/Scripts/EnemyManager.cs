using UnityEngine;

namespace Orc
{
    public class EnemyManager : MonoBehaviour
    {
        // we make this static so there can only be one shared across all of this
        //type of class and theyre going to be one instance, so all of them will share the little instance right here
        public static EnemyManager instance;

        public int enemyArcherHP;
        public int enemyArcherDamage;
        public int enemyWarriorHP;
        public int enemyWarriorDamage;
        private void Awake()
        {
            //The Singleton pattern ensures a single instance of a class in the game.
            //If an instance of a Singleton already exists in the game, attempting to create or spawn another instance will result in the new one destroying itself.
            //If a Singleton does not yet exist when trying to spawn one, it will become the main Singleton.
            //Any subsequent attempts to create another instance will cause it to be destroyed.
            if (instance != null && instance != this)
            {
                Destroy(this.gameObject);
            }
            else
            {
                instance = this;
            }
        }

        //public int ArcherHP()
        //{
        //    return enemyArcherHP;
        //}

    }
}
