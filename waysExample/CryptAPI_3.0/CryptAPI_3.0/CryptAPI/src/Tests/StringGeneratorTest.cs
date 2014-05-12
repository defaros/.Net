//
// StringGenerator.cs: Generates a random strong string.
//

using System;
using CryptAPI;
using NUnit.Framework;

namespace CryptAPITests
{
	/// <summary>
	/// StringGenerator Unit Test
	/// Uses PasswordRandomeGenerator and SaltRandomGenerator
	/// </summary>
	[TestFixture]
	public class StringGeneratorTest
	{
		
		/// <summary>
		/// Test if the generator creates a string with the same length that
		/// the user inputs.
		/// </summary>
		[Test]
		public void PassSameLengthTest() {
			PasswordRandomGenerator pgenerator = new PasswordRandomGenerator();
			for(int i=1;i<512;i++) {
				Assert.AreEqual(i,pgenerator.CreateRandomString(i,i).Length);
			}
		}
		
		/// <summary>
		/// Test if the generator creates a string with the different min and 
		/// max length.
		/// </summary>
		[Test]
		public void PassDifferentLengthTest() {
			PasswordRandomGenerator pgenerator = new PasswordRandomGenerator();
			for(int i=1;i<512;i++) {
				Assert.IsNotEmpty(pgenerator.CreateRandomString(1,i));
			}
			
		}
		
		/// <summary>
		/// Expects null
		/// </summary>
		[Test]
		public void PassZeroLengthTest() {
			PasswordRandomGenerator pgenerator = new PasswordRandomGenerator();
			Assert.IsNull(pgenerator.CreateRandomString(0,0));	
		}
		
		/// <summary>
		/// Tries to broke the CreateRandomString method with an invalid arguments.
		/// </summary>
		[Test]
		public void PassBreaker() {
			PasswordRandomGenerator pgenerator = new PasswordRandomGenerator();
			Assert.IsNull(pgenerator.CreateRandomString(512,1));
		}
		
		/// <summary>
		/// Test the 3 valid salts
		/// </summary>
		[Test]
		public void SaltTest() {
			SaltRandomGenerator sgenerator = new SaltRandomGenerator();
			Assert.IsNotNull(sgenerator.CreateRandomString(8,8));
			Assert.IsNotNull(sgenerator.CreateRandomString(16,16));
			Assert.IsNotNull(sgenerator.CreateRandomString(22,22));
		}
		
		
	}
}
