using System;
using System.Collections.Generic;

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
                var sum = 0.0;
                calculator.max = numbers[0];
                calculator.min = numbers[0];
                foreach (var number in numbers)
                {
                    sum += number;
                    if (number > calculator.max)
                        calculator.max = number;
                    if (number < calculator.min)
                        calculator.min = number;
                }
                Console.WriteLine(calculator.max);
                calculator.average = sum / numbers.Count;
            }
            else
            {
                calculator.max = calculator.min = calculator.average = double.NaN;
            }
            return calculator;
        }
    }
}
