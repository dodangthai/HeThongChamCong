using System;
using DevExpress.Xpo;

namespace ATINTimekeeping.Common
{

    public class CardType
    {
        public static int THE_CHAM_CONG = 1;
        public static int THE_GUI_XE = 2;
    }

    public class CardStatus
    {
        public static int SU_DUNG = 1;
        public static int KHONG_SU_DUNG = 2;
    }

    public class Action
    {
        public const int LOAD = 0;
        public const int ADD = 1;
        public const int UPDATE = 2;
        public const int DELETE = 3;
        public const int SAVE = 4;
        public const int CANCEL = 5;
        public const int SELECTED = 6;
    }

}