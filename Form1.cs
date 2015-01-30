using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;

namespace Thesaurus
    // maybe have it as a status bar for windows up top (docked) or docked on other sides?
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtQuery_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter)
            {
                return;
            }

            DoLookup(txtQuery.Text);
        }

        private void DoLookup(string word)
        {
            List<String> responses = thesaurusize(word);
            string synonyms = ""; // #todo stringbuilder lol
            foreach (String line in responses)
            {
                var thing = new SimilarThing(line);
                if (synonyms == "")
                    synonyms = thing.word;
                else
                    synonyms = synonyms + ", " + thing.word;
            }
            lblSynonyms.Text = synonyms;
        }

        private List<String> thesaurusize(string word)
        {
            string api = "http://words.bighugelabs.com/api/2/abef66eef1e1256bbd2912b0113b23c9/[[query]]/";
            string query = word;

            List<String> responses = new List<string>();

            string url = api.Replace("[[query]]", query);

            WebRequest wrGETURL;
            wrGETURL = WebRequest.Create(url);

            Stream objStream;
            try
            {
                objStream = wrGETURL.GetResponse().GetResponseStream();
                StreamReader objReader = new StreamReader(objStream);
                string sLine = "";
                while (sLine != null)
                {
                    sLine = objReader.ReadLine();
                    if (sLine != null)
                    {
                        responses.Add(sLine);
                    }
                }
            }
            catch
            {
                // not a single fuck
            }

            return responses;
        }

        private class SimilarThing
        {
            public string part, type, word;

            public SimilarThing(string line)
            {
                string[] parts = line.Split('|');
                part = parts[0].Trim();
                type = parts[1].Trim();
                word = parts[2].Trim();
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            int y = Screen.PrimaryScreen.Bounds.Bottom - this.Height;
            this.Location = new Point(0, y);
        }

        private void lblSynonyms_Click(object sender, EventArgs e)
        {

        }

        private void txtQuery_TextChanged(object sender, EventArgs e)
        {

        }

        [STAThread]
        private void tmrClipboardWatch_Tick(object sender, EventArgs e)
        {
            string current_clipboard_content = Clipboard.GetText();

            if (this.Tag != null)
            {
                // Treat the timer's flag as the last poll's clipboard content
                if (this.Tag.ToString() != current_clipboard_content)
                {
                    // clipboard changed
                    DoLookup(current_clipboard_content);
                    txtQuery.Text = current_clipboard_content;
                    this.Tag = current_clipboard_content;
                }
                
            }
            else
            {
                this.Tag = current_clipboard_content;
            }
        }
    }
}
