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
        const string txtPath1 = "Names.csv";
        // Variables
        static string[] arNames = new string[5000];
        StreamReader sReader = File.OpenText(txtPath1);
        int i;
        DateTime start = DateTime.Now;
        DateTime Finish;
        TimeSpan Time;



        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void loadFileToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {

                
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

                Finish = DateTime.Now;
                Time = Finish - start;
                lblTime.Text = lbNames.Items.Count.ToString() + " " + "Results Loaded in" + " " + (Time.ToString());
            }

            catch (Exception)
            {


                throw;
            }




        }

        private void exportFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Contains the path for the stream writer
            string txtPath2 = "NewNames.csv";
            // Stream Writer to write the text files
            StreamWriter sWriter = new StreamWriter(txtPath2);
            // Writes the sorted values into the new file
            foreach (string name in lbNames.Items)
            {
                sWriter.WriteLine(name.ToString());
            }

        }

       public void SelectionSort(string[] arNames)
        {
            int minIndex;
            string minValue;
            int startScan = 0;

            for (startScan = 0; startScan < arNames.Length - 1; startScan++)
            {
                minIndex = startScan;
                minValue = arNames[startScan];




                for (int index = startScan + 1; index < arNames.Length; index++)
                {
                    if (string.Compare(minValue, arNames[index], true) == 1)
                    {
                        minValue = arNames[index];
                        minIndex = index;
                    }
                }
                Swap(ref arNames[minIndex], ref arNames[startScan]);
            }



        }

       private void Swap(ref string a, ref string b)
        {
            string temp = a;
            a = b;
            b = temp;

        }

       

        private void sortResultsToolStripMenuItem_Click(object sender, EventArgs e)
        {


            while (i < arNames.Length && !sReader.EndOfStream)
            {
                arNames[i] = sReader.ReadLine();
                i++;
            }
            lbNames.Items.Clear();
            SelectionSort(arNames);

            foreach (string name in arNames)
            {
                lbNames.Items.Add(name);
            }

            Finish = DateTime.Now;
            Time = Finish - start;
            
            lblTime.Text = lbNames.Items.Count.ToString() + " " + "Results Sorted in" + " " + (Time.TotalSeconds.ToString()) + " " + "seconds";
        }

    }
}
