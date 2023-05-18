using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinElementsApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Elementspage1 : ContentPage
    {
        public object entry;
        public object editor;
        private object text;
        private string count;

        public Elementspage1()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            this.BackgroundColor = Color.CadetBlue;
       }

        public object GetEntry()
        {
            return entry;
        }

        private void SearchBar_TextChanged(object sender,TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(e.NewTextValue))
            {
                string empty = string.Empty;
                return;
            }
            char letter = e.NewTextValue[0];
            entry = "letter count:  " + count;
            }
        }
    }