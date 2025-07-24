namespace Abstraction.Services
{
    interface IShape
    {
        //best practice for interfaces is to not define method bodies, just the method signatures. putting method bodies in an interface defeats the purpose of abstraction, which is to define a contract that classes must implement without dictating how they should do it.
        void Draw(int numberOfSides);

    }
}
