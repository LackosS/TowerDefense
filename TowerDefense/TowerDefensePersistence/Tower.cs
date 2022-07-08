using System;

namespace TowerDefensePersistence
{
    /// <summary>
    /// Torony osztálya
    /// </summary>
    public abstract class Tower : Cell
    {
        const int maxLevel = 5;
        private int level;
        private int range;
        private int damage;
        private int targetCount;
        private PlayerType player;

        /// <summary>
        /// Adattagokat lekérdező propertyk
        /// </summary>
        public PlayerType Player { get => player; set => player = value; }
        public int Level { get => level; set => level = value; }
        public int Range { get => range; set => range = value; }
        public int Damage { get => damage; set => damage = value; }
        public int TargetCount { get => targetCount; set => targetCount = value; }

        /// <summary>
        /// Torony konstruktora
        /// </summary>
        /// <param name="inplayer">Aktuális játékos</param>
        /// <param name="inrow">X koordináta</param>
        /// <param name="incol">Y koordináta</param>
        public Tower(PlayerType inplayer, int inrow, int incol)
            : base(inrow, incol)
        {
            Player = inplayer;
            Level = 1;
        }

        /// <summary>
        /// Megnézi hogy egy adott cella a torony hatótávolságában van-e
        /// </summary>
        /// <param name="x">X koordinéta</param>
        /// <param name="y">Y koordinéta</param>
        /// <returns>Igen/Nem</returns>
        public bool IsInRange(int x, int y)
        {
            return Math.Abs(x - Row) + Math.Abs(y - Col) <= Range;
        }

        /// <summary>
        /// Megölt egységek metódusa
        /// </summary>
        /// <param name="s">Aktuális katona</param>
        public virtual void AttackSoldier(Soldier s)
        {
            s.HitPoints -= Damage;
        }

        /// <summary>
        /// Torony fejlesztésének árát megadó metódus
        /// </summary>
        /// <returns>Fejlesztés ára</returns>
        /// <exception cref="Exception">Nincs elég pénz a fejlesztésre</exception>
        public abstract int UpgradeCost();

        /// <summary>
        /// Torony megsemmisítés után megadja mennyi pénz jár érte
        /// </summary>
        /// <returns>Elbontásért kapott pénz</returns>
        public abstract int RemovalGain();

        /// <summary>
        /// Torony fejlesztés metódusa
        /// </summary>
        /// <exception cref="Exception">Nem sikerült fejlesztés</exception>
        /// <summary>
        public virtual void Upgrade()
        {
            Level++;
        }

        /// <summary>
        /// Megnézi hogy a torony elérte-e már a maximális szintet
        /// </summary>
        /// <returns>Igen/Nem</returns>
        public bool IsMaxLevel()
        {
            return Level == maxLevel;
        }

    }
}
