# Linear Searching Algo

## Problem Statement
Given a list of N elements, a1, a2.... an search if element x exists in the list

## Algorithm Details

### steps
1. Start from first element
2. Compare the element with x 
3. if found to be same, return the result as passed and stop
4. if not move to next element and goto step 2
5. if end of list is reached return result as failure and stop

### analysis
- The time complexity of the above algorithm is O(n).
- can be improved to O(n/2) by searching from both ends.

### usage
The list is unsorted and is only to be searched once
The list is small (though this itself is a vague notion - I've read less than around 100 elements?)
The list will need sorting following the search operation (due to say an insertion), since the resorting will dominate the time complexity of the overall task
The data structure is not random access (like a linked-list)
There is no knowledge of the data that could aid searching (relative proximities?)


## References
- https://medium.com/@ysmiracle/linear-search-vs-binary-search-and-why-we-should-approach-any-problem-using-binary-search-as-a-eca2f72d76b0
- 
