using System;
using System.Collections.Generic;

namespace GBFRDataTools.Files.Textures.Atlas;

public class MaxRectsBinPack
{
    /// Instantiates a bin of size (0,0). Call Init to create a new bin.
    public MaxRectsBinPack()
    {
        Init(0, 0);
    }

    /// Instantiates a bin of the given size.
    /// @param allowFlip Specifies whether the packing algorithm is allowed to rotate the input rectangles by 90 degrees to consider a better placement.
    public MaxRectsBinPack(int width, int height)
    {
        Init(width, height);
    }

    public void DoubleSize()
    {
        Init(binWidth * 2, binHeight * 2);
    }

    /// (Re)initializes the packer to an empty bin of width x height units. Call whenever
    /// you need to restart with a new bin.
    public void Init(int width, int height)
    {
        binWidth = width;
        binHeight = height;
        usedRectangles = new List<BinRect>();
        freeRectangles = new List<BinRect>();
        BinRect n = new BinRect();
        n.x = 0;
        n.y = 0;
        n.width = width;
        n.height = height;
        usedRectangles.Clear();
        freeRectangles.Clear();
        freeRectangles.Add(n);
    }

    /// Specifies the different heuristic rules that can be used when deciding where to place a new rectangle.
    public enum FreeRectChoiceHeuristic
    {
        RectBestShortSideFit, /// -BSSF: Positions the rectangle against the short side of a free rectangle into which it fits the best.
        RectBestLongSideFit, /// -BLSF: Positions the rectangle against the long side of a free rectangle into which it fits the best.
        RectBestAreaFit, /// -BAF: Positions the rectangle into the smallest free rect into which it fits.
        RectBottomLeftRule, /// -BL: Does the Tetris placement.
        RectContactPointRule /// -CP: Choosest the placement where the rectangle touches other rects as much as possible.
    };

    /// Inserts the given list of rectangles in an offline/batch mode, possibly rotated.
    /// @param rects The list of rectangles to insert. This vector will be destroyed in the process.
    /// @param dst [out] This list will contain the packed rectangles. The indices will not correspond to that of rects.
    /// @param method The rectangle placement rule to use when packing.
    public void Insert(List<RectSize> rects, List<BinRect> dst,bool rot, FreeRectChoiceHeuristic method)
    {
        dst.Clear();

        while (rects.Count > 0)
        {
            int bestScore1 = int.MaxValue;
            int bestScore2 = int.MaxValue;
            int bestRectIndex = -1;
            BinRect bestNode = new BinRect();

            for (int i = 0; i < rects.Count; ++i)
            {
                int score1 = 0;
                int score2 = 0;
                BinRect newNode = ScoreRect(rects[i].width, rects[i].height,rot, method, ref score1, ref score2);

                if (score1 < bestScore1 || (score1 == bestScore1 && score2 < bestScore2))
                {
                    bestScore1 = score1;
                    bestScore2 = score2;
                    bestNode = newNode;
                    bestRectIndex = i;
                }
            }

            if (bestRectIndex == -1)
                return;

            PlaceRect(ref bestNode);
            dst.Add(bestNode);
            rects.RemoveAt(bestRectIndex);
        }
    }

    /// Inserts a single rectangle into the bin, possibly rotated.
    public BinRect Insert(int width, int height,bool rot, FreeRectChoiceHeuristic method)
    {
        BinRect newNode = new BinRect();
        // Unused in this function. We don't need to know the score after finding the position.
        int score1 = int.MaxValue;
        int score2 = int.MaxValue;
        switch (method)
        {
            case FreeRectChoiceHeuristic.RectBestShortSideFit: newNode = FindPositionForNewNodeBestShortSideFit(rot,width, height, ref score1, ref score2); break;
            case FreeRectChoiceHeuristic.RectBottomLeftRule: newNode = FindPositionForNewNodeBottomLeft(rot,width, height, ref score1, ref score2); break;
            case FreeRectChoiceHeuristic.RectContactPointRule: newNode = FindPositionForNewNodeContactPoint(rot, width, height, ref score1); break;
            case FreeRectChoiceHeuristic.RectBestLongSideFit: newNode = FindPositionForNewNodeBestLongSideFit(rot, width, height, ref score2, ref score1); break;
            case FreeRectChoiceHeuristic.RectBestAreaFit: newNode = FindPositionForNewNodeBestAreaFit(rot, width, height, ref score1, ref score2); break;
        }

        if (newNode.height == 0)
            return newNode;

        int numRectanglesToProcess = freeRectangles.Count;
        for (int i = 0; i < numRectanglesToProcess; ++i)
        {
            if (SplitFreeNode(freeRectangles[i], ref newNode))
            {
                freeRectangles.RemoveAt(i);
                --i;
                --numRectanglesToProcess;
            }
        }

        PruneFreeList();

        usedRectangles.Add(newNode);
        return newNode;
    }

