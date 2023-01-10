namespace Creational.Prototype;

public interface IDeepClonable<out T>
{
    T DeepClone();
}