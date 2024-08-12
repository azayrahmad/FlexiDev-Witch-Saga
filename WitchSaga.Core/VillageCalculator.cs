namespace WitchSaga.Core
{
    /// <summary>
    /// Provides calculations related to the witch's killing patterns in the village.
    /// </summary>
    public class VillageCalculator
    {
        private readonly Witch witch = new Witch();

        /// <summary>
        /// Calculates the average number of people killed in the birth years of two persons.
        /// </summary>
        /// <param name="personA">The first person.</param>
        /// <param name="personB">The second person.</param>
        /// <returns>
        /// The average number of people killed in the birth years of the two persons,
        /// or -1 if either person was born before the witch took control.
        /// </returns>
        public double CalculateAverage(Person personA, Person personB)
        {
            // Birth year 0 or below means witch haven't killed anyone/took control yet
            if (personA.BirthYear < 1 || personB.BirthYear < 1)
                return -1;

            int killedA = witch.GetKilledInYear(personA.BirthYear);
            int killedB = witch.GetKilledInYear(personB.BirthYear);

            return (killedA + killedB) / 2.0;
        }
    }
}