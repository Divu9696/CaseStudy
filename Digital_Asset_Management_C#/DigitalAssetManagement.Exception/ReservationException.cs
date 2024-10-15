using System;

namespace DigitalAssetManagement.Exception;

public class ReservationException : System.Exception
{
        public ReservationException() { }

        // Constructor with message parameter
        public ReservationException(string message) : base(message) { }
        // Constructor with message and inner exception parameters
        public ReservationException(string message, System.Exception inner) : base(message, inner) { }    
}
