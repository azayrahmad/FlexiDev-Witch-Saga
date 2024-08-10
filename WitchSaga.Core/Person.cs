namespace WitchSaga.Core
{
    /// <summary>
    /// Represents a person in the village with their age of death and year of death.
    /// </summary>
    public class Person
    {
        /// <summary>
        /// Gets the age at which the person died.
        /// </summary>
        public int AgeOfDeath { get; }

        /// <summary>
        /// Gets the year in which the person died.
        /// </summary>
        public int YearOfDeath { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Person"/> class.
        /// </summary>
        /// <param name="ageOfDeath">The age at which the person died.</param>
        /// <param name="yearOfDeath">The year in which the person died.</param>
        /// <exception cref="ArgumentException">Thrown when age or year is invalid.</exception>
        public Person(int ageOfDeath, int yearOfDeath)
        {
            if (ageOfDeath < 0 || yearOfDeath < 1)
                throw new ArgumentException("Invalid age or year");

            AgeOfDeath = ageOfDeath;
            YearOfDeath = yearOfDeath;
        }

        /// <summary>
        /// Gets the birth year of the person.
        /// </summary>
        public int BirthYear => YearOfDeath - AgeOfDeath;
    }
}