using System.Collections;
using static task.FixedSizeList;

namespace task
{
    internal class Program
    {
        //static void ReverseArrayList(ArrayList list)
        //{
        //    int left = 0;
        //    int right = list.Count - 1;

        //    while (left < right)
        //    {
        //        object temp = list[left];
        //        list[left] = list[right];
        //        list[right] = temp;

        //        left++;
        //        right--;
        //    }
        //}
        //static void PrintArrayList(ArrayList list)
        //{
        //    foreach (var item in list)
        //    {
        //        Console.Write(item + " ");
        //    }
        //    Console.WriteLine();
        //}

        //class OptimizedBubbleSort
        //{
            //static void BubbleSort(int[] array)
            //{
            //    int n = array.Length;
            //    bool swapped;

            //    for (int i = 0; i < n - 1; i++)
            //    {
            //        swapped = false;

            //        for (int j = 0; j < n - i - 1; j++)
            //        {
            //            if (array[j] > array[j + 1])
            //            {

            //                int temp = array[j];
            //                array[j] = array[j + 1];
            //                array[j + 1] = temp;

            //                swapped = true;
            //            }
            //        }

            //        if (!swapped)
            //            break;
            //    }
            //}

            //static void PrintArray(int[] array)
            //{
            //    foreach (int item in array)
            //    {
            //        Console.Write(item + " ");
            //    }
            //    Console.WriteLine();
            //}


            static void Main(string[] args)
            {
                #region
                //int[] array = { 64, 34, 25, 12, 22, 11, 90 };
                //Console.WriteLine("Original array:");
                //PrintArray(array);

                //BubbleSort(array);

                //Console.WriteLine("\nSorted array:");
                //PrintArray(array);
                #endregion




                #region

                //Range<int> intRange = new Range<int>(5, 15);
                //Console.WriteLine("Is 10 in range: " + intRange.IsInRange(10)); 
                //Console.WriteLine("Is 20 in range: " + intRange.IsInRange(20)); 
                //Console.WriteLine("Length of range: " + intRange.Length()); 

                //Range<double> doubleRange = new Range<double>(1.5, 5.5);
                //Console.WriteLine("Is 3.0 in range: " + doubleRange.IsInRange(3.0)); 
                //Console.WriteLine("Is 6.0 in range: " + doubleRange.IsInRange(6.0)); 
                //Console.WriteLine("Length of range: " + doubleRange.Length());
                #endregion




                #region




                //ArrayList list = new ArrayList { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

                //Console.WriteLine("Original ArrayList:");
                //PrintArrayList(list);

                //ReverseArrayList(list);

                //Console.WriteLine("\nReversed ArrayList:");
                //PrintArrayList(list);

                #endregion


                #region
                //List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

                //List<int> evenNumbers = list.GetEvenNumbers(numbers);

                //Console.WriteLine("Even numbers:");
                //foreach (int number in evenNumbers)
                //{
                //    Console.Write(number + " ");

                //}
                //Console.WriteLine(  );

                //Console.WriteLine("///////////////////////////////");

                //List<int> OddnNumbers = list.GetOddNumbers(numbers);

                //Console.WriteLine("Odd numbers:");
                //foreach (int number in OddnNumbers)
                //{
                //    Console.Write(number + " ");

                //}



                #endregion

                #region
                //try
                //{
                //    FixedSizeList1<int> list = new FixedSizeList1<int>(3);
                //    list.Add(1);
                //    list.Add(2);
                //    list.Add(3);
                //    for (int i = 0; i < list.Count; i++)
                //    {
                //        Console.WriteLine(list.Get(i));
                //    }
                //}
                //catch (Exception ex)
                //{
                //    Console.WriteLine(ex.Message);
                //}
                #endregion


                #region
       



                List<Book> books = new List<Book>();
                {

                    new Book { ISBN = "123456", Title = "book one", Authors = "author one", PublicationDate = new DateTime(1, 5, 2022), Price = 100 },
                   new Book { ISBN = "123456", Title = "book one", Authors = "author one", PublicationDate = new DateTime(1, 5, 2022), Price = 150 }

                };

                
                BookProcessor.ProcessBooks(books, new BookDelegate(Bookfunctions.GetISBN));
                BookProcessor.ProcessBooks(books, new PublicationDateDelegate(Bookfunctions.GetPublicationDate));

                BookProcessorWithFunc.ProcessBooks(books, new Func<Book, string>(Bookfunctions.GetISBN));
                BookProcessorWithFunc.ProcessBooks(books, new Func<Book, DateTime>(Bookfunctions.GetPublicationDate));


                BookProcessorWithFunc.ProcessBooks(books, delegate (Book book) {
                    return book.ISBN;
                });
                BookProcessorWithFunc.ProcessBooks(books, book => book.PublicationDate);
            



            #endregion



        }

        }

    }
