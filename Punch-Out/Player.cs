using Punch_Out.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Punch_Out
{
    
    public class Player : Boxer
    {
        private bool canPunch;
        public Player (Point p, Bitmap Image): base(p, Image)
        {

            this.canPunch = true;
            this.Poisition.Offset(0, 140);
        }

      
        public override void Draw(Graphics g)
        {
             g.DrawImage(this.Image, this.Poisition);
        }

        
        public override void MoveDown()
        {
            if(this.Poisition.Y < 250)
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
            this.Poisition.Offset( moveSpeed, 0);
        }

        public override void MoveUp()
        {
            if (this.Poisition.Y + this.GetHeight() - 20 > this.enemy.GetPosition().Y + this.enemy.GetHeight() && this.Poisition.Y + this.GetHeight() > 320)
            {
                this.Poisition.Offset(0, -1 * moveSpeed);
            }
        }

        public override void Idle()
        {
            this.canPunch = true;
            this.Image = Resources.mac_idle;
            this.SetSTATE(STATE.IDLE);
        }

        public override void Block()
        {
            this.canPunch = true;
            SetSTATE(Boxer.STATE.BLOCK);
            this.Image = Resources.mac_block;

            
        }
        public override void Punch(bool isLeft)
        {
            if (!canPunch)
                return;
            if (isLeft)
            {
                this.SetSTATE(STATE.LEFT);
                this.Image = Resources.mac_left;
            }
            else
            {
                this.SetSTATE(STATE.RIGHT);
                this.Image = Resources.mac_right;
            }
            if (this.InRange() && enemy.checkSTATE() != Boxer.STATE.BLOCK)
            {
                enemy.TakeDamage(4);
            }
            canPunch = false;  
           
        }
    }
}
