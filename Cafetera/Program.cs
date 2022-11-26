using System;

namespace Cafetera
{
    class Program
    {

        // ------------ TIPOS DE VASOS ------------------
       static int vasosPequenos = 5;
        // 3 OZ
        static int vasosMedianos = 5;
        // 5 OZ
     static int vasosGrandes = 5;
        // 7 OZ
        // ---------- CANTIDAD DE CAFE --------------------
        static int cafe = 10;
        // ---------- CANTIDAD DE CUCHARADAS DE AZUCAR -------------
        static int azucar = 15;
        static void Main(string[] args)
        {
            Cafetera();
           
        }


        static void Cafetera()
        {
            Console.WriteLine("---------- BIENVENIDO A TU CAFETERA VIRTUAL! ---------------");
            GetVaso();
            
        }
        
        static void GetVaso()
        {
            Console.WriteLine();
            Console.WriteLine(" ----- Seleccione el tipo de Vaso que quiere: ");
            Console.WriteLine();
            Console.WriteLine("1. Vaso Pequeno (3 OZ)");
            Console.WriteLine("2. Vaso Mediano (5 OZ)");
            Console.WriteLine("3. Vaso Grande (7 OZ)");
            int tipoVaso = 0;
            string nameVaso = "";
            try
            {
                tipoVaso = int.Parse(Console.ReadLine());
                switch (tipoVaso)
                {
                    case 1:
                        {
                            Console.WriteLine("");
                            //Console.WriteLine("Seleccionaste el Vaso Pequeno");
                            nameVaso = "Vaso Pequeno";
                            if (vasosPequenos > 0)
                            {
                                vasosPequenos -= 1;
                                GetCafe(tipoVaso, nameVaso);
                            }
                            else
                            {
                                Console.WriteLine("Ya no quedan mas vasos Pequenos, Por favor seleccione otra opcion!");
                                GetVaso();
                            }
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("");
                           // Console.WriteLine("Seleccionaste el Vaso Mediano");
                            nameVaso = "Vaso Mediano";
                            if (vasosMedianos > 0)
                            {
                                vasosMedianos -= 1;
                                GetCafe(tipoVaso, nameVaso);
                            }
                            else
                            {
                                Console.WriteLine("Ya no quedan mas vasos Medianos, Por favor seleccione otra opcion!");
                                GetVaso();
                            }
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("");
                           // Console.WriteLine("Seleccionaste el Vaso Grande");
                            nameVaso = "Vaso Grande";
                            if(vasosGrandes > 0)
                            {
                                vasosGrandes -= 1;
                                GetCafe(tipoVaso, nameVaso);
                            }
                            else
                            {
                                Console.WriteLine("Ya no quedan mas vasos grandes, Por favor seleccione otra opcion!");
                                GetVaso();
                            }
                           
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("----- ERRROR -------");
                            Console.WriteLine("Solo puede seleccionar un numero del 1 al 3, usted selecciono: "+ tipoVaso);
                            Console.WriteLine("--------------------------------------------------------------------------");
                            GetVaso();
                            break;
                        }

                }
            }
            catch
            {
                Console.WriteLine("----- ERRROR -------");
                Console.WriteLine("Error Solo Se Permiten numeros enteros");
                Console.WriteLine("---------------------------------------");
                GetVaso();
            }

        }

