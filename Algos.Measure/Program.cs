
int[] arr = { 1, 2, 3, 4, 5 };
int left = 0;
int right = arr.Length;
var middle = arr.Length/2; //2

var slice = arr[0..middle];
var slice2 = arr[middle..right];
var s = slice;