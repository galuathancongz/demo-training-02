// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    Animal() { dec++; }

    static void Count() { }
}

class Bird : Animal
{

} 

class APP
{
    void main(String[] agrs)
    {
        Animal newObject = new A();
        Animal newObject2 = new A(); 
    }
}
//Override - ghi de
