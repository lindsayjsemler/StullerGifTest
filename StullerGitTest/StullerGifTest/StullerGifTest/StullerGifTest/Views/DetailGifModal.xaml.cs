using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using StullerGifTest.Models;
using StullerGifTest.ViewModels;
using Xamarin.Forms;

namespace StullerGifTest.Views
{	
	public partial class DetailGifModal : ContentPage
    {
        public GIFModel gifModel { get; set; }
        public DetailGifModal(GIFModel _gifModel)
        {
            gifModel = _gifModel;
            InitializeComponent();

            //Set the binding context when navigated to and make sure to give the string to the viewmodel
            BindingContext = new DetailGifViewModel(gifModel);
        }

        /*protected override void OnAppearing()
        {
            //On Appearing Start the Animation
            GifImage.IsAnimationPlaying = true;

            base.OnAppearing();
        }

        protected override void OnDisappearing()
        {
            //stop this animation when the view is closing
            if (GifImage.IsAnimationPlaying)
            {
                GifImage.CancelAnimations();
            }

            base.OnDisappearing();
        }*/
    }
}

