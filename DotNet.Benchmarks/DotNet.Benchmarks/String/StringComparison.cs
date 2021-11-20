using System.Text;
using BenchmarkDotNet.Attributes;

namespace DotNet.Benchmarks.String
{
    [MemoryDiagnoser, RPlotExporter]
    public class StringComparison
    {

        [Benchmark]
        public string StringConcatWithPlusSymbol()
        {
            return "Lorem" +
                    "Ipsum" +
                    "is" +
                    "simply" +
                    "dummy" +
                    "text" +
                    "of" +
                    "the" +
                    "printing" +
                    "and" +
                    "typesetting" +
                    "industry." +
                    "Lorem" +
                    "Ipsum" +
                    "has" +
                    "been" +
                    "the" +
                    "industry's" +
                    "standard" +
                    "dummy" +
                    "text" +
                    "ever" +
                    "since" +
                    "the" +
                    "1500s," +
                    "when" +
                    "an" +
                    "unknown" +
                    "printer" +
                    "took" +
                    "a" +
                    "galley" +
                    "of" +
                    "type" +
                    "and" +
                    "scrambled" +
                    "it" +
                    "to" +
                    "make" +
                    "a" +
                    "type" +
                    "specimen" +
                    "book." +
                    "It" +
                    "has" +
                    "survived" +
                    "not" +
                    "only" +
                    "five" +
                    "centuries," +
                    "but" +
                    "also" +
                    "the" +
                    "leap" +
                    "into" +
                    "electronic" +
                    "typesetting," +
                    "remaining" +
                    "essentially" +
                    "unchanged." +
                    "It" +
                    "was" +
                    "popularised" +
                    "in" +
                    "the" +
                    "1960s" +
                    "with" +
                    "the" +
                    "release" +
                    "of" +
                    "Letraset" +
                    "sheets" +
                    "containing" +
                    "Lorem" +
                    "Ipsum" +
                    "passages," +
                    "and" +
                    "more" +
                    "recently" +
                    "with" +
                    "desktop" +
                    "publishing" +
                    "software" +
                    "like" +
                    "Aldus" +
                    "PageMaker" +
                    "including" +
                    "versions" +
                    "of" +
                    "Lorem" +
                    "Ipsum";
        }

        [Benchmark]
        public string StringBuilderAppend()
        {
            var sb = new StringBuilder();
            sb.Append("Lorem");
            sb.Append("Ipsum");
            sb.Append("is");
            sb.Append("simply");
            sb.Append("dummy");
            sb.Append("text");
            sb.Append("of");
            sb.Append("the");
            sb.Append("printing");
            sb.Append("and(");
            sb.Append("typesetting");
            sb.Append("industry.");
            sb.Append("Lorem");
            sb.Append("Ipsum");
            sb.Append("has");
            sb.Append("been");
            sb.Append("the");
            sb.Append("industry's");
            sb.Append("standard(");
            sb.Append("dummy");
            sb.Append("text");
            sb.Append("ever");
            sb.Append("since");
            sb.Append("the");
            sb.Append("1500s,");
            sb.Append("when");
            sb.Append("an");
            sb.Append("unknown");
            sb.Append("printer");
            sb.Append("took");
            sb.Append("a");
            sb.Append("galley");
            sb.Append("of");
            sb.Append("type");
            sb.Append("and(");
            sb.Append("scrambled(");
            sb.Append("it");
            sb.Append("to");
            sb.Append("make");
            sb.Append("a");
            sb.Append("type");
            sb.Append("specimen");
            sb.Append("book.");
            sb.Append("It");
            sb.Append("has");
            sb.Append("survived(");
            sb.Append("not");
            sb.Append("only");
            sb.Append("five");
            sb.Append("centuries,");
            sb.Append("but");
            sb.Append("also");
            sb.Append("the");
            sb.Append("leap");
            sb.Append("into");
            sb.Append("electronic");
            sb.Append("typesetting,");
            sb.Append("remaining");
            sb.Append("essentially");
            sb.Append("unchanged.");
            sb.Append("It");
            sb.Append("was");
            sb.Append("popularised(");
            sb.Append("in");
            sb.Append("the");
            sb.Append("1960s");
            sb.Append("with");
            sb.Append("the");
            sb.Append("release");
            sb.Append("of");
            sb.Append("Letraset");
            sb.Append("sheets");
            sb.Append("containing");
            sb.Append("Lorem");
            sb.Append("Ipsum");
            sb.Append("passages,");
            sb.Append("and");
            sb.Append("more");
            sb.Append("recently");
            sb.Append("with");
            sb.Append("desktop");
            sb.Append("publishing");
            sb.Append("software");
            sb.Append("like");
            sb.Append("Aldus");
            sb.Append("PageMaker");
            sb.Append("including");
            sb.Append("versions");
            sb.Append("of");
            sb.Append("Lorem");
            sb.Append("Ipsum");

            return sb.ToString();
        }

        [Benchmark]
        public string StringConcat()
        {            
            return string.Concat("Lorem", "Ipsum", "is", "simply", "dummy", "text", "of", "the", "printing", "and", "typesetting", "industry.", "Lorem", "Ipsum", "has", "been", "the", "industry's", "standard", "dummy", "text", "ever", "since", "the", "1500s,", "when", "an", "unknown", "printer", "took", "a", "galley", "of", "type", "and", "scrambled", "it", "to", "make", "a", "type", "specimen", "book.", "It", "has", "survived", "not", "only", "five", "centuries,", "but", "also", "the", "leap", "into", "electronic", "typesetting", "remaining", "essentially", "unchanged.", "It", "was", "popularised", "in", "the", "1960s", "with", "the", "release", "of", "Letraset", "sheets", "containing", "Lorem", "Ipsum", "passages,", "and", "more", "recently", "with", "desktop", "publishing", "software", "like", "Aldus", "PageMaker", "including", "versions", "of", "Lorem", "Ipsum");
        }
    }
}
