using System;
    class List
    {
        private Production[] _lPS;
        private int _n;

        public Production[] LPS{get => _lPS;}

        public void PS_List()
        {
            Console.Write("So luong nhan vien van phong: ");
            _n = Convert.ToInt32(Console.ReadLine());
            Production [] p = new Production[_n];

            for (int i=0; i<_n; i++)
            {
                Console.WriteLine("Nhap nhan vien thu " +(i+1));
                Console.WriteLine(" ========== ");
                p[i] = new Production();
                p[i].Input();           
                p[i].Display();    
            }
            Production tl;
            for (int i=0; i<_n; i++)
            {
                for (int j=i+1; j<_n; j++)
                {
                    if (p[i].Luong< p[j].Luong)
                    {
                        tl = p[i];
                        p[i] = p[j];
                        p[j] = tl;
                    }
                }
            }   
            Console.WriteLine(" ========== ");
            Console.WriteLine("So tien luong giam dan cua nhan vien san xuat\n");
            for (int i=0; i<_n; i++)
            {   
                Console.WriteLine("Ho ten: {0}\nLuong nhan vien san xuat: {1:F3}\n", p[i].HoTen, p[i].Luong);
            }   
        }
    }
