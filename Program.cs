// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;



StringBuilder sb = new StringBuilder();
var obj = new
{
    thuoctinh1 = 15,
    thuoctinh2 = "Kieutext"
};
dynamic khongbiethuoctinh;
Nullable<int> innnn = null;
void ChangeValue(int valueneedchange)
{
    valueneedchange = 120;
    Console.WriteLine(valueneedchange);
}

    int bien = 0;
    Console.WriteLine(bien); 
    ChangeValue(bien);
    Console.WriteLine(bien);

class Animal    
{
    static int dec = 0;
public
    Animal() { dec++; }
public
    void Move() {
        Console.WriteLine("Day");
    }
}

class Bird : Animal
{

public
    Bird() { }
    public void Move() {
        Console.WriteLine("Day la chuong trinh tieng noi viet , phat thanh tu thu do Ha Noi");
    }
}
//Thu 5
class APP
{
    void main(String[] agrs)
    {
        // Vong lap voi for
        int i;
        for (i=0; i <= 100; i++) { if(i==10); }
        Animal newObject = new Animal();
        Animal newObject2 = new Animal();
        //Vong lap voi while
        int a1=0;
        while (true) { if (a1 == 5) { break; } a1++; }
        //Toan tu ?
        var result = a1>i ? "sai":"dung";
        int o = 1; 
        //Vong lap do while
        do {
            o++;
        }while (o == 1);
        
    }

    // Mang
    int[] a = new int[10];
    // Mang hai chieu
    int [,] haichieu= new int [10,20];
    //Mang 3 chieu
    int[,,] bachieu = new int[10, 20, 30];
    //Mang rang cua
    int[][] rangcua = new int[10][];
    // Truy cap vao mang " Chi tu"
    void SetA()
    {
        a[3] = 5;
        haichieu[3,4] = 5;
        rangcua[3][5] = 5;
    }
    //ArrayList
    ArrayList mangdanhsach = new ArrayList();
    //List
    List<int> danhsach = new List<int> ();
    //SortedList
    SortedList<int,string> sapxepso = new SortedList<int,string>();

}


