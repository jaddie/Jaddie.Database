using System;

namespace Jaddie.Database
{
	[AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = false)]
	public sealed class ShouldAutoMap : Attribute
	{
	}
}
