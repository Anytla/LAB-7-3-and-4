using System.Text;
namespace Ferrari
{
    public class Driver
    {
        private string name;

        public Driver(string name)
        {
            this.Name = name;
        }

        public string Name
        {
            get => this.name;
            private set
            {
                Validation.ValidateIsNull(value, nameof(this.Name));

                this.name = value;
            }
        }
    }

    public interface ICar
    {
        public string Model { get; }

        public Driver Driver { get; }

        string Brakes();

        string GasPedal();
    }

    public class Ferrari : ICar
    {
        private string model;

        public Ferrari(string driver)
        {
            this.Model = "488-Spider";
            this.Driver = new Driver(driver);
        }

        public string Model
        {
            get => this.model;
            private set
            {
                Validation.ValidateIsNull(value, nameof(this.Model));

                this.model = value;
            }
        }

        public Driver Driver { get; }

        public string Brakes()
        {
            return "Brakes!";
        }

        public string GasPedal()
        {
            return "Gas!";
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append(this.Model);
            sb.Append("/");
            sb.Append(this.Brakes());
            sb.Append("/");
            sb.Append(this.GasPedal());
            sb.Append("/");
            sb.Append(this.Driver.Name);
            return sb.ToString();
        }
    }
}

