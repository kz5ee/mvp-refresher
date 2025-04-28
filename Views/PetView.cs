using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mvp_refresher.Views
{
    public partial class PetView : Form, IPetView
    {
        private bool isEditing;
        private bool isSuccessful;
        private string message;

        public PetView()
        {
            InitializeComponent();
        }

        public string PetId 
        {
            get { return petIdText.Text; }
            set { petIdText.Text = value; }
        }
        public string PetName 
        {
            get { return petNameText.Text; }
            set { petNameText.Text = value; }
        }
        public string PetType 
        {
            get { return petTypeText.Text; }
            set { petTypeText.Text = value; }
        }
        public string PetColor 
        {
            get { return petColorText.Text; }
            set { petColorText.Text = value; }
        }
        public string SearchValue 
        {
            get { return searchText.Text; }
            set { searchText.Text = value; }
        }
        public bool IsEditing 
        {
            get { return isEditing; }
            set { isEditing = value; }
        }
        public bool IsSuccessful 
        {
            get { return isSuccessful; }
            set { isSuccessful = value; }
        }
        public string Message 
        {
            get { return message; }
            set { message = value; }
        }

        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;

        public void SetPetListBindingSource(BindingSource petList)
        {
            dataGridView1.DataSource = petList;
        }
    }
}
