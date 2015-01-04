namespace Goliath
{
	/// <summary>
	/// Interfaz que representa un recurso obtenible, 
	/// ya sea desde internet o local.
	/// </summary>
	public interface IUri
	{
		IDocument DownloadDocument();
	}
}