using System;

namespace Polymorphism
{
    public class Mahasiswa
    {
        public virtual void Mhs()
        {
            Console.WriteLine("Mahasiswa Universitas Amikom ");
        }
  
    public class Pelajar : Mahasiswa
    {
            public override void Mhs()
            {
                Console.WriteLine("Jaystka Pradana Kusuma");
            }
    }
        public class Siswa : Mahasiswa
        {
            public override void Mhs()
            {
                Console.WriteLine("Susilo Faat Septianto");
            }
        }
        public class Student : Mahasiswa
        {
            public override void Mhs()
            {
                Console.WriteLine("M. Zhafir Zaydan");
            }
        }

        class Polymorphism
        {
            public static void Main()
            {
                Mahasiswa[] dObj = new Mahasiswa[4];
                dObj[0] = new Pelajar();
                dObj[1] = new Siswa();
                dObj[2] = new Student();
                dObj[3] = new Mahasiswa();

                foreach (Mahasiswa mhs in dObj)
                {
                    mhs.Mhs();
                }
                Console.ReadKey();
            }
        }
    }
}
