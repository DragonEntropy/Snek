using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace Snek
{
    public partial class mainForm : Form
    {
        static Graphics g;

        public static Random rand = new Random();
        public static int pixelMultiplier = 16;
        public static (int, int) startPos = (0, 0);
        public static bool isVariantMode;
        public static int defaultSpeed = 100;

        public Player player;

        public mainForm()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void start_Click(object sender, EventArgs e)
        {
            player = new Player();
            int speed = speedBar.Value; //Taking pre-game user inputs from the form
            int complexity = complexityBar.Value;
            bool isVariantMode = variantMode.Checked;

            complexityBar.Enabled = false;
            speedBar.Enabled = false;
            variantMode.Enabled = false;
            start.Enabled = false;

            int panelHeight = mainPanel.Height; //Generating grid size
            int panelWidth = mainPanel.Width;
            int gridHeight = panelHeight / pixelMultiplier;
            int gridWidth = panelWidth / pixelMultiplier;

            bool alive = true;
            bool[,] binaryField = new bool[gridWidth, gridHeight];
            Pellet[] pelletList = new Pellet[complexity];

            g = mainPanel.CreateGraphics();
            mainPanel.Refresh();
            mainPanel.BackColor = Color.Black;

            await Task.Delay(100);
            UpdateSquare(startPos.Item1, startPos.Item2, Color.Green, binaryField, true);
            for (int p = 0; p < complexity; p++)
            {
                pelletList[p] = new Pellet(gridWidth, gridHeight, binaryField, isVariantMode);
            }

            while (alive == true)
            {
                await Task.Delay((int)(defaultSpeed /(speed * player.speedMultiplier)));
                alive = player.Update(binaryField, gridHeight, gridWidth, pelletList, complexity, isVariantMode);
            }
            Console.WriteLine("dead :(");

            complexityBar.Enabled = true;
            speedBar.Enabled = true;
            variantMode.Enabled = true;
            start.Enabled = true;
        }

        public static void UpdateSquare(int xGrid, int yGrid, Color colour, bool[,] binaryField, bool value)
        {
            (int, int) cellPos = (xGrid * pixelMultiplier + 1, yGrid * pixelMultiplier + 1);
            g.FillRectangle(new SolidBrush(colour), cellPos.Item1, cellPos.Item2, pixelMultiplier - 2, pixelMultiplier - 2);
            binaryField[xGrid, yGrid] = value;
        }

        private void mainForm_KeyDown_1(object sender, KeyEventArgs e)
        {
            if ((e.KeyValue == (char)Keys.W) || (e.KeyValue == (char)Keys.Up))
            {
                Console.WriteLine("Up!");
                player.newDirection = (0, -1);
            }
            else if ((e.KeyValue == (char)Keys.S) || (e.KeyValue == (char)Keys.Down))
            {
                Console.WriteLine("Down!");
                player.newDirection = (0, 1);
            }
            else if ((e.KeyValue == (char)Keys.D) || (e.KeyValue == (char)Keys.Right))
            {
                Console.WriteLine("Right!");
                player.newDirection = (1, 0);
            }
            else if ((e.KeyValue == (char)Keys.A) || (e.KeyValue == (char)Keys.Left))
            {
                Console.WriteLine("Left!");
                player.newDirection = (-1, 0);
            }
        }
    }

    public class Player
    {
        public int xPos = mainForm.startPos.Item1;
        public int yPos = mainForm.startPos.Item2;
        //Not used: int score = 0;
        int snakeLength = 5;
        int step = 0;

        public float speedMultiplier = 1;
        int inversion = 1;
        int trailDecay = 1;
        int stagger = 1;
        public int cooldown = 0;

        (int, int) direction = (1, 0);
        public (int, int) newDirection = (1, 0);

        List<Trail> trailList = new List<Trail> {};

        public Player()
        {
            //Places the initial trail tile
            trailList.Add(new Trail(xPos, yPos));
        }

        public void Move(int gridHeight, int gridWidth)
        {
            //Handles the movement of the player
            xPos = (xPos + direction.Item1 + gridWidth) % gridWidth;
            yPos = (yPos + direction.Item2 + gridHeight) % gridHeight;
            Console.WriteLine(String.Format("The coordinates are ({0}, {1})", xPos, yPos));
        }

        public void Turn(int inversion)
        {
            //Handles the possible turns the player can make
            if ((direction.Item1 == newDirection.Item2) || (direction.Item2 == newDirection.Item1))
            {
                direction.Item1 = inversion * newDirection.Item1;
                direction.Item2 = inversion * newDirection.Item2;
            }
        }

        public void UpdateTrail(bool[,] binaryField)
        {
            //Decreases the lifetime on each trail
            foreach (Trail trail in trailList.ToList())
            {
                bool isDead = trail.update(snakeLength, trailDecay);
                if (isDead)
                {
                    trailList.Remove(trail);
                    mainForm.UpdateSquare(trail.xPos, trail.yPos, Color.Black, binaryField, false);
                }
            }
        }

        public bool Update(bool[,] binaryField, int gridHeight, int gridWidth, Pellet[] pelletList, int complexity, bool isVariantMode)
        {
            //The player turns, moves and then the trail is made
            Turn(inversion);
            Move(gridHeight, gridWidth);
            step++;

            //Checks for collisions
            bool alive = true;
            if (binaryField[xPos, yPos])
            {
                alive = ManageCollision(binaryField, pelletList, complexity, gridWidth, gridHeight, isVariantMode);
            }

            UpdateTrail(binaryField);

            //Manages cooldowns
            if (cooldown > 0)
            {
                cooldown--;
                if (cooldown == 0)
                {
                    speedMultiplier = 1;
                    inversion = 1;
                    trailDecay = 1;
                    stagger = 1;
                }
            }

            //Adds a new trail tile
            if(step % stagger == 0)
            {
                trailList.Add(new Trail(xPos, yPos));
                mainForm.UpdateSquare(xPos, yPos, Color.Green, binaryField, true);
            }

            return alive;
        }

        public bool ManageCollision(bool[,] binaryField, Pellet[] pelletList, int complexity, int gridWidth, int gridHeight, bool isVariantMode)
        {
            for (int p = 0; p < complexity; p++)
            {
                (int, int) pelletPos = pelletList[p].getPos();
                if (pelletPos.Item1 == xPos && pelletPos.Item2 == yPos)
                {
                    //Applies variants
                    switch (pelletList[p].variant)
                    {
                        case 1:
                            speedMultiplier = 2;
                            cooldown = 400;
                            break;
                        case 2:
                            speedMultiplier = 0.5f;
                            cooldown = 100;
                            break;
                        case 3:
                            inversion = -1;
                            cooldown = 100;
                            break;
                        case 4:
                            trailDecay = 0;
                            cooldown = 50;
                            break;
                        case 5:
                            stagger = 2;
                            cooldown = 100;
                            break;
                    }

                    //Cleans pellet from binaryField
                    mainForm.UpdateSquare(pelletPos.Item1, pelletPos.Item2, Color.Black, binaryField, false);

                    //Creates a new pellet
                    pelletList[p] = new Pellet(gridWidth, gridHeight, binaryField, isVariantMode);
                    snakeLength++;

                    return true;
                }
            }
            return false;
        }
    }

    public class Pellet
    {
        int xPos;
        int yPos;
        public int variant = 0;

        public Pellet(int gridWidth, int gridHeight, bool[,] binaryField, bool isVariantMode)
        {
            bool legalPosition = false;

            //Iterates through until a pellet can be placed in a legal position
            while (legalPosition == false)
            {
                xPos = mainForm.rand.Next(gridWidth);
                yPos = mainForm.rand.Next(gridHeight);
                if (binaryField[xPos, yPos] == false)
                {
                    binaryField[xPos, yPos] = true;
                    legalPosition = true;
                }
            }

            //Possibly assigns a variant under variant mode and its colour
            Color colour = Color.Red;
            if (isVariantMode)
            {
                variant = mainForm.rand.Next(20);
                switch (variant)
                {
                    case 1:
                        colour = Color.Yellow;
                        break;
                    case 2:
                        colour = Color.DeepSkyBlue;
                        break;
                    case 3:
                        colour = Color.DeepPink;
                        break;
                    case 4:
                        colour = Color.Lime;
                        break;
                    case 5:
                        colour = Color.MediumPurple;
                        break;
                }
            }

            //Places the pellet in the grid
            mainForm.UpdateSquare(xPos, yPos, colour, binaryField, true);
            Console.WriteLine("Pellet at " + xPos + ", " + yPos + " with variant " + variant);
        }

        public (int, int) getPos()
        {
            (int, int) pos = (xPos, yPos);
            return pos;
        }
    }

    public class Trail
    {
        public int xPos;
        public int yPos;
        int lifetime;

        public Trail(int x, int y)
        {
            xPos = x;
            yPos = y;
            lifetime = 0;
        }

        public bool update(int snakeLength, int trailDecay)
        {
            lifetime += trailDecay;
            if (lifetime == snakeLength)
            {
                return true;
            }
            return false;
        }
    }
}
