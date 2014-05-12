//
// StringGenerator.cs: Generates a random strong string.
//

using System;
using CryptAPI;
using NUnit.Framework;

namespace CryptAPITests
{
	/// <summary>
	/// LM Unit Test
	/// </summary>
	[TestFixture]
	public class LMTest
	{
		LM lm = new LM();
		
		[Test]
		public void EmptySalt() {
			Assert.IsNull(lm.Encrypt("secret",""));
		}
	
		/// <summary>
		/// LM("") = aad3b435b51404eeaad3b435b51404ee
		/// </summary>
		[Test]
		public void Test1() {
			string result = "aad3b435b51404eeaad3b435b51404ee";
			string output = lm.Encrypt("");
			Assert.AreEqual(result,output);
		}
		
		/// <summary>
		/// LM("abc") = 8c6f5d02deb21501aad3b435b51404ee
		/// </summary>
		[Test]
		public void Test2() {
			string result = "8c6f5d02deb21501aad3b435b51404ee";
			string output = lm.Encrypt("abc");
			Assert.AreEqual(result,output);
		}
		
		/// <summary>
		/// LM("The quick brown fox jumps over the lazy dog") = a7b07f9948d8cc7f97c4b0b30cae500f
		/// </summary>
		[Test]
		public void Test3() {
			string result = "a7b07f9948d8cc7f97c4b0b30cae500f";
			string output = lm.Encrypt("The quick brown fox jumps over the lazy dog");
			Assert.AreEqual(result,output);
		}
		
	}
}
