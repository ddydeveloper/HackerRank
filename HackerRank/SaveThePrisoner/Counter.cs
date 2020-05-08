using System;

namespace HackerRank.SaveThePrisoner
{
    public static class Counter
    {
        public static int PrisonerToWarnNumber(int n, int m, int s)
        {
            if (n == 0 || m == 0 || s == 0)
            {
                return -1;
            }

            var startsFrom = s;            
            var prisonersNumber = n;
            var treatsNumber = startsFrom > 1 ? m + startsFrom - 1 : m;

            var result = prisonersNumber == treatsNumber
                ? prisonersNumber
                : prisonersNumber > treatsNumber
                    ? treatsNumber
                    : treatsNumber % prisonersNumber;

            if (prisonersNumber == treatsNumber)
                return prisonersNumber;

            if (prisonersNumber > treatsNumber)
                return treatsNumber;

            var delta = treatsNumber % prisonersNumber;

            return delta == 0 ? prisonersNumber : delta;
        }
    }
}