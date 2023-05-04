using System;


class person
{
    readonly int pid;
    string pname;
    int page;
    
    person()
    {
        pid=123;
    }
    public static void Main ()
    {
        person obj= new person();
        obj.pname="sandeep";
        obj.page=53;
        Console.WriteLine(obj.pid +" "+obj.pname+" "+obj.page);
        
        person obj1=new person();
        obj1.pname="Prashant";
         obj1.page=23;
         Console.WriteLine(obj1.pid+" "+obj1.pname+" "+obj.page);




    }



}