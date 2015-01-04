namespace Goliath.Plugin.Demo
{
	/// <summary>
	/// Plugin de ejemplo de goliath
	/// </summary>
	class Plugin : IPlugin
	{
		/// <summary>
		/// Obtiene una publicacion a partir de una url
		/// base que se utiliza para calcular el resto
		/// de las uri necesarias
		/// </summary>
		/// <returns>La publicacion</returns>
		/// <param name="uri">El identificador base</param>
		public Publication GetPublication(IUri uri)
		{
			var page = new Pages.PublicationPage (uri);
			return new Publication (page.Title);
		}
	}
}