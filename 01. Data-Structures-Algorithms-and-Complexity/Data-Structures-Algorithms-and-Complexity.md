## Data Structures, Algorithms and Complexity Homework

1. Task1
  - Assuming that the input array length is n, the for loop iterates n times. The nested while loop also iterates n times. Ignoring the operations that run in constant time (comparing, incrementing, decrementing etc), the algorithm runs in O(n^2).

2. Task2
  - Worst case (the first column consists of only even numbers) - The algorithm will run in *O(n * m)* time, because for every `n`-th row we iterate `m` numbers.
  - Average case (half of the numbers in the first column are odd/even) - The algorithm will run in *O(n * m/2)* time.
  - Best case (the first column consists of only odd numbers) - The algorithm will run in *O(n)* time, because the inner `for` loop will not be executed.

3. Task3
  - Worst case (`CalcSum` is called with zero as a second parameter) - The `for` loop will run in *O(n)* and the recursion will run in *O(m - 1)*, therefore the overall complexity of the algorithm will be *O(n * m)*.
  - Best case (`CalcSum` is called with second parameter `row` where `row` ∈ [`m` - 1; +∞)) - The `for` loop will run in *O(n)* and the recursive call won't be reached at all. The overall complexity will be
 *O(n)*.