namespace Extended_Data_Types
{
    public class LinkedList
    {
        public class Element
        {
            public dynamic Value { get; set; }

            public Element Next { get; set; }

            public Element(dynamic value = null) => Value = value;

            public override string ToString() => $"Element Value: {Value}; Next {(Next == null ? "is null" : "is not null")}!";
        }

        private Element _first = null;
        private Element _last = null;

        public Element First
        {
            get
            {
                return _first;
            }
        }
        public Element Last
        {
            get
            {
                return _last;
            }
        }

        public int Length
        {
            get
            {
                int counter = 0;

                Element element = _first;

                while (element != null)
                {
                    counter++;

                    element = element.Next;
                }

                return counter;
            }
        }

        public LinkedList(params dynamic[] elementsValues)
        {
            foreach (dynamic elementValue in elementsValues)
                Append(elementValue);
        }

        public LinkedList RemoveFirst()
        {
            _first = _first.Next;

            return this;
        }

        public LinkedList InsertAfter(Element element, dynamic value)
        {
            Element next = element.Next;
            element.Next = new Element(value);
            element.Next.Next = next;

            return this;
        }
        public LinkedList Append(dynamic value = null)
        {
            if (_last == null)
                _last = new Element(value);
            else
                _last = _last.Next = new Element(value);

            if (_first == null)
                _first = _last;

            return this;
        }

        public LinkedList Remove(Element element)
        {
            Element result = Find(element);

            if (result == null)
                throw new KeyNotFoundException("Cannot find element!");

            result = null;

            return this;
        }

        public LinkedList RemoveAll()
        {
            _first = null;
            _last = null;

            return this;
        }

        public Element Find(dynamic value) => Find(value, _first);

        public Element Find(dynamic value, Element element)
        {
            if (element.Value == value)
                return element;

            if (element.Next != null)
                return Find(value, element.Next);

            return null;
        }
    }
}
