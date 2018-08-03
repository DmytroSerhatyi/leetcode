/*
// Definition for a QuadTree node.
public class Node {
    public bool val;
    public bool isLeaf;
    public Node topLeft;
    public Node topRight;
    public Node bottomLeft;
    public Node bottomRight;

    public Node(){}
    public Node(bool _val,bool _isLeaf,Node _topLeft,Node _topRight,Node _bottomLeft,Node _bottomRight) {
        val = _val;
        isLeaf = _isLeaf;
        topLeft = _topLeft;
        topRight = _topRight;
        bottomLeft = _bottomLeft;
        bottomRight = _bottomRight;
}
*/
public class Solution
{
    public Node Construct(int[][] grid)
    {
        var height = grid.Length;

        if (height == 0) return null;

        return Devide(grid, 0, grid[0].Length - 1, 0, grid.Length - 1);
    }

    public Node Devide(int[][] grid, int firstIndexWidth, int lastIndexWidth, int firstIndexHeight, int lastIndexHeight)
    {
        if (firstIndexWidth == lastIndexWidth)
        {
            bool val = grid[firstIndexHeight][firstIndexWidth] == 1;
            return new Node(val, true, null, null, null, null);
        }

        var leftTop = Devide(grid, firstIndexWidth, (lastIndexWidth - firstIndexWidth - 1) / 2 + firstIndexWidth, firstIndexHeight, (lastIndexHeight - firstIndexHeight - 1) / 2 + firstIndexHeight);
        var rightTop = Devide(grid, (lastIndexWidth - firstIndexWidth + 1) / 2 + firstIndexWidth, lastIndexWidth, firstIndexHeight, (lastIndexHeight - firstIndexHeight - 1) / 2 + firstIndexHeight);
        var leftBottom = Devide(grid, firstIndexWidth, (lastIndexWidth - firstIndexWidth - 1) / 2 + firstIndexWidth, (lastIndexHeight - firstIndexHeight + 1) / 2 + firstIndexHeight, lastIndexHeight);
        var rightBottom = Devide(grid, (lastIndexWidth - firstIndexWidth + 1) / 2 + firstIndexWidth, lastIndexWidth, (lastIndexHeight - firstIndexHeight + 1) / 2 + firstIndexHeight, lastIndexHeight);

        if (
            leftTop.isLeaf && rightTop.isLeaf && leftBottom.isLeaf && rightBottom.isLeaf
            && leftTop.val == rightTop.val && rightTop.val == leftBottom.val && leftBottom.val == rightBottom.val
        )
        {
            return new Node(leftTop.val, true, null, null, null, null);
        }

        return new Node(true, false, leftTop, rightTop, leftBottom, rightBottom);
    }
}
