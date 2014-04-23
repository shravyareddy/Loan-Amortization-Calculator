using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assignment_3
{
    class Calculator
    {

      //function that calculates total payment
        public double CalculateTotalPayment(double pAmount, int loanTerm, double interestRate)
        {
            
            double totPayment;
            double monthlyPayment = CalculateMonthlyPayment(pAmount, loanTerm, interestRate);
            totPayment = loanTerm * monthlyPayment;
            return totPayment;
        }

        //function that calculates monthly payments     
        public double CalculateMonthlyPayment(double pAmount, int noOfPayment, double interestRate)
        {
            double monthlyPayment;
            double intRate = (interestRate/100)/12;
            monthlyPayment = (pAmount * (Math.Pow((1 + intRate), noOfPayment)) * intRate / (Math.Pow((1 + intRate), noOfPayment) - 1));
            return Convert.ToDouble(monthlyPayment);
        }
       
    }
}
