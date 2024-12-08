# F# Mutable Variable Unexpected Behavior

This example demonstrates a common pitfall in F# when dealing with mutable variables and immutable bindings.  The `y` variable is bound to the initial value of `x` and isn't updated when `x` changes.