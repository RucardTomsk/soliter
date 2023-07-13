using Soliter.Deck;
using Soliter.Deck.Aces.Cards;
using Soliter.Deck.Dozens.Cards;
using Soliter.Deck.Eights.Cards;
using Soliter.Deck.Fives.Cards;
using Soliter.Deck.Fours.Cards;
using Soliter.Deck.Kings.Cards;
using Soliter.Deck.Ladies.Cards;
using Soliter.Deck.Nines.Cards;
using Soliter.Deck.Sevens.Cards;
using Soliter.Deck.Sixes.Cards;
using Soliter.Deck.Threes.Cards;
using Soliter.Deck.Twos.Cards;
using Soliter.Deck.Waltzes.Cards;
using System.Reflection;

namespace Soliter
{
    
    // класс всей игровой формы
    public partial class Game : Form
    {
        
        const int wCard = 120;
        const int hCard = 180;
        const int pass = 10;
        string userName;
        // инициализация объекта Game
        public Game(string userName)
        {
            //[DllImport("kernel32.dll", SetLastError = true)]
            //[return: MarshalAs(UnmanagedType.Bool)]
            //static extern bool AllocConsole();

            InitializeComponent();
            typeof(Panel).InvokeMember("DoubleBuffered",
        BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic,
        null, panel, new object[] { true });


            //AllocConsole();
            this.userName = userName;
        }

        Aces_Hearts a_h = new Aces_Hearts();
        Aces_Peaks a_p = new Aces_Peaks();
        Ace_Cross a_c = new Ace_Cross();
        Ace_Diamonds a_d = new Ace_Diamonds();
        Dozens_Cross d_c = new Dozens_Cross();
        Dozens_Diamonds d_d = new Dozens_Diamonds();
        Dozens_Hearts d_h = new Dozens_Hearts();
        Dozens_Peaks d_p = new Dozens_Peaks();
        Eights_Cross e_c = new Eights_Cross();
        Eights_Diamonds e_d = new Eights_Diamonds();
        Eights_Hearts e_h = new Eights_Hearts();
        Eights_Peaks e_p = new Eights_Peaks();
        Fives_Cross f_c = new Fives_Cross();
        Fives_Diamonds f_d = new Fives_Diamonds();
        Fives_Hearts f_h = new Fives_Hearts();
        Fives_Peaks f_p = new Fives_Peaks();
        Fours_Hearts fo_h = new Fours_Hearts();
        Fours_Peaks fo_p = new Fours_Peaks();
        Fours_Diamonds fo_d = new Fours_Diamonds();
        Fours_Cross fo_c = new Fours_Cross();
        Kings_Hearts k_h = new Kings_Hearts();
        Kings_Diamonds k_d = new Kings_Diamonds();
        Kings_Cross k_c = new Kings_Cross();
        Kings_Peaks k_p = new Kings_Peaks();
        Ladies_Cross l_c = new Ladies_Cross();
        Ladies_Diamonds l_d = new Ladies_Diamonds();
        Ladies_Hearts l_h = new Ladies_Hearts();
        Ladies_Peaks l_p = new Ladies_Peaks();
        Nines_Cross n_c = new Nines_Cross();
        Nines_Diamonds n_d = new Nines_Diamonds();
        Nines_Hearts n_h = new Nines_Hearts();
        Nines_Peaks n_p = new Nines_Peaks();
        Sevens_Cross s_c = new Sevens_Cross();
        Sevens_Diamonds s_d = new Sevens_Diamonds();
        Sevens_Hearts s_h = new Sevens_Hearts();
        Sevens_Peaks s_p = new Sevens_Peaks();
        Sixes_Cross si_c = new Sixes_Cross();
        Sixes_Diamonds si_d = new Sixes_Diamonds();
        Sixes_Hearts si_h = new Sixes_Hearts();
        Sixes_Peaks si_p = new Sixes_Peaks();
        Threes_Cross t_c = new Threes_Cross();
        Threes_Diamonds t_d = new Threes_Diamonds();
        Threes_Hearts t_h = new Threes_Hearts();
        Threes_Peaks t_p = new Threes_Peaks();
        Twos_Cross tw_c = new Twos_Cross();
        Twos_Diamonds tw_d = new Twos_Diamonds();
        Twos_Hearts tw_h = new Twos_Hearts();
        Twos_Peaks tw_p = new Twos_Peaks();
        Waltzes_Cross w_c = new Waltzes_Cross();
        Waltzes_Diamonds w_d = new Waltzes_Diamonds();
        Waltzes_Hearts w_h = new Waltzes_Hearts();
        Waltzes_Peaks w_p = new Waltzes_Peaks();


