using System.Collections;

namespace CircleList
{
    public class CircleListNode<T> where T : IComparable
    {
        public CircleListNode(T data)
        {
            Data = data;
        }
        public T Data;
        public CircleListNode<T> Next;
    }
    public class CircleList<T> : IEnumerable<T> where T : IComparable
    {
       // успешно украдено с реализации кольцевого списка на стаковерфлоу
        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable)this).GetEnumerator();
        }
        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            CircleListNode<T>? NodeCurrent = First;
            do
            {
                if (NodeCurrent != null)
                {
                    yield return NodeCurrent.Data;
                    NodeCurrent = NodeCurrent.Next;
                }
            }
            while (NodeCurrent != First);
        }

        // Получает первый узел объекта CircleList<T>
        public CircleListNode<T>? First;
        // Получает последний узел объекта CircleList<T>
        public CircleListNode<T>? Last;
        // Получает число узлов, которое в действительности хранится в CircleList<T>
        public int Count { get => count; }

        private int count;

        // CircleList<T>()
        // Инициализирует новый экземпляр пустого класса 
        public CircleList() { count = 0; }

        // CircleList<T>(IEnumerable<T>)
        // Инициализирует новый экземпляр класса CircleList<T>, содержащий элементы, скопированные из указанного класса IEnumerable,
        // и обладающий емкостью, достаточной для того, чтобы вместить количество скопированных элементов
        public CircleList(IEnumerable<T> list)
        {
            count = 0;
            foreach (var item in list)
                AddLast(item);
        }

        // AddAfter(CircleListNode<T>, CircleListNode<T>)
        // Добавляет заданный новый узел после заданного существующего узла в CircleList<T>
        public bool AddAfter(CircleListNode<T> NodeAfter, CircleListNode<T> NodeNew)
        {
            if (First == null)
                return false;
            CircleListNode<T> NodeCurrent = First;

            do
            {
                if (NodeCurrent.Data.Equals(NodeAfter.Data))
                {
                    if (NodeCurrent != Last)
                    {
                        NodeNew.Next = NodeCurrent.Next;
                        NodeCurrent.Next = NodeNew;
                    }
                    else
                    {
                        NodeNew.Next = First;
                        Last.Next = NodeNew;
                        Last = NodeNew;
                    }
                    count++;
                    return true;
                }
                NodeCurrent = NodeCurrent.Next;
            } while (NodeCurrent != First);
            return false;
        }

        // AddAfter(CircleListNode<T>, T)
        // Добавляет новый узел, содержащий заданное значение, после заданного существующего узла в CircleList<T>
        public bool AddAfter(CircleListNode<T> NodeAfter, T data)
        {
            CircleListNode<T> NodeNew = new(data);
            return AddAfter(NodeAfter, NodeNew);
        }

        // AddBefore(CircleListNode<T>, CircleListNode<T>)
        // Добавляет заданный новый узел перед заданным существующим узлом в CircleList<T>
        public bool AddBefore(CircleListNode<T> NodeBefore, CircleListNode<T> NodeNew)
        {
            if (NodeNew == null)
                return false;
            if (First == null || Last == null)
                return false;
            CircleListNode<T> NodeCurrent = First;
            CircleListNode<T>? NodePrevious = Last;

            do
            {
                if (NodeCurrent.Data.Equals(NodeBefore.Data))
                {
                    if (NodeCurrent == First)
                    {
                        NodeNew.Next = NodeCurrent;
                        First = NodeNew;
                        Last.Next = NodeNew;
                    }
                    else
                    {
                        NodeNew.Next = NodePrevious.Next;
                        NodePrevious.Next = NodeNew;
                    }
                    count++;
                    return true;
                }
                NodePrevious = NodeCurrent;
                NodeCurrent = NodeCurrent.Next;
            } while (NodeCurrent != First);
            return false;
        }

        // AddBefore(CircleListNode<T>, T)
        // Добавляет новый узел, содержащий заданное значение, перед заданным существующим узлом в CircleList<T>
        public bool AddBefore(CircleListNode<T> NodeBefore, T data)
        {
            CircleListNode<T> NodeNew = new(data);
            return AddBefore(NodeBefore, NodeNew);
        }

        // AddFirst(CircleListNode<T>)
        // Добавляет заданный новый узел в начало CircleList<T>
        public bool AddFirst(CircleListNode<T> NodeNew)
        {
            if (NodeNew == null)
                return false;
            if (First == null || Last == null)
            {
                First = NodeNew;
                Last = NodeNew;
                Last.Next = First;
            }
            else
            {
                NodeNew.Next = First;
                First = NodeNew;
                Last.Next = NodeNew;
            }
            count++;
            return true;
        }

        // AddFirst(T)
        // Добавляет новый узел, содержащий заданное значение, в начало CircleList<T>
        public bool AddFirst(T data)
        {
            CircleListNode<T> NodeNew = new(data);
            return AddFirst(NodeNew);
        }

        // AddLast(CircleListNode<T>)
        // Добавляет заданный новый узел в конец CircleList<T>
        public bool AddLast(CircleListNode<T> NodeNew)
        {
            if (NodeNew == null)
                return false;
            if (First == null)
            {
                First = NodeNew;
                Last = NodeNew;
                Last.Next = First;
                First.Next = Last;
            }
            else
            {
                NodeNew.Next = First;
                Last.Next = NodeNew;
                Last = NodeNew;
            }
            count++;
            return true;
        }

        // AddLast(T)
        // Добавляет новый узел, содержащий заданное значение, в конец CircleList<T>
        public bool AddLast(T data)
        {
            CircleListNode<T> NodeNew = new(data);
            return AddLast(NodeNew);
        }

        // Clear()
        // Удаляет все узлы из CircleList<T>
        public bool Clear()
        {
            First = Last = null;
            count = 0;
            return true;
        }

        // Contains(T)
        // Определяет, принадлежит ли значение объекту CircleList<T>
        public bool Contains(T data)
        {
            if (First == null)
                return false;

            CircleListNode<T> NodeCurrent = First;
            do
            {
                if (NodeCurrent.Data.Equals(data))
                    return true;
                NodeCurrent = NodeCurrent.Next;
            } while (NodeCurrent != First);
            return false;
        }

        // Equals(Object)
        // Определяет, равен ли указанный объект текущему объекту
        public new bool Equals(object obj)
        {
            CircleList<T> list = (CircleList<T>)obj;
            if (list.First == null && First == null)
                return true;
            if (list.First == null || First == null)
                return false;

            var NodeCurrent = list.First;
            foreach (var item in this)
            {
                if (NodeCurrent.Data.CompareTo(item) != 0)
                    return false;
            }
            return true;
        }

        // Find(T)
        // Находит первый узел, содержащий указанное значение
        public CircleListNode<T>? Find(T data)
        {
            if (First == null)
                return null;
            CircleListNode<T> NodeCurrent = First;

            do
            {
                if (NodeCurrent.Data.Equals(data))
                    return NodeCurrent;
                NodeCurrent = NodeCurrent.Next;
            } while (NodeCurrent != First);
            return null;
        }

        // FindLast(T)
        // Находит последний узел, содержащий указанное значение
        public CircleListNode<T>? FindLast(T data)
        {
            if (First == null)
                return null;
            CircleListNode<T> NodeCurrent = First;
            CircleListNode<T>? returnNode = null;

            do
            {
                if (NodeCurrent.Data.Equals(data))
                    returnNode = NodeCurrent;
                NodeCurrent = NodeCurrent.Next;
            } while (NodeCurrent != First);
            return returnNode;
        }

        // GetType()
        // Возвращает объект Type для текущего экземпляра
        public new Type GetType()
        {
            return ((object)this).GetType();
        }

        // Remove(CircleListNode<T>)
        // Удаляет заданный узел из объекта CircleList<T>
        public bool Remove(CircleListNode<T> node)
        {
            if (First == null || Last == null)
                return false;
            CircleListNode<T> NodeCurrent = First;
            CircleListNode<T> NodePrevious = Last;

            do
            {
                if (NodeCurrent.Equals(node))
                {
                    if (NodeCurrent == Last)
                    {
                        Last = NodePrevious;
                        Last.Next = First;
                    }
                    else
                    {
                        if (First == Last)
                            First = Last = null;
                        else
                            NodePrevious.Next = NodeCurrent.Next;
                    }
                    count--;
                    return true;
                }
                NodePrevious = NodeCurrent;
                NodeCurrent = NodeCurrent.Next;
            }
            while (NodeCurrent != First);
            return false;
        }

        // Remove(T)
        // Удаляет первое вхождение заданного значения из CircleList<T>
        public bool Remove(T data)
        {
            if (First == null || Last == null)
                return false;
            CircleListNode<T> NodeCurrent = First;
            CircleListNode<T>? NodePrevious = Last;

            do
            {
                if (NodeCurrent.Data.Equals(data))
                {
                    if (NodeCurrent == Last)
                    {
                        Last = NodePrevious;
                        Last.Next = First;
                    }
                    else
                    {
                        if (First == Last)
                            First = Last = null;
                        else
                            NodePrevious.Next = NodeCurrent.Next;
                    }
                    count--;
                    return true;
                }
                NodePrevious = NodeCurrent;
                NodeCurrent = NodeCurrent.Next;
            }
            while (NodeCurrent != First);
            return false;
        }

        // RemoveFirst()
        // Удаляет узел в начале CircleList<T>
        public bool RemoveFirst()
        {
            if (First == null || Last == null)
                return false;
            if (First == Last)
            {
                First = Last = null;
                count--;
                return true;
            }

            Last.Next = First.Next;
            First = First.Next;
            count--;
            return true;
        }

        // RemoveLast()
        // Удаляет узел в конце CircleList<T>
        public bool RemoveLast()
        {
            if (First == null || Last == null)
                return false;
            if (First == Last)
            {
                First = Last = null;
                count--;
                return true;
            }

            CircleListNode<T> NodeCurrent = First;
            CircleListNode<T>? NodePrevious = Last;
            while (NodeCurrent != Last)
            {
                NodePrevious = NodeCurrent;
                NodeCurrent = NodeCurrent.Next;
            }
            NodePrevious.Next = First;
            Last = NodePrevious;
            count--;
            return true;
        }
    }
}