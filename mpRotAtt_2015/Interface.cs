using System.Collections.Generic;
using ModPlusAPI.Interfaces;

namespace mpRotAtt
{
    public class Interface : IModPlusFunctionInterface
    {
        public SupportedProduct SupportedProduct => SupportedProduct.AutoCAD;
        public string Name => "mpRotAtt";
        public string AvailProductExternalVersion => "2015";
        public string ClassName => string.Empty;
        public string LName => "Угол поворота атрибутов";
        public string Description => "Функция предназначена для изменения угла поворота атрибутов в выбранных блоках";
        public string Author => "Пекшев Александр aka Modis";
        public string Price => "0";
        public bool CanAddToRibbon => true;
        public string FullDescription => string.Empty;
        public string ToolTipHelpImage => string.Empty;
        public List<string> SubFunctionsNames => new List<string>();
        public List<string> SubFunctionsLames => new List<string>();
        public List<string> SubDescriptions => new List<string>();
        public List<string> SubFullDescriptions => new List<string>();
        public List<string> SubHelpImages => new List<string>();
        public List<string> SubClassNames => new List<string>();
    }
}