    /// Computes the ratio of used surface area to the total bin area.
    public float Occupancy()
    {
        int usedSurfaceArea = 0;
        for (int i = 0; i < usedRectangles.Count; ++i)
            usedSurfaceArea += usedRectangles[i].width * usedRectangles[i].height;

        return (float)usedSurfaceArea / (binWidth * binHeight);
    }
    public int binWidth;
    public int binHeight;
    public List<BinRect> usedRectangles;

    //private

    List<BinRect> freeRectangles;

    /// Computes the placement score for placing the given rectangle with the given method.
    /// @param score1 [out] The primary placement score will be outputted here.
    /// @param score2 [out] The secondary placement score will be outputted here. This isu sed to break ties.
    /// @return This struct identifies where the rectangle would be placed if it were placed.
    private BinRect ScoreRect(int width, int height,bool rot, FreeRectChoiceHeuristic method, ref int score1, ref int score2)
    {
        BinRect newNode = new BinRect();
        score1 = int.MaxValue;
        score2 = int.MinValue;
        switch (method)
        {
            case FreeRectChoiceHeuristic.RectBestShortSideFit: newNode = FindPositionForNewNodeBestShortSideFit(rot,width, height, ref score1, ref score2); break;
            case FreeRectChoiceHeuristic.RectBottomLeftRule: newNode = FindPositionForNewNodeBottomLeft(rot,width, height, ref score1, ref score2); break;
            case FreeRectChoiceHeuristic.RectContactPointRule:
                newNode = FindPositionForNewNodeContactPoint(rot,width, height, ref score1);
                score1 = -score1; // Reverse since we are minimizing, but for contact point score bigger is better.
                break;
            case FreeRectChoiceHeuristic.RectBestLongSideFit: newNode = FindPositionForNewNodeBestLongSideFit(rot, width, height, ref score2, ref score1); break;
            case FreeRectChoiceHeuristic.RectBestAreaFit: newNode = FindPositionForNewNodeBestAreaFit(rot, width, height, ref score1, ref score2); break;
        }

        // Cannot fit the current rectangle.
        if (newNode.height == 0)
        {
            score1 = int.MaxValue;
            score2 = int.MaxValue;
        }

        return newNode;
    }

    /// Places the given rectangle into the bin.
    private void PlaceRect(ref BinRect node)
    {

        int numRectanglesToProcess = freeRectangles.Count;
        for (int i = 0; i < numRectanglesToProcess; ++i)
        {
            if (SplitFreeNode(freeRectangles[i], ref node))
            {
                freeRectangles.RemoveAt(i);
                --i;
                --numRectanglesToProcess;
            }
        }

        PruneFreeList();

        usedRectangles.Add(node);
    }

    /// Returns 0 if the two intervals i1 and i2 are disjoint, or the length of their overlap otherwise.
    private int CommonIntervalLength(int i1start, int i1end, int i2start, int i2end)
    {
        if (i1end < i2start || i2end < i1start)
            return 0;
        return Math.Min(i1end, i2end) - Math.Max(i1start, i2start);
    }

