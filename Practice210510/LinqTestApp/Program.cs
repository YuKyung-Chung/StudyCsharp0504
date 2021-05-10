using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace LinqTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] arr = { 5, 7, 1, 3, 9, 10, 4, 2 };

            var profiles = new List<Profile>();
            //List<Profile> profiles = new List<Profile>();
            profiles.Add(new Profile() { Name = "정우성", Height = 186 });
            profiles.Add(new Profile() { Name = "김태희", Height = 158 });
            profiles.Add(new Profile() { Name = "전지현", Height = 171 });
            profiles.Add(new Profile() { Name = "고현정", Height = 172 });
            profiles.Add(new Profile() { Name = "이문세", Height = 178 });
            profiles.Add(new Profile() { Name = "하동훈", Height = 170 });

            var profiles1 = from item in profiles
                            orderby item.Height descending
                            select new { Name = item.Name, Inch = item.Height * 0.393 };


            Console.WriteLine("전체 프로필 리스트");
            foreach (var item in profiles)
            {
                Console.WriteLine($"{item.Name} : {item.Height} cm.");
            }

            /*List<Profile> newProfiles = new List<Profile>();
            foreach (var item in profiles)
            {
                if (item.Height < 172)
                    newProfiles.Add(item);
            }*/



            // 키 큰순으로 정렬작업 -> 3~4줄 코딩 더 필요 (원래는)
            var newProfiles = from item in profiles
                              where item.Height < 172
                              orderby item.Height descending // Linq 사용하여 정렬
                              select item;

            Console.WriteLine("172cm 이하 프로필 리스트.");
            foreach (var item in newProfiles)
            {
                Console.WriteLine($"{item.Name} : {item.Height} cm.");
            }


            int maxSize = 100;
            int[] numbers = new int[maxSize];
            for (int i = 0; i < maxSize; i++)
            {
                numbers[i] = (i + 1);
            }

            var result = from item in numbers
                         where (item % 10 == 3 || item % 10 == 6 || item % 10 == 9 || item /10 == 3 || item/10 == 6 || item/10 == 9)
                         select item;
            foreach (var item in result)
            {
                Console.Write($"{item}\t");
            }
            Console.WriteLine();

            /////////////////////////////////////////////////////////////////
            InstClass[] arrClasses = {
                new InstClass() { Name = "연두반", Scores = new int[] { 99, 80, 70, 24 } },
                new InstClass() { Name = "분홍반", Scores = new int[] { 60, 45, 87, 72 } },
                new InstClass() { Name = "파랑반", Scores = new int[] { 92, 30, 85, 94} },
                new InstClass() { Name = "노랑반", Scores = new int[] { 90, 88, 0, 17 } },
            };

            var rstClasses = from item in arrClasses
                             from score in item.Scores
                             where score < 60
                             orderby score ascending
                             select new { Name = item.Name, Lowest = score };

            foreach (var item in rstClasses)
            {
                Console.Write($"{item.Name} : {item.Lowest}\t");
            }
            Console.WriteLine();


            //group by
            var listProfiles = from item in profiles
                               orderby item.Height
                               group item by item.Height < 172 into g
                               select new { GroupKey = g.Key, Profiles = g };
            foreach (var item in listProfiles)
            {
                Console.WriteLine($"- 172cm 미만: {item.GroupKey}");

                foreach (var sub in item.Profiles)
                {
                    Console.WriteLine($">>> {sub.Name} : {sub.Height}");
                }
            }
        }
    }
}
