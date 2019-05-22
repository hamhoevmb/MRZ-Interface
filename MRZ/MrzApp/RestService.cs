using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Plugin.Media;
using Plugin.Media.Abstractions;

namespace MrzApp
{
    public class RestService
    {
        HttpClient _client;

        public RestService()
        {
            _client = new HttpClient();
        }

        public async Task<MrzDto> GetMrzData()
        {
            var mediaFile = await SelectImageAsync();
            MrzDto mrzData = null;

            var content = new MultipartFormDataContent();
            content.Add(new StreamContent(mediaFile.GetStream()),
            "\"image\"",
            $"\"{mediaFile.Path}\"");


            var httpClient = new HttpClient();

            var uploadServiceBaseAddress = Constants.MrzEndpoint;

            var httpResponseMessage = await httpClient.PostAsync(uploadServiceBaseAddress, content);

            if (httpResponseMessage.IsSuccessStatusCode)
            {
                var resultContent = await httpResponseMessage.Content.ReadAsStringAsync();
                mrzData = JsonConvert.DeserializeObject<MrzDto>(resultContent);
                return mrzData;
            }

            return null;
        }

        public async Task<MediaFile> SelectImageAsync()
        {
            if (CrossMedia.Current.IsCameraAvailable && CrossMedia.Current.IsTakePhotoSupported)
            {
                MediaFile file = await CrossMedia.Current.TakePhotoAsync(new StoreCameraMediaOptions
                {
                    SaveToAlbum = true,
                    Name = $"{DateTime.Now.ToString("dd.MM.yyyy_hh.mm.ss")}.jpg"
                });

                if (file == null)
                    return null;

                return file;
            }

            return null;
        }
    }
}
