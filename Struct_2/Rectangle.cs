namespace Struct_2
{
    /// <summary>
    /// Struct that defines a rectangle
    /// </summary>
    public struct Rectangle : ISize, ICoordinates
    {
        /// <summary>
        /// Rectangle's width
        /// </summary>
        public double Width { get; set; }

        /// <summary>
        /// Rectangle's height
        /// </summary>
        public double Height { get; set; }

        /// <summary>
        /// Coordinate x
        /// </summary>
        public double X { get; set; }

        /// <summary>
        /// Coordinate y
        /// </summary>
        public double Y { get; set; }

        /// <summary>
        /// Method that calculate rectangle's perimeter
        /// </summary>
        /// <returns>Returns rectangle's perimeter</returns>
        public double Perimeter()
        {
            if (Width <= 0 || Height <= 0)
                return default;
            return 2 * Width + 2 * Height;
        }
    }
}