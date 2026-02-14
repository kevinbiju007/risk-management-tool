using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace RiskManagementTool
{
    public class Class_ExportFile
    {
        public sealed class RiskScenarioTable
        {
            public decimal riskPercent { get; set; }
            public decimal riskAmount { get; set; }
            public decimal units { get; set; }
            public decimal positionValue { get; set; }
        }

        public bool ExportToCSV(DataGridView riskScenarios)
        {

            List<string> lines = new List<string>();

            // headers
            DataGridViewColumnCollection header = riskScenarios.Columns;
            bool firstDone = false;
            StringBuilder headerLine = new StringBuilder();

            foreach (DataGridViewColumn col in header)
            {
                if (!firstDone)
                {
                    headerLine.Append(col.HeaderText);
                    firstDone = true;
                }
                else
                {
                    headerLine.Append("," + col.HeaderText);
                }
            }
            lines.Add(headerLine.ToString());

            // data lines
            foreach (DataGridViewRow row in riskScenarios.Rows)
            {
                if (row.IsNewRow) continue;

                StringBuilder dataLine = new StringBuilder();
                firstDone = false;

                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (!firstDone)
                    {
                        dataLine.Append(cell.Value);
                        firstDone = true;
                    }
                    else
                    {
                        dataLine.Append("," + cell.Value);
                    }
                }

                lines.Add(dataLine.ToString());
            }
            // export csv to files
            var saveFile = new SaveFileDialog();
            saveFile.Filter = "CSV Files (*.csv)|*.csv|All Files (*.*)|*.*";
            saveFile.DefaultExt = "csv";
            saveFile.AddExtension = true;
            saveFile.FileName = $"riskScenarios_{DateTime.Now:yyyyMMdd_HHmmss}.csv";

            // opens the dialogue to allow user to save in their location
            try
            {
                if (saveFile.ShowDialog() != DialogResult.OK)
                    return false;

                System.IO.File.WriteAllLines(saveFile.FileName, lines);

                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = saveFile.FileName,
                    UseShellExecute = true
                });

                return true;
            }
            finally
            {
                saveFile.Dispose();
            }
        }
    }
}
