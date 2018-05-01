# Singleton Pattern
## Why is it good
* Ensures that the class has only one instance  
## Why is it bad
It is considered as an anti-pattern due to some reasons:
* Introduces a global state into the application
* It is bad when it is used when it is not necessay
* Increase the coupling
### However
It can be used as a good strategy in some cases when configured as a kind of bind in containers.
Dotnet core, for instance, has an option to bind an implementation of some interface as a singleton instance.

In this case, this can be used when it is necessary without compromising the application structure.

## Implementations
This project has two implementations
* Default (default implementation of Singleton)
* Di (using the built-in dotnet core container)