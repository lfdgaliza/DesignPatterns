# Prototype

## UML Diagram
![UML Diagram](https://upload.wikimedia.org/wikipedia/commons/thumb/1/14/Prototype_UML.svg/678px-Prototype_UML.svg.png)

> Img source: Wikipedia

## When do I have to use this?

Prototype DP makes easy to clone an existing object.

So, if it is heavy to create a new Object because you have to fill it with some basic information, it is better to just clone it from an existing object than to load everything from the database, right?
That's the reason behind this.

Of course that if you have to do it several times, maybe you can consider using only shallow copies or the flyweight pattern for a better resources usage...
Flyweight is structural, so it is a different approach.

Here in this project, I will give focus to the Prototype DP. 

# An image to remember
![Dolly the Sheep](/img/dolly.jpg)
>Dolly the Sheep