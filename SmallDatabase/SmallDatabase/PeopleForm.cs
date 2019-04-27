using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmallDatabase
{
    
    public partial class PeopleForm : Form
    {
        List<PersonModel> people = new List<PersonModel>();
        public PeopleForm()
        {
            InitializeComponent();
            LoadPeopleList();
        }
        private void LoadPeopleList()
        {
            people = SqliteDataAccess.LoadPeople();

            WireUpPeopleList();
        }

        private void WireUpPeopleList()
        {
            PeopleListBox.DataSource = null;
            PeopleListBox.DataSource = people;
            PeopleListBox.DisplayMember = "FullName";
        }

        private void RefreshList_Click(object sender, EventArgs e)
        {
            LoadPeopleList();
        }

        private void AddPerson_Click(object sender, EventArgs e)
        {
            PersonModel p = new PersonModel();
            {
                p.FirstName = FName.Text;
                p.LastName = LName.Text;

                SqliteDataAccess.SavePerson(p);

                FName.Text = "";
                LName.Text = "";
                    




            }

        }

      
    }
}

