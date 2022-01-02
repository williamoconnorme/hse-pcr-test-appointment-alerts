# HSE PCR Test Appointment Alerts

An Azure Function app that contains multiple functions for each county in Ireland that run in parallel to check appointment availability for PCR Tests on the HSE COVID-19 Test portal.

The functions send messages to several Telegram channels when appointments are found.

Telegram channel links:
- [Carlow](https://t.me/hse_pcr_test_alerts_carlow)
- [Cavan](https://t.me/hse_pcr_test_alerts_cavan)
- [Clare](https://t.me/hse_pcr_test_alerts_clare)
- [Cork](https://t.me/hse_pcr_appointment_alerts_cork)
- [Donegal](https://t.me/hse_pcr_test_alerts_donegal)
- [Dublin](https://t.me/hse_pcr_appointment_alerts_dub)
- [Galway](https://t.me/hse_pcr_test_alerts_galway)
- [Kerry](https://t.me/hse_pcr_test_alerts_kerry)
- [Kildare](https://t.me/+sZ3o-C6fPOg2YTQ0)
- [Kilkenny](https://t.me/+orGFYWP0b1oyMzU0)
- [Laois](https://t.me/hse_pcr_test_alerts_laois)
- [Leitrim](https://t.me/+IhuRv_c0eWs3MzY0)
- [Limerick](https://t.me/hse_pcr_test_alerts_limerick)
- [Longford](https://t.me/+5g2tek1deeoxOTA8)
- [Louth](https://t.me/hse_pcr_test_alerts_louth)
- [Mayo](https://t.me/+Zgd1raMEycczOWVk)
- [Meath](https://t.me/+a_WBHMOeRz1iM2I8)
- [Monaghan](https://t.me/hse_pcr_test_alerts_monaghan)
- [Offaly](https://t.me/hse_pcr_test_alerts_offaly)
- [Roscommon](https://t.me/+P2RgPb1yUiYwODRk)
- [Sligo](https://t.me/+DauRX3922pwzNGQ0)
- [Tipperary](https://t.me/hse_pcr_test_alerts_tipperary)
- [Waterford](https://t.me/+2vuLBukBbg43ZDVk)
- [Westmeath](https://t.me/+5_TDDFs2tU41M2Q0)
- [Wexford](https://t.me/hse_pcr_test_alerts_wexford)
- [Wicklow](https://t.me/hse_pcr_test_alerts_wicklow)

# Run locally
To run this locally, you need to clone the repository and update the `TelegramBotClient` with your own Telegram Bots API token
