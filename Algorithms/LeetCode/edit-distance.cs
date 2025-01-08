namespace Algorithms.LeetCode;

public class edit_distance
{
	public int MinDistance(string word1, string word2)
	{
		Dictionary<string, int> words = new();
		words.Add(word1, 0);
		int minDistance = int.MaxValue;
		List<string> wordsToExplore = words.Where(x => x.Value + 2 <= minDistance).Select(x => x.Key).ToList();
		while (wordsToExplore.Count > 0)
		{
			foreach (string word in wordsToExplore)
			{
				if (words[word] + 2 <= minDistance)
				{
					ExploreWord(words, word, minDistance);
				}
				else
				{
					words[word].
				}

				words[word].Explored = true;
			}

			wordsToExplore = GetWordsToExplore(words, minDistance);
		}

		return minDistance;
	}

	private int ExploreWord(Dictionary<string, WordCharacteristics> words, string wordToExplore, string target, int minDistance)
	{
		for (int i = 0; i < wordToExplore.Length; i++)
		{
			for (char c = 'a'; c <= 'z'; c++)
			{
				// modify
				if (wordToExplore[i] != c)
				{
					char[] modifyArray = wordToExplore.ToArray();
					modifyArray[i] = c;
					string potentiallyNewWordFromModifying = new string(modifyArray);
					if (potentiallyNewWordFromModifying == target)
					{
						minDistance++;
					}
					else if (!words.ContainsKey(potentiallyNewWordFromModifying))
					{
						words.Add(potentiallyNewWordFromModifying, new WordCharacteristics(words[wordToExplore].Edits + 1));
					}
				}

				// insert
				List<char> insertList = wordToExplore.ToList();
				insertList.Insert(i, c);
				string potentiallyNewWordFromInserting = new string(insertList.ToArray());
				if (potentiallyNewWordFromInserting == target)
				{
					
				}
				if (!words.ContainsKey(potentiallyNewWordFromInserting))
				{
					words.Add(potentiallyNewWordFromInserting, new WordCharacteristics(words[wordToExplore].Edits + 1));
				}
			}

			// delete
			List<char> deleteList = wordToExplore.ToList();
			deleteList.RemoveAt(i);
			string potentiallyNewWordFromDeleting = new string(deleteList.ToArray());
			if (!words.ContainsKey(potentiallyNewWordFromDeleting))
			{
				words.Add(potentiallyNewWordFromDeleting, new WordCharacteristics(words[wordToExplore].Edits + 1));
			}
		}
	}
}
