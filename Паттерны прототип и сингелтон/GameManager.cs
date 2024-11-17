using System;
using System.Collections.Generic;

namespace Паттерны_прототип_и_сингелтон
{
    internal class GameManager
    {
        private static GameManager instance;

        public int Level { get; set; }
        public int Score { get; set; }
        public List<string> CurrentTask { get; private set; }

        private GameManager()
        {
            Level = 1;
            Score = 0;
            CurrentTask = new List<string>();
        }

        public static GameManager getInstance()
        {
            if (instance == null)
                instance = new GameManager();
            return instance;
        }

        public void NextLevel()
        {
            Level++;
            Console.WriteLine($"Level up! Now at level: {Level}");
        }

        public void AddScore( int points)
        {
            Score += points;
            Console.WriteLine($"Score updated: {Score}");
        }

        public void AddTask(string task)
        {
            CurrentTask.Add(task);
            Console.WriteLine($"Task added: {task}");
        }

        public void ShowStatus()
        {
            Console.WriteLine($"Current Level: {Level}, Score: {Score}, Tasks: {string.Join(", ", CurrentTask)}");
        }
    }
}
