using System;

namespace TheArray
{
    /// <summary>
    /// demonstrates C# arrays
    /// to run this prgram by arrayApp
    /// </summary>
    class ArrayApp
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            long[] arr;             //reference to arry
            arr = new long[100];    //make array
            int nElems = 0;         // number of itmes

            int j;                  //loop counter
            long searchKey;         //key of item to search for
//......................................................................................

            arr[0] = 77;            //inert 10 items
            arr[1] = 99;
            arr[2] = 44;
            arr[3] = 55;
            arr[4] = 22;
            arr[5] = 88;
            arr[6] = 11;
            arr[7] = 00;
            arr[8] = 66;
            arr[9] = 33;
            nElems = 10;           //now 10 items in arry
//......................................................................................

            for (j = 0; j < nElems; j++)  //display items
                Console.WriteLine(arr[j] + " ");
            Console.WriteLine("");
//.......................................................................................

            searchKey = 66;                                     //find item with key 66

            for (j = 0; j < nElems; j++)                        //for each element,
                if (arr[j] == searchKey)                        //found item?
                    break;                                      //yes, exi before and     
            if (j == nElems)                                    // at the end?
                Console.WriteLine("Can't find " + searchKey);   //yes
            else
                Console.WriteLine("Found" + searchKey);         //no
//........................................................................................

            searchKey = 55;                                     //delete ite with key 55
            for (j = 0; j < nElems; j++)                        //look for it
                if (arr[j] == searchKey)
                    break;
            for (int k = j; k < nElems; j++)                    //move higher ones down
                arr[k] = arr[k + 1];
            nElems--;                                           //decrement size
//----------------------------------------------------------------------------------------
            for (j = 0; j < nElems; j++)                            //display items
                Console.WriteLine(arr[j] + " ");
            Console.WriteLine("");

        } // end main
    } // end calss ArryAPP
}
