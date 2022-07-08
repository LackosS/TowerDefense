namespace TowerDefensePersistence
{
    /// <summary>
    /// Katona osztálya
    /// </summary>
    public abstract class Soldier
    {
        protected int hitpoints;
        protected int damage;
        private PlayerType player;

        /// <summary>
        /// Katona konstruktora
        /// </summary>
        /// <param name="inplayer">Aktuális játékos</param>
        public Soldier(PlayerType inplayer)
        {
            player = inplayer;
        }

        /// <summary>
        /// Halottságot lekérdező property
        /// </summary>
        public bool IsDead { get => hitpoints <= 0; }
        /// <summary>
        /// Életerőt lekérdező property
        /// </summary>
        public int HitPoints { get => hitpoints; set => hitpoints = value; }

        /// <summary>
        /// Sebzést lekérdező property
        /// </summary>
        public int Damage { get => damage; set => damage = value; }

        /// <summary>
        /// Aktuális játékost lekérdező property
        /// </summary>
        public PlayerType Player { get => player; set => player = value; }
    }
}
