﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool
//     Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Monitor
{
	public virtual string Manufacturer
	{
		get;
		set;
	}

	public virtual int SequenceNumber
	{
		get;
		set;
	}

	public virtual double Brightness
	{
		get;
		set;
	}

	public virtual double Contrast
	{
		get;
		set;
	}

	public virtual double Hue
	{
		get;
		set;
	}

	public virtual void adjustBrightness(double AdjustmentAmount)
	{
		throw new System.NotImplementedException();
	}

	public virtual void adjustContrast(double AdjustmentAmount)
	{
		throw new System.NotImplementedException();
	}

	public virtual void adjustHue(double AdjustmentAmount)
	{
		throw new System.NotImplementedException();
	}

	public virtual void turnOff()
	{
		throw new System.NotImplementedException();
	}

}

