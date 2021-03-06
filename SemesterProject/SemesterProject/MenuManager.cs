﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace SemesterProject
{
    public class MenuManager
    {
        Menu menu;

        public MenuManager()
        {
            menu = new Menu();
            menu.OnMenuChange += Menu_OnMenuChange;
        }

        private void Menu_OnMenuChange(object sender, EventArgs e)
        {
            XmlManager<Menu> xmlMenuManager = new XmlManager<Menu>();
            menu.UnloadStuff();
            //transition
            menu = xmlMenuManager.Load(menu.ID);
            menu.LoadStuff();
        }

        public void LoadStuff(string menuPath)
        {
            if(menuPath != String.Empty)
            {
                menu.ID = menuPath;
            }

        }

        public void UnloadStuff()
        {
            menu.UnloadStuff();
        }

        public void Update(GameTime gameTime)
        {
            menu.Update(gameTime);
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            menu.Draw(spriteBatch);
        }
    }
}
