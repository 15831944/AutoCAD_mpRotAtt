using mpPInterface;

namespace mpRotAtt
{
    public class Interface : IPluginInterface
    {
        public string Name => "mpRotAtt";
        public string AvailCad => "2017";
        public string LName => "Угол поворота атрибутов";
        public string Description => "Функция предназначена для изменения угла поворота атрибутов в выбранных блоках";
        public string Author => "Пекшев Александр aka Modis";
        public string Price => "0";
    }
}