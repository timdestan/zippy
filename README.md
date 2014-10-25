##zippy##

This repository contains a type-safe F# implementation of zip that can be generalized to any number of arguments.

This implementation is based on the Haskell solution presented by Daniel Fridlender and Mia Indrika in *Do we Need Dependent Types?*

The functions are defined on the `LazyList` type declared in `Fsharpx.Collections` because it is the closest analogue in F# that I am aware of to the Haskell lists used in the original report.
