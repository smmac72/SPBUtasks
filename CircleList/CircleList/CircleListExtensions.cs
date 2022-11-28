namespace CircleList
{
    public static class CircleListExtensions
    {
        // Any<TSource>(IEnumerable<TSource>)
        // Проверяет, содержит ли последовательность какие-либо элементы
        public static bool Any<TSource>(this IEnumerable<TSource> source)
        {
            foreach (var item in source)
                if (item != null)
                    return true;
            return false;
        }

        // Append<TSource>(IEnumerable<TSource>, TSource)
        // Добавляет значение в конец последовательности
        public static IEnumerable<TSource> Append<TSource>(this IEnumerable<TSource> list, TSource data) where TSource : IComparable
        {
            var RetList = (CircleList<TSource>)list;
            RetList.AddLast(data);
            return RetList;
        }

        // Concat<TSource>(IEnumerable<TSource>, IEnumerable<TSource>)
        // Объединяет две последовательности
        public static IEnumerable<TSource> Concat<TSource>(this IEnumerable<TSource> first, IEnumerable<TSource> second)
        {
            if (first == null || second == null)
                throw new ArgumentNullException();

            IEnumerable<TSource> RetList = first;
            foreach (var item in second)
                RetList.Append(item);
            return RetList;
        }

        // Contains<TSource>(IEnumerable<TSource>, TSource)
        // Определяет, содержится ли указанный элемент в последовательности, используя компаратор проверки на равенство по умолчанию
        public static bool Contains<TSource>(this IEnumerable<TSource> list, TSource data) where TSource : IComparable
        {
            foreach (var item in list)
                if (item.CompareTo(data) == 0)
                    return true;
            return false;
        }

        // Count<TSource>(IEnumerable<TSource>)
        // Возвращает количество элементов в последовательности
        public static int Count<TSource>(this IEnumerable<TSource> list)
        {
            int count = 0;
            foreach (var item in list)
                if (item != null)
                    count++;
            return count;
        }

        // ElementAt<TSource>(IEnumerable<TSource>, Index)
        // Возвращает элемент по указанному индексу в последовательности
        public static TSource ElementAt<TSource>(this IEnumerable<TSource> list, Index index)
        {
            TSource RetItem;
            if (index.IsFromEnd == true)
                RetItem = list.ElementAt(index.Value);
            else
            {
                var newList = list.Reverse();
                RetItem = newList.ElementAt(index.Value);
            }
            return RetItem;
        }

        // ElementAt<TSource>(IEnumerable<TSource>, Int32)
        // Возвращает элемент по указанному индексу в последовательности
        public static TSource ElementAt<TSource>(this IEnumerable<TSource> list, int index)
        {
            int counter = 0;
            foreach (var item in list)
            {
                if (counter == index)
                    return item;
                counter++;
            }
            throw new ArgumentOutOfRangeException();
        }

        // ElementAtOrDefault<TSource>(IEnumerable<TSource>, Index)
        // Возвращает элемент последовательности по указанному индексу или значение по умолчанию, если индекс вне допустимого диапазона
        public static TSource? ElementAtOrDefault<TSource>(this IEnumerable<TSource> list, Index index)
        {
            if (list.Count() >= index.Value)
                return default;
            return list.ElementAt(index);
        }

        // ElementAtOrDefault<TSource>(IEnumerable<TSource>, Int32)
        // Возвращает элемент последовательности по указанному индексу или значение по умолчанию, если индекс вне допустимого диапазона
        public static TSource? ElementAtOrDefault<TSource>(this IEnumerable<TSource> list, int index)
        {
            if (list.Count() >= index)
                return default;
            return list.ElementAt(index);
        }

        // First<TSource>(IEnumerable<TSource>)
        // Возвращает первый элемент последовательности
        public static TSource First<TSource>(this IEnumerable<TSource> list)
        {
            foreach (var item in list)
                return item;
            throw new ArgumentNullException();
        }

        // FirstOrDefault<TSource>(IEnumerable<TSource>)
        // Возвращает первый элемент последовательности или значение по умолчанию, если последовательность не содержит элементов
        public static TSource? FirstOrDefault<TSource>(this IEnumerable<TSource> list)
        {
            foreach (var item in list)
                return item;
            return default;
        }

        // Last<TSource>(IEnumerable<TSource>)
        // Возвращает последний элемент последовательности
        public static TSource Last<TSource>(this IEnumerable<TSource> list)
        {
            TSource? RetItem = default;

            foreach (var item in list)
                RetItem = item;

            if (RetItem == null)
                throw new ArgumentNullException();
            return RetItem;
        }

        // LastOrDefault<TSource>(IEnumerable<TSource>)
        // Возвращает последний элемент последовательности или значение по умолчанию, если последовательность не содержит элементов
        public static TSource? LastOrDefault<TSource>(this IEnumerable<TSource> list)
        {
            TSource? RetItem = default;

            foreach (var item in list)
                RetItem = item;

            return RetItem;
        }

        // Max<TSource>(IEnumerable<TSource>)
        // Возвращает максимальное значение, содержащееся в универсальной последовательности
        public static TSource Max<TSource>(this IEnumerable<TSource> list) where TSource : IComparable
        {
            if (list.Count() == 0)
                throw new ArgumentNullException();

            var max = list.First();
            foreach (var item in list)
                if (item.CompareTo(max) > 0)
                    max = item;

            return max;
        }

        // Min<TSource>(IEnumerable<TSource>)
        // Возвращает минимальное значение, содержащееся в универсальной последовательности
        public static TSource Min<TSource>(this IEnumerable<TSource> list) where TSource : IComparable
        {
            if (list.Count() == 0)
                throw new ArgumentNullException();

            var min = list.First();
            foreach (var item in list)
            {
                if (item.CompareTo(min) < 0)
                    min = item;
            }

            return min;
        }

        // Prepend<TSource>(IEnumerable<TSource>, TSource)
        // Добавляет значение в начало последовательности
        public static IEnumerable<TSource> Prepend<TSource>(this IEnumerable<TSource> list, TSource data) where TSource : IComparable
        {
            var RetList = (CircleList<TSource>)list;
            RetList.AddFirst(data);
            return RetList;
        }

        // Reverse<TSource>(IEnumerable<TSource>)
        // Изменяет порядок элементов последовательности на противоположный
        public static IEnumerable<TSource> Reverse<TSource>(this IEnumerable<TSource> list) where TSource : IComparable
        {
            if (list.Count() == 0)
                throw new ArgumentNullException();

            var NormalArray = list.ToArray();
            IEnumerable<TSource> RetList = new CircleList<TSource>();

            for (int i = NormalArray.Count() - 1; i >= 0; i--)
                RetList.Append(NormalArray[i]);

            return RetList;
        }

        // SequenceEqual<TSource>(IEnumerable<TSource>, IEnumerable<TSource>)
        // Определяет, совпадают ли две последовательности, используя для сравнения элементов компаратор проверки на равенство по умолчанию, предназначенный для их типа
        public static bool SequenceEqual<TSource>(this IEnumerable<TSource> first, IEnumerable<TSource> second) where TSource : IComparable
        {
            if (first == null || second == null)
                throw new ArgumentNullException();
            if (first.Count() != second.Count())
                return false;

            var FirstArr = first.ToArray();
            var SecondArr = second.ToArray();

            for (int i = 0; i < first.Count(); i++)
                if (FirstArr[i].CompareTo(SecondArr[i]) != 0)
                    return false;

            return true;
        }

        // Single<TSource>(IEnumerable<TSource>)
        // Возвращает единственный элемент последовательности и генерирует исключение, если число элементов последовательности отлично от 1
        public static TSource Single<TSource>(this IEnumerable<TSource> list)
        {
            if (list == null)
                throw new ArgumentNullException();
            else if (list.Count() != 1)
                throw new InvalidOperationException();
            else
                foreach (var item in list)
                    return item;
            throw new InvalidOperationException();
        }

        // Take<TSource>(IEnumerable<TSource>, Int32)
        // Возвращает указанное число подряд идущих элементов с начала последовательности
        public static IEnumerable<TSource> Take<TSource>(this IEnumerable<TSource> list, int number) where TSource : IComparable
        {
            if (list == null)
                throw new ArgumentNullException();
            else
            {
                IEnumerable<TSource> RetList = new CircleList<TSource>();
                if (number <= 0)
                    return RetList;

                int count = 0;
                foreach (var item in list)
                {
                    RetList.Append(item);
                    count++;
                    if (count == number)
                        return RetList;
                }
                return RetList;
            }
        }

        // TakeLast<TSource>(IEnumerable<TSource>, Int32)
        // Возвращает новую перечислимую коллекцию, содержащую последние count элементов из source
        public static IEnumerable<TSource> TakeLast<TSource>(this IEnumerable<TSource> list, int number)
        {
            var RetList = list.Reverse();
            return RetList.Take(number).Reverse();
        }
    }
}