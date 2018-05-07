# Bridge
The Bridge pattern intent is to *"decouple an abstraction from its implementation so that the two can vary independently"*.

If you are like me you must be thinking:  
**\- WHAT?**

I think it is a complex description of a not so complex problem.  

To better understand, we must think in problems involving cartesian products.

If you do not remember what the heck cartesian product is, look that example:

```
S1 = { A, B, C }
S2 = { 1, 2, 3 }
```

The cartesian product of this two sets is:

```
RS = { A1, A2, A3, B1, B2, B3, C1, C2, C3 }
```

You have 9 items for a resultant set.  
Now think it as being classes.  
Imagine that you have many ways to show some information like one more resumed for mobile phones and one more detailed for web browsers running on a PC. And in the future, someone can ask you to do something for smart watchers too! What would you do?

You can make a cartesian product, like joining every possible combination:

```
S1 = { Book, Movie, Person }
S2 = { WebBrowser, Mobile, SmartWatch }

RS = {
    WebBrowserBookView
    MobileBookView
    SmartWatchBookView

    WebBrowserMovieView
    MobileMovieView
    SmartWatchMovieView

    WebBrowserPersonView
    MobilePersonView
    SmartWatchPersonView
}
```

Or... You can *"decouple an abstraction from its implementation so that the two can vary independently"*.

Doing that, instead of having s1.length * s2.length you would rather have s1.length + s2.length.  
In other words, instead of having 9 classes you would have just 6 classes.

## UML Diagram
![UML](https://upload.wikimedia.org/wikipedia/commons/f/fd/W3sDesign_Bridge_Design_Pattern_UML.jpg)

> Img source: Wikipedia

Note that the main goal of this pattern is to transform inheritance in composition.

It is better for maintenance AND you will also be applying the open/closed principle! Look what a wonderful thing!

Now take a look at the source code to see it in action.

## An image to remember
![Cartesian Product](/img/cartesian-products.jpg)  
*When you have this, it is time to use the Bridge Pattern!*

> Img source: [Mathstopia](https://www.mathstopia.net/sets/cartesian-product)