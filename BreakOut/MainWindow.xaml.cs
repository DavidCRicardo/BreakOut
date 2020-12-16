using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Input;
using System.Windows.Threading;

namespace BreakOut
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private double _angleball = 155;
        private double _speedball = 7;
        private double _speedplayer = 30;
        private int _life = 5;
        private bool once = false;
        private int _score = 0;

        List<Bonus> listaBonus = new List<Bonus>();
        List<Block> blocks = new List<Block>();
        Ball _ball = new Ball { X = 250, Y = 250 };
        Player _player = new Player { XPosition = 350 };
        DispatcherTimer time = new DispatcherTimer { Interval = TimeSpan.FromMilliseconds(0.5) };

        public MainWindow()
        {
            InitializeComponent();

            player.DataContext = _player;
            ball.DataContext = _ball;

            time.Tick += _timer_Tick;

            MessageBox.Show("START");

            lifes.Text = _life.ToString();
            score.Text = _score.ToString();

            for (int j = 0; j < 5; j++)
            {
                for (int i = 0; i < 12; i++)
                {
                    var block = new Block(MainCanvas);
                    block.MoveTo(35.0 + i * (Block.Width + 10.0), 25.0 + j * (Block.Height + 10.0));
                    blocks.Add(block);
                }
            }
        }

        public void _timer_Tick(object sender, EventArgs e)
        {
            double radians = (Math.PI / 180) * _angleball;
            Vector vector = new Vector { X = Math.Sin(radians), Y = -Math.Cos(radians) };


            _ball.X += vector.X * _speedball;
            _ball.Y += vector.Y * _speedball;

            #region Colisões
            if (_ball.Y <= 0)
            {
                _angleball = _angleball + (180 - 2 * _angleball); //cima

            } else if (_ball.X >= MainCanvas.ActualWidth - 20)
            {
                _angleball = _angleball + (0 - 2 * _angleball); // direita

            } else if (_ball.X <= 0)
            {
                _angleball = _angleball + (0 - 2 * _angleball); // esquerda

            } else if (_ball.Y >= MainCanvas.ActualHeight - 40 && _ball.X >= _player.XPosition && _ball.X <= _player.XPosition + 100)
            {
                _angleball = _angleball + (180 - 2 * _angleball);
                _ball.Y = MainCanvas.ActualHeight - 40;
            } // baixo
            #endregion

            if (_ball.Y > 600) GameReset();

            if (_life == 0) GameOver();

            var hitBlocks = blocks.Where(b => { return b.X <= _ball.X && b.X + Block.Width >= _ball.X && b.Y <= _ball.Y && b.Y + Block.Height >= _ball.Y; });
            if (hitBlocks.Any())
            {
                var hitBlock = hitBlocks.First();
                _ball.Y = hitBlock.Y + Block.Height;
                _angleball = _angleball + (180 - 2 * _angleball);
                hitBlock.Remove();
                blocks.Remove(hitBlock);

                _score += 100;
                score.Text = _score.ToString();

            }//blocks

            if ((_score == 300 || _score == 1000 || _score == 2000) && !once )
            {
                once = true;

                var bonus = new Bonus(MainCanvas);

                bonus.X = _ball.X;
                bonus.Y = _ball.Y;

                bonus.MoveTo(bonus.X, bonus.Y);
                listaBonus.Add(bonus);
            }

            var toRemove = new List<Bonus>();
            foreach (var bonus in listaBonus)
            {
                bonus.Y += 1;
                bonus.MoveTo(bonus.X, bonus.Y);

                if (bonus.X >= _player.XPosition && bonus.X <= _player.XPosition + 100 && bonus.Y == 580)
                {
                    _life += 1;
                    lifes.Text = _life.ToString();

                    toRemove.Add(bonus);
                    once = false;
                }
                else if (bonus.Y > 1000)
                {
                    toRemove.Add(bonus);
                    once = false;
                }
            }

            toRemove.ForEach(bonus =>
            {
                bonus.RemoveVisual();
                listaBonus.Remove(bonus);
            });
            toRemove.Clear();


            if (_score >= 6000) GameOver();

        }//timer.tick

        private void GameReset()
        {
            _life -= 1;
            lifes.Text = _life.ToString();

            _ball.X = 400;
            _ball.Y = 300;
            _player.XPosition = 350;
        }

        private void GameOver()
        {
            MessageBox.Show("GameOver");
            Application.Current.Shutdown();
        }

        bool mov = false;
        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (mov == true)
            {
                if (Keyboard.IsKeyDown(Key.Left))
                {
                    if (_player.XPosition <= 0)
                    {
                        _player.XPosition = 0;

                    }
                    else _player.XPosition -= _speedplayer;
                }

                if (Keyboard.IsKeyDown(Key.Right))
                {
                    if (_player.XPosition >= 690)
                    {
                        _player.XPosition = 690;
                    }
                    else _player.XPosition += _speedplayer;

                }
            }

            if (Keyboard.IsKeyDown(Key.Escape))
            {
                Application.Current.Shutdown();

            }

            if (Keyboard.IsKeyDown(Key.F3))
            {
                time.Start();
                mov = true;
            }

            if (Keyboard.IsKeyDown(Key.F4))
            {
                time.Stop();
                mov = false;
            }
        }
    }
}