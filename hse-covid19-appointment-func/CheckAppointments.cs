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
            SendAppointments(facilities, telegramChatId);
        }

        [FunctionName("Cavan")]
        public async Task RunCavanAsync([TimerTrigger("*/10 * * * * *")] TimerInfo myTimer, ILogger log)
        {
            long telegramChatId = -1001551974321;
            string countyUuid = "962520d3-8dc0-42e4-811b-b3225d74addb";
            dynamic facilities = JsonConvert.DeserializeObject(GetCountyFacilities(countyUuid));
            facilities = facilities["data"];
            SendAppointments(facilities, telegramChatId);
        }

        [FunctionName("Clare")]
        public async Task RunClareAsync([TimerTrigger("*/10 * * * * *")] TimerInfo myTimer, ILogger log)
        {
            long telegramChatId = -1001629459423;
            string countyUuid = "69111ae8-fb94-4151-b4ec-fd4ce0f605e5";
            dynamic facilities = JsonConvert.DeserializeObject(GetCountyFacilities(countyUuid));
            facilities = facilities["data"];
            SendAppointments(facilities, telegramChatId);
        }

        [FunctionName("Cork")]
        public async Task RunCorkAsync([TimerTrigger("*/10 * * * * *")] TimerInfo myTimer, ILogger log)
        {
            long telegramChatId = -1001730746708;
            string countyUuid = "88d1ac9e-f531-4b7a-a6d5-499e84ed4463";
            dynamic facilities = JsonConvert.DeserializeObject(GetCountyFacilities(countyUuid));
            facilities = facilities["data"];
            SendAppointments(facilities, telegramChatId);
        }

        [FunctionName("Donegal")]
        public async Task RunDonegalAsync([TimerTrigger("*/10 * * * * *")] TimerInfo myTimer, ILogger log)
        {
            long telegramChatId = -1001605121329;
            string countyUuid = "f961fbee-ee98-4ce3-be47-1319876fe47c";
            dynamic facilities = JsonConvert.DeserializeObject(GetCountyFacilities(countyUuid));
            facilities = facilities["data"];
            SendAppointments(facilities, telegramChatId);
        }

        [FunctionName("Dublin")]
        public async Task RunDublinAsync([TimerTrigger("*/10 * * * * *")] TimerInfo myTimer, ILogger log)
        {
            long telegramChatId = -1001681529126;
            string countyUuid = "446b0e00-ee77-435c-b83b-afb6dd469551";
            dynamic facilities = JsonConvert.DeserializeObject(GetCountyFacilities(countyUuid));
            facilities = facilities["data"];
            SendAppointments(facilities, telegramChatId);
        }

        [FunctionName("Galway")]
        public async Task RunGalwayAsync([TimerTrigger("*/10 * * * * *")] TimerInfo myTimer, ILogger log)
        {
            long telegramChatId = -1001637534810;
            string countyUuid = "b7725be0-10a9-4113-8aae-3a5a92f5e150";
            dynamic facilities = JsonConvert.DeserializeObject(GetCountyFacilities(countyUuid));
            facilities = facilities["data"];
            SendAppointments(facilities, telegramChatId);
        }

        [FunctionName("Kerry")]
        public async Task RunKerryAsync([TimerTrigger("*/10 * * * * *")] TimerInfo myTimer, ILogger log)
        {
            long telegramChatId = -1001585299170;
            string countyUuid = "b15b0c8e-a727-425f-b714-8fea314a4f50";
            dynamic facilities = JsonConvert.DeserializeObject(GetCountyFacilities(countyUuid));
            facilities = facilities["data"];
            SendAppointments(facilities, telegramChatId);
        }

        [FunctionName("Kildare")]
        public async Task RunKildareAsync([TimerTrigger("*/10 * * * * *")] TimerInfo myTimer, ILogger log)
        {
            long telegramChatId = -1001783838032;
            string countyUuid = "4a994c3c-2725-4b16-906b-d9be4d9004bc";
            dynamic facilities = JsonConvert.DeserializeObject(GetCountyFacilities(countyUuid));
            facilities = facilities["data"];
            SendAppointments(facilities, telegramChatId);
        }

        [FunctionName("Kilkenny")]
        public async Task RunKilkennyAsync([TimerTrigger("*/10 * * * * *")] TimerInfo myTimer, ILogger log)
        {
            long telegramChatId = -1001553101034;
            string countyUuid = "af5d94d2-c27e-494a-a228-d03d4c2c2b9f";
            dynamic facilities = JsonConvert.DeserializeObject(GetCountyFacilities(countyUuid));
            facilities = facilities["data"];
            SendAppointments(facilities, telegramChatId);
        }

        [FunctionName("Laois")]
        public async Task RunLaoisAsync([TimerTrigger("*/10 * * * * *")] TimerInfo myTimer, ILogger log)
        {
            long telegramChatId = -1001707749370;
            string countyUuid = "2f6b2415-76a6-4b29-8551-77ec19988a86";
            dynamic facilities = JsonConvert.DeserializeObject(GetCountyFacilities(countyUuid));
            facilities = facilities["data"];
            SendAppointments(facilities, telegramChatId);
        }

        [FunctionName("Leitrim")]
        public async Task RunLeitrimAsync([TimerTrigger("*/10 * * * * *")] TimerInfo myTimer, ILogger log)
        {
            long telegramChatId = -1001762557862;
            string countyUuid = "2f6b2415-76a6-4b29-8551-77ec19988a86";
            dynamic facilities = JsonConvert.DeserializeObject(GetCountyFacilities(countyUuid));
            facilities = facilities["data"];
            SendAppointments(facilities, telegramChatId);
        }

        [FunctionName("Limerick")]
        public async Task RunLimerickAsync([TimerTrigger("*/10 * * * * *")] TimerInfo myTimer, ILogger log)
        {
            long telegramChatId = -1001722833810;
            string countyUuid = "2f5eb9a3-ae8c-437e-aef7-bd2957be6a7e";
            dynamic facilities = JsonConvert.DeserializeObject(GetCountyFacilities(countyUuid));
            facilities = facilities["data"];
            SendAppointments(facilities, telegramChatId);
        }

        [FunctionName("Longford")]
        public async Task RunLongfordAsync([TimerTrigger("*/10 * * * * *")] TimerInfo myTimer, ILogger log)
        {
            long telegramChatId = -1001784391996;
            string countyUuid = "40972358-e4a3-4a99-8f42-a2aee761a9f9";
            dynamic facilities = JsonConvert.DeserializeObject(GetCountyFacilities(countyUuid));
            facilities = facilities["data"];
            SendAppointments(facilities, telegramChatId);
        }


        [FunctionName("Louth")]
        public async Task RunLouthAsync([TimerTrigger("*/10 * * * * *")] TimerInfo myTimer, ILogger log)
        {
            long telegramChatId = -1001707749370;
            string countyUuid = "b773371f-bb5d-405a-9c03-6ba94b0993df";
            dynamic facilities = JsonConvert.DeserializeObject(GetCountyFacilities(countyUuid));
            facilities = facilities["data"];
            SendAppointments(facilities, telegramChatId);
        }


        [FunctionName("Mayo")]
        public async Task RunMayoAsync([TimerTrigger("*/10 * * * * *")] TimerInfo myTimer, ILogger log)
        {
            long telegramChatId = -1001639680358;
            string countyUuid = "63a79dd4-49e3-408b-bf61-0fae55c8917a";
            dynamic facilities = JsonConvert.DeserializeObject(GetCountyFacilities(countyUuid));
            facilities = facilities["data"];
            SendAppointments(facilities, telegramChatId);
        }


        [FunctionName("Meath")]
        public async Task RunMeathAsync([TimerTrigger("*/10 * * * * *")] TimerInfo myTimer, ILogger log)
        {
            long telegramChatId = -1001381199577;
            string countyUuid = "3d3136b7-8893-4226-9f28-d06967022123";
            dynamic facilities = JsonConvert.DeserializeObject(GetCountyFacilities(countyUuid));
            facilities = facilities["data"];
            SendAppointments(facilities, telegramChatId);
        }

        [FunctionName("Monaghan")]
        public async Task RunMonaghanAsync([TimerTrigger("*/10 * * * * *")] TimerInfo myTimer, ILogger log)
        {
            long telegramChatId = -1001734558378;
            string countyUuid = "d6fbc7ac-4a8b-4dba-874d-d939faf06ccb";
            dynamic facilities = JsonConvert.DeserializeObject(GetCountyFacilities(countyUuid));
            facilities = facilities["data"];
            SendAppointments(facilities, telegramChatId);
        }


        [FunctionName("Offaly")]
        public async Task RunOffalyAsync([TimerTrigger("*/10 * * * * *")] TimerInfo myTimer, ILogger log)
        {
            long telegramChatId = -1001749730700;
            string countyUuid = "24abc3c6-5e28-49fe-99f8-f3d8118cae18";
            dynamic facilities = JsonConvert.DeserializeObject(GetCountyFacilities(countyUuid));
            facilities = facilities["data"];
            SendAppointments(facilities, telegramChatId);
        }

        [FunctionName("Roscommon")]
        public async Task RunRoscommonAsync([TimerTrigger("*/10 * * * * *")] TimerInfo myTimer, ILogger log)
        {
            long telegramChatId = -1001547538319;
            string countyUuid = "ef236290-f45a-4353-869b-a66e25bd68ce";
            dynamic facilities = JsonConvert.DeserializeObject(GetCountyFacilities(countyUuid));
            facilities = facilities["data"];
            SendAppointments(facilities, telegramChatId);
        }

        [FunctionName("Sligo")]
        public async Task RunSligoAsync([TimerTrigger("*/10 * * * * *")] TimerInfo myTimer, ILogger log)
        {
            long telegramChatId = -1001705346469;
            string countyUuid = "c4f8a8c2-8ec6-49e5-937d-e0b0e8ee7e6b";
            dynamic facilities = JsonConvert.DeserializeObject(GetCountyFacilities(countyUuid));
            facilities = facilities["data"];
            SendAppointments(facilities, telegramChatId);
        }

        [FunctionName("Tipperary")]
        public async Task RunTipperaryAsync([TimerTrigger("*/10 * * * * *")] TimerInfo myTimer, ILogger log)
        {
            long telegramChatId = -1001691678940;
            string countyUuid = "e2d27461-9dbc-43d1-878e-061a07fa2a25";
            dynamic facilities = JsonConvert.DeserializeObject(GetCountyFacilities(countyUuid));
            facilities = facilities["data"];
            SendAppointments(facilities, telegramChatId);
        }

        [FunctionName("Waterford")]
        public async Task RunWaterfordAsync([TimerTrigger("*/10 * * * * *")] TimerInfo myTimer, ILogger log)
        {
            long telegramChatId = -1001507299218;
            string countyUuid = "113db5f7-00b9-4e95-83b1-ff73c27317c8";
            dynamic facilities = JsonConvert.DeserializeObject(GetCountyFacilities(countyUuid));
            facilities = facilities["data"];
            SendAppointments(facilities, telegramChatId);
        }

        [FunctionName("Wexford")]
        public async Task RunWexfordAsync([TimerTrigger("*/10 * * * * *")] TimerInfo myTimer, ILogger log)
        {
            long telegramChatId = -1001568993414;
            string countyUuid = "83ee9614-ec96-4720-9909-c9b6d8ddc616";
            dynamic facilities = JsonConvert.DeserializeObject(GetCountyFacilities(countyUuid));
            facilities = facilities["data"];
            SendAppointments(facilities, telegramChatId);
        }

        [FunctionName("Westmeath")]
        public async Task RunWestmeathAsync([TimerTrigger("*/10 * * * * *")] TimerInfo myTimer, ILogger log)
        {
            long telegramChatId = -1001597714902;
            string countyUuid = "eb4cf636-821b-47f5-b940-f86231a1edec";
            dynamic facilities = JsonConvert.DeserializeObject(GetCountyFacilities(countyUuid));
            facilities = facilities["data"];
            SendAppointments(facilities, telegramChatId);
        }

        [FunctionName("Wickow")]
        public async Task RunWicklowAsync([TimerTrigger("*/10 * * * * *")] TimerInfo myTimer, ILogger log)
        {
            long telegramChatId = -1001703999022;
            string countyUuid = "49d32785-ed2c-4a8b-ab14-585e089b2043";
            dynamic facilities = JsonConvert.DeserializeObject(GetCountyFacilities(countyUuid));
            facilities = facilities["data"];
            SendAppointments(facilities, telegramChatId);
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

        static async void SendAppointments(dynamic facilities, long telegramChatId)
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
                        Console.WriteLine($"No slots available at centre: {facility["name"]}");
                    }
                }
            }
        }
    }
}

