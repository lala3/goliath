namespace Goliath.Plugin.Demo.Pages
{
	/// <summary>
	/// Estructura de datos de una pagina html
	/// parseada de ejemplo
	/// </summary>
	public class Publication : IPage
	{
		/// <summary>
		/// Inicializa la estructura con sus
		/// correspondientes valoes a base de un documento
		/// </summary>
		/// <param name="title">Titulo</param>
		public Publication(IDocument document)
		{
			Title = document.QueryText ("/html/body/h1/text()");
		}
		/// <summary>
		/// Propiedad que contiene el titulo de la pagina
		/// </summary>
		/// <value>Titulo</value>
		public string Title { get; private set; }
	}
}