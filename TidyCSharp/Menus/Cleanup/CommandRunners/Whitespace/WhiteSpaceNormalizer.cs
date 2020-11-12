using Geeks.GeeksProductivityTools;
using Geeks.GeeksProductivityTools.Menus.Cleanup;
using Geeks.VSIX.TidyCSharp.Cleanup.NormalizeWhitespace;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Formatting;

namespace Geeks.VSIX.TidyCSharp.Cleanup
{
    public class WhiteSpaceNormalizer : CodeCleanerCommandRunnerBase, ICodeCleaner
    {
        public override SyntaxNode CleanUp(SyntaxNode initialSourceNode)
        {
            return NormalizeWhiteSpaceHelper(initialSourceNode, Options);
        }

        public Options Options { get; set; }

        public static SyntaxNode NormalizeWhiteSpaceHelper(SyntaxNode initialSourceNode, Options options)
        {
            if (TidyCSharpPackage.Instance != null)
            {
                initialSourceNode = Formatter.Format(initialSourceNode, TidyCSharpPackage.Instance.CleanupWorkingSolution.Workspace);
            }

            initialSourceNode = new BlockRewriter(initialSourceNode, options).Visit(initialSourceNode);
            initialSourceNode = new WhitespaceRewriter(initialSourceNode, options).Apply();
            return initialSourceNode;
        }
    }
}