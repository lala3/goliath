using NUnit.Framework;
using Goliath.Plugin.Demo.Pages;

namespace Goliath.Tests.DemoPlugin
{
	/// <summary>
	/// Pruebas sobre la estructura de datos de la pagina
	/// de pruebas
	/// </summary>
	[TestFixture]
	public class DemoPageTest : MockTest
	{
		/// <summary>
		/// Comprueba que los valores del constructor de la pagina
		/// coincidan con las propiedades indicadas
		/// </summary>
		[Test]
		public void TheTitleMustBeTheIndicated()
		{
			var docMock = CreateMock<IDocument> ();

			docMock.Expects.One.MethodWith (x => x.QueryText ("/html/body/h1/text()"), "a");

			var page = new Publication (docMock.MockObject);

			Assert.AreEqual ("a", page.Title);
		}
	}
}