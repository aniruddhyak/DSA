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

**Basic Range questions**
- [Leetcode problem - 238](https://leetcode.com/problems/product-of-array-except-self/description/ )
- [Leetcode problem - 724](https://leetcode.com/problems/find-pivot-index/description/)
  
**Prefix Sum + Hash Map**
- [Leetcode problem - 560](https://leetcode.com/problems/subarray-sum-equals-k/description/)
- [Leetcode problem - 525](https://leetcode.com/problems/contiguous-array/description/)
- [Leetcode problem - 974](https://leetcode.com/problems/subarray-sums-divisible-by-k/description/) 
  
**2D Prefix Sum**
- [Leetcode problem - 304](https://leetcode.com/problems/range-sum-query-2d-immutable/description/)

**Advanced - Difference Array**
- [Leetcode problem - 1109](https://leetcode.com/problems/corporate-flight-bookings/description/)
- [Leetcode problem - 1074](https://leetcode.com/problems/number-of-submatrices-that-sum-to-target/description/)

5) ****
6) **Binary Search**

