using System.IO;
using System.Reflection;

namespace Goliath
{
	/// <summary>
	/// Clase que realiza descargas sobre
	/// recursos incrustados de .NET
	/// Util para pruebas
	/// </summary>
	class ResourceUri : Uri
	{
		readonly string assembly;
		readonly string name;

		/// <summary>
		/// Inicializa una instancia de una uri de recurso
		/// </summary>
		/// <param name="assembly">Nombre del ensamblado</param>
		/// <param name="name">Nombre del recurso incrustado</param>
		public ResourceUri(string assembly, string name)
		{
			this.assembly = assembly;
			this.name = name;
		}

		/// <summary>
		/// Obtiene un flujo de datos correspondiente al
		/// identificador del recurso
		/// </summary>
		protected override Stream Resolve ()
		{
			return Assembly.Load (assembly).GetManifestResourceStream (name);
		}
	}
}