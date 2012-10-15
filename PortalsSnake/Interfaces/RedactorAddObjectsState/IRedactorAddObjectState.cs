using System;

namespace Interfaces.RedactorAddObjectsState
{
	public interface IRedactorAddObjectState
	{
		String Name{get;set;}
		IRedactorAddObjectOwner Owner{get;set;}
		
	}
}

