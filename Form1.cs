using LUNA.Properties;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Reflection.Emit;
using System.Drawing.Drawing2D;

namespace LUNA
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        public ContextMenuStrip menu;

        private void newButton_Click(object sender, EventArgs e)
        {
            if (textBox.Text != "")
            {
                // readability reasons
                var warning = MessageBox.Show("Are you sure you want to create a new file? Any unsaved work you've made will be lost forever", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (warning == DialogResult.Yes)
                {
                    textBox.Text = string.Empty;
                }
            }
            else
            {
                textBox.Text = string.Empty;
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter =
                "Text files (*.txt)|*.txt|Markdown files (*.md)|*.md|Rich text files (*.rtf)|*.rtf|Hypertext Markup Language (*.html)|*.html|Batch File (*.bat)|*.bat";
            saveFileDialog1.Title = "Save file";
            var result = saveFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog1.FileName, textBox.Text);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // maybe add dropdown menu here eventually
        }

        // this is the open button i just forgot to name it first
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter =
                "Text files (*.txt)|*.txt|Markdown files (*.md)|*.md|Rich text files (*.rtf)|*.rtf|Hypertext Markup Language (*.html)|*.html|Batch File (*.bat)|*.bat";
            openFileDialog1.Title = "Open file";
            var result = openFileDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                var text = File.ReadAllText(openFileDialog1.FileName);
                textBox.Text = text;

            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            int charCount = textBox.Text.Length;
            charCountLabel.Text = $"CHARACTERS: {charCount}";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // throw new System.NotImplementedException();
        }

        // function from here, thank god, credit to this person
        // https://learn.microsoft.com/en-us/answers/questions/530055/how-to-color-a-specific-string-s-in-richtextbox-te
        void HighlightPhrase(RichTextBox box, string phrase, Color color)
        {
            string results = "";
            int pos = box.SelectionStart;
            string s = box.Text;
            for (int ix = 0; ix < s.Length; ix++)
            {
                int jx = s.IndexOf(phrase, ix, StringComparison.CurrentCultureIgnoreCase);
                if (jx < 0)
                {
                    break;
                }
                else
                {
                    box.SelectionStart = jx;
                    box.SelectionLength = phrase.Length;
                    box.SelectionColor = color;
                    ix = jx + 1;
                    results += jx;
                }
            }

            box.SelectionStart = 0;
            box.SelectionLength = 0;

        }

        private void render_Click(object sender, EventArgs e)
        {
            List<string> MarkdownBaseElements = new List<string>
            {
                "#", "##", "###", "~~", "*", "**", "---", ">", "-", "`", "```", "|", "==", "\\", "[", "]", "(", ")", "!"
            };

            List<string> Letters = new List<string>
            {
                "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U","V", "W", "X", "Y", "Z"
            };

            // text     
            foreach (var letter in Letters) // thank you chatgpt
            {
                HighlightPhrase(textBox, letter, Color.Black);
            }

            // headers
            HighlightPhrase(textBox, MarkdownBaseElements[0], Color.Firebrick);
            HighlightPhrase(textBox, MarkdownBaseElements[1], Color.Firebrick);
            HighlightPhrase(textBox, MarkdownBaseElements[2], Color.Firebrick);

            //strikethrough
            HighlightPhrase(textBox, MarkdownBaseElements[3], Color.Teal);

            //italics
            HighlightPhrase(textBox, MarkdownBaseElements[4], Color.CornflowerBlue);

            // bold
            HighlightPhrase(textBox, MarkdownBaseElements[5], Color.Fuchsia);

            // horizontal rule
            HighlightPhrase(textBox, MarkdownBaseElements[6], Color.Purple);
            
            // dash / list bullet
            HighlightPhrase(textBox, MarkdownBaseElements[8], Color.Purple);

            // blockquote 
            HighlightPhrase(textBox, MarkdownBaseElements[7], Color.Lime);
            
            // codeblock
            HighlightPhrase(textBox, MarkdownBaseElements[9], Color.Crimson);
            HighlightPhrase(textBox, MarkdownBaseElements[10], Color.Crimson);

            // pipe character
            HighlightPhrase(textBox, MarkdownBaseElements[11], Color.Blue);

            //highlight
            HighlightPhrase(textBox, MarkdownBaseElements[12], Color.Cyan);

            // escape
            HighlightPhrase(textBox, MarkdownBaseElements[13], Color.Fuchsia);

            // markdown url
            HighlightPhrase(textBox, MarkdownBaseElements[14], Color.BlueViolet);
            HighlightPhrase(textBox, MarkdownBaseElements[15], Color.BlueViolet);
            HighlightPhrase(textBox, MarkdownBaseElements[16], Color.BlueViolet);
            HighlightPhrase(textBox, MarkdownBaseElements[17], Color.BlueViolet);
            HighlightPhrase(textBox, MarkdownBaseElements[18], Color.BlueViolet);
        }
        private void button1_Click_2(object sender, EventArgs e)
        {
            About form = new About();
            form.Show();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            Process.Start("https://en.wikipedia.org/wiki/Pineapple");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox.WordWrap = !textBox.WordWrap; // took me a while to make this work

            if (textBox.WordWrap)
            {
                wordwrap.Text = "DISABLE WORD WRAP";
            }
            else wordwrap.Text = "ENABLE WORD WRAP";
        }

        private int time = 0; // psuedo vibe coded
        private void timer1_Tick(object sender, EventArgs e)
        {
            var displaytime = time;

            time += 1;
            label1.Text = "TIME ELAPSED: " + displaytime.ToString() + " SECONDS";
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (button2.Text == "DARK MODE")
            {
                button2.Text = "LIGHT MODE";

                // ty chatgpt for being ANOTHER lifesaver
                this.BackColor = ColorTranslator.FromHtml("#282A36");
                textBox.BackColor = ColorTranslator.FromHtml("#6272A4");
                button2.BackColor = ColorTranslator.FromHtml("#44475A");
                saveButton.BackColor = ColorTranslator.FromHtml("#44475A");
                newButton.BackColor = ColorTranslator.FromHtml("#44475A");
                render.BackColor = ColorTranslator.FromHtml("#44475A");
                button2.BackColor = ColorTranslator.FromHtml("#44475A");
                button1.BackColor = ColorTranslator.FromHtml("#44475A");
                wordwrap.BackColor = ColorTranslator.FromHtml("#44475A");
                openButton.BackColor = ColorTranslator.FromHtml("#44475A");
            }
            else
            {
                button2.Text = "DARK MODE";

                this.BackColor = ColorTranslator.FromHtml("#FF8000");
                textBox.BackColor = Color.Bisque;
                saveButton.BackColor = Color.Chocolate;
                newButton.BackColor = Color.Chocolate;
                render.BackColor = Color.Chocolate;
                button2.BackColor = Color.Chocolate;
                button1.BackColor = Color.Chocolate;
                wordwrap.BackColor = Color.Chocolate;
                openButton.BackColor = Color.Chocolate;
            }
        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {

        }
    }
}