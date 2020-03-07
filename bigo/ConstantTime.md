---
layout: post
title: "Time Complexity O(1) - Constant Time"
categories: bigo
---

Let us look a the below method which simply prints the input.

```csharp
public static void PrintSomething(object input)
{
    Console.WriteLine($"{input}");
}
```

Let's count the number of steps in this particular method.

```csharp
public static void PrintSomething(object input)
{
    Console.WriteLine($"{input}");
    //O(1)
    Console.WriteLine("Done");
    //O(1)
}
```

We can say the overall time it takes to execute the above method is O(1 + 1) = O(2). No matter what the input is the runtime of this algorithm is not going to change baring say input size which is not related to time complexity and its not something we have control on. Hence this is Constant Time, which we denote as O(1). Let's visualize Constant time by looking at the below chart.

![Constant Time](./img/constant.jpg)

[Next >> Linear Time O(n) Example](./LinearTime.md)

[Previous << Steps to Derive Time Complexity - Take 2](./Rules.md)

[Index](./README.md)
