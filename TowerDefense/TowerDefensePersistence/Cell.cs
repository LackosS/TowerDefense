namespace TowerDefensePersistence
{
    /// <summary>
    /// Cellák osztálya
    /// </summary>
    public abstract class Cell
    {
        private int row;
        private int col;

        /// <summary>
        /// X koordináta lekérdező property
        /// </summary>
        public int Row { get => row; set => row = value; }
        /// <summary>
        /// Y koordináta lekérdező property
        /// </summary>
        public int Col { get => col; set => col = value; }

        /// <summary>
        /// Cella konstruktora
        /// </summary>
        /// <param name="inrow">X koordináta</param>
        /// <param name="incol">Y koordináta</param>
        public Cell(int inrow, int incol)
        {
            row = inrow;
            col = incol;
        }

    }
}
