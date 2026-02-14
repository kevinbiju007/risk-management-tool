using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RiskManagementTool
{
    public partial class Form_ToolPage : Form
    {
        public Form_ToolPage()
        {
            InitializeComponent();
           
        }

        private void panel_Outputs_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label_positionSize_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_Calculate_Click(object sender, EventArgs e)
        {
            decimal accountBalance;
            decimal riskPerTrade;
            decimal entryPrice;
            decimal stopPrice;
            decimal targetPrice;
            decimal riskAmount;
            decimal stopDistance;
            decimal positionSizeUnits;
            decimal positionSizeCurrency;
            decimal targetReward;
            decimal riskReward;

            // data validation for the inputs
            if (textBox_accountBalance.Text.Length == 0)
            {
                MessageBox.Show("Please enter an account balance value!");
                textBox_accountBalance.Focus();
                return;
            }

            if (textBox_riskPerTrade.Text.Length == 0)
            {
                MessageBox.Show("Please enter a risk per trade value!");
                textBox_riskPerTrade.Focus();
                return;
            }

            if (textBox_entryPrice.Text.Length == 0)
            {
                MessageBox.Show("Please enter an stop price value!");
                textBox_entryPrice.Focus();
                return;
            }

            if (textBox_accountBalance.Text.Length == 0)
            {
                MessageBox.Show("Please enter an target price value!");
                textBox_accountBalance.Focus();
                return;
            }

            if (!decimal.TryParse(textBox_accountBalance.Text.Trim(), out accountBalance))
            {
                MessageBox.Show("Account balance should be a numerical value.");
                return;

            }

            if (!decimal.TryParse(textBox_riskPerTrade.Text.Trim(), out riskPerTrade))
            {
                MessageBox.Show("Risk per trade should be a numerical value.");
                return;

            }

            if (!decimal.TryParse(textBox_entryPrice.Text.Trim(), out entryPrice))
            {
                MessageBox.Show("Entry price should be a numerical value.");
                return;

            }

            if (!decimal.TryParse(textBox_stopPrice.Text.Trim(), out stopPrice))
            {
                MessageBox.Show("Stop price should be a numerical value.");
                return;

            }
            if (!decimal.TryParse(textBox_targetPrice.Text.Trim(), out targetPrice))
            {
                MessageBox.Show("Target price should be a numerical value.");
                return;

            }

            // displays the outputs in the textbox in the necessary formats

            riskAmount = Class_Calculations.RiskAmount(accountBalance, riskPerTrade);
            textBox_riskAmount.Text = riskAmount.ToString("0.##");

            stopDistance = Class_Calculations.StopDistance(entryPrice, stopPrice);
            textBox_stopDistance.Text = stopDistance.ToString("0.##");

            positionSizeUnits = Class_Calculations.PositionSizeUnits(accountBalance, riskPerTrade, entryPrice, stopPrice);
            textBox_positionSizeUnits.Text = positionSizeUnits.ToString("0");

            positionSizeCurrency = Class_Calculations.PositionSizeCurrency(accountBalance, riskPerTrade, entryPrice, stopPrice);
            textBox_PositionSizeCurrency.Text = positionSizeCurrency.ToString("0.##");

            targetReward = Class_Calculations.TargetReward(accountBalance, riskPerTrade, entryPrice, targetPrice, stopPrice);
            textBox_targetReward.Text = targetReward.ToString("0.##");

            riskReward = Class_Calculations.RiskReward(accountBalance, riskPerTrade, entryPrice, stopPrice, targetPrice);
            textBox_RRR.Text = "1:" + riskReward.ToString("0.##");

            // calculations for the risk scenario table

            var r05 = riskPerTrade / 2m;
            var r10 = riskPerTrade * 1m;
            var r15 = riskPerTrade * 1.5m;
            var r20 = riskPerTrade * 2m;

            var r05_riskAmount = accountBalance * (r05 / 100m);
            var r10_riskAmount = accountBalance * (r10 / 100m);
            var r15_riskAmount = accountBalance * (r15 / 100m);
            var r20_riskAmount = accountBalance * (r20 / 100m);

            var r05_units = r05_riskAmount / stopDistance;
            var r10_units = r10_riskAmount / stopDistance;
            var r15_units = r15_riskAmount / stopDistance;
            var r20_units = r20_riskAmount / stopDistance;

            var r05_value = r05_units * entryPrice;
            var r10_value = r10_units * entryPrice;
            var r15_value = r15_units * entryPrice; 
            var r20_value = r20_units * entryPrice;

            // fills the table with data
            var scenarios = new List<Class_ExportFile.RiskScenarioTable>        
        {

            new Class_ExportFile.RiskScenarioTable {riskPercent = r05, riskAmount = r05_riskAmount, units = r05_units, positionValue = r05_value},
            new Class_ExportFile.RiskScenarioTable {riskPercent = r10, riskAmount = r10_riskAmount, units = r10_units, positionValue = r10_value},
            new Class_ExportFile.RiskScenarioTable {riskPercent = r15, riskAmount = r15_riskAmount, units = r15_units, positionValue = r15_value},
            new Class_ExportFile.RiskScenarioTable {riskPercent = r20, riskAmount = r20_riskAmount, units = r20_units, positionValue = r20_value},
        };



            dataGridView_riskScenarios.DataSource = null;
            dataGridView_riskScenarios.DataSource = scenarios;

        }

        private void button_Close_Click(object sender, EventArgs e)
            // exit the application button
        {
            Application.Exit();

        }

        private void button_exportCSV_Click(object sender, EventArgs e)
            // export to csv button click that calls the function
        {
            new Class_ExportFile().ExportToCSV(dataGridView_riskScenarios);

        }

        private void Form_ToolPage_Load(object sender, EventArgs e)
            // ensures new columns are not generated and the rows are bound correctly
        {
            dataGridView_riskScenarios.AutoGenerateColumns = false;

            dataGridView_riskScenarios.Columns["Risk"].DataPropertyName = "riskPercent";
            dataGridView_riskScenarios.Columns["RiskAmount"].DataPropertyName = "riskAmount";
            dataGridView_riskScenarios.Columns["PositionSizeUnits"].DataPropertyName = "units";
            dataGridView_riskScenarios.Columns["PositionSize"].DataPropertyName = "positionValue";
           
        }
    }

}

