using Atomas2.Models.Web.BaseRes;

namespace Atomas2.Services
{
    public class ResultService<T>
    {
        public static BaseResult GetResult(Func<T> func)
        {
            try
            {
                return new BaseResult<T>(func());

            } catch (Exception ex)
            {
                return new BaseResult(false, ex.Message);
            }
        }
    }

    public class ResultService
    {
        public static BaseResult GetResult(Action action)
        {
            try
            {
                action();

                return new BaseResult(true);

            }
            catch (Exception ex)
            {
                return new BaseResult(false, ex.Message);
            }
        }
    }
}
