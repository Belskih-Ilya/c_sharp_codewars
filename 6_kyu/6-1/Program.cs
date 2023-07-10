// Write a function that accepts an array of 10 integers (between 0 and 9), that returns a string of those numbers in the form of a phone number

string PhoneNum(int[] arr)
{
    return $"({arr[0]}{arr[1]}{arr[2]}) {arr[3]}{arr[4]}{arr[5]}-{arr[6]}{arr[7]}{arr[8]}{arr[9]}";
    
}

int[] arr = { 9, 2, 0, 2, 5, 8, 1, 9, 1, 3 };
Console.WriteLine(PhoneNum(arr));