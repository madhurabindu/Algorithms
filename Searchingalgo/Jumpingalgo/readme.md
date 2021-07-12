# Jump Search / Block Search



Time Complexity : O(√n) 
Auxiliary Space : O(1)
Important points: 
 

Works only sorted arrays.
The optimal size of a block to be jumped is (√ n). This makes the time complexity of Jump Search O(√ n).
The time complexity of Jump Search is between Linear Search ( ( O(n) ) and Binary Search ( O (Log n) ).
Binary Search is better than Jump Search, but Jump search has an advantage that we traverse back only once (Binary Search may require up to O(Log n) jumps, consider a situation where the element to be searched is the smallest element or smaller than the smallest). So in a system where binary search is costly, we use Jump Search.


Optimal Size of m (Block size to be skipped)

The worst-case scenario requires:

n/m jumps, and
(m-1) comparisons (in case of linear search if x < A[km])
Hence, the total number of comparisons will be (n/m+(m-1)). 
This expression has to be minimum, so that we get the smallest value of m (block size).

On differentiating this expression with respect to m and equating it with 0, we get:

n/-m2+1 = 0

n/m2 = 1

m = √n

Hence, the optimal jump size is √n, where n is the size of the array to be searched or the total number of elements to be searched.


Evidently, Jump Search always seeks forward on its arrays unlike back and forth search methods like Binary Search. This behavior makes Jump Search much more efficient for searches on data stored on physical drives with spinning mediums.

** How is the perfect block size √N? **
Consider the list to be of size N and Block size of size B.
In the worst case, we have to do N/B jumps and if the element is not present, we perform B-1 comparisons. Therefore, the total number of comparisons in the worst case will be ((N/B) + B-1). The value of the function ((N/B) + B-1) will be minimum when B = √N.
Therefore, the best block size is B = √N.
