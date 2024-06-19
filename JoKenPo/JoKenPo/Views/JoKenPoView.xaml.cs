using JoKenPo.ViewModels;

namespace JoKenPo.Views;

public partial class JoKenPoView : ContentPage
{
	public JoKenPoView()
	{
		InitializeComponent();
        BindingContext = new JoKenPoViewModel();
    }
}