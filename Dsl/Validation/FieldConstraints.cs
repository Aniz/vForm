using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.Modeling;
using Microsoft.VisualStudio.Modeling.Validation;

namespace Ufba.visualForm.Validation
{
	[ValidationState(ValidationState.Disabled)]
	public partial class Field
	{
		// Identify the method as a validation method:  
		[ValidationMethod
		( // Specify which events cause the method to be invoked:  
		  ValidationCategories.Open // On file load.  
		| ValidationCategories.Save // On save to file.  
		| ValidationCategories.Menu // On user menu command.  
		)]
		private void validOptions(ValidationContext context)
		{
			context.LogError("[Device Type Error] The Sensor of a Feature must be of type Sensor", "Err 01",null);
		}
	}
}
