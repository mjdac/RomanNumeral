//Get user to input number
Console.Write("Enter a number between 1 and 2000: ");
int number;

//Check if value entered is an integer and number is between and equal to 1 to 2000
if (!int.TryParse(Console.ReadLine(), out number) || (number < 1 || number > 2000))
{
    Console.WriteLine("Number must be between 1 and 2000.");
    return;
}

//Get Roman Numeral for number
string romanNumeral = ConvertToRoman(number);

//Display result to user
Console.WriteLine($"The Roman numeral representation of {number} is: {romanNumeral}");

//Function to Convert an Integer Number to a Ronam Numeral String
static string ConvertToRoman(int number)
{
    //Check if key entered is between and equal to 1 to 2000
    if (number < 1 || number > 2000)
        throw new ArgumentOutOfRangeException(nameof(number), "Number must be between 1 and 2000.");

    //Array of Roman Numeral value decending from 2000
    string[] romanSymbols = ["M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I"];

    //Array of Integers Decending from 2000
    //Both arrays must marry up
    int[] values = [1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1];

    // Initialize an empty string to store the Roman Numeral value
    string romanNumeral = "";

    // Iterate through the values and corresponding symbols
    for (int i = 0; i < values.Length; i++)
    {
        // While the number is greater than or equal to the current value
        while (number >= values[i])
        {
            // Subtract the value from the number and append the corresponding symbol to the result string
            number -= values[i];
            romanNumeral += romanSymbols[i];
        }
    }

    // Return the Roman numeral representation
    return romanNumeral;
}