        List<Card> addStack = new List<Card>();
        List<Card> twoStack = new List<Card>();

        List<Card> stack1 = new List<Card>();
        List<Card> stack2 = new List<Card>();
        List<Card> stack3 = new List<Card>();
        List<Card> stack4 = new List<Card>();
        List<Card> stack5 = new List<Card>();
        List<Card> stack6 = new List<Card>();
        List<Card> stack7 = new List<Card>();

        List<Card> t_stack1 = new List<Card>();
        List<Card> t_stack2 = new List<Card>();
        List<Card> t_stack3 = new List<Card>();
        List<Card> t_stack4 = new List<Card>();

        List<Card> move_stack = new List<Card>();
        List<Card> save_stack;

        bool moveFlag = false;
        bool firstStart = true;
        DateTime date = new DateTime(0, 0);
        Random rnd = new Random();

        // класс для перезагрузки и начала игры.( очищаем списки, создаем колоду, 
        // добовляем карты в список, создание списка по мастям, перемешиваем рандомно колоду,
        //
        private void Game_Load(object sender, EventArgs e)
        {
         
            
                firstStart = true;
                addStack.Clear();
                twoStack.Clear();
                stack1.Clear();
                stack2.Clear();
                stack3.Clear();
                stack4.Clear();
                stack5.Clear();
                stack6.Clear();
                stack7.Clear();
                t_stack1.Clear();
                t_stack2.Clear();
                t_stack3.Clear();
                t_stack4.Clear();
                List<Card> cards = new List<Card>(52);
                cards.Add(a_h);
                cards.Add(a_p);
                cards.Add(a_c);
                cards.Add(a_d);
                cards.Add(d_c);
                cards.Add(d_d);
                cards.Add(d_h);
                cards.Add(d_p);
                cards.Add(e_c);
                cards.Add(e_d);
                cards.Add(e_h);
                cards.Add(e_p);
                cards.Add(f_c);
                cards.Add(f_d);
                cards.Add(f_h);
                cards.Add(f_p);
                cards.Add(fo_h);
                cards.Add(fo_p);
                cards.Add(fo_d);
                cards.Add(fo_c);
                cards.Add(k_h);
                cards.Add(k_d);
                cards.Add(k_c);
                cards.Add(k_p);
                cards.Add(l_c);
                cards.Add(l_d);
                cards.Add(l_h);
                cards.Add(l_p);
                cards.Add(n_c);
                cards.Add(n_d);
                cards.Add(n_h);
                cards.Add(n_p);
                cards.Add(s_c);
                cards.Add(s_d);
                cards.Add(s_h);
                cards.Add(s_p);
                cards.Add(si_c);
                cards.Add(si_d);
                cards.Add(si_h);
                cards.Add(si_p);
                cards.Add(t_c);
                cards.Add(t_d);
                cards.Add(t_h);
                cards.Add(t_p);
                cards.Add(tw_c);
                cards.Add(tw_d);
                cards.Add(tw_h);
                cards.Add(tw_p);
                cards.Add(w_c);
                cards.Add(w_d);
                cards.Add(w_h);
                cards.Add(w_p);

                List<Card> crossDeck = new List<Card>();
                List<Card> diamondsDeck = new List<Card>();
                List<Card> heartsDeck = new List<Card>();
                List<Card> peaksDeck = new List<Card>();
            for (int i = cards.Count - 1; i >= 1; i--)
            {
                int j = rnd.Next(i + 1);
                (cards[j], cards[i]) = (cards[i], cards[j]);
            }
            //пробегаемся по колоде
            foreach (Card card in cards)
            {
                switch (card.Suit){
                    case Suit.Diamonds:
                        diamondsDeck.Add(card);
                        break;

                    case Suit.Peaks:
                        peaksDeck.Add(card);
                        break;
                    case Suit.Hearts:
                        heartsDeck.Add(card);
                        break;

                    case Suit.Cross:
                        crossDeck.Add(card);
                        break;
                }
            }
            //разбиваем колоду на две части, чтобы в обоих находилась любая комбинация красных карт
            // от двойки до туза и любая комбинация от двойки до туза 
            //( для того чтобы косынка собиралась)
            List<Card> t1 = new List<Card>();
            List<Card> t2 = new List<Card>();
            switch (rnd.Next(4))
            {
                case 0:
                    foreach (Card card in diamondsDeck) {
                        t1.Add(card);
                    }
                    foreach (Card card in peaksDeck)
                    {
                        t1.Add(card);
                    }
                    foreach (Card card in heartsDeck)
                    {
                        t2.Add(card);
                    }
                    foreach (Card card in crossDeck)
                    {
                        t2.Add(card);
                    }
                    break;
                case 1:
                    foreach (Card card in diamondsDeck)
                    {
                        t2.Add(card);
                    }
                    foreach (Card card in peaksDeck)
                    {
                        t2.Add(card);
                    }
                    foreach (Card card in heartsDeck)
                    {
                        t1.Add(card);
                    }
                    foreach (Card card in crossDeck)
                    {
                        t1.Add(card);
                    }
                    break; 
                case 2:
                    foreach (Card card in diamondsDeck)
                    {
                        t1.Add(card);
                    }
                    foreach (Card card in peaksDeck)
                    {
                        t2.Add(card);
                    }
                    foreach (Card card in heartsDeck)
                    {
                        t2.Add(card);
                    }
                    foreach (Card card in crossDeck)
                    {
                        t1.Add(card);
                    }
                    break;
                case 3:
                    foreach (Card card in diamondsDeck)
                    {
                        t2.Add(card);
                    }
                    foreach (Card card in peaksDeck)
                    {
                        t1.Add(card);
                    }
                    foreach (Card card in heartsDeck)
                    {
                        t1.Add(card);
                    }
                    foreach (Card card in crossDeck)
                    {
                        t2.Add(card);
                    }
                    break;
            }

            for (int i = t1.Count - 1; i >= 1; i--)
            {
                int j = rnd.Next(i + 1);
                (t1[j], t1[i]) = (t1[i], t1[j]);
            }

            for (int i = t2.Count - 1; i >= 1; i--)
            {
                int j = rnd.Next(i + 1);
                (t2[j], t2[i]) = (t2[i], t2[j]);
            }

            List<Card> megList = new List<Card>();
            foreach (Card card in t1) { 
                megList.Add(card);
            }

            for(int i = 0; i < 5; i++)
            {
                megList.Add(t2[i]);
            }

            t2.RemoveRange(0, 5);

            for (int i = megList.Count - 1; i >= 1; i--)
            {
                int j = rnd.Next(i + 1);
                (megList[j], megList[i]) = (megList[i], megList[j]);
            }

            for (int i = 0; i < 24; i++)
            {
                megList[i].Closed = true;
                addStack.Add(megList[i]);
            }

            stack1.Add(megList[24]);
            stack2.Add(megList[25]);
            stack3.Add(megList[26]);
            stack4.Add(megList[27]);
            stack5.Add(megList[28]);
            stack6.Add(megList[29]);
            stack7.Add(megList[30]);

            t2[0].Closed = true;
            stack2.Add(t2[0]);
            stack2.Add(stack2[0]);
            stack2.RemoveAt(0);
            for(int i = 1; i <= 2; i++)
            {
                t2[i].Closed = true;
                stack3.Add(t2[i]);
            }
            stack3.Add(stack3[0]);
            stack3.RemoveAt(0);
            for (int i = 3; i <= 5; i++)
            {
                t2[i].Closed = true;
                stack4.Add(t2[i]);
            }
            stack4.Add(stack4[0]);
            stack4.RemoveAt(0);
            for (int i = 6; i <= 9; i++)
            {
                t2[i].Closed = true;
                stack5.Add(t2[i]);
            }
            stack5.Add(stack5[0]);
            stack5.RemoveAt(0);
            for (int i = 10; i <= 14; i++)
            {
                t2[i].Closed = true;
                stack6.Add(t2[i]);
            }
            stack6.Add(stack6[0]);
            stack6.RemoveAt(0);
            for (int i = 15; i <= 20; i++)
            {
                t2[i].Closed = true;
                stack7.Add(t2[i]);
            }
            stack7.Add(stack7[0]);
            stack7.RemoveAt(0);

        }

