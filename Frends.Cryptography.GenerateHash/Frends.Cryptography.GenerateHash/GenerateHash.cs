using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using Frends.Cryptography.GenerateHash.Definitions;

namespace Frends.Cryptography.GenerateHash;

/// <summary>
/// Cryptography operation task.
/// </summary>
public class Cryptography
{
	/// <summary>
	/// Calculates hash from input using selected algorithm
	/// [Documentation](https://tasks.frends.com/tasks/frends-tasks/Frends.Cryptography.GenerateHash)
	/// </summary>
	/// <param name="input">Input parameters</param>
	/// <returns>Object { string Hash }</returns>
	public static Result GenerateHash(Input input)
	{
        try
        {
			HashAlgorithm hash;
			var result = new Result();
			byte[] bytes;

			if (input.HashFunction == Function.HMACSHA256 || input.HashFunction == Function.HMACSHA512)
			{
				var p = KeyedHashAlgorithm.Create("System.Security.Cryptography." + input.HashFunction);
				p.Key = Encoding.UTF8.GetBytes(input.HashKey);
				hash = p;
			}
			else
				hash = HashAlgorithm.Create("System.Security.Cryptography." + input.HashFunction);

			bytes = hash.ComputeHash(Encoding.UTF8.GetBytes(input.InputString));

			var sBuilder = new StringBuilder();
			bytes.ToList().ForEach(b => sBuilder.Append(b.ToString("x2")));
			result.Hash = sBuilder.ToString();
			return result;
        }
        catch (Exception ex)
        {
            throw new Exception($"GenerateHash failed. {ex}");
        }
	}
}