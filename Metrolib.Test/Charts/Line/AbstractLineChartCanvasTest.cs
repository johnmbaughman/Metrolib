﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using FluentAssertions;
using Metrolib.Controls.Charts.Line.Canvas;
using Moq;
using NUnit.Framework;

namespace Metrolib.Test.Charts.Line
{
	[TestFixture]
	public abstract class AbstractLineChartCanvasTest
	{
		protected abstract AbstractLineChartCanvas Create();

		[Test]
		[STAThread]
		public void TestCtor()
		{
			var canvas = Create();
			canvas.Series.Should().BeNull();
			canvas.SeriesCanvasses.Should().BeEmpty();
		}

		[Test]
		[STAThread]
		public void TestSeries1()
		{
			var canvas = Create();
			new Action(() => canvas.Series = null).ShouldNotThrow();
			canvas.Series.Should().BeNull();
			canvas.SeriesCanvasses.Should().BeEmpty();
		}

		[Test]
		[STAThread]
		public void TestSeries2()
		{
			var canvas = Create();
			new Action(() => canvas.Series = new ILineSeries[0]).ShouldNotThrow();
			canvas.Series.Should().BeEmpty();
			canvas.SeriesCanvasses.Should().BeEmpty();
		}

		[Test]
		[STAThread]
		public void TestSeries3()
		{
			var canvas = Create();
			new Action(() => canvas.Series = new List<ILineSeries>()).ShouldNotThrow();
			canvas.Series.Should().BeEmpty();
			canvas.SeriesCanvasses.Should().BeEmpty();
		}

		[Test]
		[STAThread]
		public void TestSeries4()
		{
			var canvas = Create();
			var series = new Mock<ILineSeries>();
			new Action(() => canvas.Series = new[] {series.Object}).ShouldNotThrow();
			canvas.Series.Should().Equal(new object[] {series.Object});
			canvas.SeriesCanvasses.Count().Should().Be(1);
		}

		[Test]
		[STAThread]
		public void TestSeries5()
		{
			var canvas = Create();
			var series = new Mock<ILineSeries>();
			var serieses = new ObservableCollection<ILineSeries>();
			new Action(() => canvas.Series = serieses).ShouldNotThrow();
			canvas.Series.Should().BeEmpty();
			canvas.SeriesCanvasses.Should().BeEmpty();

			serieses.Add(series.Object);
			canvas.Series.Should().Equal(new object[] {series.Object});
			canvas.SeriesCanvasses.Count().Should().Be(1);
		}
	}
}