        private void Game_Paint(object sender, PaintEventArgs e)
        {

        }
        //рендоринг 
        private void panel_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.Black, 2);
            pen.DashPattern = new float[] { 2, 2 };

            //отрисовка верхнего части
            for (int i = 0; i <= 6; i++)
            {
                if (i != 2)
                {
                    e.Graphics.DrawRectangle(pen, (wCard + pass) * i, 0, wCard, hCard);
                }
            }
            // нижнего ряда
            for (int i = 0; i <= 6; i++)
            {
                e.Graphics.DrawRectangle(pen, (wCard + pass) * i, pass + hCard, wCard, hCard);
            }

            int megPass = 40;
            int startPositionY = pass + hCard;
            foreach (var card in stack1)
            {
                Bitmap image;

                if (!card.Closed)
                    image = card.Image;
                else
                    image = CardResource.closed;
                e.Graphics.DrawImage(image, 0, startPositionY);
                startPositionY = startPositionY + megPass;
            }

            startPositionY = pass + hCard;
            foreach (var card in stack2)
            {
                Bitmap image;

                if (!card.Closed)
                    image = card.Image;
                else
                    image = CardResource.closed;
                e.Graphics.DrawImage(image, (wCard + pass), startPositionY);
                startPositionY = startPositionY + megPass;
            }

