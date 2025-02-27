- To return an IList<IList<T>>, instantiate a List<IList<T>>, then add to that.
- Don't try to give them anymore than they ask for! For example, if you're looking for max sub array, but they don't ask for left and right pointers, you may not need to track left/right indices.
<<<<<<< Updated upstream
- Don't hesistate to use recursion; sometimes for me, it makes more sense to break the problem down recursively than iteratively. With iteration you manage stop/start criteria, which you do for recursion too, but with recursion, sometimes those criteria just make more sense as the solution to a subproblem rather than a step in the whole problem. Take Jump Game II for example.
=======
- Test cases to consider: negative numbers, zero, near the stated bounds of the problem, array of length 0, array of length 1.
>>>>>>> Stashed changes
