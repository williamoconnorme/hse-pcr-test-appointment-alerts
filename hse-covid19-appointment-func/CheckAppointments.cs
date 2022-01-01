using System;
using System.Threading.Tasks;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using RestSharp;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;

namespace hse_covid19_appointment_func
{
    public class CheckAppointments
    {
        public static ITelegramBotClient BotClient;
        public static ILogger log;

        [FunctionName("Carlow")]
        public async Task RunCarlowAsync([TimerTrigger("*/10 * * * * *")] TimerInfo myTimer, ILogger log)
        {
            long telegramChatId = -1001735840790;
            string countyUuid = "ed18c9cd-be86-44fb-86ba-8c54d55a2faa";
            dynamic facilities = JsonConvert.DeserializeObject(GetCountyFacilities(countyUuid));
            facilities = facilities["data"];
            SendAppointments(facilities, telegramChatId, log);
        }

        [FunctionName("Cavan")]
        public async Task RunCavanAsync([TimerTrigger("*/10 * * * * *")] TimerInfo myTimer, ILogger log)
        {
            long telegramChatId = -1001551974321;
            string countyUuid = "962520d3-8dc0-42e4-811b-b3225d74addb";
            dynamic facilities = JsonConvert.DeserializeObject(GetCountyFacilities(countyUuid));
            facilities = facilities["data"];
            SendAppointments(facilities, telegramChatId, log);
        }

        [FunctionName("Clare")]
        public async Task RunClareAsync([TimerTrigger("*/10 * * * * *")] TimerInfo myTimer, ILogger log)
        {
            long telegramChatId = -1001629459423;
            string countyUuid = "69111ae8-fb94-4151-b4ec-fd4ce0f605e5";
            dynamic facilities = JsonConvert.DeserializeObject(GetCountyFacilities(countyUuid));
            facilities = facilities["data"];
            SendAppointments(facilities, telegramChatId, log);
        }

        [FunctionName("Cork")]
        public async Task RunCorkAsync([TimerTrigger("*/10 * * * * *")] TimerInfo myTimer, ILogger log)
        {
            long telegramChatId = -1001730746708;
            string countyUuid = "88d1ac9e-f531-4b7a-a6d5-499e84ed4463";
            dynamic facilities = JsonConvert.DeserializeObject(GetCountyFacilities(countyUuid));
            facilities = facilities["data"];
            SendAppointments(facilities, telegramChatId, log);
        }

        [FunctionName("Donegal")]
        public async Task RunDonegalAsync([TimerTrigger("*/10 * * * * *")] TimerInfo myTimer, ILogger log)
        {
            long telegramChatId = -1001605121329;
            string countyUuid = "f961fbee-ee98-4ce3-be47-1319876fe47c";
            dynamic facilities = JsonConvert.DeserializeObject(GetCountyFacilities(countyUuid));
            facilities = facilities["data"];
            SendAppointments(facilities, telegramChatId, log);
        }

        [FunctionName("Dublin")]
        public async Task RunDublinAsync([TimerTrigger("*/10 * * * * *")] TimerInfo myTimer, ILogger log)
        {
            long telegramChatId = -1001681529126;
            string countyUuid = "446b0e00-ee77-435c-b83b-afb6dd469551";
            dynamic facilities = JsonConvert.DeserializeObject(GetCountyFacilities(countyUuid));
            facilities = facilities["data"];
            SendAppointments(facilities, telegramChatId, log);
        }

        [FunctionName("Galway")]
        public async Task RunGalwayAsync([TimerTrigger("*/10 * * * * *")] TimerInfo myTimer, ILogger log)
        {
            long telegramChatId = -1001637534810;
            string countyUuid = "b7725be0-10a9-4113-8aae-3a5a92f5e150";
            dynamic facilities = JsonConvert.DeserializeObject(GetCountyFacilities(countyUuid));
            facilities = facilities["data"];
            SendAppointments(facilities, telegramChatId, log);
        }

        [FunctionName("Kerry")]
        public async Task RunKerryAsync([TimerTrigger("*/10 * * * * *")] TimerInfo myTimer, ILogger log)
        {
            long telegramChatId = -1001585299170;
            string countyUuid = "b15b0c8e-a727-425f-b714-8fea314a4f50";
            dynamic facilities = JsonConvert.DeserializeObject(GetCountyFacilities(countyUuid));
            facilities = facilities["data"];
            SendAppointments(facilities, telegramChatId, log);
        }

        [FunctionName("Kildare")]
        public async Task RunKildareAsync([TimerTrigger("*/10 * * * * *")] TimerInfo myTimer, ILogger log)
        {
            long telegramChatId = -1001783838032;
            string countyUuid = "4a994c3c-2725-4b16-906b-d9be4d9004bc";
            dynamic facilities = JsonConvert.DeserializeObject(GetCountyFacilities(countyUuid));
            facilities = facilities["data"];
            SendAppointments(facilities, telegramChatId, log);
        }

        //[FunctionName("")]
        //public async Task RunAsync([TimerTrigger("*/10 * * * * *")] TimerInfo myTimer, ILogger log)
        //{
        //    long telegramChatId = -;
        //    string countyUuid = "";
        //    dynamic facilities = JsonConvert.DeserializeObject(GetCountyFacilities(countyUuid));
        //    facilities = facilities["data"];
        //    SendAppointments(facilities, telegramChatId, log);
        //}

