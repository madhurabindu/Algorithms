
1. Find pivot - either first pos or last position or median or random position 
2. Find the right position of the pivot by parsing the array, if you find an element smaller than pivot, start putting it from 0th position and increase the index.. 
at the end of this pass you have index of the point at which all elements are lesser than pivot 
Increase the index and put the pivot there
3. Now do the same for sub array 0-pivot index -1 and 
4. Do same to pivot index +1 to max size 
