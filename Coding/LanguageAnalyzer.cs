namespace TextBuster.Coding;

public class LanguageAnalyzer:HashSet<string>
{
    public LanguageAnalyzer()
    {
        
    }

    public LanguageAnalyzer(Dictionary<string, string> dictionary)
    {
        foreach (string value in dictionary.Values)
        {
            this.Add(value);
        }
    }
    
    private LanguageAnalyzer GetResidualWith(string wordResidual)
    {
        LanguageAnalyzer result = new LanguageAnalyzer();
        foreach (string word in this)
        {
            if (word.Length < wordResidual.Length)
            {
                continue;
            }

            if (word.Substring(0, wordResidual.Length)==wordResidual)
            {
                result.Add(word.Substring(wordResidual.Length, word.Length - wordResidual.Length));
            }
        }
        return result;
    }

    private LanguageAnalyzer GetResidualIn(LanguageAnalyzer languageAnalyzer)
    {
        LanguageAnalyzer result = new LanguageAnalyzer();
        foreach (string word in this)
        {
            result.UnionWith(languageAnalyzer.GetResidualWith(word));
        }
        return result;
    }

    public bool IsALanguage()
    {
        List<LanguageAnalyzer> languageAnalyzers = new List<LanguageAnalyzer>();
        LanguageAnalyzer languageAnalyzer = this.GetResidualIn(this);
        languageAnalyzer.Remove(String.Empty);
        languageAnalyzers.Add(languageAnalyzer);
        for (int i = 0; i < 200; i++)
        {
            languageAnalyzer = this.GetResidualIn(languageAnalyzers[i]);
            LanguageAnalyzer l1 = languageAnalyzers[i].GetResidualIn(this);
            languageAnalyzer.UnionWith(l1);
            if (languageAnalyzers.Contains(languageAnalyzer))
            {
                return true;
            }
            if (languageAnalyzer.Contains(String.Empty))
            {
                return false;
            }
            languageAnalyzers.Add(languageAnalyzer);
        }
        return true;
    }
}