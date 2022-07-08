using System;

namespace TowerDefensePersistence
{
    /// <summary>
    /// Sebző torony osztálya
    /// </summary>
    public class DamageTower : Tower
    {
        /// <summary>
        /// Sebző torony konstruktora
        /// </summary>
        /// <param name="inplayer">Aktuális játékos</param>
        /// <param name="inrow">X koordináta</param>
        /// <param name="incol">Y koordináta</param>
        public DamageTower(PlayerType inplayer, int inrow, int incol)
        : base(inplayer, inrow, incol)
        {
            Range = 2;
            Damage = 10;
            TargetCount = 2;
        }

        /// <summary>
        /// Sebző torony fejlesztés metódusa
        /// </summary>
        /// <exception cref="Exception">Nem sikerült fejlesztés</exception>
        public override void Upgrade()
        {
            base.Upgrade();
            switch (Level)
            {

                case 2:
                    Damage += 5;
                    break;
                case 3:
                    TargetCount++;
                    break;
                case 4:
                    Damage += 5;
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
        /// Sebző torony fejlesztésének árát megadó metódus
        /// </summary>
        /// <returns>Fejlesztés ára</returns>
        /// <exception cref="Exception">Nincs elég pénz a fejlesztésre</exception>
        public override int UpgradeCost()
        {
            switch (Level)
            {
                case 1:
                    return 80;
                case 2:
                    return 140;
                case 3:
                    return 160;
                case 4:
                    return 180;
                case 5:
                    return 200;
                default: throw new Exception();
            }
        }

        /// <summary>
        /// Sebző torony megsemmisítés után megadja mennyi pénz jár érte
        /// </summary>
        /// <returns>Elbontásért kapott pénz</returns>
        public override int RemovalGain()
        {
            return DamageTower.BuildCost() / 2 + Level * 20;
        }

        /// <summary>
        /// A sebző torony árát kiszámoló metódus
        /// </summary>
        /// <returns>A sebző torony ára</returns>
        public static int BuildCost()
        {
            return 200;
        }
    }
}
