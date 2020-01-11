using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedProject1._0
{
    class EventColorHandler
    {
        private Color _backColor;
        private Color _textColor;

        public Color BackColor
        {
            get { return _backColor; }
            private set { _backColor = value; }
        }
        public Color TextColor
        {
            get { return _textColor; }
            private set { _textColor = value; }
        }

        public EventColorHandler()
        {
            this.BackColor = Color.Gold;
            this.TextColor = Color.Gold;
        }

        public static EventColorHandler GetColorHandler(EventType type)
        {
            EventColorHandler colorHandler = new EventColorHandler();
            Color back = new Color();
            Color text = new Color();
            switch (type)
            {
                case EventType.Gaming: back = text = Color.Black; break;
                case EventType.Study: back = text = Color.CadetBlue; break;
                case EventType.Party: back = text = Color.SlateBlue; break;
                case EventType.Garbage: back = text = Color.Plum; break;
                case EventType.CommonRoom: back = text = Color.Teal; break;
                case EventType.Kitchen: back = text = Color.DarkSlateBlue; break;
                case EventType.Bathroom: back = text = Color.DarkRed; break;
                default: back = text = Color.Gold; break;
            }
            colorHandler.BackColor = back;
            colorHandler.TextColor = text;
            return colorHandler;
        }

    }
}
