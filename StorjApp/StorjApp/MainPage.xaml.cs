using uplink.NET.Models;
using uplink.NET.Services;
using System;
using System.Diagnostics;

namespace StorjApp;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;
		Access access = null;
		try
		{
            //Get an access-object from your access-grant
            access = new Access("15M6fjnUPHBJnVt3KofVPkEHb8P9AbE48hP6135x3k9yFnHJkno7zkXCD44poevuBaGjYUjYH8fXrzyYdZHhDCizj9iryNh76bub3Lvddv1WH1uGubG6AB9B1q53UBJfKLyAmHYYSbn8o2SerSTVLJvFaCGG6eYR9ZHhx8LAfqRtUUkpi9zDReNgHn5GKAkpBUDfD3JudiM9kbir3ti9boE8gT2vEiz6c97CsbeX7mUpp6HX2c26WDj58SkfFYeqVCh1EAtk3haUCr2sDergyy9vGWNn4doVY");
        }
        catch (Exception ex)
        {
            Debug.WriteLine(ex.Message);
        }
        //Get a bucket-service instance
        var bucketService = new BucketService(access);

        if (count == 1)
			CounterBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";
		
        SemanticScreenReader.Announce(CounterBtn.Text);
	}
}


