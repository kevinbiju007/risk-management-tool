namespace RiskManagementTool
{
    partial class Form_ToolPage
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label label_positionSize;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label_Title = new System.Windows.Forms.Label();
            this.panel_Inputs = new System.Windows.Forms.Panel();
            this.textBox_stopPrice = new System.Windows.Forms.TextBox();
            this.label_stopPrice = new System.Windows.Forms.Label();
            this.textBox_targetPrice = new System.Windows.Forms.TextBox();
            this.textBox_entryPrice = new System.Windows.Forms.TextBox();
            this.textBox_riskPerTrade = new System.Windows.Forms.TextBox();
            this.textBox_accountBalance = new System.Windows.Forms.TextBox();
            this.button_Calculate = new System.Windows.Forms.Button();
            this.label_targetPrice = new System.Windows.Forms.Label();
            this.label_entryPrice = new System.Windows.Forms.Label();
            this.label_AccountBalance = new System.Windows.Forms.Label();
            this.label_riskPercentage = new System.Windows.Forms.Label();
            this.label_Inputs = new System.Windows.Forms.Label();
            this.panel_Outputs = new System.Windows.Forms.Panel();
            this.textBox_PositionSizeCurrency = new System.Windows.Forms.TextBox();
            this.textBox_RRR = new System.Windows.Forms.TextBox();
            this.textBox_targetReward = new System.Windows.Forms.TextBox();
            this.textBox_positionSizeUnits = new System.Windows.Forms.TextBox();
            this.textBox_stopDistance = new System.Windows.Forms.TextBox();
            this.textBox_riskAmount = new System.Windows.Forms.TextBox();
            this.label_targetReward = new System.Windows.Forms.Label();
            this.label_riskReward = new System.Windows.Forms.Label();
            this.label_positionSize2 = new System.Windows.Forms.Label();
            this.label_Outputs = new System.Windows.Forms.Label();
            this.label_stopDistance = new System.Windows.Forms.Label();
            this.label_riskAmount = new System.Windows.Forms.Label();
            this.panel_Table = new System.Windows.Forms.Panel();
            this.dataGridView_riskScenarios = new System.Windows.Forms.DataGridView();
            this.Risk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RiskAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PositionSizeUnits = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PositionSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label_Table = new System.Windows.Forms.Label();
            this.button_exportCSV = new System.Windows.Forms.Button();
            this.button_Close = new System.Windows.Forms.Button();
            label_positionSize = new System.Windows.Forms.Label();
            this.panel_Inputs.SuspendLayout();
            this.panel_Outputs.SuspendLayout();
            this.panel_Table.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_riskScenarios)).BeginInit();
            this.SuspendLayout();
            // 
            // label_positionSize
            // 
            label_positionSize.AutoSize = true;
            label_positionSize.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label_positionSize.Location = new System.Drawing.Point(4, 153);
            label_positionSize.Name = "label_positionSize";
            label_positionSize.Size = new System.Drawing.Size(142, 20);
            label_positionSize.TabIndex = 8;
            label_positionSize.Text = "Position Size (Units):";
            label_positionSize.Click += new System.EventHandler(this.label_positionSize_Click);
            // 
            // label_Title
            // 
            this.label_Title.AutoSize = true;
            this.label_Title.Font = new System.Drawing.Font("Segoe UI", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Title.Location = new System.Drawing.Point(227, 9);
            this.label_Title.Name = "label_Title";
            this.label_Title.Size = new System.Drawing.Size(588, 50);
            this.label_Title.TabIndex = 0;
            this.label_Title.Text = "Position Size and Risk Calculator";
            // 
            // panel_Inputs
            // 
            this.panel_Inputs.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel_Inputs.Controls.Add(this.textBox_stopPrice);
            this.panel_Inputs.Controls.Add(this.label_stopPrice);
            this.panel_Inputs.Controls.Add(this.textBox_targetPrice);
            this.panel_Inputs.Controls.Add(this.textBox_entryPrice);
            this.panel_Inputs.Controls.Add(this.textBox_riskPerTrade);
            this.panel_Inputs.Controls.Add(this.textBox_accountBalance);
            this.panel_Inputs.Controls.Add(this.button_Calculate);
            this.panel_Inputs.Controls.Add(this.label_targetPrice);
            this.panel_Inputs.Controls.Add(this.label_entryPrice);
            this.panel_Inputs.Controls.Add(this.label_AccountBalance);
            this.panel_Inputs.Controls.Add(this.label_riskPercentage);
            this.panel_Inputs.Controls.Add(this.label_Inputs);
            this.panel_Inputs.Location = new System.Drawing.Point(12, 72);
            this.panel_Inputs.Name = "panel_Inputs";
            this.panel_Inputs.Size = new System.Drawing.Size(419, 329);
            this.panel_Inputs.TabIndex = 1;
            // 
            // textBox_stopPrice
            // 
            this.textBox_stopPrice.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_stopPrice.Location = new System.Drawing.Point(169, 197);
            this.textBox_stopPrice.Name = "textBox_stopPrice";
            this.textBox_stopPrice.Size = new System.Drawing.Size(175, 27);
            this.textBox_stopPrice.TabIndex = 14;
            // 
            // label_stopPrice
            // 
            this.label_stopPrice.AutoSize = true;
            this.label_stopPrice.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_stopPrice.Location = new System.Drawing.Point(6, 200);
            this.label_stopPrice.Name = "label_stopPrice";
            this.label_stopPrice.Size = new System.Drawing.Size(76, 20);
            this.label_stopPrice.TabIndex = 13;
            this.label_stopPrice.Text = "Stop Price";
            // 
            // textBox_targetPrice
            // 
            this.textBox_targetPrice.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_targetPrice.Location = new System.Drawing.Point(169, 240);
            this.textBox_targetPrice.Name = "textBox_targetPrice";
            this.textBox_targetPrice.Size = new System.Drawing.Size(175, 27);
            this.textBox_targetPrice.TabIndex = 12;
            // 
            // textBox_entryPrice
            // 
            this.textBox_entryPrice.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_entryPrice.Location = new System.Drawing.Point(169, 146);
            this.textBox_entryPrice.Name = "textBox_entryPrice";
            this.textBox_entryPrice.Size = new System.Drawing.Size(175, 27);
            this.textBox_entryPrice.TabIndex = 11;
            // 
            // textBox_riskPerTrade
            // 
            this.textBox_riskPerTrade.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_riskPerTrade.Location = new System.Drawing.Point(169, 98);
            this.textBox_riskPerTrade.Name = "textBox_riskPerTrade";
            this.textBox_riskPerTrade.Size = new System.Drawing.Size(175, 27);
            this.textBox_riskPerTrade.TabIndex = 10;
            // 
            // textBox_accountBalance
            // 
            this.textBox_accountBalance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_accountBalance.Location = new System.Drawing.Point(169, 53);
            this.textBox_accountBalance.Name = "textBox_accountBalance";
            this.textBox_accountBalance.Size = new System.Drawing.Size(175, 27);
            this.textBox_accountBalance.TabIndex = 9;
            // 
            // button_Calculate
            // 
            this.button_Calculate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_Calculate.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Calculate.Location = new System.Drawing.Point(159, 283);
            this.button_Calculate.Name = "button_Calculate";
            this.button_Calculate.Size = new System.Drawing.Size(209, 29);
            this.button_Calculate.TabIndex = 5;
            this.button_Calculate.Text = "Calculate";
            this.button_Calculate.UseVisualStyleBackColor = false;
            this.button_Calculate.Click += new System.EventHandler(this.button_Calculate_Click);
            // 
            // label_targetPrice
            // 
            this.label_targetPrice.AutoSize = true;
            this.label_targetPrice.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_targetPrice.Location = new System.Drawing.Point(4, 247);
            this.label_targetPrice.Name = "label_targetPrice";
            this.label_targetPrice.Size = new System.Drawing.Size(89, 20);
            this.label_targetPrice.TabIndex = 4;
            this.label_targetPrice.Text = "Target Price:";
            this.label_targetPrice.Click += new System.EventHandler(this.label3_Click);
            // 
            // label_entryPrice
            // 
            this.label_entryPrice.AutoSize = true;
            this.label_entryPrice.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_entryPrice.Location = new System.Drawing.Point(6, 153);
            this.label_entryPrice.Name = "label_entryPrice";
            this.label_entryPrice.Size = new System.Drawing.Size(81, 20);
            this.label_entryPrice.TabIndex = 3;
            this.label_entryPrice.Text = "Entry Price:";
            // 
            // label_AccountBalance
            // 
            this.label_AccountBalance.AutoSize = true;
            this.label_AccountBalance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_AccountBalance.Location = new System.Drawing.Point(4, 60);
            this.label_AccountBalance.Name = "label_AccountBalance";
            this.label_AccountBalance.Size = new System.Drawing.Size(122, 20);
            this.label_AccountBalance.TabIndex = 2;
            this.label_AccountBalance.Text = "Account Balance:";
            // 
            // label_riskPercentage
            // 
            this.label_riskPercentage.AutoSize = true;
            this.label_riskPercentage.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_riskPercentage.Location = new System.Drawing.Point(5, 105);
            this.label_riskPercentage.Name = "label_riskPercentage";
            this.label_riskPercentage.Size = new System.Drawing.Size(131, 20);
            this.label_riskPercentage.TabIndex = 1;
            this.label_riskPercentage.Text = "Risk per Trade (%):";
            // 
            // label_Inputs
            // 
            this.label_Inputs.AutoSize = true;
            this.label_Inputs.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Inputs.Location = new System.Drawing.Point(3, 11);
            this.label_Inputs.Name = "label_Inputs";
            this.label_Inputs.Size = new System.Drawing.Size(117, 25);
            this.label_Inputs.TabIndex = 0;
            this.label_Inputs.Text = "Trade Inputs";
            // 
            // panel_Outputs
            // 
            this.panel_Outputs.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel_Outputs.Controls.Add(this.textBox_PositionSizeCurrency);
            this.panel_Outputs.Controls.Add(this.textBox_RRR);
            this.panel_Outputs.Controls.Add(this.textBox_targetReward);
            this.panel_Outputs.Controls.Add(this.textBox_positionSizeUnits);
            this.panel_Outputs.Controls.Add(this.textBox_stopDistance);
            this.panel_Outputs.Controls.Add(this.textBox_riskAmount);
            this.panel_Outputs.Controls.Add(this.label_targetReward);
            this.panel_Outputs.Controls.Add(this.label_riskReward);
            this.panel_Outputs.Controls.Add(this.label_positionSize2);
            this.panel_Outputs.Controls.Add(this.label_Outputs);
            this.panel_Outputs.Controls.Add(label_positionSize);
            this.panel_Outputs.Controls.Add(this.label_stopDistance);
            this.panel_Outputs.Controls.Add(this.label_riskAmount);
            this.panel_Outputs.Location = new System.Drawing.Point(538, 72);
            this.panel_Outputs.Name = "panel_Outputs";
            this.panel_Outputs.Size = new System.Drawing.Size(445, 329);
            this.panel_Outputs.TabIndex = 2;
            this.panel_Outputs.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_Outputs_Paint);
            // 
            // textBox_PositionSizeCurrency
            // 
            this.textBox_PositionSizeCurrency.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_PositionSizeCurrency.Location = new System.Drawing.Point(177, 200);
            this.textBox_PositionSizeCurrency.Name = "textBox_PositionSizeCurrency";
            this.textBox_PositionSizeCurrency.ReadOnly = true;
            this.textBox_PositionSizeCurrency.Size = new System.Drawing.Size(189, 27);
            this.textBox_PositionSizeCurrency.TabIndex = 16;
            // 
            // textBox_RRR
            // 
            this.textBox_RRR.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_RRR.Location = new System.Drawing.Point(177, 276);
            this.textBox_RRR.Name = "textBox_RRR";
            this.textBox_RRR.ReadOnly = true;
            this.textBox_RRR.Size = new System.Drawing.Size(189, 27);
            this.textBox_RRR.TabIndex = 15;
            this.textBox_RRR.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
            // 
            // textBox_targetReward
            // 
            this.textBox_targetReward.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_targetReward.Location = new System.Drawing.Point(177, 233);
            this.textBox_targetReward.Name = "textBox_targetReward";
            this.textBox_targetReward.ReadOnly = true;
            this.textBox_targetReward.Size = new System.Drawing.Size(189, 27);
            this.textBox_targetReward.TabIndex = 14;
            // 
            // textBox_positionSizeUnits
            // 
            this.textBox_positionSizeUnits.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_positionSizeUnits.Location = new System.Drawing.Point(177, 146);
            this.textBox_positionSizeUnits.Name = "textBox_positionSizeUnits";
            this.textBox_positionSizeUnits.ReadOnly = true;
            this.textBox_positionSizeUnits.Size = new System.Drawing.Size(189, 27);
            this.textBox_positionSizeUnits.TabIndex = 13;
            // 
            // textBox_stopDistance
            // 
            this.textBox_stopDistance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_stopDistance.Location = new System.Drawing.Point(177, 98);
            this.textBox_stopDistance.Name = "textBox_stopDistance";
            this.textBox_stopDistance.ReadOnly = true;
            this.textBox_stopDistance.Size = new System.Drawing.Size(189, 27);
            this.textBox_stopDistance.TabIndex = 12;
            // 
            // textBox_riskAmount
            // 
            this.textBox_riskAmount.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_riskAmount.Location = new System.Drawing.Point(177, 53);
            this.textBox_riskAmount.Name = "textBox_riskAmount";
            this.textBox_riskAmount.ReadOnly = true;
            this.textBox_riskAmount.Size = new System.Drawing.Size(189, 27);
            this.textBox_riskAmount.TabIndex = 11;
            // 
            // label_targetReward
            // 
            this.label_targetReward.AutoSize = true;
            this.label_targetReward.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_targetReward.Location = new System.Drawing.Point(3, 240);
            this.label_targetReward.Name = "label_targetReward";
            this.label_targetReward.Size = new System.Drawing.Size(104, 20);
            this.label_targetReward.TabIndex = 10;
            this.label_targetReward.Text = "Target Reward";
            // 
            // label_riskReward
            // 
            this.label_riskReward.AutoSize = true;
            this.label_riskReward.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_riskReward.Location = new System.Drawing.Point(4, 283);
            this.label_riskReward.Name = "label_riskReward";
            this.label_riskReward.Size = new System.Drawing.Size(128, 20);
            this.label_riskReward.TabIndex = 9;
            this.label_riskReward.Text = "Risk Reward Ratio";
            // 
            // label_positionSize2
            // 
            this.label_positionSize2.AutoSize = true;
            this.label_positionSize2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_positionSize2.Location = new System.Drawing.Point(4, 200);
            this.label_positionSize2.Name = "label_positionSize2";
            this.label_positionSize2.Size = new System.Drawing.Size(117, 20);
            this.label_positionSize2.TabIndex = 9;
            this.label_positionSize2.Text = "Position Size (£):";
            // 
            // label_Outputs
            // 
            this.label_Outputs.AutoSize = true;
            this.label_Outputs.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Outputs.Location = new System.Drawing.Point(3, 11);
            this.label_Outputs.Name = "label_Outputs";
            this.label_Outputs.Size = new System.Drawing.Size(132, 25);
            this.label_Outputs.TabIndex = 1;
            this.label_Outputs.Text = "Trade Outputs";
            // 
            // label_stopDistance
            // 
            this.label_stopDistance.AutoSize = true;
            this.label_stopDistance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_stopDistance.Location = new System.Drawing.Point(3, 105);
            this.label_stopDistance.Name = "label_stopDistance";
            this.label_stopDistance.Size = new System.Drawing.Size(104, 20);
            this.label_stopDistance.TabIndex = 7;
            this.label_stopDistance.Text = "Stop Distance:";
            // 
            // label_riskAmount
            // 
            this.label_riskAmount.AutoSize = true;
            this.label_riskAmount.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_riskAmount.Location = new System.Drawing.Point(4, 60);
            this.label_riskAmount.Name = "label_riskAmount";
            this.label_riskAmount.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label_riskAmount.Size = new System.Drawing.Size(95, 20);
            this.label_riskAmount.TabIndex = 6;
            this.label_riskAmount.Text = "Risk Amount:";
            // 
            // panel_Table
            // 
            this.panel_Table.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel_Table.Controls.Add(this.dataGridView_riskScenarios);
            this.panel_Table.Controls.Add(this.label_Table);
            this.panel_Table.Location = new System.Drawing.Point(56, 423);
            this.panel_Table.Name = "panel_Table";
            this.panel_Table.Size = new System.Drawing.Size(825, 201);
            this.panel_Table.TabIndex = 3;
            // 
            // dataGridView_riskScenarios
            // 
            this.dataGridView_riskScenarios.AllowUserToAddRows = false;
            this.dataGridView_riskScenarios.AllowUserToDeleteRows = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView_riskScenarios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridView_riskScenarios.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView_riskScenarios.BackgroundColor = System.Drawing.SystemColors.WindowFrame;
            this.dataGridView_riskScenarios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_riskScenarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridView_riskScenarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_riskScenarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Risk,
            this.RiskAmount,
            this.PositionSizeUnits,
            this.PositionSize});
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_riskScenarios.DefaultCellStyle = dataGridViewCellStyle16;
            this.dataGridView_riskScenarios.Location = new System.Drawing.Point(115, 37);
            this.dataGridView_riskScenarios.Name = "dataGridView_riskScenarios";
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_riskScenarios.RowHeadersDefaultCellStyle = dataGridViewCellStyle17;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.DarkGray;
            this.dataGridView_riskScenarios.RowsDefaultCellStyle = dataGridViewCellStyle18;
            this.dataGridView_riskScenarios.Size = new System.Drawing.Size(621, 150);
            this.dataGridView_riskScenarios.TabIndex = 5;
            // 
            // Risk
            // 
            dataGridViewCellStyle12.Format = "0.00";
            this.Risk.DefaultCellStyle = dataGridViewCellStyle12;
            this.Risk.HeaderText = "Risk (%)";
            this.Risk.Name = "Risk";
            this.Risk.ReadOnly = true;
            // 
            // RiskAmount
            // 
            dataGridViewCellStyle13.Format = "0.00";
            this.RiskAmount.DefaultCellStyle = dataGridViewCellStyle13;
            this.RiskAmount.HeaderText = "Risk Amount";
            this.RiskAmount.Name = "RiskAmount";
            this.RiskAmount.ReadOnly = true;
            // 
            // PositionSizeUnits
            // 
            dataGridViewCellStyle14.Format = "0";
            this.PositionSizeUnits.DefaultCellStyle = dataGridViewCellStyle14;
            this.PositionSizeUnits.HeaderText = "Position Size Units";
            this.PositionSizeUnits.Name = "PositionSizeUnits";
            this.PositionSizeUnits.ReadOnly = true;
            // 
            // PositionSize
            // 
            dataGridViewCellStyle15.Format = "0.00";
            this.PositionSize.DefaultCellStyle = dataGridViewCellStyle15;
            this.PositionSize.HeaderText = "Position Size (£)";
            this.PositionSize.Name = "PositionSize";
            this.PositionSize.ReadOnly = true;
            // 
            // label_Table
            // 
            this.label_Table.AutoSize = true;
            this.label_Table.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Table.Location = new System.Drawing.Point(362, 9);
            this.label_Table.Name = "label_Table";
            this.label_Table.Size = new System.Drawing.Size(133, 25);
            this.label_Table.TabIndex = 4;
            this.label_Table.Text = "Risk Scenarios";
            // 
            // button_exportCSV
            // 
            this.button_exportCSV.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_exportCSV.Location = new System.Drawing.Point(44, 630);
            this.button_exportCSV.Name = "button_exportCSV";
            this.button_exportCSV.Size = new System.Drawing.Size(118, 30);
            this.button_exportCSV.TabIndex = 4;
            this.button_exportCSV.Text = "Export CSV";
            this.button_exportCSV.UseVisualStyleBackColor = true;
            this.button_exportCSV.Click += new System.EventHandler(this.button_exportCSV_Click);
            // 
            // button_Close
            // 
            this.button_Close.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button_Close.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Close.Location = new System.Drawing.Point(822, 630);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(82, 30);
            this.button_Close.TabIndex = 5;
            this.button_Close.Text = "Close";
            this.button_Close.UseVisualStyleBackColor = false;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // Form_ToolPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 672);
            this.Controls.Add(this.button_Close);
            this.Controls.Add(this.button_exportCSV);
            this.Controls.Add(this.panel_Inputs);
            this.Controls.Add(this.panel_Outputs);
            this.Controls.Add(this.panel_Table);
            this.Controls.Add(this.label_Title);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form_ToolPage";
            this.Text = "Risk Management Tool";
            this.Load += new System.EventHandler(this.Form_ToolPage_Load);
            this.panel_Inputs.ResumeLayout(false);
            this.panel_Inputs.PerformLayout();
            this.panel_Outputs.ResumeLayout(false);
            this.panel_Outputs.PerformLayout();
            this.panel_Table.ResumeLayout(false);
            this.panel_Table.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_riskScenarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Title;
        private System.Windows.Forms.Panel panel_Inputs;
        private System.Windows.Forms.Panel panel_Outputs;
        private System.Windows.Forms.Panel panel_Table;
        private System.Windows.Forms.Label label_Inputs;
        private System.Windows.Forms.Label label_Outputs;
        private System.Windows.Forms.Label label_Table;
        private System.Windows.Forms.Label label_entryPrice;
        private System.Windows.Forms.Label label_AccountBalance;
        private System.Windows.Forms.Label label_riskPercentage;
        private System.Windows.Forms.Label label_targetPrice;
        private System.Windows.Forms.Button button_Calculate;
        private System.Windows.Forms.Label label_riskReward;
        private System.Windows.Forms.Label label_stopDistance;
        private System.Windows.Forms.Label label_riskAmount;
        private System.Windows.Forms.TextBox textBox_accountBalance;
        private System.Windows.Forms.Label label_positionSize2;
        private System.Windows.Forms.Label label_targetReward;
        private System.Windows.Forms.TextBox textBox_targetPrice;
        private System.Windows.Forms.TextBox textBox_riskPerTrade;
        private System.Windows.Forms.TextBox textBox_PositionSizeCurrency;
        private System.Windows.Forms.TextBox textBox_RRR;
        private System.Windows.Forms.TextBox textBox_targetReward;
        private System.Windows.Forms.TextBox textBox_positionSizeUnits;
        private System.Windows.Forms.TextBox textBox_stopDistance;
        private System.Windows.Forms.TextBox textBox_riskAmount;
        private System.Windows.Forms.Button button_exportCSV;
        private System.Windows.Forms.Button button_Close;
        private System.Windows.Forms.Label label_stopPrice;
        private System.Windows.Forms.TextBox textBox_stopPrice;
        private System.Windows.Forms.TextBox textBox_entryPrice;
        private System.Windows.Forms.DataGridView dataGridView_riskScenarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn Risk;
        private System.Windows.Forms.DataGridViewTextBoxColumn RiskAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn PositionSizeUnits;
        private System.Windows.Forms.DataGridViewTextBoxColumn PositionSize;
    }
}