        static void GetCafe(int tipoVaso, string nameVaso)
        {
            if(cafe < 3)
            {
                Console.WriteLine("NO HAY CAFE!");

            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("Usted Selecciono el " + nameVaso);
                Console.WriteLine(" ----- Seleccione la Cantidad de Cafe Que Quiere en su vaso: ");
                Console.WriteLine("");
                if (tipoVaso >= 1)
                {
                    Console.WriteLine("1. 3 OZ");
                }
                if (tipoVaso >= 2)
                {
                    Console.WriteLine("2. 5 OZ");
                }
                if (tipoVaso >= 3)
                {
                    Console.WriteLine("3. 7 OZ");
                }
                int opcionCafe = 0;
                int cantidadCafe = 0;
                try
                {
                    opcionCafe = int.Parse(Console.ReadLine());
                    switch (opcionCafe)
                    {

                        case 1:
                            {
                                if (tipoVaso == 1 || tipoVaso == 2 || tipoVaso == 3)
                                {
                                    cantidadCafe = 3;
                                    if (cantidadCafe <= cafe)
                                    {
                                        cafe = cafe - cantidadCafe;
                                        GetAzucar(nameVaso, cantidadCafe);
                                    }
                                    else
                                    {
                                        Console.WriteLine("No hay suficiente Cafe, solo queda: " + cafe + " OZ");
                                        Console.WriteLine("Por Favor Seleccione otra opcion");
                                        GetCafe(tipoVaso, nameVaso);

                                    }

                                }
                                else
                                {
                                    Console.WriteLine("Por Favor Seleccione una de las opciones en pantalla");
                                    GetCafe(tipoVaso, nameVaso);
                                }



                                break;
                            }
                        case 2:
                            {
                                if (tipoVaso == 2 || tipoVaso == 3)
                                {
                                    cantidadCafe = 5;
                                    if (cantidadCafe <= cafe)
                                    {
                                        cafe = cafe - cantidadCafe;
                                        GetAzucar(nameVaso, cantidadCafe);
                                    }
                                    else
                                    {
                                        Console.WriteLine("No hay suficiente Cafe, solo queda: " + cafe + " OZ");
                                        Console.WriteLine("Por Favor Seleccione otra opcion");
                                        GetCafe(tipoVaso, nameVaso);

                                    }

                                }
                                else
                                {
                                    Console.WriteLine("Por Favor Seleccione una de las opciones en pantalla");
                                    GetCafe(tipoVaso, nameVaso);
                                }


                                break;
                            }
                        case 3:
                            {
                                if (tipoVaso == 3)
                                {
                                    cantidadCafe = 7;
                                    if (cantidadCafe <= cafe)
                                    {
                                        cafe = cafe - cantidadCafe;
                                        GetAzucar(nameVaso, cantidadCafe);
                                    }
                                    else
                                    {
                                        Console.WriteLine("No hay suficiente Cafe, solo queda: " + cafe + " OZ");
                                        Console.WriteLine("Por Favor Seleccione otra opcion");
                                        GetCafe(tipoVaso, nameVaso);

                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Por Favor Seleccione una de las opciones en pantalla");
                                    GetCafe(tipoVaso, nameVaso);
                                }



                                break;
                            }
                        default:
                            {
                                Console.WriteLine("----- ERRROR -------");
                                Console.WriteLine("Solo puede seleccionar un numero del 1 al 3, usted selecciono: " + opcionCafe);
                                Console.WriteLine("--------------------------------------------------------------------------");
                                GetCafe(tipoVaso, nameVaso);
                                break;
                            }

                    }
                }
                catch
                {
                    Console.WriteLine("----- ERRROR -------");
                    Console.WriteLine("Error Solo Se Permiten numeros enteros");
                    Console.WriteLine("---------------------------------------");
                    GetCafe(tipoVaso, nameVaso);
                }
            }


        }

        static void GetAzucar(string nameVaso, int cantidadCafe)
        {
            Console.WriteLine("");
            Console.WriteLine("----- Seleccione la cantidad de cucharadas de azucar que quiere en su cafe:");
            Console.WriteLine("0. Sin Azucar");
            Console.WriteLine("1. Una Cucharada");
            Console.WriteLine("2. Dos Cucharada");
            Console.WriteLine("3. Tres Cucharada");
            Console.WriteLine("4. Cuatro Cucharada");
            Console.WriteLine("5. Cinco Cucharada");
            int opcionAzucar = 0;
            try
            {
                opcionAzucar = int.Parse(Console.ReadLine());

                if(opcionAzucar >= 0 && opcionAzucar <= 5)
                {
                    if(opcionAzucar <= azucar)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("!!!--- SU CAFE ESTA COMPLETO ---!!!");
                        Console.WriteLine(" Usted selecciono un " + nameVaso);
                        Console.WriteLine("Con " + cantidadCafe + " OZ de CAFE");
                        Console.WriteLine("Y "+ opcionAzucar + "Cucharadas de Azucar");
                        Console.WriteLine("");
                        Cafetera();
                    }
                    else
                    {
                        Console.WriteLine("");
                        Console.WriteLine("No queda suficiente azucar, solo quedan " + azucar + "Cucharadas");
                        Console.WriteLine("");
                    }

                }
                else
                {
                    Console.WriteLine("Debe ser una opcion del 1 al 5, usted selecciono: " + opcionAzucar);
                    GetAzucar(nameVaso, cantidadCafe);
                }

            }
            catch
            {
                Console.WriteLine("----- ERRROR -------");
                Console.WriteLine("Error Solo Se Permiten numeros enteros");
                Console.WriteLine("---------------------------------------");
               GetAzucar(nameVaso, cantidadCafe);
            }

        }
    }
}
