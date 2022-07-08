namespace TowerDefensePersistence
{
    /// <summary>
    ///Támadó katona osztálya
    /// </summary>
    public class AttackSoldier : Soldier
    {
        /// <summary>
        /// Támadó katona konstruktora
        /// </summary>
        /// <param name="inplayer">Aktuális játékos</param>
        public AttackSoldier(PlayerType inplayer)
        : base(inplayer)
        {
            damage = 10;
            hitpoints = 35;
        }

        /// <summary>
        /// A támadó katona árát kiszámoló metódus
        /// </summary>
        /// <returns>A katona árát</returns>
        public static int BuildCost()
        {
            return 30;
        }
    }
}
