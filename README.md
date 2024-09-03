**Overview**

**Software design patterns** are programming paradigms that describe reusable patterns for common design problems. They are a set of tried and tested solutions to common problems in software design. They are not algorithms or code snippets that can be copied and pasted into your code. They are more like templates that can be applied to different situations. They are not a substitute for good software design principles, but they are a good starting point for designing your software. They are a good way to document your design decisions. They are a good way to communicate your design to other developers.

**Builder Desing Pattern** is a creational design pattern that allows the construction of complex objects step by step. It separates the construction process from the actual representation of the object, enabling the creation of different representations using the same construction process.

**Real world applications** of the Builder Design Pattern include the following:
User Interface Builders (GUI),Document Generation,Vehicle Configuration Systems,Meal Planning System,etc.The builder pattern is in
* Many GUI frameworks (e.g., JavaFX, Swing) use builders to create and configure UI elements. For instance, a builder might be used to create a window with various buttons, labels, and input fields.
* PDF libraries (e.g., iText) use builders to create complex PDF documents with different sections, headers, footers, and content blocks.
*  Car configurators on automotive websites (e.g., Tesla, BMW) use builders to allow users to customize their cars by selecting different options and features.
* Food ordering apps like Subway’s online order system let users build their meals by choosing bread, toppings, sauces, and extras using a builder-like approach.

**DESIGN:**
This is a project where we took the features of car and build an interface for setting features,defined these methods in CarBuilder and created an director to show various representations of cars using the same constrution process.
![image](https://github.com/user-attachments/assets/d276e704-1b78-4902-868c-7d13a32a1e9f)

**ENVIRONMENT**
  The project builds and runs with Visual Studio Community 2022 when the required workloads are installed.
**NOTE**
As ApplicationModule is a part of UX,expect that every other module has a code coverage of 100%

![image](https://github.com/user-attachments/assets/bcefae18-533c-4cb0-b0b0-df0d9b5a0bc5)
