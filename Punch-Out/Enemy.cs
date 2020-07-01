using Punch_Out.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Punch_Out
{
    public class Enemy : Boxer
    {
        public Enemy (Point p, Bitmap Image): base(p, Image)
        {
            this.Poisition.Offset(0, -80);
            this.moveSpeed = 30;
        }
        public override void Block()
        {
            this.Image = Resources.block;
            this.currentSTATE = STATE.BLOCK;
        }

        public override void Idle()
        {
            this.Image = Resources.idle;
            this.currentSTATE = STATE.IDLE;
        }

        public override void Punch(bool isLeft)
        {
            if (isLeft)
            {
                this.currentSTATE = STATE.LEFT;
                this.Image = Resources.left;
            }
            else
            {
                this.currentSTATE = STATE.RIGHT;
                this.Image = Resources.right;
                
            }
            if(InRange() && this.enemy.checkSTATE() != STATE.BLOCK)
            {
                this.enemy.TakeDamage(13);                 
            }
        }

        public override void MoveDown()
        {
            if (this.Poisition.Y + this.GetHeight() + 20 <= this.enemy.GetPosition().Y + this.enemy.GetHeight() && this.Poisition.Y < 250)
            {
                this.Poisition.Offset(0, moveSpeed);
            }
        }

        public override void MoveLeft()
        {
            this.Poisition.Offset(-1 * moveSpeed, 0);
        }

        public override void MoveRight()
        {
            this.Poisition.Offset(moveSpeed, 0);
        }

        public override void MoveUp()
        {
            if(this.Poisition.Y + this.GetHeight() > 320)
            {
                this.Poisition.Offset(0, -1 * moveSpeed);
            }
        }

        public override void Draw(Graphics g)
        {
            g.DrawImage(this.Image, this.Poisition);
        }
    }
}
