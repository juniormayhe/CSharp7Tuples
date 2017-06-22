## C# 7.0 Tuples ##

Since C# 4.0 tuples has allowed us to return multiple results without the need to create a custom class or specify out and ref parameters. C# 7.0 brings new syntax.

### Get me to the sample

Here's a quick sample of Tuple's new syntax in C# 7.0. 

> **Note:** In projects older that 4.6 you will need to install System.ValueTuple on Nuget Manager:

```
//if it is not intended to make this method static, you should move it to 
//the same level where it is being called.
(int sum, int count) calculate(int[] values)
{
	//Create tuple items "sum" and "count" 
	//and assign both items with 0 as default value
	var tuple = (sum: 0, count: 0);

	//loop int array
	foreach (var v in values)
	{
		//you can assign directly a tuple with sum and count calculations
		//tuple = (tuple.sum + v, tuple.count + 1);

		//or you can use a local function
		SumAndCount(v, 1);
	}
	
	//return tuple with final results
	return tuple;

	//creates a local function for sum
	void SumAndCount(int sum, int count)
	{
		Console.WriteLine($"Using SumAndCount(int {sum}, int {count}) local function...");
		tuple.sum += sum;
		tuple.count += count;
	}
}//calculate
```

In the same context you may use `calculate` method as follows:

```
//declare your array with dummy data
int[] numbers = { 10, 20, 30, 40, 50 };

//deconstruct tuple
var (sum, count) = calculate(numbers);

Console.WriteLine("C# 7.0 Tuples sample. Don't forget to add in nuget System.ValueType library!\n");
Console.WriteLine($"We'll compute Sum and Count of these numbers: {String.Join(",",numbers)}:\n");

Console.WriteLine($"-> Sum is {sum} and the Count is {count}\n");
Console.WriteLine("Press any key to continue...");
Console.ReadKey();
```
