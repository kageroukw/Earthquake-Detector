using System.ComponentModel;
using Xamarin.Forms;
using Earthquake_Detector.ViewModels;

namespace Earthquake_Detector.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}