public class Solution
{
    public int ComputeArea(int A, int B, int C, int D, int E, int F, int G, int H)
    {
        int leftX = Math.Max(A, E);
        int bottomY = Math.Max(B, F);
        int rightX = Math.Min(C, G);
        int topY = Math.Min(D, H);
        int area = GetArea(A, B, C, D) + GetArea(E, F, G, H);

        if (leftX >= rightX || bottomY >= topY)
        {
            return area;
        }

        return area - GetArea(leftX, bottomY, rightX, topY);
    }

    private int GetArea(int leftX, int bottomY, int rightX, int topY)
    {
        return (rightX - leftX) * (topY - bottomY);
    }
}
