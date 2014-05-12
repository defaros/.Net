//
// StringGenerator.cs: Generates a random strong string.
//

using System;
using CryptAPI;
using NUnit.Framework;

namespace CryptAPITests
{
	/// <summary>
	/// MD5 Unit Test
	/// </summary>
	[TestFixture]
	public class MD5Test
	{
		MD5 md5 = new MD5();
	
		/// <summary>
		///  MD5("") = d41d8cd98f00b204e9800998ecf8427e
		/// </summary>
		[Test]
		public void Test1() {
			string result = "d41d8cd98f00b204e9800998ecf8427e";
			string output = md5.Encrypt("");
			Assert.AreEqual(result,output);
		}
		
		/// <summary>
		/// MD5("abc") = 900150983cd24fb0d6963f7d28e17f72
		/// </summary>
		[Test]
		public void Test2() {
			string result = "900150983cd24fb0d6963f7d28e17f72";
			string output = md5.Encrypt("abc");
			Assert.AreEqual(result,output);
		}
		
		[Test]
		/// <summary>
		/// Test of MD5.Encrypt() sending only the key as argument.
		/// </summary>
		public void OnlyKey() {
			Assert.IsNotNull(md5.Encrypt("t"));
		}
		
		/// <summary>
		/// Test of MD5.Encrypt() with an empty salt
		/// </summary>
		[Test]
		[ExpectedException(typeof(ArgumentOutOfRangeException))]
		public void EmptySalt() {
			md5.Encrypt("abc","");
		}
		
		/// <summary>
		/// Test of MD5.Encrypt() with a large salt
		/// </summary>
		[Test]
		public void LargeSalt() {
			string salt = "";
			for(int i=0;i<1000;i++)
				salt += "a";
			Assert.IsNotNull(md5.Encrypt("abc",salt));
			
		}
		
	}
}
