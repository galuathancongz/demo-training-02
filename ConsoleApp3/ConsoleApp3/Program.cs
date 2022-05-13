using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace ConsoleApp3
{
    class Program
    {
        //Tu dien
        public static IDictionary<int, string> taoratudien = new Dictionary<int, string>();
        //Hashtable
        public static Hashtable bangbam = new Hashtable();
        //Stack
        public static Stack<int> nganxep = new Stack<int>();
        //Queue
        public static Queue<int> hangdoi=new Queue<int>();
        //Tuple
        public static Tuple<int, int, string> tuple = new Tuple<int, int, string>(1,2,"ba");
        //Tuple long nhau
        //public static Tuple<int, int, string, Tuple<int, int, string,int> tuplelong = Tuple.Create <int, int, string, Tuple<int, int, string, int>;
       // Value Tuple
       // Khong co var
        public static void Main(string[] args)
        {
            //Tu dien
            //Them phan tu
            taoratudien.Add(1, "mot");
            taoratudien.Add(2, "hai");
            //Truy cap vao phan tu
            
            Console.WriteLine(taoratudien[1]);
            //Cap nhat phan tu
            taoratudien[1] = "mot tram";
            Console.WriteLine(taoratudien[1]);
            //Xoa phan tu
            taoratudien.Remove(1);

            //Bang bam
            //Them phan tu
            bangbam.Add(1,"mot");
            bangbam.Add(2, "hai");
            //Truy cap phan tu
            Console.WriteLine(bangbam[1]);
            // Con lai giong tu dien, ko lam nua

            //Ngan xep
            nganxep.Push(1);
            nganxep.Push(2);
            nganxep.Push(3);
            nganxep.Push(4); 
            nganxep.Push(5);
            //Pop(). Lay lan luot phan tu ra tu sau-> truoc
            while (nganxep.Count > 0)
            {
                Console.WriteLine(nganxep.Pop());
            }
            //Peek(). Goi phan tu cuoi cung tu ngan xep
            Console.WriteLine(nganxep.Peek());
            //Contain(). Kiem tra xem co phan tu do o trong ngan xep hay khong, neu co thi true. Khong co thi fail
            nganxep.Contains(1);
            
            //Hang doi
            //Them phan tu
            hangdoi.Enqueue(1);
            hangdoi.Enqueue(2);
            hangdoi.Enqueue(3);
            hangdoi.Enqueue(4);
            hangdoi.Enqueue(5);
            //Dequeue: Tra 1 muc tu dau hang doi va xoa no
            Console.WriteLine(hangdoi.Dequeue());
            //Peek: Giong dequeue nhung ko xoa no( Con lai giong hang doi)

            //Tuple
            //Truy cap vao tuple
            Console.WriteLine(tuple.Item1);
            //
        }
    }
}
