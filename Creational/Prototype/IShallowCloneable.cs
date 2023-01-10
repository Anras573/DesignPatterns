namespace Creational.Prototype;

public interface IShallowCloneable<out T>
{
    T ShallowClone();
}