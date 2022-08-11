using Microsoft.VisualStudio.TestTools.UnitTesting;
using Frends.Cryptography.GenerateHash.Definitions;

namespace Frends.Cryptography.GenerateHash.Tests;

[TestClass]
public class UnitTests
{
    Input? input;

    [TestMethod]
    public void Hashes_SHA1()
    {
        input = new Input { InputString = "foobar", HashFunction = Function.SHA1, HashKey = null };
        var result = Cryptography.GenerateHash(input);
        Assert.AreEqual("8843d7f92416211de9ebb963ff4ce28125932878", result.Hash);
    }

    [TestMethod]
    public void Hashes_SHA256()
    {
        input = new Input { InputString = "foobar", HashFunction = Function.SHA256, HashKey = null };
        var result = Cryptography.GenerateHash(input);
        Assert.AreEqual("c3ab8ff13720e8ad9047dd39466b3c8974e592c2fa383d4a3960714caef0c4f2", result.Hash);

    }
    [TestMethod]
    public void Hashes_SHA384()
    {
        input = new Input { InputString = "foobar", HashFunction = Function.SHA384, HashKey = null };
        var result = Cryptography.GenerateHash(input);
        Assert.AreEqual("3c9c30d9f665e74d515c842960d4a451c83a0125fd3de7392d7b37231af10c72ea58aedfcdf89a5765bf902af93ecf06", result.Hash);
    }

    [TestMethod]
    public void Hashes_SHA512()
    {
        input = new Input { InputString = "foobar", HashFunction = Function.SHA512, HashKey = null };
        var result = Cryptography.GenerateHash(input);
        Assert.AreEqual("0a50261ebd1a390fed2bf326f2673c145582a6342d523204973d0219337f81616a8069b012587cf5635f6925f1b56c360230c19b273500ee013e030601bf2425", result.Hash);
    }

    [TestMethod]
    public void Hashes_MD5()
    {
        input = new Input { InputString = "foobar", HashFunction = Function.MD5, HashKey = null };
        var result = Cryptography.GenerateHash(input);
        Assert.AreEqual("3858f62230ac3c915f300c664312c63f", result.Hash);
    }

    [TestMethod]
    public void Hashes_HMACSHA256()
    {
        input = new Input { InputString = "foobar", HashFunction = Function.HMACSHA256, HashKey = "kekkeroos" };
        var result = Cryptography.GenerateHash(input);
        Assert.AreEqual("a769ca28fa0c7242bcc9aa536f3b1fd7874c765b7b4789eaff65e474f4ce6e56", result.Hash);
    }
 
    [TestMethod]
    public void Hashes_HMACSHA512()
    {
        input = new Input { InputString = "foobar", HashFunction = Function.HMACSHA512, HashKey = "kekkeroos" };
        var result = Cryptography.GenerateHash(input);
        Assert.AreEqual("20eabf2a44044559fd0299ed5967392f394be2609926d1c36a53823681f4a280a8f5f65e855c2d4655d3cba1c720c3a85ed9a77009b013eed85db710cdf0920b", result.Hash);
    }
}