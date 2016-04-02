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

namespace CharacterFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Character cChar = new Character();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rand = new Random();

            numericUpDown1.Value = rand.Next(100);
            numericUpDown2.Value = rand.Next(100);
            numericUpDown3.Value = rand.Next(100);
            numericUpDown4.Value = rand.Next(100);
            numericUpDown5.Value = rand.Next(100);
            numericUpDown6.Value = rand.Next(100);
            numericUpDown7.Value = rand.Next(100);
            numericUpDown8.Value = rand.Next(100);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex > -1)
            {
                Character c = (Character)listBox1.Items[listBox1.SelectedIndex];
                FNameBox.Text = c.Name;
                LNameBox.Text = c.LastName;
                AgeBox.Value = c.Age;
                comboBox1.Text = c.Race;

                numericUpDown1.Value = c.Skill.Brave;
                numericUpDown2.Value = c.Skill.Cheat;
                numericUpDown3.Value = c.Skill.Disguise;
                numericUpDown4.Value = c.Skill.Endur;
                numericUpDown5.Value = c.Skill.Heal;
                numericUpDown6.Value = c.Skill.Know;
                numericUpDown7.Value = c.Skill.Lead;
                numericUpDown8.Value = c.Skill.Steal;
            }
        }

        private void hideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FNameBox.Text = "";
            LNameBox.Text = "";
            AgeBox.Value = 0;


            numericUpDown1.Value = 0;
            numericUpDown2.Value = 0;
            numericUpDown3.Value = 0;
            numericUpDown4.Value = 0;
            numericUpDown5.Value = 0;
            numericUpDown6.Value = 0;
            numericUpDown7.Value = 0;
            numericUpDown8.Value = 0;
            listBox1.Items.Clear();
        }

        private void addCharactersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Character c = new Character();
            c.Name = FNameBox.Text;
            c.LastName = LNameBox.Text;
            c.Age = AgeBox.Value;
            c.Race = comboBox1.Text;

            c.Skill.Brave = numericUpDown1.Value;
            c.Skill.Cheat = numericUpDown2.Value;
            c.Skill.Disguise = numericUpDown3.Value;
            c.Skill.Endur = numericUpDown4.Value;
            c.Skill.Heal = numericUpDown5.Value;
            c.Skill.Know = numericUpDown6.Value;
            c.Skill.Lead = numericUpDown7.Value;
            c.Skill.Steal = numericUpDown8.Value;

            FNameBox.Text = "";
            LNameBox.Text = "";
            AgeBox.Value = 0;
            comboBox1.SelectedIndex = 6;

            numericUpDown1.Value = 0;
            numericUpDown2.Value = 0;
            numericUpDown3.Value = 0;
            numericUpDown4.Value = 0;
            numericUpDown5.Value = 0;
            numericUpDown6.Value = 0;
            numericUpDown7.Value = 0;
            numericUpDown8.Value = 0;
            listBox1.Items.Add(c);
        }

        private void Menu_File_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_DropDown(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = comboBox1.FindStringExact("None");
        }

        private void skillsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = skillsToolStripMenuItem.Checked;
        }

        private void Menu_File_Open_Click(object sender, EventArgs e)
        {
            //Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            /*openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;*/

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Insert code to read the stream here.
                StreamReader read = new StreamReader(openFileDialog1.FileName);
                while (!read.EndOfStream)
                {
                    string line = read.ReadLine(), sub;
                    int start = 0;
                    Character c = new Character();
                    for (int x = 0; x < 12; x++)
                    {
                        int end = line.IndexOf(',', start);
                        sub = line.Substring(start, end-start);

                        switch(x)
                        {
                            case 0:
                                c.Name = sub;
                                break;
                            case 1:
                                c.LastName = sub;
                                break;
                            case 2:
                                c.Age = decimal.Parse(sub);
                                break;
                            case 3:
                                c.Race = sub;
                                break;
                            case 4:
                                c.Skill.Brave = decimal.Parse(sub);
                                break;
                            case 5:
                                c.Skill.Cheat = decimal.Parse(sub);
                                break;
                            case 6:
                                c.Skill.Disguise = decimal.Parse(sub);
                                break;
                            case 7:
                                c.Skill.Endur = decimal.Parse(sub);
                                break;
                            case 8:
                                c.Skill.Heal = decimal.Parse(sub);
                                break;
                            case 9:
                                c.Skill.Know = decimal.Parse(sub);
                                break;
                            case 10:
                                c.Skill.Lead = decimal.Parse(sub);
                                break;
                            case 11:
                                c.Skill.Steal = decimal.Parse(sub);
                                break;
                        }
                        start = end+1;
                    }
                    listBox1.Items.Add(c);
                }


            }
        }

        private void deselectCharactersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBox1.SelectedIndex = -1;
            FNameBox.Text = "";
            LNameBox.Text = "";
            AgeBox.Value = 0;
            comboBox1.SelectedIndex = 6;

            numericUpDown1.Value = 0;
            numericUpDown2.Value = 0;
            numericUpDown3.Value = 0;
            numericUpDown4.Value = 0;
            numericUpDown5.Value = 0;
            numericUpDown6.Value = 0;
            numericUpDown7.Value = 0;
            numericUpDown8.Value = 0;
        }

        private void removeCharacterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex > -1)
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            listBox1.SelectedIndex = -1;
            FNameBox.Text = "";
            LNameBox.Text = "";
            AgeBox.Value = 0;
            comboBox1.SelectedIndex = 6;

            numericUpDown1.Value = 0;
            numericUpDown2.Value = 0;
            numericUpDown3.Value = 0;
            numericUpDown4.Value = 0;
            numericUpDown5.Value = 0;
            numericUpDown6.Value = 0;
            numericUpDown7.Value = 0;
            numericUpDown8.Value = 0;
        }

        private void File_Menu_Save_Click(object sender, EventArgs e)
        {
            Stream myStream;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            /*saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;*/
            saveFileDialog1.AddExtension = true;
            saveFileDialog1.DefaultExt = ".txt";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = saveFileDialog1.OpenFile()) != null)
                {
                    // Code to write the stream goes here.
                    StreamWriter write = new StreamWriter(myStream);
                    for (int x = 0; x < listBox1.Items.Count; x++)
                    {
                        Character temp = (Character)listBox1.Items[x];
                        string line;
                        line = temp.Name + ',' + temp.LastName + ',' +
                            temp.Age + ',' + temp.Race + ',' + temp.Skill.Brave
                             + ',' + temp.Skill.Cheat + ',' + temp.Skill.Disguise
                              + ',' + temp.Skill.Endur + ',' + temp.Skill.Heal
                               + ',' + temp.Skill.Know + ',' + temp.Skill.Lead
                                + ',' + temp.Skill.Steal+ ',';
                        write.WriteLine(line);
                    }
                    write.Close();
                    myStream.Close();
                }
            }
        }

        private void updateCharactersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex > -1)
            {
                Character c = (Character)listBox1.Items[listBox1.SelectedIndex];
                c.Name = FNameBox.Text;
                c.LastName = LNameBox.Text;
                c.Age = AgeBox.Value;
                c.Race = comboBox1.Text;

                c.Skill.Brave = numericUpDown1.Value;
                c.Skill.Cheat = numericUpDown2.Value;
                c.Skill.Disguise = numericUpDown3.Value;
                c.Skill.Endur = numericUpDown4.Value;
                c.Skill.Heal = numericUpDown5.Value;
                c.Skill.Know = numericUpDown6.Value;
                c.Skill.Lead = numericUpDown7.Value;
                c.Skill.Steal = numericUpDown8.Value;
                listBox1.Items[listBox1.SelectedIndex] = c;
            }
        }
    }
}
