using System.Text;

namespace Session03Demo
{
    internal class Program
	{
		static void Main(string[] args)
		{
			#region Implicit Casting 

			#region Example 01
			//byte value = 255;
			//short sValue = value;      // byte → short (implicit)
			//int iValue = sValue;          // short → int (implicit)
			//long lValue = iValue;          // int → long (implicit)
			//float fValue = lValue;       // long → float (implicit)
			//double dValue = fValue;    // float → double (implicit)

			//Console.WriteLine($"Byte Value : {value}");     // 255
			//Console.WriteLine($"Short Value : {sValue}");   // 255
			//Console.WriteLine($"Long Value : {lValue}");    // 255
			//Console.WriteLine($"Float Value : {fValue}");   // 255
			//Console.WriteLine($"Double Value : {dValue}");  // 255

			#endregion

			#region Example 02

			//char cValue = 'A'; // 2 Bytes
			//int charToInt = cValue;  // 4 Bytes char → int (gets ASCII value)
			//Console.WriteLine($"char Value :{cValue}"); // A
			//Console.WriteLine($"char to int Value :{charToInt}"); // 65

			#endregion
			#endregion

			#region Explicit Casting  

			//double number = 123.456;
			//int intFromDouble = (int)number;  // Truncates decimal part
			//Console.WriteLine($"Int From Double = {intFromDouble}"); // 123

			//checked
			//{
			//	 number = 123456789123456798132465798.456;
			//	 intFromDouble = (int)number;  // This will throw an OverflowException at runtime
			//	Console.WriteLine($"Int From Double = {intFromDouble}"); // 123

			//}


			//int number = 300;
			//byte byteFromInt = (byte)number;  // Data loss! 300 > 255
			//Console.WriteLine($"Byte From Int = {byteFromInt}"); // 44


			//float number = 99.9f;
			//int intFromFloat = (int)number;
			//Console.WriteLine($"Int From Float = {intFromFloat}"); // 99


			//int charAsciiCode = 66;
			//char charFromInt = (char)charAsciiCode;
			//Console.WriteLine($"Char From Int = {charFromInt}"); // B

			//object objNumber = 123;
			//int number = (int)objNumber;
			//Console.WriteLine(number);

			//object objNumber = "123";
			//int number = (int)objNumber; // This will throw an InvalidCastException at runtime
			//Console.WriteLine(number);





			#endregion

			#region Convert Class

			//// String to numeric
			//string number = "123";
			//int convertedInt = Convert.ToInt32(number); // 123
			//double convertedDouble = Convert.ToDouble(number); // 123

			////  Numeric to String
			//int number = 456;
			//string strFromNum = Convert.ToString(number); // "456"

			//// Double to int (ROUNDS, unlike casting which truncates!)
			//double val1 = 9.5;
			//double val2 = 9.4;
			//int intFromVal1 = Convert.ToInt32(val1); // 10
			//int intFromVal2 = Convert.ToInt32(val2); // 9
			//Console.WriteLine($"int from val1 = {intFromVal1}");
			//Console.WriteLine($"int from val2 = {intFromVal2}");


			//// Boolean conversions
			//Console.WriteLine(Convert.ToInt32(true)); // 1
			//Console.WriteLine(Convert.ToInt32(false)); // 0
			//Console.WriteLine(Convert.ToBoolean(0)); // False
			//Console.WriteLine(Convert.ToBoolean(1)); // True

			//// Handling null
			//string nullStr = null;
			//int fromNull = Convert.ToInt32(nullStr);  // Returns 0, doesn't throw!

			#endregion

			#region Parse() vs TryParse()

			//string number = "42";
			//int parsed = int.Parse(number); // 42
			//Console.WriteLine(parsed);

			//// Parse with invalid input
			//number = "NotANumber";
			////int invalidParse = int.Parse(number); // Throws FormatException
			//bool tryParseResult = int.TryParse(number, out int tryParsed); // False , tryParsed = 0


			//number = null;
			////int nullParse = int.Parse(number); // Throws ArgumentNullException
			//int nullParse;
			//bool tryParseNullResult = int.TryParse(number, out nullParse); // False , nullParse = 0


			//Console.Write("Please Enter Your Number : ");
			//string? userInput = Console.ReadLine();

			//if (int.TryParse(userInput, out int userNumber))
			//{
			//	Console.WriteLine($"Valid number: {userNumber}");
			//}
			//else
			//{
			//	Console.WriteLine("Invalid Number");
			//}


			#endregion

			#region toString()

			//// Basic ToString

			//int value = 42;
			//Console.WriteLine(value + 10); // 52

			//DateTime dateValue = DateTime.Now;
			//Console.WriteLine(dateValue.ToString()); // "6/10/2024 2:15:30 PM"

			//// Formatted ToString

			//int num1 = 12345;
			//double num2 = 1234.5678;

			//Console.WriteLine($"{num1.ToString("N")}"); // Number with commas
			//Console.WriteLine($"{num1:C}"); // Currency
			//Console.WriteLine($"{num1:X}");// Hexadecimal
			//Console.WriteLine($"{num1:D10}");// Padded digits
			//Console.WriteLine($"{num2:F2}"); // 2 decimal places
			//Console.WriteLine($"{dateValue:d}"); // Short date
			//Console.WriteLine($"{dateValue:D}"); // Long date
			//Console.WriteLine($"{dateValue:t}"); // Short time
			//Console.WriteLine($"{dateValue:yyyy-MM-dd}"); // Custom date format

			//// Custom object ToString
			//Person person = new Person { Id = 1, Name = "Mohamed" };
			//Console.WriteLine(person.ToString()); // 1 - Mohamed
			//Console.WriteLine(person);  // Implicitly calls ToString()

			#endregion

			#region Boxing and UnBoxing

			//int valueOnStack = 42;              // Value type on Stack
			//object boxedValue = valueOnStack;   // BOXING: copied to Heap, wrapped in object

			//int unboxedValue = (int)boxedValue;  // UNBOXING: explicit cast required


			//object boxedInt = 123; // Boxing
			//double unboxedInt = (double)boxedInt;  // InvalidCastException at runtime
			//unboxedInt = (double)(int)boxedInt; // Correct unboxing and casting

			#endregion

			#region Null-able Value Types

			//int num01 = 20;
			////num01 = null; // Compilation Error: Cannot convert null to 'int' because it is a non-nullable value type

			//int? num02 = 20; // Nullable int
			//num02 = null; // Valid


			//Console.WriteLine($"Has Value : {num02.HasValue}");
			////Console.WriteLine($"num02 Value : {num02.Value}");

			//if(num02 != null)
			//{
			//	Console.WriteLine(num02);
			//}
			//else
			//{
			//	Console.WriteLine(0);
			//}


			//if(num02.HasValue)
			//{
			//	Console.WriteLine(num02.Value);
			//}
			//else
			//{
			//	Console.WriteLine(0);
			//}

			//Console.WriteLine(num02.GetValueOrDefault());
			//Console.WriteLine(num02.GetValueOrDefault(1000));

			//int x = 10;
			//int? y = x; // Implicit conversion from int to int?


			//int? a = 10;
			////int b = a; // invalid 
			//int b = (int)a; // invalid 

			#endregion

			#region Null-able Reference Types

			#region Example 01
			//			string name01 = null; // Valid but with warning 
			//			Console.WriteLine(name01);

			//#nullable disable

			//			string name02 = null; // Valid no warning
			//			Console.WriteLine(name02);

			//#nullable enable

			//			Console.WriteLine(name01.Length); // NullReferenceException
			//			Console.WriteLine(name02.Length);

			#endregion

			#region Example 02 

			//string name01 = null;

			//string? name02 = name01;



			//string? title01 = null;

			//string title02 = title01; // valid with warning 


			#endregion

			#endregion

			#region Null-Conditional (Null-Propagation) Operator

			#region Example 01
			//Person person1 = null;
			//string? name;

			////if (person1 != null)
			////{
			////	name = person1.Name;
			////}
			////else
			////{
			////	name = null;
			////}

			//name = person1?.Name; // Using Null-Conditional Operator

			//Console.WriteLine(name == null ? "null" : name);

			#endregion

			#region Example 02

			//string? text = null;
			//int? len = text?.Length;  // Returns null, not exception
			//string? upper = text?.ToUpper(); // Returns null, not exception

			//int[]? array = null;
			//int? firstElement = array?[0]; // Returns null, not exception
			#endregion

			#region Example 03

			//Company? company1 = new Company
			//{
			//	Department = new Department
			//	{
			//		Manager = new Person() { Id = 1, Name = "Ahmed" }
			//	}
			//};

			//Console.WriteLine(company1?.Department?.Manager?.Name); // Ahmed

			#endregion

			#endregion

			#region Null-Coalescing Operators

			#region Example 01
			//string name01 = null;
			//string name02 = "Mohamed";

			//string result1 = name01 ?? "Default";
			//Console.WriteLine(result1); // Output: Default
			//string result2 = name02 ?? "Default";
			//Console.WriteLine(result2); // Output: Mohamed


			//int? num01 = null;
			//int? num02 = 42;

			//int num1 = num01 ?? 0;
			//Console.WriteLine(num1); // Output: 0
			//int num2 = num02 ?? 0;
			//Console.WriteLine(num2);// Output: 42

			//string first = null;
			//string second = null;
			//string third = "Found!";

			//string found = first ?? second ?? third ?? "None"; 
			#endregion

			#region Example 02

			//string? name01 = null;
			//name01 ??= "Default Name";
			//Console.WriteLine(name01); // Output: Default Name

			//string name02 = "Mohamed";
			//name02 ??= "Default Name";
			//Console.WriteLine(name02); // Output: Mohamed
			#endregion

			#endregion

			#region Null-Conditional with Null-Coalescing

			//Company company01 = null;
			//Company company02 = new Company
			//{
			//	Department = new Department
			//	{
			//		Manager = new Person() { Id = 1, Name = "Ahmed" }
			//	}
			//};

			//string manager1 = company01?.Department?.Manager?.Name ?? "No Manager";
			//Console.WriteLine(manager1); // Output: No Manager
			//string manager2 = company02?.Department?.Manager?.Name ?? "No Manager";
			//Console.WriteLine(manager2); // Output: Ahmed

			#endregion

			#region Null-Forgiving Operator (!)

			//string? name = GetName();

			//string name02 = name; // Warning: Converting null literal or possible null value to non-nullable type.
			//name02 = name!; // No Warning


			#endregion

			#region string 

			//// String declaration

			//string str1 = "Hello World";           // Literal
			//string str2 = new string('*', 5);  // Constructor
			//string str3 = string.Empty;            // Empty string
			//string str4 = "";                      // Also empty

			//// String concatenation
			//string first = "Hello";
			//string second = "World";

			//string concat1 = first + " " + second;           // + operator
			//string concat2 = string.Concat(first, " ", second); // Concat method
			//string concat3 = $"{first} {second}";            // String interpolation
			//string concat4 = string.Format("{0} {1}", first, second); // Format

			//// Verbatim strings
			//string path = @"C:\Users\Documents\file.txt";
			//path = "C:\\Users\\Documents\\file.txt";


			#endregion

			#region String Immutability
			#region Example 01
			//string original = "Hello";
			//string modified = original.ToUpper();
			//Console.WriteLine(original);
			//Console.WriteLine($"Original hash code = {original.GetHashCode()}");
			//Console.WriteLine(modified);
			//Console.WriteLine($"Modified hash code = {modified.GetHashCode()}");

			//// String interning
			//string s1 = "Hello";
			//string s2 = "Hello";
			//string s3 = new string("Hello".ToCharArray());
			//Console.WriteLine($"s1 hash code  = {s1.GetHashCode()}");
			//Console.WriteLine($"s2 hash code  = {s2.GetHashCode()}");
			//Console.WriteLine($"s3 hash code  = {s3.GetHashCode()}");

			//Console.WriteLine($"ReferenceEquals(s1, s2) :   {Object.ReferenceEquals(s1, s2)} "); // (same interned object)
			//Console.WriteLine($"s1.Equals(s2) {s1.Equals(s2)}");
			//Console.WriteLine($"ReferenceEquals(s2, s3) :   {Object.ReferenceEquals(s2, s3)} "); // (different objects)
			//Console.WriteLine($"s2.Equals(s3) {s2.Equals(s3)}");
			//Console.WriteLine($"ReferenceEquals(s1, s3) {Object.ReferenceEquals(s1, s3)} "); // (different objects)
			//Console.WriteLine($"s1.Equals(s3) {s1.Equals(s3)}");



			#endregion

			#region Example 02 

			//string name01 = "Omar"; // same Object 
			//string name02 = name01; // same Object 
			//Console.WriteLine($"name01 = {name01}"); // Omar
			//Console.WriteLine($"name02 = {name02}"); // Omar
			//name02 = "Ali"; // new Object
			//Console.WriteLine("After Change");
			//Console.WriteLine($"name01 = {name01}"); // Omar
			//Console.WriteLine($"name02 = {name02}"); // Ali

			#endregion

			#endregion

			#region StringBuilder in C#

			#region Example 01
			//StringBuilder sb = new StringBuilder();
			//sb.Append("Hello");
			//sb.Append(' ');
			//sb.Append("World");
			//string result = sb.ToString();
			//Console.WriteLine(result); // Output: Hello World

			#endregion

			#region Example 02
			//// String concatenation
			//var watch1 = System.Diagnostics.Stopwatch.StartNew();
			//string strResult = "";
			//for (int i = 0; i < 10000; i++)
			//	strResult += "a";
			//watch1.Stop();

			//// StringBuilder
			//var watch2 = System.Diagnostics.Stopwatch.StartNew();
			//StringBuilder sbResult = new StringBuilder();
			//for (int i = 0; i < 10000; i++)
			//	sbResult.Append("a");
			//string sbFinal = sbResult.ToString();
			//watch2.Stop();

			//Console.WriteLine($"10,000 concatenations:");
			//Console.WriteLine($"  String (+)      : {watch1.ElapsedMilliseconds}ms");
			//Console.WriteLine($"  StringBuilder   : {watch2.ElapsedMilliseconds}ms");

			#endregion

			#region Example 03 

			//StringBuilder name01 = new StringBuilder("Mohamed");
			//StringBuilder name02 = name01;
			//Console.WriteLine($"name01 = {name01}"); // Mohamed
			//Console.WriteLine($"name02 = {name02}"); // Mohamed
			//name02.Append(" Ali");
			//Console.WriteLine("After Change");
			//Console.WriteLine($"name01 = {name01}"); // Mohamed Ali
			//Console.WriteLine($"name02 = {name02}"); // Mohamed Ali

			#endregion
			#endregion
		}

		public static string? GetName()
		{
			return "Mohamed";
		}
	}
}
