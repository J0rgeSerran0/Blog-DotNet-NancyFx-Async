namespace Blog_DotNet_NancyFx_Async.Module
{

    using System.Threading;
    using System.Threading.Tasks;

    public class HelloWorldModule : Nancy.NancyModule
    {

        public HelloWorldModule()
        {
            Get["/", runAsync: true] = async (parameters, cancellationToken) =>
            {
                return await GetHelloWorld(cancellationToken);
            };
        }

        private async Task<string> GetHelloWorld(CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();

            return await Task.FromResult("Hello World!");
        }

    }

}