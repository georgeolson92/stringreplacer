using System.Text.RegularExpressions;

namespace StringReplacer.Objects
{
  public class Replacer
  {
    public string FindAndReplace(string phrase, string search, string replacement)
    {
      search = "(?i)"+search;
      return Regex.Replace(phrase, search, replacement);
    }
  }
}
