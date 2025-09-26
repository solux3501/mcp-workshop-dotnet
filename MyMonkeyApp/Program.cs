using System;
using MyMonkeyApp;

namespace MyMonkeyApp
{
    class Program
    {
        static string[] funnyAsciiArts = new string[]
        {
            @"  (\(\
  (-.-)
  o_("")("")",
            @"  (>'-')>
  <('-'<)
  ^('-')^
  v('-')v",
            @"  (¬‿¬)
  (•_•) ( •_•)>⌐■-■ (⌐■_■)",
            @"  (☞ﾟヮﾟ)☞ ☜(ﾟヮﾟ☜)"
        };

        static void Main()
        {
            var rand = new Random();
            while (true)
            {
                Console.WriteLine("\n===== Monkey Console App =====");
                if (rand.Next(0, 2) == 1)
                {
                    Console.WriteLine(funnyAsciiArts[rand.Next(funnyAsciiArts.Length)]);
                }
                Console.WriteLine("1. 모든 원숭이 목록 출력");
                Console.WriteLine("2. 이름으로 원숭이 상세 정보 조회");
                Console.WriteLine("3. 랜덤 원숭이 선택");
                Console.WriteLine("4. 종료");
                Console.Write("선택: ");
                var input = Console.ReadLine();

                if (input == "1") ListMonkeys();
                else if (input == "2") ShowMonkeyDetail();
                else if (input == "3") ShowRandomMonkey();
                else if (input == "4") break;
                else Console.WriteLine("잘못된 입력입니다. 다시 시도하세요.");
            }
        }

        static void ListMonkeys()
        {
            Console.WriteLine("\n--- 모든 원숭이 목록 ---");
            var monkeys = MonkeyHelper.GetAllMonkeys();
            foreach (var m in monkeys)
            {
                Console.WriteLine($"이름: {m.Name}\n설명: {m.Description}\n서식지: {m.Habitat}\n{m.AsciiArt}\n");
            }
        }

        static void ShowMonkeyDetail()
        {
            Console.Write("\n원숭이 이름 입력: ");
            var name = Console.ReadLine();
            var monkey = MonkeyHelper.FindMonkeyByName(name);
            if (monkey != null)
            {
                Console.WriteLine($"\n이름: {monkey.Name}\n설명: {monkey.Description}\n서식지: {monkey.Habitat}\n나이: {monkey.Age}\n식성: {monkey.Diet}\n멸종위기: {(monkey.IsEndangered ? "O" : "X")}\n{monkey.AsciiArt}");
            }
            else
            {
                Console.WriteLine("해당 이름의 원숭이가 없습니다.");
            }
        }

        static void ShowRandomMonkey()
        {
            var monkey = MonkeyHelper.GetRandomMonkey();
            Console.WriteLine($"\n--- 랜덤 원숭이 ---\n이름: {monkey.Name}\n설명: {monkey.Description}\n서식지: {monkey.Habitat}\n나이: {monkey.Age}\n식성: {monkey.Diet}\n멸종위기: {(monkey.IsEndangered ? "O" : "X")}\n{monkey.AsciiArt}");
            Console.WriteLine($"(랜덤 선택 횟수: {MonkeyHelper.GetRandomPickCount()})");
        }
    }
}