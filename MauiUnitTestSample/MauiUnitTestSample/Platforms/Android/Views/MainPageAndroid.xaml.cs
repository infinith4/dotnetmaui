﻿namespace MauiUnitTestSample;

public partial class MainPageAndroid : ContentPage
{
	int count = 0;

	public MainPageAndroid()
	{
		InitializeComponent();
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


	public int Counter(){
		count++;
		return count;
	}
}

