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
        //----- TAB 1 THE MEMBERS-----//
        private void button1MembersGo_Click(object sender, EventArgs e)
        {
            if (memberList.Count > 0) { return; }


            if (textBox_Member1.Text != string.Empty)
            {
                memberList.Add(textBox_Member1.Text);
                FamilyMembers Member = new FamilyMembers(textBox_Member1.Text);
                family.Add(Member);
                label_Member1.Text = textBox_Member1.Text;
                label_Member1.ForeColor = Color.Black;

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
                Label_Member2.Text = textBox_Member2.Text;
                Label_Member2.ForeColor = Color.Black;
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
                label_Member3.Text = textBox_Member3.Text;
                label_Member3.ForeColor = Color.Black;
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
                label_Member4.Text = textBox_Member4.Text;
                label_Member4.ForeColor = Color.Black;
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
                label_Member5.Text = textBox_Member5.Text;
                label_Member5.ForeColor = Color.Black;
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
                label_Member6.Text = textBox_Member6.Text;
                label_Member6.ForeColor = Color.Black;
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
                label_Member7.Text = textBox_Member6.Text;
                label_Member7.ForeColor = Color.Black;
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
                label_Member8.Text = textBox_Member8.Text;
                label_Member8.ForeColor = Color.Black;
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
                label_Member9.Text = textBox_Member9.Text;
                label_Member9.ForeColor = Color.Black;
            }
            else
            {
                textBox_Member9.Visible = false;
            }

            toolStripCombox_MemberList.Items.AddRange(memberList.ToArray());

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

        private void DeleteChore(string chore)
        {
            foreach (var member in family)
            {
                if (member.name == toolStripCombox_MemberList.SelectedItem.ToString())
                {
                    member.ChoreList.Remove(chore);
                }
            }
        }
        //----- CHORES TAB -----//
        private void toolStripCombox_MemberList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (toolStripCombox_MemberList.SelectedIndex > -1)
            {
                foreach (Control control in groupBox2.Controls)
                {
                    if (control is Button button)
                    {
                        control.BackColor = Color.MistyRose;
                    }
                }
                groupBox2.Enabled = true;

                foreach (FamilyMembers member in family)
                {
                    if (member.name == toolStripCombox_MemberList.SelectedItem.ToString())
                    {
                        foreach (var chore in member.ChoreList)
                        {
                            foreach (Control control in groupBox2.Controls)
                            {
                                if (control is Button button && control.Text == chore)
                                {
                                    control.BackColor = Color.AliceBlue;
                                }
                            }

                        }
                    }
                }
            }

        }




        //------ CHORES BUTTON HANDLERS -----//
        private void button_Laundry_Click(object sender, EventArgs e)
        {
            if (button_Laundry.BackColor == Color.AliceBlue)
            {
                button_Laundry.BackColor = Color.MistyRose;
                DeleteChore(button_Laundry.Text);

            }
            else
            {
                button_Laundry.BackColor = Color.AliceBlue;
                AssignChore(button_Laundry.Text.ToString());
            }

        }
        private void button_Trash_Click(object sender, EventArgs e)
        {
            if (button_Trash.BackColor == Color.AliceBlue)
            {
                button_Trash.BackColor = Color.MistyRose;
                DeleteChore(button_Trash.Text);

            }
            else
            {
                button_Trash.BackColor = Color.AliceBlue;
                AssignChore(button_Trash.Text.ToString());
            }
        }

        private void button_Dishes_Click(object sender, EventArgs e)
        {
            if (button_Dishes.BackColor == Color.AliceBlue)
            {
                button_Dishes.BackColor = Color.MistyRose;
                DeleteChore(button_Dishes.Text);

            }
            else
            {
                button_Dishes.BackColor = Color.AliceBlue;
                AssignChore(button_Dishes.Text.ToString());
            }
        }
        private void button_Disinfect_Click(object sender, EventArgs e)
        {
            if (button_Disinfect.BackColor == Color.AliceBlue)
            {
                button_Disinfect.BackColor = Color.MistyRose;
                DeleteChore(button_Disinfect.Text);

            }
            else
            {
                button_Disinfect.BackColor = Color.AliceBlue;
                AssignChore(button_Disinfect.Text.ToString());
            }
        }

        private void button_LitterBox_Click(object sender, EventArgs e)
        {
            if (button_LitterBox.BackColor == Color.AliceBlue)
            {
                button_LitterBox.BackColor = Color.MistyRose;
                DeleteChore(button_LitterBox.Text);
            }
            else
            {
                button_LitterBox.BackColor = Color.AliceBlue;
                AssignChore(button_LitterBox.Text.ToString());
            }
        }

        private void button_Vacuum_Click(object sender, EventArgs e)
        {
            if (button_Vacuum.BackColor == Color.AliceBlue)
            {
                button_Vacuum.BackColor = Color.MistyRose;
                DeleteChore(button_Vacuum.Text);

            }
            else
            {
                button_Vacuum.BackColor = Color.AliceBlue;
                AssignChore(button_Vacuum.Text.ToString());
            }
        }

        private void button_Organize_Click(object sender, EventArgs e)
        {
            if (button_Organize.BackColor == Color.AliceBlue)
            {
                button_Organize.BackColor = Color.MistyRose;
                DeleteChore(button_Organize.Text);

            }
            else
            {
                button_Organize.BackColor = Color.AliceBlue;
                AssignChore(button_Organize.Text.ToString());
            }
        }

        private void button_Mop_Click(object sender, EventArgs e)
        {
            if (button_Mop.BackColor == Color.AliceBlue)
            {
                button_Mop.BackColor = Color.MistyRose;
                DeleteChore(button_Mop.Text);

            }
            else
            {
                button_Mop.BackColor = Color.AliceBlue;
                AssignChore(button_Mop.Text.ToString());
            }
        }

        private void button_BrushUp_Click(object sender, EventArgs e)
        {
            if (button_BrushUp.BackColor == Color.AliceBlue)
            {
                button_BrushUp.BackColor = Color.MistyRose;
                DeleteChore(button_BrushUp.Text);

            }
            else
            {
                button_BrushUp.BackColor = Color.AliceBlue;
                AssignChore(button_BrushUp.Text.ToString());
            }
        }

        private void button_WaterPlants_Click(object sender, EventArgs e)
        {
            if (button_WaterPlants.BackColor == Color.AliceBlue)
            {
                button_WaterPlants.BackColor = Color.MistyRose;
                DeleteChore(button_WaterPlants.Text);

            }
            else
            {
                button_WaterPlants.BackColor = Color.AliceBlue;
                AssignChore(button_WaterPlants.Text.ToString());
            }
        }

        private void button_Homework_Click(object sender, EventArgs e)
        {
            if (button_Homework.BackColor == Color.AliceBlue)
            {
                button_Homework.BackColor = Color.MistyRose;
                DeleteChore(button_Homework.Text);

            }
            else
            {
                button_Homework.BackColor = Color.AliceBlue;
                AssignChore(button_Homework.Text.ToString());
            }
        }

        private void button_Dust_Click(object sender, EventArgs e)
        {
            if (button_Dust.BackColor == Color.AliceBlue)
            {
                button_Dust.BackColor = Color.MistyRose;
                DeleteChore(button_Dust.Text);

            }
            else
            {
                button_Dust.BackColor = Color.AliceBlue;
                AssignChore(button_Dust.Text.ToString());
            }
        }

        private void button_Shower_Click(object sender, EventArgs e)
        {
            if (button_Shower.BackColor == Color.AliceBlue)
            {
                button_Shower.BackColor = Color.MistyRose;
                DeleteChore(button_Shower.Text);

            }
            else
            {
                button_Shower.BackColor = Color.AliceBlue;
                AssignChore(button_Shower.Text.ToString());
            }
        }

        private void button_FeedAnimals_Click(object sender, EventArgs e)
        {
            if (button_FeedAnimals.BackColor == Color.AliceBlue)
            {
                button_FeedAnimals.BackColor = Color.MistyRose;
                DeleteChore(button_FeedAnimals.Text);

            }
            else
            {
                button_FeedAnimals.BackColor = Color.AliceBlue;
                AssignChore(button_FeedAnimals.Text.ToString());
            }
        }

        private void button_Other_Click(object sender, EventArgs e)
        {
            if (button_Other.BackColor == Color.AliceBlue)
            {
                button_Other.BackColor = Color.MistyRose;
                DeleteChore(button_Other.Text);

            }
            else
            {
                button_Other.BackColor = Color.AliceBlue;
                AssignChore(button_Other.Text.ToString());
            }
        }              
    }

}
        
        
          
    
    
    




