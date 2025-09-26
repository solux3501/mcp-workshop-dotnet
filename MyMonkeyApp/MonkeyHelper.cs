using System;
using System.Collections.Generic;
using System.Linq;

namespace MyMonkeyApp
{
    public static class MonkeyHelper
    {
        // MCP 서버에서 받아온 MonkeyExtended 데이터로 초기화 (예시 데이터)
        private static List<MonkeyExtended> monkeys = new List<MonkeyExtended>
        {
            new MonkeyExtended { Name = "Capuchin", Description = "작고 영리한 원숭이.", Habitat = "중남미", AsciiArt = "(\__/)", Age = 5, Diet = "과일", IsEndangered = false },
            new MonkeyExtended { Name = "Mandrill", Description = "얼굴이 화려하고, 가장 큰 원숭이.", Habitat = "아프리카", AsciiArt = "(o.o)", Age = 8, Diet = "과일, 곤충", IsEndangered = true },
            new MonkeyExtended { Name = "Howler", Description = "큰 소리로 울부짖는 원숭이.", Habitat = "남미", AsciiArt = "(°ロ°)", Age = 6, Diet = "잎, 과일", IsEndangered = false },
            new MonkeyExtended { Name = "Spider Monkey", Description = "긴 팔과 꼬리를 가진 원숭이.", Habitat = "중남미", AsciiArt = "(•_•)", Age = 7, Diet = "과일, 씨앗", IsEndangered = true }
        };

        private static int randomPickCount = 0;

        public static List<MonkeyExtended> GetAllMonkeys()
        {
            return monkeys;
        }

        public static MonkeyExtended GetRandomMonkey()
        {
            var rand = new Random();
            randomPickCount++;
            return monkeys[rand.Next(monkeys.Count)];
        }

        public static MonkeyExtended FindMonkeyByName(string name)
        {
            return monkeys.FirstOrDefault(m => m.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
        }

        public static int GetRandomPickCount()
        {
            return randomPickCount;
        }
    }
}
