﻿using AndreasReitberger.Models;
using MahApps.Metro.Controls.Dialogs;
using PrintCostCalculator3d.Models.Settings;
using PrintCostCalculator3d.Resources.Localization;
using PrintCostCalculator3d.Utilities;
using System;
using System.Windows.Input;

namespace PrintCostCalculator3d.ViewModels._3dPrinting
{
    public class NewSupplierViewModel : ViewModelBase
    {
        #region Variables
        readonly IDialogCoordinator _dialogCoordinator;
        #endregion

        #region Properties
        bool _isEdit;
        public bool IsEdit
        {
            get => _isEdit;
            set
            {
                if (value == _isEdit)
                    return;

                _isEdit = value;
                OnPropertyChanged();
            }
        }

        string _name = string.Empty;
        public string Name
        {
            get => _name;
            set
            {
                if (_name == value) return;
                _name = value;
                OnPropertyChanged();
            }
        }

        Guid _id = Guid.NewGuid();
        public Guid Id
        {
            get => _id;
            set
            {
                if (_id == value) return;  
                _id = value;
                OnPropertyChanged();
                
            }
        }

        string _debitorNumber = string.Empty;
        public string DebitorNumber
        {
            get => _debitorNumber;
            set
            {
                if (_debitorNumber == value) return;
                _debitorNumber = value;
                OnPropertyChanged();
                
            }
        }

        string _shopUri = string.Empty;
        public string ShopUri
        {
            get => _shopUri;
            set
            {
                if (_shopUri == value) return;
                _shopUri = value;
                OnPropertyChanged();
                
            }
        }

        bool _isActive = true;
        public bool isActive
        {
            get => _isActive;
            set
            {
                if (_isActive == value) return;
                _isActive = value;
                OnPropertyChanged();
                
            }
        }
        #endregion

        #region Constructor
        public NewSupplierViewModel(Action<NewSupplierViewModel> saveCommand, Action<NewSupplierViewModel> cancelHandler, IDialogCoordinator dialogCoordinator, Supplier supplier = null)
        {
            SaveCommand = new RelayCommand(p => saveCommand(this));
            CancelCommand = new RelayCommand(p => cancelHandler(this));

            _dialogCoordinator = dialogCoordinator;

            IsLicenseValid = false;

            IsEdit = supplier != null;
            try
            {
                LoadItem(supplier ?? new Supplier() { isActive = true });
                logger.Info(string.Format(Strings.EventViewInitFormated, this.GetType().Name));
            }
            catch (Exception exc)
            {
                logger.Error(string.Format(Strings.EventExceptionOccurredFormated, exc.TargetSite, exc.Message));
            }
        }
        #endregion

        #region iCommands & Actions
        public ICommand LoadFromManufacturerCommand
        {
            get => new RelayCommand(p => LoadFromManufacturerAction());
        }
        async void LoadFromManufacturerAction()
        {
            try
            {
                var _dialog = new CustomDialog() { Title = Strings.Manufacturers };
                var newViewModel = new SelectManufacturerViewModel(async instance =>
                {
                    await _dialogCoordinator.HideMetroDialogAsync(this, _dialog);
                    this.Name = instance.SelectedManufacturer.Name;
                    this.DebitorNumber = instance.SelectedManufacturer.DebitorNumber;
                    this.isActive = instance.SelectedManufacturer.isActive;
                    this.ShopUri = instance.SelectedManufacturer.Website;

                }, instance =>
                {
                    _dialogCoordinator.HideMetroDialogAsync(this, _dialog);
                },
                _dialogCoordinator
                );

                _dialog.Content = new Views._3dPrinting.SelectManufacturerDialog()
                {
                    DataContext = newViewModel
                };
                await _dialogCoordinator.ShowMetroDialogAsync(this, _dialog);
            }
            catch (Exception exc)
            {
                logger.Error(string.Format(Strings.EventExceptionOccurredFormated, exc.TargetSite, exc.Message));
                await _dialogCoordinator.ShowMessageAsync(this,
                    Strings.DialogExceptionHeadline,
                    string.Format(Strings.DialogExceptionFormatedContent, exc.Message)
                    );
            }
        }
        public ICommand SaveCommand { get; }

        public ICommand CancelCommand { get; }
        #endregion

        #region Methods
        void LoadItem(Supplier supplier)
        {
            // Load Id if material is not null
            if (supplier != null && supplier.Id != Guid.Empty)
                Id = supplier.Id;

            Name = supplier.Name;
            DebitorNumber = supplier.DebitorNumber;
            isActive = supplier.isActive;
            ShopUri = supplier.Website;
        }
        #endregion
    }
}
