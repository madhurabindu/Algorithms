
Exponential search involves two steps:  

Find range where element is present

Do Binary Search in above found range.

How to find the range where element may be present? 

The idea is to start with subarray size 1, compare its last element with x, then try size 2, then 4 and so on until last element of a subarray is not greater. 
Once we find an index i (after repeated doubling of i), we know that the element must be present between i/2 and i (Why i/2? because we could not find a greater value in previous iteration)

Time Complexity : 
The first stage of the algorithm takes O(log i) time, where i is the index where the search key would be in the list. This is because, in determining the upper bound for the binary search, the while loop is executed exactly log(i)  times. Since the list is sorted, after doubling the search index log(i)  times, the algorithm will be at a search index that is greater than or equal to i as 2 to the power of log(i) >= i. As such, the first stage of the algorithm takes O(log i) time.

The second part of the algorithm also takes O(log i) time. As the second stage is simply a binary search, it takes O(log n) where n is the size of the interval being searched. The size of this interval would be 2j - 2j - 1 where, as seen above, j = log i. This means that the size of the interval being searched is 2log i - 2log i - 1 = 2log i - 1. This gives us a run time of log (2log i - 1) = log (i) - 1 = O(log i).

This gives the algorithm a total runtime, calculated by summing the runtimes of the two stages, of O(log i) + O(log i) = 2 O(log i) = O(log i).


Auxiliary Space : The above implementation of Binary Search is recursive and requires O(Log n) space. With iterative Binary Search, we need only O(1) space.

Applications of Exponential Search: 
Exponential Binary Search is particularly useful for unbounded searches, where size of array is infinite. Please refer Unbounded Binary Search for an example.
It works better than Binary Search for bounded arrays, and also when the element to be searched is closer to the first element.

Variation
https://en.wikipedia.org/wiki/Exponential_search
