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

public class Network
{
	public virtual string Name
	{
		get;
		set;
	}

	public virtual NetworkType Type
	{
		get;
		set;
	}

	public virtual bool Connected
	{
		get;
		set;
	}

	public virtual bool PasswordProtected
	{
		get;
		set;
	}

	public virtual string MacAddress
	{
		get;
		set;
	}

	public virtual NetworkType NetworkType
	{
		get;
		set;
	}

	public virtual void connect()
	{
		throw new System.NotImplementedException();
	}

	public virtual void displayLoginDialog()
	{
		throw new System.NotImplementedException();
	}

	public virtual void verifyLogin()
	{
		throw new System.NotImplementedException();
	}

	public virtual void disconnect()
	{
		throw new System.NotImplementedException();
	}

}

