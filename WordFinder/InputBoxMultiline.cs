using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordFinder
{
    public partial class InputBoxMultiline : Form
    {
        public string CapturedText { get; set; }

        public InputBoxMultiline(IEnumerable<string> matrix)
        {
            InitializeComponent();

            if (matrix.Count() > 0)
            {
                StringBuilder sb = new StringBuilder();
                foreach (string row in matrix)
                {
                    sb.AppendLine(row);
                }
                CapturedText = sb.ToString().Substring(0, 4222);
            }
            else
            {
                CapturedText = "";
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (TextValidate())
            {
                CapturedText = txtInputText.Text;
                DialogResult = DialogResult.OK;
            }
        }
        private void InputBoxMultiline_Load(object sender, EventArgs e)
        {
            txtInputText.Text = CapturedText;
        }
        private bool TextValidate()
        {
            bool result = false;

            try
            {
                IEnumerable<string> lines = txtInputText.Text.Split("\r\n");

                if (lines.Count() != 64) throw new Exception("The number of lines must be 64");

                foreach (string line in lines)
                {
                    if (line.Length != 64) throw new Exception("The number of letters per line must be 64");
                    if (!Regex.IsMatch(line, @"^[a-zA-Z]+$")) throw new Exception("Only letters");
                }

                result = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return result;
        }
    }
}
