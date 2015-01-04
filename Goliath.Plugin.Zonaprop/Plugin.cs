using System;

namespace Goliath.Plugin.Zonaprop
{
	/// <summary>
	/// Plugin para obtener anuncios desde zonaprop
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
			throw new NotImplementedException ();
		}
	}
}