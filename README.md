# Risk Management Tool (C# WinForms)

A WinForms desktop tool I built to calculate position size and risk/reward for a trade, plus generate a quick set of risk scenarios you can export to CSV.

## How the app flows (what you actually do)
1. Enter the trade inputs (account balance, risk %, entry, stop, target)
2. Click **Calculate**
3. Review the outputs (risk amount, stop distance, units, position value, target reward, risk/reward)
4. Check the **Risk Scenarios** table for different risk % levels
5. Click **Export CSV** to save the scenario table

## App preview (in order)

**UI**
![UI](screenshots/UI.png)

**CSV export**
![CSV export](screenshots/csv_output.png)

## What’s included
- Position sizing based on account balance, risk % and stop distance
- Risk/reward calculation using entry, stop and target
- Scenario table for multiple risk percentages
- CSV export of scenario results

## Tech used
- C# WinForms
- DataGridView for the scenario table
- CSV export (writes headers + rows)

## Running it locally
1. Open `RiskManagementTool.sln` in Visual Studio
2. Build and run
3. Enter values and click **Calculate**
4. Click **Export CSV** to save the scenario table
