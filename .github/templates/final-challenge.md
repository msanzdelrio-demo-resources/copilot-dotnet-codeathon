# Copilot .Net HelloCopilot Challenge

This project showcases a basic .NET application designed to provide information about various regions, flags, and borders based on the name of a capital city. It serves as an excellent starting point for learning and experimenting with .NET development, as well as exploring the powerful capabilities of GitHub Copilot.

This challenge will guide you through the process of using GitHub Copilot to create a .Net application that interacts with an external API, handles user input, and includes unit testing and security considerations.

You will find the base code of the application and related tests in the `HelloCopilot`and `TestWithCopilot` folders respectively.

## Step 1: Create the HelloCopilot Application

In the HelloCopilot folder, create an application with the folloring requirements:

- Given a country capital, returns the region, flag, and border countries of that specific country.
- Utilize the https://restcountries.com API for retrieving country information.
- Create a `GetCapitalInfo` method that handles all the logic.
- The `Main` method should prompt the user for the capital name and display the information in the console.

You can start working in the `Program.cs`` file directly.

## Step 2: Add Europe Filter

Extend your `GetCapitalInfo` method to add a check to only return information for countries that belong to Europe. If the given capital does not correspond to a European country, send a message to the user and ask for a different capital input.

## Step 3: Implement Exit Command

Modify the application to keep running until the user types "exit." This ensures that the program does not exit immediately after displaying the information.

## Step 4: Fix Problems Using Copilot Suggestions

Check the problems tab at the bottom of the Visual Studio Code or your IDE. Try to fix one of those problems using Copilot's suggestions to improve your code quality and readability.

## Step 5: Create Tests

In the `TestWithCopilot` project, add unit tests for the `GetCapitalInfo` method. Consider different scenarios, including what happens if the input is not a valid country capital.

## Step 6: Fix Test-Induced Errors

Based on the errors thrown in the previous use case, ask Copilot to help you fix them and ensure your tests pass successfully.

## Step 7: Address Security Concerns

Ask Copilot to identify and address potential security breaches in your `GetCapitalInfo` method. Ensure that your code is secure, and make any necessary improvements to protect against vulnerabilities.

## Step 8: Translate to other languages

Now that you are done 🎉 this may be a great time to also check how much Copilot can help you with learning/migrating code to other languages. From Python to Java or any other language, feel free to test out the translating skills of Copilot and try to migrate this application to a different language!

Enjoy your Copilot-powered .Net demo!
