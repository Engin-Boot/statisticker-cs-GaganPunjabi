using System.Collections.Generic;
using System.Linq;

namespace Statistics
{
    public class StatsComputer
    {
        public Stats CalculateStatistics(List<double> numbers)
        {
            //Implement statistics here
            Stats calculator = new Stats();
            if (numbers.Count > 0)
            {
                calculator.max = numbers.Max();
                calculator.min = numbers.Min();
                calculator.average = numbers.Average();
            }
            else
            {
                calculator.max = calculator.min = calculator.average = double.NaN;
            }
            return calculator;
        }
    }
}
