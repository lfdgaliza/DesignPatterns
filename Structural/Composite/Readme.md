# Composite
Composite allows us to work with a set of objects as if it were just one.

There are two possibilities for the Composite Pattern: Design for uniformity or for type safety.  
I personally dislike both of them because of that reasons:   
If we chose Design for uniformity then we must break the Interface Segregation principle since we have unused methods in the leaves.
If we chose Design for Type Safety we must be always checking the type of an object.  

Wouldn't be better if the entire structure was immutable? It could avoid this two problems above.  
In order to be immutable every time that I need to change the structure, I would need to create a new one avoiding, thus, a lot of problems.

What do you think?

In any case, I choose the Design for Uniformity because I really dislike casts since it reminds me Java somehow (yuck) :p

## UML

![UML](https://upload.wikimedia.org/wikipedia/commons/3/39/W3sDesign_Composite_Design_Pattern_Type_Safety_UML.jpg)

> Img source: Wikipedia