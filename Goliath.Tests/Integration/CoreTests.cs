using NUnit.Framework;
using System.IO;

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

		/// <summary>
		/// Realiza un prueba sobre el constructor de una publicacion
		/// para comprobar que coincidan todas las propiedades
		/// sobre los parametros del constructor
		/// </summary>
		[Test]
		public void TestThePropertiesOfAPublication()
		{
			var p = new Publication ("title");
			Assert.AreEqual ("title", p.Title);

			var s = new StringWriter ();
			p.Save (s);

			Assert.AreEqual ("<publication title=\"title\" />", s.ToString ());
		}
	}
}