namespace TowerDefensePersistence
{
    /// <summary>
    /// Hegy akadály osztálya
    /// </summary>
    public class Mountain : Obstacle
    {
        /// <summary>
        /// Hegy akadály konstruktora
        /// </summary>
        /// <param name="inrow">X koordináta</param>
        /// <param name="incol">Y koordináta</param>
        public Mountain(int inrow, int incol)
            : base(inrow, incol)
        {

        }
    }
}
