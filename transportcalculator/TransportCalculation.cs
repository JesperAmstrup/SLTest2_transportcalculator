using System;
using System.Collections.Generic;
using System.Text;

namespace transportcalculator
{
    public static class TransportCalculation
    {
        public static decimal CalculateTransportcost(int DistanceMeters, decimal WeightGrams)
        {
            if (DistanceMeters <= 0 || WeightGrams <= 0)
            {
                throw new ArgumentOutOfRangeException("Numbers need to be more than 0");
            }

            if (DistanceMeters < 5000)
            {
                //Hvis afstanden er under 5 km og vægten er under 10 kg, så er transporten gratis
                //Er afstanden under 5 km, men vægten er 10 kg eller mere, så koster transporten 50 kr
                return (WeightGrams<10000) ? 0 : 50;
            }
            else
            {
                //Hvis afstanden er 5 km eller mere, koster transporten 75 kroner, hvis vægten er under 10 kg, og 100 kr.i øvrige tilfælde.
                return (WeightGrams < 10000) ? 75 : 100;
            }
        }
    }
}
