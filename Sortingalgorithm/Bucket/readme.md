Divide into bucket
There can be many strategies 

Say for an input whose range is floating point value between 0 to 1.0
- Bucket: arr[i] * 10 => to int 

Say for input with integer data
- bucket : arr[i] * arr.length/ (max of array)

Note: 
- Best case happens when data is uniformly distributed 
- Worst case happens when all data are present in a single bucket 


