//
// StringGenerator.cs: Generates a random strong string.
//

using System;
using CryptAPI;
using NUnit.Framework;

namespace CryptAPITests
{
	/// <summary>
	/// NTLM Unit Test
	/// </summary>
	[TestFixture]
	public class NTLMTest
	{
		NTLM nt = new NTLM();
		
		/// <summary>
		/// Expecting null, NTLM does not support salt.
		/// </summary>
		[Test]
		public void EmptySalt() {
			Assert.IsNull(nt.Encrypt("secret",""));
		}
		
		/// <summary>
		/// NTLM("") = 31d6cfe0d16ae931b73c59d7e0c089c0
		/// </summary>
		[Test]
		public void Test1() {
			string result = "31d6cfe0d16ae931b73c59d7e0c089c0";
			string output = nt.Encrypt("");
			Assert.AreEqual(result,output);
		}
		
		
		/// <summary>
		/// NTLM("abc")= e0fba38268d0ec66ef1cb452d5885e53
		/// </summary>
		[Test]
		public void Test2() {
			string result = "e0fba38268d0ec66ef1cb452d5885e53";
			string output = nt.Encrypt("abc");
			Assert.AreEqual(result,output);
		}
		
		/// <summary>
		/// NTLM("The quick brown fox jumps over the lazy dog") = e2ee3d15159661a1ea0d718ac35f73c0
		/// </summary>
		[Test]
		public void Test3() {
			string result = "e2ee3d15159661a1ea0d718ac35f73c0";
			string output = nt.Encrypt("The quick brown fox jumps over the lazy dog");
			Assert.AreEqual(result,output);
		}
		
		
	}
}
