//
// StringGenerator.cs: Generates a random strong string.
//

using System;
using CryptAPI;
using NUnit.Framework;

namespace CryptAPITests
{
	/// <summary>
	/// BlowFish Unit Test
	/// </summary>
	[TestFixture]
	public class BlowFishTest
	{
		BlowFish bf = new BlowFish();
		
		/// <summary>
		/// Sending a short salt, expecting an ArgumentOutOfRangeException
		/// </summary>
		[Test]
		[ExpectedException(typeof(ArgumentOutOfRangeException))]
		public void EmptySalt() {
			bf.Encrypt("secret","");
		}
		
		/// <summary>
		/// Expected $2a$04$zzzzzzzzzzzzzzzzzzzzzuQLRY6Flr1wbvMquuJ4njQRTlOH18Xsq
		/// </summary>
		[Test]
		public void LargeSalt() {
			string bigsalt = "";
			for(int i=0;i<1000;i++) {
				bigsalt += "z";
			}
			string result = "$2a$04$zzzzzzzzzzzzzzzzzzzzzuQLRY6Flr1wbvMquuJ4njQRTlOH18Xsq";
			string output = bf.Encrypt("secret",bigsalt);
			Assert.AreEqual(result,output);
			
		}
		
		[Test]
		public void OnlyKey() {
			Assert.IsNull(bf.Encrypt("abc"));
		}
		
		
		
	}
}
