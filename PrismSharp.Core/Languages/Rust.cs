// Auto generated by ./transform.js
using System.Text.RegularExpressions;

namespace PrismSharp.Core.Languages;

// From https://github.com/PrismJS/prism/blob/master/components/prism-rust.js

public class Rust : IGrammarDefinition
{
    public Grammar Define()
    {
        var grammar = new Grammar();

        grammar["comment"] = new GrammarToken[]
        {

        new(@"(^|[^\\])\/\*(?:[^*/]|\*(?!\/)|\/(?!\*)|\/\*(?:[^*/]|\*(?!\/)|\/(?!\*)|\/\*(?:[^*/]|\*(?!\/)|\/(?!\*)|\/\*(?:[^*/]|\*(?!\/)|\/(?!\*)|[^\s\S])*\*\/)*\*\/)*\*\/)*\*\/", lookbehind: true, greedy: true),
        new(@"(^|[^\\:])\/\/.*", lookbehind: true, greedy: true),
        };
        grammar["string"] = new GrammarToken[]
        {

        new(@"b?""(?:\\[\s\S]|[^\\""])*""|b?r(#*)""(?:[^""]|""(?!\1))*""\1", lookbehind: false, greedy: true),
        };
        grammar["char"] = new GrammarToken[]
        {

        new(@"b?'(?:\\(?:x[0-7][\da-fA-F]|u\{(?:[\da-fA-F]_*){1,6}\}|.)|[^\\\r\n\t'])'", lookbehind: false, greedy: true),
        };
        grammar["attribute"] = new GrammarToken[]
        {

        new(@"#!?\[(?:[^\[\]""]|""(?:\\[\s\S]|[^\\""])*"")*\]", lookbehind: false, greedy: true, alias: new []{"attr-name" }, inside: new Grammar
  {
      ["string"] = new GrammarToken[]
      {
        null! /* see below */
      },
  }),
        };
        grammar["closure-params"] = new GrammarToken[]
        {

        new(@"([=(,:]\s*|\bmove\s*)\|[^|]*\||\|[^|]*\|(?=\s*(?:\{|->))", lookbehind: true, greedy: true, inside: new Grammar
  {
      ["closure-punctuation"] = new GrammarToken[]
      {

        new(@"^\||\|$", lookbehind: false, greedy: false, alias: new []{"punctuation" }),
      },
      Reset = null! /* see below */,
  }),
        };
        grammar["lifetime-annotation"] = new GrammarToken[]
        {

        new(@"'\w+", lookbehind: false, greedy: false, alias: new []{"symbol" }),
        };
        grammar["fragment-specifier"] = new GrammarToken[]
        {

        new(@"(\$\w+:)[a-z]+", lookbehind: true, greedy: false, alias: new []{"punctuation" }),
        };
        grammar["variable"] = new GrammarToken[]
        {

        new(@"\$\w+", lookbehind: false, greedy: false),
        };
        grammar["function-definition"] = new GrammarToken[]
        {

        new(@"(\bfn\s+)\w+", lookbehind: true, greedy: false, alias: new []{"function" }),
        };
        grammar["type-definition"] = new GrammarToken[]
        {

        new(@"(\b(?:enum|struct|trait|type|union)\s+)\w+", lookbehind: true, greedy: false, alias: new []{"class-name" }),
        };
        grammar["module-declaration"] = new GrammarToken[]
        {

        new(@"(\b(?:crate|mod)\s+)[a-z][a-z_\d]*", lookbehind: true, greedy: false, alias: new []{"namespace" }),
        new(@"(\b(?:crate|self|super)\s*)::\s*[a-z][a-z_\d]*\b(?:\s*::(?:\s*[a-z][a-z_\d]*\s*::)*)?", lookbehind: true, greedy: false, alias: new []{"namespace" }, inside: new Grammar
  {
      ["punctuation"] = new GrammarToken[]
      {

        new(@"::", lookbehind: false, greedy: false),
      },
  }),
        };
        grammar["keyword"] = new GrammarToken[]
        {

        new(@"\b(?:Self|abstract|as|async|await|become|box|break|const|continue|crate|do|dyn|else|enum|extern|final|fn|for|if|impl|in|let|loop|macro|match|mod|move|mut|override|priv|pub|ref|return|self|static|struct|super|trait|try|type|typeof|union|unsafe|unsized|use|virtual|where|while|yield)\b", lookbehind: false, greedy: false),
        new(@"\b(?:bool|char|f(?:32|64)|[ui](?:8|16|32|64|128|size)|str)\b", lookbehind: false, greedy: false),
        };
        grammar["function"] = new GrammarToken[]
        {

        new(@"\b[a-z_]\w*(?=\s*(?:::\s*<|\())", lookbehind: false, greedy: false),
        };
        grammar["macro"] = new GrammarToken[]
        {

        new(@"\b\w+!", lookbehind: false, greedy: false, alias: new []{"property" }),
        };
        grammar["constant"] = new GrammarToken[]
        {

        new(@"\b[A-Z_][A-Z_\d]+\b", lookbehind: false, greedy: false),
        };
        grammar["class-name"] = new GrammarToken[]
        {

        new(@"\b[A-Z]\w*\b", lookbehind: false, greedy: false),
        };
        grammar["namespace"] = new GrammarToken[]
        {

        new(@"(?:\b[a-z][a-z_\d]*\s*::\s*)*\b[a-z][a-z_\d]*\s*::(?!\s*<)", lookbehind: false, greedy: false, inside: new Grammar
  {
      ["punctuation"] = new GrammarToken[]
      {

        new(@"::", lookbehind: false, greedy: false),
      },
  }),
        };
        grammar["number"] = new GrammarToken[]
        {

        new(@"\b(?:0x[\dA-Fa-f](?:_?[\dA-Fa-f])*|0o[0-7](?:_?[0-7])*|0b[01](?:_?[01])*|(?:(?:\d(?:_?\d)*)?\.)?\d(?:_?\d)*(?:[Ee][+-]?\d+)?)(?:_?(?:f32|f64|[iu](?:8|16|32|64|size)?))?\b", lookbehind: false, greedy: false),
        };
        grammar["boolean"] = new GrammarToken[]
        {

        new(@"\b(?:false|true)\b", lookbehind: false, greedy: false),
        };
        grammar["punctuation"] = new GrammarToken[]
        {

        new(@"->|\.\.=|\.{1,3}|::|[{}[\];(),:]", lookbehind: false, greedy: false),
        };
        grammar["operator"] = new GrammarToken[]
        {

        new(@"[-+*\/%!^]=?|=[=>]?|&[&=]?|\|[|=]?|<<?=?|>>?=?|[@?]", lookbehind: false, greedy: false),
        };
        grammar["attribute"][0].Inside!["string"][0] = grammar["string"][0];
        grammar["closure-params"][0].Inside!.Reset = grammar;

        return grammar;
    }
}
