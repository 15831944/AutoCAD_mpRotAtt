using mpPInterface;

namespace mpRotAtt
{
    public class Interface : IPluginInterface
    {
        private const string _Name = "mpRotAtt";
        private const string _AvailCad = "2011";
        private const string _LName = "Угол поворота атрибутов";

        private const string _Description =
            "Функция предназначена для изменения угла поворота атрибутов в выбранных блоках";

        private const string _Author = "Пекшев Александр aka Modis";
        private const string _Price = "0";

        public string Name
        {
            get { return _Name; }
        }

        public string AvailCad
        {
            get { return _AvailCad; }
        }

        public string LName
        {
            get { return _LName; }
        }

        public string Description
        {
            get { return _Description; }
        }

        public string Author
        {
            get { return _Author; }
        }

        public string Price
        {
            get { return _Price; }
        }
    }
}