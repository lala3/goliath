namespace Goliath
{
	/// <summary>
	/// Interfaz que representa un recurso obtenible, 
	/// ya sea desde internet o local.
	/// </summary>
	public interface IUri
	{
		/// <summary>
		/// Descarga la uri indicada como un documento html
		/// </summary>
		/// <returns>The document.</returns>
		IDocument DownloadDocument();
	}
}