using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Assignment_3
{
    public partial class LoanAmortizationForm : Form
    {
        public LoanAmortizationForm()
        {
            InitializeComponent();
        }
        //Properties required for Amortization
        public Double principal { get; set; }
        public int term{get;set;}
        public Double apr{get;set;}
        public Double monthlyPayments { get; set; }
        public double totalPayment { get; set; }
        
        //Populate Payments Method: calls calculator.cs class to calculate monthly payments and total payment and fills the values on entry screen
        public void PopulatePayments()
        {
            //Retrieve text box field values on the form
            principal = Double.Parse(txt_pAmount.Text.ToString());
            term = Int32.Parse(txt_Term.Text.ToString());
            apr = Double.Parse(txt_apr.Text.ToString());
            Calculator obj_payments = new Calculator();
            //calculate total payment
            totalPayment = obj_payments.CalculateTotalPayment(principal, term, apr);
            //calculate monthly payments
            monthlyPayments = obj_payments.CalculateMonthlyPayment(principal, term, apr);
            // displaying output by rounding the decimal to 2 places.
            txt_monthly_payments.Text = Math.Round(monthlyPayments, 2).ToString();
            txt_total_payments.Text = Math.Round(totalPayment,2).ToString();
            
        }

        //populates griddata
        private void btn_Chart_Click(object sender, EventArgs e)
        {
            paymentChart.Visible = false;

            PopulatePayments();
            ChartControl chartCalculator = new ChartControl();
            paymentGrid.DataSource = chartCalculator.CalculateAmortization(monthlyPayments, principal, term, apr);
            paymentGrid.Visible = true;
                
        }
        //populates graph 
        private void btn_Graph_Click(object sender, EventArgs e)
        {
            paymentGrid.Visible = false;
            PopulatePayments();
            GraphControl gc = new GraphControl();
            gc.GetGraphData(monthlyPayments, principal, term, apr);
            //providing x and y-axis values for populating barchart
            paymentChart.Series[0].Points.DataBindXY(gc.payNum,gc.remBal);
            paymentChart.Visible = true;
        }
        //hides buttons until the valid input is received from Users and the invalid data cannot be entered.
        private void text_Changed(object sender, EventArgs e)
        {
            
           this.btn_Graph.Enabled= this.btn_Chart.Enabled = !string.IsNullOrWhiteSpace(this.txt_pAmount.Text) &&
                            !string.IsNullOrWhiteSpace(this.txt_Term.Text) &&
                            !string.IsNullOrWhiteSpace(this.txt_apr.Text);
        }

        
        private void text_keyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
        && !char.IsDigit(e.KeyChar)
        && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if (e.KeyChar == '.'
                && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void txt_monthly_payments_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_pAmount_Click(object sender, EventArgs e)
        {

        }

        private void LoanAmortizationForm_Load(object sender, EventArgs e)
        {

        }

        private void lbl_apr_Click(object sender, EventArgs e)
        {

        }

        private void lbl_term_Click(object sender, EventArgs e)
        {

        }

       
    }
}
