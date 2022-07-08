using System.Collections.Generic;

namespace TowerDefensePersistence
{
    /// <summary>
    /// Katonákat tartalmazó konténer osztálya
    /// </summary>
    public abstract class SoldierContainer : Cell
    {
        private List<Soldier> player1Soldiers;
        private List<Soldier> player2Soldiers;

        protected List<Soldier> player1DeadSoldiers;
        protected List<Soldier> player2DeadSoldiers;

        /// <summary>
        /// Első játékos katonáit lekérdező property
        /// </summary>
        public List<Soldier> Player1Soldiers { get => player1Soldiers; set => player1Soldiers = value; }
        /// <summary>
        /// Második játékos katonáit lekérdező property
        /// </summary>
        public List<Soldier> Player2Soldiers { get => player2Soldiers; set => player2Soldiers = value; }

        /// <summary>
        /// Első játékos halott katonáit lekérdező property
        /// </summary>
        public List<Soldier> Player1DeadSoldiers { get => player1DeadSoldiers; set => player1DeadSoldiers = value; }

        /// <summary>
        /// Második játékos halott katonáit lekérdező property
        /// </summary>
        public List<Soldier> Player2DeadSoldiers { get => player2DeadSoldiers; set => player2DeadSoldiers = value; }

        /// <summary>
        /// Katonákat tartalmazó konténer konstruktora
        /// </summary>
        /// <param name="inrow">X koordináta</param>
        /// <param name="incol">Y koordináta</param>
        public SoldierContainer(int inrow, int incol)
        : base(inrow, incol)
        {
            Player1Soldiers = new List<Soldier>();
            player2Soldiers = new List<Soldier>();
            player1DeadSoldiers = new List<Soldier>();
            player2DeadSoldiers = new List<Soldier>();
        }
    }
}
