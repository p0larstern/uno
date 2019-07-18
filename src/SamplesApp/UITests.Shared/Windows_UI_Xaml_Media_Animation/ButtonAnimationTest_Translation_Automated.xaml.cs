﻿using System;
using System.Linq;
using System.Reactive.Concurrency;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Animation;
using Uno.UI.Samples.Controls;

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace UITests.Shared.Windows_UI_Xaml_Media_Animation
{
	[SampleControlInfo("Animations", nameof(ButtonAnimationTest_Translation_Automated))]
	public sealed partial class ButtonAnimationTest_Translation_Automated : UserControl
	{
		private int _clickTotal = 0;

		private TranslateTransform _renderTranslateTransform = new TranslateTransform();

		private EasingFunctionBase _easingFunction = new QuadraticEase() { EasingMode = EasingMode.EaseIn };
		private Duration _duration = new Duration(TimeSpan.FromSeconds(0.5));
		private Storyboard _storyboard = new Storyboard();
		private IScheduler _uiScheduler;

		public ButtonAnimationTest_Translation_Automated()
		{
			this.InitializeComponent();
			this.DataContext = this;

			this.Loaded += Initialize;

#if XAMARIN
			_uiScheduler = CoreDispatcherScheduler.MainNormal;
#else
			_uiScheduler = new CoreDispatcherScheduler(Dispatcher);
#endif
		}

		private void Initialize(object sender, RoutedEventArgs e)
		{
			//this.Loaded -= Initialize;
			//this.StartAnimationButton.Command = new Common.DelegateCommand(AnimateButton_Click);
		}

		private void IncreaseClick(object sender, RoutedEventArgs e)
		{
			//_clickTotal++;
			//TotalClicks.Text = _clickTotal.ToString();
		}

		private void AnimateButton_Click()
		{
			//PrepareAnimationTarget();
			//LaunchAnimation();
		}

		private void PrepareAnimationTarget()
		{
			//this.MyTranslatingButton.RenderTransform = _renderTranslateTransform;
		}

		private void LaunchAnimation()
		{
			/*
			_storyboard.Stop();

			var anim_translate = new DoubleAnimation()
			{
				From = 0,
				To = 50,
				EasingFunction = _easingFunction,
				Duration = _duration
			};

			Storyboard.SetTarget(anim_translate, _renderTranslateTransform);
			Storyboard.SetTargetProperty(anim_translate, "Y");

			_storyboard.Children.Add(anim_translate);

			_storyboard.Begin();
			*/
		}

		private void ResetAnimation()
		{
			/*
			if (_storyboard == null)
			{
				return;
			}

			_storyboard.Stop();
			*/
		}
	}
}
