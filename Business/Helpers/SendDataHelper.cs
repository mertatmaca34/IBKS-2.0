using Core.Utilities.Results;

namespace Business.Helpers
{
    public static class SendDataHelper
    {
        private static int LastMinute = 0;

        public static IResult IsItTime()
        {
            if (LastMinute == DateTime.Now.Minute)
                return new ErrorResult();

            LastMinute = DateTime.Now.Minute;
            return new SuccessResult();
        }
    }
}
