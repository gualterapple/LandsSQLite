﻿using System;

namespace Lands.ViewModels
{
	using GalaSoft.MvvmLight.Command;
	using Views;
	using Models;
	using System.Windows.Input;
	using Xamarin.Forms;

	public class LandItemViewModel : Land
    {
        #region Commands
		public ICommand SelectLandCommand
		{
			get
            {
				return new RelayCommand(SelectLand);
            }
        }

		private async void SelectLand()
        {
			MainViewModel.GetInstance().Land = new LandViewModel(this);
			await App.Navigator.PushAsync(new LandTabbedPage());
        }

		#endregion
    }
}
