using NUnit.Framework;
using NMock;

namespace Goliath.Tests
{
	/// <summary>
	/// Clase base para realizar pruebas unitarias
	/// usando sustitutos
	/// </summary>
	[TestFixture]
	public abstract class MockTest
	{
		MockFactory factory;

		/// <summary>
		/// Inicializa la fabrica de sustitutos
		/// </summary>
		[SetUp]
		public void Setup()
		{
			factory = new MockFactory ();
		}

		/// <summary>
		/// Comprueba las reglas de los sustitutos
		/// antes de terminar la ejecucion
		/// </summary>
		[TearDown]
		public void TearDown()
		{
			factory.VerifyAllExpectationsHaveBeenMet ();
		}

		/// <summary>
		/// Crea un sustito para la prueba unitaria
		/// </summary>
		/// <returns>El sustituto</returns>
		/// <typeparam name="TMock">El tipo del sustituto</typeparam>
		protected Mock<TMock> CreateMock<TMock>()
			where TMock : class
		{
			return factory.CreateMock<TMock> ();
		}
	}
}