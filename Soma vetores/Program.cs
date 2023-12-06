using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soma_vetores {
    class Program {
        static void Main(string[] args) {

            int n, i;

            Console.Write("Quantos valores vai ter cada vetor? ");
            n = int.Parse(Console.ReadLine());

            int[] a = new int[n];
            int[] b = new int[n];
            int[] c = new int[n];

            Console.WriteLine("Digite os valores do vetor A:");
            for (i = 0; i < n; i++) {
                a[i] = int.Parse(Console.ReadLine());                
            }

            Console.WriteLine("Digite os valores do vetor B:");
            for (i = 0; i < n; i++) {
                b[i] = int.Parse(Console.ReadLine());
            }

            for (i = 0; i < n; i++) {
                c[i] = a[i] + b[i];
            }

            Console.WriteLine("VETOR RESULTANTE:");
            for (i = 0; i < n; i++) {
                Console.WriteLine(c[i]);
            }
        }
    }
}
