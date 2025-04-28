using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mvp_refresher.Models;
using mvp_refresher.Views;

namespace mvp_refresher.Presenters
{
    public class PetPresenter
    {
        private IPetView view;
        private IPetRepository repository;
        private BindingSource petsBindingSource;
        private IEnumerable<PetModel> petList;

        public PetPresenter()
        {
            petsBindingSource = new BindingSource();
            this.view = view;
            this.repository = repository;

            //Subscribe event handlers to methods
            this.view.SearchEvent += SearchPet;
            this.view.AddNewEvent += AddNewPet;
            this.view.EditEvent += EditPet;
            this.view.DeleteEvent += DeletePet;
            this.view.SaveEvent += SavePet;
            this.view.CancelEvent += CancelAction;

            //Set binding source
            this.view.SetPetListBindingSource(petsBindingSource);

            //Load pet list view
            LoadAllPetList();

            //Show the view
            this.view.Show();
        }

        //Methods
        private void LoadAllPetList()
        {
            petList = repository.GetAll();
            petsBindingSource.DataSource = petList;
        }

        private void CancelAction(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void SavePet(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void DeletePet(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void EditPet(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void AddNewPet(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void SearchPet(object? sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);

            if (!emptyValue)
                petList = repository.GetByValue(this.view.SearchValue);
            else petList = repository.GetAll();
            petsBindingSource.DataSource = petList;
        }
    }
}
