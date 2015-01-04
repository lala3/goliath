using System;
using System.Reflection;

namespace Goliath
{
	/// <summary>
	/// Clase para cargar complementos dinamicamente
	/// </summary>
	public static class Load
	{
		/// <summary>
		/// Carga el complemento especificado por nombre
		/// </summary>
		/// <param name="name">Nombre del complemente</param>
		public static IPlugin Plugin(string name)
		{
			var assemblyName = string.Format("Goliath.Plugin.{0}", name);
			var typeName = string.Format ("{0}.Plugin", assemblyName);

			return (IPlugin)Activator.CreateInstance(Assembly.Load (assemblyName).GetType (typeName));
		}
	}
}