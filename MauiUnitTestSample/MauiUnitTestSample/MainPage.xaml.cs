namespace MauiUnitTestSample;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
        Preferences.Default.Set("testKey", "testValue");
    }

    public void OnCounterClicked(object sender, EventArgs e)
	{
		var cnt = Counter();

		if (cnt == 1)
			CounterBtn.Text = $"Clicked {cnt} time";
		else
			CounterBtn.Text = $"Clicked {cnt} times";

		SemanticScreenReader.Announce(CounterBtn.Text);
	}


    public int Counter()
    {
        var key = Preferences.Default.Get("testKey", "");
        count++;
        return count;
    }

    public int Counter1()
    {
        return 1;
    }
    public async void OnNewPageClicked(object sender, EventArgs e)
    {
        // 同じウィンドウ内で画面遷移
        await Shell.Current.GoToAsync("newPage1");
    }
}

