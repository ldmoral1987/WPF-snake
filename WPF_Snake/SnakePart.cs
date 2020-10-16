using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

// Esta clase contiene información sobre cada parte de la serpiente
namespace WPF_Snake
{
    class SnakePart
    {
        public UIElement UiElement { get; set; }
        
        public Point Position { get; set; }

        public bool IsHead { get; set; }
    }
}
