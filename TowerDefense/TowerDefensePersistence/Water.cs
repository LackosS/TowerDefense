namespace TowerDefensePersistence
{
    /// <summary>
    /// Víz akadály osztálya
    /// </summary>
    public class Water : Obstacle
    {
        /// <summary>
        /// Víz akadály konstruktora
        /// </summary>
        /// <param name="inrow">X koordináta</param>
        /// <param name="incol">Y koordináta</param>
        public Water(int inrow, int incol)
            : base(inrow, incol)
        {

        }
    }
}
