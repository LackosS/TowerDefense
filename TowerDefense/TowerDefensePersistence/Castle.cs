using System;

namespace TowerDefensePersistence
{
    /// <summary>
    /// A kastély osztálya
    /// </summary>
    public class Castle : SoldierContainer
    {
        private int hitpoints;
        private PlayerType player;

        /// <summary>
        /// Aktuális játékost lekérdező property
        /// </summary>
        public PlayerType Player { get => player; set => player = value; }


        /// <summary>
        /// Aktuális kastély életerejét lekérdező property
        /// </summary>
        public int Hitpoints { get => hitpoints; set => hitpoints = Math.Max(Math.Min(value,100),0); }


        /// <summary>
        /// Kastály konstruktora
        /// </summary>
        /// <param name="inplayer">Aktuális játékos</param>
        /// <param name="inrow">X koordináta</param>
        /// <param name="incol">Y koordináta</param>
        public Castle(PlayerType inplayer, int inrow, int incol)
        : base(inrow, incol)
        {
            Hitpoints = 100;
            player = inplayer;
        }

        /// <summary>
        /// Támogató torony által megölt egységek metódusa, amely növeli a kastély életét
        /// </summary>
        public void SupportTower_KilledUnit(object obj, EventArgs e)
        {
            Hitpoints += (obj as SupportTower).HealAmount;
        }

        /// <summary>
        /// Katona sebzéséért felelős metódus
        /// </summary>
        /// <param name="s">Sebzendő katona</param>
        /// <returns>A katona sebzési értékével</returns>
        public int TakeDamage(Soldier s)
        {
            Hitpoints -= s.Damage;
            return s.Damage;
        }
    }
}
