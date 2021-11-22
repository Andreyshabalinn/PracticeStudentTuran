using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentClass
{

    class Student {

        private string fio;
        private int edu_year;
        private int rec_book_num;

        public string FIO { get => fio; set => fio = value; }
        public int Edu_year { get => edu_year; set => edu_year = value; }
        public int Rec_book_num { get => rec_book_num; set => rec_book_num = value; }

        public Student(string FIO, int Edu_year, int Rec_book_num) {
            this.FIO = FIO;
            this.Edu_year = Edu_year;
            this.Rec_book_num = Rec_book_num;
        }

        public Student()
        {
            this.FIO = "Unknown";
            this.Edu_year = 1;
            this.Rec_book_num = 01;
        }

        public void Print() {
            Console.WriteLine(string.Format("ФИО студента {0}, год обучения {1}, номер книжки {2} ", this.FIO, this.Edu_year, this.Rec_book_num));
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Student Andrey = new Student("Шабалин Андрей Витальевич", 1,11258);
            Student Silent = new Student();
            Andrey.Print();
            Silent.Print();
            Console.ReadKey();
        }
    }
}
