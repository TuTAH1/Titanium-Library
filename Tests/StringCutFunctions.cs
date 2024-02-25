using Titanium;
using static Titanium.TypesFuncs;

namespace Tests
{
	/// <summary>
	/// Slice, IndexOfT, IndexOf
	/// </summary>
	[TestClass]
	public class StringCutFunctions
	{
		/// <summary>
		/// Slice(+int,+int)
		/// </summary>
		[TestMethod]
		public void Slice_PintPint() 
			=> Assert.AreEqual("Hello", "Hello World!".Slice(0, 5));

		/// <summary>
		/// Slice(+int)
		/// </summary>
		[TestMethod] 
		public void Slice_Nint() 
			=> Assert.AreEqual("World!", "Hello World!".Slice(-6));

		/// <summary>
		/// Slice(+int,-int)
		/// </summary>
		[TestMethod]
		public void Slice_PintNint() 
			=> Assert.AreEqual("World", "Hello World!".Slice(6, -1));

		/// <summary>
		/// Slice(string,string)
		/// </summary>
		[TestMethod]
		public void Slice_StringString() 
			=> Assert.AreEqual("lo World", "Hello World!".Slice("Hel", "!"));


		/// <summary>
		/// Slice(string,string), Include start and end
		/// </summary>
		[TestMethod]
		public void Slice_StringString_IncludeStart_IncludeEnd() 
			=> Assert.AreEqual("llo World", "Hello World!".Slice("ll", "rld", IncludeStart: true, IncludeEnd: true));

		/// <summary>
		/// Slice(string), Include end
		/// </summary>
		[TestMethod]
		public void Slice_String_IncludeEnd() 
			=> Assert.AreEqual("lo World!", "Hello World!".Slice("Hel", IncludeEnd: true));

		/// <summary>
		/// Titanium Index of
		/// </summary>
		[TestMethod]
		public void IndexOfT_Basic() 
			=> Assert.AreEqual("olollolll".Length-1, "olollolll".IndexOfT("olll", IndexOfEnd:true));

		/// <summary>
		/// Default string.IndexOf for time comparison
		/// </summary>
		[TestMethod]
		public void IndexOf_Default() 
		=> Assert.AreEqual("olollolll".Length-1, "olollolll".IndexOf("olll") + "olll".Length-1);
	}
}