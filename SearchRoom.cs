using System;
using System.Security.Cryptography;

public class GFG {
        static public void Main()
        {
            //вводимо початкові данні про кількість поверхів та під'їздів
            const int flours = 10; 
            const int rooms = 4;
            const bool logs = false;   //штука потрбіна лише для мене (виводить веселі логи)
            
            //всякі змінні потрібні для знаходження результату
            int roomNumber;
            int whatDoor = 1;
            int whatFlour = 1;

            //безпочередній початок програми
            Console.Write("\nВкажіть номер квартири: ");
            roomNumber = Convert.ToInt32(Console.ReadLine());

            //пошук під'їзду
            while(roomNumber > (flours * rooms)){
                roomNumber = roomNumber - (flours * rooms);
                whatDoor++;

                if(logs == true)
                    Console.Write("\n  :logs[room<"+(roomNumber + (flours * rooms))+"> - roomsAtDoor<"+(flours * rooms)+"> --> Door<"+whatDoor+">]");   //виведення логів для під'їзд
            }

            Console.WriteLine("\n");   //відступ потрібний для логів (покращує зрозумілість їх виведення)

            //пошук поверху
            while(roomNumber > rooms){
                roomNumber = roomNumber - rooms;
                whatFlour++;

                if(logs == true)
                    Console.WriteLine("  :logs[room<"+(roomNumber + flours)+"> - roomsAtFlour<"+rooms+"> --> Flour<"+whatFlour+">]");    //виведення логів для поверхів
            }

            //виведення результату:
            Console.WriteLine("\n\tРезультат: \n  Під'їзд: " + whatDoor + "\n  Поверх: " + whatFlour + "\n  Квартира: " + roomNumber);
            Console.Read();
            
        
        }
}