            startPositionY = pass + hCard;
            foreach (var card in stack3)
            {
                Bitmap image;

                if (!card.Closed)
                    image = card.Image;
                else
                    image = CardResource.closed;
                e.Graphics.DrawImage(image, (wCard + pass) * 2, startPositionY);
                startPositionY = startPositionY + megPass;
            }

            startPositionY = pass + hCard;
            foreach (var card in stack4)
            {
                Bitmap image;

                if (!card.Closed)
                    image = card.Image;
                else
                    image = CardResource.closed;
                e.Graphics.DrawImage(image, (wCard + pass) * 3, startPositionY);
                startPositionY = startPositionY + megPass;
            }

            startPositionY = pass + hCard;
            foreach (var card in stack5)
            {
                Bitmap image;

                if (!card.Closed)
                    image = card.Image;
                else
                    image = CardResource.closed;
                e.Graphics.DrawImage(image, (wCard + pass) * 4, startPositionY);
                startPositionY = startPositionY + megPass;
            }

            startPositionY = pass + hCard;
            foreach (var card in stack6)
            {
                Bitmap image;

                if (!card.Closed)
                    image = card.Image;
                else
                    image = CardResource.closed;
                e.Graphics.DrawImage(image, (wCard + pass) * 5, startPositionY);
                startPositionY = startPositionY + megPass;
            }

            startPositionY = pass + hCard;
            foreach (var card in stack7)
            {
                Bitmap image;

                if (!card.Closed)
                    image = card.Image;
                else
                    image = CardResource.closed;
                e.Graphics.DrawImage(image, (wCard + pass) * 6, startPositionY);
                startPositionY = startPositionY + megPass;
            }

            foreach (var card in addStack)
            {
                Bitmap image;

                if (!card.Closed)
                    image = card.Image;
                else
                    image = CardResource.closed;
                e.Graphics.DrawImage(image, 0, 0);

            }

            foreach (var card in twoStack)
            {
                Bitmap image;

                if (!card.Closed)
                    image = card.Image;
                else
                    image = CardResource.closed;
                e.Graphics.DrawImage(image, pass + wCard, 0);
            }

