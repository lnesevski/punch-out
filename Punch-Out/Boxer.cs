using Punch_Out.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Punch_Out
{
    public abstract class Boxer
    {
        protected Bitmap Image;
        protected Point Poisition;
        protected int Health;
        protected Boxer enemy;
        protected STATE currentSTATE;
        protected int moveSpeed = 20;
        protected bool canPunch;
        public enum STATE { IDLE, BLOCK, LEFT, RIGHT }

        public Boxer(Point p, Bitmap Image)
        {

            this.Image = Image;
            int X = (int)this.Image.Width / 2;
            int Y = (int)this.Image.Height / 2;
            this.Poisition = new Point(p.X - X, p.Y - Y);
            this.Health = 100;
            this.currentSTATE = Boxer.STATE.IDLE;
            this.canPunch = true;
        }

        public void SetEnemy(Boxer enemy)
        {
            this.enemy = enemy;
        }

        public Point GetPosition()
        {
            return this.Poisition;
        }

        public int GetWidth()
        {
            return this.Image.Width;
        }
        
        public int GetHeight()
        {
            return this.Image.Height;
        }

        public abstract void MoveUp();
        public abstract void MoveDown();
        public abstract void MoveLeft();
        public abstract void MoveRight();


        public abstract void Punch(bool isLeft);
        public abstract void Block();
        public abstract void Idle();

        public void SetSTATE(Boxer.STATE STATE)
        {
            this.currentSTATE = STATE;
            
        }

        public STATE checkSTATE()
        {
            return this.currentSTATE;
        }

        public abstract void Draw(Graphics g);
        

        public bool InRange()
        {
            int X_diff = Math.Abs(this.Poisition.X - enemy.GetPosition().X);
            int Y_diff = Math.Abs(this.Poisition.Y - enemy.GetPosition().Y);

            if (X_diff <= 40 && Y_diff <= 40)
            {
                return true;
            }

            return false;
        }

        public bool isDead()
        {
            return this.Health <= 0;
        }

        public void TakeDamage(int Damage)
        {
            this.Health -= Damage;
            if (this.Health < 0)
            {
                this.Health = 0;
            }
        }

        public int GetHealth()
        {
            return this.Health;
        }
    }
}
