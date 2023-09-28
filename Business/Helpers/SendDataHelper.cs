using Core.Utilities.Results;

namespace Business.Helpers
{
    public static class SendDataHelper
    {
        private static int LastMinute = 0;

        public static IResult IsItTime(DateTime dateTime)
        {
            if (LastMinute == dateTime.Minute)
                return new ErrorResult();

            LastMinute = dateTime.Minute;
            return new SuccessResult();
        }
    }
}
