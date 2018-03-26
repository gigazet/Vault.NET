using System;
using System.Collections.Generic;
using System.Text;

namespace Vault
{

	public interface IOptions<out TOptions> where TOptions : class, new()
	{
		TOptions Value { get; }
	}
		
}
