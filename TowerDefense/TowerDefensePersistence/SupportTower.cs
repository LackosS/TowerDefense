using System;

namespace TowerDefensePersistence
{
    /// <summary>
    /// Támogató torony osztálya
    /// </summary>
    public class SupportTower : Tower
    {
        private int healAmount;

        public event EventHandler KilledUnit;

        public int HealAmount { get => healAmount; set => healAmount = value; }

        /// <summary>
        /// Támogató torony konstruktora
        /// </summary>
        /// <param name="inplayer">Aktuális player</param>
        /// <param name="inrow">X koordináta</param>
        /// <param name="incol">Y koordináta</param>
        public SupportTower(PlayerType inplayer, int inrow, int incol)
        : base(inplayer, inrow, incol)
        {
            Range = 2;
            Damage = 5;
            TargetCount = 1;
            healAmount = 5;
        }

        /// <summary>
        /// Megölt egységek metódusa
        /// </summary>
        /// <param name="s">Aktuális katona</param>
        public override void AttackSoldier(Soldier s)
        {
            base.AttackSoldier(s);
            if (s.IsDead)
            {
                KilledUnit?.Invoke(this, EventArgs.Empty);
            }
        }

        /// <summary>
        /// Támogató torony fejlesztés metódusa
        /// </summary>
        /// <exception cref="Exception">Nem sikerült fejlesztés</exception>
        public override void Upgrade()
        {
            base.Upgrade();
            switch (Level)
            {
                case 2:
                    HealAmount++;
                    break;
                case 3:
                    Damage += 5;
                    Range++;
                    break;
                case 4:
                    TargetCount++;
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
        /// Támogató torony fejlesztésének árát megadó metódus
        /// </summary>
        /// <returns>Fejlesztés ára</returns>
        /// <exception cref="Exception">Nincs elég pénz a fejlesztésre</exception>
        public override int UpgradeCost()
        {
            switch (Level)
            {
                case 1:
                    return 70;
                case 2:
                    return 120;
                case 3:
                    return 140;
                case 4:
                    return 160;
                case 5:
                    return 170;
                default: throw new Exception();
            }
        }

        /// <summary>
        /// Támogató torony megsemmisítés után megadja mennyi pénz jár érte
        /// </summary>
        /// <returns>Elbontásért kapott pénz</returns>
        public override int RemovalGain()
        {
            return SupportTower.BuildCost() / 2 + Level * 20;
        }

        /// <summary>
        /// A támogató torony árát kiszámoló metódus
        /// </summary>
        /// <returns>A támogató torony ára</returns>
        public static int BuildCost()
        {
            return 150;
        }
    }
}
