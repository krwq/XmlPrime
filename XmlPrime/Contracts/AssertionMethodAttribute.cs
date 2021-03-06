using System;
using System.Diagnostics;

namespace XmlPrime.Contracts
{
	/// <summary>
	/// Indicates that the marked method is assertion method, i.e. it halts control flow if one of the conditions is satisfied. 
	/// To set the condition, mark one of the parameters with <see cref="AssertionConditionAttribute"/> attribute
	/// </summary>
	/// <seealso cref="AssertionConditionAttribute"/>
	[Conditional("ANNOTATION")]
	[AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = true)]
	internal sealed class AssertionMethodAttribute : Attribute
	{
	}
}