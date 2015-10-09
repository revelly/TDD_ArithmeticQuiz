using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArithmeticQuiz
{
    public class RandomGenerator
    {
        //public RandomGenerator(int startPoint, int endPoint)
        public RandomGenerator(int startPoint, int endPoint, int noOfRandomCounts)
        {
            if (startPoint > endPoint) {
                throw new Exception("Start point should be less than End Point!");
            }

            StartPoint = startPoint;
            EndPoint = endPoint;
            NoOfRandomCounts = noOfRandomCounts;
        }

        private int _startPoint;
        private int _endPoint;

        public int StartPoint { get { return _startPoint; } set { _startPoint = value; } }

        public int EndPoint
        {
            get { return _endPoint; }
            set {

                _endPoint = value;
                if (_startPoint > value)
                {
                    throw new Exception("Start point should be less than End Point!");
                }
                
            }
            
        }

        public int getRandomNumber()
        {
            Random random = new Random();

            return random.Next(StartPoint, EndPoint);
        }

        public int NoOfRandomCounts { get; set; }

        public List<int> getRandomNumbers()
        {
            List<int> randomNumnbers = new List<int>();

            while (randomNumnbers.Count < NoOfRandomCounts)
            {
                generateRandomNumber(randomNumnbers);
            }

            return randomNumnbers;
        }

        private void generateRandomNumber(List<int> randomNumnbers)
        {
            Random random = new Random();

            var newNumber = random.Next(StartPoint, EndPoint);

            if (!randomNumnbers.Any(n => n == newNumber))
                randomNumnbers.Add(newNumber);
        }

        
    }
}
