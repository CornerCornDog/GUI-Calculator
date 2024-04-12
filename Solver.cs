using System;
using System.Collections.Generic;
namespace Calculator
{
	public class Solver : ISolve
	{
		string equation = "";
		public Solver()
		{
		}
		public void Accumulate(string s)
		{
			equation += s;
		}
		public void Clear()
		{
            equation = "";
		}
		public double Solve()
		{
			List<Double> numbers = new List<double>();
            List<String> operators = new List<string>();
            string currentNum = "";
			double solution = 0;
			for(int i = 0; i < equation.Length; i++)
			{
				if (equation[i] == '1' || equation[i] == '2' || equation[i] == '3' || equation[i] == '4' || equation[i] == '5' || equation[i] == '6' || equation[i] == '7' || equation[i] == '8' || equation[i] == '9' || equation[i] == '0' || equation[i] == '.')
				{
					currentNum += equation[i];
				}
                //this is to check for negative numbers
                else if (equation[i] == '-')
                {
                    if(i == 0)
                    {
                        currentNum += '-';
                    }
                    else if (equation[i-1] == '+' || equation[i-1] == '-' || equation[i-1] == '*' || equation[i-1] == '/' || equation[i-1] == '%')
                    {
                        currentNum += '-';
                    }
                    else
                    {
                        numbers.Add(Convert.ToDouble(currentNum));
                        currentNum = "";
                        operators.Add(equation[i].ToString());
                    }
                }
                else
				{
                    
					numbers.Add(Convert.ToDouble(currentNum));
					currentNum = "";
					operators.Add(equation[i].ToString());
				}
			}
            numbers.Add(Convert.ToDouble(currentNum));
            //multiplication
            for (int j = 0; j < operators.Count; j++)
            {
                while (operators[j].Equals("*"))
                {
                    numbers[j] = numbers[j] * numbers[j + 1];
                    numbers.RemoveAt(j + 1);
                    operators.RemoveAt(j);
                    //this is so that it can check for a value of operators[j] without removing the operators
                    //replacing them with something that will never be counted as an operator
                    //but still allows the program to check for an operator
                    operators.Add("Skibidi");
                }
            }
            //division
            for (int j = 0; j < operators.Count; j++)
            {
                while (operators[j].Equals("/"))
                {
                    numbers[j] = numbers[j] / numbers[j + 1];
                    numbers.RemoveAt(j + 1);
                    operators.RemoveAt(j);
                    //this is so that it can check for a value of operators[j] without removing the operators
                    //replacing them with something that will never be counted as an operator
                    //but still allows the program to check for an operator
                    operators.Add("Skibidi");
                }
            }
            //modulo
            for (int j = 0; j < operators.Count; j++)
            {
                while (operators[j].Equals("%"))
                {
                    numbers[j] = numbers[j] % numbers[j + 1];
                    numbers.RemoveAt(j + 1);
                    operators.RemoveAt(j);
                    //this is so that it can check for a value of operators[j] without removing the operators
                    //replacing them with something that will never be counted as an operator
                    //but still allows the program to check for an operator
                    operators.Add("Skibidi");
                }
            }
            //addition
            for (int j = 0; j < operators.Count; j++)
            {
                while (operators[j].Equals("+"))
                {
                    numbers[j] = numbers[j] + numbers[j + 1];
                    numbers.RemoveAt(j + 1);
                    operators.RemoveAt(j);
                    //this is so that it can check for a value of operators[j] without removing the operators
                    //replacing them with something that will never be counted as an operator
                    //but still allows the program to check for an operator
                    operators.Add("Skibidi");
                }
            }
            //subtraction
            for (int j = 0; j < operators.Count; j++)
            {
                while (operators[j].Equals("-"))
                {
                    numbers[j] = numbers[j] - numbers[j + 1];
                    numbers.RemoveAt(j + 1);
                    operators.RemoveAt(j);
                    //this is so that it can check for a value of operators[j] without removing the operators
                    //replacing them with something that will never be counted as an operator
                    //but still allows the program to check for an operator
                    operators.Add("Skibidi");
                }
            }
            solution = numbers[0];

            return solution;
		}
	}
}

