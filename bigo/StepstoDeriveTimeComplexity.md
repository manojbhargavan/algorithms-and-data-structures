---
layout: post
title: "Steps to Derive Time Complexity - Take 1"
categories: bigo
---

We have two major steps to derive the complexity of an algorithm:

- Consider only the fastest-growing term
- Take out the coefficient(s)

Let us look at an example to understand the steps above. The below method takes in an integer n and calculates the running total of number from 1 to n.

```csharp
public static long CalculateRunningTotal(long n)
{
    int runningTotal = 0;
    for(long i = 1; i <= n; i++)
    {
        runningTotal += i;
    }
    return runningTotal;
}
```

Let's take a look at the steps involved in this function or algorithm.

```csharp
public static long CalculateRunningTotal(long n)
{
    int runningTotal = 0; // 1 step
    // Generally we do not consider assignment as a step,
    // but for simplicity we will say this takes say 1 step.
    for(long i = 1; i <= n; i++) // n step(s)
    // Since the for loop is executed n times
    {
        runningTotal += i;
    }
    return runningTotal; // 1 step
    // Generally we do not consider returning as a step,
    // but for the sake of understanding let us say 1 step.
}
```

So the number of steps of time which it take is 1 + n + 1 = n + 2 = O(n + 2)

Step 1: Consider only the fastest-growing term --> In this case O(n + 2), 2 is a constant and n increases as the input size increases hence n is the fastest-growing term. So we remove 2 hence we have O(n).
Step 2: Take out the coefficient(s) --> In this case O(n) does not have any coefficient.

Hence the time complexity of the above function is O(n) (spelled 'Big O of n'), or Linear Time.

## Few examples Terms

We will look at some made-up number of steps for an unknown algorithm. This will help us understand the steps in depth although you might not encounter such terms in real-world algorithms or maybe you will. n is the input size for all of the below examples.

When we say "STEP1" we mean "Consider only the fastest-growing term" and by "STEP2" we mean "Take out the coefficient(s)".

- T = O(an + b + 2c)
  - STEP1: The fastest-growing term in the above term is **"an"**, since b and 2c are constants no matter how big it is as n grow significantly "b" and "2c" does not certainly grow and will have little to no impact on the runtime. "an" on the other hand is directly related to n and is the fastest-growing term. Hence after this step we are left with **O(an)** since we removed the constants **b + 2c**.
  - STEP2: "a" is the only coefficient in the term O(an). Once we remove that we are left with just **O(n)**. Hence the above term belongs to a "Linear Time" algorithm.
- T = O(cn^2 + bn + a)
  - STEP1: cn^2 is the fastest growing term since 'a' is a constant and no matter how big 'b' is cn^2 is clearly the fastest growing eventually. Hence we are left with O(cn^2)
  - STEP2: Let's get rid of the coefficient c and we are left with **O(n^2)** which is Quadratic Time.

[Next >> Steps to Derive Time Complexity - Take 2](./Rules.md)

[Previous << Overview Of Big O Notation](./Overview.md)

[Index](README.md)
