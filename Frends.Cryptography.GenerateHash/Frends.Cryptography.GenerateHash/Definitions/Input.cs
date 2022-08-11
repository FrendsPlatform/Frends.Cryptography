using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Frends.Cryptography.GenerateHash.Definitions;

/// <summary>
/// Input parameters.
/// </summary>
public class Input
{
    /// <summary>
    /// Generates input string to chosen HashAlgorithm type.
    /// </summary>
    /// <example>MD5</example>
    [DefaultValue(Function.MD5)]
    public Function HashFunction { get; set; }

    /// <summary>
    /// Input string to be hashed.
    /// </summary>
    /// <example>foo</example>
    [DisplayFormat(DataFormatString = "Text")]
    public string InputString { get; set; }

    /// <summary>
    /// HashKey when using HMACSHA256 or HMACSHA512 HashAlgorithm type.
    /// </summary>
    /// <example>foobar</example>
    [DefaultValue("")]
    [UIHint(nameof(Function), "", Function.HMACSHA256)]
    [PasswordPropertyText]
    public string HashKey { get; set; }
}