        [FunctionName("Tipperary")]
        public async Task RunTipperaryAsync([TimerTrigger("*/10 * * * * *")] TimerInfo myTimer, ILogger log)
        {
            long telegramChatId = -1001691678940;
            string countyUuid = "e2d27461-9dbc-43d1-878e-061a07fa2a25";
            dynamic facilities = JsonConvert.DeserializeObject(GetCountyFacilities(countyUuid));
            facilities = facilities["data"];
            SendAppointments(facilities, telegramChatId, log);
        }

        public static string GetCountyFacilities(string countryUuid)
        {
            var client = new RestClient("https://covid19test.healthservice.ie/swiftflow.php");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("authority", "covid19test.healthservice.ie");
            request.AddHeader("pragma", "no-cache");
            request.AddHeader("cache-control", "no-cache");
            request.AddHeader("sec-ch-ua", "\" Not A;Brand\";v=\"99\", \"Chromium\";v=\"96\", \"Microsoft Edge\";v=\"96\"");
            request.AddHeader("accept", "application/json, text/plain, */*");
            request.AddHeader("content-type", "application/json");
            request.AddHeader("sec-ch-ua-mobile", "?0");
            client.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/96.0.4664.110 Safari/537.36 Edg/96.0.1054.62";
            request.AddHeader("sec-ch-ua-platform", "\"Windows\"");
            request.AddHeader("origin", "https://covid19test.healthservice.ie");
            request.AddHeader("sec-fetch-site", "same-origin");
            request.AddHeader("sec-fetch-mode", "cors");
            request.AddHeader("sec-fetch-dest", "empty");
            request.AddHeader("referer", "https://covid19test.healthservice.ie/hse-self-referral/facilities/");
            request.AddHeader("accept-language", "en-GB,en;q=0.9,en-US;q=0.8");
            var body = @"{""task"":""getConsultantsInCounty"",""county_uuid"":""" + countryUuid + @""",""flow"":""routine""}";
            request.AddParameter("application/json", body, ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
            return response.Content;
        }

        static async void SendAppointments(dynamic facilities, long telegramChatId, ILogger log)
        {
            bool slotsAvailable;
            string telegramMessage;
            Message message = null;
            bool messageSent = false;
            string telegramMessageSuffix;


            // Send Telegram message
            BotClient = new TelegramBotClient("BOT_API_TOKEN_HERE");
            telegramMessage = $"";


            foreach (dynamic facility in facilities)
            {
                var client = new RestClient("https://covid19test.healthservice.ie/swiftflow.php?future_days=1&minutes_buffer=60&enforce_future_days=1&enforce_today_or_tomorrow_only=0");
                client.Timeout = -1;
                var request = new RestRequest(Method.POST);
                request.AddHeader("authority", "covid19test.healthservice.ie");
                request.AddHeader("pragma", "no-cache");
                request.AddHeader("cache-control", "no-cache");
                request.AddHeader("sec-ch-ua", "\" Not A;Brand\";v=\"99\", \"Chromium\";v=\"96\", \"Microsoft Edge\";v=\"96\"");
                request.AddHeader("accept", "application/json, text/plain, */*");
                request.AddHeader("content-type", "application/json");
                request.AddHeader("sec-ch-ua-mobile", "?0");
                client.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/96.0.4664.110 Safari/537.36 Edg/96.0.1054.62";
                request.AddHeader("sec-ch-ua-platform", "\"Windows\"");
                request.AddHeader("origin", "https://covid19test.healthservice.ie");
                request.AddHeader("sec-fetch-site", "same-origin");
                request.AddHeader("sec-fetch-mode", "cors");
                request.AddHeader("sec-fetch-dest", "empty");
                request.AddHeader("referer", "https://covid19test.healthservice.ie/hse-self-referral/facilities/");
                request.AddHeader("accept-language", "en-GB,en;q=0.9,en-US;q=0.8");
                var body = @"{""task"":""getConsultantAvailability"",""facility_id"":""" + facility["fkey"] + @""",""type_id"":" + facility["appointment_types"][0]["id"] + @",""flow"":""routine""}";
                request.AddParameter("application/json", body, ParameterType.RequestBody);
                IRestResponse response = client.Execute(request);

                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    dynamic jsonResponse = JsonConvert.DeserializeObject(response.Content);

                    if (jsonResponse["data"]["type"]["total_slots_available"] > 0)
                    {
                        slotsAvailable = true;
                        telegramMessage += $"\n\r" + $"<b>{ jsonResponse["data"]["type"]["total_slots_available"]  }</b> slot(s) available in { facility["name"] }";
                        Console.WriteLine(string.Join(", ", jsonResponse));
                        Console.WriteLine(telegramMessage);

                        if (slotsAvailable == true)
                        {
                            telegramMessageSuffix = $"\n\n⚠️ <a href='https://covid19test.healthservice.ie/hse-self-referral/antigen-test/'>Book online</a>";

                            try
                            {

                                if (messageSent == false)
                                {
                                    message = await BotClient.SendTextMessageAsync(
                                        chatId: telegramChatId,
                                        text: telegramMessage + telegramMessageSuffix,
                                        parseMode: ParseMode.Html,
                                        disableNotification: false
                                    );
                                    messageSent = true;
                                }
                                else
                                {
                                    await BotClient.EditMessageTextAsync(
                                        chatId: telegramChatId,
                                        text: telegramMessage + telegramMessageSuffix,
                                        parseMode: ParseMode.Html,
                                        messageId: message.MessageId
                                    );
                                }
                            }
                            catch (Exception e)
                            {
                                throw new Exception(e.Message);
                            }
                        }
                    }
                    else
                    {
                        log.LogInformation($"No slots available at centre: {facility["name"]}");
                    }
                }
            }
        }
    }
}

