Ternary Search

https://www.hackerearth.com/practice/algorithms/searching/ternary-search/tutorial/


Tutorial Problems
Like linear search and binary search, ternary search is a searching technique that is used to determine the position of a specific value in an array. In binary search, the sorted array is divided into two parts while in ternary search, it is divided into 
3
 parts and then you determine in which part the element exists.

Ternary search, like binary search, is a divide-and-conquer algorithm. It is mandatory for the array (in which you will search for an element) to be sorted before you begin the search. In this search, after each iteration it neglects 
⅓
⅓
 part of the array and repeats the same operations on the remaining 
⅔
⅔
.

Implementation

int ternary_search(int l,int r, int x)
{
    if(r>=l)
    {
        int mid1 = l + (r-l)/3;
        int mid2 = r -  (r-l)/3;
        if(ar[mid1] == x)
            return mid1;
        if(ar[mid2] == x)
            return mid2;
        if(x<ar[mid1])
            return ternary_search(l,mid1-1,x);
        else if(x>ar[mid2])
            return ternary_search(mid2+1,r,x);
        else
            return ternary_search(mid1+1,mid2-1,x);

    }
    return -1;
}
Let us consider the following example to understand the code.

Let the sorted array be  
a
r
[
]
=
{
2
,
3
,
5
,
6
,
8
,
9
,
12
,
13
,
14
}
 with indices from 0 to 8. You are required to find the position of 
x
=
13
 in this array. Divide the sorted array into the following 
3
 parts by evaluating the values of 
m
i
d
1
 and 
m
i
d
2
:


{
2
,
3
,
5
}
 
{
6
,
8
,
9
}

{
12
,
13
,
14
}
Here 
a
r
[
m
i
d
1
]
=
5
 and 
a
r
[
m
i
d
2
]
=
12
. As 
13
 is not equal to 
a
r
[
m
i
d
1
]
 and 
a
r
[
m
i
d
2
]
 and it is also not smaller than 
a
r
[
m
i
d
1
]
, you can safely assume that it lies in the 
3
r
d
 part of the array as it is greater than 
a
r
[
m
i
d
2
]
.

Run the ternary search again with 
l
=
7
 and 
r
=
8
.

Now, 
a
r
[
m
i
d
1
]
=
a
r
[
7
]
=
13
 and 
a
r
[
m
i
d
2
]
=
a
r
[
8
]
=
14
.

As 
a
r
[
m
i
d
1
]
=
x
 , 
m
i
d
1
 is the required answer.

If the value is not in the array, it returns 
−
1
 as the answer.

Complexity
 
O
(
l
o
g
3
N
)
 , where 
N
 is the size of the array

Use of ternary search:

This concept is used in unimodal functions to determine the maximum or minimum value of that function. Unimodal functions are functions that, have a single highest value.

Let us consider a function 
f
u
n
c
 in the interval 
[
a
,
b
]
, and you are required to determine the 
x
 for which 
f
u
n
c
(
x
)
 is maximized. The function 
f
u
n
c
 is unimodal in nature, i.e. it strictly increases in the interval 
[
a
,
x
]
 and strictly decreases in the interval 
[
x
,
b
]
.

This can be done by various other methods like double differentiation or by using a modified binary search. In the case when the function cannot be differentiated easily, ternary search is useful. It is less prone to errors and easy to implement when:

Dealing with floating point integers
Required maximum value is reached at the end of the interval.
