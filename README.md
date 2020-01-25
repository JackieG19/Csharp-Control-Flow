## Conditional Statement

**If / else**
```
if(condition)
  some statement
  
else if(another condition)
  another statement

else
  yet another statement
```
```
if(condition)
{
   some statements
}

else
{
   other statements
}
```

**Nested if Statement**
```
if(condition)
{
  if(another condition)
  {
    some statements 
  }
  else
  {
    other statements
  }
}
```

**Switch / case**
```
switch(role)
{
  case Role.Admin:
    ...
    break;
    
  case Role.Modertor:
    ...
    break;
    
  default
    ...
    break;
}
```
___

## Iteration Statements

**For Loop**
```
for (var i = 0; i < 10; i++)
{
  // (initialization clause, condition clause, Iteration clause)
  ... // block of statement that will excute
}
```

**ForEach Loop**
```
foreach (var number in numbers)
{
  // (local/temp value in keyword object that is iterating)
  ... // block of statement that will excute
}
```

**While Loop**
```
whilec (i < 10) // (condition) as long as its valid the loop will excute
{
  ... // block of statement that will excute
  // typically have a counter initialize before the loop is excute
  i++; // at the end of the while loop, incremented
}
```

**Do-While Loop**
```
do // the loop is ecute at least once...
{
  ... // block of statement that will excute
  i++; // have the counter which incremented or decrement (i--)
  
} // beacuse the condition is evaluated at the end of the loop
while(i <10);
```

**Break and Continue**
- break: jumps out of the loops
- continue: jumps to the next itertion
___

Next -> [Arrays and Lists](https://github.com/JackieG19/Csharp-Arrays-and-Lists)
