﻿using GUI_20212202_IJA9WQ.Logic;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace GUI_20212202_IJA9WQ.Renderer
{
    public class Display : FrameworkElement
    {
        IGameLogic logic;
        //Size area;
        public void SetupLogic(IGameLogic logic)
        {
            this.logic = logic;
        }

        //public void SetupSizes(Size area)
        //{
        //    this.area = area;
        //    this.InvalidateVisual();
        //}

        public Brush BackgroundDayBrush
        {
            get
            {
                return new ImageBrush(new BitmapImage(new Uri(Path.Combine("Images", "background_day.png"), UriKind.RelativeOrAbsolute)));
            }
        }

        public Brush LawnMoverBrush
        {
            get
            {
                return new ImageBrush(new BitmapImage(new Uri(Path.Combine("Images", "lawn_mover.png"), UriKind.RelativeOrAbsolute)));
            }
        }

        public Brush ItemShopBrush
        {
            get
            {
                return new ImageBrush(new BitmapImage(new Uri(Path.Combine("Images", "itemShop1.png"), UriKind.RelativeOrAbsolute)));
            }
        }

        protected override void OnRender(DrawingContext drawingContext)
        {
            base.OnRender(drawingContext);
            if (logic != null)
            {
                drawingContext.DrawRectangle(BackgroundDayBrush, null, new Rect(0, 0, 1025, 600));
                drawingContext.DrawRectangle(ItemShopBrush, null, new Rect(10, 10, 104, 495));

                foreach (var item in logic.LawnMovers)
                {
                    drawingContext.DrawGeometry(LawnMoverBrush, null, item.Area);
                }
            }
        }
    }
}
