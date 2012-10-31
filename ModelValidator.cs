using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;

namespace ModelHelper
{
    public static class ModelValidator
    {
        public static ICollection<string> Validate<T>(T instance)
        {
            List<ValidationResult> results = new List<ValidationResult>();
            Validator.TryValidateObject(instance, new ValidationContext(instance, null, null), results);
            return results.Select(r => r.ErrorMessage).ToList();
        }
    }

	public class SampleData
	{
		public int Id { get; set; }
		[Required]
		public string FirstName { get; set; }
		[Required]
		public string LastName { get; set; }
		public DateTime CheckIn { get; set; }
	}

    public class Business
    {
    	public void Test(SampleData data)
    	{
    		List<ValidationResult> results = new List<ValidationResult>();
            Validator.TryValidateObject(instance, new ValidationContext(instance, null, null), results);
    	}
    }
}
