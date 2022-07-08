namespace TowerDefensePersistence
{
    /// <summary>
    /// Páncélozott katona osztálya
    /// </summary>
    public class TankSoldier : Soldier
    {
        /// <summary>
        /// Páncélozott katona konstruktora
        /// </summary>
        /// <param name="inplayer"></param>
        public TankSoldier(PlayerType inplayer)
        : base(inplayer)
        {
            damage = 5;
            hitpoints = 50;
        }
        /// <summary>
        /// A páncélozott katona árát kiszámoló metódus
        /// </summary>
        /// <returns>A katona árát</returns>
        public static int BuildCost()
        {
            return 50;
        }
    }
}
