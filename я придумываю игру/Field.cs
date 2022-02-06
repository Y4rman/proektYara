using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Field1
{
    public class Field
    {
        private byte[,] rooms = { { 0, 0, 0, -1, 0 }, { 0, 0, 0, 0, 0 } };
        /* 
         0 1 2 3 4 

         0 0 0 -1 0
         0 0 0  0 0

        0 0
        1 0
        0 0
        0 1
        0 0
        0 0
        12 — для лопнувших
        15 — для сгоревших
        20 — для выключенных
         */
        // лопается лампочка, через 7 секунд получает список лампочек, которые можно лопнуть, затем лопает по этому списку.
        public void burnOut()
        {
            byte[] canBurn;
            // List<int> canBurn = new List<int>();
            for (byte i = 0; i < rooms.Length; i++)
            {
                if (rooms[i].Contains(1)) {
                    for (byte j = 0; j < rooms.Length; i++)
                    {
                        if (rooms[i, j] == 1) {
                            canBurn.AddRange({ i, j });
                        }
                    }
                }
            }
            Random rnd = new Random((int)(DateTime.Now.Ticks));
            // 0, 4
            rooms[rnd.Next(0, canBurn.Length), rnd.Next(0, canBurn.Length)] = -1; // дописать рандом для созданного списка canBurn
        // если человек не чинит лампочку в течение 12 секунд, то страх становится больше на 0.1
        }
        public void getRoom()
        {
            Console.WriteLine(rooms[0, 3]);
        }
        
    }
}
