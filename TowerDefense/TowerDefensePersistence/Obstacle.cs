namespace TowerDefensePersistence
{
    /// <summary>
    /// Akadály osztálya
    /// </summary>
    public abstract class Obstacle : Cell
    {
        /// <summary>
        /// Akadály konstruktora
        /// </summary>
        /// <param name="inrow">X koordináta</param>
        /// <param name="incol">Y koordináta</param>
        public Obstacle(int inrow, int incol)
            : base(inrow, incol)
        {

        }
    }
}
