public class MinStack {

    private readonly Stack<(int,int)> _stack = new Stack<(int, int)>();
    public MinStack() {
        
    }
    
    public void Push(int val) {
        var minValue = int.MaxValue;
        if(_stack.TryPeek(out var value)){
            minValue = value.Item2;
        }
        var min = Math.Min(minValue, val);
        _stack.Push((val, min));
    }
    
    public void Pop() {
        _stack.Pop();
    }
    
    public int Top() {
        if(!_stack.TryPeek(out var value)){
            return 0;
        }
        return value.Item1;
    }
    
    public int GetMin() {
        return _stack.Peek().Item2;
    }
}

/**
 * Your MinStack object will be instantiated and called as such:
 * MinStack obj = new MinStack();
 * obj.Push(val);
 * obj.Pop();
 * int param_3 = obj.Top();
 * int param_4 = obj.GetMin();
 */
