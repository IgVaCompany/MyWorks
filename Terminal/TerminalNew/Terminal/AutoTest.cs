using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Terminal
{
    public partial class AutoTest : Form
    {
        private TerminalForTesting mMainForm;

        public AutoTest(TerminalForTesting mainForm)
        {
            InitializeComponent();
            mMainForm = mainForm;

           // TerminalForTesting mainForm = (TerminalForTesting)this.Owner;
            var testsCases = mainForm.TestsCases;
            ShowTest(testsCases);

        }

        public void ShowTest(List<TestCase> testCases)
        {
            for (int i = 0; i <testCases.Count ; i++)
            {
                for (int j = 0; j < testCases[i].Test.Count; j++)
                {
                    listBox1.Items.AddRange(testCases[i].Test[j].testName.Split());
                }
            }
        }
        private void AutoTest_Load(object sender, EventArgs e)
        {

        }
    }
}
