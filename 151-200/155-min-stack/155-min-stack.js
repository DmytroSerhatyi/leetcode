/**
 * initialize your data structure here.
 */
var MinStack = function () {
    this.stack = [];
    this.min = [];
};

/** 
 * @param {number} x
 * @return {void}
 */
MinStack.prototype.push = function (x) {
    this.stack.push(x);
    var min = this.min;

    if (min.length === 0 || min[min.length - 1] >= x) {
        min.push(x);
    }
};

/**
 * @return {void}
 */
MinStack.prototype.pop = function () {
    var temp = this.stack.pop();
    var min = this.min;

    if (temp === min[min.length - 1]) {
        min.pop();
    }
};

/**
 * @return {number}
 */
MinStack.prototype.top = function () {
    var stack = this.stack;
    return stack[stack.length - 1];
};

/**
 * @return {number}
 */
MinStack.prototype.getMin = function () {
    var min = this.min;
    return min[min.length - 1];
};

/** 
 * Your MinStack object will be instantiated and called as such:
 * var obj = Object.create(MinStack).createNew()
 * obj.push(x)
 * obj.pop()
 * var param_3 = obj.top()
 * var param_4 = obj.getMin()
 */
