public class LRUCache {

    public class Node
    {
        public int key;
        public int value;
        public Node(int k, int v)
        {
            this.key = k;
            this.value = v;
        }
        public Node next;
        public Node prev;
    }

    public int capacity;
    public Node head;
    public Node tail;
    public Dictionary<int, Node> map;

    public LRUCache(int capacity) 
    {
        this.capacity = capacity;
        this.map = new Dictionary<int, Node>();
        this.head = new Node(-1, -1);
        this.tail = new Node(-1, -1);
        head.next = tail;
        tail.prev = head;
   }
    
    public int Get(int key) 
    {
        if(map.ContainsKey(key))
        {
            RemoveNode(this.head, this.tail, map[key]);
            InsertNodeAtEnd(this.head, this.tail, map[key]);
            return map[key].value;
        }
        else
        {
            return -1;
        }
   }
    
    public void Put(int key, int value) 
    {
        if(map.ContainsKey(key))
        {
            map[key].value = value;
            RemoveNode(this.head, this.tail, map[key]);
            InsertNodeAtEnd(this.head, this.tail, map[key]);
            
        }
        else
        {
            Node newNode = new Node(key, value);
            if(map.Count >= this.capacity)
            {
                Node LRU = this.head.next;
                RemoveNode(this.head, this.tail, LRU);
                map.Remove(LRU.key);
            }
            InsertNodeAtEnd(this.head, this.tail, newNode);
            map.Add(newNode.key, newNode);
        }

    }

    public void InsertNodeAtEnd(Node head, Node tail, Node n)
    {
        Node prevNode = tail.prev;
        prevNode.next = n;
        n.prev = prevNode;
        n.next = tail;
        tail.prev = n;
    }

    public void RemoveNode(Node head, Node tail, Node n)
    {
        Node prevNode = n.prev;
        Node nextNode = n.next;
        prevNode.next = nextNode;
        nextNode.prev =prevNode;
        n.prev = null;
        n.next = null;
    }
}
