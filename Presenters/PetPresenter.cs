using System;
using System.Collections.Generic;
using System.Drawing;
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

        public PetPresenter(IPetView view, IPetRepository repository)
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
            CleanViewFields();
        }

        private void SavePet(object? sender, EventArgs e)
        {
            var model = new PetModel();
            model.Id = Convert.ToInt32(view.PetId);
            model.Name = view.PetName;
            model.Type = view.PetType;
            model.Color = view.PetColor;

            try
            {
                new Common.ModelDataValidation().Validate(model);

                if(view.IsEditing)
                {
                    repository.Edit(model);
                    view.Message = "Pet edited successfully";
                }
                else
                {
                    repository.Add(model);
                    view.Message = "Pet added successfully";
                }
                view.IsSuccessful = true;
                LoadAllPetList();
                CleanViewFields();
            }
            catch (Exception ex) 
            {
                view.IsSuccessful = false;
                view.Message = ex.Message;
            }
        }

        private void CleanViewFields()
        {
            view.PetId = "0";
            view.PetName = string.Empty;
            view.PetType = string.Empty;
            view.PetColor = string.Empty;
        }

        private void DeletePet(object? sender, EventArgs e)
        {
            try
            {
                var pet = (PetModel)petsBindingSource.Current;
                repository.Delete(pet.Id);
                view.IsSuccessful = true;
                view.Message = "Pet deleted successfully";
                LoadAllPetList();
            }
            catch (Exception ex)
            {
                view.IsSuccessful=false;
                view.Message = "An error occurred while deleting pet.";
            }

        }

        private void EditPet(object? sender, EventArgs e)
        {
            var pet = (PetModel)petsBindingSource.Current;
            view.PetId = pet.Id.ToString();
            view.PetName = pet.Name;
            view.PetType = pet.Type;
            view.PetColor = pet.Color;
            view.IsEditing = true;
        }

        private void AddNewPet(object? sender, EventArgs e)
        {
            view.IsEditing = false;
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
