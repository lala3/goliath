namespace Goliath
{
	/// <summary>
	/// Interfaz que representa un documento html
	/// listo para poder consultarse
	/// </summary>
	public interface IDocument
	{
		/// <summary>
		/// Realiza una consulta xpath contra el
		/// documento y devuelve el texto que coincida 
		/// con la miama
		/// </summary>
		/// <returns>Resultado de la consulta</returns>
		/// <param name="query">La consulta</param>
		string QueryText(string query);
	}
}