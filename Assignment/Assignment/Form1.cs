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
                this.Size = new Size(300, 382);
                regularSearchToolStripMenuItem.Enabled = true;
                lblName.Text = "Enter an EXACT name then hit Enter:";
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
                tbInput.Visible = false;



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

                // Determines which text box should be visible depending on which mode is selected
                if (regularSearchToolStripMenuItem.Enabled == false)
                {
                    tbInputBin.Visible = false;
                    tbInput.Visible = true;
                }
                else if (regularSearchToolStripMenuItem.Enabled == true)
                {
                    tbInputBin.Visible = true;
                    tbInput.Visible = false;
                }
                // Shows the name label, allows the items to be sorted.
                lblName.Visible = true;
                sortResultsToolStripMenuItem.Enabled = false;   
                // Displays the amount of time
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
            // Confirm that user really intends on exiting the application.
            DialogResult dr = MessageBox.Show("Are you sure you want to exit?", "Exiting...", MessageBoxButtons.YesNo);

            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
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

        private void tbInput_TextChanged(object sender, EventArgs e)
        {
            try
            {
                // Time variables
                DateTime start = DateTime.Now;
                DateTime Finish;
                TimeSpan Time;
                string search = tbInput.Text;
                // Clears list box and prepares it to show results
                lbNames.Items.Clear();
                // Searches for the item in the array that contains the text from text box
                lbNames.Items.AddRange(arNames.Where(n => n.Contains(search)).ToArray());
                //Time variables
                Finish = DateTime.Now;
                Time = Finish - start; string text = lbNames.GetItemText(lbNames.SelectedItem);
                lblTime.Text = lbNames.Items.Count + " " + "found in" + " " + (Time.TotalSeconds.ToString()) + " " + "seconds";

            }
            catch
            {  // Sam did it
                MessageBox.Show("You broke it");
            }
        }

        private void tbInputBin_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    // Time variables
                    DateTime start = DateTime.Now;
                    DateTime Finish;
                    TimeSpan Time;

                    // name = text in textbox
                    string Name = tbInputBin.Text;
                    // sets the position
                    int position = BinarySearch(arNames, tbInputBin.Text);
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
                        string text = lbNames.GetItemText(lbNames.SelectedItem);
                        lblTime.Text = text + " " + "found in" + " " + (Time.TotalSeconds.ToString()) + " " + "seconds";
                    }
                }
            }
            catch
            {  // Sam did it
                MessageBox.Show("You broke it");
            }
        }


            

        
    
        private void binarySearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // When you switch to binary search mode, it won't allow you to click the button again
            binarySearchToolStripMenuItem.Enabled = false;
            regularSearchToolStripMenuItem.Enabled = true;
            // Clears tbInput Text to reset the items to display all 5000 
            tbInput.Text = "";

            // Switches the text of the label
            lblName.Text = "Enter an EXACT name then hit Enter:";

            // Conditional statements for appearance
            if (sortResultsToolStripMenuItem.Enabled == true)
            {
                tbInputBin.Visible = false;
                lblName.Visible = false;
                tbInput.Visible = false;
            }
            else if (sortResultsToolStripMenuItem.Enabled == false)
            {
                tbInputBin.Visible = true;
                tbInput.Visible = true;
            }
        }

        private void regularSearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Disables the ability to click the button again
            regularSearchToolStripMenuItem.Enabled = false;
            binarySearchToolStripMenuItem.Enabled = true;

            // Hides the other text box and shows the new text box
            tbInputBin.Visible = false;
            tbInput.Visible = true;

            // Appearance
            lblName.Visible = true;
            lblName.Text = "Enter a name:";

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Default loading stuff that could have been changed directly in the designer but that's okay.
            regularSearchToolStripMenuItem.Enabled = false;
            binarySearchToolStripMenuItem.Enabled = false;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Exits application
            Exit();
        }
    }
}
