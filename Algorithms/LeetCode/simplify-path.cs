namespace Algorithms.LeetCode;

public class simplify_path
{
    public string SimplifyPath(string path)
    {
        Stack<string> canonicalPathStack = new Stack<string>();
        string[] pathParts = path.Split('/');
        foreach (string part in pathParts)
        {
            if (part == "." || part == string.Empty)
            {
                // do nothing
            }
            else if (part == "..")
            {
                if (canonicalPathStack.Count() != 0)
                {
                    canonicalPathStack.Pop();
                }
            }
            else
            {
                canonicalPathStack.Push(part);
            }
        }

        return '/' + string.Join('/', canonicalPathStack.Reverse());
    }
}
