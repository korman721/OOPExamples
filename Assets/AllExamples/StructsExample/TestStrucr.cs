using UnityEngine;

public class TestStrucr : MonoBehaviour
{
    private void Awake()
    {
        //ExampleStruct exampleStruct = new ExampleStruct();

        //AddTo(exampleStruct, 5);

        //Debug.Log(exampleStruct.Value);

        Vector3 position = new Vector3(1, 1, 1);
        position.x += 1;

        Debug.Log(position.x);

        TestObject testObject = new TestObject();
        //testObject.Position.x += 1;

        testObject.Position = new Vector3(testObject.Position.x + 1, testObject.Position.y, testObject.Position.z);

        PointStuct point1 = new PointStuct() { X = 1, Y = 1 };
        PointStuct point2 = new PointStuct() { X = 1, Y = 1 };

        Debug.Log(point1.Equals(point2));

        PointClass point3 = new PointClass() { X = 1, Y= 1};
        PointClass point4 = new PointClass() { X = 1, Y= 1};

        Debug.Log(point3.Equals(point4));
    }

    public void AddTo(ExampleStruct exampleStruct, int value)
    {
        exampleStruct.Add(value);
    }
}

public class PointClass
{
    public int X;
    public int Y;
}

public struct PointStuct
{
    public int X;
    public int Y;
}

public class TestObject
{
    private Vector3 _position;

    public Vector3 Position
    {
        get => _position; 
        set => _position = value;
    }
}
