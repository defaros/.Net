//
// StringGenerator.cs: Generates a random strong string.
//

using System;
using System.Collections.Generic;
using NUnit.Framework;
using CryptAPI;

namespace CryptAPITests
{
	/// <summary>
	/// CryptServiceProvider Unit Test
	/// </summary>
	[TestFixture]
	public class CryptServiceProviderTest
	{
		private static string[] hashTypes;
		private static CryptServiceProvider[] provider = new CryptServiceProvider[6];
		private static CryptServiceProvider[] providerTest = new CryptServiceProvider[6];
		private static HashAlgorithm[] algorithm = new HashAlgorithm[6];
		private static HashAlgorithm[] algorithmTest = new HashAlgorithm[6];
	
		///  <summary>Test case for the 2 constructors: CryptoServiceProvider() & CryptoServiceProvider(Algorithm)
		///  and the 2 methods GetCryptServiceProvider() & GetCryptServiceProdiver(Algorithm)</summary>
		[Test]
		public void methodsTest() {
			hashTypes = Algorithm.GetNames(typeof(Algorithm));
			
			for(int i=0;i<hashTypes.Length;i++) {
				
				providerTest[i] = new CryptServiceProvider();
				
				if (hashTypes[i].Equals("LM")) {
					provider[i] = new CryptServiceProvider(Algorithm.LM | Algorithm.NTLM);
					algorithmTest[i] = providerTest[i].GetCryptServiceProvider( Algorithm.LM | Algorithm.NTLM);
				}
				else {
				   provider[i] = new CryptServiceProvider( (Algorithm)Algorithm.Parse(typeof(Algorithm), hashTypes[i]));
				   algorithmTest[i] = providerTest[i].GetCryptServiceProvider( (Algorithm)Algorithm.Parse(typeof(Algorithm), hashTypes[i]));
				}
				algorithm[i] = provider[i].GetCryptServiceProvider();
				
				Assert.IsInstanceOfType(algorithmTest[i].GetType(),algorithm[i]);
												
			}	
		}
		
		/// <summary>Test case which represents a user that forgot to specify an algorithm in the constructor
		/// and in the GetCryptServiceProvider() method, its expected to get a null value</summary>
		///
		[Test]
		public void stupidUser() {
			CryptServiceProvider crypt = new CryptServiceProvider();
			HashAlgorithm hcrypt = crypt.GetCryptServiceProvider();
			Assert.IsNull(hcrypt,"null");
		}	
		
		
	}
}
