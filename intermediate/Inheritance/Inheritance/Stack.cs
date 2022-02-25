using System.Collections;

public class Stack
{
    private List<object> _obj;
    public Stack()
    {
        _obj = new List<object>();
    }
    public void Push(object obj)
    {
        if (obj == null)
            throw new InvalidOperationException("Null argument passed to method");
        _obj.Add(obj);
    }
    public object Pop()
    {
        if (_obj.Count == 0)
            throw new InvalidOperationException("No elements to pop in the array");
        object returnAble = _obj[0];
        _obj.RemoveAt(0);
        return returnAble;
    }
    public void Clear()
    {
        if (_obj.Count == 0)
            throw new InvalidOperationException("No elements in the array");
        int count = _obj.Count();
        for (int i = 0; i < count; i++)
        {
            _obj.RemoveAt(0);
        }
    }
}