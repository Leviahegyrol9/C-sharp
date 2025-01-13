        public class WorkerNameAndPayment

        {
            public string Name { get; set; }

            public int Payment { get; set; }

            public WorkerNameAndPayment() { }

            public WorkerNameAndPayment(string name, int payment)
            {
                Name = name;

                Payment = payment;
            }

            public override string ToString()
            {
                return $"{Name}\t{Payment}HUF";

            }

        }


