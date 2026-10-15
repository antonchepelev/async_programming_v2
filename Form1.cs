using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace async_programming
{
    public partial class Form1 : Form
    {
        private string book1Path = string.Empty;
        private string book2Path = string.Empty;

        public Form1()
        {
            InitializeComponent();
        }


        private void btnBrowse1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Select Book 1";
                ofd.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    book1Path = ofd.FileName;
                    txtBook1.Text = Path.GetFileName(ofd.FileName);
                }
            }
        }


        private void btnBrowse2_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Select Book 2";
                ofd.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    book2Path = ofd.FileName;
                    txtBook2.Text = Path.GetFileName(ofd.FileName);
                }
            }
        }

        private async void btnSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(book1Path) || string.IsNullOrEmpty(book2Path))
            {
                MessageBox.Show("Please select both books before submitting.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            btnSubmit.Enabled = false;
            lstResults1.Items.Clear();
            lstResults2.Items.Clear();

            var previousCursor = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;

            try
            {
                var wc1 = new WordCount();
                var wc2 = new WordCount();


                var t1 = wc1.CountWordsAsync(book1Path);
                var t2 = wc2.CountWordsAsync(book2Path);

                var results = await Task.WhenAll(t1, t2);

                var result1 = results[0];
                var result2 = results[1];

                foreach (var item in result1)
                    lstResults1.Items.Add($"{item.Key}: {item.Value}");

                foreach (var item in result2)
                    lstResults2.Items.Add($"{item.Key}: {item.Value}");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnSubmit.Enabled = true;
                Cursor.Current = previousCursor;
            }
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Form load handler required by the designer. No initialization needed currently.
        }

    }
}

