using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assignment_3
{
    class GraphControl
    {
        public List<int> payNum { get; set; }
        public List<double> remBal { get; set; }

        // gets data needed to populate the graph
        public void GetGraphData(double monthlyPymt, double pAmount, int loanTerm, double interestRate)
        {
            payNum = new List<int>();
            remBal = new List<double>();
            ChartControl cControl = new ChartControl();
            List<ChartControl> payData = cControl.CalculateAmortization(monthlyPymt, pAmount, loanTerm, interestRate);
            //gets remaining balance and payment number from grid data
            foreach (var x in payData)
            {
                remBal.Add(x.remBal);
                payNum.Add(x.payNum);
               
            }
        }
    }
}
