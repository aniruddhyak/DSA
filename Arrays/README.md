1) **Kadane's Algorithm (Classic and sliding window variation)**
   **Overview (Classic):** Finds the maximum subarray sum in O(n) by tracking:
   curr_sum = max(a[i], curr_sum + a[i])
   best = max(best, curr_sum)
   Works with negatives; resets when the running sum hurts the total.
   **Use When:**
   - You need the max sum of any contiguous subarray.
   - Array may contain negative numbers.
   **Variation (Sliding Window flavored):**
     When constraints force a bounded window (e.g., fixed length k or at most k), and numbers are non-negative, use a sliding window to keep/grow/shrink the sum while respecting constraints.
   **Why this pattern:**
     - Linear time, constant space.
     - Simple, robust baseline for contiguous-sum optimization problems.
   **Pitfalls:**
      - Pure Kadane doesn’t handle fixed-size or exact-length constraints—use sliding window.
      - For circular arrays, combine Kadane with inverted-sum trick.

2) **Sliding Window (Fixed and Variable Variations)**: Maintain a contiguous window [l…r] and move pointers to keep a property true.
   - Fixed Window: Window size is exactly k (e.g., max sum/avg over k, count anagrams of size k).
   - Variable Window: Window grows/shrinks to satisfy a condition (e.g., longest substring with ≤ K distinct, shortest subarray with sum ≥ S).
**Use When:**
You are dealing with contiguous segments and a local property that’s checkable incrementally.
Elements often non-negative (especially for sum-based windows).

**Why this pattern:**
- O(n) time with constant/low overhead.
- Natural fit for streaming, strings, and range constraints.

**Pitfalls:**
- Negative numbers break monotonicity for sum ≥ S problems—consider two pointers variants or prefix sum.
- Be precise with shrink condition to avoid off-by-one errors.


4) **Two Pointers**

Applications:


4) **Prefix Sum** : The core purpose of the **Prefix Sum or Cumulative sum** is to solve the efficiency bottleneck caused by **repeated range queries** on static data.

Applications:
**Pattern 1: Basic Range questions**
- [Leetcode problem - 238](https://leetcode.com/problems/product-of-array-except-self/description/ )
**Pattern 2: Prefix Sum + Hash Map**
- [Leetcode problem - 560](https://leetcode.com/problems/subarray-sum-equals-k/description/)
**Pattern 3: 2D Prefix Sum**
  
5) **Binary Search**

