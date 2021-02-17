using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Contenedores
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyStackLayout : ContentPage
    {
        public MyStackLayout()
        {
            InitializeComponent();
        }
    }
}