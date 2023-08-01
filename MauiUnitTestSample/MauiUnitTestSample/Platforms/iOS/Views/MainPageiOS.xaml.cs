namespace MauiUnitTestSample;

public partial class MainPageiOS : ContentPage
{
	int count = 0;

	public MainPageiOS()
	{
		InitializeComponent();
	}


	public int Counter(){
		count++;
		return count;
	}
}

