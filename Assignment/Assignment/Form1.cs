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

        private void btnPop_Click(object sender, EventArgs e)
        {
          

            try
            {
                // Declaration of Variables
                // Contains the path for the stream readers and writers
                string txtPath1 = "Names.csv";
                string txtPath2 = "NewNames.csv";
                // Stream Reader to read the text files
                StreamReader sReader = File.OpenText(txtPath1);
                // Stream Writer to write the text files
                StreamWriter sWriter = new StreamWriter(txtPath2);
                
               

                
                
                
                    int i;
                    i = 0;
                    string[] arNames = new string[5000];

                    for (i = 0; i < 5000; i++)
                    {
                        arNames[i] = sReader.ReadLine();
                    Array.Sort(arNames);
                        lbNames.Items.Add(arNames[i]);
                        
                    }


                foreach (string name in lbNames.Items)
                {
                    sWriter.WriteLine(name.ToString());
                }

                
                }
            
            catch (Exception)
            {


                throw;
            }





        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