            foreach (var card in t_stack1)
            {
                Bitmap image;

                if (!card.Closed)
                    image = card.Image;
                else
                    image = CardResource.closed;
                e.Graphics.DrawImage(image, (wCard + pass) * 3, 0);
            }

            foreach (var card in t_stack2)
            {
                Bitmap image;

                if (!card.Closed)
                    image = card.Image;
                else
                    image = CardResource.closed;
                e.Graphics.DrawImage(image, (wCard + pass) * 4, 0);
            }

            foreach (var card in t_stack3)
            {
                Bitmap image;

                if (!card.Closed)
                    image = card.Image;
                else
                    image = CardResource.closed;
                e.Graphics.DrawImage(image, (wCard + pass) * 5, 0);
            }

            foreach (var card in t_stack4)
            {
                Bitmap image;

                if (!card.Closed)
                    image = card.Image;
                else
                    image = CardResource.closed;
                e.Graphics.DrawImage(image, (wCard + pass) * 6, 0);
            }

            if (moveFlag)
            {
                startPositionY = Game.MousePosition.Y - (hCard / 2);
                foreach (var card in move_stack)
                {
                    e.Graphics.DrawImage(card.Image, Game.MousePosition.X - (wCard / 2), startPositionY);
                    startPositionY = startPositionY + megPass;
                }
            }

