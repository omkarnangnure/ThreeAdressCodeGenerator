using IronPython.Hosting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text;

namespace Three_Address_Code_Generator
{
    public partial class Form1 : Form
    {
        string results = "";
        int i = 0;
        string re = "";

        public void printit(string re)
        {
            PrefixPostfix.Text = re.ToString();
        }

        public Form1()
        {
            InitializeComponent();
            INIT.Enabled = false;
            OUTPUT.Enabled = false;
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Output_Click(object sender, EventArgs e)
        {
            PrefixPostfix.Text ="Output:\n "+ results ;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PrefixPostfix.Clear();
            ExpressionText.Clear();
            re = "";
        }

      private void STEPIN_Click(object sender,EventArgs e)
        { 
                    

        }
        private void button2_Click(object sender, EventArgs e)
        {
            var psi = new ProcessStartInfo();
            psi.FileName = @"C:\Users\Omkar\Anaconda3\python.exe";

            // 2) Provide script and arguments
            var script = @"C:\Users\Omkar\Anaconda3\tac.py";
            var start = ExpressionText.Text;

            psi.Arguments = $"\"{script}\" \"{start}\"";

            // 3) Process configuration
            psi.UseShellExecute = false;
            psi.CreateNoWindow = true;
            psi.RedirectStandardOutput = true;
            psi.RedirectStandardError = true;

            // 4) Execute process and get output
            var errors = "";
            

            using (var process = Process.Start(psi))
            {
                errors = process.StandardError.ReadToEnd();
                results = process.StandardOutput.ReadToEnd();
            }
            MessageBox.Show("Output Generated...");
            INIT.Enabled = true;
            OUTPUT.Enabled = true;
        }

        private void PrefixPostfix_TextChanged(object sender, EventArgs e)
        {

        }

        private void INIT_Click(object sender, EventArgs e)
        {
            int j;
            if(i<results.Length)
            { 
                for( j=i; results[j].ToString().Equals("\n")==false;j++)
                { 
                    re += results[j].ToString();
     
                }
                j++;
                i += j-i;
                re += "\n";
                printit(re);
            }
        }
    }
}
