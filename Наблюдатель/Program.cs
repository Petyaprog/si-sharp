using System;
using System.Collections.Generic;

namespace Наблюдатель
{
    public abstract class Observer
    {
        public abstract void Update();
    }

    public class ConcreteObserver : Observer
    {
        private string log;
        private char detachInfo;
        private ConcreteSubject subj;

        public ConcreteObserver(ConcreteSubject subj, char detachInfo)
        {
            this.subj = subj;
            this.detachInfo = detachInfo;
            this.log = string.Empty;
        }

        public override void Update()
        {
            char currentState = subj.GetState();
            log += currentState;

            if (currentState == detachInfo)
            {
                Detach();
            }
        }

        public void Attach()
        {
            subj.Attach(this);
        }

        public void Detach()
        {
            subj.Detach(this);
        }

        public string GetLog() { return log; }
    }
    public class Subject
    {
        protected List<Observer> observers = new List<Observer>();

        public void Attach(Observer observ)
        {
            if (!observers.Contains(observ))
            {
                observers.Add(observ);
            }
        }

        public void Detach(Observer observ)
        {
            observers.Remove(observ);
        }

        protected void Notify()
        {
            var currentObservers = new List<Observer>(observers);

            foreach (var observer in currentObservers)
            {
                observer.Update();
            }
        }
    }

    public class ConcreteSubject : Subject
    {
        private char state;

        public ConcreteSubject()
        {
            state = ' '; 
        }

        public void SetState(char st)
        {
            if (st != state)
            {
                state = st;
                Notify();
            }
        }

        public char GetState() { return state; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            if (N > 10 || N < 1)
            {
                Console.WriteLine("Число должно быть от 1 до 10.");
                return;
            }
            string S = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            ConcreteSubject subj = new ConcreteSubject();
            ConcreteObserver[] observers = new ConcreteObserver[N];
            for (int i = 0; i < N; i++)
            {
                observers[i] = new ConcreteObserver(subj, S[i]);
                observers[i].Attach();
            }

            foreach (char c in S)
            {
                subj.SetState(c); 
            }

            for (int i = 0; i < N; i++)
            {
                Console.WriteLine($"Лог наблюдателя {observers[i].GetLog()}");
            }
        }
    }
}
