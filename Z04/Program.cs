 int i = 1;
            bool not = true;

            Console.WriteLine("Введите число:");
         int A = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Чётные числа от 1 до  " + A);
            while (i <= A)
            {
                if (i % 2 != 1)
                {
                    Console.Write(i + ", ");
                    not = false;
                }
                i++;
            }

            if (not)
            {
                Console.WriteLine("Нет чётных чисел!");
            }
          

     
          
