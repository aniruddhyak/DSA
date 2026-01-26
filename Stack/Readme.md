This outlines the core strategies for solving Stack-based problems in technical interviews. In FAANG rounds, the Stack is rarely just about Push and Pop; it's about managing state and optimizing time complexity.

**Core Mental Model:** "Deferred Processing"
The Stack is used when we encounter an element but cannot process it yet. We "park" it in the stack until we find its "partner" or "boundary" later in the input.

**Strategies & Problem Sets**
  1. Monotonic Stack: The stack is kept in a strictly _increasing or decreasing_ order.
      • Trigger: "Find the next greater/smaller element" or "Find the nearest boundary."
      • Key Logic: while (stack.Count > 0 && current > stack.Peek()) { stack.Pop(); }
      • Problems:
        • [LC 739] Daily Temperatures (Medium)
        • [LC 496] Next Greater Element I (Easy)
        • [LC 84] Largest Rectangle in Histogram (Hard)
  2. Nested Symmetry (Parsing): Every "opener" must have a "closer" in LIFO order.
    • Trigger: Parentheses ()[]{}, HTML tags, or file paths /../.
    • Key Logic: Use a Dictionary for mapping and a StringBuilder for reconstruction.
    • Problems:
        • [LC 20] Valid Parentheses (Easy)
        • [LC 1249] Minimum Remove to Make Valid Parentheses (Medium)
        • [LC 71] Simplify Path (Medium)
  3. Level & State Tracking: The current value is multiplied or modified by how "deep" it is nested.
    • Trigger: Strings like 3[a2[c]] or mathematical expressions with ().
    • Key Logic: Use two stacks (e.g., countStack and stringStack) or store the current result on the stack before entering a new level.
    • Problems:
        • [LC 394] Decode String (Medium)
        • [LC 856] Score of Parentheses (Medium)
        • [LC 227] Basic Calculator II (Medium)
  4. Custom Design: Augment the stack to provide extra functionality in O(1).
    • Trigger: "Design a data structure that..."
    • Key Logic: Use a secondary stack to track metadata (min/max) or two stacks to reverse order.
    • Problems:
    • [LC 155] Min Stack (Medium)
    • [LC 232] Implement Queue using Stacks (Easy)

**Important Notes for Interview Success**
1. Complexity Pitfalls (The O(n) Argument)
Even with a while loop inside a for loop, Monotonic Stack solutions are O(n).
    _This is O(n) because each element is pushed and popped exactly once. The total number of operations is 2n, which is amortized linear time._
2. Best Practices
  • Empty Checks: Always check stack.Count > 0 before calling Peek() or Pop() to avoid InvalidOperationException.
  • Indices vs. Values: When calculating distances (like in Daily Temperatures or Histogram), store the index in the stack, not the value. We can always get the value from arr[index], but we can't get the index from the value.
  • Performance: Use StringBuilder when the stack result needs to be converted back into a string.
3. Boundary Handling
  • The "Sentinel" Value: For problems like Largest Rectangle in Histogram, adding a 0 or a -1 at the end of your input array can help "flush" the stack automatically, ensuring all remaining elements are processed without extra code.
4. Space Trade-offs
  • If an interviewer asks to optimize O(n) space, look for a Two-Pointer approach (if the data is sorted) or a Greedy approach.
 
