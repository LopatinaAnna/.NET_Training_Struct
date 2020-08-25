namespace Struct_1
{
    /// <summary>
    /// Struct that defines a person 
    /// </summary>
    public struct Person
    {
        /// <summary>
        /// Person's name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Person's surname
        /// </summary>
        public string Surname { get; set; }

        /// <summary>
        /// Person's age
        /// </summary>
        public int Age { get; set; }

        /// <summary>
        /// Struct's method that compare input number and person's age
        /// </summary>
        /// <param name="n"></param>
        /// <returns>Returns string that contains result of comparation</returns>
        public string CheckAge(int n)
        {
            if (n < 0)
                return "Number is less than zero";
            if (n == Age)
                return $"{Name} {Surname} is {n}";
            if (n < Age)
                return $"{Name} {Surname} older than {n}";
            else
                return $"{Name} {Surname} younger than {n}";
        }
    }
}