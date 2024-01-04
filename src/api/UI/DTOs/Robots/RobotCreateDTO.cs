namespace MegamanApi.api.UI.DTOs.Robots
{
    public sealed class RobotCreateDTO
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public int HP { get; set; }
        public string Picture { get; set; }
    }
}