using System.Text;

namespace Algorithms.LeetCode;

public class simplify_path
{
    public string SimplifyPath(string path)
    {
        LinkedList<string> canonicalPathStack = new LinkedList<string>();
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
                    canonicalPathStack.RemoveLast();
                }
            }
            else
            {
                canonicalPathStack.AddLast(part);
            }
        }

        if (canonicalPathStack.Count() == 0)
        {
            return "/";
        }

        StringBuilder sb = new StringBuilder("/");
        while (canonicalPathStack.Count() > 0)
        {
            sb.Append(canonicalPathStack.First() + "/");
            canonicalPathStack.RemoveFirst();
        }

        return sb.ToString(0, sb.Length - 1);
    }
}
