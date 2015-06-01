using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.IO;

namespace EPAC
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        public class Episode
        {
            public string number;
            public string name;
        }

        List<Episode> episodes = new List<Episode>();

        string pattern;

        private string get(string address)
        {
            string htmlCode = null;

            using (WebClient client = new WebClient())
            {
                client.Encoding = Encoding.UTF8;
                try
                {
                    htmlCode = client.DownloadString(address);
                }
                catch
                {
                    // pass
                }
            }

            return htmlCode;
        }

        private void imdbParse(string text)
        {
            string[] lines = text.Split('\n');
            byte control = 0;

            Episode epi = new Episode();

            episodes.Clear();
           
            foreach (string line in lines)
            {
                if (control == 0)
                {
                    epi = new Episode();
                }
                
                if (line.Contains("itemprop") && line.Contains("episodeNumber"))
                {
                    int start = line.IndexOf("t=\"") + 3;
                    int end = line.IndexOf("\"/");
                    int len = end - start;
                    epi.number = line.Substring(start, len);
                    control++;
                }

                if (line.Contains("itemprop") && line.Contains("name") && line.Contains("title"))
                {
                    int start = line.IndexOf(">") + 1;
                    int end = line.IndexOf("<");
                    int len = end - start;
                    epi.name = line.Substring(start, len);
                    control++;
                }

                if(control == 2)
                {
                    this.episodes.Add(epi);
                    control = 0;
                }
            }
        }

        private void wikiParse(string text)
        {
            string[] lines = text.Split('\n');
            byte control = 0;

            Episode episode = new Episode();
            
            episodes.Clear();

            foreach (string line in lines)
            {
                if (control == 0)
                {
                    episode = new Episode();
                }

                if (line.Contains("<th scope=\"row\" id=\"ep"))
                {
                    int start = line.IndexOf(">") + 1;
                    int end = line.LastIndexOf("<");
                    int len = end - start;
                    episode.number += line.Substring(start, len);
                    control++;
                }

                if (line.Contains("<td class=\"summary\""))
                {
                    int start = line.IndexOf(">") + 2;
                    int end = line.LastIndexOf("<") - 1;
                    int len = end - start;
                    episode.name += line.Substring(start, len);
                    control++;
                }

                if (control == 2)
                {
                    this.episodes.Add(episode);
                    control = 0;
                }
            }
        }

        private string matchPattern(Episode epi)
        {
            string res = "";
            
            res = pattern.Replace("[#]", epi.number).Replace("[name]", epi.name);

            foreach (char c in Path.GetInvalidFileNameChars())
            {
                res = res.Replace(c.ToString(), "");
            }

            return res;
        }

        private void preview(List<Episode> episodes, string pattern)
        {
            richTextBoxPreview.Clear();

            foreach (Episode epi in episodes)
            {
                richTextBoxPreview.Text += matchPattern(epi);
                richTextBoxPreview.Text += "\n";
            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            this.pattern = textBoxPattern.Text;
            preview(this.episodes, pattern);
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            string path = textBoxPath.Text;
            
            if (path[path.Length - 1] != '\\')
            {
                path += '\\';
            }

            foreach (Episode epi in this.episodes)
            {
                string dest = path + matchPattern(epi);

                bool exists = System.IO.Directory.Exists(dest);

                if (exists)
                {
                    richTextBoxLog.Text += "(error) '" + dest + "' is exist!\n";
                }
                else
                    try
                    {
                        System.IO.Directory.CreateDirectory(dest);
                        richTextBoxLog.Text += "(done) '" + dest + "' is created.\n";
                    }
                    catch
                    {
                        richTextBoxLog.Text += "(error) '" + dest + "' can't be created!\n";
                    }
            }
        }

        private void buttonCopy_Click(object sender, EventArgs e)
        {
            string path = textBoxCopyPath.Text;
            string fname = null;
            string dname = null;
            int start, end, len;

            string[] dirs = Directory.GetDirectories(path);
            string[] files = Directory.GetFiles(path);

            foreach (string f in files)
            {
                if (f.Contains("-"))
                {
                    start = f.LastIndexOf("-") + 2;
                    end = f.LastIndexOf(".");
                    len = end - start;

                    fname =  f.Substring(start, len);

                    foreach (string d in dirs)
                    {
                        if (d.Contains("Episode") && d.Contains("-"))
                        {
                            start = d.IndexOf("Episode") + 8;
                            end = d.LastIndexOf("-") - 1;
                            len = end - start;
                            dname = d.Substring(start, len);

                            if (fname == dname)
                            {
                                string fileName = Path.GetFileName(f);
                                
                                File.Move(f, d + "\\" + fileName);

                                richTextBoxCopyLog.Text += "(done) '";
                                richTextBoxCopyLog.Text += fileName;
                                richTextBoxCopyLog.Text += "' is move to:\n";
                                richTextBoxCopyLog.Text += d + "\\\n";

                                break;
                            }
                        }
                    }
                }
            }
        }

        private void buttonParse_Click(object sender, EventArgs e)
        {
            string address = null;
            string res = null;

            this.pattern = textBoxPattern.Text;

            if (radioButtonImdb.Checked == true)
            {
                address = textBoxImdb.Text;
            }
            else if(radioButtonWiki.Checked == true)
            {
                address = textBoxWiki.Text;
            }

            res = get(address);

            if (res != null)
            {
                if (radioButtonImdb.Checked == true)
                {
                    imdbParse(res);
                }
                else if (radioButtonWiki.Checked == true)
                {
                    wikiParse(res);
                }
                

                if (this.episodes.Count > 0)
                {

                    preview(this.episodes, pattern);
                }
            }
            else
            {
                string msg = "Sory! I can't connect to the website.";
                string cpt = "Connection Error";

                MessageBox.Show(msg, cpt, MessageBoxButtons.OK);
            }
        }

        private void textBoxImdb_Enter(object sender, EventArgs e)
        {
            radioButtonImdb.Checked = true;
        }

        private void textBoxWiki_Enter(object sender, EventArgs e)
        {
            radioButtonWiki.Checked = true;
        }
    }
}
