/**
 * Initialize your data structure here.
 */
var MyQueue = function () {
    this.stack = [];
    this.revertedStack = [];
};

/**
 * Push element x to the back of queue. 
 * @param {number} x
 * @return {void}
 */
MyQueue.prototype.push = function (x) {
    var stack = this.stack;

    this._reverseStack(this.revertedStack, stack);

    this.stack.push(x);
};

/**
 * Removes the element from in front of queue and returns that element.
 * @return {number}
 */
MyQueue.prototype.pop = function () {
    var rStack = this.revertedStack;

    this._reverseStack(this.stack, rStack);

    return rStack.pop();
};

/**
 * Get the front element.
 * @return {number}
 */
MyQueue.prototype.peek = function () {
    var rStack = this.revertedStack;

    this._reverseStack(this.stack, rStack);

    return rStack[rStack.length - 1];
};

/**
 * Returns whether the queue is empty.
 * @return {boolean}
 */
MyQueue.prototype.empty = function () {
    return this.stack.length === 0 && this.revertedStack.length === 0;
};

MyQueue.prototype._reverseStack = function (s, rS) {
    var l = s.length;

    while (l > 0) {
        rS.push(s.pop());
        l--;
    }
};

/** 
 * Your MyQueue object will be instantiated and called as such:
 * var obj = Object.create(MyQueue).createNew()
 * obj.push(x)
 * var param_2 = obj.pop()
 * var param_3 = obj.peek()
 * var param_4 = obj.empty()
 */