    /// Computes the placement score for the -CP variant.
    private int ContactPointScoreNode(int x, int y, int width, int height)
    {
        int score = 0;

        if (x == 0 || x + width == binWidth)
            score += height;
        if (y == 0 || y + height == binHeight)
            score += width;

        for (int i = 0; i < usedRectangles.Count; ++i)
        {
            if (usedRectangles[i].x == x + width || usedRectangles[i].x + usedRectangles[i].width == x)
                score += CommonIntervalLength(usedRectangles[i].y, usedRectangles[i].y + usedRectangles[i].height, y, y + height);
            if (usedRectangles[i].y == y + height || usedRectangles[i].y + usedRectangles[i].height == y)
                score += CommonIntervalLength(usedRectangles[i].x, usedRectangles[i].x + usedRectangles[i].width, x, x + width);
        }
        return score;
    }

    private BinRect FindPositionForNewNodeBottomLeft(bool rot, int width, int height, ref int bestY, ref int bestX)
    {
        BinRect bestNode = new BinRect();

        bestY = int.MaxValue;
        bestX = int.MaxValue;

        for (int i = 0; i < freeRectangles.Count; ++i)
        {
            // Try to place the rectangle in upright (non-flipped) orientation.
            if (freeRectangles[i].width >= width && freeRectangles[i].height >= height)
            {
                int topSideY = freeRectangles[i].y + height;
                if (topSideY < bestY || (topSideY == bestY && freeRectangles[i].x < bestX))
                {
                    bestNode.x = freeRectangles[i].x;
                    bestNode.y = freeRectangles[i].y;
                    bestNode.width = width;
                    bestNode.height = height;
                    bestY = topSideY;
                    bestX = freeRectangles[i].x;
                }
            }
            if (rot)
            {
                if (freeRectangles[i].width >= height && freeRectangles[i].height >= width)
                {
                    int topSideY = freeRectangles[i].y + width;
                    if (topSideY < bestY || (topSideY == bestY && freeRectangles[i].x < bestX))
                    {
                        bestNode.x = freeRectangles[i].x;
                        bestNode.y = freeRectangles[i].y;
                        bestNode.width = height;
                        bestNode.height = width;
                        bestY = topSideY;
                        bestX = freeRectangles[i].x;
                    }
                }
            }
        }
        return bestNode;
    }

    private BinRect FindPositionForNewNodeBestShortSideFit(bool rot,int width, int height, ref int bestShortSideFit, ref int bestLongSideFit)
    {
        BinRect bestNode = new BinRect();

        bestShortSideFit = int.MaxValue;
        bestLongSideFit = int.MaxValue;

        for (int i = 0; i < freeRectangles.Count; ++i)
        {
            // Try to place the rectangle in upright (non-flipped) orientation.
            if (freeRectangles[i].width >= width && freeRectangles[i].height >= height)
            {
                int leftoverHoriz = Math.Abs(freeRectangles[i].width - width);
                int leftoverVert = Math.Abs(freeRectangles[i].height - height);
                int shortSideFit = Math.Min(leftoverHoriz, leftoverVert);
                int longSideFit = Math.Max(leftoverHoriz, leftoverVert);

                if (shortSideFit < bestShortSideFit || (shortSideFit == bestShortSideFit && longSideFit < bestLongSideFit))
                {
                    bestNode.x = freeRectangles[i].x;
                    bestNode.y = freeRectangles[i].y;
                    bestNode.width = width;
                    bestNode.height = height;
                    bestShortSideFit = shortSideFit;
                    bestLongSideFit = longSideFit;
                }
            }

            if (rot)
            {
                if (freeRectangles[i].width >= height && freeRectangles[i].height >= width)
                {
                    int flippedLeftoverHoriz = Math.Abs(freeRectangles[i].width - height);
                    int flippedLeftoverVert = Math.Abs(freeRectangles[i].height - width);
                    int flippedShortSideFit = Math.Min(flippedLeftoverHoriz, flippedLeftoverVert);
                    int flippedLongSideFit = Math.Max(flippedLeftoverHoriz, flippedLeftoverVert);

                    if (flippedShortSideFit < bestShortSideFit || (flippedShortSideFit == bestShortSideFit && flippedLongSideFit < bestLongSideFit))
                    {
                        bestNode.x = freeRectangles[i].x;
                        bestNode.y = freeRectangles[i].y;
                        bestNode.width = height;
                        bestNode.height = width;
                        bestShortSideFit = flippedShortSideFit;
                        bestLongSideFit = flippedLongSideFit;
                    }
                }
            }
        }
        return bestNode;
    }

