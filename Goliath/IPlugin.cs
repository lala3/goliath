namespace Goliath
{
	/// <summary>
	/// Interfaz que representa un complemento de goliath
	/// </summary>
	public interface IPlugin
	{
		/// <summary>
		/// Obtiene una publicacion a partir de una url
		/// base que se utiliza para calcular el resto
		/// de las uri necesarias
		/// </summary>
		/// <returns>La publicacion</returns>
		/// <param name="uri">El identificador base</param>
		Publication GetPublication (IUri uri);
	}
}