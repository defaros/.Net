//
// StringGenerator.cs: Generates a random strong string.
//

using System;
using NUnit.Framework;
using CryptAPI;

namespace CryptAPITests
{
	/// <summary>
	/// MD4 Unit Test
	/// </summary>
	[TestFixture]
	public class MD4Test
	{
		MD4 md4 = new MD4();
		
		/// <summary>
		///  MD4("") = 31d6cfe0d16ae931b73c59d7e0c089c0
		/// </summary>
		[Test]
		public void Test1() {
			string result = "31d6cfe0d16ae931b73c59d7e0c089c0";
			string output = md4.Encrypt("");
			Assert.AreEqual(result,output);
		}
		
		/// <summary>
		/// MD4("abc") = a448017aaf21d8525fc10ae87aa6729d
		/// </summary>
		[Test]
		public void Test2() {
			string result = "a448017aaf21d8525fc10ae87aa6729d";
			string output = md4.Encrypt("abc");
			Assert.AreEqual(result,output);
		}
		
		/// <summary>
		/// MD4("The quick brown fox jumps over the lazy dog") = 1bee69a46ba811185c194762abaeae90
		/// </summary>
		[Test]
		public void Test3() {
			string result = "1bee69a46ba811185c194762abaeae90";
			string output = md4.Encrypt("The quick brown fox jumps over the lazy dog");
			Assert.AreEqual(result,output);
		}
		
		/// <summary>
		/// Using salt with MD4
		/// </summary>
		[Test]
		public void EmptySalt() {
			Assert.IsNull(md4.Encrypt("",""));
		}
	}
}