    private BinRect FindPositionForNewNodeBestLongSideFit(bool rot,int width, int height, ref int bestShortSideFit, ref int bestLongSideFit)
    {
        BinRect bestNode = new BinRect();

        bestShortSideFit = int.MaxValue;
        bestLongSideFit = int.MaxValue;

        for (int i = 0; i < freeRectangles.Count; ++i)
        {
            // Try to place the rectangle in upright (non-flipped) orientation.
            if (freeRectangles[i].width >= width && freeRectangles[i].height >= height)
            {
                int leftoverHoriz = Math.Abs(freeRectangles[i].width - width);
                int leftoverVert = Math.Abs(freeRectangles[i].height - height);
                int shortSideFit = Math.Min(leftoverHoriz, leftoverVert);
                int longSideFit = Math.Max(leftoverHoriz, leftoverVert);

                if (longSideFit < bestLongSideFit || (longSideFit == bestLongSideFit && shortSideFit < bestShortSideFit))
                {
                    bestNode.x = freeRectangles[i].x;
                    bestNode.y = freeRectangles[i].y;
                    bestNode.width = width;
                    bestNode.height = height;
                    bestShortSideFit = shortSideFit;
                    bestLongSideFit = longSideFit;
                }
            }

            if (rot)
            {
                if (freeRectangles[i].width >= height && freeRectangles[i].height >= width)
                {
                    int leftoverHoriz = Math.Abs(freeRectangles[i].width - height);
                    int leftoverVert = Math.Abs(freeRectangles[i].height - width);
                    int shortSideFit = Math.Min(leftoverHoriz, leftoverVert);
                    int longSideFit = Math.Max(leftoverHoriz, leftoverVert);

                    if (longSideFit < bestLongSideFit || (longSideFit == bestLongSideFit && shortSideFit < bestShortSideFit))
                    {
                        bestNode.x = freeRectangles[i].x;
                        bestNode.y = freeRectangles[i].y;
                        bestNode.width = height;
                        bestNode.height = width;
                        bestShortSideFit = shortSideFit;
                        bestLongSideFit = longSideFit;
                    }
                }
            }
        }
        return bestNode;
    }
    private BinRect FindPositionForNewNodeBestAreaFit(bool rot,int width, int height, ref int bestAreaFit, ref int bestShortSideFit)
    {
        BinRect bestNode = new BinRect();

        bestAreaFit = int.MaxValue;
        bestShortSideFit = int.MaxValue;

        for (int i = 0; i < freeRectangles.Count; ++i)
        {
            int areaFit = freeRectangles[i].width * freeRectangles[i].height - width * height;

            // Try to place the rectangle in upright (non-flipped) orientation.
            if (freeRectangles[i].width >= width && freeRectangles[i].height >= height)
            {
                int leftoverHoriz = Math.Abs(freeRectangles[i].width - width);
                int leftoverVert = Math.Abs(freeRectangles[i].height - height);
                int shortSideFit = Math.Min(leftoverHoriz, leftoverVert);

                if (areaFit < bestAreaFit || (areaFit == bestAreaFit && shortSideFit < bestShortSideFit))
                {
                    bestNode.x = freeRectangles[i].x;
                    bestNode.y = freeRectangles[i].y;
                    bestNode.width = width;
                    bestNode.height = height;
                    bestShortSideFit = shortSideFit;
                    bestAreaFit = areaFit;
                }
            }

            if (rot)
            {
                if (freeRectangles[i].width >= height && freeRectangles[i].height >= width)
                {
                    int leftoverHoriz = Math.Abs(freeRectangles[i].width - height);
                    int leftoverVert = Math.Abs(freeRectangles[i].height - width);
                    int shortSideFit = Math.Min(leftoverHoriz, leftoverVert);

                    if (areaFit < bestAreaFit || (areaFit == bestAreaFit && shortSideFit < bestShortSideFit))
                    {
                        bestNode.x = freeRectangles[i].x;
                        bestNode.y = freeRectangles[i].y;
                        bestNode.width = height;
                        bestNode.height = width;
                        bestShortSideFit = shortSideFit;
                        bestAreaFit = areaFit;
                    }
                }
            }
        }
        return bestNode;
    }


