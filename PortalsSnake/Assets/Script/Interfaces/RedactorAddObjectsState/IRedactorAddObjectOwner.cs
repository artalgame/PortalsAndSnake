using System;

namespace Interfaces.RedactorAddObjectsState
{
	public interface IRedactorAddObjectOwner
	{
		IRedactorAddObjectState CurrentState{get;set;}
	}
}

