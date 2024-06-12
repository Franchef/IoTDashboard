using IoT;

namespace Infrastructure
{
    public class DeviceClient
    {
        private readonly DeviceService.DeviceServiceClient _client;

        public DeviceClient(IoT.DeviceService.DeviceServiceClient client)
        {
            _client = client;
        }

        public async Task<object> GetDeivceAsync(CancellationToken cancellationToken)
        {
            var device = await _client.GetDeviceInformationAsync(new Google.Protobuf.WellKnownTypes.Empty(), cancellationToken: cancellationToken);
            return device;
        }
    }
}
