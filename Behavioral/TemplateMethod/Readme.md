# Template Method
The template method is useful when you have some order to do things, for example, but want to have many ways to do these things.  
So you can make an abstract class with basic logic and delegate the algorithms for another class who implements this basic logic.

In this source code example, I'll try to show you how to implement this in order to make a post algorithm on many social networks. Each one with their own login process.

## UML
![UML](https://upload.wikimedia.org/wikipedia/commons/2/2a/W3sDesign_Template_Method_Design_Pattern_UML.jpg)

> Img source: Wikipedia