    private BinRect FindPositionForNewNodeContactPoint(bool rot,int width, int height, ref int bestContactScore)
    {
        BinRect bestNode = new BinRect();

        bestContactScore = -1;

        for (int i = 0; i < freeRectangles.Count; ++i)
        {
            // Try to place the rectangle in upright (non-flipped) orientation.
            if (freeRectangles[i].width >= width && freeRectangles[i].height >= height)
            {
                int score = ContactPointScoreNode(freeRectangles[i].x, freeRectangles[i].y, width, height);
                if (score > bestContactScore)
                {
                    bestNode.x = freeRectangles[i].x;
                    bestNode.y = freeRectangles[i].y;
                    bestNode.width = width;
                    bestNode.height = height;
                    bestContactScore = score;
                }
            }
            if (rot)
            {
                if (freeRectangles[i].width >= height && freeRectangles[i].height >= width)
                {
                    int score = ContactPointScoreNode(freeRectangles[i].x, freeRectangles[i].y, height, width);
                    if (score > bestContactScore)
                    {
                        bestNode.x = freeRectangles[i].x;
                        bestNode.y = freeRectangles[i].y;
                        bestNode.width = height;
                        bestNode.height = width;
                        bestContactScore = score;
                    }
                }
            }
        }
        return bestNode;
    }

    /// @return True if the free node was split.
    private bool SplitFreeNode(BinRect freeNode, ref BinRect usedNode)
    {
        // Test with SAT if the rectangles even intersect.
        if (usedNode.x >= freeNode.x + freeNode.width || usedNode.x + usedNode.width <= freeNode.x ||
            usedNode.y >= freeNode.y + freeNode.height || usedNode.y + usedNode.height <= freeNode.y)
            return false;

        if (usedNode.x < freeNode.x + freeNode.width && usedNode.x + usedNode.width > freeNode.x)
        {
            // New node at the top side of the used node.
            if (usedNode.y > freeNode.y && usedNode.y < freeNode.y + freeNode.height)
            {
                BinRect newNode = freeNode;
                newNode.height = usedNode.y - newNode.y;
                freeRectangles.Add(newNode);
            }

            // New node at the bottom side of the used node.
            if (usedNode.y + usedNode.height < freeNode.y + freeNode.height)
            {
                BinRect newNode = freeNode;
                newNode.y = usedNode.y + usedNode.height;
                newNode.height = freeNode.y + freeNode.height - (usedNode.y + usedNode.height);
                freeRectangles.Add(newNode);
            }
        }

        if (usedNode.y < freeNode.y + freeNode.height && usedNode.y + usedNode.height > freeNode.y)
        {
            // New node at the left side of the used node.
            if (usedNode.x > freeNode.x && usedNode.x < freeNode.x + freeNode.width)
            {
                BinRect newNode = freeNode;
                newNode.width = usedNode.x - newNode.x;
                freeRectangles.Add(newNode);
            }

            // New node at the right side of the used node.
            if (usedNode.x + usedNode.width < freeNode.x + freeNode.width)
            {
                BinRect newNode = freeNode;
                newNode.x = usedNode.x + usedNode.width;
                newNode.width = freeNode.x + freeNode.width - (usedNode.x + usedNode.width);
                freeRectangles.Add(newNode);
            }
        }

        return true;
    }

    /// Goes through the free rectangle list and removes any redundant entries.
    private void PruneFreeList()
    {
        /// Go through each pair and remove any rectangle that is redundant.
        for (int i = 0; i < freeRectangles.Count; ++i)
            for (int j = i + 1; j < freeRectangles.Count; ++j)
            {
                if (IsContainedIn(freeRectangles[i], freeRectangles[j]))
                {
                    freeRectangles.RemoveAt(i);
                    --i;
                    break;
                }
                if (IsContainedIn(freeRectangles[j], freeRectangles[i]))
                {
                    freeRectangles.RemoveAt(j);
                    --j;
                }
            }
    }

    public bool IsContainedIn(BinRect a, BinRect b)
    {
        return a.x >= b.x && a.y >= b.y
        && a.x + a.width <= b.x + b.width
        && a.y + a.height <= b.y + b.height;
    }
};
