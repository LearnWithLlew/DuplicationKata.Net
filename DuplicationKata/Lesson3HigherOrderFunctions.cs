namespace DuplicationKata
{
    public class Lesson3HigherOrderFunctions: Song
    {
        public void SingCheers()
        {
            int number = 2;
            Sing(number + "! ");
            number = number + 2;
            Sing(number + "! ");
            number = number + 2;
            Sing(number + "! ");
            number = number + 2;
            Sing(number + "! ");
            Sing("Who do we appreciate?");
            number = 17;
            Sing(number + "! ");
            number = GetNextPrime(number);
            Sing(number + "! ");
            number = GetNextPrime(number);
            Sing(number + "! ");
            number = GetNextPrime(number);
            Sing(number + "! ");
            Sing("These are the primes, that we find fine!");
        }
        private int GetNextPrime(int number)
        {
            switch (number)
            {
                case 13:
                    return 17;
                case 17:
                    return 19;
                case 19:
                    return 23;
                case 23:
                    return 29;
            }
            return 0;
        }
    }
}