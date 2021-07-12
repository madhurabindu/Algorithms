# Binary Searching Algo

## Problem Statement
Given a SORTED list of N elements, a1, a2.... an search if element x exists in the list

## Algorithm Details
Search a sorted array by repeatedly dividing the search interval in half. Begin with an interval covering the whole array. If the value of the search key is less than the item in the middle of the interval, narrow the interval to the lower half. Otherwise, narrow it to the upper half. Repeatedly check until the value is found or the interval is empty.

### steps
1. start with a sorted list
2. Start from middle element
3. Compare the mid element with x 
4. if found to be same, return the result as passed and stop
5. if x is smaller than mid element search from a1 to an/2
6. if x is bigger than mid element then search from an/2 to an
7. goto step 2 with the new range
8. repeat till only one element is left

## Implementation
note can be implemented iteratively or using recursion

### analysis
- The time complexity of the above algorithm is O(log(n)).
- Auxiliary Space: O(1) in case of iterative implementation. In the case of recursive implementation, O(Logn) recursion call stack space.

### usage
The list is sorted 

## Alternates
can be implemented using binary tree or trie based on requirement
use interpolation search 

## References
- https://medium.com/@ysmiracle/linear-search-vs-binary-search-and-why-we-should-approach-any-problem-using-binary-search-as-a-eca2f72d76b0
- 

