ClassA myObject = new ClassA();
Console.WriteLine($"myObject.State = {myObject.State}");
ClassA.ClassB myOtherObject = new ClassA.ClassB();
myOtherObject.SetPrivateState(myObject, 999);
Console.WriteLine($"myObject.State = {myObject.State}");
ClassA.ClassC myAnotherObject = new ClassA.ClassC(1, 2);
Console.WriteLine($"{myAnotherObject}");
Console.ReadKey();

public class ClassA
{
    private int state = -1;
    public int State => state;
    public class ClassB
    {
        public void SetPrivateState(ClassA target, int newState)
        {
            target.state = newState;
        }
    }
    public class ClassC
    {
        public ClassC(int param1,int param2)
        {
            //return param1 + param2;
        }
    }
}