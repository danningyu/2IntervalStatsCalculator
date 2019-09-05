using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Excel = Microsoft.Office.Interop.Excel;

//TODO: turn the interval data validation into its own function that returns a bool

namespace AngleCalculator
{
    public partial class Form1 : Form
    {
        List<double> data = new List<double>();
        List<double> intervalData1 = new List<double>();
        List<double> intervalData2 = new List<double>();
        System.IO.Stream myStream = null;
        public Form1()
        {
            InitializeComponent();
            debugMessages.Text = debugMessages.Text + Environment.NewLine;
            debugMessages.Text = debugMessages.Text + "Application started, last revised 24 July 2019." + Environment.NewLine;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {                 
            DialogResult temp = openFileDialog2.ShowDialog();
            if(temp == DialogResult.OK) {
              //  toolStripStatusLabel1.Text = "Opened a file";
                try {
                    myStream = openFileDialog2.OpenFile(); //open the file
                    if(myStream == null) {
                        MessageBox.Show("myStream is NULL");
                        
                            }
                    else {
                        //read in all the lines                        
                        string tempData = "";
                        StreamReader sr = new StreamReader(myStream);
                        data.Clear();
                        intervalData1.Clear();
                        intervalData2.Clear();
                        while((tempData = sr.ReadLine()) != null) {
                            //tempData = sr.ReadLine();
                            if(tempData != "" && tempData[0] == '+') { //positive value
                                tempData = tempData.Substring(1); //eliminate the sign
                                if (tempData.Contains("+") == false && tempData.Contains("-") == false) {
                                    data.Add(double.Parse(tempData, System.Globalization.CultureInfo.InvariantCulture));
                                }
                              //  debugMessages.Text = debugMessages.Text + data[data.Count - 1] + "\r\n";
                            }
                            else if(tempData != "" && tempData[0] == '-') { //negative value
                                tempData = tempData.Substring(1); //eliminate the sign
                                if (tempData.Contains("+") == false && tempData.Contains("-") == false) {
                                    data.Add(double.Parse(tempData, System.Globalization.CultureInfo.InvariantCulture));
                                    data[data.Count - 1] = -1.0 * data[data.Count - 1];
                                }                               
                               // debugMessages.Text = debugMessages.Text+ data[data.Count - 1]+"\r\n";
                            }
                            //else {
                            //    debugMessages.Text += "Invalid characters found, please check text file formatting." + Environment.NewLine;
                            //    MessageBox.Show("Invalid characters found, please check text file formatting.");
                            //}
                            //debugMessages.Text = debugMessages.Text + data.Count.ToString() + "\r\n";
                        }
                        sr.Close();
                        debugMessages.Text = debugMessages.Text + "File successfully read in." + Environment.NewLine;
                        debugMessages.Text = debugMessages.Text + "Number of data points: " +data.Count.ToString() + Environment.NewLine;
                        XMinBox.Text = 0.ToString();
                        YMinBox.Text = data.Min().ToString();
                        XMaxBox.Text = (data.Count-1).ToString();
                        YMaxBox.Text = data.Max().ToString();
                    }
                }
                catch(Exception error) {
                    MessageBox.Show(error.Message); //show the error
                }
            } 
            else if(temp == DialogResult.Cancel){
               // toolStripStatusLabel1.Text = "Canceled opening a file";
            }
        }

        private void exportDataToExcelToolStripMenuItem_Click(object sender, EventArgs e) {
            if (data.Count == 0) {
                MessageBox.Show("No data to export.");
                debugMessages.Text = debugMessages.Text + "No data to export." + Environment.NewLine;
                return;
            }
            intervalAvgButton_Click(sender, e); //calculate stats for interval 1
            button1_Click_1(sender, e); //calculate stats for interval 2
            calcDiffButton_Click(sender, e); //calculate difference and its uncertainty
            DialogResult temp = exportExcelDialog.ShowDialog();
            if(temp == DialogResult.OK) {
                //create an excel spreadsheet
                Excel.Application excel = new Excel.Application();
                var workBooks = excel.Workbooks;
                var workBook = workBooks.Add();
                var workSheet = (Excel.Worksheet)excel.ActiveSheet;

                //populate the spreadsheet with the calculated data
                workSheet.Cells[1, "A"] = "Angle Reading";
                for (int i = 0; i < data.Count; i++) {
                    workSheet.Cells[i + 2, "A"] = data[i];
                }

                //column headers
                workSheet.Cells[1, "C"] = "Interval #"; 
                workSheet.Cells[1, "D"] = "Lower Bound";
                workSheet.Cells[1, "E"] = "Upper Bound";
                workSheet.Cells[1, "F"] = "Interval Avg.";
                workSheet.Cells[1, "G"] = "Uncert. of Avg.";
                workSheet.Cells[1, "H"] = "Diff. of Avgs.";
                workSheet.Cells[1, "I"] = "Uncert. of Diff. of Avgs.";

                //interval 1 stats
                workSheet.Cells[2, "C"] = "1";
                workSheet.Cells[2, "D"] = lowerBoundText.Text;
                workSheet.Cells[2, "E"] = upperBoundText.Text;
                workSheet.Cells[2, "F"] = intervalAvgTextBox.Text;
                workSheet.Cells[2, "G"] = IntervalStdDevTextBox.Text;

                //interval 2 stats
                workSheet.Cells[3, "C"] = "2";
                workSheet.Cells[3, "D"] = lowerBound2.Text;
                workSheet.Cells[3, "E"] = upperBound2Text.Text;
                workSheet.Cells[3, "F"] = interval2AvgText.Text;
                workSheet.Cells[3, "G"] = interval2UncertText.Text;

                //difference stats
                workSheet.Cells[2, "H"] = diffTextBox.Text;
                workSheet.Cells[2, "I"] = diffUncertBox.Text;

                //save the file
                string path1 = exportExcelDialog.FileName;
                workBook.SaveAs(path1);
                workBook.Close();
                excel.Quit();
                MessageBox.Show("Successfully exported data and results to Excel.");
                debugMessages.Text = debugMessages.Text + "Successfully exported data and results to Excel." + Environment.NewLine;                
            }
            else {
                return;
            }
        }

        private void Form1_Load(object sender, EventArgs e){

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e){
            //exit the application
            Application.Exit();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void openFileDialog2_FileOk(object sender, CancelEventArgs e)
        {
        
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void plotButton_Click(object sender, EventArgs e)
        {         
            if (myStream == null) {
                MessageBox.Show("Error, no data to plot! Please load a text file.");
                debugMessages.Text = debugMessages.Text + "Error, no data to plot! Please load a text file." + Environment.NewLine;
                return;
            }
            double num;
            if(!double.TryParse(XMinBox.Text, out num) ||
                !double.TryParse(XMaxBox.Text, out num) ||
                !double.TryParse(YMinBox.Text, out num) ||
                !double.TryParse(YMaxBox.Text, out num)) {
                MessageBox.Show("XMin, XMax, YMin, and/or YMax must be a number.");
                debugMessages.Text = debugMessages.Text + "XMin, XMax, YMin, and/or YMax must be a number." + Environment.NewLine;
                return;
            }
            if(Convert.ToDouble(XMinBox.Text) >= Convert.ToDouble(XMaxBox.Text)) {
                MessageBox.Show("XMin cannot be bigger than or equal to XMax.");
                debugMessages.Text = debugMessages.Text + "XMin cannot be bigger than or equal to XMax." + Environment.NewLine;
                return;
            }
            if(Convert.ToDouble(YMinBox.Text) >= Convert.ToDouble(YMaxBox.Text)) {
                MessageBox.Show("YMin cannot be bigger than or equal to YMax.");
                debugMessages.Text = debugMessages.Text + "YMin cannot be bigger than or equal to YMax." + Environment.NewLine;
                return;
            }
            anglePlot.Series.Clear();
            anglePlot.Series.Add("Angles");
            anglePlot.Series[0].ChartType = SeriesChartType.Line;
            anglePlot.Series[0].LegendText = "Angle";
           
            for (int i = 0; i < data.Count; i++) {
                anglePlot.Series[0].Points.AddXY(i, data[i]);
            }
            anglePlot.ChartAreas[0].AxisY.Title = "Angle";
            anglePlot.ChartAreas[0].AxisX.Title = "Count";
            anglePlot.ChartAreas[0].AxisX.Minimum = Convert.ToDouble(XMinBox.Text);
            anglePlot.ChartAreas[0].AxisX.Maximum = Convert.ToDouble(XMaxBox.Text);
            anglePlot.ChartAreas[0].AxisY.Minimum = Convert.ToDouble(YMinBox.Text);
            anglePlot.ChartAreas[0].AxisY.Maximum = Convert.ToDouble(YMaxBox.Text);
        }

        private void calcAvgButton_Click(object sender, EventArgs e)
        {
            //calculate overall statistics
            //avg
            string temp = calculateAvg(data).ToString();
        //    averageAngle.Text = temp;
            debugMessages.Text = debugMessages.Text + "Calculated overall statistics." + Environment.NewLine;

            //std dev
            string stdDevString = sampleStdDev(data).ToString();
          //  stdDevTextBox.Text = stdDevString;

            //min & max
           // minimumTextBox.Text = data.Min().ToString();
           // maximumTextBox.Text = data.Max().ToString();
        }

        private void anglePlot_Click(object sender, EventArgs e) {
        }

        //private void closeButton_Click(object sender, EventArgs e) {
        //    Application.Exit();
        //}

        //private void toolTip1_Popup(object sender, PopupEventArgs e) {

        //}

        private void label2_Click(object sender, EventArgs e) {

        }

        private void label4_Click(object sender, EventArgs e) {

        }

        private double calculateAvg(List<double> listOfData) {
            double sum = 0.0;
            for (int i = 0; i < listOfData.Count; i++) {
                sum += listOfData[i];
            }
            double average = sum / listOfData.Count;
            return average;
        }
        private double calculateAvg(List<double> listOfData, int lowerBound, int upperBound) {           
            double sum = 0.0;
            for (int i = lowerBound; i < upperBound; i++) {
                sum += listOfData[i];
            }
            double average = sum / (upperBound - lowerBound + 1);
            string avgString = average.ToString();
            return average;
        }

        private double sampleStdDev(List<double> listOfData) {
            double average = calculateAvg(listOfData);
            double deviationsSquared = 0.0;
            for(int i = 0; i<listOfData.Count; i++) {
                deviationsSquared += Math.Pow(listOfData[i] - average, 2);          
            }
            return Math.Sqrt(deviationsSquared / (listOfData.Count - 1)); //n-1 for sample std. dev.
        }

        private double sampleStdDev(List<double> listOfData, int lowerBound, int upperBound) {
            double average = calculateAvg(listOfData);
            double deviationsSquared = 0.0;
            for (int i = lowerBound; i < upperBound; i++) {
                deviationsSquared += Math.Pow(listOfData[i] - average, 2);
            }
            return Math.Sqrt(deviationsSquared / (upperBound - lowerBound)); //upper - lower gives # of elements minus 1
        }
        private void intervalAvgButton_Click(object sender, EventArgs e) {
            //calculate interval statistics
            intervalData1.Clear();

            //average
            if(lowerBoundText.Text == "" || upperBoundText.Text == "") {              
                    MessageBox.Show("Please specify upper and/or lower bound(s).");
                    return;         
            }
            
            int num;
            if(!Int32.TryParse(lowerBoundText.Text, out num) ||
                !Int32.TryParse(upperBoundText.Text, out num)) {
                MessageBox.Show("Lower bound and/or upper bound must be a number.");
                debugMessages.Text = debugMessages.Text + "Lower bound and/or upper bound must be a number." + Environment.NewLine;
                return;
            }
            int lower = Int32.Parse(lowerBoundText.Text);
            int upper = Int32.Parse(upperBoundText.Text);
            if(upper >= data.Count) {
                MessageBox.Show("Upper bound cannot be greater than number of data points.");
                debugMessages.Text = debugMessages.Text + "Upper bound cannot be greater than number of data points." + Environment.NewLine;
                return;
            }
            if(lower >= upper) {
                MessageBox.Show("Lower bound cannot be greater than or equal to upper bound.");
                debugMessages.Text = debugMessages.Text + "Lower bound cannot be greater than or equal to upper bound." + Environment.NewLine;
                return;
            }
            if (lower < 0 || upper < 0) {
                MessageBox.Show("Lower and/or upper bound cannot be negative.");
                debugMessages.Text = debugMessages.Text + "Lower and/or upper bound cannot be negative." + Environment.NewLine;
                return;
            }
            string avgString = calculateAvg(data, lower, upper).ToString();
            intervalAvgTextBox.Text = avgString;

            //std dev
            string uncertainty = (sampleStdDev(data, lower, upper) / (Math.Sqrt(upper - lower + 1))).ToString();
            IntervalStdDevTextBox.Text = uncertainty;

            //min & max
            for(int i = lower; i<upper; i++) {
                intervalData1.Add(data[i]);
            }
            debugMessages.Text = debugMessages.Text + "Calculated interval 1 statistics." + Environment.NewLine;
        }

        private void intervalAvgTextBox_TextChanged(object sender, EventArgs e) {

        }

        private void maximumTextBox_TextChanged(object sender, EventArgs e) {

        }

        private void resetBoundsButton_Click(object sender, EventArgs e) {
            if(data.Count == 0) {
                MessageBox.Show("No data to reset bounds for.");
                debugMessages.Text = debugMessages.Text + "No data to reset bounds for." + Environment.NewLine;
                return;
            }
            XMinBox.Text = 0.ToString();
            YMinBox.Text = data.Min().ToString();
            XMaxBox.Text = (data.Count - 1).ToString();
            YMaxBox.Text = data.Max().ToString();
        }

        private void matchIntervalBoundsButton_Click(object sender, EventArgs e) {
            if(intervalSelectorBox.SelectedIndex <0) {
                MessageBox.Show("Please select a bound to match.");
                debugMessages.Text = debugMessages.Text + "Please select a bound to match." + Environment.NewLine;
            }
            if(intervalSelectorBox.SelectedIndex == 0) { //interval 1
                XMinBox.Text = lowerBoundText.Text;
                XMaxBox.Text = upperBoundText.Text;
            }
           else if(intervalSelectorBox.SelectedIndex == 1) { //interval 2
                XMinBox.Text = lowerBound2.Text;
                XMaxBox.Text = upperBound2Text.Text;
            }
        }

        private void matchGraphBoundsButton_Click(object sender, EventArgs e) {
            lowerBoundText.Text = XMinBox.Text;
            upperBoundText.Text = XMaxBox.Text;
        }

        private void button1_Click_1(object sender, EventArgs e) { //calculate stats for interval2
            //calculate interval statistics
            intervalData2.Clear();

            //average
            if (lowerBound2.Text == "" || upperBound2Text.Text == "") {
                MessageBox.Show("Please specify upper and/or lower bound(s).");
                return;
            }

            int num;
            if (!Int32.TryParse(lowerBound2.Text, out num) ||
                !Int32.TryParse(upperBound2Text.Text, out num)) {
                MessageBox.Show("Lower bound and/or upper bound must be a number.");
                debugMessages.Text = debugMessages.Text + "Lower bound and/or upper bound must be a number." + Environment.NewLine;
                return;
            }
            int lower = Int32.Parse(lowerBound2.Text);
            int upper = Int32.Parse(upperBound2Text.Text);
            if (upper >= data.Count) {
                MessageBox.Show("Upper bound cannot be greater than number of data points.");
                debugMessages.Text = debugMessages.Text + "Upper bound cannot be greater than number of data points." + Environment.NewLine;
                return;
            }
            if (lower >= upper) {
                MessageBox.Show("Lower bound cannot be greater than or equal to upper bound.");
                debugMessages.Text = debugMessages.Text + "Lower bound cannot be greater than or equal to upper bound." + Environment.NewLine;
                return;
            }
            if (lower < 0 || upper < 0) {
                MessageBox.Show("Lower and/or upper bound cannot be negative.");
                debugMessages.Text = debugMessages.Text + "Lower and/or upper bound cannot be negative." + Environment.NewLine;
                return;
            }
            string avgString = calculateAvg(data, lower, upper).ToString();

            interval2AvgText.Text = avgString;
            
            //uncertainty: sample std. dev. divided by sqrt of number of data points
            string uncertainty = (sampleStdDev(data, lower, upper)/(Math.Sqrt(upper-lower+1))).ToString();
            interval2UncertText.Text = uncertainty;
            debugMessages.Text = debugMessages.Text + "Calculated interval 2 statistics." + Environment.NewLine;
        }

        private void matchBounds2Button_Click(object sender, EventArgs e) {
            lowerBound2.Text = XMinBox.Text;
            upperBound2Text.Text = XMaxBox.Text;
        }

        private void calcDiffButton_Click(object sender, EventArgs e) {
            if(lowerBound2.Text == "" || lowerBoundText.Text == "" || upperBound2Text.Text == "" || upperBoundText.Text == "") {
                MessageBox.Show("Missing an interval value.");
                debugMessages.Text = debugMessages.Text + "Missing an interval value." + Environment.NewLine;
                return;
            }
            if(intervalAvgTextBox.Text == "" || interval2AvgText.Text == "" || interval2AvgText.Text == "" || interval2AvgText.Text == "") {
               //first calculate the data, if not already calculated.
                intervalAvgButton_Click(sender, e);
                button1_Click_1(sender, e);            
            }
            diffTextBox.Text = (Math.Abs(double.Parse(intervalAvgTextBox.Text, System.Globalization.CultureInfo.InvariantCulture) -
              double.Parse(interval2AvgText.Text, System.Globalization.CultureInfo.InvariantCulture))).ToString();
            
            diffUncertBox.Text = Math.Sqrt(Math.Pow(double.Parse(IntervalStdDevTextBox.Text, System.Globalization.CultureInfo.InvariantCulture), 2) +
                Math.Pow(double.Parse(interval2UncertText.Text, System.Globalization.CultureInfo.InvariantCulture), 2)).ToString();            
            debugMessages.Text = debugMessages.Text + "Calculated the difference of interval 1 and 2 averages." + Environment.NewLine;
        }

        private void IntervalStdDevTextBox_TextChanged(object sender, EventArgs e) {

        }

        private void XMinBox_TextChanged(object sender, EventArgs e) {

        }

        private void exportExcelButton_Click(object sender, EventArgs e) {
            exportDataToExcelToolStripMenuItem_Click(sender, e);
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e) {
           
        }

        private void revisionHistoryToolStripMenuItem_Click(object sender, EventArgs e) {
            string line0 = "Two Interval Statistics Calculator, version 1.01 (24 July 2019).\n";
            string line1 = "About Application:\n";
            string line1AA = "Micro and Nano Manufacturing Lab.\n";
            string line1A = "Created by Danning Yu, Summer 2019.\n";
            //string line2 = "Version 1.01, last revised 21 July 2019.\n";
            string line3 = "v1.00: Initial code written.\n";
            string line4 = "v1.01: Added code to handle lines with two angle readings on one line of text.\n";
             line4 += "v1.01: Labelled X-axis as \"count.\"";
            string message = line1 +line0+line1AA + line1A + line3 + line4;
            MessageBox.Show(message, "Revision History");

           
        }

        private void helpToolStripMenuItem1_Click(object sender, EventArgs e) {
            string line2 = "This application is for reading in angle values (positive or negative) from a text file," +
               "graphing them, and calculating statistics for a particular interval of values.\n";
            string line3 = "To use, first import data in the form of a text file.\n";
            string line4 = "Then, to graph, click the \"Graph\" button. The bounds of the graph can be set manually.";
            string line5 = "To calculate statistics for a particular interval of data, specify the lower and upper bounds for either" +
                " Interval 1 or interval 2, then click \"Calculate Statistics\"\n";
            string line6 = "If the lower and upper bounds for intervals 1 and 2 are both specified, the difference of their averages can" +
                "be calculated using the \"Calculate Difference\" button.\n";
            string line7 = "The raw data and calculated data can also be exported to Excel if desired.\n";
            string message =line2 + line3 + line4 + line5 + line6 + line7;
            //MessageBox.Show(message);
            MessageBox.Show(message, "About Application");
        }

        private void intervalSelectorBox_SelectedIndexChanged(object sender, EventArgs e) {

        }
    }
}