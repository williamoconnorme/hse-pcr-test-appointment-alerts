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
            string countyUuid = "f11e7d09-6bf2-11ec-9787-02fd315c6b27";
            dynamic facilities = JsonConvert.DeserializeObject(GetCountyFacilities(countyUuid));
            facilities = facilities["data"];
            SendAppointments(facilities, telegramChatId);
        }

        [FunctionName("Cavan")]
        public async Task RunCavanAsync([TimerTrigger("*/10 * * * * *")] TimerInfo myTimer, ILogger log)
        {
            long telegramChatId = -1001551974321;
            string countyUuid = "f11fe6f7-6bf2-11ec-9787-02fd315c6b27";
            dynamic facilities = JsonConvert.DeserializeObject(GetCountyFacilities(countyUuid));
            facilities = facilities["data"];
            SendAppointments(facilities, telegramChatId);
        }

        [FunctionName("Clare")]
        public async Task RunClareAsync([TimerTrigger("*/10 * * * * *")] TimerInfo myTimer, ILogger log)
        {
            long telegramChatId = -1001629459423;
            string countyUuid = "f11fe6f7-6bf2-11ec-9787-02fd315c6b27";
            dynamic facilities = JsonConvert.DeserializeObject(GetCountyFacilities(countyUuid));
            facilities = facilities["data"];
            SendAppointments(facilities, telegramChatId);
        }

        [FunctionName("Cork")]
        public async Task RunCorkAsync([TimerTrigger("*/10 * * * * *")] TimerInfo myTimer, ILogger log)
        {
            long telegramChatId = -1001730746708;
            string countyUuid = "f122a868-6bf2-11ec-9787-02fd315c6b27";
            dynamic facilities = JsonConvert.DeserializeObject(GetCountyFacilities(countyUuid));
            facilities = facilities["data"];
            SendAppointments(facilities, telegramChatId);
        }

        [FunctionName("Donegal")]
        public async Task RunDonegalAsync([TimerTrigger("*/10 * * * * *")] TimerInfo myTimer, ILogger log)
        {
            long telegramChatId = -1001605121329;
            string countyUuid = "f123c244-6bf2-11ec-9787-02fd315c6b27";
            dynamic facilities = JsonConvert.DeserializeObject(GetCountyFacilities(countyUuid));
            facilities = facilities["data"];
            SendAppointments(facilities, telegramChatId);
        }

        [FunctionName("Dublin")]
        public async Task RunDublinAsync([TimerTrigger("*/10 * * * * *")] TimerInfo myTimer, ILogger log)
        {
            long telegramChatId = -1001681529126;
            string countyUuid = "f124eb5d-6bf2-11ec-9787-02fd315c6b27";
            dynamic facilities = JsonConvert.DeserializeObject(GetCountyFacilities(countyUuid));
            facilities = facilities["data"];
            SendAppointments(facilities, telegramChatId);
        }

        [FunctionName("Galway")]
        public async Task RunGalwayAsync([TimerTrigger("*/10 * * * * *")] TimerInfo myTimer, ILogger log)
        {
            long telegramChatId = -1001637534810;
            string countyUuid = "f126140d-6bf2-11ec-9787-02fd315c6b27";
            dynamic facilities = JsonConvert.DeserializeObject(GetCountyFacilities(countyUuid));
            facilities = facilities["data"];
            SendAppointments(facilities, telegramChatId);
        }

        [FunctionName("Kerry")]
        public async Task RunKerryAsync([TimerTrigger("*/10 * * * * *")] TimerInfo myTimer, ILogger log)
        {
            long telegramChatId = -1001585299170;
            string countyUuid = "f12739ab-6bf2-11ec-9787-02fd315c6b27";
            dynamic facilities = JsonConvert.DeserializeObject(GetCountyFacilities(countyUuid));
            facilities = facilities["data"];
            SendAppointments(facilities, telegramChatId);
        }

        [FunctionName("Kildare")]
        public async Task RunKildareAsync([TimerTrigger("*/10 * * * * *")] TimerInfo myTimer, ILogger log)
        {
            long telegramChatId = -1001783838032;
            string countyUuid = "f1286dcb-6bf2-11ec-9787-02fd315c6b27";
            dynamic facilities = JsonConvert.DeserializeObject(GetCountyFacilities(countyUuid));
            facilities = facilities["data"];
            SendAppointments(facilities, telegramChatId);
        }

        [FunctionName("Kilkenny")]
        public async Task RunKilkennyAsync([TimerTrigger("*/10 * * * * *")] TimerInfo myTimer, ILogger log)
        {
            long telegramChatId = -1001553101034;
            string countyUuid = "f129f8ea-6bf2-11ec-9787-02fd315c6b27";
            dynamic facilities = JsonConvert.DeserializeObject(GetCountyFacilities(countyUuid));
            facilities = facilities["data"];
            SendAppointments(facilities, telegramChatId);
        }

        [FunctionName("Laois")]
        public async Task RunLaoisAsync([TimerTrigger("*/10 * * * * *")] TimerInfo myTimer, ILogger log)
        {
            long telegramChatId = -1001707749370;
            string countyUuid = "f12b4e3a-6bf2-11ec-9787-02fd315c6b27";
            dynamic facilities = JsonConvert.DeserializeObject(GetCountyFacilities(countyUuid));
            facilities = facilities["data"];
            SendAppointments(facilities, telegramChatId);
        }

        [FunctionName("Leitrim")]
        public async Task RunLeitrimAsync([TimerTrigger("*/10 * * * * *")] TimerInfo myTimer, ILogger log)
        {
            long telegramChatId = -1001762557862;
            string countyUuid = "f12c84b0-6bf2-11ec-9787-02fd315c6b27";
            dynamic facilities = JsonConvert.DeserializeObject(GetCountyFacilities(countyUuid));
            facilities = facilities["data"];
            SendAppointments(facilities, telegramChatId);
        }

        [FunctionName("Limerick")]
        public async Task RunLimerickAsync([TimerTrigger("*/10 * * * * *")] TimerInfo myTimer, ILogger log)
        {
            long telegramChatId = -1001722833810;
            string countyUuid = "f12d9268-6bf2-11ec-9787-02fd315c6b27";
            dynamic facilities = JsonConvert.DeserializeObject(GetCountyFacilities(countyUuid));
            facilities = facilities["data"];
            SendAppointments(facilities, telegramChatId);
        }

        [FunctionName("Longford")]
        public async Task RunLongfordAsync([TimerTrigger("*/10 * * * * *")] TimerInfo myTimer, ILogger log)
        {
            long telegramChatId = -1001784391996;
            string countyUuid = "f12eb915-6bf2-11ec-9787-02fd315c6b27";
            dynamic facilities = JsonConvert.DeserializeObject(GetCountyFacilities(countyUuid));
            facilities = facilities["data"];
            SendAppointments(facilities, telegramChatId);
        }


        [FunctionName("Louth")]
        public async Task RunLouthAsync([TimerTrigger("*/10 * * * * *")] TimerInfo myTimer, ILogger log)
        {
            long telegramChatId = -1001707749370;
            string countyUuid = "f12fbda7-6bf2-11ec-9787-02fd315c6b27";
            dynamic facilities = JsonConvert.DeserializeObject(GetCountyFacilities(countyUuid));
            facilities = facilities["data"];
            SendAppointments(facilities, telegramChatId);
        }


        [FunctionName("Mayo")]
        public async Task RunMayoAsync([TimerTrigger("*/10 * * * * *")] TimerInfo myTimer, ILogger log)
        {
            long telegramChatId = -1001639680358;
            string countyUuid = "f13150aa-6bf2-11ec-9787-02fd315c6b27";
            dynamic facilities = JsonConvert.DeserializeObject(GetCountyFacilities(countyUuid));
            facilities = facilities["data"];
            SendAppointments(facilities, telegramChatId);
        }


        [FunctionName("Meath")]
        public async Task RunMeathAsync([TimerTrigger("*/10 * * * * *")] TimerInfo myTimer, ILogger log)
        {
            long telegramChatId = -1001381199577;
            string countyUuid = "f132ae49-6bf2-11ec-9787-02fd315c6b27";
            dynamic facilities = JsonConvert.DeserializeObject(GetCountyFacilities(countyUuid));
            facilities = facilities["data"];
            SendAppointments(facilities, telegramChatId);
        }

        [FunctionName("Monaghan")]
        public async Task RunMonaghanAsync([TimerTrigger("*/10 * * * * *")] TimerInfo myTimer, ILogger log)
        {
            long telegramChatId = -1001734558378;
            string countyUuid = "f133c6e9-6bf2-11ec-9787-02fd315c6b27";
            dynamic facilities = JsonConvert.DeserializeObject(GetCountyFacilities(countyUuid));
            facilities = facilities["data"];
            SendAppointments(facilities, telegramChatId);
        }


        [FunctionName("Offaly")]
        public async Task RunOffalyAsync([TimerTrigger("*/10 * * * * *")] TimerInfo myTimer, ILogger log)
        {
            long telegramChatId = -1001749730700;
            string countyUuid = "f134dccf-6bf2-11ec-9787-02fd315c6b27";
            dynamic facilities = JsonConvert.DeserializeObject(GetCountyFacilities(countyUuid));
            facilities = facilities["data"];
            SendAppointments(facilities, telegramChatId);
        }

        [FunctionName("Roscommon")]
        public async Task RunRoscommonAsync([TimerTrigger("*/10 * * * * *")] TimerInfo myTimer, ILogger log)
        {
            long telegramChatId = -1001547538319;
            string countyUuid = "f135f252-6bf2-11ec-9787-02fd315c6b27";
            dynamic facilities = JsonConvert.DeserializeObject(GetCountyFacilities(countyUuid));
            facilities = facilities["data"];
            SendAppointments(facilities, telegramChatId);
        }

        [FunctionName("Sligo")]
        public async Task RunSligoAsync([TimerTrigger("*/10 * * * * *")] TimerInfo myTimer, ILogger log)
        {
            long telegramChatId = -1001705346469;
            string countyUuid = "f1371c78-6bf2-11ec-9787-02fd315c6b27";
            dynamic facilities = JsonConvert.DeserializeObject(GetCountyFacilities(countyUuid));
            facilities = facilities["data"];
            SendAppointments(facilities, telegramChatId);
        }

        [FunctionName("Tipperary")]
        public async Task RunTipperaryAsync([TimerTrigger("*/10 * * * * *")] TimerInfo myTimer, ILogger log)
        {
            long telegramChatId = -1001691678940;
            string countyUuid = "f13857f5-6bf2-11ec-9787-02fd315c6b27";
            dynamic facilities = JsonConvert.DeserializeObject(GetCountyFacilities(countyUuid));
            facilities = facilities["data"];
            SendAppointments(facilities, telegramChatId);
        }

        [FunctionName("Waterford")]
        public async Task RunWaterfordAsync([TimerTrigger("*/10 * * * * *")] TimerInfo myTimer, ILogger log)
        {
            long telegramChatId = -1001507299218;
            string countyUuid = "f1398426-6bf2-11ec-9787-02fd315c6b27";
            dynamic facilities = JsonConvert.DeserializeObject(GetCountyFacilities(countyUuid));
            facilities = facilities["data"];
            SendAppointments(facilities, telegramChatId);
        }

        [FunctionName("Westmeath")]
        public async Task RunWestmeathAsync([TimerTrigger("*/10 * * * * *")] TimerInfo myTimer, ILogger log)
        {
            long telegramChatId = -1001597714902;
            string countyUuid = "f13a93db-6bf2-11ec-9787-02fd315c6b27";
            dynamic facilities = JsonConvert.DeserializeObject(GetCountyFacilities(countyUuid));
            facilities = facilities["data"];
            SendAppointments(facilities, telegramChatId);
        }

        [FunctionName("Wexford")]
        public async Task RunWexfordAsync([TimerTrigger("*/10 * * * * *")] TimerInfo myTimer, ILogger log)
        {
            long telegramChatId = -1001568993414;
            string countyUuid = "f13b96fc-6bf2-11ec-9787-02fd315c6b27";
            dynamic facilities = JsonConvert.DeserializeObject(GetCountyFacilities(countyUuid));
            facilities = facilities["data"];
            SendAppointments(facilities, telegramChatId);
        }

        [FunctionName("Wickow")]
        public async Task RunWicklowAsync([TimerTrigger("*/10 * * * * *")] TimerInfo myTimer, ILogger log)
        {
            long telegramChatId = -1001703999022;
            string countyUuid = "f13c9d18-6bf2-11ec-9787-02fd315c6b27";
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

