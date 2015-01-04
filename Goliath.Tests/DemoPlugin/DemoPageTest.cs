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

			var uriMock = CreateMock<IUri> ();
			uriMock.Expects.One.MethodWith (x => x.DownloadDocument (), docMock.MockObject);

			var page = new PublicationPage (uriMock.MockObject);

			Assert.AreEqual ("a", page.Title);
		}

		/// <summary>
		/// Realiza una integracion simple dado que se puede
		/// acceder a recursos sin dependencias externas
		/// </summary>
		[Test]
		public void SimpleIntegrationOverResource()
		{
			var plugin = Load.Plugin ("Demo");
			var uri = Uri.Create ("resource://Goliath.Plugin.Demo/Goliath.Plugin.Demo.Pages.Publication.html");
			var publication = plugin.GetPublication (uri);

			Assert.AreEqual ("title", publication.Title);
		}
	}
}