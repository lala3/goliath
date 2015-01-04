using System.IO;
using System.Xml;

namespace Goliath
{
	/// <summary>
	/// Estructura de datos que representa una publicacion
	/// </summary>
	public class Publication
	{
		/// <summary>
		/// Obtiene el titulo de la publicacion
		/// </summary>
		/// <value>Título</value>
		public string Title { get; private set; }

		/// <summary>
		/// Inicializa los datos de una nueva publicacion
		/// </summary>
		/// <param name="title">Título</param>
		public Publication (string title)
		{
			Title = title;
		}

		/// <summary>
		/// Guarda la publicacion como un documento xml
		/// </summary>
		/// <param name="output">Flujo de salida</param>
		public void Save (TextWriter output)
		{
			var writer = new XmlTextWriter (output);
			writer.WriteStartElement ("publication");
			writer.WriteAttributeString ("title", Title);
			writer.WriteEndElement ();
			writer.Close ();
		}
	}
}