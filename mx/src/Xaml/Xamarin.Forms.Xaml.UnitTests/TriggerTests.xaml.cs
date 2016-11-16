﻿using System;
using System.Collections.Generic;
using Xamarin.Forms;
using NUnit.Framework;

namespace Xamarin.Forms.Xaml.UnitTests
{	
	public partial class TriggerTests : ContentPage
	{	
		public TriggerTests ()
		{
			InitializeComponent ();
		}

		public TriggerTests (bool useCompiledXaml)
		{
			//this stub will be replaced at compile time
		}

		[TestFixture]
		public class Tests 
		{
			[TestCase (false)]
			[TestCase (true)]
			public void ValueIsConverted (bool useCompiledXaml)
			{
				var layout = new TriggerTests (useCompiledXaml);
				Entry entry = layout.entry;
				Assert.NotNull (entry);

				var triggers = entry.Triggers;
				Assert.IsNotEmpty (triggers);
				var pwTrigger = triggers [0] as Trigger;
				Assert.AreEqual (Entry.IsPasswordProperty, pwTrigger.Property);
				Assert.AreEqual (true, pwTrigger.Value);
			}
		}
	}
}