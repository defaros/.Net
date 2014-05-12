//
// StringGenerator.cs: Generates a random strong string.
//

using System;
using CryptAPI;
using NUnit.Framework;

namespace CryptAPITests
{
	/// <summary>
	/// DES Unit Test
	/// </summary>
	[TestFixture]
	public class DESTest
	{
		DES des = new DES();
		
		
		/// <summary>
		/// DES("","aa") = aaQSqAReePlq6
		/// </summary>
		[Test]
		public void Test1() {
			string result = "aaQSqAReePlq6";
			string output = des.Encrypt("","aa");
			Assert.AreEqual(result,output);
		}
		
		/// <summary>
		/// DES("abc","zz") = zzsT4g5y.2SNE 
		/// </summary>
		[Test]
		public void Test2() {
			string result = "zzsT4g5y.2SNE";
			string output = des.Encrypt("abc","zz");
			Assert.AreEqual(result,output);
		}
		
		[Test]
		[ExpectedException(typeof(IndexOutOfRangeException))]
		public void EmptySalt() {
			des.Encrypt("abc","");
		}
		
		/// <summary>
		/// Test of DES.Encrypt() with a large salt.
		/// </summary>
		[Test]
		public void LargeSalt() {
			string bigsalt = "";
			for(int i=0;i<1000;i++) {
				bigsalt += "z";
			}
			string result = "zzsT4g5y.2SNE";
			string output = des.Encrypt("abc",bigsalt);
			Assert.AreEqual(result,output);
		}
		
		/// <summary>
		/// Test of DES.Encrypt() sending only the key as argument.
		/// </summary>
		[Test]
		public void OnlyKey() {
			Assert.IsNull(des.Encrypt("abc"));
		}
		
		
	}
}
