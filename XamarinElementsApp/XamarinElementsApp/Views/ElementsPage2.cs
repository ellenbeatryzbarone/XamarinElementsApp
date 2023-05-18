using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace XamarinElementsApp.Views
{
    public class ElementsPage2 : ContentPage
    {
        public ElementsPage2()
        {
            Button button = new Button { Text = "pain to blue", BackgroundColor = Color.Gray, FontSize = 20 };
            button.Clicked += (s, e) =>
            {
                this.BackgroundColor = Color.White;
            };
            Content = new StackLayout
            {

            };
            Label label = new Label(); new Label
            {
                Text = "Welcome Estacio Group",
                TextColor = Color.Navy,
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label))
            };
            Content = new StackLayout
            {

            };
            Entry entry = new Entry
            { Placeholder = "Password", IsPassword = true, TextColor = Color.BlueViolet };
            Editor editor = new Editor
            { Placeholder = "About", BackgroundColor = Color.CornflowerBlue, TextColor = Color.White, FontFamily = "calibri", FontAttributes = FontAttributes.Bold, HeightRequest = 150 };

            Content = new StackLayout
            {

                Children =
                {
                    button,
                    label,
                    entry,
                    editor,
                }
            };
        }
    }
}

