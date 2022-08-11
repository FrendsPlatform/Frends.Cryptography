namespace Frends.Cryptography.GenerateHash.Definitions;

/// <summary>
/// Enum for choosing HashAlgorithm type.
/// </summary>
public enum Function
{
#pragma warning disable CS1591 // self explanatory
    MD5,
    SHA1,
    SHA256,
    SHA384,
    SHA512,
    HMACSHA256,
    HMACSHA512
#pragma warning restore CS1591 // self explanatory
}