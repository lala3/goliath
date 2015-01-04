using HtmlAgilityPack;
using System.IO;

namespace Goliath
{
	/// <summary>
	/// Clase que representa un documento html
	/// utilizando la boblioteca HtmlAgilityPack
	/// </summary>
	public class ApDocument : IDocument
	{
		HtmlDocument document;

		/// <summary>
		/// Inicializa una instancia de documento 
		/// a partir de un stream con su contenido
		/// </summary>
		/// <param name="source">Source.</param>
		public ApDocument(Stream source)
		{
			document = new HtmlDocument ();
			document.Load (source, true);
		}

		/// <summary>
		/// Realiza una consulta xpath contra el
		/// documento y devuelve el texto que coincida 
		/// con la miama
		/// </summary>
		/// <returns>Resultado de la consulta</returns>
		/// <param name="query">La consulta</param>
		public string QueryText(string query)
		{
			return (document.DocumentNode.SelectSingleNode (query) as HtmlTextNode).Text;
		}
	}
}