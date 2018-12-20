﻿using System;
using Microsoft.MobCAT.Forms.Pages;
using News.ViewModels;
using NewsAPI.Models;
using Xamarin.Forms;

namespace News.Pages
{
    public partial class NewsBySourcePage : BaseContentPage<NewsBySourceViewModel>
    {
        public NewsBySourcePage()
        {
            InitializeComponent();
        }

        void Handle_ItemSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            var selectedArticle = (Article)e.SelectedItem;
            ((ListView)sender).SelectedItem = null;

            if (selectedArticle != null)
            {
                // TODO: move to view model as a command
                // TODO: parse and validate url
                var validUri = new Uri(selectedArticle.Url);
                Device.OpenUri(validUri);
            }
        }
    }
}