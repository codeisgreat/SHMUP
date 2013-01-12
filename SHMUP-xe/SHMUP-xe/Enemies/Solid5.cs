﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Graphics;

namespace SHMUP.Enemies
{
    class Solid5 : Enemy
    {
        float f;
        float counter = 119;
        int mode = -1;

        public Solid5(Vector2 inV2, Color topC, Color botC)
        {
            score = 40;
            damageTake = 0.025f;
            drawSize = 0.4f;

            texture = EnemyTextures.Solid5;
            base.Setup(inV2, topC, botC);
        }

        public override void update(double gameTime)
        {
            counter += 1f / 16f * (float)gameTime;

            if (counter >= 120)
            {
                counter = 0;
                mode++;
                switch (mode)
                {
                    case 0:
                        f = 0;
                        break;
                    case 1:
                        f = 0.001f;
                        break;
                    case 2:
                        f = 0;
                        break;
                    case 3:
                        f = -0.002f;
                        mode = -1;
                        break;
                }
            }

            position -= (new Vector2(0.0014f, f) / 16) * (float)gameTime;

            base.update(gameTime);
        }
    }
}
