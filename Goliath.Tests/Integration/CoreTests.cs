using NUnit.Framework;

namespace Goliath.Tests.Integration
{
	/// <summary>
	/// Realiza priebas de integracion generales
	/// </summary>
	[TestFixture]
	public class CoreTests
	{
		/// <summary>
		/// Realiza una prueba simple de integracion la cual
		/// obtiene un documento de un recurso embebido
		/// y realiza una consulta xpath sobre el mismo
		/// </summary>
		[Test]
		public void TestASimpleResourceDocumentQuery()
		{
			var uri = Uri.Create ("resource://Goliath.Plugin.Demo/Goliath.Plugin.Demo.Pages.Publication.html");

			var document = uri.DownloadDocument ();

			var result = document.QueryText ("/html/body/h1/text()");

			Assert.AreEqual ("title", result);
		}
	}
}