# Reverse Polish Notation Calculator

This is a calculator application that supports Reverse Polish Notation (RPN) and is implemented in C#. It allows users to perform basic arithmetic operations (addition, subtraction, multiplication, and division) as well as calculate the square root. The calculator also supports different number types such as real, natural, and fractional numbers.


## Table of Contents
- [Installation](https://github.com/IsraelChidera/RPN-Calculator#installation)

- [How to use](https://github.com/IsraelChidera/RPN-Calculator#how-to-use)

- [Testing](https://github.com/IsraelChidera/RPN-Calculator#testing)

- [Architecture and Design Decisions](https://github.com/IsraelChidera/RPN-Calculator#architecture-and-design-decisions)

- [Technologies Used](https://github.com/IsraelChidera/RPN-Calculator#technologies-used)

- [Contributing](https://github.com/IsraelChidera/RPN-Calculator#contributing)


## Installation
To run the calculator, you need to have the following installed on your machine:

- NET Core SDK version 6.0 or later
After installing the .NET 5 SDK, you can clone the repository to your local machine :

To get started, follow these steps:

1. Clone the repository to your local machine. 
2. Open the solution file CeestoreWebAPI.sln in your preferred IDE or text editor.
3. Run the application using your IDE

## How to use
Here are some examples of valid inputs and their corresponding outputs:

- Operations with RPN Expression
Addition: 2 3 + outputs 5
Subtraction: 5 2 - outputs 3
Multiplication: 4 2 * outputs 8
Division: 10 5 / outputs 2
Addition: 5 3 4 + * ouputs 35
*...and so on*

- Square root operation
Square Root: 16 outputs 4

The calculator also handles invalid inputs and operations gracefully. For example, if you enter 10 /, which is a division operation without a second operand, the calculator will display an error message indicating the invalid input.

## Testing
The calculator comes with a comprehensive suite of unit tests to ensure the correctness of calculations and proper handling of different number types and invalid inputs. To run the tests, you can either use the Test Explorer or navigate to the project's root directory in a terminal or command prompt, and run the following command:
- dotnet test

## Architecture and Design Decisions
The calculator project follows the Onion Architecture design pattern, which helps to achieve a modular and maintainable codebase. The code is structured into layers: the presentation layer, the business logic layer, and the utility layer.

## Technologies Used
The Ceestore Web API is built using the following technologies:

- C#
- XUnit for testing

## Contributing
To contribute to the Reverse Polish Notation Calculator, please follow these guidelines:

- Create a new branch for your changes.
- Make your changes and commit them with clear commit messages.
- Push your changes to your forked repository.
- Create a pull request to the main repository's master branch.

