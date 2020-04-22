using FluentScheduler;

namespace Mlily.WMSInterface.Console
{
    public class SystemJobManager
    {
        private SystemJobManager()
        {
        }

        public static SystemJobManager Instance
        {
            get
            {
                return Nested.Inner;
            }
        }

        public void Start()
        {
            JobManager.Initialize(new JobRegistry());
        }

        public void Stop()
        {
            JobManager.Stop();
        }

        private static class Nested
        {
            #region Static Fields

            /// <summary>
            ///     The inner.
            /// </summary>
            internal static readonly SystemJobManager Inner = new SystemJobManager();

            #endregion
        }
    }
}