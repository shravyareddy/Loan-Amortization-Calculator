using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assignment_3
{
    class ChartControl
    {
       
        public int payNum { get; set; }
        public double pAmount { get; set; }
        public double interestAmt { get; set; }
        public double remBal { get; set; }
        
        
        //calcuates remaining balance and monthly payments for each month and displays it in a table
        public List<ChartControl> CalculateAmortization(double monthlyPymt, double pAmount, int loanTerm, double interestRate)
        {

            List<ChartControl> payment = new List<ChartControl>();

            double deductBal;
            double intPaid;
            double newBal;
            int cnt = 1;
            int NumofPayments = loanTerm;
            double interest = (interestRate / 100) / 12;
            newBal = pAmount;
            //calculate remaining balance for every term
            while (cnt <= NumofPayments)
            {
                intPaid = newBal * interest;
                deductBal = monthlyPymt - intPaid;
                newBal = newBal - deductBal;
                if (cnt == NumofPayments)
                {
                    payment.Add(new ChartControl() { payNum = cnt, pAmount = Math.Round(deductBal + newBal, 2), interestAmt = Math.Round(intPaid, 2), remBal = 0 });
                               
                }
                else
                payment.Add(new ChartControl() { payNum = cnt, pAmount = Math.Round(deductBal,2), interestAmt = Math.Round(intPaid, 2), remBal = Math.Round(newBal, 2) });
                cnt=cnt+1;
                
            }
            return payment;

        }    
    }
}