            //e.Graphics.DrawImage(a_d.Image, a, 300);

        }
        private void reset_timer_Tick(object sender, EventArgs e)
        {
            if (!moveFlag)
            {
                if (stack1.Count != 0)
                    if (stack1[stack1.Count - 1].Closed)
                        stack1[stack1.Count - 1].Closed = false;

                if (stack2.Count != 0)
                    if (stack2[stack2.Count - 1].Closed)
                        stack2[stack2.Count - 1].Closed = false;

                if (stack3.Count != 0)
                    if (stack3[stack3.Count - 1].Closed)
                        stack3[stack3.Count - 1].Closed = false;

                if (stack4.Count != 0)
                    if (stack4[stack4.Count - 1].Closed)
                        stack4[stack4.Count - 1].Closed = false;

                if (stack5.Count != 0)
                    if (stack5[stack5.Count - 1].Closed)
                        stack5[stack5.Count - 1].Closed = false;

                if (stack6.Count != 0)
                    if (stack6[stack6.Count - 1].Closed)
                        stack6[stack6.Count - 1].Closed = false;

                if (stack7.Count != 0)
                    if (stack7[stack7.Count - 1].Closed)
                        stack7[stack7.Count - 1].Closed = false;
                // проверка победы
                if (t_stack1.Count != 0 &&
                    t_stack2.Count != 0 &&
                    t_stack3.Count != 0 &&
                    t_stack4.Count != 0)
                    if (t_stack1[t_stack1.Count - 1].Cost == Cost.King &&
                        t_stack2[t_stack2.Count - 1].Cost == Cost.King &&
                        t_stack3[t_stack3.Count - 1].Cost == Cost.King &&
                        t_stack4[t_stack4.Count - 1].Cost == Cost.King)
                    {
                        reset_timer.Stop();
                        sec_timer.Stop();
                        EndGame formEndGame = new EndGame(date, userName, this);
                        formEndGame.Show();
                    }
            }

            Refresh();
        }

        private void panel_Click(object sender, EventArgs e)
        {

            if (firstStart)
            {
                sec_timer.Start();
                firstStart = false;
            }

            if (sec_timer.Enabled == false)
                return;

            if (Game.MousePosition.Y < pass + hCard)
            {
                int h = int.MaxValue;
                int y = -1;
                for (int i = 0; i < 7; i++)
                {
                    var a = Math.Abs(Game.MousePosition.X - ((wCard + pass) * i) - wCard + 30);
                    Console.WriteLine(a);

                    if (a < h)
                    {
                        h = a;
                        y = i + 1;
                    }
                }
                Console.WriteLine("-------------");
                Console.WriteLine(y);
                Console.WriteLine("-------------");
                List<Card> c;

                switch (y)
                {
                    case 1:
                        c = addStack;
                        break;
                    case 2:
                        c = twoStack;
                        break;
                    case 4:
                        c = t_stack1;
                        break;
                    case 5:
                        c = t_stack2;
                        break;
                    case 6:
                        c = t_stack3;
                        break;
                    case 7:
                        c = t_stack4;
                        break;
                    default:
                        Console.WriteLine("Выход!!!");
                        return;
                }
                if (!moveFlag)
                {
                    if (c == addStack)
                    {
                        if (c.Count != 0)
                        {
                            c[c.Count - 1].Closed = false;
                            twoStack.Add(c[c.Count - 1]);
                            c.RemoveAt(c.Count - 1);
                        }
                        else
                        {
                            for (int i = twoStack.Count - 1; i >= 0; i--)
                            {
                                twoStack[i].Closed = true;
                                c.Add(twoStack[i]);
                            }
                            twoStack.Clear();
                        }

                    }
                    else if (c == twoStack)
                    {
                        if (twoStack.Count != 0)
                        {
                            move_stack.Add(twoStack[twoStack.Count - 1]);
                            twoStack.RemoveAt(twoStack.Count - 1);
                            save_stack = twoStack;
                            moveFlag = true;
                        }
                    }else if (c == t_stack1 || c == t_stack2 || c == t_stack3 || c == t_stack4)
                    {
                        if(c.Count != 0)
                        {
                            move_stack.Add(c[c.Count - 1]);
                            c.RemoveAt(c.Count - 1);
                            save_stack = c;
                            moveFlag = true;
                        }
                        else
                        {
                            return;
                        }
                    }
                }
                else
                {
                    if (c == t_stack1 || c == t_stack2 || c == t_stack3 || c == t_stack4)
                    {
                        if (move_stack.Count > 1)
                        {
                            for (int i = 0; i < move_stack.Count; i++)
                            {
                                save_stack.Add(move_stack[i]);
                            }
                            move_stack.Clear();
                            save_stack = null;
                        }
                        else
                        if (c.Count == 0)
                        {
                            if (move_stack[0].Cost == Cost.Ace)
                            {
                                c.Add(move_stack[0]);
                                move_stack.Clear();
                            }
                        }
                        else
                        {
                            if (c[c.Count - 1].Cost + 1 == move_stack[0].Cost && c[0].Suit == move_stack[0].Suit)
                            {
                                c.Add(move_stack[0]);
                                move_stack.Clear();
                            }
                            else
                            {
                                for (int i = 0; i < move_stack.Count; i++)
                                {
                                    save_stack.Add(move_stack[i]);
                                }
                                move_stack.Clear();
                                save_stack = null;
                            }
                        }
                        moveFlag = false;
                    }
                }
            }
            else
            if (!moveFlag)
            {
                int h = int.MaxValue;
                int y = -1;
                for (int i = 0; i < 7; i++)
                {
                    var a = Math.Abs(Game.MousePosition.X - ((wCard + pass) * i) - wCard + 30);
                    Console.WriteLine(a);

                    if (a < h)
                    {
                        h = a;
                        y = i + 1;
                    }
                }
                Console.WriteLine("-------------");
                Console.WriteLine(y);
                Console.WriteLine("-------------");
                List<Card> c;

                switch (y)
                {
                    case 1:
                        c = stack1;
                        break;
                    case 2:
                        c = stack2;
                        break;
                    case 3:
                        c = stack3;
                        break;
                    case 4:
                        c = stack4;
                        break;
                    case 5:
                        c = stack5;
                        break;
                    case 6:
                        c = stack6;
                        break;
                    case 7:
                        c = stack7;
                        break;
                    default:
                        Console.WriteLine("Выход!!!");
                        return;
                }

                int mp = -1;
                int startPositionY = hCard + pass + 40;
                int g = int.MaxValue;
                for (int i = 0; i < c.Count - 1; i++)
                {
                    startPositionY += 20;
                    int q = Math.Abs(startPositionY - Game.MousePosition.Y);
                    if (q < g)
                    {
                        g = q;
                        mp = i;
                    }
                    Console.WriteLine(q);
                    startPositionY += 20;
                }

                startPositionY += (hCard / 2);
                int r = Math.Abs(startPositionY - Game.MousePosition.Y);
                if (r < g)
                    mp = c.Count - 1;

                Console.WriteLine(r);

                Console.WriteLine("-------------");
                if (mp < 0)
                    return;

                Console.WriteLine("Позиция столбца: " + y.ToString() + " Позиция карты: " + mp.ToString());


                for (int i = mp; i < c.Count; i++)
                {
                    if (c[i].Closed)
                        return;

                    move_stack.Add(c[i]);
                }


                c.RemoveRange(mp, c.Count - mp);


                save_stack = c;

                moveFlag = true;
            }
            else
            {
                int h = int.MaxValue;
                int y = -1;
                for (int i = 0; i < 7; i++)
                {
                    var a = Math.Abs(Game.MousePosition.X - ((wCard + pass) * i) - wCard + 30);
                    Console.WriteLine(a);

                    if (a < h)
                    {
                        h = a;
                        y = i + 1;
                    }
                }
                Console.WriteLine("-------------");
                Console.WriteLine(y);
                Console.WriteLine("-------------");
                List<Card> c;

                switch (y)
                {
                    case 1:
                        c = stack1;
                        break;
                    case 2:
                        c = stack2;
                        break;
                    case 3:
                        c = stack3;
                        break;
                    case 4:
                        c = stack4;
                        break;
                    case 5:
                        c = stack5;
                        break;
                    case 6:
                        c = stack6;
                        break;
                    case 7:
                        c = stack7;
                        break;
                    default:
                        Console.WriteLine("Выход!!!");
                        return;
                }
                if (c.Count == 0)
                {
                    Console.WriteLine("Стопка пустая");
                    if (move_stack[0].Cost == Cost.King)
                    {
                        Console.WriteLine("Был поствлен король");
                        for (int i = 0; i < move_stack.Count; i++)
                        {
                            c.Add(move_stack[i]);
                        }
                        move_stack.Clear();
                        save_stack = null;
                    }
                    else
                    {
                        Console.WriteLine("Пытались поставить не короля");
                        for (int i = 0; i < move_stack.Count; i++)
                        {
                            save_stack.Add(move_stack[i]);
                        }
                        move_stack.Clear();
                        save_stack = null;
                    }
                }
                else
                {
                    Console.WriteLine("Стопка не пустая");
                    if (c[c.Count - 1].Cost - 1 == move_stack[0].Cost)
                    {
                        Console.WriteLine("Стоимость подходит");
                        if (c[c.Count - 1].Color != move_stack[0].Color)
                        {
                            Console.WriteLine("Цвет подходит");
                            for (int i = 0; i < move_stack.Count; i++)
                            {
                                c.Add(move_stack[i]);
                            }
                            move_stack.Clear();
                            save_stack = null;
                        }
                        else
                        {
                            Console.WriteLine("Цвет не подходит");
                            for (int i = 0; i < move_stack.Count; i++)
                            {
                                save_stack.Add(move_stack[i]);
                            }
                            move_stack.Clear();
                            save_stack = null;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Стоимость не подходит");
                        for (int i = 0; i < move_stack.Count; i++)
                        {
                            save_stack.Add(move_stack[i]);
                        }
                        move_stack.Clear();
                        save_stack = null;
                    }
                }

                moveFlag = false;
            }
        }

        private void buttonPause_Click(object sender, EventArgs e)
        {
            if (!firstStart)
                if (sec_timer.Enabled)
                {
                    sec_timer.Stop();
                    buttonPause.Text = "Продолжить";
                    buttonPause.BackColor = Color.Green;
                }
                else
                {
                    sec_timer.Start();
                    buttonPause.Text = "Пауза";
                    buttonPause.BackColor = Color.White;
                }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            date = new DateTime(0, 0);
            sec_timer.Stop();
            sec_label.Text = date.ToString("mm:ss");
            buttonPause.Text = "Пауза";
            buttonPause.BackColor = Color.White;
            Game_Load(sender, e);
        }

        private void sec_timer_Tick(object sender, EventArgs e)
        {
            date = date.AddSeconds(1);

            sec_label.Text = date.ToString("mm:ss");
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Menu formMenu = new Menu();
            formMenu.Show();
            this.Close();
        }
    }
}
