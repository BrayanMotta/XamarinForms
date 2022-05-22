using System;
using System.Collections.Generic;
using System.Text;

namespace IntroXamarin.App.Views.Forms
{
    public static class SimpleCalculator
    {
        public static double Calculate(double valor1, double valor2, string mathOperator)
        {
            double result = 0;

            switch (mathOperator)
            {
                case "+":
                    result = valor1 + valor2;
                    break;

                case "-":
                    result = valor1 - valor2;
                    break;

                case "*":
                    result = valor1 * valor2;
                    break;

                case "/":
                    result = valor1 / valor2;
                    break;
            }

            return result;
        }
    }
}
