/**
 * @param {number[]} nums
 */
var NumArray = function (nums) {
    this.sums = [0];

    for (var i = 0, l = nums.length; i < l; i++) {
        this.sums[i + 1] = this.sums[i] + nums[i];
    }
};

/** 
 * @param {number} i 
 * @param {number} j
 * @return {number}
 */
NumArray.prototype.sumRange = function (i, j) {
    return this.sums[j + 1] - this.sums[i];
};

/** 
 * Your NumArray object will be instantiated and called as such:
 * var obj = Object.create(NumArray).createNew(nums)
 * var param_1 = obj.sumRange(i,j)
 */
