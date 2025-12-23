1) **Kadane's Algorithm (Classic and sliding window variation)**
   **Pitfalls:**
      - Pure Kadane doesn’t handle fixed-size or exact-length constraints—use sliding window.
      - For circular arrays, combine Kadane with inverted-sum trick.

2) **Sliding Window (Fixed and Variable Variations)**: 
**Pitfalls:**
- Negative numbers break monotonicity for sum ≥ S problems—consider two pointers variants or prefix sum.
- Be precise with shrink condition to avoid off-by-one errors.

4) **Two Pointers**

Applications:


4) **Prefix Sum** : The core purpose of the **Prefix Sum or Cumulative sum** is to solve the efficiency bottleneck caused by **repeated range queries** on static data.

Applications:
**Pattern 1: Basic Range questions**
- [Leetcode problem - 238](https://leetcode.com/problems/product-of-array-except-self/description/ )
- [Leetcode problem - 724](https://leetcode.com/problems/find-pivot-index/description/)
**Pattern 2: Prefix Sum + Hash Map**
- [Leetcode problem - 560](https://leetcode.com/problems/subarray-sum-equals-k/description/)
**Pattern 3: 2D Prefix Sum**
  
5) **Binary Search**

