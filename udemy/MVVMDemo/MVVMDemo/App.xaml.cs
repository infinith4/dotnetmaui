﻿using MVVMDemo.MVVM.Views;

namespace MVVMDemo;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

        //MainPage = new PersonView();
        //MainPage = new PeopleView();
        //MainPage = new ConvertersView();
        MainPage = new CommandsView();
    }
}

