public class LRUCache
{
    class Node
    {
        public int key;
        public int val;
        public Node prev;
        public Node next;

        public Node() { }

        public Node(int key, int val)
        {
            this.key = key;
            this.val = val;
        }
    }

    private readonly Dictionary<int, Node> store = new Dictionary<int, Node>();
    private Node head;
    private Node tail;
    private readonly int capacity;

    public LRUCache(int capacity)
    {
        this.capacity = capacity;
    }

    public int Get(int key)
    {
        if (store.ContainsKey(key))
        {
            Node node = store[key];

            MakeRecent(node);

            return node.val;
        }

        return -1;
    }

    public void Put(int key, int value)
    {
        if (store.ContainsKey(key))
        {
            Node node = store[key];

            node.val = value;
            MakeRecent(node);
        }
        else
        {
            Node node = new Node(key, value) { next = head };

            if (head != null)
            {
                head.prev = node;
            }

            head = node;

            if (tail == null)
            {
                tail = head;
            }

            if (store.Count >= capacity)
            {
                store.Remove(tail.key);
                tail = tail.prev;
                tail.next = null;
            }

            store.Add(key, node);
        }
    }

    private void MakeRecent(Node node)
    {
        if (node == head)
        {
            return;
        }

        Node prev = node.prev;

        prev.next = node.next;
        node.next = head;
        head.prev = node;
        head = node;
        head.prev = null;

        if (prev.next == null)
        {
            tail = prev;
        }
        else
        {
            prev.next.prev = prev;
        }
    }
}

/**
 * Your LRUCache object will be instantiated and called as such:
 * LRUCache obj = new LRUCache(capacity);
 * int param_1 = obj.Get(key);
 * obj.Put(key,value);
 */
