namespace Struct_2
{
    internal interface ISize
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
        /// Method that calculate rectangle's perimeter
        /// </summary>
        /// <returns>Returns rectangle's perimeter</returns>
        double Perimeter();
    }
}