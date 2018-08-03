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
        bool leaf = true;
        var temp = grid[firstIndexHeight][firstIndexWidth];

        for (var i = firstIndexWidth; i <= lastIndexWidth; i++)
        {
            for (var j = firstIndexHeight; j <= lastIndexHeight; j++)
            {
                if (temp != grid[j][i])
                {
                    leaf = false;
                    break;
                }
            }
        }

        if (leaf) return new Node(temp == 1, true, null, null, null, null);

        int widthMid = (firstIndexWidth + lastIndexWidth) / 2;
        int heightMid = (firstIndexHeight + lastIndexHeight) / 2;

        return new Node(
            true,
            false,
            Devide(grid, firstIndexWidth, widthMid, firstIndexHeight, heightMid),
            Devide(grid, widthMid + 1, lastIndexWidth, firstIndexHeight, heightMid),
            Devide(grid, firstIndexWidth, widthMid, heightMid + 1, lastIndexHeight),
            Devide(grid, widthMid + 1, lastIndexWidth, heightMid + 1, lastIndexHeight)
        );
    }
}
