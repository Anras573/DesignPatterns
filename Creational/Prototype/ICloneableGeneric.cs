namespace Creational.Prototype;

public interface ICloneableGeneric<out T>
{
    T ShallowClone();
}