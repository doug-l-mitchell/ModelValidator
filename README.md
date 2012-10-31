ModelValidator
==============

A handy way to validate annotated POCOs.


Suppose I have this model

```csharp
public class SampleData
{
	public int Id { get; set; }
	[Required]
	public string FirstName { get; set; }
	[Required]
	public string LastName { get; set; }
	public DateTime CheckIn { get; set; }
}
```

and I want to validate this object in the business layer...

```csharp
public void SomeBusinessMethod(SampleData data)
{
	ICollection<string> errors = ModelValidator.Validate(data);
	if(data.CheckIn.DayOfWeek != DayOfWeek.Friday)
		errors.Add("It's not Friday!");

	if(errors.Count() > 0)
		throw new ValidationException(errors);

	...
}
```
No rocket science here but it keeps the business logic a bit cleaner.