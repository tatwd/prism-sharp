# PrismSharp

A porting of [PrismJS](https://github.com/PrismJS/prism) to C# or .NET.

All supported language grammars are [here](https://github.com/tatwd/prism-sharp/tree/main/PrismSharp.Core/Languages).

## Getting Started

Using `PrismSharp.Core` to tokenize a programing language:

```csharp
using PrismSharp.Core;

var text = @"<p>Hello world!</p>"
var grammar = LanguageGrammars.Html;
var tokens = Prism.Tokenize(text, grammar);
```

Using `PrismSharp.Highlighting.HTML` to highlight code via html:

```csharp
using PrismSharp.Core;
using PrismSharp.Highlighting.HTML;

var text = @"<p>Hello world!</p>"
var grammar = LanguageGrammars.Html;
var highlighter = new HtmlHighlighter();
var tokens = highlighter.Highlight(text, grammar, "html");
```