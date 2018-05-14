# Proxy
The intent of proxy pattern is to wrap some object in order to use this indirectly.

\- Ok, but why do I need to use an object in such indirect way?

There are 4 reasons for that:

## Reasons to use

1. You want to create a placeholder for a real object which is too expensive to create. In this case, your proxy will be called a **Virtual Proxy**
2. You want to have a local representation of an object which resides in a different address space. This is used as stub code in a distributed architecture and you can call this a **Remote Proxy**
3. You want to protect some resources adding some security checks prior to access them. You can call this a **Protective Proxy**
4. You want to add some functionality to some existing object. In this case, I think C# extensions are better. But if for some reason you want to use this pattern, you can call this a **Smart Proxy**

All these names are just explanations of what you are doing with the proxy. The implementation is pretty much the same in all of these cases and you can find the UML Diagram just below:

## UML
![UML](https://upload.wikimedia.org/wikipedia/commons/6/6e/W3sDesign_Proxy_Design_Pattern_UML.jpg)

> Img source: Wikipedia

## Source Code
In the source code, you can find an implementation of a Protective Proxy.