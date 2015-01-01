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
		/// Comprueba la consultas xpath correctas para completar
		/// las propiedades de datos de la pagina.
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