using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OchoReinas
{
    public partial class Form1 : Form
    {
        public static Dictionary<string, Button> botones = new Dictionary<string, Button>(); // guarda mis botones
        public static List<Button> botonesConReina = new List<Button>(); // list de potones con reina
        public static List<string> posicionesReinas = new List<string>(); // list de posiciones de la Reina 
        public static List<List<string>> soluciones = new List<List<string>>(); // lista de lista de Soluciones
        public static char[] letras = "abcdefgh".ToCharArray(); // para usar abcdefgh en el array
        public static int n = 8; //tablero tamaño
        public int reinasColocadas = 0; 
        static int numSoluciones = 0;  
        public static Button[,] tableroR; //Array de botones
        public static Button boton; // creación de boton individual
        
        
        public Form1()
        {
            InitializeComponent();
            Soluciones.SelectedIndexChanged += Soluciones_SelectedIndexChanged;
        }

        private void InicializarTablero()
        {
            tableroR = new Button[n, n];
            int tamaño = 30;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    boton = new Button();
                    boton.Text = "0";
                    boton.Width = tamaño;
                    boton.Height = tamaño;
                    if ((i + j) % 2 == 0)
                    {
                        boton.BackColor = Color.White;
                    }
                    else
                    {
                        boton.BackColor = Color.Orange;
                    }
                    boton.Tag = new Tuple<int, int>(i, j);  // etiqueta para trabajabar con esos botones 
                    boton.Click += new EventHandler(handlerComun_Click); // handler para todos los botones 
                    //POSICIONES EN EL PANEL
                    int posX = j * (tamaño) + 10; 
                    int posY = i * (tamaño) + 10;

                    boton.Location = new System.Drawing.Point(posX, posY); // pa dibujar

                    tableroR[i, j] = boton;
                    botones.Add($"{i + 1}-{j + 1}", boton);  
                    pnlTablero.Controls.Add(boton);  // se añaden con su posición en el segundo panel
                }
            }
        }
        private void handlerComun_Click(object sender, EventArgs e)
        {
            Button botonClicado = sender as Button;

            if (botonClicado != null)
            {
                // Verificar si ya se colocaron 8 reinas
                if (reinasColocadas < 8)
                {
                    // Verificar si el botón ya tiene una reina
                    if (!botonesConReina.Contains(botonClicado))
                    {
                        // Compruebo si la nueva reina se ataca con alguna reina ya colocada
                        if (!SeAtacanReinas(botonClicado))
                        {
                            // Poner el emoji de reina solo en el botón clicado
                            botonClicado.Text = "♛";
                            reinasColocadas++;
                            botonesConReina.Add(botonClicado);
                            if (reinasColocadas == 8) MessageBox.Show("Ya has colocado las 8 reinas ", "🍻🍾FELICIDADES🎉🎉", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        else MessageBox.Show("La reina se ataca con otra reina ya colocada.♛", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else MessageBox.Show("Ya has colocado una reina en este botón.♛", "ALERTA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private bool SeAtacanReinas(Button nuevaReina)
        {
            int filaNuevaReina = ((Tuple<int, int>)nuevaReina.Tag).Item1;
            int columnaNuevaReina = ((Tuple<int, int>)nuevaReina.Tag).Item2;

            foreach (Button reinaColocada in botonesConReina)
            {
                int filaReinaColocada = ((Tuple<int, int>)reinaColocada.Tag).Item1;
                int columnaReinaColocada = ((Tuple<int, int>)reinaColocada.Tag).Item2;

                // Verificar si están en la misma fila, columna o diagonal
                if (filaNuevaReina == filaReinaColocada ||
                    columnaNuevaReina == columnaReinaColocada ||
                    Math.Abs(filaNuevaReina - filaReinaColocada) == Math.Abs(columnaNuevaReina - columnaReinaColocada))
                {
                    return true; // Las reinas se atacan entre sí
                }
            }
            return false; // Las reinas no se atacan entre sí
        }
        public void Refrescar()
        {
            botones.Clear();
            botonesConReina.Clear();
            pnlTablero.Controls.Clear();
            GC.Collect();
            reinasColocadas = 0;

        }
        private void btnResolver_Click(object sender, EventArgs e)
        {
            Soluciones.Hide();
            Refrescar();
            reinasColocadas = 0;
            InicializarTablero();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (tableroR[i, j].Text == "0")
                    tableroR[i, j].Text = "";
                }
            }
        }
        private void btnResolver_Click()
        {
            Refrescar();
            InicializarTablero();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (tableroR[i, j].Text == "0")
                        tableroR[i, j].Text = "";

                }
            }
        }
        private void btnSolucion_Click(object sender, EventArgs e)
        {
            Soluciones.Hide();
            int cont = 0;
            Refrescar(); 
            reinasColocadas = 0;
            InicializarTablero();
            resolverOchoReinas();

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (tableroR[i,j].Text == "0")
                    {
                        tableroR[i, j].Text = "";
                    }
                    else if (tableroR[i,j].Text == "♛")
                    {
                        cont++;
                    }
                    else
                    {
                        tableroR[i, j].Text = "♛"; 
                    }
                }
            }
            if(cont == reinasColocadas)
            {
                MessageBox.Show("Una posible solución para que entiendas el juego, encuentra las otras 91!!♛", "ATENCIÓN",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnResolver_Click();
            }
        }
        private void pnlTablero_Paint(object sender, PaintEventArgs e)
        {
            //llama este metodo para que se coloquen los botones en el panel, por eso el PaintEventArgs
        }
        static void resolverOchoReinas()
        {
            if (!resolverOchoReinasUtil(tableroR, 0))
            {
                Console.WriteLine("No hay solución.");
                return;
            }
        }
        // Utilidad para verificar si es seguro colocar una reina en la posición (fila, col)

        static bool esSeguro(Button[,] tableroR, int fila, int col)
        {
            int i, j;
            // Verificar esta fila a la izquierda
            for (i = 0; i < col; i++)
            {
                if (tableroR[fila,i].Text == "1")
                {
                    return false;
                }
            }
            // Verificar la diagonal superior izquierda
            for (i = fila, j = col; i >= 0 && j >= 0; i--, j--)
            {
                if (tableroR[i,j].Text == "1")
                {
                    return false;
                }
            }
            // Verificar la diagonal inferior izquierda
            for (i = fila, j = col; j >= 0 && i < n; i++, j--)
            {
                if (tableroR[i,j].Text == "1")
                {
                    return false;
                }
            }
            return true;
        }
        // Función de utilidad recursiva para resolver el problema de las 8 reinas

        static bool resolverOchoReinasUtil(Button[,] tablero, int col)
        {
            if (col == n)
            {
                // Todas las reinas están colocadas, la solución está encontrada
                return true;
            }
            for (int i = 0; i < n; i++)
            {
                if (esSeguro(tablero, i, col))
                {
                    tablero[i,col].Text = $"{1}";
                    if (resolverOchoReinasUtil(tablero, col + 1))
                    {
                        return true;
                    }
                    tablero[i,col].Text = $"{0}"; // Si colocar la reina en la posición actual
                                                  //no lleva a una solución, retrocedemos.
                }
            }
            return false; // Si no se puede colocar la reina en ninguna fila en esta columna,
                          //regresamos false
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Refrescar();
            reinasColocadas = 0;
            btnRespuesta.Enabled = true;
            Soluciones.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pnlBase.Hide();
            gbOpciones.Hide();
            Soluciones.Hide();
            btnRespuesta.Hide();
            txtRespuesta.Hide();
        }

        private void btnEmpezar_Click(object sender, EventArgs e)
        {
            pnlBase.Show();
            gbOpciones.Show();
            btnRespuesta.Show();
            txtRespuesta.Show();
        }
        //--------------------------------------------------------------------------------------------------------------------------------------------------------------

        private void btnRespuesta_Click(object sender, EventArgs e)
        {
            Refrescar();
            txtRespuesta.Text.ToLower();
            if (txtRespuesta.Text == "platano")
            {
                Soluciones.Show();
                InicializarTablero();
                resolverOchoReinasSoluciones();
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (tableroR[i, j].Text == "0")
                        {
                            tableroR[i, j].Text = "";
                        }
                        else
                        {
                            tableroR[i, j].Text = "♛";
                        }
                    }
                }
                // Mostrar las soluciones en el ListBox
                foreach (var solucion in soluciones)
                {
                    Soluciones.Items.Add(string.Join(",", solucion));
                }
                btnRespuesta.Enabled = false;
            }
            else MessageBox.Show("Prueba otra vez", "INCORRECTO", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        static public void resolverOchoReinasSoluciones()
        {
            int[,] tablero = new int[n, n];
            encontrarSoluciones(tablero, 0);
        }
        static public void encontrarSoluciones(int[,] tablero, int col)
        {
            if (col == n)
            {
                numSoluciones++;
                Console.WriteLine($"Solución #{numSoluciones}:");
                List<string> solucionActual = new List<string>();

                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        if (tablero[i, j] == 1)
                        {
                            string posicion = $"{letras[j]}{i + 1}";
                            Console.Write($"{posicion} ");
                            solucionActual.Add(posicion);
                        }
                        else
                        {
                            Console.Write("0 ");
                        }
                    }
                    Console.WriteLine();
                }
                // Agregar la solución actual a la lista de soluciones
                soluciones.Add(solucionActual);

                Console.WriteLine();
                return;
            }

            for (int i = 0; i < n; i++)
            {
                if (esSeguroSoluciones(tablero, i, col))
                {
                    tablero[i, col] = 1;
                    encontrarSoluciones(tablero, col + 1);
                    tablero[i, col] = 0; // Retroceder
                }
            }
        }


        static public bool esSeguroSoluciones(int[,] tablero, int fila, int col)
        {
            int i, j;

            // Verificar esta fila a la izquierda
            for (i = 0; i < col; i++)
                if (tablero[fila, i] == 1)
                    return false;

            // Verificar la diagonal superior izquierda
            for (i = fila, j = col; i >= 0 && j >= 0; i--, j--)
                if (tablero[i, j] == 1)
                    return false;

            // Verificar la diagonal inferior izquierda
            for (i = fila, j = col; j >= 0 && i < n; i++, j--)
                if (tablero[i, j] == 1)
                    return false;

            return true;
        }

        public static void imprimirPosiciones(int[,] tablero)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (tablero[i, j] == 1)
                    {
                        posicionesReinas.Add($"{letras[j]}{i + 1}");  // agregar respuesta
                        Console.Write($"{letras[j]}{i + 1} ");  // compruebo en consola
                    }
                    else
                    {
                        Console.Write("0 ");
                    }
                }
                Console.WriteLine();
            }
            // Imprimir las posiciones de las reinas en orden
            Console.WriteLine("Posiciones de las reinas en orden:");
            Console.WriteLine(string.Join(",", posicionesReinas)); // 1 sola respuesta y despues se limpia
            posicionesReinas.Clear(); // para que no se me acumule de respuestas, solo la que obtengo 
        }
        private void Soluciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Obtener el índice de la solución seleccionada
            int indiceSeleccionado = Soluciones.SelectedIndex;

            // Verificar si se seleccionó una solución
            if (indiceSeleccionado >= 0 && indiceSeleccionado < soluciones.Count)
            {
                // Obtener la solución seleccionada
                List<string> solucionSeleccionada = soluciones[indiceSeleccionado];

                // Graficar la solución
                GraficarSolucion(solucionSeleccionada);
            }
        }
        private void GraficarSolucion(List<string> solucion)
        {
            Refrescar();
            InicializarTablero();
            foreach (string posicion in solucion) // Colocar las reinas en el tablero según la solución
            {
                int columna = Array.IndexOf(letras, posicion[0]);
                int fila = int.Parse(posicion[1].ToString()) - 1;
                tableroR[fila, columna].Text = "♛";  // Colocar la reina en el tablero
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (tableroR[i, j].Text == "0")
                    {
                        tableroR[i, j].Text = "";   //volver los espacios con 0 en blancos
                    }
                    else
                    {
                        tableroR[i, j].Text = "♛";  //colocar reina
                    }
                }
            }
        }
    }
}
