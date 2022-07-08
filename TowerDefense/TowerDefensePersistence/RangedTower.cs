using System;

namespace TowerDefensePersistence
{
    /// <summary>
    /// Távolsági torony osztálya
    /// </summary>
    public class RangedTower : Tower
    {
        /// <summary>
        /// Távolsági torony konstruktora
        /// </summary>
        /// <param name="inplayer">Aktuális játékos</param>
        /// <param name="inrow">X koordináta</param>
        /// <param name="incol">Y koordináta</param>
        public RangedTower(PlayerType inplayer, int inrow, int incol)
        : base(inplayer, inrow, incol)
        {
            Range = 3;
            Damage = 5;
            TargetCount = 2;
        }

        /// <summary>
        /// Távolsági torony fejlesztés metódusa
        /// </summary>
        /// <exception cref="Exception">Nem sikerült fejlesztés</exception>
        public override void Upgrade()
        {
            base.Upgrade();
            switch (Level)
            {
                case 2:
                    Damage += 3;
                    Range++;
                    break;
                case 3:
                    TargetCount++;
                    break;
                case 4:
                    Damage += 3;
                    break;
                case 5:
                    Damage += 5;
                    Range++;
                    TargetCount++;
                    break;
                default: throw new Exception();
            }
        }

        /// <summary>
        /// Távolsági torony fejlesztésének árát megadó metódus
        /// </summary>
        /// <returns>Fejlesztés ára</returns>
        /// <exception cref="Exception">Nincs elég pénz a fejlesztésre</exception>
        public override int UpgradeCost()
        {
            switch (Level)
            {
                case 1:
                    return 50;
                case 2:
                    return 100;
                case 3:
                    return 120;
                case 4:
                    return 140;
                case 5:
                    return 160;
                default: throw new Exception();
            }
        }

        /// <summary>
        /// Távolsági torony megsemmisítés után megadja mennyi pénz jár érte
        /// </summary>
        /// <returns>Elbontásért kapott pénz</returns>
        public override int RemovalGain()
        {
            return RangedTower.BuildCost() / 2 + Level * 20;
        }

         /// <summary>
        /// A távolsági torony árát kiszámoló metódus
        /// </summary>
        /// <returns>A távolsági torony ára</returns>
        public static int BuildCost()
        {
            return 100;
        }
    }
}
