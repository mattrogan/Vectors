# Vectors
A C# object-oriented implementation of Vectors using unit tests.

## Definition

A **vector** is a position on a plane that has both *direction* and *magnitude*.

A `Vector` is represented internally by an array of $n$ dimensions. For example, a 3-dimensional `Vector` object can be represented as:
$$
\begin{pmatrix}
a \\ b \\ c
\end{pmatrix}
$$
This is a column vector, however in our program it will be printed as `<a, b, c>`. Vectors can have a scalar product applied, that will affect its magnitude:
$$
\lambda \cdot \begin{pmatrix}
a \\ b \\ c
\end{pmatrix}
= 
\begin{pmatrix}
\lambda \cdot {a} \\ \lambda \cdot {b} \\ \lambda \cdot {c}
\end{pmatrix}
$$

## Attributes
A `Vector` only has one internal attribute: `_vector`. This is a `float` array of length $n$, containing the values for each dimension of the vector.

## Methods

### Constructor
We can construct vector objects in one of two ways:

1. Using a blank vector: `Vector()`. This will initialise an empty vector, with two dimensions set to zero.

2. Using pre-determined dimensions: `Vector(dims)`. This will set the internal dimensions to the pre-determined ones.



### Setter

### Getter

### Mutator