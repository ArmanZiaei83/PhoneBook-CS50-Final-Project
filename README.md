# PhoneBook CS50 Project
#### Video Demo : <https://youtu.be/-cXEXKtfekc>

# Description

## Introduction:
### This project is written in C# Programming Language.
### Furthermore, I've used a variety of technologies like :
- OOP
- CRUD
- XUnit For Unit Testing
- AAA (Arrange, Act, Assert) For Unit Tests
- Fluent Assertion
- JSON File Managing
- SOLID Principles

## How To Run Project:
1. Use a well known IDE, like Visual Studio, VSCode, Rider, etc:
open project and click on run button.
2. Open project extracted folder, and use <b>.exe</b> file from this directory: PhoneBook/PhoneBook/bin/Debug/net5.0/PhoneBook.exe

## First Step:
- After running project, you'll see two options :
1. *Login
2. *SingIn
- You can select <b>Login</b> by entering 1, and <b>SignIn</b> by entering 2.

## Sing In Proccess :
- When selected Sign In Action, you'll be asked for your Full Name. Enter your name, and don't leave it as empty. Otherwise, you'll face with an error.
- After your full name, its time for a proper and correct email! Note that all of your inputs, such as email, national code, phone number, etc, has validation.
So you'll get notified when ever an error occurs.
- Then, you'll be asked for your Iranian National Code! The national code validation is in <b>MelliLogic Class</b>, in <b>inputs</b> directory.
- If you enter your information successfully, you'll be taken through <b>Main Menu</b>.

## Main Menu
- Application main menu is like this:
#### Usage:
1. Add A Contact
2. Edit An Existing Contact
3. Delete An Existing Contact
4. Show Contacts List
5. Exit

## Add a contact:
- If you enter action number 1, you can create a new contact for yourself.
- First, you'll be asked for your contact's first name, and after that you can enter his/her last name.
- #### NOTE that you need to enter at least one of these two, first name, or last name.
- After contact's name, It's time for Phone Number! Note that :
1. Phone number needs to be an Iranian valid one.
2. Supported phone number formats are : +989... || 09...
- If the process was successful, you'll be taken through application main menu. Otherwise, errors will be shown.

## Edit an existing contact:

- If you enter action number 2, you can edit one of your contacts.
- #### This action will show you an error, if you haven't added any contacts yet.
- First, your contacts list will be shown to you.
- By selecting one of your contacts - using their number - you can see this menu :
#### Select Action :
1. Edit First Name
2. Edit Last Name
3. Edit Phone Number
4. Cancel
5. Save

- Action number one will help you to change your contact's first name.
- Similarly, action number two will do the same thing one your contact's last name.
- Action Number 3, can help you out in changing your contact's phone number (that needs to be valid).
- Action number 4, will cancel all of the changes you made on your contact and it goes back to the previous version of it.
- Finally, action number 5 will save all changes that you made.
#### Using action numbers 4 and 5, you'll be taken to the main menu again.

## Delete An Existing Contact:

- Using action number 3 in main menu, you can delete one of your contacts.
- #### This action will show you an error, if you haven't added any contacts yet.
- First, list of your contacts will be shown.
- Then, you need to choose one of your contacts using their number.
- After that, message "Delete This Contact? (yes/no)" will be shown, to ensure that you really want to delete it.
- By typing "yes" the contact will be deleted.
- By typing "no" contact won't be deleted an you'll be taked into main menu.

## Show contacts list:

- Action number 4, can help you in seeing your contacts.
- #### This action will show you an error, if you haven't added any contacts yet.
- First, it shows you the list.
- Second, you're allowed to search in your contacts, using their first and last name. Typing "yes" will let you search, and "no" will take you into main menu.
- When you're searching, all of your contacts that matches the search input will be shown.

## Exit:
- This action will close the application for you.

## Log In Process:
- When you enterd your information in Sing In section, you can restart the app and use log in action.
- When you choose LogIn, using action number 1, you'll be asked for your national code.
- #### Entering invalid national code that does not exist in system, will cause an error and you'll be asked for an other national code. So in this case, if you haven't created an account for your self, you need to close and reopen the app.
- If the login process was successful, you'll be taken into main menu.
- All of your changes have been saved since the last enterance.


## Project structure:

#### If you open up the project with an IDE, like Rider, or Visual Studio, you can see two main directories:
1. PhoneBook : Contains project files and codes
2. Tests : Contains Unit Tests, for testing application methods, validations and so on.

## Phone Book Directory:

#### If you open this directory, you can see these directories:
1. account-manager: contains login and sign in logics.
2. crud: performs CRUD operations on your contacts.
3. entities: this directory contains our entities, like Contact, User, UserData.
4. extensions: i have defined some extensions to make source code cleaner and more maintainable, like string.print(), string.isEmail() and so on.
5. inputs: this section is responsible for printing and validating data in terminal.
6. json-manager: this section has the main logic of our application which is the way we save and change data, using JSON files. Many classes are using a type of Inheritance (In OOP) from this directory.

#### You can also see some classes like:
1. Program: the application's starting point.
2. ProgramManager: an interface that contains Program.cs class main body.

## Tests directory:
- In this directory, you can see a ValidationTests.cs class which contains all unit tests of our application. We have different methods inside of this class:
> ValidateCorrectEmailSuccessfully(): checks whether a correct email can be generated or not.

> ValidateWrongEmailSuccessfully(): check whether a wrong email will be banned or not.

> ValidateCorrectNationalCodeSuccessfully(): checks whether a correct national code is acceptable or not (note that we have used Test National Code, which is 2283888888. You can test it with yours if you wish)

> ValidateWrongNationalCodeSuccessfully(): checks whether a wrong national code is unacceptable or not.

> GenerateFileNameSuccessfully(): checks whether we can create a json file name based on your national code or not.

> ValidateCorrectPhoneNumberWithCountryCodeSuccessfully(): checks whether phone number enterd with +98 is acceptable or not.

> ValidateCorrectPhoneNumberWithZeroSccessfully(): checks whether phone number enterd with 09 is acceptable or not.

> ValidateWrongPhoneNumberWithWrongLenghtSuccessfully(): checks whether we can detect wrong phone number or not.

## What's special in unit tests?

- Used TDD in action.
- Used FluentAssertion - a well-known package for unit testing in C#
- Used AAA priciple: AAA stands for Arrange, Act, Assert, that I've used it in my application.


# Summary: 
<t> PhoneBook project is written in C# language, using a variety of technologies. </t> <br>
<t> Although its not a new idea, it can easily present how can we use small features and technologies in an application. </t> <br>
<t> I'm really looking forward CS50 group, hope to see my project in CS50's exhibition. </t> <br>
<t> If it didn't happen, I'll try as much as I can to take my self up there!</t> <br>
<t> Don't forget to checkout my LinkedIn Account: https://www.linkedin.com/m/in/arman-ziaei-bb98481b1. </t> <br>
<t>Thank you CS50xIran for your great course.</t>
