using System;

namespace Perceptron4Entradas
{
    class Program
    {
        static void Main(string[] args)
        {
            Neurona p = new Neurona(4);
            Random r = new Random();

            bool sw = false;
            while (!sw)
            {
                sw = true;

                Console.WriteLine("---------------------------------------");
                Console.WriteLine("w1: " + p.w[0]);
                Console.WriteLine("w2: " + p.w[1]);
                Console.WriteLine("w3: " + p.w[2]);
                Console.WriteLine("w4: " + p.w[3]);
                Console.WriteLine("u: " + p.u);
                Console.WriteLine("x1:-1   x2:-1  x3:-1  x4:-1  : " + p.Salida(new float[4] { -1f, -1f, -1f, -1f }));
                Console.WriteLine("x1:-1   x2:-1  x3:-1  x4: 1  : " + p.Salida(new float[4] { -1f, -1f, -1f, 1f }));
                Console.WriteLine("x1:-1   x2:-1  x3: 1  x4:-1  : " + p.Salida(new float[4] { -1f, -1f, 1f, -1f }));
                Console.WriteLine("x1:-1   x2:-1  x3: 1  x4: 1  : " + p.Salida(new float[4] { -1f, -1f, 1f, 1f }));
                Console.WriteLine("x1:-1   x2: 1  x3:-1  x4:-1  : " + p.Salida(new float[4] { -1f, 1f, -1f, -1f }));
                Console.WriteLine("x1:-1   x2: 1  x3:-1  x4: 1  : " + p.Salida(new float[4] { -1f, 1f, -1f, 1f }));
                Console.WriteLine("x1:-1   x2: 1  x3: 1  x4:-1  : " + p.Salida(new float[4] { -1f, 1f, 1f, -1f }));
                Console.WriteLine("x1:-1   x2: 1  x3: 1  x4: 1  : " + p.Salida(new float[4] { -1f, 1f, 1f, 1f }));
                Console.WriteLine("x1: 1   x2:-1  x3:-1  x4:-1  : " + p.Salida(new float[4] { 1f, -1f, -1f, -1f }));
                Console.WriteLine("x1: 1   x2:-1  x3:-1  x4: 1  : " + p.Salida(new float[4] { 1f, -1f, -1f, 1f }));
                Console.WriteLine("x1: 1   x2:-1  x3: 1  x4:-1  : " + p.Salida(new float[4] { 1f, -1f, 1f, -1f }));
                Console.WriteLine("x1: 1   x2:-1  x3: 1  x4: 1  : " + p.Salida(new float[4] { 1f, -1f, 1f, 1f }));
                Console.WriteLine("x1: 1   x2: 1  x3:-1  x4:-1  : " + p.Salida(new float[4] { 1f, 1f, -1f, -1f }));
                Console.WriteLine("x1: 1   x2: 1  x3:-1  x4: 1  : " + p.Salida(new float[4] { 1f, 1f, -1f, 1f }));
                Console.WriteLine("x1: 1   x2: 1  x3: 1  x4:-1  : " + p.Salida(new float[4] { 1f, 1f, 1f, -1f }));
                Console.WriteLine("x1: 1   x2: 1  x3: 1  x4: 1  : " + p.Salida(new float[4] { 1f, 1f, 1f, 1f }));

                if (p.Salida(new float[4] { -1f, -1f, -1f, -1f }) != -1)
                {
                    p.Aprender(new float[4] { -1f, -1f, -1f, -1f }, -1);
                    sw = false;
                }

                if (p.Salida(new float[4] { -1f, -1f, -1f, 1f }) != -1)
                {
                    p.Aprender(new float[4] { -1f, -1f, -1f, 1f }, -1);
                    sw = false;
                }

                if (p.Salida(new float[4] { -1f, -1f, 1f, -1f }) != -1)
                {
                    p.Aprender(new float[4] { -1f, -1f, 1f, -1f }, -1);
                    sw = false;
                }

                if (p.Salida(new float[4] { -1f, -1f, 1f, 1f }) != -1)
                {
                    p.Aprender(new float[4] { -1f, -1f, 1f, 1f }, -1);
                    sw = false;
                }

                if (p.Salida(new float[4] { -1f, 1f, -1f, -1f }) != -1)
                {
                    p.Aprender(new float[4] { -1f, 1f, -1f, -1f }, -1);
                    sw = false;
                }

                if (p.Salida(new float[4] { -1f, 1f, -1f, 1f }) != -1)
                {
                    p.Aprender(new float[4] { -1f, 1f, -1f, 1f }, -1);
                    sw = false;
                }

                if (p.Salida(new float[4] { -1f, 1f, 1f, -1f }) != -1)
                {
                    p.Aprender(new float[4] { -1f, 1f, 1f, -1f }, -1);
                    sw = false;
                }

                if (p.Salida(new float[4] { -1f, 1f, 1f, 1f }) != -1)
                {
                    p.Aprender(new float[4] { -1f, 1f, 1f, 1f }, -1);
                    sw = false;
                }

                if (p.Salida(new float[4] { 1f, -1f, -1f, -1f }) != -1)
                {
                    p.Aprender(new float[4] { 1f, -1f, -1f, -1f }, -1);
                    sw = false;
                }

                if (p.Salida(new float[4] { 1f, -1f, -1f, 1f }) != -1)
                {
                    p.Aprender(new float[4] { 1f, -1f, -1f, 1f }, -1);
                    sw = false;
                }

                if (p.Salida(new float[4] { 1f, -1f, 1f, -1f }) != -1)
                {
                    p.Aprender(new float[4] { 1f, -1f, 1f, -1f }, -1);
                    sw = false;
                }

                if (p.Salida(new float[4] { 1f, -1f, 1f, 1f }) != -1)
                {
                    p.Aprender(new float[4] { 1f, -1f, 1f, 1f }, -1);
                    sw = false;
                }

                if (p.Salida(new float[4] { 1f, 1f, -1f, -1f }) != -1)
                {
                    p.Aprender(new float[4] { 1f, 1f, -1f, -1f }, -1);
                    sw = false;
                }

                if (p.Salida(new float[4] { 1f, 1f, -1f, 1f }) != -1)
                {
                    p.Aprender(new float[4] { 1f, 1f, -1f, 1f }, -1);
                    sw = false;
                }

                if (p.Salida(new float[4] { 1f, 1f, 1f, -1f }) != -1)
                {
                    p.Aprender(new float[4] { 1f, 1f, 1f, -1f }, -1);
                    sw = false;
                }

                if (p.Salida(new float[4] { 1f, 1f, 1f, 1f }) != 1)
                {
                    p.Aprender(new float[4] { 1f, 1f, 1f, 1f }, 1);
                    sw = false;
                }


            }
            Console.ReadKey();
        }

    }
    public class Neurona
    {
        float[] wa;
        float ua;

        public float[] w;
        public float u;
        public float TSA = 0.3f;

        public Neurona(int nx)
        {
            wa = new float[nx];
            w = new float[nx];
            Aprender();
        }

        public void Aprender()
        {
            Random r = new Random();
            for (int i = 0; i < wa.Length; i++)
            {
                wa[i] = Convert.ToSingle(r.NextDouble() - r.NextDouble());
            }

            ua = Convert.ToSingle(r.NextDouble() - r.NextDouble());

            w = wa;
            u = ua;
        }

        public void Aprender(float[] entradas, float dx)
        {
            float error = dx - Salida(entradas);
            for (int i = 0; i < w.Length; i++)
            {
                w[i] = wa[i] + TSA * error * entradas[i];
            }
            u = ua + TSA * error;

            wa = w;
            ua = u;
        }

        public float Salida(float[] entradas)
        {
            return function(neurona(entradas));
        }
        float neurona(float[] entradas)
        {
            float sum = 0;

            for (int i = 0; i < w.Length; i++)
            {
                sum += entradas[i] * w[i];
            }

            sum += u;

            return sum;
        }

        float function(float d)
        {
            return d > 0 ? 1 : -1;
        }
    }
}
