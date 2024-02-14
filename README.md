# Issue
My laptop is running a single-language windows OS with russian language. There is a difference between regions when you use excel - some countries use comma "," to indicate that the number is decimal, but other countries use dot "." to do the same.  
This patters also applied for the numbers in Invoices.txt file. If your windows accepts decimal numbers using "," it will throw an error in case of encountering "." sign. To solve that I used following line of code
```
var culture = CultureInfo.InvariantCulture; //73rd line of Form1.cs file
```
and I used this variable in the following lines  
```
var date = DateTime.Parse(split[0], culture); //86th line of Form1.cs file
var dateForModel = DateTime.Parse(split[0], culture).ToString("MMMM"); //87th line of Form1.cs file
```
I passed the ```culture``` variable as an argument to ```Parse()``` method, so the numbers started parsing to a decimals, but if it throws an error on your pc, please delete ```culture``` variable from method - it should help.  
