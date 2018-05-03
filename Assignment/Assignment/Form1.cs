using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Assignment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Constant path to my names csv file
        const string txtPath1 = "Names.csv";
        // Variables
        static string[] arNames = new string[5000];
        StreamReader sReader = File.OpenText(txtPath1);
        int i;
       



        private void btnClose_Click(object sender, EventArgs e)
        {
            // Closes application
            Exit();
        }

        

        public void loadFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Variables for time
            DateTime start = DateTime.Now;
            DateTime Finish;
            TimeSpan Time;
            try
            {
                // Clears Text
                lblTime.Text = "";
                // Declaration of Variables
                // Contains the path for the stream reader


                // Stream Reader to read the text files



                // Variables


                i = 0;

                // Increment my i variable
                for (i = 0; i < 5000; i++)
                {
                    // Adds each line that my stream reader reads
                    // into the array instance of i
                    arNames[i] = sReader.ReadLine();
                    // adds the instance of i into the list box
                    lbNames.Items.Add(arNames[i]);
                    
                }
                // finish variable is the current time

                Finish = DateTime.Now;

                // Time lapse variable set
                Time = Finish - start;

                // Visual things that I like
                sortResultsToolStripMenuItem.Enabled = true;
                exportFileToolStripMenuItem.Enabled = true;
                loadFileToolStripMenuItem.Enabled = false;
               

                // Requiremental time thingy
                lblTime.Text = lbNames.Items.Count.ToString() + " " + "Results Loaded in" + " " + (Time.TotalSeconds.ToString()) + " " + "seconds";
            }

            catch 
            {
                // if you're Sam, you will see this eventually
                MessageBox.Show("Error..");
                
            }




        }

        private void exportFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // Time variables declared
                DateTime start = DateTime.Now;
                DateTime Finish;
                TimeSpan Time;

                // Clears text
                lblTime.Text = "";
                // Contains the path for the stream writer
                string txtPath2 = "NewNames.csv";
                // Stream Writer to write the text files
                StreamWriter sWriter = new StreamWriter(txtPath2);
                // Writes the sorted values into the new file
                foreach (string name in lbNames.Items)
                {
                    // Writes the items from the listbox into the csv file
                    sWriter.WriteLine(name.ToString());
                }
                // Sets time variables
                Finish = DateTime.Now;
                Time = Finish - start;

                // Visuals
                sortResultsToolStripMenuItem.Enabled = false;
                exportFileToolStripMenuItem.Enabled = false;
                restartToolStripMenuItem.Visible = true;

                // time label
                lblTime.Text = lbNames.Items.Count.ToString() + " " + "Results exported in" + " " + (Time.TotalSeconds.ToString()) + " " + "seconds";
            }
            catch
            {
                // If you're Sam, you will see this eventually 
                MessageBox.Show("Error...");
                
            }
        }

        public void SelectionSort(string[] arNames)
        {
            try
            {
                // Declares variables
                int minIndex;
                string minValue;
                int startScan = 0;

                // Starts scaning items in index
                for (startScan = 0; startScan < arNames.Length - 1; startScan++)
                {
                    minIndex = startScan;
                    minValue = arNames[startScan];


                    // for items found in index, increment to the next value

                    for (int index = startScan + 1; index < arNames.Length; index++)

                        // if item found in index is less than next item found, move it to the other index
                        if (string.Compare(minValue, arNames[index], true) == 1)
                        {
                            minValue = arNames[index];
                            minIndex = index;
                        }

                    // Swaps the two places
                    Swap(ref arNames[minIndex], ref arNames[startScan]);




                }
            }
            catch
            {
                // Sam might see this but it's unlikely
                MessageBox.Show("Something went wrong in the sorting process...");
            }
        }

       private void Swap(ref string a, ref string b)
        {
            // Nothing should go wrong here..
            // Swaps the variables
            string temp = a;
            a = b;
            b = temp;

        }



        private void sortResultsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                // Time variables
                DateTime start = DateTime.Now;
                DateTime Finish;
                TimeSpan Time;
                // Clear
                lblTime.Text = "";

                // While the counter is less than the length of the erray / reader end
                while (i < arNames.Length && !sReader.EndOfStream)
                {
                    // Puts the items in the text file into the erray
                    arNames[i] = sReader.ReadLine();
                    i++;
                }
                // Clears the list box
                lbNames.Items.Clear();
                // Sorts items in array
                SelectionSort(arNames);

                // Adds them to the list box
                foreach (string name in arNames)
                {
                    lbNames.Items.Add(name);
                }
                // Time stuff
                Finish = DateTime.Now;
                Time = Finish - start;
                tbInput.Visible = true;
                lblName.Visible = true;
                btnPop.Visible = true;
                lblTime.Text = lbNames.Items.Count.ToString() + " " + "Results Sorted in" + " " + (Time.TotalSeconds.ToString()) + " " + "seconds";
            }
            catch
            {
                // Sam will see this eventually
                MessageBox.Show("Error...");
            }
            }

        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Restarts the application if you click the restart button
            Restart();
        }

        //  I put this here to throw everyone off...
        private void Restart()
        {
            
            Application.Restart();
        }
        private void Exit()
        {
            Application.Exit();
        }


        private int BinarySearch(string[] arName, string value)
        {
            int first = 0;                      // first array element
            int last = arName.Length - 1;       // last array element
            int middle;                         // Midpoint of search
            int position = -1;                  // position of search value
            bool found = false;                 // Flag

            // Search for the value
            while (!found && first <= last)
            {
                // Calc the midpoint.
                middle = (first + last) / 2;

                // If value is found at midpoint ...
                if (arName[middle] == value)
                {
                    found = true;
                    position = middle;
                }

                // else if value is in lower half...
                else if (string.Compare(arName[middle], value, false) > 0)
                {
                    last = middle - 1;
                }

                // else if value is in upper half...
                else
                {
                    first = middle + 1;
                }
            }
            // Return the position of the item, or -1
            // If it was not found.
            return position;



        }
        private void btnPop_Click(object sender, EventArgs e)
        {
            try
            {
                // Time variables
                DateTime start = DateTime.Now;
                DateTime Finish;
                TimeSpan Time;
                // name = text in textbox
                string Name = tbInput.Text;
                // sets the position
                int position = BinarySearch(arNames, tbInput.Text);
                // boolean determining if name is in the array
                bool Found = arNames.Contains(Name);
                // If it was not found, display this message
                if (Found == false)
                {
                    lblTime.Text = "This name could not be found";
                }
                // If found, do this
                else
                {
                    // Time stuff
                    Finish = DateTime.Now;
                    Time = Finish - start;
                    // Highlights the name
                    lbNames.SetSelected(position, true);
                    lblTime.Text = "Results found in" + " " + (Time.TotalSeconds.ToString()) + " " + "seconds";
                }
            }
            catch
            {  // Sam did it
                MessageBox.Show("You broke it");
            }
        }

    }
}
