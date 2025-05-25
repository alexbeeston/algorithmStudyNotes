using System.Text;

namespace Algorithms.LeetCode;

public class simplify_path
{
    public string SimplifyPath(string path)
    {
        int inputIndex = 0;
        int outputIndex = 0;
        Stack<int> directories = new Stack<int>();
        char[] output = new char[path.Length]; // can't be longer
        while (inputIndex < path.Length)
        {
            if (path[inputIndex] == '/')
            {
                if (outputIndex > 0 && output[outputIndex - 1] == '/')
                {
                    // repeated slashes, do nothing
                    inputIndex++;
                }
                else
                {
                    output[outputIndex] = '/';
                    directories.Push(outputIndex);
                    outputIndex++;
                    inputIndex++;
                }
            }
            else if (path[inputIndex] == '.')
            {
                inputIndex++;
                if (inputIndex == path.Length) // >> /.
                {
                }

                else if (path[inputIndex] != '.' && path[inputIndex] != '/') // >>  /.a
                {
                    output[outputIndex] = path[inputIndex - 1];
                    output[outputIndex + 1] = path[inputIndex];
                    outputIndex += 2;
                    inputIndex++;
                }
                else if (path[inputIndex] == '/') // >> /./
                {
                    inputIndex++;
                }
                else // >> /..
                {
                    inputIndex++;
                    if (inputIndex == path.Length) // >> /..
                    {
                        if (directories.Count() > 0)
                        {
                            directories.Pop();
                            outputIndex = directories.Count() > 0 ? directories.Pop() + 1 : 1;
                        }
                        else
                        {
                            outputIndex = 1;
                        }
                    }
                    else if (path[inputIndex] == '.') // >> /...
                    {
                        output[outputIndex] = '.';
                        output[outputIndex + 1] = '.';
                        output[outputIndex + 2] = '.';
                        outputIndex += 3;
                        inputIndex++;
                    }
                    else if (path[inputIndex] == '/') // >> /../
                    {
                        if (directories.Count() > 0)
                        {
                            directories.Pop();
                            outputIndex = directories.Count() > 0 ? directories.Pop() + 1 : 1;
                        }
                        else
                        {
                            outputIndex = 1;
                        }
                    }
                }
            }
            else
            {
                output[outputIndex] = path[inputIndex];
                outputIndex++;
                inputIndex++;
            }
        }

        if (outputIndex > 1 && output[outputIndex - 1] == '/')
        {
            outputIndex--;
        }

        return new string(output, 0, outputIndex);
    }
}
