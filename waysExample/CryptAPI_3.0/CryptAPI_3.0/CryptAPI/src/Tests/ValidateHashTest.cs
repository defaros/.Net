//
// StringGenerator.cs: Generates a random strong string.
//

using System;
using CryptAPI;
using NUnit.Framework;

namespace CryptAPITests
{
	/// <summary>
	/// ValidateHash Unit Test
	/// </summary>
	[TestFixture]
	public class ValidateHashTest
	{
		private string[] keys = {"","abc","testing","this is a large large large key"};
		
		
		/// <summary>
		/// Testing MD4 validation
		/// </summary>
		[Test]
		[Ignore("We need to differentiate MD4 from LM")]
		public void MD4ValidateTest() {
			MD4 md4 = new MD4();
			foreach(string key in keys) {
				HashComponents hash = ValidateHash.HashType(md4.Encrypt(key));
				Assert.AreEqual(Algorithm.MD4,hash.AlgorithmName);
			}
		}
		
		/// <summary>
		/// Testing DES validation
		/// </summary>
		[Test]
		public void DESValidateTest() {
			DES des = new DES();
			foreach(string key in keys) {
				HashComponents hash = ValidateHash.HashType(des.Encrypt(key,"aa"));
				Assert.AreEqual(Algorithm.DES,hash.AlgorithmName);
			}
		}
		
		/// <summary>
		/// Testing NTLM validation
		/// </summary>
		[Test]
		[Ignore("We need to differentiate NTLM from LM")]
		public void NTLMValidateTest() {
			NTLM nt = new NTLM();
			foreach(string key in keys) {
				HashComponents hash = ValidateHash.HashType(nt.Encrypt(key));
				Assert.AreEqual(Algorithm.NTLM,hash.AlgorithmName);
			}
		}
		
		/// <summary>
		/// Testing LM validation
		/// </summary>
		[Test]
		public void LMValidateTest() {
			LM lm = new LM();
			foreach(string key in keys) {
				HashComponents hash = ValidateHash.HashType(lm.Encrypt(key));
				Assert.AreEqual(Algorithm.LM,hash.AlgorithmName);
			}
		}
		
		
		
		/// <summary>
		/// Testing MD5 validation
		/// </summary>
		[Test]
		[Ignore("We need to differentiate MD5 from LM")]
		public void MD5ValidateTest() {
			MD5 md5 = new MD5();
			foreach(string key in keys) {
				HashComponents hash = ValidateHash.HashType(md5.Encrypt(key));
				Assert.AreEqual(Algorithm.MD5,hash.AlgorithmName);
			}
			
		}
		
		/// <summary>
		/// Testing MD5 with Salt validation
		/// </summary>
		[Test]
		public void MD5SaltValidateTest() {
			MD5 md5 = new MD5();
			foreach(string key in keys) {
				HashComponents hash = ValidateHash.HashType(md5.Encrypt(key,"simplesalt"));
				Assert.AreEqual(Algorithm.MD5,hash.AlgorithmName);
			}
		}
		
		/// <summary>
		/// Testing BlowFish validation
		/// </summary>
		[Test]
		public void BlowFishValidateTest() {
			BlowFish bf = new BlowFish();
			string salt = "";
			for(int i=0;i<22;i++) {
				salt += "a";
			}
			foreach(string key in keys) {
				HashComponents hash = ValidateHash.HashType(bf.Encrypt(key,salt));
				Assert.AreEqual(Algorithm.BF,hash.AlgorithmName);
			}
		}
		
		
	

		
		
	}
}
