// Conceptual Questions
//1. Type safety without creating many similar types.
//2. List<string> strings = new List<string>();
//3. Two: the key type and the value type.
//4. False
//5. Add
//6. RemoveAt() and Clear()
//7. In angle brackets by the class name.
//8. False
//9. True
//10. True

//Coding Questions
// Question 1
class MyStack<T>
{
    int capacity;
    T[] stack;
    int top;

    public MyStack(int MaxElements)

    {

        capacity = MaxElements;

        stack = new T[capacity];



        //initialize top with -1

    }

    public int push(T Element)

    {

        //Check Overflow

        if (top == capacity - 1)

        {

            // return -1 if over flow is there

            return -1;

        }

        else

        {

            // insert elementt into stack

            top = top + 1;

            stack[top] = Element;

        }

        return 0;

    }

    public T pop()

    {

        T RemovedElement;

        T temp = default(T);

        //check Underflow

        if (!(top <= 0))

        {

            RemovedElement = stack[top];

            top = top - 1;

            return RemovedElement;

        }

        return temp;
    }

    public T peep(int position)

    {

        T temp = default(T);

        //check if Position is Valid or not

        if (position < capacity && position >= 0)

        {

            return stack[position];

        }

        return temp;

    }
    public T[] GetAllStackElements()

    {

        T[] Elements = new T[top + 1];

        Array.Copy(stack, 0, Elements, 0, top + 1);

        return Elements;

    }

}
// Question 2

namespace Generics
{
    // Type parameter T in angle brackets <>
    public class CustomList<T>
    {
        // Fields
        private Node head;

        // The nested class is also generic on T
        private class Node
        {
            // Fields
            private Node next;

            // T as private member data type
            private T data;

            // T used in non-generic constructor
            public Node(T pData)
            {
                next = null;
                data = pData;
            }

            // Properties
            public Node Next
            {
                get
                {
                    return next;
                }
                set
                {
                    next = value;
                }
            }

            // T as return type of the Property
            public T Data
            {
                get
                {
                    return data;
                }
                set
                {
                    data = value;
                }
            }
        }

        // Constructor
        public CustomList()
        {
            head = null;
        }

        // T as method parameter type:
        public void Add(T pType)
        {
            Node n = new Node(pType);
            n.Next = head;
            head = n;
        }

        // Enables foreach on the List
        public IEnumerator<T> GetEnumerator()
        {
            Node current = head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }

        // Provides indexing on the List
        public T this[int index]
        {
            get
            {
                int ctr = 0;
                Node current = head;
                while (current != null && ctr <= index)
                {
                    if (ctr == index)
                    {
                        return current.Data;
                    }
                    else
                    {
                        current = current.Next;
                    }
                    ++ctr;
                }
                return default(T);
            }
        }

        // Provides ToString() on the List
        public override string ToString()
        {
            if (this.head != null)
            {
                return this.head.ToString();
            }
            else
            {
                return string.Empty;
            }
        }
    }
}

// Question 3

namespace RepositoryUsingEFinMVC.GenericRepository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private EmployeeDBContext _context = null;
        private DbSet<T> table = null;
        public GenericRepository()
        {
            this._context = new EmployeeDBContext();
            table = _context.Set<T>();
        }
        public GenericRepository(EmployeeDBContext _context)
        {
            this._context = _context;
            table = _context.Set<T>();
        }
        public IEnumerable<T> GetAll()
        {
            return table.ToList();
        }
        public T GetById(object id)
        {
            return table.Find(id);
        }
        public void Add(T obj)
        {
            table.Add(obj);
        }
        public void Update(T obj)
        {
            table.Attach(obj);
            _context.Entry(obj).State = EntityState.Modified;
        }
        public void Remove(object id)
        {
            T existing = table.Find(id);
            table.Remove(existing);
        }
        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
