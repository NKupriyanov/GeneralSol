using System.Data.SqlTypes;

namespace Home3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task1();
            //Task2();
            //Task3();
            Task4();
        }

        /// <summary>
        /// Задать строку содержащую внутри цифры и несколько повторений слова test, Заменить в строке все вхождения 'test' на 'testing'.
        /// </summary>

        public static void Task1()
        {
            string text = "test 1 test 2 test 3";
            string newText = text.Replace("test", "testing");

            Console.WriteLine(newText);
        }

        /// <summary>
        /// Создайте переменные, которые будут хранить следующие слова: 
        /// (Welcome, to, the, TMS, lessons)выполните конкатенацию слов и выведите на экран следующую фразу: Welcome to the TMS lessons. 
        /// </summary>

        public static void Task2()
        {
            string word1 = "\"Welcome\" ";
            string word2 = "\"to\" ";
            string word3 = "\"the\" ";
            string word4 = "\"TMS\" ";
            string word5 = "\"lessons\"";
            string text = word1 + word2 + word3 + word4 + word5;

            Console.WriteLine(text);
        }

        /// <summary>
        /// Дана строка: teamwithsomeofexcersicesabcwanttomakeitbetter.
        /// Необходимо найти в данной строке "abc", записав всё что до этих символов в переменную firstPart, а также всё, что после них во вторую secondPart.
        /// </summary>

        public static void Task3()
        {
            string text = "teamwithsomeofexcersicesabcwanttomakeitbetter";
            string keyword = "abc";
            int index = text.IndexOf(keyword);
            string firstPart = text.Substring(0, index);
            string secondPart = text.Substring(index + keyword.Length);

            Console.WriteLine("firstPart: " + firstPart);
            Console.WriteLine("secondPart: " + secondPart);
        }

        /// <summary>
        /// Дана строка: Good day 
        /// Необходимо с помощью метода substring удалить слово "Good". 
        /// После чего необходимо используя команду insert создать строку со значением: The best day!!!!!!!!!.
        /// Заменить последний "!" на "?" и вывести результат на консоль. 
        /// </summary>

        public static void Task4()
        {
            string text = "Good day";
            text = text.Substring(4);

            String text1 = "The best";
            text = text.Insert(0, text1);

            String text2 = "!!!!!!!!!";
            text = text.Insert(12, text2);

            int ind = text.Length - 1;
            text = text.Remove(ind);

            String text3 = "?";
            text = text.Insert(20, text3);

            Console.WriteLine(text);
        }
    }
}