using System;
using System.IO;

namespace Goliath
{
	/// <summary>
	/// Implementacion basica para descargas archivos
	/// </summary>
	public abstract class Uri : IUri
	{
		/// <summary>
		/// Descarga la uri indicada como un documento html
		/// </summary>
		/// <returns>The document.</returns>
		public IDocument DownloadDocument()
		{
			return new ApDocument (Resolve ());
		}

		/// <summary>
		/// Obtiene un flujo de datos correspondiente al
		/// identificador del recurso
		/// </summary>
		protected abstract Stream Resolve();

		/// <summary>
		/// Crea un identificador de recurso a base de 
		/// un texto descriptivo
		/// </summary>
		/// <param name="uri">Uri en formato de texto</param>
		public static IUri Create(string uri)
		{
			var parts = uri.Split (new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);
			return new ResourceUri (parts [1], parts [2]);
		}
	}
}