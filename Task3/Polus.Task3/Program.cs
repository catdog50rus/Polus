/*
 * Пусть есть некоторый Timer который запускает функцию f() раз в 5 секунд.
 * Что будет, если функция будет работать гораздо дольше 5 секунд?
 * Какие можете предложить варианты в разных ситуациях?
 * Как бы вы исправили код чтобы при минимальных изменениях получить наиболее надежное 
   работоспособное исправление этой проблемы?
 */


using System;
using System.Threading;

namespace Polus.Task3
{
    class Program
    {
        static void Main()
        {
            //Таймер из условия задачи. 
            //Необходимо, чтобы ссылка на Таймер не вышла из области видимости и не была уничтожена сборщиком мусора.
            //Таймер запускает метод в бэкграунде, поэтому метод может быть прерван. когда завершатся основные потоки
            //и работа приложения завершится.
            //Необходимо управлять потоком через классы AutoResetEvent, ManualResetEvent

            // Превышение времени отклика                
            var timeout = 4900;
            new SameTimer().ResponseOverTime(5000, timeout);

            Console.WriteLine("Для завершения нажмите любую клавишу");
            Console.WriteLine();
            Console.ReadKey();

        }

    }

    public class SameTimer
    {
        private Timer _timer;

        public void DefaultTimer(int period)
        {
            Work work = new Work(0);
            var timerCallback = new TimerCallback(work.GetDefaultMeasurement);
            _timer = new Timer(timerCallback, null, 0, period);
        }

        public void ResponseOverTime(int period, int timeout)
        {
            Work work = new Work(timeout);
            var reset = new AutoResetEvent(false);
            var timerCallback = new TimerCallback(work.GetMeasurement);
            _timer = new Timer(timerCallback, reset, 0, period);
            reset.WaitOne();
            _timer.Dispose();
            
        }

    }

    /// <summary>
    /// Какая то работа по снятию показаний
    /// </summary>
    public class Work
    {
        private readonly System.Timers.Timer timer;
        private AutoResetEvent _resetEvent;

        public Work(int timeout)
        {
            if (timeout > 0)
            {
                timer = new System.Timers.Timer(timeout);
                timer.Elapsed += Timer_Elapsed;
            }       
        }

        public void GetDefaultMeasurement(object state)
        {
            Console.WriteLine($"Поток измерения: {Thread.CurrentThread.ManagedThreadId}, Получаю показания прибора");
            Thread.Sleep(5000); //Моделирование получения ответа от прибора
            Console.WriteLine($"Поток измерения: {Thread.CurrentThread.ManagedThreadId}, " +
                                  $"время снятия показаний {DateTime.Now}, Status: Ok!");
        }

        public void GetMeasurement(object state)
        {
            if (state != null && state is AutoResetEvent reset)
                _resetEvent = reset;
            timer.Start();
            Console.WriteLine($"Поток измерения: {Thread.CurrentThread.ManagedThreadId}, Получаю показания прибора");
            Thread.Sleep(5000); //Моделирование получения ответа от прибора
            if (timer.Enabled)
                Console.WriteLine($"Поток измерения: {Thread.CurrentThread.ManagedThreadId}, " +
                                  $"время снятия показаний {DateTime.Now}, Status: Ok!");
            timer.Stop();
        }

        private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            Console.WriteLine("Превышено время ожидания от прибора!");
            _resetEvent.Set();
            timer.Stop();
        }
    }
}
