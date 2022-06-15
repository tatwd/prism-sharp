// Auto generated by ./transform.js
using System.Text.RegularExpressions;

namespace PrismSharp.Core.Languages;

// From https://github.com/PrismJS/prism/blob/master/components/prism-batch.js

public class Batch : IGrammarDefinition
{
    public Grammar Define()
    {
        var grammar = new Grammar();

        grammar["comment"] = new GrammarToken[]
        {

        new(new Regex(@"^::.*", RegexOptions.Compiled | RegexOptions.Multiline), lookbehind: false, greedy: false),
        new(new Regex(@"((?:^|[&(])[ \t]*)rem\b(?:[^^&)\r\n]|\^(?:\r\n|[\s\S]))*", RegexOptions.Compiled | RegexOptions.IgnoreCase | RegexOptions.Multiline), lookbehind: true, greedy: false),
        };
        grammar["label"] = new GrammarToken[]
        {

        new(new Regex(@"^:.*", RegexOptions.Compiled | RegexOptions.Multiline), lookbehind: false, greedy: false, alias: new []{"property" }),
        };
        grammar["command"] = new GrammarToken[]
        {

        new(new Regex(@"((?:^|[&(])[ \t]*)for(?: \/[a-z?](?:[ :](?:""[^""]*""|[^\s""/]\S*))?)* \S+ in \([^)]+\) do", RegexOptions.Compiled | RegexOptions.IgnoreCase | RegexOptions.Multiline), lookbehind: true, greedy: false, inside: new Grammar
  {
      ["keyword"] = new GrammarToken[]
      {

        new(new Regex(@"\b(?:do|in)\b|^for\b", RegexOptions.Compiled | RegexOptions.IgnoreCase), lookbehind: false, greedy: false),
      },
      ["string"] = new GrammarToken[]
      {

        new(@"""(?:[\\""]""|[^""])*""(?!"")", lookbehind: false, greedy: false),
      },
      ["parameter"] = new GrammarToken[]
      {

        new(new Regex(@"\/[a-z?]+(?=[ :]|$):?|-[a-z]\b|--[a-z-]+\b", RegexOptions.Compiled | RegexOptions.IgnoreCase | RegexOptions.Multiline), lookbehind: false, greedy: false, alias: new []{"attr-name" }, inside: new Grammar
  {
      ["punctuation"] = new GrammarToken[]
      {

        new(@":", lookbehind: false, greedy: false),
      },
  }),
      },
      ["variable"] = new GrammarToken[]
      {

        new(@"%%?[~:\w]+%?|!\S+!", lookbehind: false, greedy: false),
      },
      ["number"] = new GrammarToken[]
      {

        new(@"(?:\b|-)\d+\b", lookbehind: false, greedy: false),
      },
      ["punctuation"] = new GrammarToken[]
      {

        new(@"[()',]", lookbehind: false, greedy: false),
      },
  }),
        new(new Regex(@"((?:^|[&(])[ \t]*)if(?: \/[a-z?](?:[ :](?:""[^""]*""|[^\s""/]\S*))?)* (?:not )?(?:cmdextversion \d+|defined \w+|errorlevel \d+|exist \S+|(?:""[^""]*""|(?!"")(?:(?!==)\S)+)?(?:==| (?:equ|geq|gtr|leq|lss|neq) )(?:""[^""]*""|[^\s""]\S*))", RegexOptions.Compiled | RegexOptions.IgnoreCase | RegexOptions.Multiline), lookbehind: true, greedy: false, inside: new Grammar
  {
      ["keyword"] = new GrammarToken[]
      {

        new(new Regex(@"\b(?:cmdextversion|defined|errorlevel|exist|not)\b|^if\b", RegexOptions.Compiled | RegexOptions.IgnoreCase), lookbehind: false, greedy: false),
      },
      ["string"] = new GrammarToken[]
      {

        new(@"""(?:[\\""]""|[^""])*""(?!"")", lookbehind: false, greedy: false),
      },
      ["parameter"] = new GrammarToken[]
      {
        null! /* see below */
      },
      ["variable"] = new GrammarToken[]
      {

        new(@"%%?[~:\w]+%?|!\S+!", lookbehind: false, greedy: false),
      },
      ["number"] = new GrammarToken[]
      {

        new(@"(?:\b|-)\d+\b", lookbehind: false, greedy: false),
      },
      ["operator"] = new GrammarToken[]
      {

        new(new Regex(@"\^|==|\b(?:equ|geq|gtr|leq|lss|neq)\b", RegexOptions.Compiled | RegexOptions.IgnoreCase), lookbehind: false, greedy: false),
      },
  }),
        new(new Regex(@"((?:^|[&()])[ \t]*)else\b", RegexOptions.Compiled | RegexOptions.IgnoreCase | RegexOptions.Multiline), lookbehind: true, greedy: false, inside: new Grammar
  {
      ["keyword"] = new GrammarToken[]
      {

        new(new Regex(@"^else\b", RegexOptions.Compiled | RegexOptions.IgnoreCase), lookbehind: false, greedy: false),
      },
  }),
        new(new Regex(@"((?:^|[&(])[ \t]*)set(?: \/[a-z](?:[ :](?:""[^""]*""|[^\s""/]\S*))?)* (?:[^^&)\r\n]|\^(?:\r\n|[\s\S]))*", RegexOptions.Compiled | RegexOptions.IgnoreCase | RegexOptions.Multiline), lookbehind: true, greedy: false, inside: new Grammar
  {
      ["keyword"] = new GrammarToken[]
      {

        new(new Regex(@"^set\b", RegexOptions.Compiled | RegexOptions.IgnoreCase), lookbehind: false, greedy: false),
      },
      ["string"] = new GrammarToken[]
      {

        new(@"""(?:[\\""]""|[^""])*""(?!"")", lookbehind: false, greedy: false),
      },
      ["parameter"] = new GrammarToken[]
      {
        null! /* see below */
      },
      ["variable"] = new GrammarToken[]
      {

        new(@"%%?[~:\w]+%?|!\S+!", lookbehind: false, greedy: false),
        new(@"\w+(?=(?:[*\/%+\-&^|]|<<|>>)?=)", lookbehind: false, greedy: false),
      },
      ["number"] = new GrammarToken[]
      {

        new(@"(?:\b|-)\d+\b", lookbehind: false, greedy: false),
      },
      ["operator"] = new GrammarToken[]
      {

        new(@"[*\/%+\-&^|]=?|<<=?|>>=?|[!~_=]", lookbehind: false, greedy: false),
      },
      ["punctuation"] = new GrammarToken[]
      {

        new(@"[()',]", lookbehind: false, greedy: false),
      },
  }),
        new(new Regex(@"((?:^|[&(])[ \t]*@?)\w+\b(?:""(?:[\\""]""|[^""])*""(?!"")|[^""^&)\r\n]|\^(?:\r\n|[\s\S]))*", RegexOptions.Compiled | RegexOptions.Multiline), lookbehind: true, greedy: false, inside: new Grammar
  {
      ["keyword"] = new GrammarToken[]
      {

        new(@"^\w+\b", lookbehind: false, greedy: false),
      },
      ["string"] = new GrammarToken[]
      {

        new(@"""(?:[\\""]""|[^""])*""(?!"")", lookbehind: false, greedy: false),
      },
      ["parameter"] = new GrammarToken[]
      {
        null! /* see below */
      },
      ["label"] = new GrammarToken[]
      {

        new(new Regex(@"(^\s*):\S+", RegexOptions.Compiled | RegexOptions.Multiline), lookbehind: true, greedy: false, alias: new []{"property" }),
      },
      ["variable"] = new GrammarToken[]
      {

        new(@"%%?[~:\w]+%?|!\S+!", lookbehind: false, greedy: false),
      },
      ["number"] = new GrammarToken[]
      {

        new(@"(?:\b|-)\d+\b", lookbehind: false, greedy: false),
      },
      ["operator"] = new GrammarToken[]
      {

        new(@"\^", lookbehind: false, greedy: false),
      },
  }),
        };
        grammar["operator"] = new GrammarToken[]
        {

        new(@"[&@]", lookbehind: false, greedy: false),
        };
        grammar["punctuation"] = new GrammarToken[]
        {

        new(@"[()']", lookbehind: false, greedy: false),
        };
        grammar["command"][1].Inside!["parameter"][0] = grammar["command"][0].Inside!["parameter"][0];
        grammar["command"][3].Inside!["parameter"][0] = grammar["command"][0].Inside!["parameter"][0];
        grammar["command"][4].Inside!["parameter"][0] = grammar["command"][0].Inside!["parameter"][0];

        return grammar;
    }
}
