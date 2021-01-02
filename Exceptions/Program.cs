using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            //ExceptionIntro();

            try
            {
                Find();
            }
            catch (RecordNotFoundException exception)
            {

                Console.WriteLine(exception.Message);
            }
            catch(Exception exception)
            {

            }
            
            HandleException(() =>{ Find(); }); //Hata yakalama metotlarını daha düzenli yazmak için kullanılan metot.
                                              // Yukaradaki try catch bloğuyla aynı işi yaparlar.
            Console.ReadLine();
        }

        private static void HandleException(Action action)
        {
            try
            {
                action.Invoke();
            }
            catch (Exception exception)
            {

                Console.WriteLine(exception.Message);
            }
        }

        private static void Find()
        {
            List<string> students = new List<string> { "Beyza", "Nur", "Kök" };
            if (!students.Contains("Erhan"))
            {
                throw new RecordNotFoundException("Record not found!");
            }
            else
            {
                Console.WriteLine("Record found!");

            }
        }

        private static void ExceptionIntro()
        {
            try // Bu kodu çalıştırmayı dener.
            {
                string[] students = new string[3] { "Beyza", "Nur", "Kök" };

                students[3] = "Ahmet";
            }
            catch (DivideByZeroException exception)//Eğer sıfıra bölünme hatasıyla karşılaşırsa burdaki kod bloğunu çalıştırır.
            {
                Console.WriteLine(exception.Message);
            }
            catch (IndexOutOfRangeException exception) //Eğer dizi boyutu aşma hatasıyla karşılaşırsa burdaki kod bloğunu çalıştırır.
            {
                Console.WriteLine(exception.Message);
            }
            catch (Exception exception) //Diğer hatalar için bu kod bloğunu çalıştırır.
            {

                Console.WriteLine(exception.Message);//Hatanın neden kaynaklandığını yazdırır.Ancak güvenlik nedeniyle son kullanıcıya bu bilgi verilmemelidir.
                Console.WriteLine(exception.InnerException);//Hatayı daha ayrıntılı listeler.
            }
        }
    }
}
