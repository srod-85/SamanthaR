//1. Declare a string variable and an integer variable but don't assign values to them
string newString;
int newInt;
//2. Get a string from the user. We are not worried about input validation right now, so if your user inputs unexpected values, your program will give unexpected results

//3. Print to the console "Please enter your message and press enter
Console.WriteLine("Please enter your message and press enter");
//4. The user will enter their message
//5.Assign that entered string to the string variable which you declared initially
newString = Console.ReadLine();
//6. Print tothe console "Please enter a number LESS THAN the length of your string and press enter"
Console.WriteLine("Please enter a number LESS THAN the length of your string and press enter.");
//7. Assign that entered string to the int variable which you declared initialy
//8. You will need to parse the string to an int using int.parse()
newInt = int.Parse(Console.ReadLine());

//9. Call each of the provided methods with the correct arguments
//10. Print the return of each method to the console
Console.WriteLine("You entered the message: " + newString);
Console.WriteLine("You entered the number: " + newInt);

//Declare a char variable but do not assign a value to it
char newChar;
//12. Ask the user "For which character should I search in your original message?"
Console.WriteLine("For which character should I search in your original message?");
//13. Save the user input to the char variable. **remember we are not validating user input at this time so if the letter (char value) isn't in the message, you won't be able to find it.
//14. Call the SearchChar method and print the result to the console.
int charInt = int.Parse(Console.ReadLine());
newChar = newString[charInt];
Console.WriteLine("The character in the " + charInt + " place of the message, \"" + newString + "\" is '" + newChar +"'");

//15. Ask the user for their first name and save it to a string variable.
//16. Ask the user for their last name and save it to a variable.
//17. Call the ConcatNames method and print the full name result to the console.
Console.WriteLine("Please enter your first name.");
string firstName = Console.ReadLine();
Console.WriteLine("Please enter your last name.");
string lastName = Console.ReadLine();
Console.WriteLine("It's nice to meet you, " + firstName + " " + lastName);
