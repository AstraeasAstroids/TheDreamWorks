using System.Collections.Generic;
using System.Linq.Expressions;

namespace TheDreamWorks
{
    
    
    public struct FamilyMembers
        {
        public string name;
        public List<string> ChoreList = new List<string>();

        public FamilyMembers(string Name)
        {
            name = Name;
        }
    }
    public partial class Form1 : Form
    {
        public List<FamilyMembers> family = new List<FamilyMembers>();
        public List<string> memberList = new List<string>();
        public List<string> buttons = new List<string>();

        public object Button1 { get; private set; }
        public object ChoresButtons { get; private set; }
        public Form1()

        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private ListBox GetListBox1()
        {
            return listBox1;
        }

        private void button1MembersGo_Click(object sender, EventArgs e)
        {
            if (memberList.Count > 0) { return; }


            if (textBox_Member1.Text != string.Empty)
            {
                memberList.Add(textBox_Member1.Text);
                FamilyMembers Member = new FamilyMembers(textBox_Member1.Text);
                family.Add(Member);
            }
            else
            {
                textBox_Member1.Visible = false;
            }
            if (textBox_Member2.Text != string.Empty)
            {
                memberList.Add(textBox_Member2.Text);
                FamilyMembers Member2 = new FamilyMembers(textBox_Member2.Text);
                family.Add(Member2);
            }
            else
            {
                textBox_Member2.Visible = false;
            }
            if (textBox_Member3.Text != string.Empty)
            {
                memberList.Add(textBox_Member3.Text);
                FamilyMembers Member3 = new FamilyMembers(textBox_Member3.Text);
                family.Add(Member3);
            }
            else
            {
                textBox_Member3.Visible = false;
            }
            if (textBox_Member4.Text != string.Empty)
            {
                memberList.Add(textBox_Member4.Text);
                FamilyMembers Member4 = new FamilyMembers(textBox_Member4.Text);
                family.Add(Member4);
            }
            else
            {
                textBox_Member4.Visible = false;
            }
            if (textBox_Member5.Text != string.Empty)
            {
                memberList.Add(textBox_Member5.Text);
                FamilyMembers Member5 = new FamilyMembers(textBox_Member5.Text);
                family.Add(Member5);
            }
            else
            {
                textBox_Member5.Visible = false;
            }
            if (textBox_Member6.Text != string.Empty)
            {
                memberList.Add(textBox_Member6.Text);
                FamilyMembers Member6 = new FamilyMembers(textBox_Member6.Text);
                family.Add(Member6);
            }
            else
            {
                textBox_Member6.Visible = false;
            }
            if (textBox_Member7.Text != string.Empty)
            {

                memberList.Add(textBox_Member7.Text);
                FamilyMembers Member7 = new FamilyMembers(textBox_Member7.Text);
                family.Add(Member7);
            }
            else
            {
                textBox_Member7.Visible = false;
            }
            if (textBox_Member8.Text != string.Empty)
            {
                memberList.Add(textBox_Member8.Text);
                FamilyMembers Member8 = new FamilyMembers(textBox_Member8.Text);
                family.Add(Member8);
            }
            else
            {
                textBox_Member8.Visible = false;
            }
            if (textBox_Member9.Text != string.Empty)
            {
                memberList.Add(textBox_Member9.Text);
                FamilyMembers Member9 = new FamilyMembers(textBox_Member9.Text);
                family.Add(Member9);
            }
            else
            {
                textBox_Member9.Visible = false;
            }


            toolStripCombox_MemberList.Items.AddRange(memberList.ToArray());
            {

            }



        }
        private void button2_Click(object sender, EventArgs e)
        {
            button2.BackColor = Color.LightCyan;
            AssignChore(toolStripCombox_MemberList.SelectedItem.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.BackColor = Color.LightCyan;
            AssignChore(toolStripCombox_MemberList.SelectedItem.ToString());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.BackColor = Color.LightCyan;
            AssignChore(toolStripCombox_MemberList.SelectedItem.ToString());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.BackColor = Color.LightCyan;
            AssignChore(toolStripCombox_MemberList.SelectedItem.ToString());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.BackColor = Color.LightCyan;
            AssignChore(toolStripCombox_MemberList.SelectedItem.ToString());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button7.BackColor = Color.LightCyan;
            AssignChore(toolStripCombox_MemberList.SelectedItem.ToString());
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button8.BackColor = Color.LightCyan;
            AssignChore(toolStripCombox_MemberList.SelectedItem.ToString());
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button9.BackColor = Color.LightCyan;
            AssignChore(toolStripCombox_MemberList.SelectedItem.ToString());
        }

        private void button10_Click(object sender, EventArgs e)
        {
            button10.BackColor = Color.LightCyan;
            AssignChore(toolStripCombox_MemberList.SelectedItem.ToString());
        }

        private void button11_Click(object sender, EventArgs e)
        {
            button11.BackColor = Color.LightCyan;
            AssignChore(toolStripCombox_MemberList.SelectedItem.ToString());
        }

        private void button12_Click(object sender, EventArgs e)
        {
            button12.BackColor = Color.LightCyan;
            AssignChore(toolStripCombox_MemberList.SelectedItem.ToString());
        }

        private void button13_Click(object sender, EventArgs e)
        {
            button13.BackColor = Color.LightCyan;
            AssignChore(toolStripCombox_MemberList.SelectedItem.ToString());
        }

        private void button14_Click(object sender, EventArgs e)
        {
            button14.BackColor = Color.LightCyan;
            AssignChore(toolStripCombox_MemberList.SelectedItem.ToString());
        }

        private void button15_Click(object sender, EventArgs e)
        {
            button15.BackColor = Color.LightCyan;
            AssignChore(toolStripCombox_MemberList.SelectedItem.ToString());
        }

        private void button16_Click(object sender, EventArgs e)
        {
            button16.BackColor = Color.LightCyan;
            AssignChore(toolStripCombox_MemberList.SelectedItem.ToString());

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1_SelectedIndexChanged(sender, e, memberList);

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e, object memberList)
        {
            throw new NotImplementedException();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e, List<MemberListBinding> memberList)
        {
            memberList = new List<MemberListBinding>();
        }

        private void AssignChore(string chore)
        {
            foreach (var member in family)
            {
                if (member.name == toolStripCombox_MemberList.SelectedItem.ToString())
                {
                    member.ChoreList.Add(chore);
                }
            }
        }

        private void toolStripCombox_MemberList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (toolStripCombox_MemberList.SelectedIndex > 0)
            {
                foreach (Control control in groupBox2.Controls)
                {
                    if (control is Button button)
                    {
                        button.BackColor = Color.White;
                    }
                }
                groupBox2.Enabled = true;

                foreach (FamilyMembers member in family)
                {
                    if (member.name == toolStripCombox_MemberList.SelectedItem.ToString())
                    {
                        foreach (var chore in member.ChoreList)
                        {
                            //iterate through each of the chores buttons
                            //if match change button color

                            foreach(Control control in groupBox2.Controls)
                            {
                                if (control is Button button)
                                {
                                    button.BackColor = Color.Azure;
                                }
                            }

                        }
                    }
                }
            }
           
        }
    }

}
        
        
          
    
    
    




