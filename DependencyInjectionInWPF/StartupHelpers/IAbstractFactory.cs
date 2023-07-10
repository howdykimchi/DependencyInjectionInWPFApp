namespace DependencyInjectionInWPF.StartupHelpers
{
	public interface IAbstractFactory<T>
	{
		T Create();
	}
}