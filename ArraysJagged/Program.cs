using System;

namespace ArraysJagged
{
    class Program
    {
        static void Main(string[] args)
        {
            ////tipo[][] Nombre = new tipo[tamaño del arreglo del contenedor][];

            //// Arreglo contenedor. Al poner "[][]" indicamos que es un arreglo de arreglos
            //// Si hubieramos puesto [,] esto indica que es una "Matriz".

            //double[][] Prueba = new double[5][];



            //// Inicializando los arreglos

            //Prueba[0] = new double[3]; //En la fila 0 hay 3 elementos
            //Prueba[1] = new double[5];  //En la fila 1 hay 5 elementos
            //Prueba[2] = new double[1];  //En la fila 2 hay 1 elementos
            //Prueba[3] = new double[4];  //En la fila 3 hay 4 elementos
            //Prueba[4] = new double[2];   //En la fila 4 hay 2 elementos


            //Prueba[1][3] = 7.4;

            //double resultado = Prueba[1][3] * 3;
            //Console.WriteLine(resultado);
            //Prueba[4][1] = 22.1;
            //double resultado1 = Prueba[1][3] + Prueba[1][4];
            //Console.WriteLine(resultado1);



            ////double[][] Calificaciones = new double [][]
            ////{
            ////    // En esta parte estamos declarando el array de tipo Jagged
            ////    // Estamos diciendo que tendremos un array de arrays en el que la primera fila
            ////    // tendra dos espacios con los numeros "7.0 y 8.4"
            ////    // y un asegunda fila que tendra tres espacios con los numeros "9.2,8.8 y 6.5"


            ////    new double[] { 7.0, 8.4 },
            ////    new double[] { 9.2, 8.8, 6.5}

            ////};

            int salones = 0;
            int alumnos = 0;

            int i; // Ciclo exterior (salones)
            int j; // Ciclo interior (alumnos)

            // Pedir la cantidad de salones

            Console.Write("Dame la cantidad de salones");
            salones = Convert.ToInt32(Console.ReadLine());

            // Crear el arreglo Jagged

            double[][] calificaciones = new double[salones][];

            Console.WriteLine();// Espacio de linea

            // Pedimos los alumnos por cada salon

            for (i = 0; i < salones; i++)
            {
                Console.WriteLine("Salon {0}", i + 1);
                Console.Write("Dame la cantidad de alumnos : ");
                alumnos = Convert.ToInt32(Console.ReadLine());

                // Asignamos los alumnos (instanciar el arreglo)

                calificaciones[i] = new double[alumnos];

            }

            //Ejemplo con GetLength ( Es el metodo utilizado para recorrer cada uno de los salones y cada uno de los alumnos que este en esos salones). GetLength nos obtiene el arreglo que esta dentro del otro arreglo

            //Console.WriteLine("Muestra la dimension del indice {0} ", calificaciones[0].GetLength(0));
            //Console.WriteLine("Muestra la dimension del indice {1} ", calificaciones[1].GetLength(0));
            //Console.WriteLine("Muestra la dimension del indice {0} ", calificaciones[2].GetLength(0));

            Console.WriteLine();

            //Pedimos las calificaciones


            for (i = 0; i < salones; i++)
            {
                Console.WriteLine("Salon {0}", i + 1);
                for (j = 0; j < calificaciones[i].GetLength(0); j++)
                {

                    Console.WriteLine("Dame la calificacion del alumno {0} ", j + 1);
                    calificaciones[i][j] = Convert.ToDouble(Console.ReadLine());

                }

            }

            //Mostramos la informacion

            Console.WriteLine("\n\nInformacion\n");


            for (i = 0; i < salones; i++)
            {
                Console.WriteLine("Salon {0}", i + 1);
                for (j = 0; j < calificaciones[i].GetLength(0); j++)
                {
                    Console.WriteLine("El alumno {0} tiene {1} de calificacion ", j + 1, calificaciones[i][j]);
                }
            }
        }
    }
}
