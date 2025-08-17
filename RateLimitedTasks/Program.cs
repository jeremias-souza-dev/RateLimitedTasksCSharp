using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
namespace RateLimitedTasks {

    class Program {
        static async Task Main() {
            int total = 4000;
            int limitPerMinute = 4000;

            int delayBetween = 60000 / limitPerMinute; // tempo entre execuções

            List<Task> tasks = new List<Task>();

            for (int i = 0; i < total; i++) {
                tasks.Add(ExecutarAsync(i, total));

                // aguarda antes de iniciar a próxima execução
                await Task.Delay(delayBetween);
            }

            await Task.WhenAll(tasks);
            Console.WriteLine("Concluído!");
        }

        static async Task ExecutarAsync(int id, int total) {
            Console.WriteLine($"Executando {id} falta {total - id} - {DateTime.Now:HH:mm:ss.fff}");
            await Task.Delay(1000); // simula trabalho
        }
    }
}