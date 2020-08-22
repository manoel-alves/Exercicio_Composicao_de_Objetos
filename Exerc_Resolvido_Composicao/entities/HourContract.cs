using System;

namespace Exerc_Resolvido_Composicao.entities
{
    class HourContract
    {

        public DateTime Date { get; set; }
        public double ValuePerHour { get; set; }
        public int Hours { get; set; }

        public HourContract()
        {
        }

        public HourContract(DateTime date, double vph, int hours)
        {
            Date = date;
            ValuePerHour = vph;
            Hours = hours;
        }

        public double TotalValue()
        {
            double total = ValuePerHour * Hours;
            return total;
        }

    }
}
