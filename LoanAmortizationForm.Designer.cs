namespace OOP_Assignment_3
{
    partial class LoanAmortizationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        // Initializing tools for representing input and output details. 
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lbl_pAmount = new System.Windows.Forms.Label();
            this.txt_pAmount = new System.Windows.Forms.TextBox();
            this.lbl_term = new System.Windows.Forms.Label();
            this.txt_Term = new System.Windows.Forms.TextBox();
            this.lbl_apr = new System.Windows.Forms.Label();
            this.txt_apr = new System.Windows.Forms.TextBox();
            this.btn_Chart = new System.Windows.Forms.Button();
            this.lbl_monthlypayments = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_monthly_payments = new System.Windows.Forms.TextBox();
            this.lbl_total_payments = new System.Windows.Forms.Label();
            this.txt_total_payments = new System.Windows.Forms.TextBox();
            this.btn_Graph = new System.Windows.Forms.Button();
            this.paymentGrid = new System.Windows.Forms.DataGridView();
            this.paymentChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.paymentGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentChart)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_pAmount
            // 
            this.lbl_pAmount.AutoSize = true;
            this.lbl_pAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pAmount.Location = new System.Drawing.Point(28, 25);
            this.lbl_pAmount.Name = "lbl_pAmount";
            this.lbl_pAmount.Size = new System.Drawing.Size(142, 16);
            this.lbl_pAmount.TabIndex = 0;
            this.lbl_pAmount.Text = "Enter Principal Amount";
            this.lbl_pAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_pAmount.Click += new System.EventHandler(this.lbl_pAmount_Click);
            // 
            // txt_pAmount
            // 
            this.txt_pAmount.Location = new System.Drawing.Point(176, 21);
            this.txt_pAmount.Name = "txt_pAmount";
            this.txt_pAmount.Size = new System.Drawing.Size(100, 20);
            this.txt_pAmount.TabIndex = 1;
            this.txt_pAmount.TextChanged += new System.EventHandler(this.text_Changed);
            this.txt_pAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_keyPress);
            // 
            // lbl_term
            // 
            this.lbl_term.AutoSize = true;
            this.lbl_term.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_term.Location = new System.Drawing.Point(31, 60);
            this.lbl_term.Name = "lbl_term";
            this.lbl_term.Size = new System.Drawing.Size(141, 16);
            this.lbl_term.TabIndex = 2;
            this.lbl_term.Text = "Enter Term (in Months)";
            this.lbl_term.Click += new System.EventHandler(this.lbl_term_Click);
            // 
            // txt_Term
            // 
            this.txt_Term.Location = new System.Drawing.Point(178, 60);
            this.txt_Term.Name = "txt_Term";
            this.txt_Term.Size = new System.Drawing.Size(100, 20);
            this.txt_Term.TabIndex = 3;
            this.txt_Term.TextChanged += new System.EventHandler(this.text_Changed);
            this.txt_Term.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_keyPress);
            // 
            // lbl_apr
            // 
            this.lbl_apr.AutoSize = true;
            this.lbl_apr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_apr.Location = new System.Drawing.Point(34, 102);
            this.lbl_apr.Name = "lbl_apr";
            this.lbl_apr.Size = new System.Drawing.Size(97, 16);
            this.lbl_apr.TabIndex = 4;
            this.lbl_apr.Text = "Rate of Interest";
            this.lbl_apr.Click += new System.EventHandler(this.lbl_apr_Click);
            // 
            // txt_apr
            // 
            this.txt_apr.Location = new System.Drawing.Point(176, 102);
            this.txt_apr.Name = "txt_apr";
            this.txt_apr.Size = new System.Drawing.Size(100, 20);
            this.txt_apr.TabIndex = 5;
            this.txt_apr.TextChanged += new System.EventHandler(this.text_Changed);
            this.txt_apr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.text_keyPress);
            // 
            // btn_Chart
            // 
            this.btn_Chart.Enabled = false;
            this.btn_Chart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Chart.Location = new System.Drawing.Point(55, 161);
            this.btn_Chart.Name = "btn_Chart";
            this.btn_Chart.Size = new System.Drawing.Size(111, 23);
            this.btn_Chart.TabIndex = 6;
            this.btn_Chart.Text = "Display Chart";
            this.btn_Chart.UseVisualStyleBackColor = true;
            this.btn_Chart.Click += new System.EventHandler(this.btn_Chart_Click);
            // 
            // lbl_monthlypayments
            // 
            this.lbl_monthlypayments.AutoSize = true;
            this.lbl_monthlypayments.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_monthlypayments.Location = new System.Drawing.Point(34, 210);
            this.lbl_monthlypayments.Name = "lbl_monthlypayments";
            this.lbl_monthlypayments.Size = new System.Drawing.Size(117, 16);
            this.lbl_monthlypayments.TabIndex = 7;
            this.lbl_monthlypayments.Text = "Monthly Payments";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(166, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 8;
            // 
            // txt_monthly_payments
            // 
            this.txt_monthly_payments.Location = new System.Drawing.Point(172, 210);
            this.txt_monthly_payments.Name = "txt_monthly_payments";
            this.txt_monthly_payments.ReadOnly = true;
            this.txt_monthly_payments.Size = new System.Drawing.Size(100, 20);
            this.txt_monthly_payments.TabIndex = 9;
            this.txt_monthly_payments.TextChanged += new System.EventHandler(this.txt_monthly_payments_TextChanged);
            // 
            // lbl_total_payments
            // 
            this.lbl_total_payments.AutoSize = true;
            this.lbl_total_payments.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total_payments.Location = new System.Drawing.Point(36, 268);
            this.lbl_total_payments.Name = "lbl_total_payments";
            this.lbl_total_payments.Size = new System.Drawing.Size(95, 16);
            this.lbl_total_payments.TabIndex = 10;
            this.lbl_total_payments.Text = "Total Payment";
            // 
            // txt_total_payments
            // 
            this.txt_total_payments.Location = new System.Drawing.Point(169, 268);
            this.txt_total_payments.Name = "txt_total_payments";
            this.txt_total_payments.ReadOnly = true;
            this.txt_total_payments.Size = new System.Drawing.Size(100, 20);
            this.txt_total_payments.TabIndex = 12;
            // 
            // btn_Graph
            // 
            this.btn_Graph.Enabled = false;
            this.btn_Graph.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Graph.Location = new System.Drawing.Point(192, 161);
            this.btn_Graph.Name = "btn_Graph";
            this.btn_Graph.Size = new System.Drawing.Size(122, 23);
            this.btn_Graph.TabIndex = 13;
            this.btn_Graph.Text = " Display Graph";
            this.btn_Graph.UseVisualStyleBackColor = true;
            this.btn_Graph.Click += new System.EventHandler(this.btn_Graph_Click);
            // 
            // paymentGrid
            // 
            this.paymentGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.paymentGrid.Location = new System.Drawing.Point(55, 352);
            this.paymentGrid.Name = "paymentGrid";
            this.paymentGrid.Size = new System.Drawing.Size(428, 184);
            this.paymentGrid.TabIndex = 14;
            this.paymentGrid.Visible = false;
            // 
            // paymentChart
            // 
            this.paymentChart.BackColor = System.Drawing.Color.Azure;
            chartArea1.Name = "ChartArea1";
            this.paymentChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.paymentChart.Legends.Add(legend1);
            this.paymentChart.Location = new System.Drawing.Point(543, 44);
            this.paymentChart.Name = "paymentChart";
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.LightCoral;
            series1.Legend = "Legend1";
            series1.Name = "balance";
            this.paymentChart.Series.Add(series1);
            this.paymentChart.Size = new System.Drawing.Size(300, 300);
            this.paymentChart.TabIndex = 15;
            this.paymentChart.Text = "chart1";
            this.paymentChart.Visible = false;
            // 
            // LoanAmortizationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 621);
            this.Controls.Add(this.paymentChart);
            this.Controls.Add(this.paymentGrid);
            this.Controls.Add(this.btn_Graph);
            this.Controls.Add(this.txt_total_payments);
            this.Controls.Add(this.lbl_total_payments);
            this.Controls.Add(this.txt_monthly_payments);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_monthlypayments);
            this.Controls.Add(this.btn_Chart);
            this.Controls.Add(this.txt_apr);
            this.Controls.Add(this.lbl_apr);
            this.Controls.Add(this.txt_Term);
            this.Controls.Add(this.lbl_term);
            this.Controls.Add(this.txt_pAmount);
            this.Controls.Add(this.lbl_pAmount);
            this.Name = "LoanAmortizationForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.LoanAmortizationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.paymentGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_pAmount;
        private System.Windows.Forms.TextBox txt_pAmount;
        private System.Windows.Forms.Label lbl_term;
        private System.Windows.Forms.TextBox txt_Term;
        private System.Windows.Forms.Label lbl_apr;
        private System.Windows.Forms.TextBox txt_apr;
        private System.Windows.Forms.Button btn_Chart;
        private System.Windows.Forms.Label lbl_monthlypayments;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_monthly_payments;
        private System.Windows.Forms.Label lbl_total_payments;
        private System.Windows.Forms.TextBox txt_total_payments;
        private System.Windows.Forms.Button btn_Graph;
        private System.Windows.Forms.DataGridView paymentGrid;
        private System.Windows.Forms.DataVisualization.Charting.Chart paymentChart;
    }
}

