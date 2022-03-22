using System.IO;
using System.Linq;
using Xunit;

namespace PrismSharp.Core.Tests;

// TODO: create the class by source-generator
public class LanguageTokenizeTest
{
    [Fact]
    public void test_CLike_features_ok()
    {
        var testFiles = Directory.GetFiles("./testcases/clike/", "*.test")
            .Where(testFile => !testFile.EndsWith(".html.test")).ToArray();
        Assert.NotEmpty(testFiles);
        Assert.All(testFiles, testFile => TestHelper.RunTestCaseFromFile(LanguageGrammars.CLike, testFile));
    }

    [Fact]
    public void test_C_features_ok()
    {
        var testFiles = Directory.GetFiles("./testcases/c/", "*.test")
            .Where(testFile => !testFile.EndsWith(".html.test")).ToArray();
        Assert.NotEmpty(testFiles);
        Assert.All(testFiles, testFile => TestHelper.RunTestCaseFromFile(LanguageGrammars.C, testFile));
    }

    [Fact]
    public void test_CSharp_features_ok()
    {
        var testFiles = Directory.GetFiles("./testcases/csharp/", "*.test")
            .Where(testFile => !testFile.EndsWith(".html.test")).ToArray();
        Assert.NotEmpty(testFiles);
        Assert.All(testFiles, testFile => TestHelper.RunTestCaseFromFile(LanguageGrammars.CSharp, testFile));
    }

    [Theory]
    [InlineData("comment_feature")]
    [InlineData("page-directive_feature")]
    public void test_AspNet_features_ok(string testCase)
    {
        var testFile = $"./testcases/aspnet/{testCase}.test";
        TestHelper.RunTestCaseFromFile(LanguageGrammars.AspNet, testFile);
    }

    [Theory]
    [InlineData("directive_feature")]
    public void test_CSharp_AspNet_features_ok(string testCase)
    {
        var testFile = $"./testcases/csharp+aspnet/{testCase}.test";
        TestHelper.RunTestCaseFromFile(LanguageGrammars.AspNet, testFile);
    }

    [Fact]
    public void test_JavaScript_features_ok()
    {
        var testFiles = Directory.GetFiles("./testcases/javascript/", "*.test")
            .Where(testFile => !testFile.EndsWith(".html.test")).ToArray();
        Assert.NotEmpty(testFiles);
        Assert.All(testFiles, testFile => TestHelper.RunTestCaseFromFile(LanguageGrammars.JavaScript, testFile));
    }

    [Fact]
    public void test_Markup_features_ok()
    {
        var testFiles = Directory.GetFiles("./testcases/markup/", "*.test")
            .Where(testFile => !testFile.EndsWith(".html.test")).ToArray();
        Assert.NotEmpty(testFiles);
        Assert.All(testFiles, testFile => TestHelper.RunTestCaseFromFile(LanguageGrammars.Markup, testFile));
    }

    [Theory]
    [InlineData("javascript_inclusion")]
    public void test_Markup_inline_JavaScript_features_ok(string testCase)
    {
        var testFile = $"./testcases/markup!+javascript/{testCase}.test";
        TestHelper.RunTestCaseFromFile(LanguageGrammars.Markup, testFile);
    }

    [Theory]
    [InlineData("script_feature")]
    public void test_Markup_inline_JavaScript_CSharp_AspNet_features_ok(string testCase)
    {
        var testFile = $"./testcases/markup+javascript+csharp+aspnet/{testCase}.test";
        TestHelper.RunTestCaseFromFile(LanguageGrammars.Markup, testFile);
    }

    [Fact]
    public void test_RegExp_features_ok()
    {
        var testFiles = Directory.GetFiles("./testcases/regex/", "*.test")
            .Where(testFile => !testFile.EndsWith(".html.test")).ToArray();
        Assert.NotEmpty(testFiles);
        Assert.All(testFiles, testFile => TestHelper.RunTestCaseFromFile(LanguageGrammars.RegExp, testFile));
    }

    [Fact]
    public void test_Sql_features_ok()
    {
        var testFiles = Directory.GetFiles("./testcases/sql/", "*.test")
            .Where(testFile => !testFile.EndsWith(".html.test")).ToArray();
        Assert.NotEmpty(testFiles);
        Assert.All(testFiles, testFile => TestHelper.RunTestCaseFromFile(LanguageGrammars.Sql, testFile));
    }

    [Fact]
    public void test_Json_features_ok()
    {
        var testFiles = Directory.GetFiles("./testcases/json/", "*.test")
            .Where(testFile => !testFile.EndsWith(".html.test")).ToArray();
        Assert.NotEmpty(testFiles);
        Assert.All(testFiles, testFile => TestHelper.RunTestCaseFromFile(LanguageGrammars.Json, testFile));
    }

    [Fact]
    public void test_PowerShell_features_ok()
    {
        var testFiles = Directory.GetFiles("./testcases/powershell/", "*.test")
            .Where(testFile => !testFile.EndsWith(".html.test")).ToArray();
        Assert.NotEmpty(testFiles);
        Assert.All(testFiles, testFile => TestHelper.RunTestCaseFromFile(LanguageGrammars.PowerShell, testFile));
    }

    [Fact]
    public void test_Yaml_features_ok()
    {
        var testFiles = Directory.GetFiles("./testcases/yaml/", "*.test")
            .Where(testFile => !testFile.EndsWith(".html.test")).ToArray();
        Assert.NotEmpty(testFiles);
        Assert.All(testFiles, testFile => TestHelper.RunTestCaseFromFile(LanguageGrammars.Yaml, testFile));
    }
}
