# Coinigy-API
https://coinigy.docs.apiary.io/

Coinigy's API allows you to interact with your Coinigy Account and Exchange Accounts directly,
to refresh balances, place and cancel orders, set and cancel alerts, and poll for market data.

## Examples:

```csharp

  var api = new ApiRequest("[YOUR-API-KEY]", "[YOUR-API-SECRET]");

  // Note: To see more, you can pull the repo and have a look at the Tests project to see all implementations.

  public async Task Get_Account_Info()
  {
      var result = await api.AccountDataRequest.GetAccountInfo();
  }

  public async Task Select_Account_Activities()
  {
      var result = await api.AccountDataRequest.SelectAccountActivities();
  }

  public async Task Select_Notifications()
  {
      var result = await api.AccountDataRequest.SelectNotifications();
  }

  public async Task Select_Exchange_Accounts()
  {
      var result = await api.AccountDataRequest.SelectExchangeAccounts();
  }

  public async Task Select_Account_Balances()
  {
      var result = await api.AccountDataRequest.SelectAccountBalances(new AccountModel
      {
          ShowNils = 0,
          AuthIds = ""
      });
  }

  public async Task Select_Account_Balance_History()
  {
      var result = await api.AccountDataRequest.SelectAccountBalanceHistory(new AccountBalanceHistoryModel
      {
          Date = "2016-07-01"
      });
  }

  public async Task Select_Orders()
  {
      var result = await api.AccountDataRequest.SelectOrders();
  }

  public async Task Select_Alerts()
  {
      var result = await api.AccountDataRequest.SelectAlerts();
  }

  public async Task Select_User_Watch_List()
  {
      var result = await api.AccountDataRequest.SelectUserWatchList();
  }

  public async Task Select_News_Feed()
  {
      var result = await api.AccountDataRequest.SelectNewsFeed();
  }
```
