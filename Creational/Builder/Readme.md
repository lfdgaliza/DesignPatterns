# Builder
\- Binf.  
\- Binf?  
\- Yes, Binf.  
\- Ok... But... What is Binf?  
\- Builder is not Fluent.

> I am so sorry about that...

I don't know whether this expression was sometimes used or not for someone, but I put here to remind you that Builder and Fluent are different concepts. I did it because there is a lot of people that think that Builder and Fluent are the same, but, believe me, they are not.

**The Builder Pattern is about how can you construct a complex object.**  

Fluent, in another hand, is more like a Facade where you can join different objects in a more readable way. Like Entity Framework, for example! =)

So, in this source, you will find a complex solution for a simple problem for learning reasons. The goal here is to make you understand how to implement this pattern for when you need it in a real complex situation.

## UML Diagram
![UML](https://upload.wikimedia.org/wikipedia/commons/thumb/f/f3/Builder_UML_class_diagram.svg/1400px-Builder_UML_class_diagram.svg.png)

> Img source: Wikipedia

## SOLID
You can find this a great example of open/closed principle =)

## Players in this code
* Abstract Builder: IMobilePhoneBuilder
* Concrete Builders
    * IphoneXBuilder
    * Redmi3ProBuilder
    * S9Builder
* Director: MobilePhoneDirector
* Product: MobilePhone

## An image to remember
![Binf](/.aitr/binf.png)
> Ok... I know... This is not exactly an image, but you've got the point.