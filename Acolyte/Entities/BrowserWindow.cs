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

public class BrowserWindow
{
	public virtual List<BrowserTab> Tabs
	{
		get;
		set;
	}

	public virtual string ProcessId
	{
		get;
		set;
	}

	public virtual Browser Browser
	{
		get;
		set;
	}

	public virtual IEnumerable<BrowserTab> BrowserTab
	{
		get;
		set;
	}

	public virtual void close()
	{
		throw new System.NotImplementedException();
	}

	public virtual void newTab()
	{
		throw new System.NotImplementedException();
	}

	public virtual void closeTab()
	{
		throw new System.NotImplementedException();
	}

}
