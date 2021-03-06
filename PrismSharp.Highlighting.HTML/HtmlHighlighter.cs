using System.Text;
using PrismSharp.Core;

namespace PrismSharp.Highlighting.HTML;

public class HtmlHighlighter : IHighlighter
{
    public string Highlight(string text, Grammar grammar, string language)
    {
        var tokens = Prism.Tokenize(text, grammar);
        return Stringify(tokens);
    }

    private static string Stringify(Token[] tokens)
    {
        if (!tokens.Any()) return string.Empty;

        var htmlSb = new StringBuilder();

        foreach (var token in tokens)
        {
            if (token is StringToken stringToken)
            {
                var content = Encode(stringToken.Content);

                if (!stringToken.IsMatchedToken())
                {
                    htmlSb.Append(content);
                    continue;
                }

                const string tag = "span";
                var type = token.Type;
                // TODO: maybe need check `token.Alias` null or not
                var classes = new[] { "token", type }.Concat(token.Alias);
                // TODO: support attributes
                var html = $"<{tag} class=\"{string.Join(" ", classes)}\">{content}</{tag}>";
                htmlSb.Append(html);
                continue;
            }

            if (token is not StreamToken streamToken) continue;

            htmlSb.Append(Stringify(streamToken.Content));
        }

        return htmlSb.ToString();
    }

    private static string Encode(string content)
    {
        return content.Replace("&", "&amp;")
            .Replace("<", "&lt;")
            .Replace("\u00a0", " ");
    }
}
