I used inheritance because all transport types share a common identity as vehicles. 
This lets us centralize shared state like Name and handle different vehicle types uniformly
I used interfaces to model orthogonal capabilitiessuch as flying, driving, or sailing that can be mixed into any vehicle regardless of its position in the class hierarchy.
A Helicopter cannot inherit from both Vehicle and Airplane because C# forbids multiple class inheritance, avoiding ambiguity issues like the diamond problem, where overlapping logic from two parents could conflict.
A Helicopter can implement multiple interfaces because C# allows a class to implement any number of interfaces; they define behavioral contracts without imposing shared implementation.