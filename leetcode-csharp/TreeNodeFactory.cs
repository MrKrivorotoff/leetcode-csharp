namespace leetcode_csharp;

public static class TreeNodeFactory
{
    public static TreeNode? OfValues(params ReadOnlySpan<int?> values)
    {
        var valuesLength = values.Length;
        if (valuesLength == 0)
            return null;
        var steps = new int[GetNumberOfLevels(valuesLength) - 1];
        return CreateNode(steps, -1, -1, values);
    }

    private static int GetNumberOfLevels(int numberOfValues)
    {
        var numberOfLevels = 0;
        for (var decrement = 1; numberOfValues > 0; numberOfLevels++, decrement <<= 1)
            numberOfValues -= decrement;
        return numberOfValues == 0 ? numberOfLevels : throw new ArgumentException(null, nameof(numberOfValues));
    }

    private static TreeNode? CreateNode(int[] steps, int currentStepIndex, int currentStep, ReadOnlySpan<int?> values)
    {
        if (currentStepIndex >= 0)
            steps[currentStepIndex] = currentStep;
        var value = values[GetIndexOfNode(steps, currentStepIndex)];
        if (value == null)
            return null;
        if (currentStepIndex == steps.Length - 1)
            return new TreeNode((int)value);
        var left = CreateNode(steps, currentStepIndex + 1, 0, values);
        var right = CreateNode(steps, currentStepIndex + 1, 1, values);
        return new TreeNode((int)value, left, right);

    }

    private static int GetIndexOfNode(int[] steps, int currentStepIndex)
    {
        var nodesInPrevLevels = 0;
        for (int i = 0, offsetIncrement = 1; i <= currentStepIndex; i++, offsetIncrement <<= 1)
            nodesInPrevLevels += offsetIncrement;
        var currentStepOffset = 0;
        for (int i = currentStepIndex, offsetIncrement = 1; i >= 0; i--, offsetIncrement <<= 1)
            if (steps[i] != 0)
                currentStepOffset += offsetIncrement;
        return nodesInPrevLevels + currentStepOffset;
    }
}