using Geeks.VSIX.TidyCSharp.Cleanup.Infra;
using System;

namespace Geeks.VSIX.TidyCSharp.Cleanup
{
    [Flags]
    public enum CodeCleanerType
    {
        [CleanupItem(Title = "Normalize white spaces", FirstOrder = 1, SubItemType = typeof(NormalizeWhitespace.CleanupTypes))]
        NormalizeWhiteSpaces = 0x01,

        [CleanupItem(Title = "Remove unnecessary \"private\";", SubItemType = typeof(RemovePrivateModifier.CleanupTypes))]
        PrivateAccessModifier = 0x02,

        [CleanupItem(Title = "Remove and Sort Using Directives")]
        OrganizeUsingDirectives = 0x04,

        [CleanupItem(Title = "Small methods properties -> Expression bodied", SubItemType = typeof(SimplifyClassFieldDeclaration.CleanupTypes))]
        ConvertMembersToExpressionBodied = 0x08,

        [CleanupItem(Title = "Use C# alias type names (e.g. \"System.Int32\" -> \"int\")")]
        ConvertFullNameTypesToBuiltInTypes = 0x10,

        [CleanupItem(Title = "Simply async calls")]
        SimplyAsyncCalls = 0x20,

        [CleanupItem(Title = "Move constructors before methods")]
        SortClassMembers = 0x40,

        [CleanupItem(Title = "Compact class field declarations", SubItemType = typeof(SimplifyClassFieldDeclaration.CleanupTypes))]
        SimplifyClassFieldDeclarations = 0x80,

        [CleanupItem(Title = "Remove unnecessary \"Attribute\" (e.g. [SomethingAttribute] -> [Something]")]
        RemoveAttributeKeywork = 0x100,

        [CleanupItem(Title = "Compact small if/else blocks")]
        CompactSmallIfElseStatements = 0x200,

        [CleanupItem(Title = "Remove unnecessary 'this.'", SubItemType = typeof(RemoveExtraThisKeyword.CleanupTypes))]
        RemoveExtraThisQualification = 0x400,

        [CleanupItem(Title = "Local variables -> camelCased")]
        CamelCasedLocalVariable = 0x800,

        [CleanupItem(Title = "\"_something\" -> \"Something\" or \"something\"")]
        CamelCasedFields = 0x1000,

        [CleanupItem(Title = "Const names \"Something\" -> \"SOME_THING\"")]
        CamelCasedConstFields = 0x2000,
    }
}